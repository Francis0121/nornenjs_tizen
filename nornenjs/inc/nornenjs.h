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

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *nf;
} appdata_s;

#endif /* __nornenjs_H__ */
