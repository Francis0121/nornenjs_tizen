S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 22143
Date: 2015-07-09 20:39:13+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb8095170

Register Information
r0   = 0xb1ab7000, r1   = 0xb8094170
r2   = 0x00000800, r3   = 0xb8095170
r4   = 0x00500000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000280
r8   = 0x000a0000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4436d70, pc   = 0xb4436f4c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    120424 KB
Buffers:     45628 KB
Cached:     247812 KB
VmPeak:      95708 KB
VmSize:      95092 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19036 KB
VmRSS:       19032 KB
VmData:      40560 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 22143 TID = 22143
22143 22144 22145 22167 22168 22169 

Maps Information
b1bd5000 b23d4000 rw-p [stack:22169]
b23d5000 b2bd4000 rw-p [stack:22168]
b2ecc000 b36cb000 rw-p [stack:22167]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:22144]
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
b6f91000 b6f94000 rw-p [stack:22145]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8095000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b8095000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22143)
Call Stack Count: 1
 0: (0xb4436f4c) [/usr/lib/driver/libEGL.so] + 0x26f4c
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
:39:10.694+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.694+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.704+0900 F/sio_packet(22143): accept()
07-09 20:39:10.704+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.704+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:10.704+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.714+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.724+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.724+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.734+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.734+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.744+0900 F/sio_packet(22143): accept()
07-09 20:39:10.744+0900 E/socket.io(22143): 743: encoded paylod length: 73
07-09 20:39:10.744+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.764+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.764+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.764+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.764+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.774+0900 F/sio_packet(22143): accept()
07-09 20:39:10.774+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:10.774+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.794+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.794+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.794+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.794+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.804+0900 F/sio_packet(22143): accept()
07-09 20:39:10.804+0900 E/socket.io(22143): 743: encoded paylod length: 81
07-09 20:39:10.804+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.824+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.824+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.824+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.834+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.834+0900 F/sio_packet(22143): accept()
07-09 20:39:10.834+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:10.844+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.864+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.864+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.864+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.874+0900 F/sio_packet(22143): accept()
07-09 20:39:10.874+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:10.874+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.874+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.894+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.894+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.894+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.894+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.904+0900 F/sio_packet(22143): accept()
07-09 20:39:10.904+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:10.904+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.924+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.924+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.924+0900 F/sio_packet(22143): accept()
07-09 20:39:10.924+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:10.934+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.934+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.934+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.954+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.954+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.954+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.954+0900 F/sio_packet(22143): accept()
07-09 20:39:10.964+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:10.964+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.964+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:10.984+0900 F/sio_packet(22143): accept()
07-09 20:39:10.984+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:10.984+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:10.984+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:10.994+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:10.994+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:10.994+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.014+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.014+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.014+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.014+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.024+0900 F/sio_packet(22143): accept()
07-09 20:39:11.024+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.024+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.044+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.044+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.044+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.044+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.054+0900 F/sio_packet(22143): accept()
07-09 20:39:11.054+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:11.054+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.074+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.074+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.074+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.084+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.084+0900 F/sio_packet(22143): accept()
07-09 20:39:11.084+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.084+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.114+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.114+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.114+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.124+0900 F/sio_packet(22143): accept()
07-09 20:39:11.124+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.124+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.124+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.144+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.144+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.144+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.144+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.154+0900 F/sio_packet(22143): accept()
07-09 20:39:11.154+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.154+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.174+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.174+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.184+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.184+0900 F/sio_packet(22143): accept()
07-09 20:39:11.184+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.194+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.194+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.204+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.204+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.214+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.214+0900 F/sio_packet(22143): accept()
07-09 20:39:11.214+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.214+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.224+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.234+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.234+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.244+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.244+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.244+0900 F/sio_packet(22143): accept()
07-09 20:39:11.244+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.244+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.284+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.284+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.284+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.284+0900 F/sio_packet(22143): accept()
07-09 20:39:11.284+0900 E/socket.io(22143): 743: encoded paylod length: 81
07-09 20:39:11.284+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.294+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.314+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.314+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.314+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.314+0900 F/sio_packet(22143): accept()
07-09 20:39:11.324+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.324+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.324+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.344+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.344+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.344+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.344+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.354+0900 F/sio_packet(22143): accept()
07-09 20:39:11.354+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.354+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.374+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.374+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.384+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.384+0900 F/sio_packet(22143): accept()
07-09 20:39:11.384+0900 E/socket.io(22143): 743: encoded paylod length: 72
07-09 20:39:11.384+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.394+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.404+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.404+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.414+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.414+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.414+0900 F/sio_packet(22143): accept()
07-09 20:39:11.414+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:11.414+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.434+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.434+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.434+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.444+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.444+0900 F/sio_packet(22143): accept()
07-09 20:39:11.454+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.454+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.474+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.474+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.474+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.474+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.484+0900 F/sio_packet(22143): accept()
07-09 20:39:11.484+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.484+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.504+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.504+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.504+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.514+0900 F/sio_packet(22143): accept()
07-09 20:39:11.514+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.514+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.514+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.534+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.534+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.534+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.534+0900 F/sio_packet(22143): accept()
07-09 20:39:11.544+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:11.544+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.544+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.554+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.554+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.564+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.564+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.574+0900 F/sio_packet(22143): accept()
07-09 20:39:11.574+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.574+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.594+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.594+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.594+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.604+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.604+0900 F/sio_packet(22143): accept()
07-09 20:39:11.614+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.614+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.624+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.624+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.634+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.634+0900 F/sio_packet(22143): accept()
07-09 20:39:11.634+0900 E/socket.io(22143): 743: encoded paylod length: 81
07-09 20:39:11.634+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.644+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.654+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.654+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.664+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.664+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.674+0900 F/sio_packet(22143): accept()
07-09 20:39:11.674+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.674+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.694+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.694+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.694+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.704+0900 F/sio_packet(22143): accept()
07-09 20:39:11.704+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.704+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.704+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.724+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.724+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.724+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.724+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.734+0900 F/sio_packet(22143): accept()
07-09 20:39:11.734+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.734+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.754+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.754+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.754+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.764+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.764+0900 F/sio_packet(22143): accept()
07-09 20:39:11.774+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.774+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.784+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.784+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.794+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.794+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.804+0900 F/sio_packet(22143): accept()
07-09 20:39:11.804+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:11.804+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.824+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.824+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.824+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.824+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.834+0900 F/sio_packet(22143): accept()
07-09 20:39:11.834+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.834+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.854+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.854+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.854+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.864+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.864+0900 F/sio_packet(22143): accept()
07-09 20:39:11.864+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.874+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.894+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.894+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.894+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.904+0900 F/sio_packet(22143): accept()
07-09 20:39:11.904+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:11.904+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.904+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.914+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.914+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.924+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.924+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.934+0900 F/sio_packet(22143): accept()
07-09 20:39:11.934+0900 E/socket.io(22143): 743: encoded paylod length: 80
07-09 20:39:11.934+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.954+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.954+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.954+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.964+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:11.964+0900 F/sio_packet(22143): accept()
07-09 20:39:11.964+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:11.964+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.984+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:11.984+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:11.994+0900 F/sio_packet(22143): accept()
07-09 20:39:11.994+0900 E/socket.io(22143): 743: encoded paylod length: 74
07-09 20:39:11.994+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:11.994+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:11.994+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.014+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.014+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.014+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.014+0900 F/sio_packet(22143): accept()
07-09 20:39:12.014+0900 E/socket.io(22143): 743: encoded paylod length: 74
07-09 20:39:12.014+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.014+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.034+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.034+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.034+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.034+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.044+0900 F/sio_packet(22143): accept()
07-09 20:39:12.044+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.044+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.064+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.064+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.064+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.064+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.074+0900 F/sio_packet(22143): accept()
07-09 20:39:12.074+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:12.084+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.094+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.094+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.104+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.104+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.114+0900 F/sio_packet(22143): accept()
07-09 20:39:12.114+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.114+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.134+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.134+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.144+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.144+0900 F/sio_packet(22143): accept()
07-09 20:39:12.144+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.144+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.154+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.164+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.164+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.164+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.174+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.174+0900 F/sio_packet(22143): accept()
07-09 20:39:12.174+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.174+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.194+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.194+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.194+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.204+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.224+0900 F/sio_packet(22143): accept()
07-09 20:39:12.224+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.224+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.244+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.244+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.244+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.254+0900 F/sio_packet(22143): accept()
07-09 20:39:12.254+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.254+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.254+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.264+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.264+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.274+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.274+0900 F/sio_packet(22143): accept()
07-09 20:39:12.274+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.274+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.274+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.294+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.294+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.294+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.304+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.304+0900 F/sio_packet(22143): accept()
07-09 20:39:12.314+0900 E/socket.io(22143): 743: encoded paylod length: 74
07-09 20:39:12.314+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.334+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.334+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.344+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.344+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.344+0900 F/sio_packet(22143): accept()
07-09 20:39:12.354+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.354+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.374+0900 F/sio_packet(22143): accept()
07-09 20:39:12.374+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.374+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.384+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.384+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.384+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.394+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.404+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.404+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.404+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.404+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.414+0900 F/sio_packet(22143): accept()
07-09 20:39:12.414+0900 E/socket.io(22143): 743: encoded paylod length: 79
07-09 20:39:12.414+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.434+0900 F/sio_packet(22143): accept()
07-09 20:39:12.444+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:12.444+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.444+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.444+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.454+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.454+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.464+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.474+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.474+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.474+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.484+0900 F/sio_packet(22143): accept()
07-09 20:39:12.484+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.484+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.504+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.504+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.504+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.504+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.514+0900 F/sio_packet(22143): accept()
07-09 20:39:12.514+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.514+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.534+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.534+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.534+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.544+0900 F/sio_packet(22143): accept()
07-09 20:39:12.544+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.544+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.544+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.564+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.564+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.574+0900 F/sio_packet(22143): accept()
07-09 20:39:12.574+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.574+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.574+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.574+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.594+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.594+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.604+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.604+0900 F/sio_packet(22143): accept()
07-09 20:39:12.604+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.604+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.604+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.624+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.624+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.624+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.634+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.634+0900 F/sio_packet(22143): accept()
07-09 20:39:12.644+0900 E/socket.io(22143): 743: encoded paylod length: 82
07-09 20:39:12.644+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.654+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.654+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.664+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.664+0900 F/sio_packet(22143): accept()
07-09 20:39:12.664+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:12.664+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.664+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.684+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.684+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.684+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.684+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.704+0900 F/sio_packet(22143): accept()
07-09 20:39:12.704+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.704+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.724+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.724+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.724+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.734+0900 F/sio_packet(22143): accept()
07-09 20:39:12.734+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.734+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.734+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.754+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.754+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.754+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.754+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.764+0900 F/sio_packet(22143): accept()
07-09 20:39:12.764+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.764+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.784+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.784+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.784+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.794+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.794+0900 F/sio_packet(22143): accept()
07-09 20:39:12.804+0900 E/socket.io(22143): 743: encoded paylod length: 81
07-09 20:39:12.804+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.814+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.814+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.824+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.824+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.824+0900 F/sio_packet(22143): accept()
07-09 20:39:12.834+0900 E/socket.io(22143): 743: encoded paylod length: 84
07-09 20:39:12.834+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.854+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.854+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.854+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.854+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.864+0900 F/sio_packet(22143): accept()
07-09 20:39:12.864+0900 E/socket.io(22143): 743: encoded paylod length: 74
07-09 20:39:12.864+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.884+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.884+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.884+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.884+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.894+0900 F/sio_packet(22143): accept()
07-09 20:39:12.894+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.894+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.914+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.914+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.914+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.924+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.924+0900 F/sio_packet(22143): accept()
07-09 20:39:12.924+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:12.934+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.944+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.944+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.954+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.954+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.964+0900 F/sio_packet(22143): accept()
07-09 20:39:12.964+0900 E/socket.io(22143): 743: encoded paylod length: 82
07-09 20:39:12.964+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:12.984+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:12.984+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:12.984+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:12.994+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:12.994+0900 F/sio_packet(22143): accept()
07-09 20:39:12.994+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:12.994+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.014+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.014+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.014+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.024+0900 F/sio_packet(22143): accept()
07-09 20:39:13.024+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.024+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.024+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.044+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.044+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.044+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.054+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.054+0900 F/sio_packet(22143): accept()
07-09 20:39:13.054+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.064+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.084+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.084+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.084+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.084+0900 F/sio_packet(22143): accept()
07-09 20:39:13.084+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.084+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.094+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.104+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.104+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.104+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.114+0900 F/sio_packet(22143): accept()
07-09 20:39:13.114+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.114+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.124+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.134+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.134+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.134+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.144+0900 F/sio_packet(22143): accept()
07-09 20:39:13.144+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.144+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.154+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.164+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.164+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.164+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.174+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.174+0900 F/sio_packet(22143): accept()
07-09 20:39:13.184+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.184+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.194+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.194+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.204+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.204+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.204+0900 F/sio_packet(22143): accept()
07-09 20:39:13.214+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:13.214+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.234+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.234+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.234+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.234+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.244+0900 F/sio_packet(22143): accept()
07-09 20:39:13.244+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.244+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.264+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.264+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.264+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.274+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.274+0900 F/sio_packet(22143): accept()
07-09 20:39:13.274+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.274+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.294+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.294+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.304+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.304+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.304+0900 F/sio_packet(22143): accept()
07-09 20:39:13.314+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.314+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.324+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.324+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.334+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.334+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.344+0900 F/sio_packet(22143): accept()
07-09 20:39:13.344+0900 E/socket.io(22143): 743: encoded paylod length: 81
07-09 20:39:13.344+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.364+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.364+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.364+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.364+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.374+0900 F/sio_packet(22143): accept()
07-09 20:39:13.374+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.374+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.394+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.394+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.394+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.394+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.404+0900 F/sio_packet(22143): accept()
07-09 20:39:13.404+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:13.404+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.434+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.434+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.434+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.444+0900 F/sio_packet(22143): accept()
07-09 20:39:13.444+0900 E/socket.io(22143): 743: encoded paylod length: 79
07-09 20:39:13.444+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.454+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.464+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.464+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.464+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.464+0900 F/sio_packet(22143): accept()
07-09 20:39:13.464+0900 E/socket.io(22143): 743: encoded paylod length: 74
07-09 20:39:13.474+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.474+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.494+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.494+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.504+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.504+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.514+0900 F/sio_packet(22143): accept()
07-09 20:39:13.514+0900 E/socket.io(22143): 743: encoded paylod length: 76
07-09 20:39:13.514+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.524+0900 F/sio_packet(22143): accept()
07-09 20:39:13.534+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.534+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.534+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.534+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.534+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.544+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.554+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.554+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.564+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.564+0900 F/sio_packet(22143): accept()
07-09 20:39:13.564+0900 E/socket.io(22143): 743: encoded paylod length: 75
07-09 20:39:13.564+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.564+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.584+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.584+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.584+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.584+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.594+0900 F/sio_packet(22143): accept()
07-09 20:39:13.594+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.594+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.614+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.614+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.614+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.614+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.624+0900 F/sio_packet(22143): accept()
07-09 20:39:13.624+0900 E/socket.io(22143): 743: encoded paylod length: 21
07-09 20:39:13.624+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.664+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.664+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.684+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.684+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.804+0900 F/sio_packet(22143): accept()
07-09 20:39:13.804+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.804+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.834+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.834+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.834+0900 F/sio_packet(22143): accept()
07-09 20:39:13.834+0900 E/socket.io(22143): 743: encoded paylod length: 77
07-09 20:39:13.834+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.834+0900 I/nornenjs_queue(22143): Queue pop
07-09 20:39:13.834+0900 E/socket.io(22143): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:39:13.854+0900 E/socket.io(22143): 669: Received Message type(Event)
07-09 20:39:13.854+0900 F/get_binary(22143): in get binary_message()...
07-09 20:39:13.854+0900 I/nornenjs_queue(22143): Queue push
07-09 20:39:13.944+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 22143 pgid = 22143
07-09 20:39:13.944+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(22143)
07-09 20:39:13.944+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 20:39:13.944+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 20:39:13.944+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 22143
07-09 20:39:13.964+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-09 20:39:13.964+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 20:39:13.964+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[22143] terminate event is forwarded
07-09 20:39:13.964+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 20:39:13.964+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 22143, ]
07-09 20:39:13.964+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 20:39:13.964+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-09 20:39:13.964+0900 I/Tizen::App( 1034): (512) > Not registered pid(22143)
07-09 20:39:13.964+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 22143.
07-09 20:39:13.994+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 20:39:13.994+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-09 20:39:13.994+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 20:39:13.994+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 22143.
07-09 20:39:14.044+0900 W/CRASH_MANAGER(22220): worker.c: worker_job(1236) > 11221436e6f72143644195