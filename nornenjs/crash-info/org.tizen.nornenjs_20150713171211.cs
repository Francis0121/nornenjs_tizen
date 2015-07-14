S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 25234
Date: 2015-07-13 17:12:11+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000008, r1   = 0x00000008
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb4db3299
r6   = 0xbef82780, r7   = 0x00000008
r8   = 0x00000008, r9   = 0xb65844d0
r10  = 0xb4db3290, fp   = 0xbef82774
ip   = 0x00000000, sp   = 0xbef82210
lr   = 0xb6ca65b8, pc   = 0xb6cd9d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    206060 KB
Buffers:     36976 KB
Cached:     162848 KB
VmPeak:      73096 KB
VmSize:      73092 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15232 KB
VmRSS:       15228 KB
VmData:      21540 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 25234 TID = 25234
25234 25237 25238 

Maps Information
b3a00000 b3a01000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a09000 b3a10000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a26000 b3a27000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a2f000 b3a31000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a39000 b3a3a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a42000 b3a59000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c00000 b3c04000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c0e000 b440d000 rw-p [stack:25237]
b440d000 b4554000 r-xp /usr/lib/driver/libMali.so
b4561000 b45b1000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b48e8000 b49b2000 r-xp /usr/lib/libCOREGL.so.4.0
b49c3000 b4b02000 r-xp /usr/lib/libicui18n.so.51.1
b4b12000 b4b17000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b20000 b4b21000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4b2a000 b4b42000 r-xp /usr/lib/libpng12.so.0.50.0
b4b4a000 b4b4d000 r-xp /usr/lib/libEGL.so.1.4
b4b55000 b4b63000 r-xp /usr/lib/libGLESv2.so.2.0
b4b6c000 b4b6e000 r-xp /usr/lib/libiniparser.so.0
b4b78000 b4b80000 r-xp /usr/lib/libui-extension.so.0.1.0
b4b81000 b4b84000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4b8c000 b4c42000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c4d000 b4c5f000 r-xp /usr/lib/libtts.so
b4c67000 b4c6e000 r-xp /usr/lib/libtbm.so.1.0.0
b4c76000 b4c7b000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c83000 b4c87000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c90000 b4c92000 r-xp /usr/lib/libdri2.so.0.0.0
b4c9a000 b4ca1000 r-xp /usr/lib/libdrm.so.2.4.0
b4caa000 b4cc0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4cc8000 b4cd0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4cd8000 b4cdd000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4ce5000 b4ce7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cef000 b4cf6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4cff000 b4d02000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4d0c000 b4d16000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d1f000 b4ddf000 r-xp /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
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
b6f91000 b6f94000 rw-p [stack:25238]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b7eca000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25234)
Call Stack Count: 17
 0: strlen + 0x4 (0xb6cd9d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6ca65b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6d3eb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f6e063) [/usr/lib/libdlog.so.0] + 0x1063
 4: create_main_list + 0x160 (0xb4d2b7a9) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc7a9
 5: main_page_timer_cb + 0x4a (0xb4d2b86f) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xc86f
 6: (0xb6be2d61) [/usr/lib/libecore.so.1] + 0xdd61
 7: (0xb6be2e57) [/usr/lib/libecore.so.1] + 0xde57
 8: (0xb6be010b) [/usr/lib/libecore.so.1] + 0xb10b
 9: ecore_main_loop_begin + 0x30 (0xb6be0691) [/usr/lib/libecore.so.1] + 0xb691
10: appcore_efl_main + 0x17e (0xb6f96387) [/usr/lib/libappcore-efl.so.1] + 0x2387
11: ui_app_main + 0xb0 (0xb657a499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
12: main + 0x146 (0xb4d2bdd3) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0xcdd3
13: (0xb6fd6dc7) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x2dc7
14: (0xb6fd5d8f) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x1d8f
15: __libc_start_main + 0x114 (0xb6c7e82c) [/lib/libc.so.6] + 0x1782c
16: (0xb6fd60d4) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x20d4
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
24+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 17:10:09.224+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 17:10:09.224+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 17:10:09.224+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 17:10:09.224+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 17:10:09.224+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 17:10:09.244+0900 E/PKGMGR_CERT(24296): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 17:10:09.244+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 17:10:09.714+0900 E/rpm-installer(24296): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 17:10:10.534+0900 E/PKGMGR_SERVER(24295): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 17:10:10.594+0900 E/PKGMGR_INFO(24296): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 17:10:10.594+0900 E/PKGMGR_INSTALLER(24296): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 17:10:10.604+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 17:10:10.604+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 17:10:10.604+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 17:10:10.604+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 17:10:10.624+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 17:10:10.634+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 17:10:10.654+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:10:10.654+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:10:10.654+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 17:10:10.654+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 17:10:10.654+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 17:10:10.674+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 17:10:10.684+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 17:10:10.684+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 17:10:10.684+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 17:10:10.684+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 17:10:10.694+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:10:10.694+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:10:10.704+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 17:10:10.704+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [1]
07-13 17:10:10.714+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:10:10.714+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:10:10.714+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 17:10:10.714+0900 I/Tizen::App( 1034): (131) > Enter
07-13 17:10:10.724+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 17:10:10.724+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 17:10:12.404+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 17:10:12.414+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 17:10:12.424+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 17:10:12.424+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 17:10:12.504+0900 I/CAPI_APPFW_APPLICATION(24370): app_main.c: ui_app_main(699) > app_efl_main
07-13 17:10:12.534+0900 E/PKGMGR_SERVER(24295): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 17:10:12.534+0900 E/PKGMGR_SERVER(24295): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 17:10:12.554+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 430
07-13 17:10:12.564+0900 I/UXT     (24370): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 17:10:12.604+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 17:10:12.634+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 24370.
07-13 17:10:12.634+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 24370.
07-13 17:10:12.664+0900 I/CAPI_APPFW_APPLICATION(24370): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 17:10:12.924+0900 I/CAPI_APPFW_APPLICATION(24370): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 17:10:12.944+0900 I/APP_CORE(24370): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 17:10:12.944+0900 I/APP_CORE(24370): appcore-efl.c: __do_app(511) > [APP 24370] Initial Launching, call the resume_cb
07-13 17:10:12.944+0900 I/CAPI_APPFW_APPLICATION(24370): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 17:10:12.974+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=24370
07-13 17:10:13.014+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:10:13.014+0900 W/APP_CORE(24370): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 17:10:13.034+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-13 17:10:13.044+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 24370"
07-13 17:10:13.094+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-13 17:10:13.104+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:10:13.114+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 17:10:13.114+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-13 17:10:13.114+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:10:13.144+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:10:13.144+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:10:15.474+0900 I/MALI    (24370): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-13 17:10:15.924+0900 I/nornenjs(24370): Timer expired after 3.001 seconds.
07-13 17:10:15.924+0900 E/EFL     (24370): ecore<24370> ecore.c:568 _ecore_magic_fail() 
07-13 17:10:15.924+0900 E/EFL     (24370): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 17:10:15.924+0900 E/EFL     (24370): *** IN FUNCTION: ecore_timer_delay()
07-13 17:10:15.924+0900 E/EFL     (24370): ecore<24370> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 17:10:15.924+0900 E/EFL     (24370): ecore<24370> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 17:10:15.924+0900 E/EFL     (24370): *** SPANK SPANK SPANK!!!
07-13 17:10:15.924+0900 E/EFL     (24370): *** Now go fix your code. Tut tut tut!
07-13 17:10:16.044+0900 E/EFL     (24370): evas_main<24370> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-13 17:10:16.064+0900 E/EFL     (24370): evas_main<24370> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-13 17:10:17.344+0900 E/socket.io(24370): 566: Connected.
07-13 17:10:17.344+0900 E/socket.io(24370): 554: On handshake, sid
07-13 17:10:17.344+0900 E/socket.io(24370): 651: Received Message type(connect)
07-13 17:10:17.344+0900 E/socket.io(24370): 489: On Connected
07-13 17:10:17.344+0900 F/sio_packet(24370): accept()
07-13 17:10:17.344+0900 E/socket.io(24370): 743: encoded paylod length: 41
07-13 17:10:17.344+0900 E/socket.io(24370): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 17:10:17.444+0900 E/socket.io(24370): 669: Received Message type(Event)
07-13 17:10:17.444+0900 F/sio_packet(24370): accept()
07-13 17:10:17.444+0900 E/socket.io(24370): 743: encoded paylod length: 21
07-13 17:10:17.454+0900 E/socket.io(24370): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 17:10:17.504+0900 E/socket.io(24370): 669: Received Message type(Event)
07-13 17:10:17.504+0900 F/get_binary(24370): in get binary_message()...
07-13 17:10:17.524+0900 I/nornenjs_queue(24370): Queue push
07-13 17:10:17.524+0900 I/nornenjs_queue(24370): Queue pop
07-13 17:10:18.434+0900 E/socket.io(24370): 849: Close by reason: End by user
07-13 17:10:18.434+0900 F/sio_packet(24370): accept()
07-13 17:10:18.434+0900 E/socket.io(24370): 867: __close paylod  1000
07-13 17:10:18.454+0900 E/socket.io(24370): 588: Client Disconnected.
07-13 17:10:18.454+0900 E/socket.io(24370): 602: Close code 1000
07-13 17:10:18.454+0900 E/socket.io(24370): clear timers
07-13 17:10:18.454+0900 E/socket.io(24370): 800: ping exit, con is expired? 1, ec: Operation canceled
07-13 17:10:18.644+0900 I/nornenjs_queue(24370): Output Image free
07-13 17:10:18.714+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:10:18.714+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:10:18.734+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:10:18.754+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-13 17:10:18.784+0900 I/MALI    (24370): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb7d187a8] swap changed from sync to async
07-13 17:10:18.794+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-13 17:10:18.864+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-13 17:10:18.874+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:10:18.874+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 17:10:18.874+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-13 17:10:18.884+0900 I/CAPI_APPFW_APPLICATION(24370): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
07-13 17:10:18.904+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:10:19.154+0900 I/RESOURCED(  768): logging.c: broadcast_logging_data_updated_signal(714) > [broadcast_logging_data_updated_signal,714] broadcast logging_data updated signal!
07-13 17:10:21.184+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-13 17:11:14.024+0900 E/PKGMGR_SERVER(24666): pkgmgr-server.c: main(1608) > server start
07-13 17:11:14.134+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24370 pgid = 24370
07-13 17:11:14.134+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(24370)
07-13 17:11:14.134+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 17:11:14.134+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 17:11:14.164+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 17:11:14.164+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[24370] terminate event is forwarded
07-13 17:11:14.164+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 17:11:14.164+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 24370, ]
07-13 17:11:14.164+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 17:11:14.164+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 17:11:14.164+0900 I/Tizen::App( 1034): (512) > Not registered pid(24370)
07-13 17:11:14.164+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 24370.
07-13 17:11:14.164+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:11:14.174+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24370
07-13 17:11:14.174+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:11:14.174+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 24370.
07-13 17:11:16.534+0900 E/PKGMGR_SERVER(24666): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 17:11:16.534+0900 E/PKGMGR_SERVER(24666): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 17:11:18.954+0900 E/PKGMGR_SERVER(24770): pkgmgr-server.c: main(1608) > server start
07-13 17:11:19.004+0900 E/PKGMGR  (24770): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-13 17:11:19.004+0900 E/PKGMGR_SERVER(24770): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-13 17:11:19.004+0900 E/PKGMGR_SERVER(24770): [0;m
07-13 17:11:19.184+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-13 17:11:19.184+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-13 17:11:19.194+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-13 17:11:19.314+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-13 17:11:19.314+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-13 17:11:19.314+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 17:11:21.504+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-13 17:11:21.504+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-13 17:11:21.504+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 17:11:21.504+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 17:11:21.524+0900 E/PKGMGR_CERT(24774): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 17:11:21.524+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 17:11:21.534+0900 E/PKGMGR_SERVER(24770): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 17:11:21.974+0900 E/rpm-installer(24774): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 17:11:22.854+0900 E/PKGMGR_INFO(24774): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 17:11:22.854+0900 E/PKGMGR_INSTALLER(24774): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 17:11:22.864+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 17:11:22.864+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 17:11:22.864+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 17:11:22.864+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 17:11:22.904+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 17:11:22.904+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 17:11:22.904+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 17:11:22.904+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 17:11:22.904+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 17:11:22.914+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 17:11:22.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:11:22.924+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:11:22.954+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 17:11:22.964+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:11:22.964+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:11:22.964+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 17:11:22.964+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 17:11:22.964+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 17:11:22.974+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 17:11:22.974+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [1]
07-13 17:11:22.974+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:11:22.984+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:11:22.984+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 17:11:22.984+0900 I/Tizen::App( 1034): (131) > Enter
07-13 17:11:22.984+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 17:11:22.984+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 17:11:23.534+0900 E/PKGMGR_SERVER(24770): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 17:11:23.534+0900 E/PKGMGR_SERVER(24770): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 17:11:24.434+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 17:11:24.444+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 17:11:24.454+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 17:11:24.454+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 17:11:24.534+0900 I/CAPI_APPFW_APPLICATION(24847): app_main.c: ui_app_main(699) > app_efl_main
07-13 17:11:24.574+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 430
07-13 17:11:24.574+0900 I/UXT     (24847): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 17:11:24.604+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 24847.
07-13 17:11:24.624+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 17:11:24.624+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 24847.
07-13 17:11:24.644+0900 I/CAPI_APPFW_APPLICATION(24847): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 17:11:24.914+0900 I/CAPI_APPFW_APPLICATION(24847): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 17:11:24.924+0900 I/APP_CORE(24847): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 17:11:24.924+0900 I/APP_CORE(24847): appcore-efl.c: __do_app(511) > [APP 24847] Initial Launching, call the resume_cb
07-13 17:11:24.924+0900 I/CAPI_APPFW_APPLICATION(24847): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 17:11:24.964+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=24847
07-13 17:11:24.964+0900 W/APP_CORE(24847): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 17:11:25.004+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:11:25.024+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 24847"
07-13 17:11:25.024+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-13 17:11:25.104+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-13 17:11:25.104+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:11:25.104+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 17:11:25.104+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-13 17:11:25.164+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:11:25.164+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:11:25.174+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:11:27.484+0900 I/MALI    (24847): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-13 17:11:27.914+0900 I/nornenjs(24847): Timer expired after 3.001 seconds.
07-13 17:11:27.914+0900 E/EFL     (24847): ecore<24847> ecore.c:568 _ecore_magic_fail() 
07-13 17:11:27.914+0900 E/EFL     (24847): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 17:11:27.914+0900 E/EFL     (24847): *** IN FUNCTION: ecore_timer_delay()
07-13 17:11:27.914+0900 E/EFL     (24847): ecore<24847> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 17:11:27.914+0900 E/EFL     (24847): ecore<24847> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 17:11:27.914+0900 E/EFL     (24847): *** SPANK SPANK SPANK!!!
07-13 17:11:27.914+0900 E/EFL     (24847): *** Now go fix your code. Tut tut tut!
07-13 17:11:28.384+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24847 pgid = 24847
07-13 17:11:28.384+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(24847)
07-13 17:11:28.384+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 17:11:28.384+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 17:11:28.394+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:11:28.394+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:11:28.404+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 17:11:28.404+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:11:28.404+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[24847] terminate event is forwarded
07-13 17:11:28.404+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 17:11:28.404+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 24847, ]
07-13 17:11:28.404+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 17:11:28.404+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 17:11:28.404+0900 I/Tizen::App( 1034): (512) > Not registered pid(24847)
07-13 17:11:28.404+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 24847.
07-13 17:11:28.424+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24847
07-13 17:11:28.424+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:11:28.424+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 24847.
07-13 17:11:28.474+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-13 17:11:28.494+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 17:11:28.494+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-13 17:11:28.514+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-13 17:11:28.514+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:11:28.544+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:11:28.564+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-13 17:11:28.574+0900 W/CRASH_MANAGER(24867): worker.c: worker_job(1236) > 11248476e6f721436775088
07-13 17:11:28.594+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:11:30.854+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-13 17:11:56.574+0900 E/PKGMGR_SERVER(25049): pkgmgr-server.c: main(1608) > server start
07-13 17:11:58.534+0900 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 17:11:58.534+0900 E/PKGMGR_SERVER(25049): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 17:12:02.164+0900 E/PKGMGR_SERVER(25159): pkgmgr-server.c: main(1608) > server start
07-13 17:12:02.224+0900 E/PKGMGR  (25159): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-13 17:12:02.224+0900 E/PKGMGR_SERVER(25159): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-13 17:12:02.224+0900 E/PKGMGR_SERVER(25159): [0;m
07-13 17:12:02.394+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-13 17:12:02.394+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [1]
07-13 17:12:02.414+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-13 17:12:02.524+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-13 17:12:02.524+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-13 17:12:02.524+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [1]
07-13 17:12:04.534+0900 E/PKGMGR_SERVER(25159): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 17:12:04.744+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-13 17:12:04.744+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-13 17:12:04.744+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [1]
07-13 17:12:04.744+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 17:12:04.754+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 17:12:04.774+0900 E/PKGMGR_CERT(25160): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 17:12:04.774+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 17:12:05.254+0900 E/rpm-installer(25160): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 17:12:06.124+0900 E/PKGMGR_INFO(25160): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 17:12:06.124+0900 E/PKGMGR_INSTALLER(25160): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [1]
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 17:12:06.124+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 17:12:06.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 17:12:06.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 17:12:06.134+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 17:12:06.134+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 17:12:06.204+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 17:12:06.204+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 17:12:06.204+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 17:12:06.204+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 17:12:06.204+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 17:12:06.214+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 17:12:06.224+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:12:06.224+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:12:06.224+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:12:06.224+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 17:12:06.224+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 17:12:06.224+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 17:12:06.224+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 17:12:06.234+0900 I/Tizen::App( 1034): (131) > Enter
07-13 17:12:06.244+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 17:12:06.244+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 17:12:06.534+0900 E/PKGMGR_SERVER(25159): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 17:12:06.534+0900 E/PKGMGR_SERVER(25159): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 17:12:07.784+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 17:12:07.794+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 17:12:07.804+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 17:12:07.804+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 17:12:07.884+0900 I/CAPI_APPFW_APPLICATION(25234): app_main.c: ui_app_main(699) > app_efl_main
07-13 17:12:07.924+0900 I/UXT     (25234): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 17:12:07.934+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 429
07-13 17:12:07.964+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 17:12:07.964+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 25234.
07-13 17:12:07.964+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 25234.
07-13 17:12:08.004+0900 I/CAPI_APPFW_APPLICATION(25234): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 17:12:08.274+0900 I/CAPI_APPFW_APPLICATION(25234): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 17:12:08.284+0900 I/APP_CORE(25234): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 17:12:08.284+0900 I/APP_CORE(25234): appcore-efl.c: __do_app(511) > [APP 25234] Initial Launching, call the resume_cb
07-13 17:12:08.284+0900 I/CAPI_APPFW_APPLICATION(25234): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 17:12:08.284+0900 W/APP_CORE(25234): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 17:12:08.324+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=25234
07-13 17:12:08.374+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:12:08.394+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 25234"
07-13 17:12:08.414+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-13 17:12:08.414+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-13 17:12:08.414+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:12:08.424+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:12:08.454+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 17:12:08.464+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-13 17:12:08.504+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:12:08.504+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:12:10.814+0900 I/MALI    (25234): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-13 17:12:11.274+0900 I/nornenjs(25234): Timer expired after 3.001 seconds.
07-13 17:12:11.274+0900 E/EFL     (25234): ecore<25234> ecore.c:568 _ecore_magic_fail() 
07-13 17:12:11.274+0900 E/EFL     (25234): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 17:12:11.274+0900 E/EFL     (25234): *** IN FUNCTION: ecore_timer_delay()
07-13 17:12:11.274+0900 E/EFL     (25234): ecore<25234> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 17:12:11.274+0900 E/EFL     (25234): ecore<25234> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 17:12:11.274+0900 E/EFL     (25234): *** SPANK SPANK SPANK!!!
07-13 17:12:11.274+0900 E/EFL     (25234): *** Now go fix your code. Tut tut tut!
07-13 17:12:11.684+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 25234 pgid = 25234
07-13 17:12:11.684+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(25234)
07-13 17:12:11.684+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 17:12:11.684+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 17:12:11.694+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 17:12:11.694+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:12:11.694+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[25234] terminate event is forwarded
07-13 17:12:11.694+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 17:12:11.694+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 25234, ]
07-13 17:12:11.694+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 17:12:11.694+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 17:12:11.694+0900 I/Tizen::App( 1034): (512) > Not registered pid(25234)
07-13 17:12:11.694+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 25234.
07-13 17:12:11.694+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 25234
07-13 17:12:11.704+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:12:11.704+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 25234.
07-13 17:12:11.734+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 17:12:11.734+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 17:12:11.754+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 17:12:11.774+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 606"
07-13 17:12:11.794+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-13 17:12:11.824+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 17:12:11.824+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-13 17:12:11.864+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-13 17:12:11.864+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 17:12:11.874+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 17:12:14.194+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb06357f8] swap changed from async to sync
07-13 17:12:28.654+0900 W/CRASH_MANAGER(25321): worker.c: worker_job(1236) > 11252346e6f72143677513
