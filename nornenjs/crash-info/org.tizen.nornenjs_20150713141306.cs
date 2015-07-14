S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: nornenjs
PID: 31480
Date: 2015-07-13 14:13:06+0900
Executable File Path: /opt/usr/apps/org.tizen.nornenjs/bin/nornenjs
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xfbad2878

Register Information
r0   = 0x3ffffffc, r1   = 0xb2517758
r2   = 0x00000011, r3   = 0xfbad2884
r4   = 0xb6d8c5d8, r5   = 0xb5b2f000
r6   = 0xb2517758, r7   = 0xb36c87f0
r8   = 0xb2517758, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb36c8904
ip   = 0xb4de7ebc, sp   = 0xb36c87d0
lr   = 0xb4d2acd3, pc   = 0xb5b0202a
cpsr = 0xa0000030

Memory Information
MemTotal:   730748 KB
MemFree:    205940 KB
Buffers:     36956 KB
Cached:     160292 KB
VmPeak:      93032 KB
VmSize:      93028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20024 KB
VmRSS:       20024 KB
VmData:      41096 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26004 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 31480 TID = 31543
31480 31481 31482 31543 31544 31545 

Maps Information
b1d01000 b2500000 rw-p [stack:31545]
b26cb000 b2eca000 rw-p [stack:31544]
b2ecb000 b36ca000 rw-p [stack:31543]
b3a02000 b3a03000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a0b000 b3a12000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a28000 b3a29000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3a31000 b3a33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3a3b000 b3a3c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3a44000 b3a5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3c02000 b3c06000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3c10000 b440f000 rw-p [stack:31481]
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
b6f91000 b6f94000 rw-p [stack:31482]
b6f94000 b6f97000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fa1000 b6fa5000 r-xp /usr/lib/libsys-assert.so
b6fae000 b6fcb000 r-xp /lib/ld-2.13.so
b6fd4000 b6fd9000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7c5a000 b7c84000 rw-p [heap]
b7c84000 b801e000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
b7c84000 b801e000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31480)
Call Stack Count: 9
 0: std::basic_string<char, std::char_traits<char>, std::allocator<char> >::append(char const*, unsigned int) + 0x1d (0xb5b0202a) [/usr/lib/libstdc++.so.6] + 0x7202a
 1: writer(char*, unsigned int, unsigned int, std::basic_string<char, std::char_traits<char>, std::allocator<char> >*) + 0x26 (0xb4d2acd3) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9cd3
 2: (0xb5dfc637) [/usr/lib/libcurl.so.4] + 0xf637
 3: (0xb5dfb54f) [/usr/lib/libcurl.so.4] + 0xe54f
 4: (0xb5e0b83f) [/usr/lib/libcurl.so.4] + 0x1e83f
 5: (0xb5e0c983) [/usr/lib/libcurl.so.4] + 0x1f983
 6: curl_test() + 0x130 (0xb4d2ae29) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x9e29
 7: socket_io_client + 0x3b4 (0xb4daf48d) [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs] + 0x8e48d
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
E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 13:56:45.834+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-13 13:56:45.834+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-13 13:56:45.834+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [96]
07-13 13:56:45.834+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 13:56:45.834+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 13:56:45.834+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 13:56:45.844+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 13:56:45.844+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 13:56:45.854+0900 E/PKGMGR_CERT(28205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 13:56:45.864+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 13:56:46.334+0900 E/rpm-installer(28205): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 13:56:47.214+0900 E/PKGMGR_INFO(28205): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 13:56:47.214+0900 E/PKGMGR_INSTALLER(28205): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [96]
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 13:56:47.214+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 13:56:47.224+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 13:56:47.224+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 13:56:47.224+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 13:56:47.254+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 13:56:47.294+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 13:56:47.294+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 13:56:47.294+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 13:56:47.294+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 13:56:47.294+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 13:56:47.304+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 13:56:47.304+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 13:56:47.314+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 13:56:47.314+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 13:56:47.314+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 13:56:47.314+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 13:56:47.314+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 13:56:47.314+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 13:56:47.324+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 13:56:47.324+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-13 13:56:47.324+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 13:56:47.324+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 13:56:47.324+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 13:56:47.334+0900 I/Tizen::App( 1034): (131) > Enter
07-13 13:56:47.334+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 13:56:47.334+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 13:56:47.534+0900 E/PKGMGR_SERVER(28204): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 13:56:47.534+0900 E/PKGMGR_SERVER(28204): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 13:56:49.314+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 13:56:49.324+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 13:56:49.334+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 13:56:49.334+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 13:56:49.414+0900 I/CAPI_APPFW_APPLICATION(28279): app_main.c: ui_app_main(699) > app_efl_main
07-13 13:56:49.464+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 431
07-13 13:56:49.494+0900 I/UXT     (28279): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 13:56:49.544+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 28279.
07-13 13:56:49.544+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 13:56:49.544+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 28279.
07-13 13:56:49.554+0900 I/CAPI_APPFW_APPLICATION(28279): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 13:56:49.814+0900 I/CAPI_APPFW_APPLICATION(28279): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 13:56:49.824+0900 I/APP_CORE(28279): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 13:56:49.824+0900 I/APP_CORE(28279): appcore-efl.c: __do_app(511) > [APP 28279] Initial Launching, call the resume_cb
07-13 13:56:49.834+0900 I/CAPI_APPFW_APPLICATION(28279): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 13:56:49.864+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=28279
07-13 13:56:49.904+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 13:56:49.914+0900 W/APP_CORE(28279): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 13:56:49.934+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 28279"
07-13 13:56:49.954+0900 I/MALI    (  606): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb06357f8] swap changed from sync to async
07-13 13:56:49.984+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-13 13:56:49.984+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 13:56:49.994+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 13:56:50.024+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 13:56:50.024+0900 E/cluster-home(  606): homescreen-main.cpp: app_pause(355) >  app pause
07-13 13:56:50.074+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 13:56:50.074+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 13:56:52.394+0900 I/MALI    (28279): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d187a8] swap changed from async to sync
07-13 13:56:52.814+0900 I/nornenjs(28279): Timer expired after 3.001 seconds.
07-13 13:56:52.814+0900 E/EFL     (28279): ecore<28279> ecore.c:568 _ecore_magic_fail() 
07-13 13:56:52.814+0900 E/EFL     (28279): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 13:56:52.814+0900 E/EFL     (28279): *** IN FUNCTION: ecore_timer_delay()
07-13 13:56:52.814+0900 E/EFL     (28279): ecore<28279> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 13:56:52.814+0900 E/EFL     (28279): ecore<28279> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 13:56:52.814+0900 E/EFL     (28279): *** SPANK SPANK SPANK!!!
07-13 13:56:52.814+0900 E/EFL     (28279): *** Now go fix your code. Tut tut tut!
07-13 13:56:52.854+0900 E/EFL     (28279): evas_main<28279> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-13 13:56:52.874+0900 E/EFL     (28279): evas_main<28279> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-13 13:56:59.984+0900 E/socket.io(28279): 566: Connected.
07-13 13:56:59.984+0900 E/socket.io(28279): 554: On handshake, sid
07-13 13:56:59.984+0900 E/socket.io(28279): 651: Received Message type(connect)
07-13 13:56:59.984+0900 E/socket.io(28279): 489: On Connected
07-13 13:56:59.984+0900 F/sio_packet(28279): accept()
07-13 13:56:59.984+0900 E/socket.io(28279): 743: encoded paylod length: 41
07-13 13:56:59.994+0900 E/socket.io(28279): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 13:57:00.104+0900 E/socket.io(28279): 669: Received Message type(Event)
07-13 13:57:00.104+0900 F/sio_packet(28279): accept()
07-13 13:57:00.104+0900 E/socket.io(28279): 743: encoded paylod length: 21
07-13 13:57:00.104+0900 E/socket.io(28279): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 13:57:00.154+0900 E/socket.io(28279): 669: Received Message type(Event)
07-13 13:57:00.154+0900 F/get_binary(28279): in get binary_message()...
07-13 13:57:00.164+0900 I/nornenjs_queue(28279): Queue push
07-13 13:57:00.174+0900 I/nornenjs_queue(28279): Queue pop
07-13 13:57:25.104+0900 F/sio_packet(28279): accept()
07-13 13:57:50.104+0900 F/sio_packet(28279): accept()
07-13 13:58:15.104+0900 F/sio_packet(28279): accept()
07-13 13:58:40.104+0900 F/sio_packet(28279): accept()
07-13 13:59:05.104+0900 F/sio_packet(28279): accept()
07-13 13:59:30.104+0900 F/sio_packet(28279): accept()
07-13 13:59:55.104+0900 F/sio_packet(28279): accept()
07-13 14:00:20.104+0900 F/sio_packet(28279): accept()
07-13 14:00:45.104+0900 F/sio_packet(28279): accept()
07-13 14:01:10.104+0900 F/sio_packet(28279): accept()
07-13 14:01:35.114+0900 F/sio_packet(28279): accept()
07-13 14:02:00.114+0900 F/sio_packet(28279): accept()
07-13 14:02:25.114+0900 F/sio_packet(28279): accept()
07-13 14:02:50.114+0900 F/sio_packet(28279): accept()
07-13 14:03:15.114+0900 F/sio_packet(28279): accept()
07-13 14:03:40.114+0900 F/sio_packet(28279): accept()
07-13 14:04:05.114+0900 F/sio_packet(28279): accept()
07-13 14:04:30.114+0900 F/sio_packet(28279): accept()
07-13 14:04:55.114+0900 F/sio_packet(28279): accept()
07-13 14:05:20.114+0900 F/sio_packet(28279): accept()
07-13 14:05:45.114+0900 F/sio_packet(28279): accept()
07-13 14:06:10.114+0900 F/sio_packet(28279): accept()
07-13 14:06:35.114+0900 F/sio_packet(28279): accept()
07-13 14:06:52.804+0900 W/CAM_APP (21008): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): dbus.c: _dbus_message_recv_cb(141) > [_dbus_message_recv_cb:141:W] LCD off
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): event.c: _lcd_off_cb(61) > [_lcd_off_cb:61:W] Dbus LCD off:timeout
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30000:LCD_WILL_OFF
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:30000 event_info:1b58820
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-13 14:06:59.874+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] HIDE => WILL RESUME
07-13 14:06:59.874+0900 E/LOCKSCREEN(  575): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 14:06:59.964+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:0:LKD_EVT_WILL_LOCK
07-13 14:06:59.964+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:0 event_info:0
07-13 14:06:59.964+0900 W/LOCKSCREEN(  575): view-mgr.c: _event_route(108) > [_event_route:108:W] event:0 event_info:0
07-13 14:07:00.124+0900 F/sio_packet(28279): accept()
07-13 14:07:00.504+0900 E/VOLUME  (  595): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-13 14:07:00.504+0900 E/VOLUME  (  595): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-13 14:07:00.514+0900 W/CAM_APP (21008): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 14:07:00.524+0900 E/VOLUME  (  595): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): event.c: _lcd_off_source_cb(47) > [_lcd_off_source_cb:47:W] Vconf LCD off
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30002:LCD_OFF
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:30002 event_info:0
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:5
07-13 14:07:00.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-13 14:07:00.574+0900 E/WALLPAPER_SERVICE_COMMON(  575): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 14:07:00.584+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=575
07-13 14:07:00.614+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:07:00.614+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 14:07:00.664+0900 I/MALI    (28279): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb7d187a8] swap changed from sync to async
07-13 14:07:00.684+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-13 14:07:00.684+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-13 14:07:00.684+0900 W/LOCKSCREEN(  575): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-13 14:07:00.714+0900 I/CAPI_APPFW_APPLICATION(28279): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
07-13 14:07:00.714+0900 W/LOCKSCREEN(  575): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1200008] is now visible(0)
07-13 14:07:00.724+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-13 14:07:00.724+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-13 14:07:00.724+0900 I/CAPI_APPFW_APPLICATION(  575): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 14:07:00.724+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-13 14:07:00.724+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-13 14:07:00.754+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-13 14:07:00.764+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:07:00.784+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:07:00.814+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 14:07:00.824+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 575"
07-13 14:07:01.074+0900 W/LOCKSCREEN(  575): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-13 14:07:25.114+0900 F/sio_packet(28279): accept()
07-13 14:07:50.114+0900 F/sio_packet(28279): accept()
07-13 14:08:15.114+0900 F/sio_packet(28279): accept()
07-13 14:08:40.114+0900 F/sio_packet(28279): accept()
07-13 14:09:05.124+0900 F/sio_packet(28279): accept()
07-13 14:09:30.124+0900 F/sio_packet(28279): accept()
07-13 14:09:55.124+0900 F/sio_packet(28279): accept()
07-13 14:10:20.124+0900 F/sio_packet(28279): accept()
07-13 14:10:45.124+0900 F/sio_packet(28279): accept()
07-13 14:11:10.124+0900 F/sio_packet(28279): accept()
07-13 14:11:35.124+0900 F/sio_packet(28279): accept()
07-13 14:12:00.124+0900 F/sio_packet(28279): accept()
07-13 14:12:25.124+0900 F/sio_packet(28279): accept()
07-13 14:12:43.794+0900 E/PKGMGR_SERVER(31292): pkgmgr-server.c: main(1608) > server start
07-13 14:12:43.964+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:12:43.964+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 14:12:43.974+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 28279 pgid = 28279
07-13 14:12:43.974+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(28279)
07-13 14:12:43.974+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 14:12:43.974+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 14:12:43.994+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 14:12:43.994+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:12:43.994+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[28279] terminate event is forwarded
07-13 14:12:43.994+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 14:12:43.994+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 28279, ]
07-13 14:12:43.994+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 14:12:43.994+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 14:12:43.994+0900 I/Tizen::App( 1034): (512) > Not registered pid(28279)
07-13 14:12:43.994+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 28279.
07-13 14:12:44.014+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:12:44.014+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 28279.
07-13 14:12:44.014+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 28279
07-13 14:12:46.534+0900 E/PKGMGR_SERVER(31292): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 14:12:46.534+0900 E/PKGMGR_SERVER(31292): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 14:12:48.784+0900 E/PKGMGR_SERVER(31401): pkgmgr-server.c: main(1608) > server start
07-13 14:12:48.834+0900 E/PKGMGR  (31401): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.nornenjs]
07-13 14:12:48.834+0900 E/PKGMGR_SERVER(31401): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.nornenjs 
07-13 14:12:48.834+0900 E/PKGMGR_SERVER(31401): [0;m
07-13 14:12:49.014+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: start, val: update
07-13 14:12:49.014+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [start], Value = [update], install = [96]
07-13 14:12:49.034+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-13 14:12:49.144+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 30
07-13 14:12:49.144+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [30]
07-13 14:12:49.144+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [30], install = [96]
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 14:12:51.294+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 60
07-13 14:12:51.294+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [60]
07-13 14:12:51.294+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [60], install = [96]
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 93
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 93
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 5
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 5
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 5
07-13 14:12:51.294+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 24 5
07-13 14:12:51.324+0900 E/PKGMGR_CERT(31402): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.nornenjs/shared], errno=[2][No such file or directory]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.nornenjs/shared/data]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.nornenjs/shared/res]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/tizen-manifest.xml]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/author-signature.xml]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.nornenjs/signature1.xml]
07-13 14:12:51.334+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.nornenjs.xml]
07-13 14:12:51.534+0900 E/PKGMGR_SERVER(31401): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 14:12:51.794+0900 E/rpm-installer(31402): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.nornenjs/shared/data]))
07-13 14:12:52.664+0900 E/PKGMGR_INFO(31402): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 14:12:52.664+0900 E/PKGMGR_INSTALLER(31402): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 14:12:52.664+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 14:12:52.664+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 14:12:52.664+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: install_percent, val: 100
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (119) > InstallationInProgress [100]
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [install_percent], Value = [100], install = [96]
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.nornenjs, key: end, val: ok
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (78) > Installation is Completed. [Package = org.tizen.nornenjs]
07-13 14:12:52.704+0900 I/Tizen::App( 1034): (663) > Enter. package(org.tizen.nornenjs), installationResult(0)
07-13 14:12:52.714+0900 I/Tizen::App( 1034): (1360) > package(org.tizen.nornenjs), version(1.0.0), type(rpm), displayName(Nornenjs), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.nornenjs), storeClient(), appRootPath(/opt/usr/apps/org.tizen.nornenjs)
07-13 14:12:52.724+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.nornenjs]
07-13 14:12:52.724+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.nornenjs]
07-13 14:12:52.724+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 14:12:52.724+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
07-13 14:12:52.724+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.nornenjs]
07-13 14:12:52.744+0900 I/Tizen::App( 1034): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.nornenjs]
07-13 14:12:52.744+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 14:12:52.754+0900 E/cluster-home(  606): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.nornenjs] Name[Nornenjs] Icon[/opt/usr/apps/org.tizen.nornenjs/shared/res/favicon.png] enable[1] system[0]
07-13 14:12:52.764+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 14:12:52.774+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 14:12:52.774+0900 E/PKGMGR_INFO( 1034): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 14:12:52.774+0900 I/Tizen::App( 1034): (675) > Application count(1) in this package
07-13 14:12:52.774+0900 I/Tizen::App( 1034): (855) > Enter.
07-13 14:12:52.774+0900 I/Tizen::App( 1034): (695) > Exit.
07-13 14:12:52.774+0900 I/Tizen::App( 1034): (1584) > Package = [org.tizen.nornenjs], Key = [end], Value = [ok], install = [96]
07-13 14:12:52.784+0900 I/Tizen::App( 1034): (416) > appName = [nornenjs]
07-13 14:12:52.784+0900 I/Tizen::App( 1034): (509) > exe = [/opt/usr/apps/org.tizen.nornenjs/bin/nornenjs], displayName = [Nornenjs], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
07-13 14:12:52.784+0900 I/Tizen::App( 1034): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.nornenjs.info]
07-13 14:12:52.784+0900 I/Tizen::App( 1034): (131) > Enter
07-13 14:12:52.794+0900 I/Tizen::App( 1034): (137) > org.tizen.nornenjs does not have launch condition
07-13 14:12:52.794+0900 I/Tizen::App( 1034): (898) > Exit.
07-13 14:12:53.534+0900 E/PKGMGR_SERVER(31401): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 14:12:53.534+0900 E/PKGMGR_SERVER(31401): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 14:12:54.514+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 14:12:54.524+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 14:12:54.534+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 14:12:54.534+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 14:12:54.624+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: ui_app_main(699) > app_efl_main
07-13 14:12:54.664+0900 I/UXT     (31480): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-13 14:12:54.674+0900 E/RESOURCED(  768): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 430
07-13 14:12:54.714+0900 I/Tizen::App( 1034): (499) > LaunchedApp(org.tizen.nornenjs)
07-13 14:12:54.714+0900 I/Tizen::App( 1047): (733) > Finished invoking application event listener for org.tizen.nornenjs, 31480.
07-13 14:12:54.714+0900 I/Tizen::App( 1034): (733) > Finished invoking application event listener for org.tizen.nornenjs, 31480.
07-13 14:12:54.734+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-13 14:12:55.004+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-13 14:12:55.014+0900 I/APP_CORE(31480): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-13 14:12:55.014+0900 I/APP_CORE(31480): appcore-efl.c: __do_app(511) > [APP 31480] Initial Launching, call the resume_cb
07-13 14:12:55.014+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 14:12:55.044+0900 W/APP_CORE(31480): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-13 14:12:55.114+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
07-13 14:12:55.654+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:12:55.654+0900 W/AUL_AMD (  452): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-13 14:12:58.004+0900 I/nornenjs(31480): Timer expired after 3.001 seconds.
07-13 14:12:58.004+0900 E/EFL     (31480): ecore<31480> ecore.c:568 _ecore_magic_fail() 
07-13 14:12:58.004+0900 E/EFL     (31480): *** ECORE ERROR: Ecore Magic Check Failed!!!
07-13 14:12:58.004+0900 E/EFL     (31480): *** IN FUNCTION: ecore_timer_delay()
07-13 14:12:58.004+0900 E/EFL     (31480): ecore<31480> ecore.c:570 _ecore_magic_fail()   Input handle pointer is NULL!
07-13 14:12:58.004+0900 E/EFL     (31480): ecore<31480> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
07-13 14:12:58.004+0900 E/EFL     (31480): *** SPANK SPANK SPANK!!!
07-13 14:12:58.004+0900 E/EFL     (31480): *** Now go fix your code. Tut tut tut!
07-13 14:12:58.034+0900 E/EFL     (31480): evas_main<31480> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-13 14:12:58.054+0900 E/EFL     (31480): evas_main<31480> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-13 14:13:03.654+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-13 14:13:03.664+0900 E/LOCKSCREEN(  575): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 14:13:03.674+0900 I/indicator(  492): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-13 14:13:03.684+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-13 14:13:03.694+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-13 14:13:03.694+0900 W/LOCKSCREEN(  575): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 74 359 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 78 387 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 47 595 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 67 623 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-13 14:13:03.794+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 74 679 5 28 25"
07-13 14:13:03.804+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 78 707 5 28 25"
07-13 14:13:03.804+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 14:13:03.804+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 14:13:03.804+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 74 359 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 78 387 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 47 595 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 67 623 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 74 679 5 28 25"
07-13 14:13:03.814+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 78 707 5 28 25"
07-13 14:13:04.324+0900 W/CAM_APP (21008): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 14:13:04.324+0900 I/Tizen::System( 1047): (280) > The screen has been turned on.
07-13 14:13:04.324+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:13:04.334+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:13:05.064+0900 E/LOCKSCREEN(  575): progress_circle.c: unlock_mouse_up(285) > 
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-13 14:13:05.064+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-13 14:13:05.564+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-13 14:13:05.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-13 14:13:05.564+0900 W/LOCKSCREEN(  575): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-13 14:13:05.574+0900 E/WALLPAPER_SERVICE_COMMON(  575): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 14:13:05.574+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=31480
07-13 14:13:05.604+0900 I/CAPI_APPFW_APPLICATION(31480): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-13 14:13:05.654+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:13:05.654+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 14:13:05.664+0900 I/Tizen::System( 1047): (259) > Active app [org.tizen.], current [com.samsun] 
07-13 14:13:05.674+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:13:05.674+0900 W/LOCKSCREEN(  575): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1200008] is now visible(1)
07-13 14:13:05.674+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-13 14:13:05.674+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-13 14:13:05.674+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:13:05.674+0900 I/CAPI_APPFW_APPLICATION(  575): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 14:13:05.674+0900 E/LOCKSCREEN(  575): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 14:13:05.674+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-13 14:13:05.674+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-13 14:13:05.734+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 14:13:05.764+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.nornenjs, pid = 31480"
07-13 14:13:05.824+0900 W/LOCKSCREEN(  575): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-13 14:13:05.824+0900 E/LOCKSCREEN(  575): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 14:13:05.824+0900 W/LOCKSCREEN(  575): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-13 14:13:05.824+0900 W/LOCKSCREEN(  575): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-13 14:13:05.844+0900 I/Tizen::System( 1047): (340) > Setting event[http://tizen.org/setting/screen.wallpaper.lock] is occured.
07-13 14:13:05.844+0900 I/Tizen::System( 1047): (351) > The key is http://tizen.org/setting/screen.wallpaper.lock.
07-13 14:13:05.844+0900 I/Tizen::System( 1047): (355) > Try to awake client processes.
07-13 14:13:05.844+0900 I/Tizen::System( 1047): (362) > Event is delivered to b3002118.
07-13 14:13:05.914+0900 E/VCONF   (  575): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/lockscreen/lock_wallpaper_is_default) step(-21) failed(2 / No such file or directory)
07-13 14:13:05.914+0900 E/VCONF   (  575): vconf.c: _vconf_get_key(2111) > db/lockscreen/lock_wallpaper_is_default : read buf error(-21). break
07-13 14:13:05.914+0900 E/VCONF   (  575): vconf.c: vconf_get_bool(2417) > vconf_get_bool(575) : db/lockscreen/lock_wallpaper_is_default error
07-13 14:13:05.914+0900 E/WALLPAPER_SERVICE_COMMON(  575): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 14:13:06.214+0900 W/LOCKSCREEN(  575): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-13 14:13:06.294+0900 E/socket.io(31480): 566: Connected.
07-13 14:13:06.294+0900 E/socket.io(31480): 554: On handshake, sid
07-13 14:13:06.304+0900 E/socket.io(31480): 651: Received Message type(connect)
07-13 14:13:06.304+0900 E/socket.io(31480): 489: On Connected
07-13 14:13:06.304+0900 F/sio_packet(31480): accept()
07-13 14:13:06.304+0900 E/socket.io(31480): 743: encoded paylod length: 41
07-13 14:13:06.304+0900 E/socket.io(31480): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 14:13:06.424+0900 E/socket.io(31480): 669: Received Message type(Event)
07-13 14:13:06.424+0900 F/sio_packet(31480): accept()
07-13 14:13:06.424+0900 E/socket.io(31480): 743: encoded paylod length: 21
07-13 14:13:06.424+0900 E/socket.io(31480): 800: ping exit, con is expired? 0, ec: Operation canceled
07-13 14:13:06.494+0900 E/socket.io(31480): 669: Received Message type(Event)
07-13 14:13:06.494+0900 F/get_binary(31480): in get binary_message()...
07-13 14:13:06.524+0900 I/nornenjs_queue(31480): Queue push
07-13 14:13:06.524+0900 I/nornenjs_queue(31480): Queue pop
07-13 14:13:06.724+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 14:13:06.724+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 14:13:06.744+0900 W/PROCESSMGR(  377): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=606
07-13 14:13:06.764+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(142) > dead_pid = 31480 pgid = 31480
07-13 14:13:06.764+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(123) > dead_pid(31480)
07-13 14:13:06.764+0900 I/AUL_PAD (  491): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 14:13:06.764+0900 I/AUL_PAD (  491): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 14:13:06.774+0900 I/CAPI_APPFW_APPLICATION(  606): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 14:13:06.774+0900 E/cluster-home(  606): homescreen-main.cpp: app_resume(422) >  app resume
07-13 14:13:06.794+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 31480
07-13 14:13:06.814+0900 I/Tizen::App( 1034): (243) > App[org.tizen.nornenjs] pid[31480] terminate event is forwarded
07-13 14:13:06.824+0900 I/Tizen::System( 1034): (256) > osp.accessorymanager.service provider is found.
07-13 14:13:06.824+0900 I/Tizen::System( 1047): (259) > Active app [com.samsun], current [org.tizen.] 
07-13 14:13:06.824+0900 I/Tizen::System( 1034): (196) > Accessory Owner is removed [org.tizen.nornenjs, 31480, ]
07-13 14:13:06.824+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:13:06.824+0900 I/Tizen::System( 1034): (256) > osp.system.service provider is found.
07-13 14:13:06.824+0900 I/Tizen::App( 1034): (506) > TerminatedApp(org.tizen.nornenjs)
07-13 14:13:06.824+0900 I/Tizen::App( 1034): (512) > Not registered pid(31480)
07-13 14:13:06.824+0900 I/Tizen::App( 1034): (782) > Finished invoking application event listener for org.tizen.nornenjs, 31480.
07-13 14:13:06.844+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:13:06.844+0900 I/Tizen::System( 1047): (246) > Terminated app [org.tizen.nornenjs]
07-13 14:13:06.844+0900 I/Tizen::Io( 1047): (729) > Entry not found
07-13 14:13:06.864+0900 I/Tizen::System( 1047): (157) > change brightness system value.
07-13 14:13:06.864+0900 I/Tizen::App( 1047): (782) > Finished invoking application event listener for org.tizen.nornenjs, 31480.
07-13 14:13:06.914+0900 W/CRASH_MANAGER(31547): worker.c: worker_job(1236) > 11314806e6f72143676438
