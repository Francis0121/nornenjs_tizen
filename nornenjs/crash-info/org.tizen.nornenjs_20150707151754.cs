S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 5331
Date: 2015-07-07 15:17:54+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb1916008

Register Information
r0   = 0xb1a17000, r1   = 0xb1916008
r2   = 0x00000800, r3   = 0xb1916008
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82318
lr   = 0xb4436d70, pc   = 0xb4436f44
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     91304 KB
Buffers:     46692 KB
Cached:     256216 KB
VmPeak:      94664 KB
VmSize:      93404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18420 KB
VmRSS:       18416 KB
VmData:      39128 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5331 TID = 5331
5331 5333 5334 5373 5374 

Maps Information
b1bd5000 b23d4000 rw-p [stack:5374]
b23d5000 b2bd4000 rw-p [stack:5373]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:5333]
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
b6f91000 b6f94000 rw-p [stack:5334]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8035000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b8035000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5331)
Call Stack Count: 1
 0: (0xb4436f44) [/usr/lib/driver/libEGL.so] + 0x26f44
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
error
07-07 15:13:39.510+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3871
07-07 15:13:39.540+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:13:39.540+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 3871.
07-07 15:13:39.580+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:13:39.600+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:13:39.600+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:13:39.600+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:13:39.630+0900 W/CRASH_MANAGER( 3904): worker.c: worker_job(1236) > 11038716e6f721436249619
07-07 15:13:39.660+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:13:39.660+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:13:39.670+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:13:39.680+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:13:41.530+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:13:41.530+0900 W/CAM_APP (17481): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-07 15:13:41.970+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-07 15:14:15.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-07 15:14:15.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-07 15:14:15.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-07 15:14:15.700+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-07 15:14:15.710+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-07 15:14:15.710+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3606): media_content.c: media_content_disconnect(942) > [32m[3606]ref count changed to: 0
07-07 15:14:15.720+0900 I/CLOUD_CONTENT_SYNC_SERVER( 3606): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-07 15:14:15.720+0900 I/CLOUD_CONTENT_SYNC_TRANS( 3606): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-07 15:14:15.720+0900 I/CAPI_NETWORK_CONNECTION( 3606): connection.c: connection_destroy(379) > Destroy handle: 0xb421eb68
07-07 15:14:15.720+0900 I/CAPI_NETWORK_CONNECTION( 3606): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-07 15:14:15.720+0900 I/CAPI_NETWORK_CONNECTION( 3606): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-07 15:14:15.730+0900 I/CAPI_APPFW_APPLICATION( 3606): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-07 15:14:15.740+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:14:15.740+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 7
07-07 15:14:15.740+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:14:15.740+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-07 15:14:15.890+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 23
07-07 15:14:15.890+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-07 15:14:15.890+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 3606
07-07 15:14:15.890+0900 W/AUL_AMD (  452): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-07 15:14:15.890+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3606
07-07 15:14:15.890+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-07 15:14:15.890+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:14:15.890+0900 I/Tizen::App( 1034): (243) > App[com.samsung.cloud-content-sync-server] pid[3606] terminate event is forwarded
07-07 15:14:15.890+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:14:15.890+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 3606, ]
07-07 15:14:15.890+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:14:15.890+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-07 15:14:15.890+0900 I/Tizen::App( 1034): (512) > Not registered pid(3606)
07-07 15:14:15.890+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 3606.
07-07 15:14:15.900+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:14:15.900+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 3606.
07-07 15:14:15.900+0900 E/AUL     ( 4086): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-07 15:14:17.740+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-07 15:14:57.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_expired(1223) > alarm_id[885711502] is expired.
07-07 15:14:57.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(885711502)
07-07 15:14:57.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:16:03 (UTC).
07-07 15:14:57.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:14:58.010+0900 W/ALARM_MANAGER(  954): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.apush] : Alarm id [885711502]
07-07 15:14:58.040+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.040+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.040+0900 W/ALARM_MANAGER(  954): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(15), start(7-7-2015, 15:15:13), repeat(0), interval(0), type(-1073741822)
07-07 15:14:58.060+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.070+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.080+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.090+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.100+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.110+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1436249713, Tue Jul  7 15:15:13 2015
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1023457209, next duetime: 1436249713
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(1023457209)
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_create(873) > [alarm-server]:alarm_context.c_due_time(1436249763), due_time(1436249713)
07-07 15:14:58.110+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:15:13 (UTC).
07-07 15:14:58.130+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:14:58.200+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(1023457209)
07-07 15:14:58.200+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:16:03 (UTC).
07-07 15:14:58.280+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:14:58.290+0900 E/PUSHD   (  954): ping.c: ping_success(351) > = PING_SUCCESS = avg[240] inc[240] min[240] max[1440] interval[1440] successes[8] max[2] EXLORE[true]
07-07 15:14:58.290+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.300+0900 W/ALARM_MANAGER(  404): alarm-manager.c: alarm_manager_alarm_delete(1750) > alarm_id[1023457209] is removed.
07-07 15:14:58.300+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.300+0900 W/ALARM_MANAGER(  954): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(1440), start(7-7-2015, 15:38:58), repeat(0), interval(0), type(-1073741822)
07-07 15:14:58.320+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.330+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.340+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.350+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.360+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.360+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1436251138, Tue Jul  7 15:38:58 2015
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1023457209, next duetime: 1436251138
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(1023457209)
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_create(873) > [alarm-server]:alarm_context.c_due_time(1436249763), due_time(1436251138)
07-07 15:14:58.360+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:16:03 (UTC).
07-07 15:14:58.450+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:15:28.560+0900 E/PKGMGR_SERVER( 4416): pkgmgr-server.c: main(1608) > server start
07-07 15:15:30.830+0900 E/PKGMGR_SERVER( 4416): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:15:30.830+0900 E/PKGMGR_SERVER( 4416): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:15:33.680+0900 E/PKGMGR_SERVER( 4523): pkgmgr-server.c: main(1608) > server start
07-07 15:15:33.740+0900 E/PKGMGR  ( 4523): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-07 15:15:33.740+0900 E/PKGMGR_SERVER( 4523): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-07 15:15:33.740+0900 E/PKGMGR_SERVER( 4523): [0;m
07-07 15:15:33.920+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-07 15:15:33.920+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-07 15:15:33.920+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-07 15:15:34.040+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-07 15:15:34.040+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-07 15:15:34.040+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-07 15:15:35.830+0900 E/PKGMGR_SERVER( 4523): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-07 15:15:36.180+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-07 15:15:36.180+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-07 15:15:36.180+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-07 15:15:36.180+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-07 15:15:36.190+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-07 15:15:36.200+0900 E/PKGMGR_CERT( 4524): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-07 15:15:36.210+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-07 15:15:36.650+0900 E/rpm-installer( 4524): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-07 15:15:37.530+0900 E/PKGMGR_INFO( 4524): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-07 15:15:37.530+0900 E/PKGMGR_INSTALLER( 4524): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-07 15:15:37.540+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-07 15:15:37.550+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-07 15:15:37.550+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-07 15:15:37.550+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-07 15:15:37.570+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-07 15:15:37.570+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-07 15:15:37.570+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-07 15:15:37.580+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-07 15:15:37.580+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-07 15:15:37.600+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-07 15:15:37.600+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:15:37.600+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:15:37.620+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:15:37.640+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (855) > Enter.
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (695) > Exit.
07-07 15:15:37.640+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [1]
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (131) > Enter
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-07 15:15:37.650+0900 I/Tizen::App( 1034): (898) > Exit.
07-07 15:15:37.830+0900 E/PKGMGR_SERVER( 4523): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:15:37.830+0900 E/PKGMGR_SERVER( 4523): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:15:39.110+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-07 15:15:39.120+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-07 15:15:39.130+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-07 15:15:39.130+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-07 15:15:39.210+0900 I/CAPI_APPFW_APPLICATION( 4600): app_main.c: ui_app_main(699) > app_efl_main
07-07 15:15:39.260+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 420
07-07 15:15:39.260+0900 I/UXT     ( 4600): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-07 15:15:39.270+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-07 15:15:39.270+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 4600.
07-07 15:15:39.290+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 4600.
07-07 15:15:39.310+0900 I/CAPI_APPFW_APPLICATION( 4600): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-07 15:15:39.580+0900 I/CAPI_APPFW_APPLICATION( 4600): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-07 15:15:39.590+0900 I/APP_CORE( 4600): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-07 15:15:39.590+0900 I/APP_CORE( 4600): appcore-efl.c: __do_app(511) > [APP 4600] Initial Launching, call the resume_cb
07-07 15:15:39.590+0900 I/CAPI_APPFW_APPLICATION( 4600): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-07 15:15:39.620+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4600
07-07 15:15:39.630+0900 W/APP_CORE( 4600): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-07 15:15:39.660+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:15:39.670+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 4600"
07-07 15:15:39.680+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-07 15:15:39.740+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-07 15:15:39.740+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:15:39.760+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:15:39.760+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-07 15:15:39.760+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-07 15:15:39.810+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:15:39.810+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:15:42.110+0900 I/MALI    ( 4600): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d18c28] swap changed from async to sync
07-07 15:15:42.570+0900 I/nornenjs( 4600): Timer expired after 3.001 seconds.
07-07 15:15:42.570+0900 E/EFL     ( 4600): ecore<4600> ecore.c:568 _ecore_magic_fail() 
07-07 15:15:42.570+0900 E/EFL     ( 4600): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-07 15:15:42.570+0900 E/EFL     ( 4600): *** IN FUNCTION: ecore_timer_delay()
07-07 15:15:42.570+0900 E/EFL     ( 4600): ecore<4600> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-07 15:15:42.570+0900 E/EFL     ( 4600): ecore<4600> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-07 15:15:42.570+0900 E/EFL     ( 4600): *** SPANK SPANK SPANK!!!
07-07 15:15:42.570+0900 E/EFL     ( 4600): *** Now go fix your code. Tut tut tut!
07-07 15:15:42.600+0900 E/EFL     ( 4600): evas_main<4600> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:15:42.620+0900 E/EFL     ( 4600): evas_main<4600> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:15:47.100+0900 E/socket.io( 4600): 566: Connected.
07-07 15:15:47.110+0900 E/socket.io( 4600): 554: On handshake, sid
07-07 15:15:47.110+0900 E/socket.io( 4600): 651: Received Message type(connect)
07-07 15:15:47.110+0900 E/socket.io( 4600): 489: On Connected
07-07 15:15:47.110+0900 F/sio_packet( 4600): accept()
07-07 15:15:47.110+0900 E/socket.io( 4600): 743: encoded paylod length: 18
07-07 15:15:47.120+0900 E/socket.io( 4600): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:15:47.200+0900 E/socket.io( 4600): 669: Received Message type(Event)
07-07 15:15:47.200+0900 F/sio_packet( 4600): accept()
07-07 15:15:47.200+0900 E/socket.io( 4600): 743: encoded paylod length: 21
07-07 15:15:47.200+0900 E/socket.io( 4600): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:15:47.250+0900 E/socket.io( 4600): 669: Received Message type(Event)
07-07 15:15:47.250+0900 F/get_binary( 4600): in get binary_message()...
07-07 15:15:55.370+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4600 pgid = 4600
07-07 15:15:55.370+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(4600)
07-07 15:15:55.370+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:15:55.370+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:15:55.390+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[4600] terminate event is forwarded
07-07 15:15:55.390+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 4600
07-07 15:15:55.390+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:15:55.390+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 4600, ]
07-07 15:15:55.390+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:15:55.390+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:15:55.390+0900 I/Tizen::App( 1034): (512) > Not registered pid(4600)
07-07 15:15:55.390+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 4600.
07-07 15:15:55.390+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:15:55.390+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:15:55.400+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:15:55.400+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:15:55.410+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:15:55.410+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 4600.
07-07 15:15:55.440+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:15:55.450+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:15:55.460+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:15:55.490+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:15:55.490+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:15:55.530+0900 W/CRASH_MANAGER( 4676): worker.c: worker_job(1236) > 11046006e6f721436249755
07-07 15:15:55.540+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:15:55.540+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:15:55.560+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:15:57.850+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-07 15:16:02.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_expired(1223) > alarm_id[918904061] is expired.
07-07 15:16:02.990+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 918904061, next duetime: 1436256963
07-07 15:16:02.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-7-2015, 06:26:08 (UTC).
07-07 15:16:02.990+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-07 15:16:03.010+0900 W/ALARM_MANAGER(  993): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.alogmanager] : Alarm id [918904061]
07-07 15:17:34.090+0900 E/PKGMGR_SERVER( 5147): pkgmgr-server.c: main(1608) > server start
07-07 15:17:36.830+0900 E/PKGMGR_SERVER( 5147): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:17:36.830+0900 E/PKGMGR_SERVER( 5147): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:17:39.210+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: main(1608) > server start
07-07 15:17:39.270+0900 E/PKGMGR  ( 5254): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-07 15:17:39.270+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-07 15:17:39.270+0900 E/PKGMGR_SERVER( 5254): [0;m
07-07 15:17:39.430+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-07 15:17:39.440+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-07 15:17:39.440+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-07 15:17:39.560+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-07 15:17:39.560+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-07 15:17:39.560+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-07 15:17:41.710+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-07 15:17:41.710+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-07 15:17:41.710+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-07 15:17:41.710+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-07 15:17:41.710+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-07 15:17:41.720+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-07 15:17:41.720+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-07 15:17:41.720+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-07 15:17:41.720+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-07 15:17:41.720+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-07 15:17:41.750+0900 E/PKGMGR_CERT( 5255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-07 15:17:41.750+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-07 15:17:41.830+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-07 15:17:42.220+0900 E/rpm-installer( 5255): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-07 15:17:43.830+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-07 15:17:43.880+0900 E/PKGMGR_INFO( 5255): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-07 15:17:43.880+0900 E/PKGMGR_INSTALLER( 5255): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-07 15:17:43.900+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-07 15:17:43.900+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-07 15:17:43.900+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-07 15:17:43.900+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-07 15:17:43.920+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-07 15:17:43.950+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-07 15:17:43.970+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:17:43.970+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:17:43.970+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-07 15:17:43.970+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-07 15:17:43.970+0900 I/Tizen::App( 1034): (855) > Enter.
07-07 15:17:43.970+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-07 15:17:43.970+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-07 15:17:43.970+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-07 15:17:43.970+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-07 15:17:43.970+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (695) > Exit.
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-07 15:17:43.980+0900 I/Tizen::App( 1034): (131) > Enter
07-07 15:17:43.990+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-07 15:17:43.990+0900 I/Tizen::App( 1034): (898) > Exit.
07-07 15:17:43.990+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:17:44.000+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:17:45.390+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-07 15:17:45.400+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-07 15:17:45.410+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-07 15:17:45.410+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-07 15:17:45.500+0900 I/CAPI_APPFW_APPLICATION( 5331): app_main.c: ui_app_main(699) > app_efl_main
07-07 15:17:45.530+0900 I/UXT     ( 5331): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-07 15:17:45.550+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 419
07-07 15:17:45.550+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 5331.
07-07 15:17:45.560+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-07 15:17:45.560+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 5331.
07-07 15:17:45.590+0900 I/CAPI_APPFW_APPLICATION( 5331): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-07 15:17:45.830+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:17:45.830+0900 E/PKGMGR_SERVER( 5254): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:17:45.920+0900 I/CAPI_APPFW_APPLICATION( 5331): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-07 15:17:45.930+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5331
07-07 15:17:45.930+0900 I/APP_CORE( 5331): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-07 15:17:45.930+0900 I/APP_CORE( 5331): appcore-efl.c: __do_app(511) > [APP 5331] Initial Launching, call the resume_cb
07-07 15:17:45.930+0900 I/CAPI_APPFW_APPLICATION( 5331): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-07 15:17:45.960+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:17:45.970+0900 W/APP_CORE( 5331): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-07 15:17:45.980+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 5331"
07-07 15:17:45.980+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-07 15:17:46.010+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-07 15:17:46.010+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:17:46.020+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:17:46.080+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-07 15:17:46.080+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-07 15:17:46.110+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:17:46.110+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:17:48.450+0900 I/MALI    ( 5331): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-07 15:17:48.870+0900 I/nornenjs( 5331): Timer expired after 3.000 seconds.
07-07 15:17:48.870+0900 E/EFL     ( 5331): ecore<5331> ecore.c:568 _ecore_magic_fail() 
07-07 15:17:48.870+0900 E/EFL     ( 5331): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-07 15:17:48.870+0900 E/EFL     ( 5331): *** IN FUNCTION: ecore_timer_delay()
07-07 15:17:48.870+0900 E/EFL     ( 5331): ecore<5331> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-07 15:17:48.870+0900 E/EFL     ( 5331): ecore<5331> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-07 15:17:48.870+0900 E/EFL     ( 5331): *** SPANK SPANK SPANK!!!
07-07 15:17:48.870+0900 E/EFL     ( 5331): *** Now go fix your code. Tut tut tut!
07-07 15:17:48.900+0900 E/EFL     ( 5331): evas_main<5331> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:17:48.920+0900 E/EFL     ( 5331): evas_main<5331> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:17:53.550+0900 E/socket.io( 5331): 566: Connected.
07-07 15:17:53.550+0900 E/socket.io( 5331): 554: On handshake, sid
07-07 15:17:53.550+0900 E/socket.io( 5331): 651: Received Message type(connect)
07-07 15:17:53.550+0900 E/socket.io( 5331): 489: On Connected
07-07 15:17:53.560+0900 F/sio_packet( 5331): accept()
07-07 15:17:53.560+0900 E/socket.io( 5331): 743: encoded paylod length: 18
07-07 15:17:53.570+0900 E/socket.io( 5331): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:17:53.650+0900 E/socket.io( 5331): 669: Received Message type(Event)
07-07 15:17:53.650+0900 F/sio_packet( 5331): accept()
07-07 15:17:53.650+0900 E/socket.io( 5331): 743: encoded paylod length: 21
07-07 15:17:53.650+0900 E/socket.io( 5331): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:17:53.700+0900 E/socket.io( 5331): 669: Received Message type(Event)
07-07 15:17:53.700+0900 F/get_binary( 5331): in get binary_message()...
07-07 15:17:54.910+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:17:54.910+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:17:54.910+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5331 pgid = 5331
07-07 15:17:54.910+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(5331)
07-07 15:17:54.910+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:17:54.910+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:17:54.930+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:17:54.930+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:17:54.930+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[5331] terminate event is forwarded
07-07 15:17:54.930+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:17:54.930+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 5331, ]
07-07 15:17:54.930+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:17:54.930+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:17:54.930+0900 I/Tizen::App( 1034): (512) > Not registered pid(5331)
07-07 15:17:54.930+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 5331.
07-07 15:17:54.940+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5331
07-07 15:17:54.950+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:17:54.950+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 5331.
07-07 15:17:54.970+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:17:54.990+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:17:54.990+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:17:55.020+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:17:55.020+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:17:55.040+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:17:55.050+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:17:55.060+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:17:55.100+0900 W/CRASH_MANAGER( 5381): worker.c: worker_job(1236) > 11053316e6f72143624987
