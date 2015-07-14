S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 1886
Date: 2015-07-10 14:51:23+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb15ff004

Register Information
r0   = 0xb15ff008, r1   = 0xb4dae5bb
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0xb7f56760, r5   = 0xb15ff008
r6   = 0xb7d838a0, r7   = 0xbef82c08
r8   = 0xb7f95d80, r9   = 0xb7f56760
r10  = 0xbef82cd0, fp   = 0x00000000
ip   = 0xb4de7c88, sp   = 0xbef82bf0
lr   = 0xb4dae5bb, pc   = 0xb6cd6150
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    222636 KB
Buffers:     35700 KB
Cached:     152344 KB
VmPeak:      96656 KB
VmSize:      96484 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20240 KB
VmRSS:       20236 KB
VmData:      42204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1886 TID = 1886
1886 1888 1889 1909 1910 

Maps Information
b1b97000 b2396000 rw-p [stack:1910]
b2397000 b2b96000 rw-p [stack:1909]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:1888]
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
b6f91000 b6f94000 rw-p [stack:1889]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8026000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b8026000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1886)
Call Stack Count: 19
 0: cfree + 0x30 (0xb6cd6150) [/lib/libc.so.6] + 0x6f150
 1: socket_io_client_close + 0x72 (0xb4dae5bb) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x8d5bb
 2: destroy_thread_cb + 0x24 (0xb4db20c9) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x910c9
 3: elm_naviframe_item_pop + 0x8e (0xb646d04b) [/usr/lib/libelementary.so.1] + 0x4b04b
 4: eext_naviframe_back_cb + 0x12 (0xb4d2af63) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9f63
 5: (0xb4ce7fa7) [/usr/lib/libefl-extension.so.0] + 0xfa7
 6: (0xb62e9645) [/usr/lib/libevas.so.1] + 0x16645
 7: evas_event_feed_key_up + 0x496 (0xb62f0f1f) [/usr/lib/libevas.so.1] + 0x1df1f
 8: (0xb602c865) [/usr/lib/libecore_input_evas.so.1] + 0x1865
 9: (0xb6bdcc6b) [/usr/lib/libecore.so.1] + 0x7c6b
10: (0xb6be0283) [/usr/lib/libecore.so.1] + 0xb283
11: ecore_main_loop_begin + 0x30 (0xb6be0691) [/usr/lib/libecore.so.1] + 0xb691
12: appcore_efl_main + 0x17e (0xb6f96387) [/usr/lib/libappcore-efl.so.1] + 0x2387
13: ui_app_main + 0xb0 (0xb657a499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
14: main + 0x146 (0xb4d2b68b) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xa68b
15: (0xb6fd6dc7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x2dc7
16: (0xb6fd5d8f) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x1d8f
17: __libc_start_main + 0x114 (0xb6c7e82c) [/lib/libc.so.6] + 0x1782c
18: (0xb6fd60d4) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x20d4
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
LL for odcUrl
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: ParseRespXmlFileAndMakeTsResponse(1866) > TSTRACEF OUT
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3951) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.614+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1480) > TSTRACEF IN
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: GetTsValueInTsList(1491) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3977) > odcUrl = 
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3978) > odcSize = 0
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3979) > checkPeriod = 48|48|48|24|24|24
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3980) > licenseUrl = http://ap-zircornia.tizenstore.com/ods.as
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3981) > isUpgrade = 0
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(3983) > pPrdDrmServerUrl = (null)
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(4019) > UPDATE IS NOT AVAILABLE
07-10 14:49:11.624+0900 I/SamsungAccountUpdate( 1186): SelfUpdate.cpp: OnCheckUpdate(159) > Starts
07-10 14:49:11.624+0900 I/SamsungAccountUpdate( 1186): SelfUpdate.cpp: OnCheckUpdate(173) > checkPeriod: 48|48|48|24|24|24
07-10 14:49:11.624+0900 I/SamsungAccountUpdate( 1186): SelfUpdate.cpp: OnCheckUpdate(190) > NO UPDATE PKG AVAILABLE
07-10 14:49:11.624+0900 E/SamsungAccountUpdate( 1186): SAUpdateCheckUpdate.cpp: OnUpdateResultReceived(68) > UPDATE_UNAVAILABLE, extraData: NO UPDATE PKG AVAILABLE
07-10 14:49:11.624+0900 E/SamsungAccountUpdate( 1186): SAUpdateCheckUpdate.cpp: OnUpdateResultReceived(78) > Send terminate signal...
07-10 14:49:11.624+0900 I/CAPI_APPFW_APPLICATION( 1186): service_app_main.c: service_app_exit(440) > service_app_exit
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: engine_CHECKAPPUP_xmlDnCb(4023) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: deleteTsRequest(1909) > TSTRACEF IN
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: deleteTsRequest(1916) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/tizenstore( 1186): engine.c: DnCompCb(796) > TSTRACEF OUT
07-10 14:49:11.624+0900 I/SamsungAccountUpdate( 1186): SAUpdateApplicationCallback.cpp: OnAppTerminate(73) > Starts
07-10 14:49:11.624+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-10 14:49:11.624+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-10 14:49:11.724+0900 I/tizenstore( 1186): engine.c: fNetThread(988) > g_terminate_engine_requested = true
07-10 14:49:11.724+0900 I/tizenstore( 1186): engine.c: fNetThread(997) > TSTRACEF OUT
07-10 14:49:11.784+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 23
07-10 14:49:11.784+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-10 14:49:11.784+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 1186
07-10 14:49:11.784+0900 W/AUL_AMD (  452): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-10 14:49:11.794+0900 I/Tizen::App( 1034): (243) > App[com.samsung.samsungaccount.samsungaccountupdate] pid[1186] terminate event is forwarded
07-10 14:49:11.794+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 14:49:11.794+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [com.samsung.samsungaccount.samsungaccountupdate, 1186, ]
07-10 14:49:11.794+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 14:49:11.794+0900 I/Tizen::App( 1034): (506) > TerminatedApp(com.samsung.samsungaccount.samsungaccountupdate)
07-10 14:49:11.794+0900 I/Tizen::App( 1034): (512) > Not registered pid(1186)
07-10 14:49:11.794+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for com.samsung.samsungaccount.samsungaccountupdate, 1186.
07-10 14:49:11.794+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1186
07-10 14:49:11.794+0900 I/Tizen::System( 1047): (246) > Terminated app [com.samsung.samsungaccount.samsungaccountupdate]
07-10 14:49:11.794+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:49:11.804+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-10 14:49:11.814+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:49:11.814+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for com.samsung.samsungaccount.samsungaccountupdate, 1186.
07-10 14:49:13.634+0900 W/AUL_AMD (  452): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-10 14:49:20.554+0900 F/sio_packet(  618): accept()
07-10 14:49:45.564+0900 F/sio_packet(  618): accept()
07-10 14:50:10.564+0900 F/sio_packet(  618): accept()
07-10 14:50:35.564+0900 F/sio_packet(  618): accept()
07-10 14:51:00.564+0900 F/sio_packet(  618): accept()
07-10 14:51:03.634+0900 E/PKGMGR_SERVER( 1701): pkgmgr-server.c: main(1608) > server start
07-10 14:51:03.794+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:51:03.794+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:51:03.794+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 618 pgid = 618
07-10 14:51:03.794+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(618)
07-10 14:51:03.794+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-10 14:51:03.794+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-10 14:51:03.814+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-10 14:51:03.814+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:51:03.814+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[618] terminate event is forwarded
07-10 14:51:03.814+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 14:51:03.814+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 618, ]
07-10 14:51:03.814+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 14:51:03.814+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-10 14:51:03.814+0900 I/Tizen::App( 1034): (512) > Not registered pid(618)
07-10 14:51:03.814+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 618.
07-10 14:51:03.824+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 618
07-10 14:51:03.834+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:51:03.834+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 618.
07-10 14:51:03.874+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 14:51:03.874+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:51:03.884+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-10 14:51:03.894+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 14:51:03.894+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 14:51:03.924+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-10 14:51:03.924+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:51:03.944+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:51:05.534+0900 E/PKGMGR_SERVER( 1701): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 14:51:05.534+0900 E/PKGMGR_SERVER( 1701): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 14:51:06.314+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-10 14:51:08.614+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: main(1608) > server start
07-10 14:51:08.664+0900 E/PKGMGR  ( 1806): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-10 14:51:08.664+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-10 14:51:08.664+0900 E/PKGMGR_SERVER( 1806): [0;m
07-10 14:51:08.844+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-10 14:51:08.844+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-10 14:51:08.854+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-10 14:51:08.964+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-10 14:51:08.964+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-10 14:51:08.964+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-10 14:51:10.534+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 14:51:11.094+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-10 14:51:11.094+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-10 14:51:11.094+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-10 14:51:11.094+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-10 14:51:11.094+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 92
07-10 14:51:11.094+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 92
07-10 14:51:11.094+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 4
07-10 14:51:11.104+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 4
07-10 14:51:11.104+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 4
07-10 14:51:11.104+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 4
07-10 14:51:11.114+0900 E/PKGMGR_CERT( 1808): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-10 14:51:11.124+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-10 14:51:12.244+0900 E/rpm-installer( 1808): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-10 14:51:12.534+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-10 14:51:13.814+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-10 14:51:13.814+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-10 14:51:13.814+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-10 14:51:13.834+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-10 14:51:13.834+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-10 14:51:13.834+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-10 14:51:13.834+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-10 14:51:13.844+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-10 14:51:13.844+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-10 14:51:13.844+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-10 14:51:13.884+0900 E/PKGMGR_INFO( 1808): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-10 14:51:13.884+0900 E/PKGMGR_INSTALLER( 1808): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-10 14:51:13.914+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-10 14:51:13.964+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-10 14:51:13.964+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-10 14:51:13.964+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-10 14:51:13.964+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-10 14:51:13.964+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-10 14:51:13.984+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 14:51:13.984+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 14:51:13.984+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 14:51:13.994+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 14:51:13.994+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-10 14:51:13.994+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-10 14:51:13.994+0900 I/Tizen::App( 1034): (855) > Enter.
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (695) > Exit.
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (131) > Enter
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-10 14:51:14.004+0900 I/Tizen::App( 1034): (898) > Exit.
07-10 14:51:14.534+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-10 14:51:14.534+0900 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: main(1704) > package manager server terminated.
07-10 14:51:15.394+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-10 14:51:15.404+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-10 14:51:15.414+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-10 14:51:15.414+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-10 14:51:15.494+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: ui_app_main(699) > app_efl_main
07-10 14:51:15.534+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 436
07-10 14:51:15.534+0900 I/UXT     ( 1886): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-10 14:51:15.554+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 1886.
07-10 14:51:15.564+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-10 14:51:15.574+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 1886.
07-10 14:51:15.594+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-10 14:51:15.864+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-10 14:51:15.874+0900 I/APP_CORE( 1886): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-10 14:51:15.874+0900 I/APP_CORE( 1886): appcore-efl.c: __do_app(511) > [APP 1886] Initial Launching, call the resume_cb
07-10 14:51:15.874+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-10 14:51:15.904+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=1886
07-10 14:51:15.914+0900 W/APP_CORE( 1886): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-10 14:51:15.944+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-10 14:51:15.964+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 1886"
07-10 14:51:15.984+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-10 14:51:16.034+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-10 14:51:16.034+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:51:16.044+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:51:16.054+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-10 14:51:16.054+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-10 14:51:16.094+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:51:16.094+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:51:18.404+0900 I/MALI    ( 1886): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-10 14:51:18.834+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:18.834+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:18.834+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:51:18.854+0900 I/nornenjs( 1886): Timer expired after 3.000 seconds.
07-10 14:51:18.854+0900 E/EFL     ( 1886): ecore<1886> ecore.c:568 _ecore_magic_fail() 
07-10 14:51:18.854+0900 E/EFL     ( 1886): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-10 14:51:18.854+0900 E/EFL     ( 1886): *** IN FUNCTION: ecore_timer_delay()
07-10 14:51:18.854+0900 E/EFL     ( 1886): ecore<1886> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-10 14:51:18.854+0900 E/EFL     ( 1886): ecore<1886> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-10 14:51:18.854+0900 E/EFL     ( 1886): *** SPANK SPANK SPANK!!!
07-10 14:51:18.854+0900 E/EFL     ( 1886): *** Now go fix your code. Tut tut tut!
07-10 14:51:18.884+0900 E/EFL     ( 1886): evas_main<1886> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-10 14:51:18.894+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:18.894+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:51:18.914+0900 E/EFL     ( 1886): evas_main<1886> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-10 14:51:18.954+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:18.954+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:51:19.014+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:19.014+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:19.924+0900 E/socket.io( 1886): 566: Connected.
07-10 14:51:19.924+0900 E/socket.io( 1886): 554: On handshake, sid
07-10 14:51:19.924+0900 E/socket.io( 1886): 651: Received Message type(connect)
07-10 14:51:19.924+0900 E/socket.io( 1886): 489: On Connected
07-10 14:51:19.934+0900 F/sio_packet( 1886): accept()
07-10 14:51:19.934+0900 E/socket.io( 1886): 743: encoded paylod length: 41
07-10 14:51:19.934+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:20.024+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:20.024+0900 F/sio_packet( 1886): accept()
07-10 14:51:20.024+0900 E/socket.io( 1886): 743: encoded paylod length: 21
07-10 14:51:20.024+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:20.074+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:20.074+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:20.094+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:20.104+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:20.154+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:20.154+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:20.154+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:51:20.934+0900 I/CAPI_APPFW_APPLICATION( 1886): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:20.934+0900 I/CAPI_APPFW_APPLICATION(25836): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-10 14:51:20.934+0900 W/CAM_APP (25836): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-10 14:51:21.014+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.014+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:21.014+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.054+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.054+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.054+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.054+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.054+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.054+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.054+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.074+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.074+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.074+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.074+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.084+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.084+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.084+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.104+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.104+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.104+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.124+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.124+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.124+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.134+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.144+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.154+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.154+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.154+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.154+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:21.154+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.164+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.184+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.184+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.184+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.184+0900 E/socket.io( 1886): 743: encoded paylod length: 77
07-10 14:51:21.184+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.194+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.204+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.214+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.214+0900 E/socket.io( 1886): 743: encoded paylod length: 75
07-10 14:51:21.214+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.214+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.214+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.214+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.214+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.234+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.234+0900 E/socket.io( 1886): 743: encoded paylod length: 75
07-10 14:51:21.244+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.254+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.254+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.254+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.264+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.264+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.274+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.274+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:21.274+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.284+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.284+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.284+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.294+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.304+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.304+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.304+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.304+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.324+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.324+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.334+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.334+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.334+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.334+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.344+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.354+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.354+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.364+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.364+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.374+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.374+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.374+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.384+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.384+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.394+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.404+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.404+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.404+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.404+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.434+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.434+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.434+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.454+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.454+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.454+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.464+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.464+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.474+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.474+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.474+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.484+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.494+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.494+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.494+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.504+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.504+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.504+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.504+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.524+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.524+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.524+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.534+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.534+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.534+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.534+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.554+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.554+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.554+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.564+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.564+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:21.564+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.564+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.584+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.584+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.584+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.584+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.594+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.594+0900 E/socket.io( 1886): 743: encoded paylod length: 75
07-10 14:51:21.594+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.614+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.614+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.624+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.624+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.624+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.624+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.634+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.654+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.654+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.654+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.654+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.664+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.664+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.664+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.684+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.684+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.684+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.694+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.694+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:21.694+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.694+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.714+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.714+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.714+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.724+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.724+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.724+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.734+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.744+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.744+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.744+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.744+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.754+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.754+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:21.754+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.774+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.774+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.784+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.784+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.794+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.794+0900 E/socket.io( 1886): 743: encoded paylod length: 81
07-10 14:51:21.794+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.824+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.824+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.824+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.824+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.824+0900 E/socket.io( 1886): 743: encoded paylod length: 82
07-10 14:51:21.824+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.834+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.844+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.844+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.854+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.854+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.854+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.854+0900 E/socket.io( 1886): 743: encoded paylod length: 82
07-10 14:51:21.854+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.884+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.884+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.884+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.894+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.894+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.894+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.904+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:21.914+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:21.914+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:21.924+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.924+0900 E/socket.io( 1886): 743: encoded paylod length: 76
07-10 14:51:21.924+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:21.924+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.924+0900 F/sio_packet( 1886): accept()
07-10 14:51:21.924+0900 E/socket.io( 1886): 743: encoded paylod length: 21
07-10 14:51:21.934+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:21.934+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.014+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.014+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.014+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.014+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.064+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.064+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.074+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.084+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.704+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.704+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:22.704+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.734+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.734+0900 E/socket.io( 1886): 743: encoded paylod length: 77
07-10 14:51:22.734+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.734+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.734+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.744+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.744+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.754+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.754+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.764+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.764+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.764+0900 E/socket.io( 1886): 743: encoded paylod length: 77
07-10 14:51:22.764+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.764+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.784+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.784+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.784+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.794+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.804+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.804+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:22.804+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.824+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.824+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.824+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.824+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.834+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.834+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:22.834+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.854+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.854+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:22.854+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.854+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.854+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.864+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.864+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.874+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.874+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.874+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.874+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.894+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.894+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:22.894+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.914+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.914+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.914+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.914+0900 E/socket.io( 1886): 743: encoded paylod length: 74
07-10 14:51:22.924+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.924+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.924+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.944+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.944+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.944+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.954+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.954+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:22.954+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:22.964+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.974+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:22.974+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:22.974+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:22.974+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:22.984+0900 F/sio_packet( 1886): accept()
07-10 14:51:22.984+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:22.984+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:23.004+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:23.004+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:23.004+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:23.014+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:23.014+0900 F/sio_packet( 1886): accept()
07-10 14:51:23.014+0900 E/socket.io( 1886): 743: encoded paylod length: 78
07-10 14:51:23.014+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:23.034+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:23.034+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:23.034+0900 F/sio_packet( 1886): accept()
07-10 14:51:23.034+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:23.034+0900 E/socket.io( 1886): 743: encoded paylod length: 21
07-10 14:51:23.034+0900 E/socket.io( 1886): 800: ping exit, con is expired? 0, ec: Operation canceled
07-10 14:51:23.044+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:23.084+0900 E/socket.io( 1886): 669: Received Message type(Event)
07-10 14:51:23.084+0900 F/get_binary( 1886): in get binary_message()...
07-10 14:51:23.104+0900 I/nornenjs_queue( 1886): Queue push
07-10 14:51:23.114+0900 I/nornenjs_queue( 1886): Queue pop
07-10 14:51:23.944+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-10 14:51:23.944+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-10 14:51:23.974+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 1886 pgid = 1886
07-10 14:51:23.974+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(1886)
07-10 14:51:23.974+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-10 14:51:23.974+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-10 14:51:23.984+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-10 14:51:23.984+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-10 14:51:23.984+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[1886] terminate event is forwarded
07-10 14:51:23.984+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-10 14:51:23.984+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 1886, ]
07-10 14:51:23.984+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-10 14:51:23.984+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-10 14:51:23.984+0900 I/Tizen::App( 1034): (512) > Not registered pid(1886)
07-10 14:51:23.984+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1886.
07-10 14:51:23.994+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1886
07-10 14:51:24.004+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-10 14:51:24.014+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-10 14:51:24.014+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1886.
07-10 14:51:24.044+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 14:51:24.044+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-10 14:51:24.104+0900 W/CRASH_MANAGER( 1927): worker.c: worker_job(1236) > 11018866e6f72143650748
