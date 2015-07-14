S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 17887
Date: 2015-07-09 18:42:00+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb815f710

Register Information
r0   = 0xb1a76000, r1   = 0xb815ef10
r2   = 0x00000800, r3   = 0xb815f710
r4   = 0x00300000, r5   = 0x00000000
r6   = 0x00000000, r7   = 0x00000180
r8   = 0x00060000, r9   = 0x00002000
r10  = 0x00000200, fp   = 0x00000200
ip   = 0x00000000, sp   = 0xbef82310
lr   = 0xb4435d70, pc   = 0xb4435f48
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    111000 KB
Buffers:     45932 KB
Cached:     252920 KB
VmPeak:      96672 KB
VmSize:      96668 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20960 KB
VmRSS:       20956 KB
VmData:      42388 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 17887 TID = 17887
17887 17895 17896 17919 17920 17921 

Maps Information
b1bd4000 b23d3000 rw-p [stack:17921]
b23d4000 b2bd3000 rw-p [stack:17920]
b2ecb000 b36ca000 rw-p [stack:17919]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:17895]
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
b6f91000 b6f94000 rw-p [stack:17896]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b815f000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b815f000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17887)
Call Stack Count: 1
 0: (0xb4435f48) [/usr/lib/driver/libEGL.so] + 0x26f48
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
et.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:45.364+0900 F/sio_packet(17775): accept()
07-09 18:41:45.364+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:45.364+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.364+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:45.374+0900 F/sio_packet(17775): accept()
07-09 18:41:45.374+0900 E/socket.io(17775): 743: encoded paylod length: 21
07-09 18:41:45.384+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.384+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:45.384+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:45.384+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:45.404+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.404+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:45.414+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.414+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:45.454+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.454+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:45.484+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:45.484+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.294+0900 F/sio_packet(17775): accept()
07-09 18:41:46.294+0900 E/socket.io(17775): 743: encoded paylod length: 77
07-09 18:41:46.294+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.314+0900 F/sio_packet(17775): accept()
07-09 18:41:46.314+0900 E/socket.io(17775): 743: encoded paylod length: 77
07-09 18:41:46.314+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.324+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.324+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.344+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.344+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.354+0900 F/sio_packet(17775): accept()
07-09 18:41:46.354+0900 E/socket.io(17775): 743: encoded paylod length: 77
07-09 18:41:46.354+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.374+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.374+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.374+0900 F/sio_packet(17775): accept()
07-09 18:41:46.374+0900 E/socket.io(17775): 743: encoded paylod length: 75
07-09 18:41:46.374+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.394+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.394+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.404+0900 F/sio_packet(17775): accept()
07-09 18:41:46.404+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.404+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.434+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.434+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.444+0900 F/sio_packet(17775): accept()
07-09 18:41:46.444+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.444+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.464+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.464+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.474+0900 F/sio_packet(17775): accept()
07-09 18:41:46.474+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.474+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.494+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.494+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.504+0900 F/sio_packet(17775): accept()
07-09 18:41:46.514+0900 E/socket.io(17775): 743: encoded paylod length: 76
07-09 18:41:46.514+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.534+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.534+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.534+0900 F/sio_packet(17775): accept()
07-09 18:41:46.544+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.544+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.564+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.564+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.574+0900 F/sio_packet(17775): accept()
07-09 18:41:46.574+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.574+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.594+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.594+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.604+0900 F/sio_packet(17775): accept()
07-09 18:41:46.604+0900 E/socket.io(17775): 743: encoded paylod length: 78
07-09 18:41:46.604+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.624+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.624+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.634+0900 F/sio_packet(17775): accept()
07-09 18:41:46.634+0900 E/socket.io(17775): 743: encoded paylod length: 76
07-09 18:41:46.634+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.654+0900 F/sio_packet(17775): accept()
07-09 18:41:46.654+0900 E/socket.io(17775): 743: encoded paylod length: 21
07-09 18:41:46.654+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:46.684+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.684+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:46.724+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:46.724+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.384+0900 F/sio_packet(17775): accept()
07-09 18:41:47.384+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:47.384+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.404+0900 F/sio_packet(17775): accept()
07-09 18:41:47.404+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:47.404+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.424+0900 F/sio_packet(17775): accept()
07-09 18:41:47.424+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.424+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.444+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.444+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.454+0900 F/sio_packet(17775): accept()
07-09 18:41:47.454+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.454+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.474+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.474+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.474+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.474+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.474+0900 F/sio_packet(17775): accept()
07-09 18:41:47.484+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.484+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.494+0900 F/sio_packet(17775): accept()
07-09 18:41:47.494+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.504+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.504+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.504+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.524+0900 F/sio_packet(17775): accept()
07-09 18:41:47.524+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.524+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.524+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.524+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.544+0900 F/sio_packet(17775): accept()
07-09 18:41:47.544+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.544+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.554+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.554+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.554+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.554+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.574+0900 F/sio_packet(17775): accept()
07-09 18:41:47.574+0900 E/socket.io(17775): 743: encoded paylod length: 51
07-09 18:41:47.574+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.584+0900 F/sio_packet(17775): accept()
07-09 18:41:47.584+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.584+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.584+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.584+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.594+0900 F/sio_packet(17775): accept()
07-09 18:41:47.594+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.594+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.594+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.604+0900 F/sio_packet(17775): accept()
07-09 18:41:47.604+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.604+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.614+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.614+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.614+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.614+0900 F/sio_packet(17775): accept()
07-09 18:41:47.614+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.624+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.624+0900 F/sio_packet(17775): accept()
07-09 18:41:47.634+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.634+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.634+0900 F/sio_packet(17775): accept()
07-09 18:41:47.634+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.644+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.644+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.644+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.644+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.654+0900 F/sio_packet(17775): accept()
07-09 18:41:47.654+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.654+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.654+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.664+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.664+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.664+0900 F/sio_packet(17775): accept()
07-09 18:41:47.664+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.674+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.674+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.674+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.684+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.684+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.694+0900 F/sio_packet(17775): accept()
07-09 18:41:47.694+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.694+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.704+0900 F/sio_packet(17775): accept()
07-09 18:41:47.704+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:47.704+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.714+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.714+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.724+0900 F/sio_packet(17775): accept()
07-09 18:41:47.724+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.724+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.724+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.734+0900 F/sio_packet(17775): accept()
07-09 18:41:47.734+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.744+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.744+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.754+0900 F/sio_packet(17775): accept()
07-09 18:41:47.754+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.764+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.764+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.774+0900 F/sio_packet(17775): accept()
07-09 18:41:47.774+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.774+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.774+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.774+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.774+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.794+0900 F/sio_packet(17775): accept()
07-09 18:41:47.804+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.804+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.804+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.804+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.824+0900 F/sio_packet(17775): accept()
07-09 18:41:47.824+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.824+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.824+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.834+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.834+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.844+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.844+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.844+0900 F/sio_packet(17775): accept()
07-09 18:41:47.844+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:47.854+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.854+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.854+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.854+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.864+0900 F/sio_packet(17775): accept()
07-09 18:41:47.864+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.864+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.874+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.874+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.884+0900 F/sio_packet(17775): accept()
07-09 18:41:47.884+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.884+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.894+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.894+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.904+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.904+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.904+0900 F/sio_packet(17775): accept()
07-09 18:41:47.914+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.914+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.914+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.914+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.924+0900 F/sio_packet(17775): accept()
07-09 18:41:47.924+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.924+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.934+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.934+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.944+0900 F/sio_packet(17775): accept()
07-09 18:41:47.944+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.944+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.954+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.954+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.954+0900 F/sio_packet(17775): accept()
07-09 18:41:47.954+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.964+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.964+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.964+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.974+0900 F/sio_packet(17775): accept()
07-09 18:41:47.974+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.984+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.984+0900 F/sio_packet(17775): accept()
07-09 18:41:47.984+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:47.984+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:47.984+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:47.994+0900 F/sio_packet(17775): accept()
07-09 18:41:47.994+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:47.994+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:48.004+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.004+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.004+0900 F/sio_packet(17775): accept()
07-09 18:41:48.004+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.014+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.014+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.014+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.014+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.024+0900 F/sio_packet(17775): accept()
07-09 18:41:48.024+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.024+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.034+0900 F/sio_packet(17775): accept()
07-09 18:41:48.034+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.034+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.044+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.044+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.054+0900 F/sio_packet(17775): accept()
07-09 18:41:48.054+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.054+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.054+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.064+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.064+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.064+0900 F/sio_packet(17775): accept()
07-09 18:41:48.064+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.074+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.074+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.074+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.084+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.084+0900 F/sio_packet(17775): accept()
07-09 18:41:48.084+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.084+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.094+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.094+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.104+0900 F/sio_packet(17775): accept()
07-09 18:41:48.104+0900 E/socket.io(17775): 743: encoded paylod length: 56
07-09 18:41:48.104+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.124+0900 F/sio_packet(17775): accept()
07-09 18:41:48.124+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.124+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.124+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.124+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.124+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.134+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.134+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.134+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.144+0900 F/sio_packet(17775): accept()
07-09 18:41:48.144+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.144+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.154+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.154+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.164+0900 F/sio_packet(17775): accept()
07-09 18:41:48.164+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.174+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.174+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.174+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.194+0900 F/sio_packet(17775): accept()
07-09 18:41:48.194+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.194+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.194+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.194+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.214+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.214+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.224+0900 F/sio_packet(17775): accept()
07-09 18:41:48.224+0900 E/socket.io(17775): 743: encoded paylod length: 57
07-09 18:41:48.224+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.234+0900 F/sio_packet(17775): accept()
07-09 18:41:48.234+0900 E/socket.io(17775): 743: encoded paylod length: 51
07-09 18:41:48.234+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.264+0900 F/sio_packet(17775): accept()
07-09 18:41:48.264+0900 E/socket.io(17775): 743: encoded paylod length: 21
07-09 18:41:48.264+0900 E/socket.io(17775): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:48.274+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.274+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.324+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.324+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.324+0900 E/socket.io(17775): 669: Received Message type(Event)
07-09 18:41:48.324+0900 F/get_binary(17775): in get binary_message()...
07-09 18:41:48.474+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-09 18:41:48.474+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-09 18:41:48.494+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 17775 pgid = 17775
07-09 18:41:48.494+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(17775)
07-09 18:41:48.494+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-09 18:41:48.494+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-09 18:41:48.504+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-09 18:41:48.514+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:41:48.514+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[17775] terminate event is forwarded
07-09 18:41:48.514+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-09 18:41:48.514+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 17775, ]
07-09 18:41:48.514+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-09 18:41:48.514+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-09 18:41:48.514+0900 I/Tizen::App( 1034): (512) > Not registered pid(17775)
07-09 18:41:48.514+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 17775.
07-09 18:41:48.524+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 17775
07-09 18:41:48.534+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:41:48.534+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 17775.
07-09 18:41:48.544+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-09 18:41:48.574+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:41:48.584+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-09 18:41:48.584+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-09 18:41:48.584+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-09 18:41:48.624+0900 W/CRASH_MANAGER(17849): worker.c: worker_job(1236) > 11177756e6f721436434908
07-09 18:41:48.634+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-09 18:41:48.634+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:41:48.674+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:41:50.934+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-09 18:41:52.414+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-09 18:41:52.414+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-09 18:41:52.414+0900 W/test-log(  606): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-09 18:41:52.754+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-09 18:41:52.834+0900 I/CAPI_APPFW_APPLICATION(17887): app_main.c: ui_app_main(699) > app_efl_main
07-09 18:41:52.864+0900 I/UXT     (17887): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-09 18:41:52.874+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 17887.
07-09 18:41:52.884+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 435
07-09 18:41:52.894+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-09 18:41:52.894+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 17887.
07-09 18:41:52.954+0900 I/CAPI_APPFW_APPLICATION(17887): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-09 18:41:53.184+0900 I/CAPI_APPFW_APPLICATION(17887): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-09 18:41:53.194+0900 I/APP_CORE(17887): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-09 18:41:53.194+0900 I/APP_CORE(17887): appcore-efl.c: __do_app(511) > [APP 17887] Initial Launching, call the resume_cb
07-09 18:41:53.194+0900 I/CAPI_APPFW_APPLICATION(17887): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-09 18:41:53.234+0900 W/APP_CORE(17887): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
07-09 18:41:53.234+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17887
07-09 18:41:53.274+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-09 18:41:53.284+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 17887"
07-09 18:41:53.294+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-09 18:41:53.354+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-09 18:41:53.354+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-09 18:41:53.364+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 18:41:53.364+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-09 18:41:53.374+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-09 18:41:55.724+0900 I/MALI    (17887): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d188f0] swap changed from async to sync
07-09 18:41:56.184+0900 I/nornenjs(17887): Timer expired after 3.001 seconds.
07-09 18:41:56.184+0900 E/EFL     (17887): ecore<17887> ecore.c:568 _ecore_magic_fail() 
07-09 18:41:56.184+0900 E/EFL     (17887): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-09 18:41:56.184+0900 E/EFL     (17887): *** IN FUNCTION: ecore_timer_delay()
07-09 18:41:56.184+0900 E/EFL     (17887): ecore<17887> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-09 18:41:56.184+0900 E/EFL     (17887): ecore<17887> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-09 18:41:56.184+0900 E/EFL     (17887): *** SPANK SPANK SPANK!!!
07-09 18:41:56.184+0900 E/EFL     (17887): *** Now go fix your code. Tut tut tut!
07-09 18:41:56.214+0900 E/EFL     (17887): evas_main<17887> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-09 18:41:56.224+0900 E/EFL     (17887): evas_main<17887> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-09 18:41:56.974+0900 E/socket.io(17887): 566: Connected.
07-09 18:41:56.984+0900 E/socket.io(17887): 554: On handshake, sid
07-09 18:41:56.984+0900 E/socket.io(17887): 651: Received Message type(connect)
07-09 18:41:56.984+0900 E/socket.io(17887): 489: On Connected
07-09 18:41:56.984+0900 F/sio_packet(17887): accept()
07-09 18:41:56.984+0900 E/socket.io(17887): 743: encoded paylod length: 41
07-09 18:41:56.994+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.074+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.074+0900 F/sio_packet(17887): accept()
07-09 18:41:57.074+0900 E/socket.io(17887): 743: encoded paylod length: 21
07-09 18:41:57.074+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.114+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.114+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.704+0900 F/sio_packet(17887): accept()
07-09 18:41:57.704+0900 E/socket.io(17887): 743: encoded paylod length: 74
07-09 18:41:57.704+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.744+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.744+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.744+0900 F/sio_packet(17887): accept()
07-09 18:41:57.744+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:57.744+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.764+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.764+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.774+0900 F/sio_packet(17887): accept()
07-09 18:41:57.774+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:57.774+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.794+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.794+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.804+0900 F/sio_packet(17887): accept()
07-09 18:41:57.804+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:57.814+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.824+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.824+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.844+0900 F/sio_packet(17887): accept()
07-09 18:41:57.844+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:57.844+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.864+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.864+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.874+0900 F/sio_packet(17887): accept()
07-09 18:41:57.874+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:57.874+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.894+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.894+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.904+0900 F/sio_packet(17887): accept()
07-09 18:41:57.904+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:57.904+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.924+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.924+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.934+0900 F/sio_packet(17887): accept()
07-09 18:41:57.934+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:57.934+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.954+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.954+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:57.974+0900 F/sio_packet(17887): accept()
07-09 18:41:57.974+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:57.974+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:57.994+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:57.994+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.004+0900 F/sio_packet(17887): accept()
07-09 18:41:58.004+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:58.004+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.024+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.024+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.034+0900 F/sio_packet(17887): accept()
07-09 18:41:58.034+0900 E/socket.io(17887): 743: encoded paylod length: 78
07-09 18:41:58.034+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.064+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.064+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.074+0900 F/sio_packet(17887): accept()
07-09 18:41:58.074+0900 E/socket.io(17887): 743: encoded paylod length: 77
07-09 18:41:58.074+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.094+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.094+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.094+0900 F/sio_packet(17887): accept()
07-09 18:41:58.094+0900 E/socket.io(17887): 743: encoded paylod length: 77
07-09 18:41:58.094+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.114+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.114+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.124+0900 F/sio_packet(17887): accept()
07-09 18:41:58.124+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:58.124+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.144+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.144+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.164+0900 F/sio_packet(17887): accept()
07-09 18:41:58.164+0900 E/socket.io(17887): 743: encoded paylod length: 75
07-09 18:41:58.164+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.184+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.184+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.194+0900 F/sio_packet(17887): accept()
07-09 18:41:58.194+0900 E/socket.io(17887): 743: encoded paylod length: 75
07-09 18:41:58.194+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.214+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.214+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.224+0900 F/sio_packet(17887): accept()
07-09 18:41:58.224+0900 E/socket.io(17887): 743: encoded paylod length: 79
07-09 18:41:58.234+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.254+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.254+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.274+0900 F/sio_packet(17887): accept()
07-09 18:41:58.274+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:58.274+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.294+0900 F/sio_packet(17887): accept()
07-09 18:41:58.294+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:58.294+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.294+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.294+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.304+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.304+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.324+0900 F/sio_packet(17887): accept()
07-09 18:41:58.324+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:58.324+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.344+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.344+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.354+0900 F/sio_packet(17887): accept()
07-09 18:41:58.354+0900 E/socket.io(17887): 743: encoded paylod length: 81
07-09 18:41:58.354+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.374+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.374+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.394+0900 F/sio_packet(17887): accept()
07-09 18:41:58.394+0900 E/socket.io(17887): 743: encoded paylod length: 76
07-09 18:41:58.394+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.424+0900 F/sio_packet(17887): accept()
07-09 18:41:58.424+0900 E/socket.io(17887): 743: encoded paylod length: 74
07-09 18:41:58.424+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.424+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.424+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.434+0900 F/sio_packet(17887): accept()
07-09 18:41:58.434+0900 E/socket.io(17887): 743: encoded paylod length: 21
07-09 18:41:58.444+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.444+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:58.464+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:58.504+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:58.504+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.664+0900 F/sio_packet(17887): accept()
07-09 18:41:59.664+0900 E/socket.io(17887): 743: encoded paylod length: 56
07-09 18:41:59.664+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.674+0900 F/sio_packet(17887): accept()
07-09 18:41:59.674+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.674+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.694+0900 F/sio_packet(17887): accept()
07-09 18:41:59.694+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.694+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.704+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.704+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.714+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.714+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.724+0900 F/sio_packet(17887): accept()
07-09 18:41:59.724+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.724+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.724+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.734+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.734+0900 F/sio_packet(17887): accept()
07-09 18:41:59.734+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.734+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.744+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.744+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.764+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.764+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.774+0900 F/sio_packet(17887): accept()
07-09 18:41:59.774+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.774+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.784+0900 F/sio_packet(17887): accept()
07-09 18:41:59.794+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.794+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.794+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.794+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.804+0900 F/sio_packet(17887): accept()
07-09 18:41:59.804+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.804+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.814+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.814+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.824+0900 F/sio_packet(17887): accept()
07-09 18:41:59.824+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.824+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.834+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.834+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.844+0900 F/sio_packet(17887): accept()
07-09 18:41:59.844+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.844+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.854+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.854+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.864+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.864+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.874+0900 F/sio_packet(17887): accept()
07-09 18:41:59.874+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.874+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.894+0900 F/sio_packet(17887): accept()
07-09 18:41:59.894+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.894+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.904+0900 E/socket.io(17887): 743: encoded paylod length: 56
07-09 18:41:59.904+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.914+0900 F/sio_packet(17887): accept()
07-09 18:41:59.914+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.914+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.924+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.924+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.934+0900 F/sio_packet(17887): accept()
07-09 18:41:59.934+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.934+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.944+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.944+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.954+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.954+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.964+0900 F/sio_packet(17887): accept()
07-09 18:41:59.964+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.964+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:41:59.974+0900 F/sio_packet(17887): accept()
07-09 18:41:59.984+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:41:59.984+0900 F/get_binary(17887): in get binary_message()...
07-09 18:41:59.994+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:41:59.994+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:42:00.004+0900 F/sio_packet(17887): accept()
07-09 18:42:00.004+0900 E/socket.io(17887): 743: encoded paylod length: 21
07-09 18:42:00.004+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:42:00.004+0900 F/sio_packet(17887): accept()
07-09 18:42:00.004+0900 E/socket.io(17887): 743: encoded paylod length: 57
07-09 18:42:00.004+0900 E/socket.io(17887): 800: ping exit, con is expired? 0, ec: Operation canceled
07-09 18:42:00.014+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:42:00.014+0900 F/get_binary(17887): in get binary_message()...
07-09 18:42:00.054+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:42:00.054+0900 F/get_binary(17887): in get binary_message()...
07-09 18:42:00.094+0900 E/socket.io(17887): 669: Received Message type(Event)
07-09 18:42:00.094+0900 F/get_binary(17887): in get binary_message()...
07-09 18:42:00.164+0900 W/CRASH_MANAGER(17849): worker.c: worker_job(1236) > 11178876e6f72143643492
