S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 10961
Date: 2015-07-09 16:30:28+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb2a23130

Register Information
r0   = 0xb1898200, r1   = 0xb2a20910
r2   = 0x00000400, r3   = 0xb2a23130
r4   = 0x000c0000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000060
r8   = 0x00018000, r9   = 0x00002000
r10  = 0x00000100, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4435d84, pc   = 0xb4435f4c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     91340 KB
Buffers:     47248 KB
Cached:     251032 KB
VmPeak:      95748 KB
VmSize:      94944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19772 KB
VmRSS:       19768 KB
VmData:      41432 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 10961 TID = 10961
10961 10962 10963 10981 10982 10983 

Maps Information
b1a01000 b2200000 rw-p [stack:10983]
b2201000 b2a00000 rw-p [stack:10982]
b2ecb000 b36ca000 rw-p [stack:10981]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:10962]
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
b6f91000 b6f94000 rw-p [stack:10963]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b806e000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b806e000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10961)
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
 743: encoded paylod length: 77
07-09 16:30:19.670+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:19.690+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:19.690+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:19.700+0900 F/sio_packet(10961): accept()
07-09 16:30:19.700+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:19.700+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:19.710+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:19.710+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:19.730+0900 F/sio_packet(10961): accept()
07-09 16:30:19.730+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:19.730+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:19.770+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:19.770+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:21.480+0900 F/sio_packet(10961): accept()
07-09 16:30:21.480+0900 E/socket.io(10961): 743: encoded paylod length: 75
07-09 16:30:21.480+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:21.500+0900 F/sio_packet(10961): accept()
07-09 16:30:21.500+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:21.510+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:21.520+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:21.520+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:21.540+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:21.540+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:21.540+0900 F/sio_packet(10961): accept()
07-09 16:30:21.540+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:21.540+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:21.570+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:21.570+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:21.570+0900 F/sio_packet(10961): accept()
07-09 16:30:21.580+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:21.580+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:21.600+0900 F/sio_packet(10961): accept()
07-09 16:30:21.600+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:21.600+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:21.600+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:21.610+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:21.640+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:21.640+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.050+0900 F/sio_packet(10961): accept()
07-09 16:30:22.050+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:22.050+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.080+0900 F/sio_packet(10961): accept()
07-09 16:30:22.080+0900 E/socket.io(10961): 743: encoded paylod length: 73
07-09 16:30:22.080+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.080+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.080+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.100+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.100+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.110+0900 F/sio_packet(10961): accept()
07-09 16:30:22.110+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:22.110+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.130+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.130+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.140+0900 F/sio_packet(10961): accept()
07-09 16:30:22.150+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:22.150+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.160+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.160+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.170+0900 F/sio_packet(10961): accept()
07-09 16:30:22.180+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:22.180+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.200+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.200+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.210+0900 F/sio_packet(10961): accept()
07-09 16:30:22.210+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:22.210+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.230+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.230+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.240+0900 F/sio_packet(10961): accept()
07-09 16:30:22.240+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:22.240+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.260+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.260+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.270+0900 F/sio_packet(10961): accept()
07-09 16:30:22.270+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:22.280+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.350+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.350+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.610+0900 F/sio_packet(10961): accept()
07-09 16:30:22.610+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:22.610+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.640+0900 F/sio_packet(10961): accept()
07-09 16:30:22.640+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:22.640+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.640+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.640+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.660+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.660+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.670+0900 F/sio_packet(10961): accept()
07-09 16:30:22.670+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.670+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.690+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.690+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.700+0900 F/sio_packet(10961): accept()
07-09 16:30:22.700+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.710+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.730+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.730+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.740+0900 F/sio_packet(10961): accept()
07-09 16:30:22.740+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.740+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.760+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.760+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.770+0900 F/sio_packet(10961): accept()
07-09 16:30:22.770+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.780+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.800+0900 F/sio_packet(10961): accept()
07-09 16:30:22.800+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.800+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.800+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.810+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.840+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.840+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.840+0900 F/sio_packet(10961): accept()
07-09 16:30:22.840+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.840+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.850+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.850+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.860+0900 F/sio_packet(10961): accept()
07-09 16:30:22.860+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:22.860+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.870+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.870+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.890+0900 F/sio_packet(10961): accept()
07-09 16:30:22.890+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.890+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.910+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.910+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.920+0900 F/sio_packet(10961): accept()
07-09 16:30:22.930+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.930+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.940+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.940+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.950+0900 F/sio_packet(10961): accept()
07-09 16:30:22.960+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:22.960+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:22.980+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:22.980+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:22.990+0900 F/sio_packet(10961): accept()
07-09 16:30:22.990+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:23.000+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:23.010+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:23.010+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:23.020+0900 F/sio_packet(10961): accept()
07-09 16:30:23.020+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:23.020+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:23.040+0900 F/sio_packet(10961): accept()
07-09 16:30:23.040+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:23.040+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:23.040+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:23.040+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:23.070+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:23.070+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.140+0900 F/sio_packet(10961): accept()
07-09 16:30:24.140+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.140+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.180+0900 F/sio_packet(10961): accept()
07-09 16:30:24.180+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.180+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.190+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:24.190+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.210+0900 F/sio_packet(10961): accept()
07-09 16:30:24.210+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.210+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.220+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.220+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.230+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.230+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.240+0900 F/sio_packet(10961): accept()
07-09 16:30:24.240+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.250+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.260+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.260+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.270+0900 F/sio_packet(10961): accept()
07-09 16:30:24.270+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.270+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.290+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.290+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.300+0900 F/sio_packet(10961): accept()
07-09 16:30:24.300+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:24.300+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.320+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.320+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.330+0900 F/sio_packet(10961): accept()
07-09 16:30:24.330+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.340+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.340+0900 F/sio_packet(10961): accept()
07-09 16:30:24.350+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:24.350+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.350+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.350+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.390+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.390+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.620+0900 F/sio_packet(10961): accept()
07-09 16:30:24.620+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.620+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.650+0900 F/sio_packet(10961): accept()
07-09 16:30:24.650+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.650+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.660+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.660+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.670+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.670+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.680+0900 F/sio_packet(10961): accept()
07-09 16:30:24.680+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.680+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.690+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.690+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.710+0900 F/sio_packet(10961): accept()
07-09 16:30:24.710+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.710+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.730+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.730+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.750+0900 F/sio_packet(10961): accept()
07-09 16:30:24.750+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.750+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.760+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.760+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.780+0900 F/sio_packet(10961): accept()
07-09 16:30:24.780+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:24.780+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.800+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.800+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.810+0900 F/sio_packet(10961): accept()
07-09 16:30:24.810+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:24.810+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.830+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.830+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.850+0900 F/sio_packet(10961): accept()
07-09 16:30:24.850+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:24.850+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.870+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.870+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.880+0900 F/sio_packet(10961): accept()
07-09 16:30:24.880+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:24.880+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.890+0900 F/sio_packet(10961): accept()
07-09 16:30:24.890+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:24.890+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:24.900+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.900+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:24.930+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:24.930+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.040+0900 F/sio_packet(10961): accept()
07-09 16:30:25.040+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.040+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.070+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.070+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.070+0900 F/sio_packet(10961): accept()
07-09 16:30:25.070+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:25.070+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.100+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.100+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.110+0900 F/sio_packet(10961): accept()
07-09 16:30:25.110+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.110+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.130+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.130+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.140+0900 F/sio_packet(10961): accept()
07-09 16:30:25.140+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.140+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.160+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.160+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.170+0900 F/sio_packet(10961): accept()
07-09 16:30:25.170+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.170+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.190+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.190+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.200+0900 F/sio_packet(10961): accept()
07-09 16:30:25.210+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.210+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.220+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.220+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.230+0900 F/sio_packet(10961): accept()
07-09 16:30:25.230+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.230+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.250+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.250+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.260+0900 F/sio_packet(10961): accept()
07-09 16:30:25.260+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:25.260+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.300+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.300+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.480+0900 F/sio_packet(10961): accept()
07-09 16:30:25.480+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:25.480+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.510+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.510+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.520+0900 F/sio_packet(10961): accept()
07-09 16:30:25.520+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.520+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.550+0900 F/sio_packet(10961): accept()
07-09 16:30:25.550+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:25.550+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.550+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.550+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.570+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.570+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.580+0900 F/sio_packet(10961): accept()
07-09 16:30:25.590+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.590+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.600+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.600+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.610+0900 F/sio_packet(10961): accept()
07-09 16:30:25.610+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.620+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.630+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.630+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.640+0900 F/sio_packet(10961): accept()
07-09 16:30:25.640+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.640+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.660+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.660+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.670+0900 F/sio_packet(10961): accept()
07-09 16:30:25.670+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.670+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.690+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.690+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.700+0900 F/sio_packet(10961): accept()
07-09 16:30:25.700+0900 E/socket.io(10961): 743: encoded paylod length: 77
07-09 16:30:25.700+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.720+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.720+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.740+0900 F/sio_packet(10961): accept()
07-09 16:30:25.740+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.740+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.760+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.760+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.760+0900 F/sio_packet(10961): accept()
07-09 16:30:25.760+0900 E/socket.io(10961): 743: encoded paylod length: 79
07-09 16:30:25.760+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.780+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.780+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.790+0900 F/sio_packet(10961): accept()
07-09 16:30:25.790+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:25.790+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:25.830+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:25.830+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:25.990+0900 F/sio_packet(10961): accept()
07-09 16:30:25.990+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:25.990+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.010+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.010+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.020+0900 F/sio_packet(10961): accept()
07-09 16:30:26.030+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:26.030+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.040+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.040+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.060+0900 F/sio_packet(10961): accept()
07-09 16:30:26.060+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:26.060+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.080+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.080+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.090+0900 F/sio_packet(10961): accept()
07-09 16:30:26.090+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.090+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.110+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.110+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.130+0900 F/sio_packet(10961): accept()
07-09 16:30:26.130+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.130+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.140+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.140+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.160+0900 F/sio_packet(10961): accept()
07-09 16:30:26.160+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.160+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.180+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.180+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.190+0900 F/sio_packet(10961): accept()
07-09 16:30:26.190+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.190+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.210+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.210+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.220+0900 F/sio_packet(10961): accept()
07-09 16:30:26.220+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.220+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.250+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.250+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.260+0900 F/sio_packet(10961): accept()
07-09 16:30:26.260+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:26.260+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.290+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.290+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.470+0900 F/sio_packet(10961): accept()
07-09 16:30:26.470+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.470+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.500+0900 F/sio_packet(10961): accept()
07-09 16:30:26.500+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.500+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.500+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.500+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.520+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.520+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.530+0900 F/sio_packet(10961): accept()
07-09 16:30:26.530+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.540+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.560+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.560+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.570+0900 F/sio_packet(10961): accept()
07-09 16:30:26.570+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.570+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.590+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.590+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.600+0900 F/sio_packet(10961): accept()
07-09 16:30:26.600+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.600+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.630+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.630+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.630+0900 F/sio_packet(10961): accept()
07-09 16:30:26.630+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.630+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.650+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.650+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.660+0900 F/sio_packet(10961): accept()
07-09 16:30:26.660+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.670+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.680+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.680+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.690+0900 F/sio_packet(10961): accept()
07-09 16:30:26.690+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.690+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.710+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.710+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.720+0900 F/sio_packet(10961): accept()
07-09 16:30:26.730+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.730+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.740+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.740+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.760+0900 F/sio_packet(10961): accept()
07-09 16:30:26.760+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.760+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.780+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.780+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.790+0900 F/sio_packet(10961): accept()
07-09 16:30:26.790+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.790+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.810+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.810+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.820+0900 F/sio_packet(10961): accept()
07-09 16:30:26.830+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.830+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.840+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.840+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.860+0900 F/sio_packet(10961): accept()
07-09 16:30:26.860+0900 E/socket.io(10961): 743: encoded paylod length: 76
07-09 16:30:26.860+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.880+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.880+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.890+0900 F/sio_packet(10961): accept()
07-09 16:30:26.890+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:26.890+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.910+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.910+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.920+0900 F/sio_packet(10961): accept()
07-09 16:30:26.920+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:26.920+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.930+0900 F/sio_packet(10961): accept()
07-09 16:30:26.930+0900 E/socket.io(10961): 743: encoded paylod length: 21
07-09 16:30:26.930+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:26.940+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.940+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:26.970+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:26.970+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.180+0900 F/sio_packet(10961): accept()
07-09 16:30:27.180+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:27.180+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.220+0900 F/sio_packet(10961): accept()
07-09 16:30:27.220+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.220+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.220+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:27.230+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.250+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.250+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.260+0900 F/sio_packet(10961): accept()
07-09 16:30:27.260+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:27.260+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.280+0900 F/sio_packet(10961): accept()
07-09 16:30:27.280+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:27.280+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.290+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.290+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.300+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.300+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.320+0900 F/sio_packet(10961): accept()
07-09 16:30:27.320+0900 E/socket.io(10961): 743: encoded paylod length: 81
07-09 16:30:27.320+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.350+0900 F/sio_packet(10961): accept()
07-09 16:30:27.350+0900 E/socket.io(10961): 743: encoded paylod length: 82
07-09 16:30:27.350+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.360+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.360+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.370+0900 F/sio_packet(10961): accept()
07-09 16:30:27.370+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.380+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.380+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.390+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.400+0900 F/sio_packet(10961): accept()
07-09 16:30:27.400+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.400+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.410+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.410+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.430+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.430+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.440+0900 F/sio_packet(10961): accept()
07-09 16:30:27.440+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.440+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.460+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.460+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.470+0900 F/sio_packet(10961): accept()
07-09 16:30:27.470+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.470+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.490+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.490+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.500+0900 F/sio_packet(10961): accept()
07-09 16:30:27.500+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.500+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.520+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.520+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.530+0900 F/sio_packet(10961): accept()
07-09 16:30:27.530+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.530+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.560+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.560+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.570+0900 F/sio_packet(10961): accept()
07-09 16:30:27.570+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.570+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.590+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.590+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.590+0900 F/sio_packet(10961): accept()
07-09 16:30:27.590+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.600+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.610+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.610+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.630+0900 F/sio_packet(10961): accept()
07-09 16:30:27.630+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.630+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.650+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.650+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.660+0900 F/sio_packet(10961): accept()
07-09 16:30:27.660+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.660+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.690+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.690+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.700+0900 F/sio_packet(10961): accept()
07-09 16:30:27.700+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.700+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.720+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.720+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.730+0900 F/sio_packet(10961): accept()
07-09 16:30:27.730+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.740+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.760+0900 F/sio_packet(10961): accept()
07-09 16:30:27.760+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.760+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.770+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.770+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.780+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.780+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.790+0900 F/sio_packet(10961): accept()
07-09 16:30:27.790+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.790+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.810+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.810+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.820+0900 F/sio_packet(10961): accept()
07-09 16:30:27.820+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.820+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.850+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.850+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.850+0900 F/sio_packet(10961): accept()
07-09 16:30:27.860+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.860+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.880+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.880+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.890+0900 F/sio_packet(10961): accept()
07-09 16:30:27.890+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.890+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.910+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.910+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.920+0900 F/sio_packet(10961): accept()
07-09 16:30:27.920+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.930+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.940+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.940+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:27.950+0900 F/sio_packet(10961): accept()
07-09 16:30:27.950+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:27.960+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:27.970+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:27.970+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.020+0900 F/sio_packet(10961): accept()
07-09 16:30:28.020+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.020+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.030+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.030+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.060+0900 F/sio_packet(10961): accept()
07-09 16:30:28.060+0900 E/socket.io(10961): 743: encoded paylod length: 78
07-09 16:30:28.060+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.080+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.080+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.150+0900 F/sio_packet(10961): accept()
07-09 16:30:28.150+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.150+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.170+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.170+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.220+0900 F/sio_packet(10961): accept()
07-09 16:30:28.220+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.220+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.240+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.240+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.280+0900 F/sio_packet(10961): accept()
07-09 16:30:28.280+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.280+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.300+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.300+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.330+0900 F/sio_packet(10961): accept()
07-09 16:30:28.330+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.330+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.350+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.350+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.390+0900 F/sio_packet(10961): accept()
07-09 16:30:28.390+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.390+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.410+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.410+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.460+0900 F/sio_packet(10961): accept()
07-09 16:30:28.460+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.460+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.480+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.480+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.540+0900 F/sio_packet(10961): accept()
07-09 16:30:28.540+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.540+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.560+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.560+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.610+0900 F/sio_packet(10961): accept()
07-09 16:30:28.610+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.610+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.630+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.630+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.690+0900 F/sio_packet(10961): accept()
07-09 16:30:28.690+0900 E/socket.io(10961): 743: encoded paylod length: 80
07-09 16:30:28.690+0900 E/socket.io(10961): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 16:30:28.710+0900 E/socket.io(10961): 669: Received Message type(Event)
07-09 16:30:28.710+0900 F/get_binary(10961): in get binary_message()...
07-09 16:30:28.790+0900 W/CRASH_MANAGER(10894): worker.c: worker_job(1236) > 11109616e6f72143642702
