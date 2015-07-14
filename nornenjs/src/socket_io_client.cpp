#include "sio_client.h"
#include "socket_io_client.hpp"
#include "curl_post.hpp"

#include <functional>
#include <iostream>
#include <mutex>
#include <condition_variable>
#include <string>
#include <pthread.h>
#include <unistd.h>
#include <sstream>
#include <image_util.h>

using namespace sio;
using namespace std;

std::mutex _lock;
std::condition_variable_any _cond;
bool connect_finish = false;

#define LOG_TAG_QUEUE "nornenjs_queue"
#define VOLUME_DATA_URL "http://112.108.40.166:10000/tizen/data/"

int image_diff_count = 0;

class connection_listener
{
    sio::client &handler;

public:

    connection_listener(sio::client& h):handler(h)
    {
    	dlog_print(DLOG_VERBOSE, LOG_TAG, "Socket.io client call constructor");
    }

    void on_connected()
    {
        _lock.lock();
        _cond.notify_all();
        connect_finish = true;
        _lock.unlock();
        dlog_print(DLOG_VERBOSE, LOG_TAG, "Socket.io client connect");
    }

    void on_close(client::close_reason const& reason)
    {
        dlog_print(DLOG_VERBOSE, LOG_TAG, "Socket.io client closed");
    }

    void on_fail()
    {
        dlog_print(DLOG_VERBOSE, LOG_TAG, "Socket.io client failed");
    }
};

sio::client h;

extern "C" {
	void socket_io_client_close(){

		if(!h.connected()){
			dlog_print(DLOG_INFO, LOG_TAG_QUEUE, "Socket.io not conntected - not closed socket");
			return;
		}

		h.unbind_event("loadCudaMemory");
		h.unbind_event("tizenJpeg");
		h.close();
		dlog_print(DLOG_VERBOSE, LOG_TAG_QUEUE, "Socket.io closed");
	}
}

extern "C" {

	void socket_io_client(void *data)
	{
		appdata_s *ad = (appdata_s *)data;
		char* ch_init_json = NULL;
		char volume_data_url[] = VOLUME_DATA_URL;
		image_bind_error = SOCKET_IMAGE_BIND_ERROR;

		strcat(volume_data_url, ad->volumeDataPn);
		ch_init_json = http_post(volume_data_url);

		connection_listener l(h);
		h.set_connect_listener(std::bind(&connection_listener::on_connected, &l));
		h.set_close_listener(std::bind(&connection_listener::on_close, &l,std::placeholders::_1));
		h.set_fail_listener(std::bind(&connection_listener::on_fail, &l));
		h.connect(SOCKET_URI);

		_lock.lock();
		if(!connect_finish){
			_cond.wait(_lock);
		}
		_lock.unlock();

		std::string str_init_json(ch_init_json);
		h.emit("tizenInit", str_init_json);

		// After Memory Init. Do First tizen request image
		h.bind_event("loadCudaMemory",[&](string const& name, message::ptr const& data, bool isAck,message::ptr &ack_resp){
			_lock.lock();
			h.emit("tizenQuality", "");
			_lock.unlock();
		});

		// Image Streaming
		h.bind_event("tizenJpeg", [&](string const& name, message::ptr const& data, bool isAck,message::ptr &ack_resp){
			_lock.lock();
			int binary_data_size = data->get_map()["stream"]->get_map()["size"]->get_int();
			global_binary_data_size = binary_data_size;

			shared_ptr<const string> image_binary_data = data->get_map()["stream"]->get_map()["buffer"]->get_binary();
			string image_string = *image_binary_data;
			char* image_char = (char *) image_string.c_str();

			image_bind_error = SOCKET_IMAGE_BIND_ERROR;

			unsigned int decode_buf_size;
			image_bind_error = image_util_decode_jpeg_from_memory((unsigned char *)image_char, global_binary_data_size, IMAGE_UTIL_COLORSPACE_RGBA8888, &input_image, &image_buffer_width, &image_buffer_height, &decode_buf_size);

			if(image_diff_count == 0){
				image_diff_count+=1;
			}
			_lock.unlock();
		});

	}
}


extern "C" {
	void emit_quality(){
		h.emit("tizenQuality", "");
	}
}

extern "C"{
	void emit_otf(float otf){
		std::ostringstream otfbuf;
		otfbuf << otf;

		std::string json = "{ \"otf\" : \"" + otfbuf.str()+ "\", \"transferFlag\" : \"1\" }";
		h.emit("tizenOtf", json);
	}
}

extern "C" {
	void emit_otf_end(float otf){
		std::ostringstream otfbuf;
		otfbuf << otf;

		std::string json = "{ \"otf\" : \"" + otfbuf.str()+ "\", \"transferFlag\" : \"2\" }";
		h.emit("tizenOtf", json);
	}
}

extern "C"{
	void emit_brightness(float brightness){
		std::ostringstream brightnessbuf;
		brightnessbuf << brightness;

		std::string json = "{ \"brightness\" : \"" + brightnessbuf.str()+ "\" } ";
		h.emit("tizenBrightness", json);
	}
}

extern "C" {
	int rotationRequestCount = 0;

	void emit_rotation(float rotationX, float rotationY){
		if(rotationRequestCount == 100){
			rotationRequestCount = 0;
			return;
		}

		if( (rotationRequestCount++)%3 != 0 ){
			return;
		}

		std::ostringstream rotationXbuf;
		rotationXbuf << rotationX;

		std::ostringstream rotationYbuf;
		rotationYbuf << rotationY;

		std::string json = "{ \"rotationX\" : \"" + rotationXbuf.str() +"\", \"rotationY\" : \"" + rotationYbuf.str() + "\" } ";
		h.emit("tizenRotation", json);
	}
}


extern "C" {
	int zoomRequestCount = 0;

	void emit_zoom(float positionZ){
		if(zoomRequestCount == 100){
			zoomRequestCount = 0;

			return;
		}

		if( (zoomRequestCount++)%3 != 0 ){
			return;
		}

		std::ostringstream positionZbuf;
		positionZbuf << positionZ;

		std::string json = "{ \"positionZ\" : \"" + positionZbuf.str() +"\" } ";
		h.emit("tizenZoom", json);
	}
}

extern "C" {
	unsigned char * image_pop(){
		_lock.lock();
		if(image_diff_count == 1){
			free(output_image);
			output_image = input_image;
			image_diff_count-=1;
		}
		_lock.unlock();
		return output_image;
	}
}

extern "C"{
	void clear_image_pointer(){
		_lock.lock();
		image_diff_count = 0;
		input_image = NULL;
		dlog_print(DLOG_INFO, LOG_TAG_QUEUE, "Output Image free");
		_lock.unlock();
	}
}
