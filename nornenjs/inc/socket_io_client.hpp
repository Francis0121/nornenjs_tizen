#include "nornenjs.h"
#include <Elementary.h>
#include <dlog.h>s

static int LOOP_FLAG = 1;

#ifdef __cplusplus
extern "C"
#endif
void turn_off_flag();

#ifdef __cplusplus
extern "C"
#endif
void socket_io_client(void *data);

#ifdef __cplusplus
extern "C"
#endif
char* texture_getter();

#ifdef __cplusplus
extern "C"
#endif
void emit_quality();

#ifdef __cplusplus
extern "C"
#endif
void emit_otf(float otf);

#ifdef __cplusplus
extern "C"
#endif
void emit_otf_end(float otf);

#ifdef __cplusplus
extern "C"
#endif
void emit_brightness(float brightness);

#ifdef __cplusplus
extern "C"
#endif
void emit_rotation(float rotationX, float rotationY);

#ifdef __cplusplus
extern "C"
#endif
void emit_zoom(float positionZ);

#ifdef __cplusplus
extern "C"
#endif
void image_queue_push();

#ifdef __cplusplus
extern "C"
#endif
unsigned char * image_queue_pop();

#ifdef __cplusplus
extern "C"
#endif
int image_queue_is_null();

#ifdef __cplusplus
extern "C"
#endif
unsigned char *input_image;
unsigned char *output_image;

int image_buffer_width;
int image_buffer_height;
int global_binary_data_size;
int image_bind_error;
