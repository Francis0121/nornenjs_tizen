#ifndef __nornenjs_H__
#define __nornenjs_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "nornenjs"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.nornenjs"
#endif

#define APPDATA_KEY "AppData"

typedef struct appdata {
	// ~ Default Object
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *nf;
	// ~ First page Object
	Evas_Object *image;
	Ecore_Timer *timer;
	// ~ Table Object
	Ecore_Animator *anim;
	Evas_Object *box;
	Evas_Object *table;
	Evas_Object *render_view;

} appdata_s;

void editfield_cb(void *data, Evas_Object *obj, void *event_info);
void volume_render_cb(void *data, Evas_Object *obj, void *event_info);

#endif /* __nornenjs_H__ */
