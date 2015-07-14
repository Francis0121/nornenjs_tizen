S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 14074
Date: 2015-07-09 18:29:59+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb1aa92b8

Register Information
r0   = 0xb17bf000, r1   = 0xb1aa82b8
r2   = 0x00000800, r3   = 0xb1aa92b8
r4   = 0x00200000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000100
r8   = 0x00040000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4435d70, pc   = 0xb4435f4c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    111372 KB
Buffers:     45928 KB
Cached:     250772 KB
VmPeak:      95660 KB
VmSize:      95656 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20344 KB
VmRSS:       20340 KB
VmData:      41376 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 14074 TID = 14074
14074 14080 14081 14125 14126 14127 

Maps Information
b1bd4000 b23d3000 rw-p [stack:14127]
b23d4000 b2bd3000 rw-p [stack:14126]
b2ecb000 b36ca000 rw-p [stack:14125]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:14080]
b440f000 b4556000 r-xp /usr/lib/driver/libMali.so
b4563000 b45b3000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b48ea000 b49b4000 r-xp /usr/lib/libCOREGL.so.4.0
b49c5000 b4b04000 r-xp /usr/lib/libicui18n.so.51.1
b4b14000 b4b19000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b22000 b4b23000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4b2c000 b4b44000 r-xp /usr/lib/libpng12.so.0.50.0
b4b4c000 b4b4f000 r-xp /usr/lib/libEGL.so.1.4
b4b57000 b4b65000 r-xp /usr/lib/libGLESv2.so.2.0
b4b6e000 b4b70000 r-xp /usr/lib/libiniparser.so.0
b4b7a000 b4b82000 r-xp /usr/lib/libui-extension.so.0.1.0
b4b83000 b4b86000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4b8e000 b4c44000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c4f000 b4c61000 r-xp /usr/lib/libtts.so
b4c69000 b4c70000 r-xp /usr/lib/libtbm.so.1.0.0
b4c78000 b4c7d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c85000 b4c89000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c92000 b4c94000 r-xp /usr/lib/libdri2.so.0.0.0
b4c9c000 b4ca3000 r-xp /usr/lib/libdrm.so.2.4.0
b4cac000 b4cc2000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4cca000 b4cd2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4cda000 b4cdf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4ce7000 b4ce9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cf1000 b4cf8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d01000 b4d04000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4d0e000 b4d18000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d21000 b4dde000 r-xp /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
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
b6f91000 b6f94000 rw-p [stack:14081]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b805c000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b805c000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14074)
Call Stack Count: 1
 0: (0xb4435f4c) [/usr/lib/driver/libEGL.so] + 0x26f4c
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
434174
07-09 18:29:34.900+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:29:34.910+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-09 18:29:34.910+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-09 18:29:34.930+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-09 18:29:34.970+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-09 18:29:34.970+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:29:34.980+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:29:37.280+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-09 18:29:44.620+0900 I/CAPI_APPFW_APPLICATION(24699): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-09 18:29:44.620+0900 W/CAM_APP (24699): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-09 18:29:44.980+0900 I/CAPI_APPFW_APPLICATION(24699): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-09 18:29:44.980+0900 W/CAM_APP (24699): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-09 18:29:45.150+0900 W/STARTER (  525): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
07-09 18:29:45.150+0900 W/STARTER (  525): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
07-09 18:29:45.470+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-09 18:29:45.470+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-09 18:29:45.470+0900 E/VOLUME  (  595): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-09 18:29:45.470+0900 E/VOLUME  (  595): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-09 18:29:45.480+0900 E/VOLUME  (  595): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-09 18:29:45.580+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-09 18:29:45.590+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
07-09 18:29:45.590+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-09 18:29:45.720+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 441
07-09 18:29:45.730+0900 I/UXT     (14057): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-09 18:29:45.750+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14057.
07-09 18:29:45.760+0900 I/Tizen::App( 1034): (499) > LaunchedApp(com.samsung.task-mgr)
07-09 18:29:45.760+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14057.
07-09 18:29:46.010+0900 I/EFL-ASSIST(14057): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b7cd06b0]
07-09 18:29:46.020+0900 I/EFL-ASSIST(14057): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7dfeed8) from (/usr/share/themes/ChangeableColorTable2.xml) is created
07-09 18:29:46.030+0900 I/EFL-ASSIST(14057): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7dfeed8) is freed
07-09 18:29:46.120+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-09 18:29:46.130+0900 E/RUA     (14057): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 3, ncols : 5
07-09 18:29:46.130+0900 E/TASK_MGR_LITE(14057): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-09 18:29:46.190+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-09 18:29:46.200+0900 I/APP_CORE(14057): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-09 18:29:46.200+0900 I/APP_CORE(14057): appcore-efl.c: __do_app(511) > [APP 14057] Initial Launching, call the resume_cb
07-09 18:29:46.210+0900 W/APP_CORE(14057): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00008
07-09 18:29:46.210+0900 E/EFL     (14057): evas_main<14057> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-09 18:29:46.220+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=14057
07-09 18:29:46.230+0900 E/EFL     (14057): evas_main<14057> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-09 18:29:46.260+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:29:46.280+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.task-mgr, pid = 14057"
07-09 18:29:46.280+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-09 18:29:46.320+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [com.samsun] 
07-09 18:29:46.320+0900 I/Tizen::System( 1047): (273) > Current App[com.samsun] is already actived.
07-09 18:29:46.360+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 18:29:46.360+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-09 18:29:46.400+0900 E/TASK_MGR_LITE(14057): genlist_item.c: del_cb(758) > Deleted
07-09 18:29:46.780+0900 W/STARTER (  525): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
07-09 18:29:46.800+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-09 18:29:46.800+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-09 18:29:46.800+0900 E/VOLUME  (  595): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-09 18:29:46.800+0900 E/VOLUME  (  595): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-09 18:29:46.810+0900 E/VOLUME  (  595): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-09 18:29:47.160+0900 E/EFL     (14057): elementary<14057> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:29:47.410+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-09 18:29:47.470+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 4
07-09 18:29:47.490+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(24699), cmd(4)
07-09 18:29:47.510+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-09 18:29:47.510+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-09 18:29:47.510+0900 I/APP_CORE(24699): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-09 18:29:47.510+0900 I/CAPI_APPFW_APPLICATION(24699): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-09 18:29:47.510+0900 W/CAM_APP (24699): cam.c: cam_terminate(276) > [33m############## cam_terminate START ##############[0m
07-09 18:29:47.530+0900 E/TASK_MGR_LITE(14057): genlist_item.c: del_cb(758) > Deleted
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_app.c: cam_app_destroy_main_view(1309) > [33mSTART:[0][0m
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_ui_switch_effect_utils.c: cam_ui_switch_effect_reset(39) > [33mstart[0m
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_app.c: cam_app_request_display_freeze(8949) > [33mstart - [0][0m
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_app.c: cam_app_request_display_freeze(8961) > [33mskip, display_freeze is FALSE[0m
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_ui_switch_effect_utils.c: cam_ui_switch_effect_reset(49) > [33mend[0m
07-09 18:29:47.530+0900 W/CAM_APP (24699): cam_auto_trigger_layout.c: cam_auto_trigger_layout_destroy(823) > [33mauto_trigger_camera_layout is not exist[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_destroy_main_view(1334) > [33mEND[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_shot.c: cam_shot_destroy(225) > [33mSTART:[0][0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_shot.c: cam_shot_destroy(241) > [33mEND[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_camera_control_thread_run(8504) > [33msignal received[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_camera_control_thread_run(8508) > [33mcmd is CAM_CTRL_THREAD_EXIT[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_camera_control_thread_run(8542) > [33mthread exit[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_auto_trigger.c: cam_auto_trigger_face_detect_thread_exit(228) > [33mstart[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_auto_trigger.c: cam_auto_trigger_face_detect_thread_exit(231) > [33mCAM_THREAD_AUTO_TRIGGER_FACE_DETECT is NULL[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_panorama_burst_shot.c: cam_panorama_burst_shot_exit_thread(229) > [33mstart[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_panorama_burst_shot.c: cam_panorama_burst_shot_exit_thread(267) > [33mend[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 1[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 1[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 2[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 2[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_stop(997) > [33m############# cam_app_stop - START #############[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_request_display_freeze(8949) > [33mstart - [0][0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_request_display_freeze(8961) > [33mskip, display_freeze is FALSE[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_app.c: cam_app_preview_stop(1149) > [33mcam_app_preview_stop - START[0m
07-09 18:29:47.540+0900 E/CAM_APP (24699): cam_app.c: cam_app_preview_stop(1162) > [31mcam_mm_preview_stop failed[0m
07-09 18:29:47.540+0900 E/CAM_APP (24699): cam_app.c: cam_app_stop(1030) > [31mcam_app_preview_stop failed[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_mm.c: cam_mm_destory(1705) > [33mSTART[0m
07-09 18:29:47.540+0900 W/CAM_APP (24699): cam_sound_session_manager.c: cam_sound_session_destroy(68) > [33mdestroy sound session[0m
07-09 18:29:47.540+0900 I/TIZEN_N_SOUND_MANAGER(24699): sound_manager_product.c: sound_manager_multi_session_destroy(850) > >> enter : session=0xb7e82680
07-09 18:29:47.540+0900 I/TIZEN_N_SOUND_MANAGER(24699): sound_manager_product.c: sound_manager_multi_session_destroy(911) > << leave : already set same option(0), skip it
07-09 18:29:47.540+0900 I/TIZEN_N_SOUND_MANAGER(24699): sound_manager_product.c: sound_manager_multi_session_destroy(920) > << leave : session=(nil)
07-09 18:29:47.540+0900 E/TIZEN_N_RECORDER(24699): recorder.c: __convert_recorder_error_code(192) > [recorder_destroy] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-09 18:29:47.550+0900 W/TIZEN_N_CAMERA(24699): camera.c: camera_destroy(844) > camera handle 0xb7e82fe0
07-09 18:29:47.550+0900 I/TIZEN_N_CAMERA(24699): camera.c: _camera_remove_cb_message(92) > start
07-09 18:29:47.550+0900 W/TIZEN_N_CAMERA(24699): camera.c: _camera_remove_cb_message(118) > There is no remained callback
07-09 18:29:47.550+0900 I/TIZEN_N_CAMERA(24699): camera.c: _camera_remove_cb_message(123) > done
07-09 18:29:47.550+0900 W/CAM_APP (24699): cam_mm.c: cam_mm_destory(1735) > [33mEND[0m
07-09 18:29:47.570+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-09 18:29:47.570+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-09 18:29:47.570+0900 I/APP_CORE(14057): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-09 18:29:47.570+0900 I/APP_CORE(14057): appcore-efl.c: __after_loop(1059) > [APP 14057] PAUSE before termination
07-09 18:29:47.580+0900 E/APP_CORE(14057): appcore.c: appcore_flush_memory(631) > Appcore not initialized
07-09 18:29:47.590+0900 W/CAM_APP (24699): cam_lbs.c: cam_lbs_finialize(246) > [33mstart[0m
07-09 18:29:47.590+0900 I/PRIVACY-MANAGER-CLIENT(24699): PrivacyChecker.cpp: finalize(487) > Quit signal to dbus thread
07-09 18:29:47.590+0900 I/PRIVACY-MANAGER-CLIENT(24699): PrivacyChecker.cpp: runSignalListenerThread(218) > Thread Exit
07-09 18:29:47.590+0900 W/CAM_APP (24699): cam_lbs.c: cam_lbs_finialize(262) > [33mend[0m
07-09 18:29:47.610+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-09 18:29:47.620+0900 I/CAPI_CONTENT_MEDIA_CONTENT(24699): media_content.c: media_content_disconnect(942) > [32m[24699]ref count changed to: 0
07-09 18:29:47.620+0900 W/CAM_APP (24699): cam_dream_shot_template_info.c: cam_dream_shot_template_info_deinit(73) > [33mSTART[0m
07-09 18:29:47.620+0900 W/CAM_APP (24699): cam_dream_shot_template_info.c: cam_dream_shot_template_info_deinit(80) > [33mEND[0m
07-09 18:29:47.670+0900 I/MALI    (14057): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-09 18:29:47.670+0900 I/MALI    (14057): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=14057   close drm_fd=21 
07-09 18:29:47.670+0900 I/MALI    (14057): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-09 18:29:47.670+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [com.samsun] 
07-09 18:29:47.670+0900 I/Tizen::System( 1047): (273) > Current App[com.samsun] is already actived.
07-09 18:29:47.700+0900 W/CAM_APP (24699): cam_app.c: cam_app_stop(1079) > [33m############# cam_app_stop - END #############[0m
07-09 18:29:47.720+0900 I/EFL-ASSIST(24699): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b2108798) is freed
07-09 18:29:47.720+0900 I/EFL-ASSIST(24699): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b7e68ff8) is freed
07-09 18:29:47.720+0900 W/CAM_APP (24699): cam.c: cam_terminate(300) > [33m############## cam_terminate END ##############[0m
07-09 18:29:47.740+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:29:47.750+0900 I/MALI    (24699): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-09 18:29:47.750+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-09 18:29:47.750+0900 I/MALI    (24699): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=24699   close drm_fd=21 
07-09 18:29:47.760+0900 I/MALI    (24699): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-09 18:29:47.800+0900 I/UXT     (14057): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-09 18:29:47.860+0900 I/UXT     (24699): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-09 18:29:47.940+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 14057 pgid = 14057
07-09 18:29:47.940+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(14057)
07-09 18:29:47.940+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 18:29:47.940+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 18:29:47.950+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.task-mgr]
07-09 18:29:47.950+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:29:47.960+0900 I/Tizen::App( 1034): (243) > App[com.samsung.task-mgr] pid[14057] terminate event is forwarded
07-09 18:29:47.960+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 18:29:47.960+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.task-mgr, 14057, ]
07-09 18:29:47.960+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 18:29:47.960+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.task-mgr)
07-09 18:29:47.960+0900 I/Tizen::App( 1034): (512) > Not registered pid(14057)
07-09 18:29:47.960+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.task-mgr, 14057.
07-09 18:29:47.960+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 14057
07-09 18:29:47.970+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:29:47.970+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.task-mgr, 14057.
07-09 18:29:48.020+0900 I/AUL_PAD ( 1181): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24699 pgid = 24699
07-09 18:29:48.020+0900 I/AUL_PAD ( 1181): sigchild.h: __sigchild_action(123) > dead_pid(24699)
07-09 18:29:48.020+0900 I/AUL_PAD ( 1181): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 18:29:48.020+0900 I/AUL_PAD ( 1181): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 18:29:48.020+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.camera-app-lite]
07-09 18:29:48.020+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:29:48.020+0900 I/Tizen::App( 1034): (243) > App[com.samsung.camera-app-lite] pid[24699] terminate event is forwarded
07-09 18:29:48.020+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 18:29:48.020+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.camera-app-lite, 24699, ]
07-09 18:29:48.020+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 18:29:48.020+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.camera-app-lite)
07-09 18:29:48.020+0900 I/Tizen::App( 1034): (512) > Not registered pid(24699)
07-09 18:29:48.020+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 24699.
07-09 18:29:48.020+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24699
07-09 18:29:48.020+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(77) > [33mSTART[0m
07-09 18:29:48.030+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(82) > [33m0, com.samsung.camera-app-lite[0m
07-09 18:29:48.030+0900 W/CAM_SERVICE( 1174): cam_service.c: __camera_app_launch(29) > [33mSTART[0m
07-09 18:29:48.030+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 14
07-09 18:29:48.040+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-09 18:29:48.040+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:29:48.040+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 24699.
07-09 18:29:48.050+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-09 18:29:48.140+0900 W/CAM_APP (19908): cam.c: main(973) > [33mmain START[0m
07-09 18:29:48.140+0900 I/CAPI_APPFW_APPLICATION(19908): app_main.c: ui_app_main(699) > app_efl_main
07-09 18:29:48.140+0900 I/CAPI_APPFW_APPLICATION(19908): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-09 18:29:48.170+0900 W/CAM_APP (19908): cam.c: cam_create(118) > [33m############## cam_create START ##############[0m
07-09 18:29:48.180+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 442
07-09 18:29:48.180+0900 W/CAM_SERVICE( 1174): cam_service.c: __camera_app_launch(72) > [33mEND[0m
07-09 18:29:48.180+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(89) > [33mEND[0m
07-09 18:29:48.180+0900 W/CAM_APP (19908): cam.c: __cam_preloading_thread_run(827) > [33mSTART[0m
07-09 18:29:48.180+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(748) > initializing gstreamer with following parameter
07-09 18:29:48.180+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(749) > argc : 2
07-09 18:29:48.180+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(754) > argv[0] : camera
07-09 18:29:48.180+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(754) > argv[1] : --gst-disable-registry-fork
07-09 18:29:48.210+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-09 18:29:48.250+0900 I/EFL-ASSIST(19908): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b7c70328]
07-09 18:29:48.260+0900 I/EFL-ASSIST(19908): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b21088d0) from (/usr/share/themes/ChangeableColorTable2.xml) is created
07-09 18:29:48.280+0900 I/EFL-ASSIST(19908): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b21088d0) is freed
07-09 18:29:48.280+0900 I/EFL-ASSIST(19908): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b21088b8) from (/usr/apps/com.samsung.camera-app-lite/shared/res/tables/com.samsung.camera-app-lite_ChangeableColorInfo.xml) is created
07-09 18:29:48.280+0900 I/EFL-ASSIST(19908): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b7e75618) from (/usr/apps/com.samsung.camera-app-lite/shared/res/tables/com.samsung.camera-app-lite_ChangeableFontInfo.xml) is created
07-09 18:29:48.290+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(772) > release - argv[0] : camera
07-09 18:29:48.290+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preinit_framework(772) > release - argv[1] : --gst-disable-registry-fork
07-09 18:29:48.290+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preload_framework(804) > start load plugin
07-09 18:29:48.290+0900 I/CAPI_CONTENT_MEDIA_CONTENT(19908): media_content.c: media_content_connect(854) > [32m[19908]ref count : 0
07-09 18:29:48.290+0900 I/CAPI_CONTENT_MEDIA_CONTENT(19908): media_content.c: media_content_connect(886) > [32m[19908]ref count changed to: 1
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam.c: cam_create(223) > [33m############## cam_create END ##############[0m
07-09 18:29:48.300+0900 I/CAPI_APPFW_APPLICATION(19908): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam.c: cam_service(415) > [33m############## cam_service START ##############[0m
07-09 18:29:48.300+0900 W/CAPI_APPFW_APP_CONTROL(19908): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam.c: cam_service(464) > [33mapp state is [0][0m
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam.c: cam_service(509) > [33mapp_control_get_operation is CAM_APP_PRELAUNCH_STATE[0m
07-09 18:29:48.300+0900 W/CAPI_APPFW_APP_CONTROL(19908): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam_app.c: cam_handle_init(1524) > [33mmode : 1 [0m
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam_mm.c: cam_mm_create(1641) > [33mSTART[0m
07-09 18:29:48.300+0900 W/CAM_APP (19908): cam_sound_session_manager.c: cam_sound_session_create(49) > [33mcreate sound session[0m
07-09 18:29:48.300+0900 I/TIZEN_N_SOUND_MANAGER(19908): sound_manager_product.c: sound_manager_multi_session_create(585) > >> enter : type=2, session=0xb34ae370
07-09 18:29:48.310+0900 I/TIZEN_N_SOUND_MANAGER(19908): sound_manager_product.c: sound_manager_multi_session_create(637) > << leave : type=2, session=0xb34ae370
07-09 18:29:48.310+0900 W/TIZEN_N_CAMERA(19908): camera.c: camera_create(764) > [camera_create]device name = [0]
07-09 18:29:48.310+0900 W/TIZEN_N_CAMERA(19908): camera.c: camera_create(824) > camera handle 0xb7e90118
07-09 18:29:48.310+0900 W/TIZEN_N_RECORDER(19908): recorder.c: recorder_create_videorecorder(422) > permission check done
07-09 18:29:48.310+0900 W/CAM_APP (19908): cam_mm.c: cam_mm_create(1696) > [33mEND[0m
07-09 18:29:48.310+0900 W/CAM_APP (19908): cam_app.c: cam_app_start(684) > [33m############# cam_app_start - START #############[0m
07-09 18:29:48.310+0900 E/TIZEN_N_RECORDER(19908): recorder.c: __convert_recorder_error_code(192) > [recorder_set_video_resolution] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-09 18:29:48.310+0900 E/TIZEN_N_RECORDER(19908): recorder.c: __convert_recorder_error_code(192) > [recorder_attr_set_recording_flip] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-09 18:29:48.310+0900 E/TIZEN_N_CAMERA(19908): camera.c: camera_attr_enable_anti_shake(3351) > NOT SUPPORTED
07-09 18:29:48.310+0900 E/CAM_APP (19908): cam_mm.c: cam_mm_set_anti_hand_shake(329) > [31mcamera_attr_enable_anti_shake failed - code[c0000002][0m
07-09 18:29:48.320+0900 I/TIZEN_N_CAMERA(19908): camera.c: camera_get_recommended_preview_resolution(1968) > recommend resolution 800x480, type 1
07-09 18:29:48.320+0900 E/CAM_APP (19908): cam_app.c: cam_app_start(701) > [31mcam_app_init_attribute failed[0m
07-09 18:29:48.320+0900 W/CAM_APP (19908): cam_app.c: cam_app_start(711) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not start preview[0m
07-09 18:29:48.320+0900 W/CAM_APP (19908): cam_app.c: cam_app_start(729) > [33m############# cam_app_start - END #############[0m
07-09 18:29:48.350+0900 I/CAPI_APPFW_APPLICATION(14074): app_main.c: ui_app_main(699) > app_efl_main
07-09 18:29:48.400+0900 I/UXT     (14074): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-09 18:29:48.460+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 14074.
07-09 18:29:48.470+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 440
07-09 18:29:48.480+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-09 18:29:48.480+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 14074.
07-09 18:29:48.540+0900 I/CAPI_APPFW_APPLICATION(14074): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-09 18:29:48.540+0900 W/CAM_APP (19908): cam_app.c: cam_app_create_main_view(1257) > [33mSTART:[0][0m
07-09 18:29:48.580+0900 W/CAM_APP (19908): cam_app.c: cam_app_destroy_main_view(1309) > [33mSTART:[0][0m
07-09 18:29:48.580+0900 W/CAM_APP (19908): cam_standby_view.c: cam_standby_view_destroy(2398) > [33mstandby_view is NULL[0m
07-09 18:29:48.580+0900 W/CAM_APP (19908): cam_app.c: cam_app_destroy_main_view(1334) > [33mEND[0m
07-09 18:29:48.640+0900 E/EFL     (19908): evas_main<19908> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-09 18:29:48.650+0900 I/TIZEN_N_CAMERA(19908): camera_product.c: camera_preload_framework(814) > done load plugin
07-09 18:29:48.650+0900 W/CAM_APP (19908): cam.c: __cam_preloading_thread_run(842) > [33mEND[0m
07-09 18:29:48.670+0900 E/EFL     (19908): evas_main<19908> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-09 18:29:48.670+0900 I/Tizen::App( 1034): (499) > LaunchedApp(com.samsung.camera-app-lite)
07-09 18:29:48.670+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 19908.
07-09 18:29:48.690+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 19908.
07-09 18:29:48.790+0900 W/CAM_APP (19908): cam_app.c: cam_app_create_main_view(1303) > [33mEND[0m
07-09 18:29:48.790+0900 W/CAM_APP (19908): cam.c: cam_service(594) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not show window[0m
07-09 18:29:48.800+0900 W/CAM_APP (19908): cam.c: cam_service(730) > [33m############## cam_service END ##############[0m
07-09 18:29:48.810+0900 I/APP_CORE(19908): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-09 18:29:48.810+0900 I/APP_CORE(19908): appcore-efl.c: __do_app(511) > [APP 19908] Initial Launching, call the resume_cb
07-09 18:29:48.810+0900 I/CAPI_APPFW_APPLICATION(19908): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-09 18:29:48.810+0900 W/CAM_APP (19908): cam.c: cam_resume(345) > [33m############## cam_resume START ##############[0m
07-09 18:29:48.810+0900 W/CAM_APP (19908): cam.c: cam_resume(356) > [33mapp state is CAM_APP_PRELAUNCH_STATE[0m
07-09 18:29:48.810+0900 W/CAM_APP (19908): cam.c: __app_init_idler(926) > [33mSTART[0m
07-09 18:29:48.810+0900 W/CAM_APP (19908): cam_shot.c: cam_shot_create(254) > [33mstart[0m
07-09 18:29:48.810+0900 W/CAM_APP (19908): cam_shot.c: cam_shot_create(270) > [33mend[0m
07-09 18:29:48.820+0900 W/CAM_APP (19908): cam_lbs.c: cam_lbs_init(190) > [33mstart[0m
07-09 18:29:48.830+0900 W/LOCATION(19908): module-internal.c: module_is_supported(282) > module name(gps) is found
07-09 18:29:48.850+0900 I/PRIVACY-MANAGER-CLIENT(19908): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
07-09 18:29:48.850+0900 I/PRIVACY-MANAGER-CLIENT(19908): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
07-09 18:29:48.850+0900 I/PRIVACY-MANAGER-CLIENT(19908): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
07-09 18:29:48.870+0900 I/PRIVACY-MANAGER-CLIENT(19908): PrivacyChecker.cpp: initializeDbus(245) > Initialized
07-09 18:29:48.870+0900 I/PRIVACY-MANAGER-CLIENT(19908): PrivacyChecker.cpp: initialize(192) > Initialized
07-09 18:29:48.880+0900 W/LOCATION(19908): module-internal.c: module_is_supported(282) > module name(gps) is found
07-09 18:29:48.900+0900 W/LOCATION(19908): module-internal.c: module_new(253) > module (gps) open success
07-09 18:29:48.920+0900 W/LOCATION(19908): module-internal.c: module_is_supported(282) > module name(wps) is found
07-09 18:29:48.930+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=14074
07-09 18:29:48.950+0900 W/LOCATION(19908): module-internal.c: module_new(253) > module (wps) open success
07-09 18:29:48.950+0900 I/CAPI_APPFW_APPLICATION(14074): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-09 18:29:48.960+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:29:48.970+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_lbs.c: cam_lbs_init(228) > [33mend[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(32) > [33mSTART[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(49) > [33mg_key_file_load_from_file failed: No such file or directory[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(55) > [33mload default data for dreamshot[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(67) > [33mEND[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam.c: __app_init_idler(961) > [33mEND[0m
07-09 18:29:48.980+0900 W/CAM_APP (19908): cam_app.c: cam_app_camera_control_thread_run(8494) > [33mstart[0m
07-09 18:29:48.980+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 14074"
07-09 18:29:48.990+0900 I/APP_CORE(14074): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-09 18:29:48.990+0900 I/APP_CORE(14074): appcore-efl.c: __do_app(511) > [APP 14074] Initial Launching, call the resume_cb
07-09 18:29:48.990+0900 I/CAPI_APPFW_APPLICATION(14074): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-09 18:29:49.000+0900 W/APP_CORE(14074): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000003
07-09 18:29:49.010+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:29:49.010+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:29:49.020+0900 W/CAM_APP (19908): cam_app.c: cam_app_join_thread_async_cb(5880) > [33mjoin thread [0][0m
07-09 18:29:49.020+0900 W/CAM_APP (19908): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 0[0m
07-09 18:29:49.020+0900 W/CAM_APP (19908): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 0[0m
07-09 18:29:49.070+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 18:29:49.070+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-09 18:29:49.160+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 18:29:49.160+0900 W/AUL_AMD (  452): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-09 18:29:49.510+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-09 18:29:49.570+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-09 18:29:49.720+0900 I/UXT     (14082): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-09 18:29:50.930+0900 W/CAM_APP (19908): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-09 18:29:51.890+0900 I/nornenjs(14074): Timer expired after 3.001 seconds.
07-09 18:29:51.890+0900 E/EFL     (14074): ecore<14074> ecore.c:568 _ecore_magic_fail() 
07-09 18:29:51.890+0900 E/EFL     (14074): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-09 18:29:51.890+0900 E/EFL     (14074): *** IN FUNCTION: ecore_timer_delay()
07-09 18:29:51.890+0900 E/EFL     (14074): ecore<14074> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-09 18:29:51.890+0900 E/EFL     (14074): ecore<14074> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-09 18:29:51.890+0900 E/EFL     (14074): *** SPANK SPANK SPANK!!!
07-09 18:29:51.890+0900 E/EFL     (14074): *** Now go fix your code. Tut tut tut!
07-09 18:29:51.910+0900 E/EFL     (14074): evas_main<14074> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-09 18:29:51.930+0900 E/EFL     (14074): evas_main<14074> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-09 18:29:52.020+0900 I/MALI    (14074): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d188f0] swap changed from async to sync
07-09 18:29:56.680+0900 E/socket.io(14074): 566: Connected.
07-09 18:29:56.680+0900 E/socket.io(14074): 554: On handshake, sid
07-09 18:29:56.680+0900 E/socket.io(14074): 651: Received Message type(connect)
07-09 18:29:56.680+0900 E/socket.io(14074): 489: On Connected
07-09 18:29:56.680+0900 F/sio_packet(14074): accept()
07-09 18:29:56.690+0900 E/socket.io(14074): 743: encoded paylod length: 41
07-09 18:29:56.700+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:56.770+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:56.770+0900 F/sio_packet(14074): accept()
07-09 18:29:56.770+0900 E/socket.io(14074): 743: encoded paylod length: 21
07-09 18:29:56.770+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:56.820+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:56.820+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:56.820+0900 I/CAPI_APPFW_APPLICATION(19908): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-09 18:29:56.820+0900 W/CAM_APP (19908): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-09 18:29:56.850+0900 I/CAPI_APPFW_APPLICATION(14074): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-09 18:29:58.440+0900 F/sio_packet(14074): accept()
07-09 18:29:58.440+0900 E/socket.io(14074): 743: encoded paylod length: 56
07-09 18:29:58.440+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.450+0900 F/sio_packet(14074): accept()
07-09 18:29:58.450+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.450+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.470+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.470+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.480+0900 F/sio_packet(14074): accept()
07-09 18:29:58.480+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.480+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.490+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.490+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.500+0900 F/sio_packet(14074): accept()
07-09 18:29:58.500+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.500+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.500+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.500+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.520+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.520+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.520+0900 F/sio_packet(14074): accept()
07-09 18:29:58.520+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.530+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.540+0900 F/sio_packet(14074): accept()
07-09 18:29:58.540+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.540+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.540+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.540+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.560+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.560+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.570+0900 F/sio_packet(14074): accept()
07-09 18:29:58.570+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.570+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.580+0900 F/sio_packet(14074): accept()
07-09 18:29:58.580+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.580+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.580+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.580+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.590+0900 F/sio_packet(14074): accept()
07-09 18:29:58.600+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.600+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.600+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.600+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.610+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.610+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.620+0900 F/sio_packet(14074): accept()
07-09 18:29:58.620+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.620+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.630+0900 F/sio_packet(14074): accept()
07-09 18:29:58.630+0900 E/socket.io(14074): 743: encoded paylod length: 56
07-09 18:29:58.630+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.640+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.640+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.650+0900 F/sio_packet(14074): accept()
07-09 18:29:58.660+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.660+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.660+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.660+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.670+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.680+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.680+0900 F/sio_packet(14074): accept()
07-09 18:29:58.690+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.690+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.700+0900 F/sio_packet(14074): accept()
07-09 18:29:58.700+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.700+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.700+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.700+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.720+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.720+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.720+0900 F/sio_packet(14074): accept()
07-09 18:29:58.720+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.730+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.740+0900 F/sio_packet(14074): accept()
07-09 18:29:58.740+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.740+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.740+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.740+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.760+0900 F/sio_packet(14074): accept()
07-09 18:29:58.760+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.760+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.770+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.770+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.780+0900 F/sio_packet(14074): accept()
07-09 18:29:58.790+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.790+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.790+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.790+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.800+0900 F/sio_packet(14074): accept()
07-09 18:29:58.810+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.810+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.810+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.810+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.820+0900 F/sio_packet(14074): accept()
07-09 18:29:58.830+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.830+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.840+0900 E/socket.io(14074): 743: encoded paylod length: 56
07-09 18:29:58.840+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.850+0900 F/sio_packet(14074): accept()
07-09 18:29:58.850+0900 E/socket.io(14074): 743: encoded paylod length: 56
07-09 18:29:58.850+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.850+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.850+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.860+0900 F/sio_packet(14074): accept()
07-09 18:29:58.860+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.860+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.870+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.870+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.880+0900 F/sio_packet(14074): accept()
07-09 18:29:58.880+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.880+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.890+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.890+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.900+0900 F/sio_packet(14074): accept()
07-09 18:29:58.900+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.900+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.900+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.910+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.920+0900 F/sio_packet(14074): accept()
07-09 18:29:58.920+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.920+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.920+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.930+0900 F/sio_packet(14074): accept()
07-09 18:29:58.930+0900 E/socket.io(14074): 743: encoded paylod length: 57
07-09 18:29:58.930+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.930+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:58.950+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.950+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:58.970+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:58.970+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:59.010+0900 F/sio_packet(14074): accept()
07-09 18:29:59.010+0900 E/socket.io(14074): 743: encoded paylod length: 21
07-09 18:29:59.010+0900 E/socket.io(14074): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:29:59.050+0900 E/socket.io(14074): 669: Received Message type(Event)
07-09 18:29:59.050+0900 F/get_binary(14074): in get binary_message()...
07-09 18:29:59.150+0900 W/CRASH_MANAGER(13978): worker.c: worker_job(1236) > 11140746e6f72143643419
