#include <tizen.h>
#include "nornenjs.h"
#include "curl_post.hpp"
#include "json.h"

#define VOLUME_LIST_URL "http://112.108.40.166:10000/tizen/list"

#define TIMEOUT 3.0
#define DELAY	3.0

static double initial_time = 0;

static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part)
{
	int index = (int) data;
	return get_title_from_index(index);
}

static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info) {
	ui_app_exit();
}

static double get_current_time(void) {
	return ecore_time_get() - initial_time;
}

// ~ Back Button Active 시 가장 마지막에 대한 화면을 지금 mainList로 해주는 역할을 수행함. (아니면 해당 부분을 종료하도록함)
static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it){
	Evas_Object *win = (Evas_Object *)data;
	elm_win_lower(win);
	return EINA_FALSE;
}

static Evas_Object * create_main_list(appdata_s *ad) {
	static Elm_Genlist_Item_Class itc;
	Evas_Object *genlist;
	int i = 0, x = 0, length;
	char* response_buffer;
	json_value *object_map, *volumes, *volume;
	json_value *title_map, *volumeDataPn_map;
	char *post_data = "{}";

	response_buffer = http_post(VOLUME_LIST_URL, post_data);
	dlog_print(DLOG_VERBOSE, LOG_TAG, "Response data %s", response_buffer);

	object_map = json_parse(response_buffer, strlen(response_buffer));
	if(object_map->type == json_object){

		volumes = object_map->u.object.values[0].value;
		length = volumes->u.array.length;

		clear_volume_list_map();

		for(x=0; x<length; x++){
			volume = volumes->u.array.values[x];

			volumeDataPn_map = volume->u.object.values[0].value;
			dlog_print(DLOG_VERBOSE, LOG_TAG, "int: %s\n", volumeDataPn_map->u.string.ptr);

			title_map = volume->u.object.values[3].value;
			dlog_print(DLOG_VERBOSE, LOG_TAG, "string: %s\n", title_map->u.string.ptr);

			insert_map(1, x, volumeDataPn_map->u.string.ptr);
			insert_map(2, x, title_map->u.string.ptr);
		}
	}

	json_value_free(object_map);


	genlist = elm_genlist_add(ad->nf);
	evas_object_size_hint_weight_set(genlist, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(genlist, EVAS_HINT_FILL, EVAS_HINT_FILL);

	itc.item_style = "default";
	itc.func.text_get = gl_text_get_cb;
	itc.func.content_get = NULL;
	itc.func.state_get = NULL;
	itc.func.del = NULL;

	for (i = 0; i < length; i++) {
		elm_genlist_item_append(genlist, &itc, (void *) i, NULL, ELM_GENLIST_ITEM_NONE, volume_render_cb, ad);
	}
	evas_object_show(genlist);

	return genlist;
}

static Eina_Bool main_page_timer_cb(void *data EINA_UNUSED) {
	appdata_s *ad = data;
	Evas_Object *main_list;
	Elm_Object_Item *nf_it;

	dlog_print(DLOG_INFO, LOG_TAG, "Timer expired after %0.3f seconds.",
			get_current_time());

	ecore_timer_delay(ad->timer, DELAY);
	ad->timer = NULL;

	/* Main list */
	main_list = create_main_list(ad);
	nf_it = elm_naviframe_item_push(ad->nf, "Volume Rendering List", NULL, NULL, main_list, NULL);
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, ad->win);

	/* Change main-> list*/
	evas_object_hide(ad->image);
	evas_object_show(main_list);

	return ECORE_CALLBACK_CANCEL;
}

static void app_get_resource(const char *res_file_in, char *res_path_out,
		int res_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

static Evas_Object * create_image_from_resource(appdata_s *ad, const char *res_file_in) {
	Evas_Object *image;
	char image_path[PATH_MAX] = { 0, };
	app_get_resource(res_file_in, image_path, PATH_MAX);

	Evas* canvas = evas_object_evas_get(ad->nf);
	image = evas_object_image_filled_add(canvas);
	evas_object_image_file_set(image, image_path, NULL);
	evas_object_move(image, 0, 0);
	evas_object_resize(image, 480, 800);

	return image;
}

static void create_base_gui(appdata_s *ad) {

	//To develop a GL application, you have to call elm_config_accel_preference_set() before creating a window which makes an application to use GPU.
	// !important
	elm_config_accel_preference_set("opengl");

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_HIDE);
	evas_object_smart_callback_add(ad->win, "delete,request",win_delete_request_cb, NULL);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Naviframe */
	ad->nf = elm_naviframe_add(ad->conform);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, ad);
	evas_object_size_hint_weight_set(ad->nf, EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->nf);
	evas_object_show(ad->nf);

	/* Image */
	ad->image = create_image_from_resource(ad, "main.png");
	evas_object_show(ad->image);

	/* Timer */
	initial_time = ecore_time_get();
	ecore_timer_add(TIMEOUT, main_page_timer_cb, ad);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
