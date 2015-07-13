#include "nornenjs.h"

#include<cstdio>
#include<iostream>
#include<string>
#include<sstream>
#include<curl/curl.h>

const char* post_data = "{\"username\": \"nornenjs\", \"password\" : \"sg3512af@\" }";

static size_t WriteCallback(void *contents, size_t size, size_t nmemb, void *userp){
    ((std::string*)userp)->append((char*)contents, size * nmemb);
    return size * nmemb;
}

extern "C" {
	char* http_post(char* send_url){

		CURLcode res;
		CURL* ctx = NULL;
		curl_slist* responseHeaders = NULL ;
		std::string readBuffer;
		char* chRead;

		curl_global_init(CURL_GLOBAL_ALL);
		ctx = curl_easy_init() ;

		if( NULL == ctx ){
			dlog_print(DLOG_ERROR, LOG_TAG, "Unable to initialize cURL interface");
			return NULL;
		}

		responseHeaders = curl_slist_append(responseHeaders, "Accept: application/json");
		responseHeaders = curl_slist_append(responseHeaders, "Content-Type: application/json");
		responseHeaders = curl_slist_append(responseHeaders, "charsets: utf-8");

		curl_easy_setopt(ctx ,CURLOPT_HTTPHEADER ,responseHeaders);
		curl_easy_setopt(ctx, CURLOPT_URL, send_url);
		curl_easy_setopt(ctx, CURLOPT_POSTFIELDS, post_data);
		curl_easy_setopt(ctx, CURLOPT_POSTFIELDSIZE, (long)strlen(post_data));

		curl_easy_setopt(ctx, CURLOPT_WRITEFUNCTION, WriteCallback);
		curl_easy_setopt(ctx, CURLOPT_WRITEDATA, &readBuffer);

		dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - BEGIN: response - - -");
		res = curl_easy_perform(ctx);
		if(CURLE_OK != res){
			dlog_print(DLOG_ERROR, LOG_TAG, "Error from cURL: %s", curl_easy_strerror(res));
		}else{
			char *ct;
			res = curl_easy_getinfo(ctx, CURLINFO_CONTENT_TYPE, &ct);
			if((CURLE_OK == res) && ct){
				dlog_print(DLOG_VERBOSE, LOG_TAG, "Content_type %s", ct);
			}
		}
		dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - END: response - - -");

		curl_slist_free_all(responseHeaders);
		curl_easy_cleanup(ctx);
		curl_global_cleanup() ;

		chRead = strdup(readBuffer.c_str());
		return chRead;
	}
}
