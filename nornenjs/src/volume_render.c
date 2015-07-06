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

static Eina_Bool anim_cb(void *data){
   appdata_s *ad = data;
   elm_glview_changed_set(ad->render_view);
   return ECORE_CALLBACK_RENEW;
}

static void destroy_anim(void *data, Evas *evas, Evas_Object *obj, void *event_info){
   Ecore_Animator *ani = data;
   ecore_animator_del(ani);
}

/* Create a GLView with an OpenGL-ES 1.1 context */
static void glview_create(appdata_s *ad){

   Evas_Object *render_view;

   ad->render_view = render_view = elm_glview_version_add(ad->box, EVAS_GL_GLES_1_X);
   ELEMENTARY_GLVIEW_GLOBAL_USE(ad->render_view);
   evas_object_data_set(render_view, APPDATA_KEY, ad);

   elm_glview_mode_set(render_view, ELM_GLVIEW_ALPHA | ELM_GLVIEW_DEPTH);
   elm_glview_resize_policy_set(render_view, ELM_GLVIEW_RESIZE_POLICY_SCALE);
   elm_glview_render_policy_set(render_view, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

   elm_glview_init_func_set(render_view, init_gles);
   elm_glview_del_func_set(render_view, destroy_gles);
   elm_glview_render_func_set(render_view, draw_gl);
   elm_glview_resize_func_set(render_view, resize_gl);
}

static void create_volume_render_view(appdata_s *ad)
{
	ad->box = elm_box_add(ad->nf);
	evas_object_size_hint_weight_set(ad->box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->box, EVAS_HINT_FILL, EVAS_HINT_FILL);

	glview_create(ad);
	evas_object_size_hint_align_set(ad->render_view, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(ad->render_view, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	elm_box_pack_end(ad->box, ad->render_view);
	evas_object_show(ad->render_view);
	evas_object_show(ad->box);

	ad->anim = ecore_animator_add(anim_cb, ad);
	evas_object_event_callback_add(ad->render_view, EVAS_CALLBACK_DEL, destroy_anim, ad->anim);
}

void volume_render_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;

	int thread_error_number = 0;

	if ((thread_error_number = pthread_create(&thread_id, NULL, socket_io_client, NULL))) {
		dlog_print(DLOG_FATAL, LOG_TAG, "thread_error_number %d", thread_error_number);
	}

	create_volume_render_view(ad);
	elm_naviframe_item_push(ad->nf, "Bighead", NULL, NULL, ad->box, NULL);
}
