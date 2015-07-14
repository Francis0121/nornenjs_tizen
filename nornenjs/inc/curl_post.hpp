
#ifdef __cplusplus
extern "C"
#endif
int empty_volume_list_map();

#ifdef __cplusplus
extern "C"
#endif
void clear_volume_list_map();

#ifdef __cplusplus
extern "C"
#endif
void insert_map(int flag, int index, char* data);

#ifdef __cplusplus
extern "C"
#endif
char* get_volumeDataPn_from_index(int index);

#ifdef __cplusplus
extern "C"
#endif
char* get_title_from_index(int index);

#ifdef __cplusplus
extern "C"
#endif
char* http_post(char* send_url);
