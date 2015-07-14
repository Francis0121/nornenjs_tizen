S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 19208
Date: 2015-07-09 20:29:55+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb35a1470

Register Information
r0   = 0xb0ec8000, r1   = 0xb35a0470
r2   = 0x00000800, r3   = 0xb35a1470
r4   = 0x00200000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000100
r8   = 0x00040000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4436d70, pc   = 0xb4436f4c
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    114804 KB
Buffers:     45932 KB
Cached:     248984 KB
VmPeak:     105588 KB
VmSize:     105584 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21792 KB
VmRSS:       21788 KB
VmData:      51052 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 19208 TID = 19208
19208 19209 19210 19234 19235 19237 

Maps Information
b120a000 b1a09000 rw-p [stack:19237]
b220a000 b2a09000 rw-p [stack:19235]
b2d01000 b3500000 rw-p [stack:19234]
b3a03000 b3a04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0c000 b3a13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a29000 b3a2a000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a32000 b3a34000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3c000 b3a3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a45000 b3a5c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c03000 b3c07000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c11000 b4410000 rw-p [stack:19209]
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
b6f91000 b6f94000 rw-p [stack:19210]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b81cf000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b81cf000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19208)
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
2.094+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.104+0900 F/sio_packet(19208): accept()
07-09 20:29:52.104+0900 E/socket.io(19208): 743: encoded paylod length: 83
07-09 20:29:52.104+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.104+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.114+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.124+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.124+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.124+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.124+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.134+0900 F/sio_packet(19208): accept()
07-09 20:29:52.134+0900 E/socket.io(19208): 743: encoded paylod length: 83
07-09 20:29:52.134+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.144+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.154+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.154+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.154+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.164+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.164+0900 F/sio_packet(19208): accept()
07-09 20:29:52.174+0900 E/socket.io(19208): 743: encoded paylod length: 85
07-09 20:29:52.174+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.174+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.194+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.194+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.194+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.204+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.204+0900 F/sio_packet(19208): accept()
07-09 20:29:52.204+0900 E/socket.io(19208): 743: encoded paylod length: 82
07-09 20:29:52.204+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.214+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.224+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.234+0900 F/sio_packet(19208): accept()
07-09 20:29:52.234+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:52.234+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.244+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.244+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.244+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.244+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.254+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.254+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.264+0900 F/sio_packet(19208): accept()
07-09 20:29:52.264+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:52.264+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.264+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.264+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.274+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.284+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.284+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.284+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.294+0900 F/sio_packet(19208): accept()
07-09 20:29:52.294+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.294+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.304+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.314+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.314+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.314+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.324+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.334+0900 F/sio_packet(19208): accept()
07-09 20:29:52.334+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.334+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.344+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.354+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.354+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.354+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.364+0900 F/sio_packet(19208): accept()
07-09 20:29:52.364+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:52.364+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.364+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.374+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.374+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.384+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.384+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.394+0900 F/sio_packet(19208): accept()
07-09 20:29:52.394+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:52.394+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.394+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.414+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.424+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.424+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.434+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.434+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.434+0900 F/sio_packet(19208): accept()
07-09 20:29:52.434+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.434+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.444+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.454+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.454+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.454+0900 F/sio_packet(19208): accept()
07-09 20:29:52.454+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.464+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.474+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.474+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.494+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.494+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.494+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.494+0900 F/sio_packet(19208): accept()
07-09 20:29:52.494+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.494+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.494+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.514+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.514+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.514+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.514+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.524+0900 F/sio_packet(19208): accept()
07-09 20:29:52.524+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.524+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.524+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.544+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.544+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.544+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.544+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.554+0900 F/sio_packet(19208): accept()
07-09 20:29:52.554+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.554+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.564+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.574+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.574+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.574+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.584+0900 F/sio_packet(19208): accept()
07-09 20:29:52.584+0900 E/socket.io(19208): 743: encoded paylod length: 80
07-09 20:29:52.584+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.594+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.604+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.604+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.614+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.614+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.624+0900 F/sio_packet(19208): accept()
07-09 20:29:52.624+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.624+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.624+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.634+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.634+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.644+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.654+0900 F/sio_packet(19208): accept()
07-09 20:29:52.654+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.654+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.664+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.674+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.674+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.684+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.684+0900 F/sio_packet(19208): accept()
07-09 20:29:52.684+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.684+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.694+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.704+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.704+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.704+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.714+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.724+0900 F/sio_packet(19208): accept()
07-09 20:29:52.724+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.724+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.724+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.744+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.744+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.744+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.744+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.754+0900 F/sio_packet(19208): accept()
07-09 20:29:52.754+0900 E/socket.io(19208): 743: encoded paylod length: 73
07-09 20:29:52.754+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.764+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.774+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.784+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.784+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.784+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.784+0900 F/sio_packet(19208): accept()
07-09 20:29:52.794+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.794+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.794+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.814+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.814+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.814+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.814+0900 F/sio_packet(19208): accept()
07-09 20:29:52.814+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:52.814+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.824+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.824+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.834+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.834+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.834+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.844+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.854+0900 F/sio_packet(19208): accept()
07-09 20:29:52.854+0900 E/socket.io(19208): 743: encoded paylod length: 81
07-09 20:29:52.854+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.854+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.874+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.874+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.874+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.874+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:52.884+0900 F/sio_packet(19208): accept()
07-09 20:29:52.884+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:52.884+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.894+0900 F/sio_packet(19208): accept()
07-09 20:29:52.894+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:52.894+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:52.894+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.904+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.904+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.914+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.924+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.944+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:52.944+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:52.964+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:52.974+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:52.994+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.004+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.024+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.044+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.054+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.074+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.094+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.104+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.124+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.144+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.154+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.174+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.194+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.204+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.224+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.244+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.254+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.274+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.284+0900 F/sio_packet(19208): accept()
07-09 20:29:53.294+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:53.294+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.294+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.304+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.324+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.324+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.324+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.324+0900 F/sio_packet(19208): accept()
07-09 20:29:53.324+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:53.334+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.334+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.344+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.354+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.354+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.354+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.354+0900 F/sio_packet(19208): accept()
07-09 20:29:53.354+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:53.354+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.364+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.374+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.374+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.374+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.384+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.394+0900 F/sio_packet(19208): accept()
07-09 20:29:53.394+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:53.394+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.394+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.404+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.414+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.414+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.414+0900 F/sio_packet(19208): accept()
07-09 20:29:53.414+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:53.424+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.434+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.444+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.454+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.454+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.454+0900 F/sio_packet(19208): accept()
07-09 20:29:53.454+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:53.464+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.464+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.474+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.494+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.504+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.504+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.514+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.524+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.544+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.554+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.574+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.584+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.604+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.624+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.634+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.654+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.674+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.684+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.704+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.724+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.734+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.754+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.764+0900 F/sio_packet(19208): accept()
07-09 20:29:53.764+0900 E/socket.io(19208): 743: encoded paylod length: 75
07-09 20:29:53.764+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.774+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.794+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.804+0900 F/sio_packet(19208): accept()
07-09 20:29:53.804+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:53.804+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.804+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.804+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.814+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.824+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.824+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.834+0900 W/nornenjs_queue(19208): Queue not push
07-09 20:29:53.834+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.834+0900 F/sio_packet(19208): accept()
07-09 20:29:53.844+0900 E/socket.io(19208): 743: encoded paylod length: 77
07-09 20:29:53.844+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.844+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.854+0900 F/sio_packet(19208): accept()
07-09 20:29:53.854+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:53.854+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.854+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.864+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.864+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.864+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.874+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.874+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.874+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.874+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.884+0900 F/sio_packet(19208): accept()
07-09 20:29:53.884+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:53.884+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.894+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.904+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.904+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.904+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.914+0900 F/sio_packet(19208): accept()
07-09 20:29:53.914+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:53.914+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.924+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.934+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.934+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.934+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.934+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:53.944+0900 F/sio_packet(19208): accept()
07-09 20:29:53.954+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:53.954+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.954+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:53.964+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:53.964+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:53.974+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:53.974+0900 F/sio_packet(19208): accept()
07-09 20:29:53.974+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:53.984+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:53.984+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.004+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.014+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.014+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.034+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.034+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.044+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.064+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.074+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.084+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.104+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.124+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.134+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.154+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.174+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.184+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.204+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.224+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.234+0900 F/sio_packet(19208): accept()
07-09 20:29:54.234+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.234+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.234+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.254+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.264+0900 F/sio_packet(19208): accept()
07-09 20:29:54.264+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.264+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.274+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.274+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.274+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.274+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.284+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.294+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.294+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.294+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.304+0900 F/sio_packet(19208): accept()
07-09 20:29:54.304+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.304+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.304+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.314+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.314+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.324+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.324+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.324+0900 F/sio_packet(19208): accept()
07-09 20:29:54.324+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.324+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.334+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.354+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.354+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.354+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.354+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.364+0900 F/sio_packet(19208): accept()
07-09 20:29:54.364+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.364+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.374+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.384+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.384+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.384+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.394+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.394+0900 F/sio_packet(19208): accept()
07-09 20:29:54.394+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:54.394+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.404+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.414+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.414+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.424+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.424+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.434+0900 F/sio_packet(19208): accept()
07-09 20:29:54.434+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.434+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.434+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.454+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.454+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.454+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.464+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.464+0900 F/sio_packet(19208): accept()
07-09 20:29:54.464+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.474+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.474+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.484+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.494+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.494+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.494+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.494+0900 F/sio_packet(19208): accept()
07-09 20:29:54.504+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.504+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.504+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.524+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.524+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.524+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.524+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.534+0900 F/sio_packet(19208): accept()
07-09 20:29:54.534+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:54.534+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.534+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.554+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.554+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.554+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.564+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.564+0900 F/sio_packet(19208): accept()
07-09 20:29:54.564+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.564+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.574+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.574+0900 F/sio_packet(19208): accept()
07-09 20:29:54.584+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:54.584+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.584+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.584+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.594+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.604+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.614+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.624+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.624+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.644+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.654+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.664+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.684+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.704+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.714+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.734+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.754+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.764+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.784+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.804+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.814+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.824+0900 F/sio_packet(19208): accept()
07-09 20:29:54.834+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.834+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.834+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.854+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.864+0900 F/sio_packet(19208): accept()
07-09 20:29:54.864+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.864+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.864+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.884+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.894+0900 F/sio_packet(19208): accept()
07-09 20:29:54.894+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.894+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.904+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.914+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.924+0900 F/sio_packet(19208): accept()
07-09 20:29:54.924+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.934+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.934+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.954+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.954+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:54.954+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:54.954+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:54.964+0900 F/sio_packet(19208): accept()
07-09 20:29:54.964+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:54.964+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.964+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.984+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:54.984+0900 F/sio_packet(19208): accept()
07-09 20:29:54.994+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:54.994+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:54.994+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:54.994+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.004+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.004+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.014+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.014+0900 W/nornenjs_queue(19208): Queue not push
07-09 20:29:55.014+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.024+0900 F/sio_packet(19208): accept()
07-09 20:29:55.024+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.024+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.024+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.034+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.034+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.034+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.034+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.034+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.044+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.044+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.044+0900 W/nornenjs_queue(19208): Queue not push
07-09 20:29:55.044+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.054+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.054+0900 F/sio_packet(19208): accept()
07-09 20:29:55.054+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.054+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.064+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.074+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.074+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.084+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.084+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.084+0900 F/sio_packet(19208): accept()
07-09 20:29:55.094+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.094+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.094+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.094+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.104+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.114+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.114+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.124+0900 F/sio_packet(19208): accept()
07-09 20:29:55.124+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.124+0900 W/nornenjs_queue(19208): Queue not push
07-09 20:29:55.124+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.134+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.154+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.154+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.154+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.154+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.164+0900 F/sio_packet(19208): accept()
07-09 20:29:55.164+0900 E/socket.io(19208): 743: encoded paylod length: 76
07-09 20:29:55.164+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.164+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.184+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.184+0900 F/sio_packet(19208): accept()
07-09 20:29:55.194+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.194+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.204+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.214+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.214+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.214+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.214+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.224+0900 F/sio_packet(19208): accept()
07-09 20:29:55.224+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.224+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.234+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.234+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.234+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.244+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.244+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.244+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.254+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.254+0900 F/sio_packet(19208): accept()
07-09 20:29:55.254+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.254+0900 F/sio_packet(19208): accept()
07-09 20:29:55.254+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:55.254+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.254+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.264+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.284+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.294+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.304+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.304+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.314+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.314+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.314+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.314+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.334+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.334+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.344+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.364+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.384+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.404+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.414+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.434+0900 F/sio_packet(19208): accept()
07-09 20:29:55.434+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.434+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.434+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.454+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.454+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.454+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.454+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.464+0900 F/sio_packet(19208): accept()
07-09 20:29:55.464+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.464+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.464+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.484+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.484+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.484+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.484+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.494+0900 F/sio_packet(19208): accept()
07-09 20:29:55.494+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.504+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.504+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.514+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.524+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.524+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.524+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.534+0900 F/sio_packet(19208): accept()
07-09 20:29:55.534+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.534+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.534+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.554+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.554+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.554+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.554+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.564+0900 F/sio_packet(19208): accept()
07-09 20:29:55.564+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.564+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.564+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.584+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.584+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.584+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.584+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.594+0900 F/sio_packet(19208): accept()
07-09 20:29:55.594+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.594+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.604+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.614+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.614+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.624+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.624+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.624+0900 F/sio_packet(19208): accept()
07-09 20:29:55.634+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.634+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.634+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.644+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.654+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.654+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.654+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.664+0900 F/sio_packet(19208): accept()
07-09 20:29:55.664+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.664+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.674+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.684+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.684+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.684+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.684+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.694+0900 F/sio_packet(19208): accept()
07-09 20:29:55.694+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.694+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.704+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.714+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.714+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.724+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.724+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.734+0900 F/sio_packet(19208): accept()
07-09 20:29:55.734+0900 E/socket.io(19208): 743: encoded paylod length: 78
07-09 20:29:55.734+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.734+0900 F/sio_packet(19208): accept()
07-09 20:29:55.734+0900 E/socket.io(19208): 743: encoded paylod length: 21
07-09 20:29:55.734+0900 E/socket.io(19208): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 20:29:55.744+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.754+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.754+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.754+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.754+0900 I/nornenjs_queue(19208): Queue pop
07-09 20:29:55.764+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.784+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.784+0900 E/socket.io(19208): 669: Received Message type(Event)
07-09 20:29:55.784+0900 F/get_binary(19208): in get binary_message()...
07-09 20:29:55.804+0900 I/nornenjs_queue(19208): Queue push
07-09 20:29:55.804+0900 W/nornenjs_queue(19208): Queue not pop
07-09 20:29:55.934+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 20:29:55.934+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-09 20:29:55.944+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 19208 pgid = 19208
07-09 20:29:55.944+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(19208)
07-09 20:29:55.944+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 20:29:55.944+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 20:29:55.964+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-09 20:29:55.964+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 20:29:55.964+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[19208] terminate event is forwarded
07-09 20:29:55.964+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 20:29:55.964+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 19208, ]
07-09 20:29:55.964+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 20:29:55.964+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-09 20:29:55.964+0900 I/Tizen::App( 1034): (512) > Not registered pid(19208)
07-09 20:29:55.964+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 19208.
07-09 20:29:55.974+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 19208
07-09 20:29:55.984+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 20:29:55.984+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 19208.
07-09 20:29:56.014+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-09 20:29:56.024+0900 W/CRASH_MANAGER(19275): worker.c: worker_job(1236) > 11192086e6f72143644139
