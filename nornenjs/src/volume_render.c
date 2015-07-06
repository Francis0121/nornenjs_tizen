/*
 * Copyright (c) 2013 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <Elementary_GL_Helpers.h>
#include "nornenjs.h"
#include "opengles.h"
#include "socket_io_client.hpp"

ELEMENTARY_GLVIEW_GLOBAL_DEFINE();

static pthread_t thread_id;

/* Create a GLView with an OpenGL-ES 1.1 context */
static void glview_create(appdata_s *ad){

   Evas_Object *render_view;

   dlog_print(DLOG_DEBUG, LOG_TAG, "glview_create 04");

   ad->render_view = render_view = elm_glview_version_add(ad->box, EVAS_GL_GLES_1_X);
   ELEMENTARY_GLVIEW_GLOBAL_USE(ad->render_view);
   evas_object_data_set(render_view, APPDATA_KEY, ad);

   dlog_print(DLOG_DEBUG, LOG_TAG, "glview_create 02");

   elm_glview_mode_set(render_view, ELM_GLVIEW_ALPHA | ELM_GLVIEW_DEPTH);
   elm_glview_resize_policy_set(render_view, ELM_GLVIEW_RESIZE_POLICY_RECREATE);
   elm_glview_render_policy_set(render_view, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

   dlog_print(DLOG_DEBUG, LOG_TAG, "glview_create 03");

   elm_glview_init_func_set(render_view, init_gles);
   elm_glview_del_func_set(render_view, destroy_gles);
   elm_glview_resize_func_set(render_view, resize_gl);
   elm_glview_render_func_set(render_view, draw_gl);

   dlog_print(DLOG_DEBUG, LOG_TAG, "glview_create 04");

	evas_object_size_hint_align_set(render_view, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(render_view, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(render_view);

   dlog_print(DLOG_DEBUG, LOG_TAG, "glview_create 05");
}

static void create_volume_render_view(appdata_s *ad)
{
	Evas_Object *box, *label;

	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 01");

	ad->box = box = elm_box_add(ad->nf);
	// Create a label
//	label = elm_label_add(box);
//	// Set text to the label with a tag
//	elm_object_text_set(label, "<font_size=110><color=#000000>07:26</color></font_size>");
//	// Add the label to the box
//	elm_box_pack_end(box, label);
//	// Change label visibility
//	evas_object_show(label);

//	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

	glview_create(ad);

	elm_box_pack_end(box, ad->render_view);

	evas_object_show(box);

	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 02");

	int thread_error_number = 0;

	if ((thread_error_number = pthread_create(&thread_id, NULL, socket_io_client, NULL))) {
		dlog_print(DLOG_FATAL, LOG_TAG, "thread_error_number %d", thread_error_number);
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 03");
}

void volume_render_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;

	create_volume_render_view(ad);
	elm_naviframe_item_push(ad->nf, "Bighead", NULL, NULL, ad->box, NULL);
}
