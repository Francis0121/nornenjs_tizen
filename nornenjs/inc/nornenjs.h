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
	// ~ Default Wrapper
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *nf;
	// ~ First Loading View
	Evas_Object *image;
	Ecore_Timer *timer;
	// ~ Box O(Volume Render View)
	Ecore_Animator *anim;
	Evas_Object *box;
	Evas_Object *render_view;

	/**
	* Touch event - 3d object rotation
	*/
	Eina_Bool mouse_down : 1;
	float rotationX;
	float rotationY;

	/**
	* Multi touch event - 3d object resize
	*/
	Eina_Bool multi_mouse_down : 1;
	float oldVectorX1;
	float oldVectorY1;
	float oldVectorX2;
	float oldVectorY2;
	float newDist;
	float oldDist;
	float div;

} appdata_s;

void editfield_cb(void *data, Evas_Object *obj, void *event_info);
void volume_render_cb(void *data, Evas_Object *obj, void *event_info);

#endif /* __nornenjs_H__ */
