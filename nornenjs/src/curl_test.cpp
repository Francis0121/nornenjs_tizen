#include "nornenjs.h"

#include<cstdio>
#include<iostream>
#include<string>
#include<sstream>

extern "C" {
	#include<curl/curl.h>
}

#define SIGN_URL "http://112.108.40.166:10000/mobile/signIn"

enum {
	ERROR_ARGS = 1 ,
	ERROR_CURL_INIT = 2
} ;

enum {
	OPTION_FALSE = 0 ,
	OPTION_TRUE = 1
} ;

enum {
	FLAG_DEFAULT = 0
} ;

const char* target_url = SIGN_URL;
const char* post_data = "{\"username\": \"nornenjs\", \"password\" : \"sg3512af@\" }";

// - - - - - - - - - - - - - - - - - - - -

void curl_test(){

	CURLcode res;
	CURL* ctx = NULL;
	curl_slist* responseHeaders = NULL ;

	curl_global_init(CURL_GLOBAL_ALL);
	ctx = curl_easy_init() ;

	if( NULL == ctx ){
		dlog_print(DLOG_ERROR, LOG_TAG, "Unable to initialize cURL interface");
		return;
	}

	responseHeaders = curl_slist_append(responseHeaders, "Accept: application/json");
	responseHeaders = curl_slist_append(responseHeaders, "Content-Type: application/json");
	responseHeaders = curl_slist_append(responseHeaders, "charsets: utf-8");

	curl_easy_setopt(ctx ,CURLOPT_HTTPHEADER ,responseHeaders);
	curl_easy_setopt(ctx, CURLOPT_URL, target_url);
	curl_easy_setopt(ctx, CURLOPT_POSTFIELDS, post_data);
	curl_easy_setopt(ctx, CURLOPT_POSTFIELDSIZE, (long)strlen(post_data));
	curl_easy_setopt(ctx, CURLOPT_WRITEHEADER, stdout);
	curl_easy_setopt(ctx, CURLOPT_WRITEDATA, stdout);

	dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - BEGIN: response - - -");
	res = curl_easy_perform(ctx);
	if(CURLE_OK != res){
		dlog_print(DLOG_ERROR, LOG_TAG, "Error from cURL: %s", curl_easy_strerror(res));
	}else{
		char *ct;
		res = curl_easy_getinfo(ctx, CURLINFO_CONTENT_TYPE, &ct);
		if((CURLE_OK == res) && ct){
			dlog_print(DLOG_VERBOSE, LOG_TAG, "Content_type %s", ct);
		}
	}
	dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - END: response - - -");

	curl_slist_free_all(responseHeaders);
	curl_easy_cleanup(ctx);
	curl_global_cleanup() ;

}
