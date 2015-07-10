#include "nornenjs.h"

#ifdef __cplusplus
extern "C"
#endif
void socket_io_client_close();

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
unsigned char * image_pop();

#ifdef __cplusplus
extern "C"
#endif
void clear_image_pointer();

unsigned char *input_image;
unsigned char *output_image;

int image_buffer_width;
int image_buffer_height;
int global_binary_data_size;
int image_bind_error;
