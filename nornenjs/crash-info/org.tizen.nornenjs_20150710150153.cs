S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 5140
Date: 2015-07-10 15:01:53+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb0f88004

Register Information
r0   = 0xb0f88008, r1   = 0xb4daf99b
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0xb7e4f200, r5   = 0xb0f88008
r6   = 0xb7e4d3a8, r7   = 0xbef82a70
r8   = 0x000002a3, r9   = 0xb654c218
r10  = 0xb654c2dc, fp   = 0xb654ba3c
ip   = 0xb4de7c88, sp   = 0xbef82a58
lr   = 0xb4daf99b, pc   = 0xb6cd6150
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    223056 KB
Buffers:     35768 KB
Cached:     153036 KB
VmPeak:     104652 KB
VmSize:     104648 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19048 KB
VmRSS:       19044 KB
VmData:      48576 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5140 TID = 5140
5140 5143 5144 5170 

Maps Information
b120a000 b1a09000 rw-p [stack:5170]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:5143]
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
b6f91000 b6f94000 rw-p [stack:5144]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b803b000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b803b000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5140)
Call Stack Count: 32
 0: cfree + 0x30 (0xb6cd6150) [/lib/libc.so.6] + 0x6f150
 1: clear_image_pointer + 0x3a (0xb4daf99b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x8e99b
 2: destroy_gles + 0x34 (0xb4d2b865) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xa865
 3: (0xb64bb8dd) [/usr/lib/libelementary.so.1] + 0x998dd
 4: (0xb6308e5b) [/usr/lib/libevas.so.1] + 0x35e5b
 5: evas_object_del + 0x174 (0xb630028d) [/usr/lib/libevas.so.1] + 0x2d28d
 6: (0xb6516ccf) [/usr/lib/libelementary.so.1] + 0xf4ccf
 7: (0xb647799d) [/usr/lib/libelementary.so.1] + 0x5599d
 8: (0xb6308e5b) [/usr/lib/libevas.so.1] + 0x35e5b
 9: evas_object_del + 0x174 (0xb630028d) [/usr/lib/libevas.so.1] + 0x2d28d
10: (0xb6516ccf) [/usr/lib/libelementary.so.1] + 0xf4ccf
11: (0xb64d29fd) [/usr/lib/libelementary.so.1] + 0xb09fd
12: (0xb6308e5b) [/usr/lib/libevas.so.1] + 0x35e5b
13: evas_object_del + 0x174 (0xb630028d) [/usr/lib/libevas.so.1] + 0x2d28d
14: _elm_widget_item_free + 0x76 (0xb651b66f) [/usr/lib/libelementary.so.1] + 0xf966f
15: (0xb64cfe6d) [/usr/lib/libelementary.so.1] + 0xade6d
16: (0xb6254f7d) [/usr/lib/libedje.so.1] + 0x43f7d
17: (0xb6259955) [/usr/lib/libedje.so.1] + 0x48955
18: (0xb62558d9) [/usr/lib/libedje.so.1] + 0x448d9
19: (0xb6255c8b) [/usr/lib/libedje.so.1] + 0x44c8b
20: (0xb6255dc5) [/usr/lib/libedje.so.1] + 0x44dc5
21: (0xb6bdf20d) [/usr/lib/libecore.so.1] + 0xa20d
22: (0xb6bdcc6b) [/usr/lib/libecore.so.1] + 0x7c6b
23: (0xb6be0283) [/usr/lib/libecore.so.1] + 0xb283
24: ecore_main_loop_begin + 0x30 (0xb6be0691) [/usr/lib/libecore.so.1] + 0xb691
25: appcore_efl_main + 0x17e (0xb6f96387) [/usr/lib/libappcore-efl.so.1] + 0x2387
26: ui_app_main + 0xb0 (0xb657a499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
27: main + 0x146 (0xb4d2b68b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xa68b
28: (0xb6fd6dc7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x2dc7
29: (0xb6fd5d8f) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x1d8f
30: __libc_start_main + 0x114 (0xb6c7e82c) [/lib/libc.so.6] + 0x1782c
31: (0xb6fd60d4) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x20d4
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
> Finished invoking application event listener for org.tizen.nornenjs, 2356.
07-10 14:52:27.174+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2356
07-10 14:52:27.184+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:52:27.184+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 2356.
07-10 14:52:27.204+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 14:52:27.234+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:52:27.254+0900 W/CRASH_MANAGER( 2402): worker.c: worker_job(1236) > 11023566e6f721436507546
07-10 14:52:27.264+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 14:52:27.264+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 14:52:27.304+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-10 14:52:27.304+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:52:27.324+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:52:27.344+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-10 14:52:28.624+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:52:28.624+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:52:29.624+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-10 14:53:40.604+0900 E/PKGMGR_SERVER( 2771): pkgmgr-server.c: main(1608) > server start
07-10 14:53:42.534+0900 E/PKGMGR_SERVER( 2771): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 14:53:42.534+0900 E/PKGMGR_SERVER( 2771): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 14:53:45.224+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: main(1608) > server start
07-10 14:53:45.284+0900 E/PKGMGR  ( 2875): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-10 14:53:45.284+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-10 14:53:45.284+0900 E/PKGMGR_SERVER( 2875): [0;m
07-10 14:53:45.454+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-10 14:53:45.454+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-10 14:53:45.474+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-10 14:53:45.584+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-10 14:53:45.584+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-10 14:53:45.584+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-10 14:53:47.534+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 14:53:47.694+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-10 14:53:47.694+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-10 14:53:47.694+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-10 14:53:48.094+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-10 14:53:48.114+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-10 14:53:48.124+0900 E/PKGMGR_CERT( 2877): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-10 14:53:48.134+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-10 14:53:48.604+0900 E/rpm-installer( 2877): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-10 14:53:49.534+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 14:53:50.464+0900 E/PKGMGR_INFO( 2877): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-10 14:53:50.464+0900 E/PKGMGR_INSTALLER( 2877): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-10 14:53:50.464+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-10 14:53:50.474+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-10 14:53:50.474+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-10 14:53:50.474+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-10 14:53:50.494+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-10 14:53:50.524+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-10 14:53:50.544+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 14:53:50.544+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 14:53:50.544+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 14:53:50.544+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-10 14:53:50.544+0900 I/Tizen::App( 1034): (855) > Enter.
07-10 14:53:50.554+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-10 14:53:50.554+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-10 14:53:50.554+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-10 14:53:50.554+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-10 14:53:50.554+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-10 14:53:50.554+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 14:53:50.554+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 14:53:50.554+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-10 14:53:50.554+0900 I/Tizen::App( 1034): (131) > Enter
07-10 14:53:50.564+0900 I/Tizen::App( 1034): (695) > Exit.
07-10 14:53:50.564+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-10 14:53:50.564+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-10 14:53:50.564+0900 I/Tizen::App( 1034): (898) > Exit.
07-10 14:53:50.574+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 14:53:50.574+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 14:53:51.534+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 14:53:51.534+0900 E/PKGMGR_SERVER( 2875): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 14:53:52.184+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-10 14:53:52.194+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-10 14:53:52.194+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-10 14:53:52.194+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-10 14:53:52.274+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: ui_app_main(699) > app_efl_main
07-10 14:53:52.314+0900 I/UXT     ( 2957): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-10 14:53:52.334+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 436
07-10 14:53:52.344+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 2957.
07-10 14:53:52.344+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-10 14:53:52.344+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 2957.
07-10 14:53:52.384+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-10 14:53:52.644+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-10 14:53:52.654+0900 I/APP_CORE( 2957): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-10 14:53:52.654+0900 I/APP_CORE( 2957): appcore-efl.c: __do_app(511) > [APP 2957] Initial Launching, call the resume_cb
07-10 14:53:52.664+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-10 14:53:52.694+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2957
07-10 14:53:52.704+0900 W/APP_CORE( 2957): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-10 14:53:52.744+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:53:52.764+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 2957"
07-10 14:53:52.764+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-10 14:53:52.814+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-10 14:53:52.824+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:53:52.834+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:53:52.844+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-10 14:53:52.844+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-10 14:53:52.884+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:53:52.884+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:53:53.664+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:53.664+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:53.664+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:53:53.724+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:53.724+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:53.724+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:53:54.084+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:54.084+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:54.084+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:53:55.204+0900 I/MALI    ( 2957): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-10 14:53:55.644+0900 I/nornenjs( 2957): Timer expired after 3.001 seconds.
07-10 14:53:55.644+0900 E/EFL     ( 2957): ecore<2957> ecore.c:568 _ecore_magic_fail() 
07-10 14:53:55.644+0900 E/EFL     ( 2957): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-10 14:53:55.644+0900 E/EFL     ( 2957): *** IN FUNCTION: ecore_timer_delay()
07-10 14:53:55.644+0900 E/EFL     ( 2957): ecore<2957> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-10 14:53:55.644+0900 E/EFL     ( 2957): ecore<2957> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-10 14:53:55.644+0900 E/EFL     ( 2957): *** SPANK SPANK SPANK!!!
07-10 14:53:55.644+0900 E/EFL     ( 2957): *** Now go fix your code. Tut tut tut!
07-10 14:53:55.674+0900 E/EFL     ( 2957): evas_main<2957> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-10 14:53:55.694+0900 E/EFL     ( 2957): evas_main<2957> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-10 14:53:57.284+0900 E/socket.io( 2957): 566: Connected.
07-10 14:53:57.284+0900 E/socket.io( 2957): 554: On handshake, sid
07-10 14:53:57.284+0900 E/socket.io( 2957): 651: Received Message type(connect)
07-10 14:53:57.284+0900 E/socket.io( 2957): 489: On Connected
07-10 14:53:57.284+0900 F/sio_packet( 2957): accept()
07-10 14:53:57.284+0900 E/socket.io( 2957): 743: encoded paylod length: 41
07-10 14:53:57.284+0900 E/socket.io( 2957): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:53:57.374+0900 E/socket.io( 2957): 669: Received Message type(Event)
07-10 14:53:57.374+0900 F/sio_packet( 2957): accept()
07-10 14:53:57.374+0900 E/socket.io( 2957): 743: encoded paylod length: 21
07-10 14:53:57.374+0900 E/socket.io( 2957): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:53:57.414+0900 E/socket.io( 2957): 669: Received Message type(Event)
07-10 14:53:57.414+0900 F/get_binary( 2957): in get binary_message()...
07-10 14:53:57.434+0900 I/nornenjs_queue( 2957): Queue push
07-10 14:53:57.444+0900 I/nornenjs_queue( 2957): Queue pop
07-10 14:53:57.624+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:57.624+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:53:57.624+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:58.104+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:58.104+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:53:58.114+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:58.454+0900 E/socket.io( 2957): 849: Close by reason: End by user
07-10 14:53:58.454+0900 F/sio_packet( 2957): accept()
07-10 14:53:58.454+0900 E/socket.io( 2957): 867: __close paylod  1000
07-10 14:53:58.474+0900 E/socket.io( 2957): 588: Client Disconnected.
07-10 14:53:58.474+0900 E/socket.io( 2957): 602: Close code 1000
07-10 14:53:58.474+0900 E/socket.io( 2957): clear timers
07-10 14:53:58.474+0900 E/socket.io( 2957): 800: ping exit, con is expired? 1, ec: Operation canceled
07-10 14:53:59.724+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:59.724+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:53:59.724+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:54:01.104+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:54:01.104+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:54:01.104+0900 I/CAPI_APPFW_APPLICATION( 2957): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:54:01.404+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2957 pgid = 2957
07-10 14:54:01.404+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(2957)
07-10 14:54:01.404+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-10 14:54:01.404+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-10 14:54:01.414+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-10 14:54:01.414+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:54:01.424+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2957
07-10 14:54:01.424+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[2957] terminate event is forwarded
07-10 14:54:01.424+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 14:54:01.424+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 2957, ]
07-10 14:54:01.424+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 14:54:01.424+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-10 14:54:01.424+0900 I/Tizen::App( 1034): (512) > Not registered pid(2957)
07-10 14:54:01.424+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 2957.
07-10 14:54:01.454+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:54:01.454+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:54:01.464+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:54:01.464+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 2957.
07-10 14:54:01.514+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 14:54:01.534+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:54:01.544+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 14:54:01.544+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 14:54:01.554+0900 W/CRASH_MANAGER( 3006): worker.c: worker_job(1236) > 11029576e6f721436507641
07-10 14:54:01.564+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-10 14:54:01.594+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-10 14:54:01.594+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:54:01.614+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:54:02.864+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:54:02.864+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:54:03.894+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-10 14:55:52.664+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-10 14:55:52.744+0900 I/CAPI_APPFW_APPLICATION( 3498): app_main.c: ui_app_main(699) > app_efl_main
07-10 14:55:52.774+0900 I/UXT     ( 3498): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-10 14:55:52.794+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 437
07-10 14:55:52.814+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 3498.
07-10 14:55:52.824+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-10 14:55:52.834+0900 I/CAPI_APPFW_APPLICATION( 3498): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-10 14:55:52.834+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 3498.
07-10 14:55:53.084+0900 I/CAPI_APPFW_APPLICATION( 3498): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-10 14:55:53.094+0900 I/APP_CORE( 3498): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-10 14:55:53.094+0900 I/APP_CORE( 3498): appcore-efl.c: __do_app(511) > [APP 3498] Initial Launching, call the resume_cb
07-10 14:55:53.094+0900 I/CAPI_APPFW_APPLICATION( 3498): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-10 14:55:53.094+0900 W/APP_CORE( 3498): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-10 14:55:53.124+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3498
07-10 14:55:53.174+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:55:53.184+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 3498"
07-10 14:55:53.184+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-10 14:55:53.244+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-10 14:55:53.244+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:55:53.254+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:55:53.264+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-10 14:55:53.264+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-10 14:55:55.594+0900 I/MALI    ( 3498): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d188f0] swap changed from async to sync
07-10 14:55:56.084+0900 I/nornenjs( 3498): Timer expired after 3.001 seconds.
07-10 14:55:56.084+0900 E/EFL     ( 3498): ecore<3498> ecore.c:568 _ecore_magic_fail() 
07-10 14:55:56.084+0900 E/EFL     ( 3498): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-10 14:55:56.084+0900 E/EFL     ( 3498): *** IN FUNCTION: ecore_timer_delay()
07-10 14:55:56.084+0900 E/EFL     ( 3498): ecore<3498> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-10 14:55:56.084+0900 E/EFL     ( 3498): ecore<3498> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-10 14:55:56.084+0900 E/EFL     ( 3498): *** SPANK SPANK SPANK!!!
07-10 14:55:56.084+0900 E/EFL     ( 3498): *** Now go fix your code. Tut tut tut!
07-10 14:55:56.104+0900 E/EFL     ( 3498): evas_main<3498> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-10 14:55:56.124+0900 E/EFL     ( 3498): evas_main<3498> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-10 14:55:56.844+0900 E/socket.io( 3498): 566: Connected.
07-10 14:55:56.854+0900 E/socket.io( 3498): 554: On handshake, sid
07-10 14:55:56.854+0900 E/socket.io( 3498): 651: Received Message type(connect)
07-10 14:55:56.854+0900 E/socket.io( 3498): 489: On Connected
07-10 14:55:56.854+0900 F/sio_packet( 3498): accept()
07-10 14:55:56.854+0900 E/socket.io( 3498): 743: encoded paylod length: 41
07-10 14:55:56.854+0900 E/socket.io( 3498): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:55:56.954+0900 E/socket.io( 3498): 669: Received Message type(Event)
07-10 14:55:56.954+0900 F/sio_packet( 3498): accept()
07-10 14:55:56.954+0900 E/socket.io( 3498): 743: encoded paylod length: 21
07-10 14:55:56.954+0900 E/socket.io( 3498): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:55:56.994+0900 E/socket.io( 3498): 669: Received Message type(Event)
07-10 14:55:56.994+0900 F/get_binary( 3498): in get binary_message()...
07-10 14:55:57.014+0900 I/nornenjs_queue( 3498): Queue push
07-10 14:55:57.014+0900 I/nornenjs_queue( 3498): Queue pop
07-10 14:55:59.294+0900 E/socket.io( 3498): 849: Close by reason: End by user
07-10 14:55:59.294+0900 F/sio_packet( 3498): accept()
07-10 14:55:59.294+0900 E/socket.io( 3498): 867: __close paylod  1000
07-10 14:55:59.324+0900 E/socket.io( 3498): 588: Client Disconnected.
07-10 14:55:59.324+0900 E/socket.io( 3498): 602: Close code 1000
07-10 14:55:59.324+0900 E/socket.io( 3498): clear timers
07-10 14:55:59.324+0900 E/socket.io( 3498): 800: ping exit, con is expired? 1, ec: Operation canceled
07-10 14:59:46.654+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3498 pgid = 3498
07-10 14:59:46.654+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(3498)
07-10 14:59:46.654+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-10 14:59:46.654+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-10 14:59:46.664+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-10 14:59:46.664+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:59:46.664+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[3498] terminate event is forwarded
07-10 14:59:46.664+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 14:59:46.664+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 3498, ]
07-10 14:59:46.664+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 14:59:46.664+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-10 14:59:46.664+0900 I/Tizen::App( 1034): (512) > Not registered pid(3498)
07-10 14:59:46.664+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 3498.
07-10 14:59:46.664+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:59:46.664+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:59:46.674+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3498
07-10 14:59:46.684+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:59:46.684+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 3498.
07-10 14:59:46.694+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:59:46.724+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-10 14:59:46.764+0900 W/CRASH_MANAGER( 4469): worker.c: worker_job(1236) > 11034986e6f721436507986
07-10 14:59:46.774+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 14:59:46.804+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 14:59:46.804+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 14:59:46.864+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-10 14:59:46.864+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:59:46.874+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:59:49.164+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-10 15:01:28.474+0900 E/PKGMGR_SERVER( 4958): pkgmgr-server.c: main(1608) > server start
07-10 15:01:30.534+0900 E/PKGMGR_SERVER( 4958): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 15:01:30.534+0900 E/PKGMGR_SERVER( 4958): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 15:01:33.634+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: main(1608) > server start
07-10 15:01:33.684+0900 E/PKGMGR  ( 5064): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-10 15:01:33.684+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-10 15:01:33.684+0900 E/PKGMGR_SERVER( 5064): [0;m
07-10 15:01:33.854+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-10 15:01:33.854+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-10 15:01:33.864+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-10 15:01:34.214+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-10 15:01:34.214+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-10 15:01:34.214+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-10 15:01:35.534+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 15:01:36.334+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-10 15:01:36.334+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-10 15:01:36.334+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-10 15:01:36.334+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-10 15:01:36.344+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-10 15:01:36.484+0900 E/PKGMGR_CERT( 5066): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-10 15:01:36.484+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-10 15:01:37.014+0900 E/rpm-installer( 5066): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-10 15:01:37.534+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 15:01:37.884+0900 E/PKGMGR_INFO( 5066): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-10 15:01:37.884+0900 E/PKGMGR_INSTALLER( 5066): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-10 15:01:37.894+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-10 15:01:37.894+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-10 15:01:37.894+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-10 15:01:37.894+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-10 15:01:37.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-10 15:01:37.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-10 15:01:37.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-10 15:01:37.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-10 15:01:37.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-10 15:01:37.944+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-10 15:01:37.974+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-10 15:01:37.984+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 15:01:37.984+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 15:01:37.984+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 15:01:37.984+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 15:01:37.984+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 15:01:37.984+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-10 15:01:37.984+0900 I/Tizen::App( 1034): (855) > Enter.
07-10 15:01:37.994+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 15:01:37.994+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 15:01:37.994+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-10 15:01:37.994+0900 I/Tizen::App( 1034): (131) > Enter
07-10 15:01:38.004+0900 I/Tizen::App( 1034): (695) > Exit.
07-10 15:01:38.004+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-10 15:01:38.004+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-10 15:01:38.004+0900 I/Tizen::App( 1034): (898) > Exit.
07-10 15:01:39.354+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-10 15:01:39.364+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-10 15:01:39.364+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-10 15:01:39.364+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-10 15:01:39.444+0900 I/CAPI_APPFW_APPLICATION( 5140): app_main.c: ui_app_main(699) > app_efl_main
07-10 15:01:39.484+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 435
07-10 15:01:39.494+0900 I/UXT     ( 5140): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-10 15:01:39.524+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 5140.
07-10 15:01:39.524+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-10 15:01:39.524+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 5140.
07-10 15:01:39.534+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 15:01:39.534+0900 E/PKGMGR_SERVER( 5064): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 15:01:39.574+0900 I/CAPI_APPFW_APPLICATION( 5140): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-10 15:01:39.844+0900 I/CAPI_APPFW_APPLICATION( 5140): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-10 15:01:39.854+0900 I/APP_CORE( 5140): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-10 15:01:39.854+0900 I/APP_CORE( 5140): appcore-efl.c: __do_app(511) > [APP 5140] Initial Launching, call the resume_cb
07-10 15:01:39.854+0900 I/CAPI_APPFW_APPLICATION( 5140): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-10 15:01:39.854+0900 W/APP_CORE( 5140): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-10 15:01:39.894+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5140
07-10 15:01:39.934+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 15:01:39.954+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 5140"
07-10 15:01:39.974+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-10 15:01:39.984+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-10 15:01:39.994+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-10 15:01:39.994+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-10 15:01:40.004+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 15:01:40.044+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 15:01:40.044+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 15:01:40.044+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 15:01:42.344+0900 I/MALI    ( 5140): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-10 15:01:42.834+0900 I/nornenjs( 5140): Timer expired after 3.001 seconds.
07-10 15:01:42.834+0900 E/EFL     ( 5140): ecore<5140> ecore.c:568 _ecore_magic_fail() 
07-10 15:01:42.834+0900 E/EFL     ( 5140): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-10 15:01:42.834+0900 E/EFL     ( 5140): *** IN FUNCTION: ecore_timer_delay()
07-10 15:01:42.834+0900 E/EFL     ( 5140): ecore<5140> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-10 15:01:42.834+0900 E/EFL     ( 5140): ecore<5140> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-10 15:01:42.834+0900 E/EFL     ( 5140): *** SPANK SPANK SPANK!!!
07-10 15:01:42.834+0900 E/EFL     ( 5140): *** Now go fix your code. Tut tut tut!
07-10 15:01:42.864+0900 E/EFL     ( 5140): evas_main<5140> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-10 15:01:42.884+0900 E/EFL     ( 5140): evas_main<5140> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-10 15:01:45.144+0900 E/socket.io( 5140): 566: Connected.
07-10 15:01:45.144+0900 E/socket.io( 5140): 554: On handshake, sid
07-10 15:01:45.154+0900 E/socket.io( 5140): 651: Received Message type(connect)
07-10 15:01:45.154+0900 E/socket.io( 5140): 489: On Connected
07-10 15:01:45.154+0900 F/sio_packet( 5140): accept()
07-10 15:01:45.154+0900 E/socket.io( 5140): 743: encoded paylod length: 41
07-10 15:01:45.154+0900 E/socket.io( 5140): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 15:01:45.264+0900 E/socket.io( 5140): 669: Received Message type(Event)
07-10 15:01:45.264+0900 F/sio_packet( 5140): accept()
07-10 15:01:45.264+0900 E/socket.io( 5140): 743: encoded paylod length: 21
07-10 15:01:45.264+0900 E/socket.io( 5140): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 15:01:45.304+0900 E/socket.io( 5140): 669: Received Message type(Event)
07-10 15:01:45.304+0900 F/get_binary( 5140): in get binary_message()...
07-10 15:01:45.324+0900 I/nornenjs_queue( 5140): Queue push
07-10 15:01:45.324+0900 I/nornenjs_queue( 5140): Queue pop
07-10 15:01:52.954+0900 E/socket.io( 5140): 849: Close by reason: End by user
07-10 15:01:52.954+0900 F/sio_packet( 5140): accept()
07-10 15:01:52.954+0900 E/socket.io( 5140): 867: __close paylod  1000
07-10 15:01:52.974+0900 E/socket.io( 5140): 588: Client Disconnected.
07-10 15:01:52.974+0900 E/socket.io( 5140): 602: Close code 1000
07-10 15:01:52.974+0900 E/socket.io( 5140): clear timers
07-10 15:01:52.974+0900 E/socket.io( 5140): 800: ping exit, con is expired? 1, ec: Operation canceled
07-10 15:01:53.604+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5140 pgid = 5140
07-10 15:01:53.604+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(5140)
07-10 15:01:53.604+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-10 15:01:53.604+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-10 15:01:53.614+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-10 15:01:53.614+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 15:01:53.614+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[5140] terminate event is forwarded
07-10 15:01:53.614+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 15:01:53.614+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 5140, ]
07-10 15:01:53.614+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 15:01:53.614+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-10 15:01:53.614+0900 I/Tizen::App( 1034): (512) > Not registered pid(5140)
07-10 15:01:53.614+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 5140.
07-10 15:01:53.624+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5140
07-10 15:01:53.634+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 15:01:53.634+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 15:01:53.634+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 15:01:53.634+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 5140.
07-10 15:01:53.694+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 15:01:53.734+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 15:01:53.734+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 15:01:53.734+0900 W/CRASH_MANAGER( 5207): worker.c: worker_job(1236) > 11051406e6f72143650811
