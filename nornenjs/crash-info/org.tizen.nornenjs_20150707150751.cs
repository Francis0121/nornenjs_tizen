S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 1568
Date: 2015-07-07 15:07:51+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb13ff004

Register Information
r0   = 0xb13ff008, r1   = 0xb4db2fa7
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0xb4de8170, r5   = 0xb13ff008
r6   = 0xb7d838a0, r7   = 0xbef82c20
r8   = 0xb7fa0288, r9   = 0xb7eed968
r10  = 0xbef82cd8, fp   = 0x00000000
ip   = 0xb4de81f8, sp   = 0xbef82c08
lr   = 0xb4db2fa7, pc   = 0xb6cd6150
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:     83940 KB
Buffers:     46656 KB
Cached:     255632 KB
VmPeak:     102688 KB
VmSize:     102684 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26552 KB
VmRSS:       26548 KB
VmData:      48664 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1568 TID = 1568
1568 1569 1570 1605 1606 

Maps Information
b1bd5000 b23d4000 rw-p [stack:1606]
b23d5000 b2bd4000 rw-p [stack:1605]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:1569]
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
b6f91000 b6f94000 rw-p [stack:1570]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8579000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b8579000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1568)
Call Stack Count: 18
 0: cfree + 0x30 (0xb6cd6150) [/lib/libc.so.6] + 0x6f150
 1: destroy_thread_cb + 0x42 (0xb4db2fa7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x90fa7
 2: elm_naviframe_item_pop + 0x8e (0xb646d04b) [/usr/lib/libelementary.so.1] + 0x4b04b
 3: eext_naviframe_back_cb + 0x12 (0xb4d2bf63) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9f63
 4: (0xb4ce8fa7) [/usr/lib/libefl-extension.so.0] + 0xfa7
 5: (0xb62e9645) [/usr/lib/libevas.so.1] + 0x16645
 6: evas_event_feed_key_up + 0x496 (0xb62f0f1f) [/usr/lib/libevas.so.1] + 0x1df1f
 7: (0xb602c865) [/usr/lib/libecore_input_evas.so.1] + 0x1865
 8: (0xb6bdcc6b) [/usr/lib/libecore.so.1] + 0x7c6b
 9: (0xb6be0283) [/usr/lib/libecore.so.1] + 0xb283
10: ecore_main_loop_begin + 0x30 (0xb6be0691) [/usr/lib/libecore.so.1] + 0xb691
11: appcore_efl_main + 0x17e (0xb6f96387) [/usr/lib/libappcore-efl.so.1] + 0x2387
12: ui_app_main + 0xb0 (0xb657a499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
13: main + 0x146 (0xb4d2c643) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xa643
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
 fix your code. Tut tut tut!
07-07 15:07:33.660+0900 E/EFL     ( 1568): evas_main<1568> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-07 15:07:33.680+0900 E/EFL     ( 1568): evas_main<1568> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-07 15:07:34.850+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:34.850+0900 W/CAM_APP (17481): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-07 15:07:34.910+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:34.910+0900 W/CAM_APP (17481): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-07 15:07:34.910+0900 I/CAPI_APPFW_APPLICATION( 1568): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:37.550+0900 E/socket.io( 1568): 566: Connected.
07-07 15:07:37.560+0900 E/socket.io( 1568): 554: On handshake, sid
07-07 15:07:37.560+0900 E/socket.io( 1568): 651: Received Message type(connect)
07-07 15:07:37.560+0900 E/socket.io( 1568): 489: On Connected
07-07 15:07:37.560+0900 F/sio_packet( 1568): accept()
07-07 15:07:37.560+0900 E/socket.io( 1568): 743: encoded paylod length: 18
07-07 15:07:37.570+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:37.650+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:37.650+0900 F/sio_packet( 1568): accept()
07-07 15:07:37.650+0900 E/socket.io( 1568): 743: encoded paylod length: 21
07-07 15:07:37.650+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:37.700+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:37.700+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.280+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.280+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.280+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.320+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.320+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.320+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.320+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.320+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.340+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.340+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.340+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.350+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.350+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.360+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.360+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.360+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.370+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.370+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.380+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.380+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.390+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.390+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.390+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.400+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.400+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.410+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.410+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.410+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.420+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.420+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.430+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.430+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.430+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.430+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.440+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.440+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.450+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.450+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.450+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.450+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.450+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.460+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.460+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.460+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.460+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.470+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.470+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.470+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.470+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.480+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.480+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.490+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.490+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.500+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.500+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.500+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.500+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.510+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.520+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.520+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.530+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.530+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.540+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.540+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.540+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.540+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.540+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.550+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.550+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.560+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.560+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.560+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.570+0900 E/socket.io( 1568): 743: encoded paylod length: 67
07-07 15:07:46.580+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.580+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.580+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.590+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.590+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.590+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.600+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.600+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.600+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.600+0900 E/socket.io( 1568): 743: encoded paylod length: 67
07-07 15:07:46.610+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.620+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.620+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.620+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.630+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.630+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.630+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.640+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.640+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.650+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.650+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.650+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.660+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.660+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.660+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.670+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.670+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.670+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.670+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.680+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.680+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.680+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.690+0900 E/socket.io( 1568): 743: encoded paylod length: 65
07-07 15:07:46.700+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.700+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.700+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.710+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.710+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.710+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.710+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.710+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.710+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.720+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.730+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.730+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.730+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.730+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.730+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.740+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.740+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.750+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.750+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.750+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.760+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.760+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.770+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.770+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.770+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.780+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.780+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.780+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.780+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.780+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.790+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.790+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.790+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.800+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.800+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.810+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.810+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.820+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.820+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.820+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.830+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.840+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.840+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.850+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.850+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.860+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.870+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.870+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.870+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.870+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.880+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.880+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.890+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.890+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.900+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.900+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.900+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.910+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.920+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.920+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.930+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.930+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.940+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.940+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.940+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.940+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.940+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.960+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.960+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:46.970+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.970+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.970+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.980+0900 F/sio_packet( 1568): accept()
07-07 15:07:46.980+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:46.980+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:46.990+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:46.990+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.000+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.000+0900 E/socket.io( 1568): 743: encoded paylod length: 63
07-07 15:07:47.010+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.010+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.010+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.020+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.020+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.020+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.030+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.030+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.030+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.040+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.040+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.040+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.040+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.060+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.060+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.070+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.070+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.070+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.080+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.080+0900 E/socket.io( 1568): 743: encoded paylod length: 67
07-07 15:07:47.080+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.090+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.090+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.100+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.100+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.100+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.110+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.110+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.120+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.120+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.130+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.130+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.130+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.140+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.140+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.140+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.150+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.160+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.160+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.170+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.170+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.170+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.170+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.180+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.190+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.190+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.200+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.200+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.220+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.220+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.230+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.240+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.240+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.240+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.250+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.250+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.260+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.260+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.260+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.270+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.270+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.270+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.270+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.280+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.290+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.290+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.300+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.300+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.310+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.310+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.310+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.320+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.320+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.330+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.330+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.340+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.340+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.340+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.350+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.350+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.350+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.360+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.360+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.370+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.370+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.380+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.380+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.380+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.390+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.400+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.400+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.400+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.400+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.420+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.420+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.420+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.420+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.430+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.430+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.440+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.440+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.450+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.450+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.450+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.460+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.460+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.460+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.470+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.470+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.480+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.480+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.480+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.490+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.490+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.500+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.500+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.500+0900 E/socket.io( 1568): 743: encoded paylod length: 68
07-07 15:07:47.500+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.500+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:47.510+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.510+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.560+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.560+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.600+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:47.600+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:47.990+0900 F/sio_packet( 1568): accept()
07-07 15:07:47.990+0900 E/socket.io( 1568): 743: encoded paylod length: 73
07-07 15:07:47.990+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.030+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.030+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.030+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.040+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:48.040+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.060+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.060+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.070+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.070+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:48.070+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.090+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.090+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.100+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.100+0900 E/socket.io( 1568): 743: encoded paylod length: 73
07-07 15:07:48.100+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.120+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.120+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.130+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.130+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:48.130+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.150+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.150+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.160+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.160+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:48.170+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.190+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.190+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.200+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.200+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:48.200+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.220+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.220+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.230+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.230+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.230+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.260+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.260+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.260+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.270+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.270+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.290+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.290+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.300+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.300+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.300+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.320+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.320+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.330+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.330+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.330+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.360+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.360+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.370+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.370+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.370+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.390+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.390+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.400+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.400+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.400+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.420+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.420+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.430+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.430+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:48.430+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.450+0900 F/sio_packet( 1568): accept()
07-07 15:07:48.450+0900 E/socket.io( 1568): 743: encoded paylod length: 21
07-07 15:07:48.450+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:48.450+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.450+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:48.500+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:48.500+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.420+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.420+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.420+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.450+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.460+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.460+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.460+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.460+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.480+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.480+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.490+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.490+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.490+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.520+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.520+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.520+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.520+0900 E/socket.io( 1568): 743: encoded paylod length: 75
07-07 15:07:49.520+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.550+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.550+0900 E/socket.io( 1568): 743: encoded paylod length: 74
07-07 15:07:49.550+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.550+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.560+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.580+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.580+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.590+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.590+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.590+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.610+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.610+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.620+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.620+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.620+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.640+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.640+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.660+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.660+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.660+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.680+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.680+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.690+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.690+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.690+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.710+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.710+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.720+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.720+0900 E/socket.io( 1568): 743: encoded paylod length: 74
07-07 15:07:49.720+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.750+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.750+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.760+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.760+0900 E/socket.io( 1568): 743: encoded paylod length: 76
07-07 15:07:49.760+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.780+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.780+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:49.830+0900 F/sio_packet( 1568): accept()
07-07 15:07:49.840+0900 E/socket.io( 1568): 743: encoded paylod length: 21
07-07 15:07:49.840+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:49.880+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:49.880+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.410+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.410+0900 E/socket.io( 1568): 743: encoded paylod length: 56
07-07 15:07:50.410+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.420+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.420+0900 E/socket.io( 1568): 743: encoded paylod length: 56
07-07 15:07:50.420+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.440+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.440+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.460+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.450+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.460+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.460+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.460+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.470+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.470+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.470+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.480+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.490+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.490+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.490+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.500+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.510+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.510+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.510+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.520+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.520+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.520+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.530+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.530+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.540+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.540+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.550+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.550+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.550+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.560+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.560+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.570+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.580+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.580+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.590+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.590+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.600+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.600+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.600+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.610+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.610+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.610+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.620+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.630+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.630+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.630+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.640+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.640+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.640+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.640+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.640+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.650+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.650+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.650+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.650+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.660+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.660+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.660+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.670+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.670+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.670+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.670+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.670+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.680+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.680+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.680+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.690+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.690+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.700+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.700+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.700+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.710+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.710+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.710+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.720+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.720+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.730+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.730+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.730+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.740+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.740+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.750+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.750+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.750+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.750+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.750+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.760+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.760+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.770+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.770+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.770+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.780+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.780+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.780+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.790+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.790+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.800+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.800+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.800+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.800+0900 E/socket.io( 1568): 743: encoded paylod length: 57
07-07 15:07:50.800+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.810+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.810+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.820+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.820+0900 E/socket.io( 1568): 743: encoded paylod length: 56
07-07 15:07:50.830+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.830+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.830+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.830+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.830+0900 E/socket.io( 1568): 743: encoded paylod length: 56
07-07 15:07:50.840+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.850+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.850+0900 E/socket.io( 1568): 743: encoded paylod length: 56
07-07 15:07:50.850+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.860+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.860+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.870+0900 F/sio_packet( 1568): accept()
07-07 15:07:50.870+0900 E/socket.io( 1568): 743: encoded paylod length: 21
07-07 15:07:50.870+0900 E/socket.io( 1568): 800: ping exit, con is expired? 0, ec: Operation canceled
07-07 15:07:50.880+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.880+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.890+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.890+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:50.920+0900 E/socket.io( 1568): 669: Received Message type(Event)
07-07 15:07:50.920+0900 F/get_binary( 1568): in get binary_message()...
07-07 15:07:51.520+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:51.520+0900 W/CAM_APP (17481): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-07 15:07:51.540+0900 I/CAPI_APPFW_APPLICATION( 1568): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:51.940+0900 I/CAPI_APPFW_APPLICATION(17481): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-07 15:07:51.940+0900 W/CAM_APP (17481): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-07 15:07:52.200+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 1568 pgid = 1568
07-07 15:07:52.200+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(1568)
07-07 15:07:52.200+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-07 15:07:52.200+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-07 15:07:52.230+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-07 15:07:52.230+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:07:52.240+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[1568] terminate event is forwarded
07-07 15:07:52.240+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-07 15:07:52.240+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 1568, ]
07-07 15:07:52.240+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-07 15:07:52.240+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-07 15:07:52.240+0900 I/Tizen::App( 1034): (512) > Not registered pid(1568)
07-07 15:07:52.240+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1568.
07-07 15:07:52.240+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1568
07-07 15:07:52.250+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-07 15:07:52.250+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-07 15:07:52.270+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-07 15:07:52.270+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1568.
07-07 15:07:52.310+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-07 15:07:52.330+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-07 15:07:52.340+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-07 15:07:52.340+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-07 15:07:52.340+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-07 15:07:52.380+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-07 15:07:52.380+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-07 15:07:52.390+0900 W/CRASH_MANAGER( 1668): worker.c: worker_job(1236) > 11015686e6f72143624927
