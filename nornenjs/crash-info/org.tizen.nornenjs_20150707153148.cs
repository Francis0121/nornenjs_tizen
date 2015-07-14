S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 10061
Date: 2015-07-07 15:31:48+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb17ff008

Register Information
r0   = 0xb16ff000, r1   = 0xb17ff008
r2   = 0x00000800, r3   = 0xb17ff008
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82318
lr   = 0xb4436d70, pc   = 0xb4436f44
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     94708 KB
Buffers:     46804 KB
Cached:     252060 KB
VmPeak:      94660 KB
VmSize:      94440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18444 KB
VmRSS:       18440 KB
VmData:      40164 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10061 TID = 10061
10061 10062 10063 10331 10332 

Maps Information
b1bd5000 b23d4000 rw-p [stack:10332]
b23d5000 b2bd4000 rw-p [stack:10331]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:10062]
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
b6f91000 b6f94000 rw-p [stack:10063]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8034000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8034000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10061)
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
_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:29:31.910+0900 E/EFL     ( 9556): evas_main<9556> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:29:31.920+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:29:31.960+0900 W/STARTER (  525): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
07-07 15:29:31.970+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.task-mgr, pid = 9556"
07-07 15:29:31.970+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:29:31.970+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:29:32.000+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-07 15:29:32.000+0900 I/SYSPOPUP(  595): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-07 15:29:32.000+0900 E/VOLUME  (  595): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-07 15:29:32.000+0900 E/VOLUME  (  595): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-07 15:29:32.000+0900 E/VOLUME  (  595): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-07 15:29:32.050+0900 E/TASK_MGR_LITE( 9556): genlist_item.c: del_cb(758) > Deleted
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_widget.c:5012 _elm_widget_item_data_get() Elm_Widget_Item item is NULL
07-07 15:29:32.730+0900 E/EFL     ( 9556): elementary<9556> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-07 15:29:32.970+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-07 15:29:33.030+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 4
07-07 15:29:33.050+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(17481), cmd(4)
07-07 15:29:33.060+0900 I/APP_CORE(17481): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-07 15:29:33.060+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-07 15:29:33.060+0900 W/CAM_APP (17481): cam.c: cam_terminate(276) > [33m############## cam_terminate START ##############[0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_app.c: cam_app_destroy_main_view(1309) > [33mSTART:[0][0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_ui_switch_effect_utils.c: cam_ui_switch_effect_reset(39) > [33mstart[0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_app.c: cam_app_request_display_freeze(8949) > [33mstart - [0][0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_app.c: cam_app_request_display_freeze(8961) > [33mskip, display_freeze is FALSE[0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_ui_switch_effect_utils.c: cam_ui_switch_effect_reset(49) > [33mend[0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_auto_trigger_layout.c: cam_auto_trigger_layout_destroy(823) > [33mauto_trigger_camera_layout is not exist[0m
07-07 15:29:33.070+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 4
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_app.c: cam_app_destroy_main_view(1334) > [33mEND[0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_shot.c: cam_shot_destroy(225) > [33mSTART:[0][0m
07-07 15:29:33.070+0900 W/CAM_APP (17481): cam_shot.c: cam_shot_destroy(241) > [33mEND[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_camera_control_thread_run(8504) > [33msignal received[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_camera_control_thread_run(8508) > [33mcmd is CAM_CTRL_THREAD_EXIT[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_camera_control_thread_run(8542) > [33mthread exit[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_auto_trigger.c: cam_auto_trigger_face_detect_thread_exit(228) > [33mstart[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_auto_trigger.c: cam_auto_trigger_face_detect_thread_exit(231) > [33mCAM_THREAD_AUTO_TRIGGER_FACE_DETECT is NULL[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_panorama_burst_shot.c: cam_panorama_burst_shot_exit_thread(229) > [33mstart[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_panorama_burst_shot.c: cam_panorama_burst_shot_exit_thread(267) > [33mend[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 1[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 1[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 2[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 2[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_stop(997) > [33m############# cam_app_stop - START #############[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_request_display_freeze(8949) > [33mstart - [0][0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_request_display_freeze(8961) > [33mskip, display_freeze is FALSE[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_app.c: cam_app_preview_stop(1149) > [33mcam_app_preview_stop - START[0m
07-07 15:29:33.080+0900 E/CAM_APP (17481): cam_app.c: cam_app_preview_stop(1162) > [31mcam_mm_preview_stop failed[0m
07-07 15:29:33.080+0900 E/CAM_APP (17481): cam_app.c: cam_app_stop(1030) > [31mcam_app_preview_stop failed[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_mm.c: cam_mm_destory(1705) > [33mSTART[0m
07-07 15:29:33.080+0900 W/CAM_APP (17481): cam_sound_session_manager.c: cam_sound_session_destroy(68) > [33mdestroy sound session[0m
07-07 15:29:33.080+0900 I/TIZEN_N_SOUND_MANAGER(17481): sound_manager_product.c: sound_manager_multi_session_destroy(850) > >> enter : session=0xb7d6cd78
07-07 15:29:33.080+0900 I/TIZEN_N_SOUND_MANAGER(17481): sound_manager_product.c: sound_manager_multi_session_destroy(911) > << leave : already set same option(0), skip it
07-07 15:29:33.080+0900 I/TIZEN_N_SOUND_MANAGER(17481): sound_manager_product.c: sound_manager_multi_session_destroy(920) > << leave : session=(nil)
07-07 15:29:33.080+0900 E/TIZEN_N_RECORDER(17481): recorder.c: __convert_recorder_error_code(192) > [recorder_destroy] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-07 15:29:33.090+0900 W/TIZEN_N_CAMERA(17481): camera.c: camera_destroy(844) > camera handle 0xb7dcba00
07-07 15:29:33.090+0900 I/TIZEN_N_CAMERA(17481): camera.c: _camera_remove_cb_message(92) > start
07-07 15:29:33.090+0900 W/TIZEN_N_CAMERA(17481): camera.c: _camera_remove_cb_message(118) > There is no remained callback
07-07 15:29:33.090+0900 I/TIZEN_N_CAMERA(17481): camera.c: _camera_remove_cb_message(123) > done
07-07 15:29:33.090+0900 W/CAM_APP (17481): cam_mm.c: cam_mm_destory(1735) > [33mEND[0m
07-07 15:29:33.110+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:29:33.110+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-07 15:29:33.110+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(9486), cmd(4)
07-07 15:29:33.120+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:29:33.120+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-07 15:29:33.120+0900 I/APP_CORE( 9486): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-07 15:29:33.120+0900 E/TASK_MGR_LITE( 9556): genlist_item.c: del_cb(758) > Deleted
07-07 15:29:33.130+0900 W/CAM_APP (17481): cam_lbs.c: cam_lbs_finialize(246) > [33mstart[0m
07-07 15:29:33.130+0900 I/PRIVACY-MANAGER-CLIENT(17481): PrivacyChecker.cpp: finalize(487) > Quit signal to dbus thread
07-07 15:29:33.130+0900 W/CAM_APP (17481): cam_lbs.c: cam_lbs_finialize(262) > [33mend[0m
07-07 15:29:33.130+0900 I/PRIVACY-MANAGER-CLIENT(17481): PrivacyChecker.cpp: runSignalListenerThread(218) > Thread Exit
07-07 15:29:33.140+0900 I/CAPI_CONTENT_MEDIA_CONTENT(17481): media_content.c: media_content_disconnect(942) > [32m[17481]ref count changed to: 0
07-07 15:29:33.140+0900 W/CAM_APP (17481): cam_dream_shot_template_info.c: cam_dream_shot_template_info_deinit(73) > [33mSTART[0m
07-07 15:29:33.140+0900 W/CAM_APP (17481): cam_dream_shot_template_info.c: cam_dream_shot_template_info_deinit(80) > [33mEND[0m
07-07 15:29:33.150+0900 I/CAPI_APPFW_APPLICATION( 9486): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-07 15:29:33.160+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-07 15:29:33.160+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-07 15:29:33.160+0900 I/APP_CORE( 9556): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-07 15:29:33.160+0900 I/APP_CORE( 9556): appcore-efl.c: __after_loop(1059) > [APP 9556] PAUSE before termination
07-07 15:29:33.180+0900 E/APP_CORE( 9556): appcore.c: appcore_flush_memory(631) > Appcore not initialized
07-07 15:29:33.190+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:29:33.220+0900 W/CAM_APP (17481): cam_app.c: cam_app_stop(1079) > [33m############# cam_app_stop - END #############[0m
07-07 15:29:33.240+0900 I/EFL-ASSIST(17481): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b21087b8) is freed
07-07 15:29:33.240+0900 I/EFL-ASSIST(17481): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b210dfc0) is freed
07-07 15:29:33.240+0900 W/CAM_APP (17481): cam.c: cam_terminate(300) > [33m############## cam_terminate END ##############[0m
07-07 15:29:33.240+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [com.samsun] 
07-07 15:29:33.240+0900 I/Tizen::System( 1047): (273) > Current App[com.samsun] is already actived.
07-07 15:29:33.280+0900 I/MALI    ( 9556): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-07 15:29:33.280+0900 I/MALI    ( 9556): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=9556   close drm_fd=21 
07-07 15:29:33.280+0900 I/MALI    ( 9556): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-07 15:29:33.290+0900 I/MALI    (17481): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-07 15:29:33.290+0900 I/MALI    (17481): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=17481   close drm_fd=21 
07-07 15:29:33.300+0900 I/MALI    (17481): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-07 15:29:33.320+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:29:33.340+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:29:33.410+0900 I/UXT     (17481): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-07 15:29:33.420+0900 I/UXT     ( 9556): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-07 15:29:33.460+0900 I/MALI    ( 9486): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-07 15:29:33.460+0900 I/MALI    ( 9486): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=9486   close drm_fd=25 
07-07 15:29:33.460+0900 I/MALI    ( 9486): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-07 15:29:33.590+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9556 pgid = 9556
07-07 15:29:33.590+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(9556)
07-07 15:29:33.590+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:29:33.590+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:29:33.590+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.task-mgr]
07-07 15:29:33.590+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9556
07-07 15:29:33.590+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:29:33.590+0900 I/Tizen::App( 1034): (243) > App[com.samsung.task-mgr] pid[9556] terminate event is forwarded
07-07 15:29:33.590+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:29:33.590+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.task-mgr, 9556, ]
07-07 15:29:33.590+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:29:33.590+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.task-mgr)
07-07 15:29:33.590+0900 I/Tizen::App( 1034): (512) > Not registered pid(9556)
07-07 15:29:33.590+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.task-mgr, 9556.
07-07 15:29:33.600+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:29:33.600+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.task-mgr, 9556.
07-07 15:29:33.630+0900 I/AUL_PAD ( 1181): sigchild.h: __launchpad_sig_child(142) > dead_pid = 17481 pgid = 17481
07-07 15:29:33.630+0900 I/AUL_PAD ( 1181): sigchild.h: __sigchild_action(123) > dead_pid(17481)
07-07 15:29:33.630+0900 I/AUL_PAD ( 1181): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:29:33.630+0900 I/AUL_PAD ( 1181): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:29:33.630+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.camera-app-lite]
07-07 15:29:33.630+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:29:33.630+0900 I/Tizen::App( 1034): (243) > App[com.samsung.camera-app-lite] pid[17481] terminate event is forwarded
07-07 15:29:33.630+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:29:33.630+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.camera-app-lite, 17481, ]
07-07 15:29:33.630+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 17481
07-07 15:29:33.630+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:29:33.630+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.camera-app-lite)
07-07 15:29:33.630+0900 I/Tizen::App( 1034): (512) > Not registered pid(17481)
07-07 15:29:33.630+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 17481.
07-07 15:29:33.630+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(77) > [33mSTART[0m
07-07 15:29:33.630+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(82) > [33m0, com.samsung.camera-app-lite[0m
07-07 15:29:33.630+0900 W/CAM_SERVICE( 1174): cam_service.c: __camera_app_launch(29) > [33mSTART[0m
07-07 15:29:33.630+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 14
07-07 15:29:33.640+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-07 15:29:33.640+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:29:33.640+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 17481.
07-07 15:29:33.690+0900 I/UXT     ( 9486): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-07 15:29:33.700+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-07 15:29:33.790+0900 W/CAM_APP ( 1285): cam.c: main(973) > [33mmain START[0m
07-07 15:29:33.800+0900 I/CAPI_APPFW_APPLICATION( 1285): app_main.c: ui_app_main(699) > app_efl_main
07-07 15:29:33.800+0900 I/CAPI_APPFW_APPLICATION( 1285): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-07 15:29:33.820+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 421
07-07 15:29:33.820+0900 W/CAM_SERVICE( 1174): cam_service.c: __camera_app_launch(72) > [33mEND[0m
07-07 15:29:33.820+0900 W/CAM_SERVICE( 1174): cam_service.c: __app_context_status_cb(89) > [33mEND[0m
07-07 15:29:33.830+0900 E/socket.io( 9486): 849: Close by reason: End by user
07-07 15:29:33.830+0900 F/sio_packet( 9486): accept()
07-07 15:29:33.830+0900 W/CAM_APP ( 1285): cam.c: cam_create(118) > [33m############## cam_create START ##############[0m
07-07 15:29:33.830+0900 E/socket.io( 9486): 867: __close paylod  1000
07-07 15:29:33.840+0900 W/CAM_APP ( 1285): cam.c: __cam_preloading_thread_run(827) > [33mSTART[0m
07-07 15:29:33.840+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(748) > initializing gstreamer with following parameter
07-07 15:29:33.840+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(749) > argc : 2
07-07 15:29:33.840+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(754) > argv[0] : camera
07-07 15:29:33.840+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(754) > argv[1] : --gst-disable-registry-fork
07-07 15:29:33.880+0900 I/EFL-ASSIST( 1285): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b7c70328]
07-07 15:29:33.890+0900 I/EFL-ASSIST( 1285): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7e1be00) from (/usr/share/themes/ChangeableColorTable2.xml) is created
07-07 15:29:33.910+0900 I/EFL-ASSIST( 1285): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7e1be00) is freed
07-07 15:29:33.920+0900 I/EFL-ASSIST( 1285): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7e1bde8) from (/usr/apps/com.samsung.camera-app-lite/shared/res/tables/com.samsung.camera-app-lite_ChangeableColorInfo.xml) is created
07-07 15:29:33.930+0900 E/socket.io( 9486): 588: Client Disconnected.
07-07 15:29:33.930+0900 E/socket.io( 9486): 602: Close code 1000
07-07 15:29:33.930+0900 E/socket.io( 9486): clear timers
07-07 15:29:33.940+0900 I/EFL-ASSIST( 1285): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b210ecf8) from (/usr/apps/com.samsung.camera-app-lite/shared/res/tables/com.samsung.camera-app-lite_ChangeableFontInfo.xml) is created
07-07 15:29:33.940+0900 E/socket.io( 9486): 800: ping exit, con is expired? 1, ec: Operation canceled
07-07 15:29:33.940+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(772) > release - argv[0] : camera
07-07 15:29:33.950+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preinit_framework(772) > release - argv[1] : --gst-disable-registry-fork
07-07 15:29:33.950+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preload_framework(804) > start load plugin
07-07 15:29:33.950+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1285): media_content.c: media_content_connect(854) > [32m[1285]ref count : 0
07-07 15:29:33.950+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1285): media_content.c: media_content_connect(886) > [32m[1285]ref count changed to: 1
07-07 15:29:33.950+0900 W/CAM_APP ( 1285): cam.c: cam_create(223) > [33m############## cam_create END ##############[0m
07-07 15:29:33.960+0900 I/CAPI_APPFW_APPLICATION( 1285): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-07 15:29:33.960+0900 W/CAM_APP ( 1285): cam.c: cam_service(415) > [33m############## cam_service START ##############[0m
07-07 15:29:33.960+0900 W/CAPI_APPFW_APP_CONTROL( 1285): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-07 15:29:33.960+0900 W/CAM_APP ( 1285): cam.c: cam_service(464) > [33mapp state is [0][0m
07-07 15:29:33.960+0900 W/CAM_APP ( 1285): cam.c: cam_service(509) > [33mapp_control_get_operation is CAM_APP_PRELAUNCH_STATE[0m
07-07 15:29:33.960+0900 W/CAPI_APPFW_APP_CONTROL( 1285): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-07 15:29:33.960+0900 W/CAM_APP ( 1285): cam_app.c: cam_handle_init(1524) > [33mmode : 1 [0m
07-07 15:29:33.970+0900 W/CAM_APP ( 1285): cam_mm.c: cam_mm_create(1641) > [33mSTART[0m
07-07 15:29:33.970+0900 W/CAM_APP ( 1285): cam_sound_session_manager.c: cam_sound_session_create(49) > [33mcreate sound session[0m
07-07 15:29:33.970+0900 I/TIZEN_N_SOUND_MANAGER( 1285): sound_manager_product.c: sound_manager_multi_session_create(585) > >> enter : type=2, session=0xb34ae370
07-07 15:29:33.970+0900 I/TIZEN_N_SOUND_MANAGER( 1285): sound_manager_product.c: sound_manager_multi_session_create(637) > << leave : type=2, session=0xb34ae370
07-07 15:29:33.970+0900 W/TIZEN_N_CAMERA( 1285): camera.c: camera_create(764) > [camera_create]device name = [0]
07-07 15:29:33.980+0900 W/TIZEN_N_CAMERA( 1285): camera.c: camera_create(824) > camera handle 0xb7e86e00
07-07 15:29:33.980+0900 W/TIZEN_N_RECORDER( 1285): recorder.c: recorder_create_videorecorder(422) > permission check done
07-07 15:29:33.990+0900 W/CAM_APP ( 1285): cam_mm.c: cam_mm_create(1696) > [33mEND[0m
07-07 15:29:34.000+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_start(684) > [33m############# cam_app_start - START #############[0m
07-07 15:29:34.000+0900 E/TIZEN_N_RECORDER( 1285): recorder.c: __convert_recorder_error_code(192) > [recorder_set_video_resolution] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-07 15:29:34.000+0900 E/TIZEN_N_RECORDER( 1285): recorder.c: __convert_recorder_error_code(192) > [recorder_attr_set_recording_flip] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-07 15:29:34.000+0900 E/TIZEN_N_CAMERA( 1285): camera.c: camera_attr_enable_anti_shake(3351) > NOT SUPPORTED
07-07 15:29:34.010+0900 E/CAM_APP ( 1285): cam_mm.c: cam_mm_set_anti_hand_shake(329) > [31mcamera_attr_enable_anti_shake failed - code[c0000002][0m
07-07 15:29:34.010+0900 I/TIZEN_N_CAMERA( 1285): camera.c: camera_get_recommended_preview_resolution(1968) > recommend resolution 800x480, type 1
07-07 15:29:34.010+0900 E/CAM_APP ( 1285): cam_app.c: cam_app_start(701) > [31mcam_app_init_attribute failed[0m
07-07 15:29:34.010+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_start(711) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not start preview[0m
07-07 15:29:34.010+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_start(729) > [33m############# cam_app_start - END #############[0m
07-07 15:29:34.050+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9486 pgid = 9486
07-07 15:29:34.050+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(9486)
07-07 15:29:34.050+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:29:34.050+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:29:34.080+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:29:34.080+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:29:34.080+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[9486] terminate event is forwarded
07-07 15:29:34.080+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:29:34.080+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 9486, ]
07-07 15:29:34.080+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:29:34.080+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:29:34.080+0900 I/Tizen::App( 1034): (512) > Not registered pid(9486)
07-07 15:29:34.080+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 9486.
07-07 15:29:34.080+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9486
07-07 15:29:34.090+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:29:34.090+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 9486.
07-07 15:29:34.140+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_create_main_view(1257) > [33mSTART:[0][0m
07-07 15:29:34.150+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_destroy_main_view(1309) > [33mSTART:[0][0m
07-07 15:29:34.150+0900 W/CAM_APP ( 1285): cam_standby_view.c: cam_standby_view_destroy(2398) > [33mstandby_view is NULL[0m
07-07 15:29:34.150+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_destroy_main_view(1334) > [33mEND[0m
07-07 15:29:34.290+0900 E/EFL     ( 1285): evas_main<1285> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:29:34.310+0900 E/EFL     ( 1285): evas_main<1285> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:29:34.320+0900 I/Tizen::App( 1034): (499) > LaunchedApp(com.samsung.camera-app-lite)
07-07 15:29:34.330+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 1285.
07-07 15:29:34.340+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 1285.
07-07 15:29:34.360+0900 I/TIZEN_N_CAMERA( 1285): camera_product.c: camera_preload_framework(814) > done load plugin
07-07 15:29:34.360+0900 W/CAM_APP ( 1285): cam.c: __cam_preloading_thread_run(842) > [33mEND[0m
07-07 15:29:34.460+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_create_main_view(1303) > [33mEND[0m
07-07 15:29:34.460+0900 W/CAM_APP ( 1285): cam.c: cam_service(594) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not show window[0m
07-07 15:29:34.470+0900 W/CAM_APP ( 1285): cam.c: cam_service(730) > [33m############## cam_service END ##############[0m
07-07 15:29:34.480+0900 I/APP_CORE( 1285): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-07 15:29:34.480+0900 I/APP_CORE( 1285): appcore-efl.c: __do_app(511) > [APP 1285] Initial Launching, call the resume_cb
07-07 15:29:34.480+0900 I/CAPI_APPFW_APPLICATION( 1285): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-07 15:29:34.480+0900 W/CAM_APP ( 1285): cam.c: cam_resume(345) > [33m############## cam_resume START ##############[0m
07-07 15:29:34.480+0900 W/CAM_APP ( 1285): cam.c: cam_resume(356) > [33mapp state is CAM_APP_PRELAUNCH_STATE[0m
07-07 15:29:34.480+0900 W/CAM_APP ( 1285): cam.c: __app_init_idler(926) > [33mSTART[0m
07-07 15:29:34.480+0900 W/CAM_APP ( 1285): cam_shot.c: cam_shot_create(254) > [33mstart[0m
07-07 15:29:34.480+0900 W/CAM_APP ( 1285): cam_shot.c: cam_shot_create(270) > [33mend[0m
07-07 15:29:34.490+0900 W/CAM_APP ( 1285): cam_lbs.c: cam_lbs_init(190) > [33mstart[0m
07-07 15:29:34.500+0900 W/LOCATION( 1285): module-internal.c: module_is_supported(282) > module name(gps) is found
07-07 15:29:34.520+0900 I/PRIVACY-MANAGER-CLIENT( 1285): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
07-07 15:29:34.520+0900 I/PRIVACY-MANAGER-CLIENT( 1285): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
07-07 15:29:34.520+0900 I/PRIVACY-MANAGER-CLIENT( 1285): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
07-07 15:29:34.550+0900 I/PRIVACY-MANAGER-CLIENT( 1285): PrivacyChecker.cpp: initializeDbus(245) > Initialized
07-07 15:29:34.550+0900 I/PRIVACY-MANAGER-CLIENT( 1285): PrivacyChecker.cpp: initialize(192) > Initialized
07-07 15:29:34.560+0900 W/LOCATION( 1285): module-internal.c: module_is_supported(282) > module name(gps) is found
07-07 15:29:34.580+0900 W/LOCATION( 1285): module-internal.c: module_new(253) > module (gps) open success
07-07 15:29:34.600+0900 W/LOCATION( 1285): module-internal.c: module_is_supported(282) > module name(wps) is found
07-07 15:29:34.610+0900 W/LOCATION( 1285): module-internal.c: module_new(253) > module (wps) open success
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_lbs.c: cam_lbs_init(228) > [33mend[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(32) > [33mSTART[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(49) > [33mg_key_file_load_from_file failed: No such file or directory[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_camera_control_thread_run(8494) > [33mstart[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(55) > [33mload default data for dreamshot[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(67) > [33mEND[0m
07-07 15:29:34.630+0900 W/CAM_APP ( 1285): cam.c: __app_init_idler(961) > [33mEND[0m
07-07 15:29:34.660+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_join_thread_async_cb(5880) > [33mjoin thread [0][0m
07-07 15:29:34.660+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 0[0m
07-07 15:29:34.660+0900 W/CAM_APP ( 1285): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 0[0m
07-07 15:29:34.820+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:29:34.820+0900 W/AUL_AMD (  452): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-07 15:29:35.110+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-07 15:29:35.120+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-07 15:29:35.160+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-07 15:29:35.370+0900 I/UXT     ( 9580): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-07 15:29:35.600+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-07 15:30:37.660+0900 E/PKGMGR_SERVER( 9873): pkgmgr-server.c: main(1608) > server start
07-07 15:30:39.830+0900 E/PKGMGR_SERVER( 9873): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:30:39.830+0900 E/PKGMGR_SERVER( 9873): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:30:42.360+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: main(1608) > server start
07-07 15:30:42.420+0900 E/PKGMGR  ( 9980): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-07 15:30:42.420+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-07 15:30:42.420+0900 E/PKGMGR_SERVER( 9980): [0;m
07-07 15:30:42.580+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-07 15:30:42.580+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [96]
07-07 15:30:42.590+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-07 15:30:42.710+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-07 15:30:42.710+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-07 15:30:42.710+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [96]
07-07 15:30:44.830+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-07 15:30:44.830+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-07 15:30:44.830+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-07 15:30:44.830+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [96]
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-07 15:30:44.840+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-07 15:30:45.040+0900 E/PKGMGR_CERT( 9981): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-07 15:30:45.040+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-07 15:30:45.500+0900 E/rpm-installer( 9981): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-07 15:30:46.830+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-07 15:30:47.340+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-07 15:30:47.340+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-07 15:30:47.340+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [96]
07-07 15:30:47.350+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-07 15:30:47.350+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-07 15:30:47.350+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-07 15:30:47.360+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-07 15:30:47.360+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-07 15:30:47.360+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-07 15:30:47.390+0900 E/PKGMGR_INFO( 9981): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-07 15:30:47.400+0900 E/PKGMGR_INSTALLER( 9981): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-07 15:30:47.400+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-07 15:30:47.480+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-07 15:30:47.480+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-07 15:30:47.480+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-07 15:30:47.480+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-07 15:30:47.490+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-07 15:30:47.490+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:30:47.490+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (695) > Exit.
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [1]
07-07 15:30:47.490+0900 I/Tizen::App( 1034): (855) > Enter.
07-07 15:30:47.500+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:30:47.500+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-07 15:30:47.500+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-07 15:30:47.500+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-07 15:30:47.500+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-07 15:30:47.510+0900 I/Tizen::App( 1034): (131) > Enter
07-07 15:30:47.510+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-07 15:30:47.510+0900 I/Tizen::App( 1034): (898) > Exit.
07-07 15:30:48.830+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-07 15:30:48.830+0900 E/PKGMGR_SERVER( 9980): pkgmgr-server.c: main(1704) > package manager server terminated.
07-07 15:30:49.000+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-07 15:30:49.010+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-07 15:30:49.020+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-07 15:30:49.020+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-07 15:30:49.100+0900 I/CAPI_APPFW_APPLICATION(10061): app_main.c: ui_app_main(699) > app_efl_main
07-07 15:30:49.130+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 420
07-07 15:30:49.150+0900 I/UXT     (10061): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-07 15:30:49.170+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 10061.
07-07 15:30:49.180+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-07 15:30:49.180+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 10061.
07-07 15:30:49.200+0900 I/CAPI_APPFW_APPLICATION(10061): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-07 15:30:49.470+0900 I/CAPI_APPFW_APPLICATION(10061): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-07 15:30:49.480+0900 I/APP_CORE(10061): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-07 15:30:49.480+0900 I/APP_CORE(10061): appcore-efl.c: __do_app(511) > [APP 10061] Initial Launching, call the resume_cb
07-07 15:30:49.480+0900 I/CAPI_APPFW_APPLICATION(10061): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-07 15:30:49.480+0900 W/APP_CORE(10061): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-07 15:30:49.520+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10061
07-07 15:30:49.560+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:30:49.570+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 10061"
07-07 15:30:49.580+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-07 15:30:49.630+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-07 15:30:49.630+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:30:49.640+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:30:49.650+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-07 15:30:49.650+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-07 15:30:49.680+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:30:49.680+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:30:51.980+0900 I/MALI    (10061): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187d0] swap changed from async to sync
07-07 15:30:52.470+0900 I/nornenjs(10061): Timer expired after 3.001 seconds.
07-07 15:30:52.470+0900 E/EFL     (10061): ecore<10061> ecore.c:568 _ecore_magic_fail() 
07-07 15:30:52.470+0900 E/EFL     (10061): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-07 15:30:52.470+0900 E/EFL     (10061): *** IN FUNCTION: ecore_timer_delay()
07-07 15:30:52.470+0900 E/EFL     (10061): ecore<10061> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-07 15:30:52.470+0900 E/EFL     (10061): ecore<10061> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-07 15:30:52.470+0900 E/EFL     (10061): *** SPANK SPANK SPANK!!!
07-07 15:30:52.470+0900 E/EFL     (10061): *** Now go fix your code. Tut tut tut!
07-07 15:30:52.490+0900 E/EFL     (10061): evas_main<10061> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:30:52.510+0900 E/EFL     (10061): evas_main<10061> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:31:42.180+0900 E/socket.io(10061): 566: Connected.
07-07 15:31:42.180+0900 E/socket.io(10061): 554: On handshake, sid
07-07 15:31:42.180+0900 E/socket.io(10061): 651: Received Message type(connect)
07-07 15:31:42.180+0900 E/socket.io(10061): 489: On Connected
07-07 15:31:42.190+0900 F/sio_packet(10061): accept()
07-07 15:31:42.190+0900 E/socket.io(10061): 743: encoded paylod length: 18
07-07 15:31:42.200+0900 E/socket.io(10061): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:31:42.280+0900 E/socket.io(10061): 669: Received Message type(Event)
07-07 15:31:42.280+0900 F/sio_packet(10061): accept()
07-07 15:31:42.280+0900 E/socket.io(10061): 743: encoded paylod length: 21
07-07 15:31:42.290+0900 E/socket.io(10061): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:31:42.330+0900 E/socket.io(10061): 669: Received Message type(Event)
07-07 15:31:42.330+0900 F/get_binary(10061): in get binary_message()...
07-07 15:31:49.060+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:31:49.060+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:31:49.070+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 10061 pgid = 10061
07-07 15:31:49.070+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(10061)
07-07 15:31:49.070+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:31:49.070+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:31:49.080+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:31:49.080+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:31:49.080+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[10061] terminate event is forwarded
07-07 15:31:49.080+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:31:49.080+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 10061, ]
07-07 15:31:49.080+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:31:49.080+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:31:49.080+0900 I/Tizen::App( 1034): (512) > Not registered pid(10061)
07-07 15:31:49.080+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 10061.
07-07 15:31:49.090+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 10061
07-07 15:31:49.090+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:31:49.090+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 10061.
07-07 15:31:49.120+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:31:49.140+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:31:49.140+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:31:49.180+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:31:49.180+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:31:49.190+0900 W/CRASH_MANAGER(10362): worker.c: worker_job(1236) > 11100616e6f72143625070
