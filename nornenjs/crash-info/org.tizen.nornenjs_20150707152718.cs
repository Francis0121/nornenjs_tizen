S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 8666
Date: 2015-07-07 15:27:18+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb123c4f8

Register Information
r0   = 0xb18bce00, r1   = 0xb12374c8
r2   = 0x00000800, r3   = 0xb123c4f8
r4   = 0x001e6000, r5   = 0x00000130
r6   = 0x00002600, r7   = 0x000000f3
r8   = 0x00038000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82318
lr   = 0xb4436d84, pc   = 0xb4436f94
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     91148 KB
Buffers:     46772 KB
Cached:     251688 KB
VmPeak:      98652 KB
VmSize:      98648 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22756 KB
VmRSS:       22752 KB
VmData:      44372 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 8666 TID = 8666
8666 8668 8669 8690 8691 8692 

Maps Information
b1bd5000 b23d4000 rw-p [stack:8692]
b23d5000 b2bd4000 rw-p [stack:8691]
b2ecc000 b36cb000 rw-p [stack:8690]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:8668]
b4410000 b4557000 r-xp /usr/lib/driver/libMali.so
b4564000 b45b4000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b48eb000 b49b5000 r-xp /usr/lib/libCOREGL.so.4.0
b49c6000 b4b05000 r-xp /usr/lib/libicui18n.so.51.1
b4b15000 b4b1a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b23000 b4b24000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4b2d000 b4b45000 r-xp /usr/lib/libpng12.so.0.50.0
b4b4d000 b4b50000 r-xp /usr/lib/libEGL.so.1.4
b4b58000 b4b66000 r-xp /usr/lib/libGLESv2.so.2.0
b4b6f000 b4b71000 r-xp /usr/lib/libiniparser.so.0
b4b7b000 b4b83000 r-xp /usr/lib/libui-extension.so.0.1.0
b4b84000 b4b87000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4b8f000 b4c45000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c50000 b4c62000 r-xp /usr/lib/libtts.so
b4c6a000 b4c71000 r-xp /usr/lib/libtbm.so.1.0.0
b4c79000 b4c7e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c86000 b4c8a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c93000 b4c95000 r-xp /usr/lib/libdri2.so.0.0.0
b4c9d000 b4ca4000 r-xp /usr/lib/libdrm.so.2.4.0
b4cad000 b4cc3000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4ccb000 b4cd3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4cdb000 b4ce0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4ce8000 b4cea000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cf2000 b4cf9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d02000 b4d05000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4d0f000 b4d19000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d22000 b4ddf000 r-xp /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
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
b6f91000 b6f94000 rw-p [stack:8669]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8149000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b8149000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8666)
Call Stack Count: 1
 0: (0xb4436f94) [/usr/lib/driver/libEGL.so] + 0x26f94
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
0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __foreach_account_request_deinit(608) > [0;35m* Info * current_time in micro secs [1436250371] rotation_alaram_start_time[1436250371][0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __foreach_account_request_deinit(610) > [0;35m* Info * time_diff[0][0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __foreach_account_request_deinit(617) > [0;35m* Info * Request is Ongoing[0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(729) > [0;35m* Info * Ongoing Task Present[0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-07 15:26:11.220+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-07 15:26:11.240+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-07 15:26:11.240+0900 E/CLOUD_CONTENT_SYNC_COMMON( 8445): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-07 15:26:11.240+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-07 15:26:11.240+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:11.250+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.250+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-07 15:26:11.250+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-07 15:26:11.260+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.260+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:11.260+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[2][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2397) > [0;35m* Info * has Content Type [0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[4] with val[0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[2] with val[0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[1] with val[0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-07 15:26:11.270+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-07 15:26:11.280+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-07 15:26:11.280+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): [0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-07 15:26:11.280+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(679) > [0;31m* Critical * device_power_release_lock() success[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(316) > [0;35m* Info * Add Timer for 1min for destroying....[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(318) > [0;35m* Info * Delete Previous Timer.....[0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-07 15:26:11.280+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-07 15:26:11.300+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-07 15:26:11.300+0900 E/CLOUD_CONTENT_SYNC_COMMON( 8445): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-07 15:26:11.300+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-07 15:26:11.300+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:11.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-07 15:26:11.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-07 15:26:11.320+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.320+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:11.320+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:11.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:11.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:13.000+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-07 15:26:13.010+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/alarm-server, ret : 0
07-07 15:26:13.010+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/alarm-server, ret : 0
07-07 15:26:13.010+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-07 15:26:13.020+0900 W/AUL_AMD (  452): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 8445
07-07 15:26:13.030+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_expired(1223) > alarm_id[1174318770] is expired.
07-07 15:26:13.030+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1174318770, next duetime: 1436253973
07-07 15:26:13.030+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:36:28 (UTC).
07-07 15:26:13.030+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:26:13.040+0900 E/AUL_AMD (  452): amd_launch.c: __real_send(761) > send fail to client
07-07 15:26:13.040+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(8445), cmd(0)
07-07 15:26:13.040+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: __service_app_control_cb(523) > [0;35m* Info * Service already running.....[0;m
07-07 15:26:13.050+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: __service_app_control_cb(527) > [0;35m* Info * Operation present...op [http://tizen.org/appcontrol/data/alarm_id][0;m
07-07 15:26:13.050+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: __service_app_control_cb(534) > [0;35m* Info * alarm operation: http://tizen.org/appcontrol/data/alarm_id[0;m
07-07 15:26:13.050+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: __service_app_control_cb(539) > [0;35m* Info * alarm_id [1174318770][0;m
07-07 15:26:13.050+0900 I/CLOUD_CONTENT_SYNC_TRANS( 8445): cs_transport_connection.c: _transport_connection_get_wifi_state(79) > [0;35m* Info * Wifi Status [2][0;m
07-07 15:26:13.050+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _get_content_type_for_polling(552) > [0;35m* Info * Including All type as well[0;m
07-07 15:26:13.060+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_fill_media_db(1427) > [0;31m* Critical * Invalid parameters[0;m
07-07 15:26:13.060+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __request_power_lock(704) > [0;31m* Critical * device_power_request_lock() success[0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __start_power_lock_timer(645) > [0;35m* Info * Add Timer for 9. 5 min for power lock....[0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: _server_task_manager_generate_reqid_and_write_to_hash_table(808) > [0;35m* Info * Adding cmd [6] req_id [1784061126][0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[71] with val[1][0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_refresh_once(1389) > [0;35m* Info * loop_started [1][0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_refresh_once(1412) > [0;35m* Info * refresh_data->use_dtmd [0][0;m
07-07 15:26:13.060+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[71] with val[1][0;m
07-07 15:26:13.060+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_util.c: _server_util_is_wifi_only_and_disabled_for_content(498) > [0;31m* Critical * Invalid Content Type[0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __server_noti_manager_refresh_by_content_type(2506) > [0;35m* Info * Refrreshing Content Type [64][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __server_noti_manager_refresh_by_content_type(2521) > [0;35m* Info * refresh_data->use_dtmd [0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[2][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[64] with val[0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2397) > [0;35m* Info * has Content Type [0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[4] with val[0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[2] with val[0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[1] with val[0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: _server_noti_manager_process_refresh_response(2419) > [0;35m* Info * Pending Content Type [0][0;m
07-07 15:26:13.070+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __end_refresh(883) > [0;35m* Info * Ending refresh......[0;m
07-07 15:26:13.080+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __end_refresh(888) > [0;31m* Critical * Refresh failed err_code [27]
07-07 15:26:13.080+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): [0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __remove_if_read_count_zero(557) > [0;35m* Info * Removing param from hash[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-07 15:26:13.080+0900 E/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(679) > [0;31m* Critical * device_power_release_lock() success[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(302) > [0;35m* Info * is_deactivate [1][0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(316) > [0;35m* Info * Add Timer for 1min for destroying....[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _service_deinit_cloud_content_sync_service(318) > [0;35m* Info * Delete Previous Timer.....[0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_set_refreshing(368) > [0;35m* Info * setting content_type[0] with val[0][0;m
07-07 15:26:13.080+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(729) > [0;35m* Info * Starting Downloading.................[0;m
07-07 15:26:13.100+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(734) > [0;35m* Info * Refreshing thumbnail_cover_cache.................[0;m
07-07 15:26:13.110+0900 E/CLOUD_CONTENT_SYNC_COMMON( 8445): cs_common_storage_manager.c: _common_storage_manager_get_file_list_for_thumbails(2843) > [0;31m* Critical * Invalid Params[0;m
07-07 15:26:13.110+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(353) > [0;35m* Info * _common_storage_manager_get_file_list_for_thumbails failed[0;m
07-07 15:26:13.110+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:13.110+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:13.110+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(737) > [0;35m* Info * __download_thumbnail_cover_cache failed - 19[0;m
07-07 15:26:13.110+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache_after_polling(740) > [0;35m* Info * Refreshing thumbnail_cover_cache failed cases............[0;m
07-07 15:26:13.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_thumbnail_manager.c: _server_thumbnail_manager_bulk_thumbnail_request(329) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:13.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __download_thumbnail_cover_cache(459) > [0;35m* Info * _server_thumbnail_manager_bulk_thumbnail_request failed[0;m
07-07 15:26:13.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_bulk_cover_download(2230) > [0;35m* Info * _common_storage_manager_get_sync_content_info_list failed[0;m
07-07 15:26:13.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:13.140+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_content_sync_manager.c: _server_content_sync_manager_upload_retry(1852) > [0;35m* Info * No files to be uploaded[0;m
07-07 15:26:59.730+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-07 15:26:59.730+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-07 15:26:59.730+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-07 15:27:00.300+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-07 15:27:00.380+0900 I/CAPI_APPFW_APPLICATION( 8666): app_main.c: ui_app_main(699) > app_efl_main
07-07 15:27:00.410+0900 I/UXT     ( 8666): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-07 15:27:00.430+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-07 15:27:00.430+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 419
07-07 15:27:00.450+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 8666.
07-07 15:27:00.460+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 8666.
07-07 15:27:00.480+0900 I/CAPI_APPFW_APPLICATION( 8666): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-07 15:27:00.710+0900 I/CAPI_APPFW_APPLICATION( 8666): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-07 15:27:00.720+0900 I/APP_CORE( 8666): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-07 15:27:00.720+0900 I/APP_CORE( 8666): appcore-efl.c: __do_app(511) > [APP 8666] Initial Launching, call the resume_cb
07-07 15:27:00.720+0900 I/CAPI_APPFW_APPLICATION( 8666): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-07 15:27:00.760+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8666
07-07 15:27:00.790+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:27:00.800+0900 W/APP_CORE( 8666): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-07 15:27:00.800+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 8666"
07-07 15:27:00.820+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-07 15:27:00.840+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-07 15:27:00.840+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:27:00.860+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:27:00.900+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-07 15:27:00.900+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-07 15:27:03.270+0900 I/MALI    ( 8666): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d188f0] swap changed from async to sync
07-07 15:27:03.710+0900 I/nornenjs( 8666): Timer expired after 3.001 seconds.
07-07 15:27:03.710+0900 E/EFL     ( 8666): ecore<8666> ecore.c:568 _ecore_magic_fail() 
07-07 15:27:03.710+0900 E/EFL     ( 8666): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-07 15:27:03.710+0900 E/EFL     ( 8666): *** IN FUNCTION: ecore_timer_delay()
07-07 15:27:03.710+0900 E/EFL     ( 8666): ecore<8666> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-07 15:27:03.710+0900 E/EFL     ( 8666): ecore<8666> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-07 15:27:03.710+0900 E/EFL     ( 8666): *** SPANK SPANK SPANK!!!
07-07 15:27:03.710+0900 E/EFL     ( 8666): *** Now go fix your code. Tut tut tut!
07-07 15:27:03.740+0900 E/EFL     ( 8666): evas_main<8666> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:27:03.760+0900 E/EFL     ( 8666): evas_main<8666> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:27:05.040+0900 E/socket.io( 8666): 566: Connected.
07-07 15:27:05.040+0900 E/socket.io( 8666): 554: On handshake, sid
07-07 15:27:05.040+0900 E/socket.io( 8666): 651: Received Message type(connect)
07-07 15:27:05.040+0900 E/socket.io( 8666): 489: On Connected
07-07 15:27:05.040+0900 F/sio_packet( 8666): accept()
07-07 15:27:05.040+0900 E/socket.io( 8666): 743: encoded paylod length: 18
07-07 15:27:05.050+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:05.140+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:05.140+0900 F/sio_packet( 8666): accept()
07-07 15:27:05.140+0900 E/socket.io( 8666): 743: encoded paylod length: 21
07-07 15:27:05.140+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:05.200+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:05.200+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:13.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-07 15:27:13.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-07 15:27:13.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-07 15:27:13.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-07 15:27:13.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:27:13.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:27:13.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:27:13.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:27:13.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-07 15:27:13.720+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-07 15:27:13.730+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-07 15:27:13.750+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-07 15:27:13.750+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 8445): media_content.c: media_content_disconnect(942) > [32m[8445]ref count changed to: 0
07-07 15:27:13.770+0900 I/CLOUD_CONTENT_SYNC_SERVER( 8445): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-07 15:27:13.770+0900 I/CLOUD_CONTENT_SYNC_TRANS( 8445): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-07 15:27:13.780+0900 I/CAPI_NETWORK_CONNECTION( 8445): connection.c: connection_destroy(379) > Destroy handle: 0xb89d2cd0
07-07 15:27:13.780+0900 I/CAPI_NETWORK_CONNECTION( 8445): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-07 15:27:13.780+0900 I/CAPI_NETWORK_CONNECTION( 8445): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-07 15:27:13.850+0900 I/CAPI_APPFW_APPLICATION( 8445): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-07 15:27:13.860+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:27:13.860+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 7
07-07 15:27:13.870+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:27:13.870+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-07 15:27:14.050+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 23
07-07 15:27:14.050+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-07 15:27:14.050+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 8445
07-07 15:27:14.050+0900 W/AUL_AMD (  452): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-07 15:27:14.060+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-07 15:27:14.060+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 8445
07-07 15:27:14.060+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:27:14.060+0900 I/Tizen::App( 1034): (243) > App[com.samsung.cloud-content-sync-server] pid[8445] terminate event is forwarded
07-07 15:27:14.060+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:27:14.060+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 8445, ]
07-07 15:27:14.060+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:27:14.060+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-07 15:27:14.060+0900 I/Tizen::App( 1034): (512) > Not registered pid(8445)
07-07 15:27:14.060+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 8445.
07-07 15:27:14.070+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:27:14.070+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 8445.
07-07 15:27:14.070+0900 E/AUL     ( 8730): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-07 15:27:15.870+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-07 15:27:15.960+0900 F/sio_packet( 8666): accept()
07-07 15:27:15.960+0900 E/socket.io( 8666): 743: encoded paylod length: 56
07-07 15:27:15.960+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:15.990+0900 F/sio_packet( 8666): accept()
07-07 15:27:15.990+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:15.990+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.010+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.010+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.020+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.020+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.030+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.030+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.030+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.040+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.050+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.050+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.050+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.050+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.070+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.070+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.080+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.080+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.080+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.090+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.090+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.090+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.110+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.110+0900 E/socket.io( 8666): 743: encoded paylod length: 56
07-07 15:27:16.110+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.110+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.110+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.130+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.130+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.140+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.140+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.150+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.150+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.160+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.160+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.170+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.170+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.180+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.180+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.190+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.190+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.190+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.190+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.190+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.210+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.210+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.210+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.220+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.220+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.230+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.230+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.230+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.240+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.240+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.240+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.250+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.250+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.250+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.250+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.270+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.270+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.270+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.280+0900 E/socket.io( 8666): 743: encoded paylod length: 56
07-07 15:27:16.280+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.290+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.290+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.290+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.300+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.300+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.300+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.310+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.310+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.320+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.330+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.330+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.330+0900 E/socket.io( 8666): 743: encoded paylod length: 21
07-07 15:27:16.330+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.330+0900 F/sio_packet( 8666): accept()
07-07 15:27:16.330+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:16.340+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.340+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.340+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:16.380+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.380+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:16.410+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:16.410+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.080+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.080+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.080+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.090+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.090+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.090+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.100+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.100+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.100+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.120+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.120+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.150+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.150+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.160+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.160+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.170+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.170+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.170+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.180+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.180+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.180+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.200+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.200+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.200+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.200+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.200+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.210+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.210+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.220+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.220+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.220+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.230+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.230+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.230+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.230+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.240+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.240+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.240+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.250+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.250+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.250+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.250+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.250+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.260+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.270+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.270+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.270+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.280+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.280+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.280+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.290+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.290+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.300+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.310+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.310+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.310+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.310+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.320+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.320+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.320+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.330+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.330+0900 E/socket.io( 8666): 743: encoded paylod length: 57
07-07 15:27:17.340+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.340+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.340+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.350+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.350+0900 F/sio_packet( 8666): accept()
07-07 15:27:17.350+0900 E/socket.io( 8666): 743: encoded paylod length: 21
07-07 15:27:17.350+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.360+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.360+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.370+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:17.370+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.370+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.370+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.370+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.380+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.380+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:17.420+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:17.420+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:18.470+0900 F/sio_packet( 8666): accept()
07-07 15:27:18.480+0900 E/socket.io( 8666): 743: encoded paylod length: 76
07-07 15:27:18.480+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:18.500+0900 F/sio_packet( 8666): accept()
07-07 15:27:18.500+0900 E/socket.io( 8666): 743: encoded paylod length: 76
07-07 15:27:18.500+0900 E/socket.io( 8666): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:27:18.530+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:18.530+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:18.540+0900 E/socket.io( 8666): 669: Received Message type(Event)
07-07 15:27:18.540+0900 F/get_binary( 8666): in get binary_message()...
07-07 15:27:18.650+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 8666 pgid = 8666
07-07 15:27:18.650+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(8666)
07-07 15:27:18.650+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:27:18.650+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:27:18.660+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 8666
07-07 15:27:18.660+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:27:18.660+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:27:18.660+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[8666] terminate event is forwarded
07-07 15:27:18.660+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:27:18.660+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 8666, ]
07-07 15:27:18.660+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:27:18.660+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:27:18.660+0900 I/Tizen::App( 1034): (512) > Not registered pid(8666)
07-07 15:27:18.660+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 8666.
07-07 15:27:18.680+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:27:18.680+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:27:18.700+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:27:18.710+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:27:18.720+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:27:18.720+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 8666.
07-07 15:27:18.740+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:27:18.760+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:27:18.760+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:27:18.820+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:27:18.820+0900 W/CRASH_MANAGER( 8750): worker.c: worker_job(1236) > 11086666e6f72143625043
