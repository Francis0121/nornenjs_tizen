/*
 * +Copyright (c) 2013 Samsung Electronics Co., Ltd All Rights Reserved
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

static void
editfield_focused_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *editfield = (Evas_Object *)data;
	elm_object_signal_emit(editfield, "elm,state,focused", "");

	if (!elm_entry_is_empty(obj))
		elm_object_signal_emit(editfield, "elm,action,show,button", "");
}

static void
editfield_unfocused_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *editfield = (Evas_Object *)data;
	elm_object_signal_emit(editfield, "elm,state,unfocused", "");
	elm_object_signal_emit(editfield, "elm,action,hide,button", "");
}

static void
editfield_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *editfield = (Evas_Object *)data;

	if (!elm_entry_is_empty(obj) && elm_object_focus_get(obj))
		elm_object_signal_emit(editfield, "elm,action,show,button", "");
	else
		elm_object_signal_emit(editfield, "elm,action,hide,button", "");
}

static void
editfield_clear_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = (Evas_Object *)data;

	elm_entry_entry_set(entry, "");
}

static Evas_Object *
create_singleline_editfield_layout(Evas_Object *parent)
{
	Evas_Object *editfield, *entry, *button;

	editfield = elm_layout_add(parent);
	elm_layout_theme_set(editfield, "layout", "editfield", "singleline");
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);

	entry = elm_entry_add(editfield);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_object_part_text_set(entry, "elm.guide", "Singleline Editfield");
	evas_object_smart_callback_add(entry, "focused", editfield_focused_cb, editfield);
	evas_object_smart_callback_add(entry, "unfocused", editfield_unfocused_cb, editfield);
	evas_object_smart_callback_add(entry, "changed", editfield_changed_cb, editfield);
	evas_object_smart_callback_add(entry, "preedit,changed", editfield_changed_cb, editfield);
	elm_object_part_content_set(editfield, "elm.swallow.content", entry);

	button = elm_button_add(editfield);
	elm_object_style_set(button, "editfield_clear");
	evas_object_smart_callback_add(button, "clicked", editfield_clear_button_clicked_cb, entry);
	elm_object_part_content_set(editfield, "elm.swallow.button", button);

	return editfield;
}

static Evas_Object *
create_password_editfield_layout(Evas_Object *parent)
{
	Evas_Object *editfield, *entry, *button;

	editfield = elm_layout_add(parent);
	elm_layout_theme_set(editfield, "layout", "editfield", "singleline");
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);

	entry = elm_entry_add(editfield);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_entry_password_set(entry, EINA_TRUE);
	elm_object_part_text_set(entry, "elm.guide", "Password Editfield");
	evas_object_smart_callback_add(entry, "focused", editfield_focused_cb, editfield);
	evas_object_smart_callback_add(entry, "unfocused", editfield_unfocused_cb, editfield);
	evas_object_smart_callback_add(entry, "changed", editfield_changed_cb, editfield);
	evas_object_smart_callback_add(entry, "preedit,changed", editfield_changed_cb, editfield);
	elm_object_part_content_set(editfield, "elm.swallow.content", entry);

	button = elm_button_add(editfield);
	elm_object_style_set(button, "editfield_clear");
	evas_object_smart_callback_add(button, "clicked", editfield_clear_button_clicked_cb, entry);
	elm_object_part_content_set(editfield, "elm.swallow.button", button);

	return editfield;
}

static Evas_Object *
create_editfield_view(appdata_s *ad)
{
	Evas_Object *main_scroller, *main_box, *editfield;

	/* For organizing the Application Store application, you need to add a scroller to the base layout,
	 * since the total height of the layout will be greater than the screen size,
	 * and you will therefore need to scroll the screen contents up and down.
	 *
	 * If the layout is larger than the screen, the scroller makes the view itself scrollable.
	 * */
	main_scroller = elm_scroller_add(ad->nf);
	elm_scroller_bounce_set(main_scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_origin_reverse_set(main_scroller, EINA_FALSE, EINA_TRUE);
	evas_object_size_hint_weight_set(main_scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(main_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(main_scroller);

	main_box = elm_box_add(main_scroller);
	evas_object_size_hint_align_set(main_box, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(main_box, EVAS_HINT_EXPAND, 0.0);
	evas_object_show(main_box);

	editfield = create_singleline_editfield_layout(main_box);
	elm_box_pack_end(main_box, editfield);
	evas_object_show(editfield);

	editfield = create_password_editfield_layout(main_box);
	elm_box_pack_end(main_box, editfield);
	evas_object_show(editfield);

	elm_object_content_set(main_scroller, main_box);

	return main_scroller;
}

void
editfield_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *editfield_view;

	/* Editfield view */
	editfield_view = create_editfield_view(ad);
	elm_naviframe_item_push(ad->nf, "Editfield", NULL, NULL, editfield_view, NULL);
}
