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

	curl_global_init(CURL_GLOBAL_ALL);
	CURL* ctx = curl_easy_init() ;

	if( NULL == ctx ){
		dlog_print(DLOG_ERROR, LOG_TAG, "Unable to initialize cURL interface");
		return;
	}

	curl_easy_setopt(ctx, CURLOPT_URL, target_url);

	curl_easy_setopt(ctx, CURLOPT_POSTFIELDS, post_data);
	curl_easy_setopt(ctx, CURLOPT_POSTFIELDSIZE, (long)strlen(post_data));

	curl_easy_setopt(ctx, CURLOPT_WRITEHEADER, stdout);
	curl_easy_setopt(ctx, CURLOPT_WRITEDATA, stdout);

	curl_slist* responseHeaders = NULL ;
	responseHeaders = curl_slist_append(responseHeaders, "Accept: application/json");
	responseHeaders = curl_slist_append(responseHeaders, "Content-Type: application/json");
	responseHeaders = curl_slist_append(responseHeaders, "charsets: utf-8");
	curl_easy_setopt(ctx ,CURLOPT_HTTPHEADER ,responseHeaders);

	dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - BEGIN: response - - -");
	res = curl_easy_perform(ctx);
	dlog_print(DLOG_VERBOSE, LOG_TAG, "- - - END: response - - -");

	if(CURLE_OK != res){
		dlog_print(DLOG_ERROR, LOG_TAG, "Error from cURL: %s", curl_easy_strerror(res));
	}

	curl_slist_free_all( responseHeaders ) ;
	curl_easy_cleanup( ctx ) ;
	curl_global_cleanup() ;

}
