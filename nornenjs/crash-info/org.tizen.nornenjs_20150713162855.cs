S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 11866
Date: 2015-07-13 16:28:55+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0xb7e8a788, r1   = 0xb7e85a58
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb4de7f40, r5   = 0xb6bf2aa8
r6   = 0xb6bf2298, r7   = 0xbef82c50
r8   = 0xb6bf2aa8, r9   = 0xb7ca22e8
r10  = 0xb6c00c00, fp   = 0xb7c6c5a0
ip   = 0xb6f76a58, sp   = 0xbef82c50
lr   = 0xb4d2b48b, pc   = 0xb4d2b4d8
cpsr = 0x40000030

Memory Information
MemTotal:   730748 KB
MemFree:    207292 KB
Buffers:     36976 KB
Cached:     162072 KB
VmPeak:      69856 KB
VmSize:      69856 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15232 KB
VmRSS:       15232 KB
VmData:      21568 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26016 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11866 TID = 11866
11866 11867 11868 

Maps Information
b2ec9000 b36c8000 rw-p [stack:11888]
b3a00000 b3a01000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a09000 b3a10000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a26000 b3a27000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a2f000 b3a31000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a39000 b3a3a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a42000 b3a59000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c00000 b3c04000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c0e000 b440d000 rw-p [stack:11867]
b440d000 b4554000 r-xp /usr/lib/driver/libMali.so
b4561000 b45b1000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b48e8000 b49b2000 r-xp /usr/lib/libCOREGL.so.4.0
b49c3000 b4b02000 r-xp /usr/lib/libicui18n.so.51.1
b4b12000 b4b17000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b20000 b4b21000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4b2a000 b4b42000 r-xp /usr/lib/libpng12.so.0.50.0
b4b4a000 b4b4d000 r-xp /usr/lib/libEGL.so.1.4
b4b55000 b4b63000 r-xp /usr/lib/libGLESv2.so.2.0
b4b6c000 b4b6e000 r-xp /usr/lib/libiniparser.so.0
b4b78000 b4b80000 r-xp /usr/lib/libui-extension.so.0.1.0
b4b81000 b4b84000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4b8c000 b4c42000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c4d000 b4c5f000 r-xp /usr/lib/libtts.so
b4c67000 b4c6e000 r-xp /usr/lib/libtbm.so.1.0.0
b4c76000 b4c7b000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c83000 b4c87000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c90000 b4c92000 r-xp /usr/lib/libdri2.so.0.0.0
b4c9a000 b4ca1000 r-xp /usr/lib/libdrm.so.2.4.0
b4caa000 b4cc0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4cc8000 b4cd0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4cd8000 b4cdd000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4ce5000 b4ce7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cef000 b4cf6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4cff000 b4d02000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4d0c000 b4d16000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d1f000 b4ddf000 r-xp /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
b4de9000 b4df3000 r-xp /lib/libnss_files-2.13.so
b4dfc000 b4e0e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4e16000 b4e2c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4e34000 b4f02000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4f19000 b4f3d000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f46000 b4f4c000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f54000 b4f62000 r-xp /usr/lib/libail.so.0.1.0
b4f6a000 b4f6c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f75000 b4f7a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f82000 b4f84000 r-xp /opt/usr/apps/org.tizen.nornenjs/lib/libboost_system.so.1.55.0
b4f8d000 b4f8e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f97000 b4f9b000 r-xp /usr/lib/libogg.so.0.7.1
b4fa3000 b4fc5000 r-xp /usr/lib/libvorbis.so.0.4.3
b4fcd000 b50b1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50c5000 b50f6000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a90000 b5b24000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b37000 b5b39000 r-xp /usr/lib/libXau.so.6.0.0
b5b41000 b5b4b000 r-xp /usr/lib/libspdy.so.0.0.0
b5b54000 b5ba0000 r-xp /usr/lib/libssl.so.1.0.0
b5bad000 b5bdb000 r-xp /usr/lib/libidn.so.11.5.44
b5be3000 b5bed000 r-xp /usr/lib/libcares.so.2.1.0
b5bf5000 b5c16000 r-xp /usr/lib/libexif.so.12.3.3
b5c29000 b5c6e000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c7c000 b5c92000 r-xp /lib/libexpat.so.1.5.2
b5c9b000 b5d80000 r-xp /usr/lib/libicuuc.so.51.1
b5d95000 b5dc9000 r-xp /usr/lib/libicule.so.51.1
b5dd2000 b5de5000 r-xp /usr/lib/libxcb.so.1.1.0
b5ded000 b5e2a000 r-xp /usr/lib/libcurl.so.4.3.0
b5e33000 b5e3c000 r-xp /usr/lib/libethumb.so.1.7.99
b5e45000 b5e47000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e4f000 b5e5c000 r-xp /usr/lib/libremix.so.0.0.0
b5e64000 b5e65000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e6d000 b5e84000 r-xp /usr/lib/liblua-5.1.so
b5e8d000 b5e94000 r-xp /usr/lib/libembryo.so.1.7.99
b5e9c000 b5ebf000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ed7000 b5f2d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f3a000 b5f8d000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f98000 b5fc0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5fc1000 b6007000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b6010000 b6023000 r-xp /usr/lib/libfribidi.so.0.3.1
b602b000 b602e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6036000 b603a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6042000 b6047000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6050000 b605a000 r-xp /usr/lib/libXext.so.6.4.0
b6062000 b6143000 r-xp /usr/lib/libX11.so.6.3.0
b614e000 b6151000 r-xp /usr/lib/libXtst.so.6.1.0
b6159000 b615f000 r-xp /usr/lib/libXrender.so.1.3.0
b6167000 b616c000 r-xp /usr/lib/libXrandr.so.2.2.0
b6174000 b6175000 r-xp /usr/lib/libXinerama.so.1.0.0
b617e000 b6186000 r-xp /usr/lib/libXi.so.6.1.0
b6187000 b618a000 r-xp /usr/lib/libXfixes.so.3.1.0
b6192000 b6194000 r-xp /usr/lib/libXgesture.so.7.0.0
b619c000 b619e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b61a6000 b61a7000 r-xp /usr/lib/libXdamage.so.1.1.0
b61b0000 b61b6000 r-xp /usr/lib/libXcursor.so.1.0.2
b61bf000 b61d8000 r-xp /usr/lib/libecore_con.so.1.7.99
b61e2000 b61e8000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61f0000 b61f8000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6200000 b6209000 r-xp /usr/lib/libedbus.so.1.7.99
b6211000 b626e000 r-xp /usr/lib/libedje.so.1.7.99
b6277000 b6288000 r-xp /usr/lib/libecore_input.so.1.7.99
b6290000 b6295000 r-xp /usr/lib/libecore_file.so.1.7.99
b629d000 b62b6000 r-xp /usr/lib/libeet.so.1.7.99
b62c7000 b62cb000 r-xp /usr/lib/libappcore-common.so.1.1
b62d3000 b639a000 r-xp /usr/lib/libevas.so.1.7.99
b63bf000 b63e0000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63e9000 b6418000 r-xp /usr/lib/libecore_x.so.1.7.99
b6422000 b6559000 r-xp /usr/lib/libelementary.so.1.7.99
b656f000 b6570000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b6578000 b657c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6587000 b658a000 r-xp /lib/libgpg-error.so.0.5.0
b6592000 b65ea000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65f4000 b6620000 r-xp /usr/lib/libsystemd.so.0.0.1
b6629000 b662b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6634000 b66ff000 r-xp /usr/lib/libxml2.so.2.7.8
b670d000 b671d000 r-xp /lib/libresolv-2.13.so
b6721000 b6737000 r-xp /lib/libz.so.1.2.5
b673f000 b6741000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6749000 b674e000 r-xp /usr/lib/libffi.so.5.0.10
b6757000 b6758000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6760000 b6763000 r-xp /lib/libattr.so.1.1.0
b676b000 b676e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6776000 b677d000 r-xp /usr/lib/libvconf.so.0.2.45
b6786000 b692e000 r-xp /usr/lib/libcrypto.so.1.0.0
b694f000 b6965000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b696d000 b69d6000 r-xp /lib/libm-2.13.so
b69df000 b6a1f000 r-xp /usr/lib/libeina.so.1.7.99
b6a28000 b6a5c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a65000 b6b39000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b45000 b6b4a000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b53000 b6b59000 r-xp /lib/librt-2.13.so
b6b62000 b6b69000 r-xp /lib/libcrypt-2.13.so
b6b99000 b6b9c000 r-xp /lib/libcap.so.2.21
b6ba4000 b6ba6000 r-xp /usr/lib/libiri.so
b6bae000 b6bcd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd5000 b6beb000 r-xp /usr/lib/libecore.so.1.7.99
b6c01000 b6c06000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c0f000 b6c26000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2f000 b6c3a000 r-xp /lib/libunwind.so.8.0.1
b6c67000 b6d82000 r-xp /lib/libc-2.13.so
b6d90000 b6d98000 r-xp /lib/libgcc_s-4.6.4.so.1
b6da0000 b6dca000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6dd3000 b6dd6000 r-xp /usr/lib/libbundle.so.0.1.22
b6dde000 b6de0000 r-xp /lib/libdl-2.13.so
b6de9000 b6dec000 r-xp /usr/lib/libsmack.so.1.0.0
b6df4000 b6ec4000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6ec5000 b6f2a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6f34000 b6f46000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f4e000 b6f62000 r-xp /lib/libpthread-2.13.so
b6f6d000 b6f6f000 r-xp /usr/lib/libdlog.so.0.0.0
b6f77000 b6f82000 r-xp /usr/lib/libaul.so.0.1.0
b6f91000 b6f94000 rw-p [stack:11868]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b7ec6000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11866)
Call Stack Count: 18
 0: process_array + 0x27 (0xb4d2b4d8) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc4d8
 1: process_object + 0x66 (0xb4d2b48b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc48b
 2: process_value + 0x4e (0xb4d2b54b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc54b
 3: process_array + 0x30 (0xb4d2b4e1) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc4e1
 4: process_object + 0x66 (0xb4d2b48b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc48b
 5: create_main_list + 0xfe (0xb4d2b757) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc757
 6: main_page_timer_cb + 0x4a (0xb4d2b7f7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc7f7
 7: (0xb6be2d61) [/usr/lib/libecore.so.1] + 0xdd61
 8: (0xb6be2e57) [/usr/lib/libecore.so.1] + 0xde57
 9: (0xb6be010b) [/usr/lib/libecore.so.1] + 0xb10b
10: ecore_main_loop_begin + 0x30 (0xb6be0691) [/usr/lib/libecore.so.1] + 0xb691
11: appcore_efl_main + 0x17e (0xb6f96387) [/usr/lib/libappcore-efl.so.1] + 0x2387
12: ui_app_main + 0xb0 (0xb657a499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
13: main + 0x146 (0xb4d2bd5b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xcd5b
14: (0xb6fd6dc7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x2dc7
15: (0xb6fd5d8f) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x1d8f
16: __libc_start_main + 0x114 (0xb6c7e82c) [/lib/libc.so.6] + 0x1782c
17: (0xb6fd60d4) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x20d4
End of Call Stack

Package Information
Package Name: org.tizen.nornenjs
Package ID : org.tizen.nornenjs
Version: 1.0.0
Package Type: rpm
App Name: Nornenjs
App ID: org.tizen.nornenjs
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
:12.284+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-13 16:26:12.284+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-13 16:26:12.294+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-13 16:26:12.294+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): [0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(596) > [0;35m* Info * req_id  - 1234431453 cmd [6][0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(604) > [0;35m* Info * task is present.....Check for TimeStamp[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(608) > [0;35m* Info * current_time in micro secs [1436772372] rotation_alaram_start_time[1436772370][0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(610) > [0;35m* Info * time_diff[2][0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(617) > [0;35m* Info * Request is Ongoing[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(729) > [0;35m* Info * Ongoing Task Present[0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-13 16:26:12.294+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-13 16:26:12.304+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-13 16:26:12.304+0900 E/CLOUD_CONTENT_SYNC_COMMON(10700): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-13 16:26:12.314+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-13 16:26:12.314+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.314+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.314+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-13 16:26:12.314+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-13 16:26:12.324+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.324+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.324+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.324+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[2][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2397) > [0;35m* Info * has Content Type [0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[4] with val[0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[2] with val[0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[1] with val[0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-13 16:26:12.334+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-13 16:26:12.334+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): [0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(596) > [0;35m* Info * req_id  - 1234431453 cmd [6][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(604) > [0;35m* Info * task is present.....Check for TimeStamp[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(608) > [0;35m* Info * current_time in micro secs [1436772372] rotation_alaram_start_time[1436772370][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(610) > [0;35m* Info * time_diff[2][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(617) > [0;35m* Info * Request is Ongoing[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(729) > [0;35m* Info * Ongoing Task Present[0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-13 16:26:12.334+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-13 16:26:12.354+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-13 16:26:12.354+0900 E/CLOUD_CONTENT_SYNC_COMMON(10700): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-13 16:26:12.354+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-13 16:26:12.354+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.364+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.364+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-13 16:26:12.364+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-13 16:26:12.364+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.364+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.374+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.374+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.374+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.374+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[2][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2397) > [0;35m* Info * has Content Type [0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[4] with val[0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[2] with val[0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[1] with val[0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-13 16:26:12.384+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-13 16:26:12.384+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): [0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(596) > [0;35m* Info * req_id  - 1234431453 cmd [6][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(604) > [0;35m* Info * task is present.....Check for TimeStamp[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(608) > [0;35m* Info * current_time in micro secs [1436772372] rotation_alaram_start_time[1436772370][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(610) > [0;35m* Info * time_diff[2][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __foreach_account_request_deinit(617) > [0;35m* Info * Request is Ongoing[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(729) > [0;35m* Info * Ongoing Task Present[0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-13 16:26:12.384+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-13 16:26:12.394+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-13 16:26:12.404+0900 E/CLOUD_CONTENT_SYNC_COMMON(10700): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-13 16:26:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-13 16:26:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-13 16:26:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-13 16:26:12.414+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.414+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.414+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[2][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2397) > [0;35m* Info * has Content Type [0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[4] with val[0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[2] with val[0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[1] with val[0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-13 16:26:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-13 16:26:12.434+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-13 16:26:12.434+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): [0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-13 16:26:12.434+0900 E/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __release_power_lock(679) > [0;31m* Critical * device_power_release_lock() success[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(316) > [0;35m* Info * Add Timer for 1min for destroying....[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _service_deinit_cloud_content_sync_service(318) > [0;35m* Info * Delete Previous Timer.....[0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-13 16:26:12.434+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-13 16:26:12.454+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-13 16:26:12.454+0900 E/CLOUD_CONTENT_SYNC_COMMON(10700): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-13 16:26:12.454+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-13 16:26:12.454+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.464+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.464+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-13 16:26:12.464+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-13 16:26:12.464+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.464+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-13 16:26:12.474+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-13 16:26:12.474+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:26:12.474+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-13 16:27:12.394+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 16:27:12.394+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-13 16:27:12.394+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-13 16:27:12.394+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-13 16:27:12.404+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-13 16:27:12.414+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-13 16:27:12.414+0900 I/CAPI_CONTENT_MEDIA_CONTENT(10700): media_content.c: media_content_disconnect(942) > [32m[10700]ref count changed to: 0
07-13 16:27:12.424+0900 I/CLOUD_CONTENT_SYNC_SERVER(10700): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-13 16:27:12.424+0900 I/CLOUD_CONTENT_SYNC_TRANS(10700): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-13 16:27:12.424+0900 I/CAPI_NETWORK_CONNECTION(10700): connection.c: connection_destroy(379) > Destroy handle: 0xb7ea41f0
07-13 16:27:12.424+0900 I/CAPI_NETWORK_CONNECTION(10700): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-13 16:27:12.424+0900 I/CAPI_NETWORK_CONNECTION(10700): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-13 16:27:12.434+0900 I/CAPI_APPFW_APPLICATION(10700): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-13 16:27:12.434+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 16:27:12.434+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 7
07-13 16:27:12.454+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 16:27:12.454+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-13 16:27:12.614+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 23
07-13 16:27:12.614+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-13 16:27:12.614+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 5902
07-13 16:27:12.614+0900 W/AUL_AMD (  452): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-13 16:27:12.634+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5902
07-13 16:27:12.634+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-13 16:27:12.634+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 16:27:12.634+0900 I/Tizen::App( 1034): (243) > App[com.samsung.cloud-content-sync-server] pid[5902] terminate event is forwarded
07-13 16:27:12.634+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 16:27:12.634+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 5902, ]
07-13 16:27:12.634+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 16:27:12.634+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-13 16:27:12.634+0900 I/Tizen::App( 1034): (512) > Not registered pid(5902)
07-13 16:27:12.634+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 5902.
07-13 16:27:12.644+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 16:27:12.644+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 5902.
07-13 16:27:12.644+0900 E/AUL     (11100): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-13 16:27:14.454+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-13 16:28:41.244+0900 E/PKGMGR_SERVER(11678): pkgmgr-server.c: main(1608) > server start
07-13 16:28:41.364+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 16:28:41.364+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 16:28:41.374+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 10590 pgid = 10590
07-13 16:28:41.374+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(10590)
07-13 16:28:41.374+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 16:28:41.374+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 16:28:41.394+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 16:28:41.394+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 16:28:41.394+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[10590] terminate event is forwarded
07-13 16:28:41.394+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 16:28:41.394+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 10590, ]
07-13 16:28:41.394+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 16:28:41.394+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 16:28:41.394+0900 I/Tizen::App( 1034): (512) > Not registered pid(10590)
07-13 16:28:41.394+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 10590.
07-13 16:28:41.414+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 10590
07-13 16:28:41.434+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 16:28:41.434+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 10590.
07-13 16:28:43.534+0900 E/PKGMGR_SERVER(11678): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 16:28:43.534+0900 E/PKGMGR_SERVER(11678): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 16:28:46.174+0900 E/PKGMGR_SERVER(11786): pkgmgr-server.c: main(1608) > server start
07-13 16:28:46.234+0900 E/PKGMGR  (11786): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-13 16:28:46.234+0900 E/PKGMGR_SERVER(11786): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-13 16:28:46.234+0900 E/PKGMGR_SERVER(11786): [0;m
07-13 16:28:46.404+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-13 16:28:46.404+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-13 16:28:46.414+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-13 16:28:46.534+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-13 16:28:46.534+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-13 16:28:46.534+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-13 16:28:48.534+0900 E/PKGMGR_SERVER(11786): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 16:28:48.694+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-13 16:28:48.694+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-13 16:28:48.694+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 16:28:48.694+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 16:28:48.714+0900 E/PKGMGR_CERT(11788): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 16:28:48.714+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 16:28:48.714+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 16:28:48.714+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 16:28:48.714+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 16:28:48.724+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 16:28:48.724+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 16:28:48.724+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 16:28:48.724+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 16:28:49.184+0900 E/rpm-installer(11788): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 16:28:50.054+0900 E/PKGMGR_INFO(11788): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 16:28:50.054+0900 E/PKGMGR_INSTALLER(11788): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 16:28:50.054+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 16:28:50.054+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 16:28:50.054+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 16:28:50.074+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 16:28:50.114+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 16:28:50.124+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 16:28:50.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 16:28:50.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 16:28:50.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 16:28:50.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 16:28:50.134+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 16:28:50.144+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 16:28:50.144+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 16:28:50.154+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 16:28:50.154+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 16:28:50.154+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 16:28:50.154+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 16:28:50.154+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (131) > Enter
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 16:28:50.164+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [1]
07-13 16:28:50.174+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 16:28:50.174+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 16:28:50.534+0900 E/PKGMGR_SERVER(11786): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 16:28:50.534+0900 E/PKGMGR_SERVER(11786): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 16:28:51.554+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 16:28:51.564+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 16:28:51.574+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 16:28:51.574+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 16:28:51.654+0900 I/CAPI_APPFW_APPLICATION(11866): app_main.c: ui_app_main(699) > app_efl_main
07-13 16:28:51.694+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 430
07-13 16:28:51.724+0900 I/UXT     (11866): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 16:28:51.744+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 16:28:51.744+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 11866.
07-13 16:28:51.744+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 11866.
07-13 16:28:51.774+0900 I/CAPI_APPFW_APPLICATION(11866): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 16:28:52.034+0900 I/CAPI_APPFW_APPLICATION(11866): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 16:28:52.044+0900 I/APP_CORE(11866): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 16:28:52.044+0900 I/APP_CORE(11866): appcore-efl.c: __do_app(511) > [APP 11866] Initial Launching, call the resume_cb
07-13 16:28:52.044+0900 I/CAPI_APPFW_APPLICATION(11866): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 16:28:52.084+0900 W/APP_CORE(11866): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 16:28:52.154+0900 I/CAPI_APPFW_APPLICATION(11866): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
07-13 16:28:52.684+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 16:28:52.684+0900 W/AUL_AMD (  452): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-13 16:28:55.044+0900 I/nornenjs(11866): Timer expired after 3.003 seconds.
07-13 16:28:55.044+0900 E/EFL     (11866): ecore<11866> ecore.c:568 _ecore_magic_fail() 
07-13 16:28:55.044+0900 E/EFL     (11866): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 16:28:55.044+0900 E/EFL     (11866): *** IN FUNCTION: ecore_timer_delay()
07-13 16:28:55.044+0900 E/EFL     (11866): ecore<11866> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 16:28:55.044+0900 E/EFL     (11866): ecore<11866> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 16:28:55.044+0900 E/EFL     (11866): *** SPANK SPANK SPANK!!!
07-13 16:28:55.044+0900 E/EFL     (11866): *** Now go fix your code. Tut tut tut!
07-13 16:28:55.494+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 16:28:55.494+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 16:28:55.504+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 11866 pgid = 11866
07-13 16:28:55.504+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(11866)
07-13 16:28:55.504+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 16:28:55.504+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 16:28:55.514+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 16:28:55.514+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 16:28:55.514+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[11866] terminate event is forwarded
07-13 16:28:55.514+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 16:28:55.514+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 11866, ]
07-13 16:28:55.514+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 16:28:55.514+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 16:28:55.514+0900 I/Tizen::App( 1034): (512) > Not registered pid(11866)
07-13 16:28:55.514+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 11866.
07-13 16:28:55.524+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 11866
07-13 16:28:55.554+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 16:28:55.554+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 11866.
07-13 16:28:55.604+0900 W/CRASH_MANAGER(11890): worker.c: worker_job(1236) > 11118666e6f72143677253
