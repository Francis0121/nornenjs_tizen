S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 7617
Date: 2015-07-09 18:08:51+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb1781020

Register Information
r0   = 0xb1900000, r1   = 0xb1780020
r2   = 0x00000800, r3   = 0xb1781020
r4   = 0x00200000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000100
r8   = 0x00040000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4435d70, pc   = 0xb4435f4c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     86388 KB
Buffers:     47260 KB
Cached:     255976 KB
VmPeak:      95084 KB
VmSize:      95080 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20456 KB
VmRSS:       20452 KB
VmData:      41568 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 7617 TID = 7617
7617 7618 7619 7655 7656 7657 

Maps Information
b1a01000 b2200000 rw-p [stack:7657]
b23d4000 b2bd3000 rw-p [stack:7656]
b2ecb000 b36ca000 rw-p [stack:7655]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:7618]
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
b6f91000 b6f94000 rw-p [stack:7619]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b7f88000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b7f88000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7617)
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
900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:45.310+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.330+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.330+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.330+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.360+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.360+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.370+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.370+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.370+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.370+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.390+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.400+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.400+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.400+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.410+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.410+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.430+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.430+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.440+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.440+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.440+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.460+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.460+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.460+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.460+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.470+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.490+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.490+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.500+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.500+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.500+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.520+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.520+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.530+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.540+0900 E/socket.io( 7617): 743: encoded paylod length: 83
07-09 18:08:45.540+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.560+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.560+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.570+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.570+0900 E/socket.io( 7617): 743: encoded paylod length: 81
07-09 18:08:45.570+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.600+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.600+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.600+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.600+0900 E/socket.io( 7617): 743: encoded paylod length: 81
07-09 18:08:45.610+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.630+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.630+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.630+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.640+0900 E/socket.io( 7617): 743: encoded paylod length: 81
07-09 18:08:45.640+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.660+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.660+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.670+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.670+0900 E/socket.io( 7617): 743: encoded paylod length: 81
07-09 18:08:45.670+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.690+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.690+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.700+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.700+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.700+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.720+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.730+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.730+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.730+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.730+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.760+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.760+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.760+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.760+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.760+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.790+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.790+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.800+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.800+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.800+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.820+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.820+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.830+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.840+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:45.840+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.860+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.860+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:45.860+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.870+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.870+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.890+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.890+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.900+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.900+0900 E/socket.io( 7617): 743: encoded paylod length: 78
07-09 18:08:45.900+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.920+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.920+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.920+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.920+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.920+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.950+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.950+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.950+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.950+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.950+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:45.980+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:45.980+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:45.980+0900 F/sio_packet( 7617): accept()
07-09 18:08:45.980+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:45.980+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.010+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.010+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.020+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.020+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.020+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.040+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.040+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.050+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.050+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.050+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.070+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.070+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.080+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.080+0900 E/socket.io( 7617): 743: encoded paylod length: 78
07-09 18:08:46.080+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.100+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.100+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.110+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.120+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.120+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.140+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.140+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.150+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.150+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.150+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.170+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.170+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.180+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.180+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.180+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.200+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.200+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.210+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.220+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.220+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.240+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.240+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.250+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.250+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.250+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.280+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.280+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.280+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.300+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.300+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.300+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.300+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.300+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.320+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.320+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.330+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.330+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.340+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.340+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.340+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.370+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.370+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.370+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.370+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.370+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.390+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.390+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.400+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.400+0900 E/socket.io( 7617): 743: encoded paylod length: 83
07-09 18:08:46.400+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.430+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.430+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.430+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.430+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.430+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.450+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.450+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.460+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.460+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.460+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.480+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.480+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.490+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.490+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.500+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.520+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.520+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.530+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.530+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.530+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.560+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.560+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.560+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.560+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.560+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.580+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.580+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.590+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.590+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.590+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.620+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.620+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.620+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.620+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:46.630+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.650+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.650+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.660+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.660+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.660+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.690+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.690+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.700+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.700+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.700+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.720+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.720+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.730+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.730+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.730+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.750+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.750+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.760+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.770+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.770+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.790+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.790+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.790+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.800+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.800+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.820+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.820+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.830+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.830+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.830+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.850+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.860+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.860+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.870+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.870+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.880+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.880+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.880+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.880+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.890+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.910+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.910+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.910+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.910+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:46.930+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.950+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.950+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.950+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:46.960+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.960+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.970+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:46.970+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:46.980+0900 F/sio_packet( 7617): accept()
07-09 18:08:46.980+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:46.990+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.010+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.010+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.010+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.020+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.020+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.040+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.040+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.050+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.060+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.060+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.080+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.080+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.080+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.080+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.080+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.110+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.110+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.110+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.110+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.120+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.140+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.150+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.150+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.150+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.160+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.180+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.180+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.180+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.180+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.190+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.210+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.210+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.210+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.210+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.210+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.230+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.230+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.240+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.240+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.240+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.260+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.260+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.280+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.280+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.280+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.300+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.310+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.310+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.330+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.330+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.340+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.340+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.340+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.360+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.360+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.370+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.380+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.380+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.400+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.400+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.400+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.420+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.420+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.430+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.430+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.430+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.460+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.460+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.470+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.470+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.480+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.490+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.490+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.500+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.500+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.500+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.500+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.520+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.520+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.520+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.530+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.530+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.530+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.550+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.550+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.560+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.560+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.560+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.570+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.570+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.590+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.590+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.590+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.600+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.600+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.620+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.620+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.630+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.630+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.630+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.660+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.660+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.660+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.660+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.660+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.690+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.690+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.690+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.690+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.690+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.720+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.720+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.720+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.730+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.730+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.750+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.750+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.760+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.760+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.760+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.790+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.790+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.790+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.790+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.790+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.820+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.820+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.830+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.830+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.830+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.840+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.840+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.850+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.870+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.870+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.880+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.880+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.880+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.890+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:47.890+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.910+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.910+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.920+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.920+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:47.920+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.940+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.940+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.940+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.940+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.950+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:47.970+0900 F/sio_packet( 7617): accept()
07-09 18:08:47.980+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:47.980+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:47.980+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:47.980+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.010+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.010+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.010+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.010+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.010+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.040+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.040+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.040+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.040+0900 E/socket.io( 7617): 743: encoded paylod length: 78
07-09 18:08:48.040+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.070+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.070+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.070+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.080+0900 E/socket.io( 7617): 743: encoded paylod length: 78
07-09 18:08:48.080+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.100+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.100+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.110+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.110+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.110+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.130+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.130+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.140+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.140+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.140+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.170+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.170+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.180+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.180+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:48.180+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.200+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.200+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.210+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.210+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.210+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.240+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.240+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.250+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.250+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.250+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.270+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.270+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.270+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.280+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.280+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.300+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.300+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:48.300+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.300+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.300+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.320+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.320+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.330+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.330+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.330+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.350+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.350+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.360+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.360+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.370+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.390+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.390+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.400+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.400+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.400+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.430+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.430+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.430+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.430+0900 E/socket.io( 7617): 743: encoded paylod length: 75
07-09 18:08:48.430+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.460+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.460+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.470+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.470+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.470+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.480+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.480+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.480+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.500+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.500+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.520+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.520+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.530+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.530+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.530+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.550+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.550+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.550+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.560+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.560+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.580+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.580+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.580+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.580+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.590+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.610+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.610+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.620+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.620+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.620+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.650+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.650+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.650+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.670+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.670+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.680+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.680+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.690+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.690+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.690+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.710+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.720+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.720+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.730+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.730+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.750+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.750+0900 E/socket.io( 7617): 743: encoded paylod length: 77
07-09 18:08:48.750+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.760+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.760+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.780+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.780+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.780+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.790+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.790+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.800+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.800+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.810+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.810+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.810+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.830+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.830+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.850+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.850+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.850+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.870+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.870+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.870+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.870+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.880+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.900+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.900+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.910+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.910+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.910+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.940+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.940+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.940+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.970+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.970+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:48.970+0900 F/sio_packet( 7617): accept()
07-09 18:08:48.970+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:48.970+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:48.990+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:48.990+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:49.010+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:49.010+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:49.010+0900 F/sio_packet( 7617): accept()
07-09 18:08:49.010+0900 E/socket.io( 7617): 743: encoded paylod length: 80
07-09 18:08:49.020+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:49.030+0900 F/sio_packet( 7617): accept()
07-09 18:08:49.040+0900 E/socket.io( 7617): 743: encoded paylod length: 21
07-09 18:08:49.040+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:49.040+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:49.040+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:49.130+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:49.130+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:50.840+0900 F/sio_packet( 7617): accept()
07-09 18:08:50.840+0900 E/socket.io( 7617): 743: encoded paylod length: 56
07-09 18:08:50.840+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:50.860+0900 F/sio_packet( 7617): accept()
07-09 18:08:50.860+0900 E/socket.io( 7617): 743: encoded paylod length: 57
07-09 18:08:50.860+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:50.870+0900 F/sio_packet( 7617): accept()
07-09 18:08:50.880+0900 E/socket.io( 7617): 743: encoded paylod length: 57
07-09 18:08:50.880+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:50.900+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:50.900+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:50.900+0900 F/sio_packet( 7617): accept()
07-09 18:08:50.900+0900 E/socket.io( 7617): 743: encoded paylod length: 57
07-09 18:08:50.900+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:50.910+0900 F/sio_packet( 7617): accept()
07-09 18:08:50.910+0900 E/socket.io( 7617): 743: encoded paylod length: 21
07-09 18:08:50.910+0900 E/socket.io( 7617): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:08:50.920+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:50.920+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:50.970+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:50.970+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:50.980+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:50.980+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:51.020+0900 E/socket.io( 7617): 669: Received Message type(Event)
07-09 18:08:51.020+0900 F/get_binary( 7617): in get binary_message()...
07-09 18:08:51.150+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 18:08:51.150+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-09 18:08:51.170+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 7617 pgid = 7617
07-09 18:08:51.170+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(7617)
07-09 18:08:51.170+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 18:08:51.170+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 18:08:51.180+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-09 18:08:51.180+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:08:51.180+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[7617] terminate event is forwarded
07-09 18:08:51.180+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 18:08:51.180+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 7617, ]
07-09 18:08:51.180+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 18:08:51.180+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-09 18:08:51.180+0900 I/Tizen::App( 1034): (512) > Not registered pid(7617)
07-09 18:08:51.180+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 7617.
07-09 18:08:51.190+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 7617
07-09 18:08:51.200+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:08:51.200+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 7617.
07-09 18:08:51.230+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-09 18:08:51.250+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:08:51.250+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-09 18:08:51.250+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-09 18:08:51.260+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-09 18:08:51.270+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-09 18:08:51.300+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:08:51.320+0900 W/CRASH_MANAGER( 7748): worker.c: worker_job(1236) > 11076176e6f72143643293
