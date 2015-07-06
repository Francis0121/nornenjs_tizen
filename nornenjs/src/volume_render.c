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

#include "nornenjs.h"
#include "opengles.h"
#include "socket_io_client.hpp"

static pthread_t thread_id;

/* Create a GLView with an OpenGL-ES 1.1 context */
static Evas_Object * glview_create(appdata_s *ad){
   Evas_Object *render_view;

   render_view = elm_glview_version_add(ad->nf, EVAS_GL_GLES_1_X);
   evas_object_data_set(render_view, APPDATA_KEY, ad);

   elm_glview_mode_set(render_view, ELM_GLVIEW_ALPHA | ELM_GLVIEW_DEPTH);
   elm_glview_resize_policy_set(render_view, ELM_GLVIEW_RESIZE_POLICY_RECREATE);
   elm_glview_render_policy_set(render_view, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

   elm_glview_init_func_set(render_view, init_gles);
   elm_glview_del_func_set(render_view, destroy_gles);
   elm_glview_resize_func_set(render_view, resize_gl);
   elm_glview_render_func_set(render_view, draw_gl);

   return render_view;
}

static Evas_Object * create_volume_render_view(appdata_s *ad)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 01");

	ad->render_view = glview_create(ad);
	evas_object_size_hint_align_set(ad->render_view, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(ad->render_view, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->render_view);

	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 03");

	int thread_error_number = 0;

	if ((thread_error_number = pthread_create(&thread_id, NULL, socket_io_client, NULL))) {
		dlog_print(DLOG_FATAL, LOG_TAG, "thread_error_number %d", thread_error_number);
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "create_volume_render_view 04");

	return ad->render_view;
}

void volume_render_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;

	Evas_Object *volume_render_view;
	volume_render_view = create_volume_render_view(ad);
	elm_naviframe_item_push(ad->nf, "Bighead", NULL, NULL, volume_render_view, NULL);
}
