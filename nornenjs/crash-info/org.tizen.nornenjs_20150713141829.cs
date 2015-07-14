S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 1053
Date: 2015-07-13 14:18:29+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xfbad2878

Register Information
r0   = 0x3ffffffc, r1   = 0xb7f82198
r2   = 0x00000025, r3   = 0xfbad2884
r4   = 0xb6d8c5d8, r5   = 0xb5b2f000
r6   = 0xb7f82198, r7   = 0xb36c8840
r8   = 0xb7f82198, r9   = 0xb36c891c
r10  = 0x00000025, fp   = 0xb2203d70
ip   = 0xb4de7ebc, sp   = 0xb36c8820
lr   = 0xb4d2acb3, pc   = 0xb5b0202a
cpsr = 0xa0000030

Memory Information
MemTotal:   730748 KB
MemFree:    206504 KB
Buffers:     36956 KB
Cached:     161800 KB
VmPeak:      95172 KB
VmSize:      95172 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19076 KB
VmRSS:       19076 KB
VmData:      41148 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 1053 TID = 1133
1053 1055 1056 1133 1134 1135 

Maps Information
b1a01000 b2200000 rw-p [stack:1135]
b23d4000 b2bd3000 rw-p [stack:1134]
b2ecb000 b36ca000 rw-p [stack:1133]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:1055]
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
b6f91000 b6f94000 rw-p [stack:1056]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8005000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8005000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1053)
Call Stack Count: 9
 0: std::basic_string<char, std::char_traits<char>, std::allocator<char> >::append(char const*, unsigned int) + 0x1d (0xb5b0202a) [/usr/lib/libstdc++.so.6] + 0x7202a
 1: writer(char*, unsigned int, unsigned int, std::basic_string<char, std::char_traits<char>, std::allocator<char> >*) + 0x26 (0xb4d2acb3) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9cb3
 2: (0xb5dfc69b) [/usr/lib/libcurl.so.4] + 0xf69b
 3: (0xb5e0ef69) [/usr/lib/libcurl.so.4] + 0x21f69
 4: (0xb5e0ba59) [/usr/lib/libcurl.so.4] + 0x1ea59
 5: (0xb5e0c983) [/usr/lib/libcurl.so.4] + 0x1f983
 6: curl_test() + 0xe2 (0xb4d2adbb) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9dbb
 7: socket_io_client + 0x3b4 (0xb4daf3ed) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x8e3ed
 8: (0xb6f54d30) [/lib/libpthread.so.0] + 0x6d30
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
_find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1786797551) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(309774649) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(972136381) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1334477818) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(612553974) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(965901549) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1328155854) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1390870842) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(669268519) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2093817529) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1388493229) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1741008381) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1028929537) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1391032406) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(666891985) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1031553989) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1397125648) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(682012095) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1036978319) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(323510185) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1749810828) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1044173696) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(330435173) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1760950322) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2113115273) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1397631926) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1762960929) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1043360944) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1394679648) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1758310470) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(742558240) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(18479071) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(388026571) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1808893499) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1101876939) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(387294975) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1809482996) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1105683873) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(385184427) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1811388242) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1109467856) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(393850577) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(741063708) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1455415023) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1825568881) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1099605620) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1458902439) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1825752200) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1876270165) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(83073240) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(453542589) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1884936654) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1165856816) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1525486917) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1880681156) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1525780290) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(102569103) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1533399398) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1886024335) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1170908558) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(465255741) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1575849510) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1945533766) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1532732373) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1883602183) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1166664112) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1538336666) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(824134563) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(114490874) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(659203690) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2099252636) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(289838724) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2091299542) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1381925653) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(663840149) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2091887011) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(306865065) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(660623411) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2095373702) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(295660564) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1735781047) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1014984471) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(322629244) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(671971728) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2111283566) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(311053465) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1748739387) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2089212782) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(327491440) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(677089560) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1032187177) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1384694999) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(672122708) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734713134) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(11121348) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1450667790) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734114040) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1088938049) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(366617850) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734283951) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1093657515) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(375279555) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(728068022) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(17468535) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1451307387) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1804363918) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(19400225) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1457160447) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1812733171) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1089083287) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1450096669) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(435480998) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1430148655) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1458572046) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1792141921) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1834893154) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(5366971) is OVER.
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 13-7-2015, 05:26:08 (UTC).
07-13 14:18:28.994+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-13 14:18:29.054+0900 W/ALARM_MANAGER(  954): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.apush] : Alarm id [867028266]
07-13 14:18:29.064+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.144+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.144+0900 W/ALARM_MANAGER(  954): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(15), start(13-7-2015, 14:18:44), repeat(0), interval(0), type(-1073741822)
07-13 14:18:29.174+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.174+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.184+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.194+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.214+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.214+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.214+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
07-13 14:18:29.214+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1436764724, Mon Jul 13 14:18:44 2015
07-13 14:18:29.214+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1007981507, next duetime: 1436764724
07-13 14:18:29.214+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(1007981507)
07-13 14:18:29.214+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_create(873) > [alarm-server]:alarm_context.c_due_time(1436765168), due_time(1436764724)
07-13 14:18:29.224+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 13-7-2015, 05:18:44 (UTC).
07-13 14:18:29.224+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-13 14:18:29.254+0900 E/socket.io( 1053): 566: Connected.
07-13 14:18:29.254+0900 E/socket.io( 1053): 554: On handshake, sid
07-13 14:18:29.254+0900 E/socket.io( 1053): 651: Received Message type(connect)
07-13 14:18:29.254+0900 E/socket.io( 1053): 489: On Connected
07-13 14:18:29.254+0900 F/sio_packet( 1053): accept()
07-13 14:18:29.254+0900 E/socket.io( 1053): 743: encoded paylod length: 41
07-13 14:18:29.254+0900 E/socket.io( 1053): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(1007981507)
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1174318770) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(294361110) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1424370282) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(702623908) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(3489177) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(351773840) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1787444229) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(366959758) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1785490029) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2141268945) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2040435170) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1330390502) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1683409963) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2041497014) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1319596594) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(602517992) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(957598089) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1329719950) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1682559217) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2042906864) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1326687191) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1686439662) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(979560525) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1786797551) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(309774649) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(972136381) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1334477818) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(612553974) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(965901549) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1328155854) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1390870842) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(669268519) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2093817529) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1388493229) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1741008381) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1028929537) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1391032406) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(666891985) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1031553989) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1397125648) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(682012095) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1036978319) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(323510185) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1749810828) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1044173696) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(330435173) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1760950322) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2113115273) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1397631926) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1762960929) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1043360944) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1394679648) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1758310470) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(742558240) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(18479071) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(388026571) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1808893499) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1101876939) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(387294975) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1809482996) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1105683873) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(385184427) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1811388242) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1109467856) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(393850577) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(741063708) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1455415023) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1825568881) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1099605620) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1458902439) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1825752200) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1876270165) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(83073240) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(453542589) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1884936654) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1165856816) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1525486917) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1880681156) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1525780290) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(102569103) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1533399398) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1886024335) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1170908558) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(465255741) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1575849510) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1945533766) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1532732373) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1883602183) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1166664112) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1538336666) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(824134563) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(114490874) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(659203690) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2099252636) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(289838724) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2091299542) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1381925653) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(663840149) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2091887011) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(306865065) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(660623411) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2095373702) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(295660564) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1735781047) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1014984471) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(322629244) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(671971728) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2111283566) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(311053465) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1748739387) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(2089212782) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(327491440) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(677089560) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1032187177) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1384694999) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(672122708) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734713134) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(11121348) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1450667790) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734114040) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1088938049) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(366617850) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(734283951) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1093657515) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(375279555) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(728068022) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(17468535) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1451307387) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1804363918) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(19400225) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1457160447) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1812733171) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1089083287) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1450096669) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(435480998) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1430148655) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1458572046) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1792141921) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(1834893154) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(543) > The duetime of alarm(5366971) is OVER.
07-13 14:18:29.284+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 13-7-2015, 05:26:08 (UTC).
07-13 14:18:29.354+0900 E/socket.io( 1053): 669: Received Message type(Event)
07-13 14:18:29.354+0900 F/sio_packet( 1053): accept()
07-13 14:18:29.354+0900 E/socket.io( 1053): 743: encoded paylod length: 21
07-13 14:18:29.354+0900 E/socket.io( 1053): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 14:18:29.384+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-13 14:18:29.384+0900 E/PUSHD   (  954): ping.c: ping_success(351) > = PING_SUCCESS = avg[240] inc[240] min[240] max[1440] interval[1440] successes[363] max[2] EXLORE[true]
07-13 14:18:29.404+0900 E/socket.io( 1053): 669: Received Message type(Event)
07-13 14:18:29.404+0900 F/get_binary( 1053): in get binary_message()...
07-13 14:18:29.414+0900 W/ALARM_MANAGER(  404): alarm-manager.c: alarm_manager_alarm_delete(1750) > alarm_id[1007981507] is removed.
07-13 14:18:29.414+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.424+0900 I/AUL     (  954): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.424+0900 W/ALARM_MANAGER(  954): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(1440), start(13-7-2015, 14:42:29), repeat(0), interval(0), type(-1073741822)
07-13 14:18:29.444+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.444+0900 I/nornenjs_queue( 1053): Queue push
07-13 14:18:29.454+0900 I/nornenjs_queue( 1053): Queue pop
07-13 14:18:29.464+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.474+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.494+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.504+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.524+0900 I/AUL     (  404): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1436766149, Mon Jul 13 14:42:29 2015
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1007981507, next duetime: 1436766149
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(1007981507)
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __alarm_create(873) > [alarm-server]:alarm_context.c_due_time(1436765168), due_time(1436766149)
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 13-7-2015, 05:26:08 (UTC).
07-13 14:18:29.524+0900 W/ALARM_MANAGER(  404): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-13 14:18:29.614+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:18:29.614+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 14:18:29.634+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 1053 pgid = 1053
07-13 14:18:29.634+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(1053)
07-13 14:18:29.634+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 14:18:29.634+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 14:18:29.654+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 14:18:29.654+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:18:29.654+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[1053] terminate event is forwarded
07-13 14:18:29.654+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 14:18:29.654+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 1053, ]
07-13 14:18:29.654+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 14:18:29.654+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 14:18:29.654+0900 I/Tizen::App( 1034): (512) > Not registered pid(1053)
07-13 14:18:29.654+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1053.
07-13 14:18:29.674+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1053
07-13 14:18:29.684+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:18:29.684+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 1053.
07-13 14:18:29.694+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-13 14:18:29.724+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 14:18:29.724+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-13 14:18:29.734+0900 W/CRASH_MANAGER( 1137): worker.c: worker_job(1236) > 11010536e6f72143676470
