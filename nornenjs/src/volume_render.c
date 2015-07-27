#include "nornenjs.h"
#include "opengles.h"
#include "curl_post.hpp"
#include "socket_io_client.hpp"

static pthread_t thread_id;

static void otf_changed_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	ad->is_otf = EINA_TRUE;
	double otf = elm_slider_value_get(ad->otf_slider);
	emit_otf((float) otf);
}

static void otf_mouseup_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	if (ad->is_otf) {
		ad->is_otf = EINA_FALSE;
		double otf = elm_slider_value_get(ad->otf_slider);
		emit_otf_end((float) otf);
	}
}

// ~ Brightness
static void brightness_changed_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	ad->is_brightness = EINA_TRUE;
	double brightness = elm_slider_value_get(ad->bright_slider);
	emit_brightness((float) (brightness / 100.0));
}

static void brightness_mouseup_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	if (ad->is_brightness) {
		ad->is_brightness = EINA_FALSE;
		emit_quality();
	}
}

// ~ mouse event
static void mouse_down_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {
	Evas_Event_Mouse_Move *ev = (Evas_Event_Mouse_Move *) event_info;
	appdata_s *ad = data;

	ad->mouse_down = EINA_TRUE;

	ad->old_vector_x1 = ev->cur.canvas.x;
	ad->old_vector_y1 = ev->cur.canvas.y;
}

static void mouse_move_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {
	Evas_Event_Mouse_Move *ev = (Evas_Event_Mouse_Move *) event_info;
	appdata_s *ad = data;

	if (ad->mouse_down && !ad->multi_mouse_down) {
		dlog_print(DLOG_VERBOSE, LOG_TAG, "single mouse move");
		ad->rotation_x += (ev->cur.canvas.x - ev->prev.canvas.x) / 10.0;
		ad->rotation_y += (ev->cur.canvas.y - ev->prev.canvas.y) / 10.0;
		emit_rotation(ad->rotation_x, ad->rotation_y);
	}

	if (ad->multi_mouse_down) {
		ad->old_vector_x1 = ev->cur.canvas.x;
		ad->old_vector_y1 = ev->cur.canvas.y;
	}
}

static void mouse_up_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;

	if (ad->mouse_down) {
		emit_quality();
		ad->mouse_down = EINA_FALSE;
	}
}

// ~ Multi Mouse event
static float spacing(float x1, float y1, float x2, float y2) {

	float x = x1 - x2;
	float y = y1 - y2;

	return sqrt(x * x + y * y);
}

static void multi_mouse_down_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {
	Evas_Event_Multi_Move *ev = (Evas_Event_Multi_Move *) event_info;
	appdata_s *ad = data;

	dlog_print(DLOG_VERBOSE, LOG_TAG, "multi mouse down");

	ad->multi_mouse_down = EINA_TRUE;

	ad->old_vector_x2 = ev->cur.canvas.x;
	ad->old_vector_y2 = ev->cur.canvas.y;

	ad->old_dist = spacing(ad->old_vector_x1, ad->old_vector_y1, ad->old_vector_x2, ad->old_vector_y2);
}

static void multi_mouse_move_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {

	Evas_Event_Multi_Move *ev = (Evas_Event_Multi_Move *) event_info;
	appdata_s *ad = data;

	if (ad->multi_mouse_down) {

		ad->old_vector_x2 = ev->cur.canvas.x;
		ad->old_vector_y2 = ev->cur.canvas.y;

		ad->new_dist = spacing(ad->old_vector_x1, ad->old_vector_y1, ad->old_vector_x2, ad->old_vector_y2);

		// zoom in
		if (ad->new_dist - ad->old_dist > 15) {

			ad->old_dist = ad->new_dist;
			ad->div -= (((ad->new_dist / ad->old_dist) / 50) * 10);

			if (ad->div <= 0.2f) {
				ad->div = 0.2f;
			}

			emit_zoom(ad->div);
		// zoom out
		} else if (ad->old_dist - ad->new_dist > 15) {

			ad->old_dist = ad->new_dist;
			ad->div += (((ad->new_dist / ad->old_dist) / 50) * 10);
			if (ad->div >= 10.0f) {
				ad->div = 10.0f;
			}
			emit_zoom(ad->div);
		}
	}
}

static void multi_mouse_up_cb(void *data, Evas *e, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	if (ad->multi_mouse_down) {
		ad->multi_mouse_down = EINA_FALSE;
		emit_quality();
	}
}

// ~ Animator
static Eina_Bool anim_cb(void *data){
   appdata_s *ad = data;
   elm_glview_changed_set(ad->render_view);
   return ECORE_CALLBACK_RENEW;
}

static void destroy_anim(void *data, Evas *evas, Evas_Object *obj, void *event_info){
   Ecore_Animator *ani = data;
   ecore_animator_del(ani);
}

static void destroy_thread_cb(void *data){
	appdata_s *ad = data;
	dlog_print(DLOG_VERBOSE, LOG_TAG, "call destory thread");
	socket_io_client_close();
}

static void glview_create(appdata_s *ad){
   Evas_Object *render_view;

   ad->render_view = render_view = elm_glview_version_add(ad->box, EVAS_GL_GLES_1_X);
   evas_object_data_set(render_view, APPDATA_KEY, ad);

   elm_glview_mode_set(render_view, ELM_GLVIEW_ALPHA | ELM_GLVIEW_DEPTH);
   elm_glview_resize_policy_set(render_view, ELM_GLVIEW_RESIZE_POLICY_SCALE);
   elm_glview_render_policy_set(render_view, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

   elm_glview_init_func_set(render_view, init_gles);
   elm_glview_del_func_set(render_view, destroy_gles);
   elm_glview_render_func_set(render_view, draw_gl);
   elm_glview_resize_func_set(render_view, resize_gl);

   evas_object_size_hint_align_set(render_view, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_size_hint_weight_set(render_view, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	// ~ touch event listener
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MOUSE_DOWN, mouse_down_cb, ad);
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MOUSE_UP, mouse_up_cb, ad);
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MOUSE_MOVE, mouse_move_cb, ad);

	// ~ multi touch event listener
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MULTI_DOWN, multi_mouse_down_cb, ad);
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MULTI_MOVE, multi_mouse_move_cb, ad);
	evas_object_event_callback_add(render_view, EVAS_CALLBACK_MULTI_UP, multi_mouse_up_cb, ad);
}

static void create_volume_render_view(appdata_s *ad){
	Evas_Object *box, *bright_slider, *otf_slider;

	ad->box = box = elm_box_add(ad->nf);
	evas_object_show(box);

	// ~ bright slider
	ad->bright_slider = bright_slider = elm_slider_add(ad->win);
	evas_object_size_hint_align_set(bright_slider, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(bright_slider, 1, 0.00001);
	elm_slider_indicator_format_set(bright_slider, "%1.0f");
	elm_slider_min_max_set(bright_slider, 0, 600);
	elm_slider_value_set(bright_slider, 200);
	evas_object_smart_callback_add(bright_slider, "changed", brightness_changed_cb, ad);
	evas_object_event_callback_add(bright_slider, EVAS_CALLBACK_MOUSE_UP, brightness_mouseup_cb, ad);
	elm_box_pack_end(box, bright_slider);
	evas_object_show(bright_slider);

	// ~ render view
	glview_create(ad);
	elm_box_pack_end(box, ad->render_view);
	evas_object_show(ad->render_view);

	// ~ otf slider
	ad->otf_slider = otf_slider = elm_slider_add(ad->win);
	evas_object_size_hint_align_set(otf_slider, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(otf_slider, 0.00001, 0.00001);
	elm_slider_indicator_format_set(otf_slider, "%1.0f");
	elm_slider_min_max_set(otf_slider, 0, 165);
	elm_slider_value_set(otf_slider, 65);
	evas_object_smart_callback_add(otf_slider, "changed", otf_changed_cb, ad);
	evas_object_event_callback_add(otf_slider, EVAS_CALLBACK_MOUSE_UP, otf_mouseup_cb, ad);
	elm_box_pack_end(box, otf_slider);
	evas_object_show(otf_slider);

	ad->anim = ecore_animator_add(anim_cb, ad);
	evas_object_event_callback_add(ad->render_view, EVAS_CALLBACK_DEL, destroy_anim, ad->anim);
}

void volume_render_cb(void *data, Evas_Object *obj, void *event_info){
	int index = 0;
	appdata_s *ad = (appdata_s *)data;
	Elm_Object_Item *item = event_info, *nav_item;

	index = (int)elm_object_item_data_get(item);
	ad->volumeDataPn = get_volumeDataPn_from_index(index);

	int thread_error_number = 0;
	if ((thread_error_number = pthread_create(&thread_id, NULL, socket_io_client, ad))) {
		dlog_print(DLOG_FATAL, LOG_TAG, "thread_error_number %d", thread_error_number);
	}

	create_volume_render_view(ad);
	nav_item = elm_naviframe_item_push(ad->nf, "", NULL, NULL, ad->box, NULL);
	elm_naviframe_item_title_visible_set(nav_item, EINA_FALSE);
	elm_naviframe_item_pop_cb_set(nav_item, destroy_thread_cb, ad); // destory thread pop
}
