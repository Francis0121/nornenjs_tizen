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

static Evas_Object *
create_nocontent_view(appdata_s *ad)
{
	Evas_Object *layout, *scroller;

	/* Scroller */
	scroller = elm_scroller_add(ad->nf);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* NoContent Layout */
	layout = elm_layout_add(scroller);
	elm_layout_theme_set(layout, "layout", "nocontents", "default");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_text_set(layout, "elm.text", "No Contents");

	elm_object_content_set(scroller, layout);

	return scroller;
}

void
nocontent_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *nocontent_view;

	/* No Content view */
	nocontent_view = create_nocontent_view(ad);
	elm_naviframe_item_push(ad->nf, "No Content", NULL, NULL, nocontent_view, NULL);
}
