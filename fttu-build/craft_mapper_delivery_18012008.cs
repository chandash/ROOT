# r4.5.5_ntlt.cs
# NT and LT HOST/TARGET OS (R4.5.5)
# 17-Jan-2008 18:40
# :Start:/vobs/esam/build/ehnt-a/OS
# Base: ISAM 3.3.1.1.8

element * CHECKEDOUT
#############CRAFT#######################
#time 18-Jan-2008.17:15
#element /cm4/fsn/app/asam/craft/... .../ahaa/LATEST
#end time
########################################
#############Perl Rules#####################################
element -dir /cm4/tools/GNU/src/perl/lib PERL5.8.3
element /cm4/tools/GNU/src/perl/... PERL_MODULES_V1.0.3
element /cm4/tools/GNU/src/perl/... PERL5.8.3
element /cm4/fsn/app/snmp/mib/makeTranslationTable .../raleigh_temp/LATEST
element /vobs/dsl/source02/ConfigDataTools/changeStr .../raleigh_temp/LATEST
element /vobs/dsl/source02/ConfigDataTools/xml2code .../raleigh_temp/LATEST
element /vobs/dsl/source02/ConfigDataTools/xml2dml .../raleigh_temp/LATEST
element /vobs/dsl/source02/ConfigDataTools/xslt .../raleigh_temp/LATEST
#########################################################

##############################################################################
# uncomment out the following for official builds
##############################################################################
#include /vobs/dsl/source12/Raleigh/cspecs/r4.5_raleigh_wrap.cs@@/main/LATEST
##############################################################################

##########################################################
# TEMP

#### KM 1/9/08 - BDFam37622 TEST FAST DIRECT ALARM
# modified code
element /cm4/fsn/app/asam/craft/new/alarm/AsamAlarmMib.cc .../raleigh_temp/LATEST
element /vobs/dsl/source02/Alarm/mapper/al_map.c .../raleigh_gpon45_temp1/LATEST

#TMH Temp change to fix host builds.
element /vobs/dsl/source02/SimpleTrace/simpleTrace.c		       /main/aaaa/raleigh_test/1
element /vobs/dsl/source12/glt4-a_BSP/export/ecntcUartInit.h .../raleigh_gpon45_temp1/LATEST #FIXME

# To build ESIM
# 1. cd /vobs/esam/pSOSun/esim
# 2. /usr/atria/bin/clearmake -C gnu BUILD_VERSION= E=SUN ROOT=/vobs/dsl
# Patched ESIM, from latest ISAM R3.3
element -dir /vobs/esam/pSOSun/esim/SwMgnt     .../raleigh_gpon45_temp1/LATEST
#KM45!element /vobs/esam/pSOSun/esim/Makefile        .../raleigh_gpon42_temp1/LATEST
#KM45!element /vobs/esam/pSOSun/esim/esim.cs         .../raleigh_gpon42_temp1/LATEST
element /vobs/esam/pSOSun/esim/esimCreate      .../raleigh_gpon45_temp1/LATEST
element /vobs/esam/pSOSun/esim/SwMgnt/ML3MAA45.001             .../ahaa/LATEST
element /vobs/esam/pSOSun/esim/SwMgnt/ML3NAA45.001             .../ahaa/LATEST
element /vobs/esam/pSOSun/esim/SwMgnt/M3Q7AA45.001             .../ahaa/LATEST
element /vobs/esam/pSOSun/esim/SwMgnt/M3Q8AA45.001             .../ahaa/LATEST
#KM45!element /vobs/esam/pSOSun/esim/SwMgnt/SwMgnt.ini .../raleigh_gpon42_temp1/LATEST
element /vobs/esam/pSOSun/esim/SwMgnt/touchBoards.c .../raleigh_gpon42_temp1/LATEST
element /vobs/esam/pSOSun/esim/cmdHdlr/CmdMain.flex .../raleigh_gpon45_temp1/LATEST
#KM45!element /vobs/esam/pSOSun/esim/sbp/sbp.cc      .../raleigh_gpon42_temp2/LATEST

########################################################

# DIRS
# merge after Makefile fixed!
element -dir /vobs/dsl/source02/QoSMgntNt      .../raleigh_gpon42_temp1/LATEST
# other
element -dir /cm4/fsn/app/asam                                  GPON_TRANSPORT
element -dir /cm4/fsn/app/asam/craft/config              .../raleigh/11 #FIXME
element -dir /cm4/tools/WRS/tornado     .../raleigh_gpon45_temp1/LATEST #FIXME
element -dir /cm8/auto/tools/...                                  /main/LATEST
element -dir /vobs/dsl/mibs       .../raleigh_gpon44_temp1/LATEST #CAN'T MERGE
element -dir /vobs/dsl/source02/ConfigDataXml  .../raleigh_gpon45_temp1/LATEST #FIXME BLR
element -dir /vobs/dsl/source03/EqptCoreNt/export    .../raleigh_gpon45_temp1/LATEST
element -dir /vobs/dsl/source03/Interfaces/app/headers/boards .../raleigh_gpon42_temp1/LATEST
element -dir /vobs/dsl/source03/Interfaces/app/sources/boards .../raleigh_gpon42_temp1/LATEST
element -dir /vobs/dsl/source03/LanxMgnt/app   .../raleigh_gpon42_temp1/LATEST
element -dir /vobs/dsl/source03/REDCY_BPS/app                  .../ahaa/LATEST
element -dir /vobs/dsl/source04                .../raleigh_gpon45_temp1/LATEST
element -dir /vobs/dsl/source04/HsRip_Boards   .../raleigh_gpon45_temp1/LATEST
element -dir /vobs/dsl/source07/VlanBridgeMgntCommon/export .../raleigh_gpon40/LATEST
element -dir /vobs/dsl/source07/VlanBridgeMgntNt/test .../raleigh_gpon40/LATEST
element -dir /vobs/dsl/source08/DHCPRelayMgntLsm            .../raleigh/LATEST
element -dir /vobs/dsl/source08/DHCPRelayMgntNt/idl  .../raleigh_gpon40/LATEST
element -dir /vobs/dsl/sw/flat          .../raleigh_gpon45_temp1/LATEST #FIXME MASTERSHIP BLOCKED
element -dir /vobs/dsl/sw/include       .../raleigh_gpon45_temp1/LATEST #FIXME MASTERSHIP BLOCKED
####
# merged (want label)
element -dir /cm4/fsn/app/osba                                        /main/15
element -dir /cm4/fsn/hs/asics                                         /main/6
element -dir /cm4/fsn/include                                        /main/198
element -dir /cm4/fsn/krnl/bsp/board                                 /main/165
element -dir /cm4/fsn/krnl/bsp/dev                                    /main/17
element -dir /cm4/fsn/krnl/bsp/prozone/board                          /main/28
element -dir /cm4/fsn/krnl/cpu                                         /main/6
element -dir /cm4/fsn/krnl/fs/board                                  /main/120
element -dir /cm4/fsn/krnl/fs/promdrv                                 /main/11
element -dir /cm4/fsn/krnl/os/VXWORKS/api                             /main/13
element -dir /cm4/fsn/krnl/startup                                    /main/10
element -dir /cm4/fsn/prj/asam                                       /main/360
element -dir /cm4/fsn/prj/co/vxworks                                  /main/13
element -dir /cm4/fsn/prj/esam                                        /main/32
element -dir /cm4/tools/Sun/java                                       /main/5
element -dir /cm4/tools/WRS                                           /main/11
element -dir /vobs/dsl/mibs/lanx                                      /main/16
element -dir /vobs/dsl/mibs/lanx/SMIv1                                 /main/4
element -dir /vobs/dsl/sw/include/board                               /main/49
element -dir /vobs/dsl/sw/include/board/exnt-a                    /main/LATEST
element -dir /vobs/esam/build                                         /main/73
element -dir /vobs/dsl/source02/BootLdrEsamBCMLsm/board                /main/4
#bad!element -dir /cm4/fsn/...                         MOD_DIRS_AH_V1.0.0 #BAD
element -dir /vobs/dsl/source02/Alarm                                  /main/4
element -dir /vobs/dsl/source02/NlEth/export                           /main/4
#bad!element -dir /vobs/dsl/source02/...               MOD_DIRS_AH_V1.0.0 #BAD
element -dir /vobs/dsl/source03/REDCY_swolo/engine/cpp                 /main/2
element -dir /vobs/dsl/source03/Swm/export                             /main/4
#bad!element -dir /vobs/dsl/source03/...               MOD_DIRS_AH_V1.0.0 #BAD
#bad!element -dir /vobs/dsl/source04/...               MOD_DIRS_AH_V1.0.0 #BAD
element -dir /vobs/dsl/source04/TemperatureHds/low_level               /main/4
#bad!element -dir /vobs/dsl/source07/...               MOD_DIRS_AH_V1.0.0 #BAD
element -dir /vobs/dsl/source08/AAAServer/export                       /main/5
element -dir /vobs/dsl/source08/AAAServer/include                     /main/15
element -dir /vobs/dsl/source08/AAAServer/src                         /main/19
element -dir /vobs/dsl/source08/DHCPRelayMgntNt                  /main/10 #???
element -dir /vobs/dsl/source08/RadiusClient/inc                       /main/5
element -dir /vobs/dsl/source08/IGMPMgntNt/sources/classes            /main/11
element -dir /vobs/dsl/source08/IGMPMgntNt/headers                    /main/12
element -dir /vobs/dsl/source08/IGMPMgntLsm/sources/classes            /main/6
element -dir /vobs/dsl/source08/IGMPMgntLsm/export                     /main/5
#bad!element -dir /vobs/dsl/source08/...               MOD_DIRS_AH_V1.0.0 #BAD

##########################################################
##########################################################
# DEVELOPMENT - BOARD/SITE-SPECIFIC

element -file /cm4/fsn/hs/asics/serdes/...                     .../ahaa/LATEST
element -file /cm4/fsn/hs/asics/serdes/...              /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/hs/asics/serdes/...                        /main/LATEST

element -file /cm4/fsn/include/ehnt-a/...                      .../ahaa/LATEST
element -file /cm4/fsn/include/ehnt-a/...               /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/include/ehnt-a/...                         /main/LATEST

element -file /cm4/fsn/include/exnt-a/...                      .../ahaa/LATEST
element -file /cm4/fsn/include/exnt-a/...               /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/include/exnt-a/...                         /main/LATEST

element -file /cm4/fsn/include/glt2-a/...                      .../ahaa/LATEST
element -file /cm4/fsn/include/glt2-a/...               /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/include/glt2-a/...                         /main/LATEST

element -file /cm4/fsn/include/glt4-a/...                      .../ahaa/LATEST
element -file /cm4/fsn/include/glt4-a/...               /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/include/glt4-a/...                         /main/LATEST

element -file /cm4/fsn/krnl/bsp/board/ehnt-a/...               .../ahaa/LATEST
element -file /cm4/fsn/krnl/bsp/board/ehnt-a/...        /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/bsp/board/ehnt-a/...                  /main/LATEST

element -file /cm4/fsn/krnl/fs/board/ehnt-a/...                .../ahaa/LATEST
element -file /cm4/fsn/krnl/fs/board/ehnt-a/...         /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/fs/board/ehnt-a/...                   /main/LATEST

element -file /cm4/fsn/krnl/fs/promdrv/cfi/...                 .../ahaa/LATEST
element -file /cm4/fsn/krnl/fs/promdrv/cfi/...          /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/fs/promdrv/cfi/...                    /main/LATEST

element -file /cm4/fsn/krnl/startup/board/ehnt-a/...           .../ahaa/LATEST
element -file /cm4/fsn/krnl/startup/board/ehnt-a/...    /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/startup/board/ehnt-a/...              /main/LATEST

element -file /cm4/fsn/krnl/startup/M8270/...                  .../ahaa/LATEST
element -file /cm4/fsn/krnl/startup/M8270/...           /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/startup/M8270/...                     /main/LATEST

element -file /cm4/fsn/krnl/startup/M834x/...                  .../ahaa/LATEST
element -file /cm4/fsn/krnl/startup/M834x/...           /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/krnl/startup/M834x/...                     /main/LATEST

element /cm4/fsn/prj/co/vxworks/eant-a/Makefile.asam           .../ahaa/LATEST

element -file /cm4/fsn/prj/co/vxworks/glt2-a/...               .../ahaa/LATEST
element -file /cm4/fsn/prj/co/vxworks/glt2-a/...        /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/co/vxworks/glt2-a/...                  /main/LATEST

element -file /cm4/fsn/prj/co/vxworks/glt4-a/...               .../ahaa/LATEST
element -file /cm4/fsn/prj/co/vxworks/glt4-a/...        /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/co/vxworks/glt4-a/...                  /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/bh/...                  .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/bh/...           /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/bh/...                     /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/co_hds/...              .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/co_hds/...       /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/co_hds/...                 /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/lca/...                 .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/lca/...          /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/lca/...                    /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/mini_bh/...             .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/mini_bh/...      /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/mini_bh/...                /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/oflt/...                .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/oflt/...         /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/oflt/...                   /main/LATEST

element -file /cm4/fsn/prj/esam/ehnt-a/...                     .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/ehnt-a/...              /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/ehnt-a/...                        /main/LATEST

element -file /cm4/fsn/prj/esam/exnt-a/...                     .../ahaa/LATEST
element -file /cm4/fsn/prj/esam/exnt-a/...              /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/exnt-a/...                        /main/LATEST

element -file /cm4/fsn/prj/esam/glt2-a/...                   /main/ahaa/LATEST
element -file /cm4/fsn/prj/esam/glt2-a/...              /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/glt2-a/...                        /main/LATEST

element -file /cm4/fsn/prj/esam/glt4-a/...                   /main/ahaa/LATEST
element -file /cm4/fsn/prj/esam/glt4-a/...              /main/0 -mkbranch ahaa
element -dir  /cm4/fsn/prj/esam/glt4-a/...                        /main/LATEST

element /vobs/dsl/sw/include/board/glt2-a/...               .../raleigh/LATEST
element /vobs/dsl/sw/include/board/glt2-a/...   /main/LATEST -mkbranch raleigh

element -file /vobs/dsl/sw/include/board/glt4-a/...            .../ahaa/LATEST
element -file /vobs/dsl/sw/include/board/glt4-a/...     /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/sw/include/board/glt4-a/...               /main/LATEST

element       /vobs/esam/build/ehnt-a/OS/start_a_us.cmd .../raleigh_gpon45_temp1/LATEST #FIXME Wipro
element -file /vobs/esam/build/ehnt-a/OS/...                   .../ahaa/LATEST
element -file /vobs/esam/build/ehnt-a/OS/...            /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/ehnt-a/OS/...                      /main/LATEST

element -file /vobs/esam/build/ehnt-a/...                      .../ahaa/LATEST
element -file /vobs/esam/build/ehnt-a/...               /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/ehnt-a/...                         /main/LATEST

element -file /vobs/esam/build/exnt-a/...                      .../ahaa/LATEST
element -file /vobs/esam/build/exnt-a/...               /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/exnt-a/...                         /main/LATEST

element -file /vobs/esam/build/glt2-a/...                      .../ahaa/LATEST
element -file /vobs/esam/build/glt2-a/...               /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/glt2-a/...                         /main/LATEST

element -file /vobs/esam/build/glt2-b/...                      .../ahaa/LATEST
element -file /vobs/esam/build/glt2-b/...               /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/glt2-b/...                         /main/LATEST

element -file /vobs/esam/build/glt4-a/...                      .../ahaa/LATEST
element -file /vobs/esam/build/glt4-a/...               /main/0 -mkbranch ahaa
element -dir  /vobs/esam/build/glt4-a/...                         /main/LATEST

# build
element /vobs/fttx/objects/ehnt-a                                      /main/0
element /vobs/fttx/objects/exnt-a                                      /main/0
element /vobs/esam/objects/glt2-a                                      /main/0
element /vobs/esam/objects/glt2-b                                      /main/0
##element /vobs/esam/objects/glt4-a                                      /main/0

####
# MOD_TRANSPORT_AH_V
element -file /cm4/fsn/app/asam/transport/...                  .../ahaa/LATEST
element -file /cm4/fsn/app/asam/transport/...           /main/0 -mkbranch ahaa
element -dir /cm4/fsn/app/asam/transport/...                      /main/LATEST

#####
element -file /vobs/dsl/source04/BspPq2ProVxWorks/...          .../ahaa/LATEST
element -file /vobs/dsl/source04/BspPq2ProVxWorks/...   /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/BspPq2ProVxWorks/...             /main/LATEST

#####
# MOD_HSRIP_BOARDS_AH_V
element -file /vobs/dsl/source04/HsRip_Boards/ehnt-a/...       .../ahaa/LATEST
element -file /vobs/dsl/source04/HsRip_Boards/ehnt-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/HsRip_Boards/ehnt-a/...          /main/LATEST

#####
# MOD_HSRIP_BOARDS_AH_V
element -file /vobs/dsl/source04/HsRip_Boards/glt2-a/...       .../ahaa/LATEST
element -file /vobs/dsl/source04/HsRip_Boards/glt2-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/HsRip_Boards/glt2-a/...          /main/LATEST

element -file /vobs/dsl/source04/HsRip_Boards/glt4-a/...       .../ahaa/LATEST
element -file /vobs/dsl/source04/HsRip_Boards/glt4-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/HsRip_Boards/glt4-a/...          /main/LATEST

#####
# MOD_HSRIP_BOARDS_??_?  EXNT board
element -file /vobs/dsl/source04/HsRip_Boards/exnt-a/...       .../ahaa/LATEST
element -file /vobs/dsl/source04/HsRip_Boards/exnt-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/HsRip_Boards/exnt-a/...          /main/LATEST

#####
# 
element -file /vobs/dsl/source04/KRNLCPU_M834x/...             .../ahaa/LATEST
element -file /vobs/dsl/source04/KRNLCPU_M834x/...      /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/KRNLCPU_M834x/...                /main/LATEST

#####
# MOD_NP_LXFWD_ITFWRAP_GLT2A_AA_V
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt2-a/...   .../ahaa/LATEST
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt2-a/... /main/0 -mkbranch ahaa
element -dir /vobs/dsl/source04/NP_LxFwd_itfwrap_glt2-a/...       /main/LATEST

#####
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/stubs/... .../ahaa/LATEST
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/stubs/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/stubs/...  /main/LATEST

#####
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/...     .../ahaa/LATEST
element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/NP_LxFwd_itfwrap_glt4/...        /main/LATEST

#####
# MOD_PROXYARPMGNTLSM_AH_V
element -file /vobs/dsl/source08/ProxyARPMgntLsm/...           .../ahaa/LATEST
element -file /vobs/dsl/source08/ProxyARPMgntLsm/...    /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source08/ProxyARPMgntLsm/...              /main/LATEST

#####
# MOD_PROXYARPMGNTNT_AH_V
element -file /vobs/dsl/source08/ProxyARPMgntNt/...            .../ahaa/LATEST
element -file /vobs/dsl/source08/ProxyARPMgntNt/...     /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source08/ProxyARPMgntNt/...               /main/LATEST

#####
# MOD_PROXYARPPRTCLS_AH_V
element -file /vobs/dsl/source08/ProxyARPPrtcls/...            .../ahaa/LATEST
element -file /vobs/dsl/source08/ProxyARPPrtcls/...     /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source08/ProxyARPPrtcls/...               /main/LATEST

####
# MOD...
element -file /vobs/dsl/source12/BspDevEthPq2Pro/...           .../ahaa/LATEST
element -file /vobs/dsl/source12/BspDevEthPq2Pro/...    /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/BspDevEthPq2Pro/...              /main/LATEST

####
# 
element -file /vobs/dsl/source12/CrashLog/...                  .../ahaa/LATEST
element -file /vobs/dsl/source12/CrashLog/...           /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/CrashLog/...                     /main/LATEST

####
#
element -file /vobs/dsl/source12/Ehlm-2/...                    .../ahaa/LATEST
element -file /vobs/dsl/source12/Ehlm-2/...             /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/Ehlm-2/...                       /main/LATEST

####
# MOD_GPON_COMMON_V
element -file /vobs/dsl/source12/GponCommon/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/GponCommon/...         /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/GponCommon/...                   /main/LATEST

####
# MOD_GPON_LT_V
#glt2 glob sw
element /vobs/dsl/source12/GponLt/mbx/gltd.hex  MOD_FTTU_GLOB_SW_GLT2_V1.4.5.5
#glt4 glob sw
element /vobs/dsl/source12/GponLt/mbxddr/gltd4.hex MOD_FTTU_GLOB_SW_GLT4_V1.4.5.7
element -file /vobs/dsl/source12/GponLt/...                    .../ahaa/LATEST
element -file /vobs/dsl/source12/GponLt/...             /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/GponLt/...                       /main/LATEST

####
# MOD_GPON_NT_V

# Mapper Header
element /vobs/dsl/source12/GponNt/export/GponMapper.h   MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/source12/GponNt/export/gponPmSnmp.h   MOD_MAPPER_AH_V4.5.5.0.3

#GPON Mapper
element -dir /vobs/dsl/source12/GponNt/mapper           MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/source12/GponNt/mapper/...            MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/source12/GponNt/export/gpon.rc        MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/source12/GponNt/export/gpon.mib       MOD_MAPPER_AH_V4.5.5.0.3

element /vobs/dsl/source12/GponNt/mapper/...            MOD_MAPPER_AH_V4.3.5.2
element /vobs/dsl/source12/GponNt/export/GponMapper.h   MOD_MAPPER_AH_V4.3.5.2

# official
element -file /vobs/dsl/source12/GponNt/...                    .../ahaa/LATEST
element -file /vobs/dsl/source12/GponNt/...             /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/GponNt/...                       /main/LATEST

####
# EthCFM libraries for other sites
element -file /vobs/dsl/source12/EthCFMMgnt_lib/...            .../ahaa/LATEST
element -file /vobs/dsl/source12/EthCFMMgnt_lib/...     /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/EthCFMMgnt_lib/...               /main/LATEST

####
# Broadcom
element -file /vobs/dsl/source12/bcm5395Drv/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/bcm5395Drv/...         /main/0 -mkbranch ahaa
element -file /vobs/dsl/source12/bcm5395Drv/...                  /main/LATEST

####
# Interfaces for other sites
element -file /vobs/dsl/source12/interfaces_temp/...           .../ahaa/LATEST
element -file /vobs/dsl/source12/interfaces_temp/...    /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/interfaces_temp/...              /main/LATEST

####
# -- temporary stubs
element /vobs/dsl/source12/fttu_dummy/...      .../raleigh_gpon45_temp1/LATEST

####
# -- temporary stubs
element /vobs/dsl/source12/fttu_lt_dummy/user_ipconfig.c .../raleigh_gpon45_temp1/LATEST #FIXME
element -file /vobs/dsl/source12/fttu_lt_dummy/...             .../ahaa/LATEST
element -file /vobs/dsl/source12/fttu_lt_dummy/...         /main/LATEST #FIXME
#element -file /vobs/dsl/source12/fttu_lt_dummy/...      /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/fttu_lt_dummy/...                /main/LATEST

####
# -- permanent stubs
element /vobs/dsl/source12/fttu_stubs/Makefile                 .../ahaa/LATEST
element -file /vobs/dsl/source12/fttu_stubs/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/fttu_stubs/...         /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/fttu_stubs/...                   /main/LATEST

element -file /vobs/dsl/source12/fttu_stubs_lt/... /main/ahaa/raleigh_gpon44/LATEST #FIXME
element -file /vobs/dsl/source12/fttu_stubs_lt/... /main/ahaa/wipro_blr_gpon_fgu44/LATEST #FIXME
element -file /vobs/dsl/source12/fttu_stubs_lt/...             .../ahaa/LATEST
element -file /vobs/dsl/source12/fttu_stubs_lt/...      /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/fttu_stubs_lt/...                /main/LATEST

####
# board-specific

element /vobs/dsl/source12/exnt-a_BSP/Makefile          .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_BSP/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_BSP/...         /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_BSP/...                   /main/LATEST

element -file /vobs/dsl/source12/exnt-a_flash/...              .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_flash/...       /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_flash/...                 /main/LATEST

element -file /vobs/dsl/source12/exnt-a_FS/...                 .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_FS/...          /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_FS/...                    /main/LATEST

element -file /vobs/dsl/source12/exnt-a_HIT/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_HIT/...         /main/0 -mkbranch ahaa
element -file /vobs/dsl/source12/exnt-a_HIT/...                   /main/LATEST

element -file /vobs/dsl/source12/exnt-a_HIT_SHELL/...          .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_HIT_SHELL/...   /main/0 -mkbranch ahaa
element -file /vobs/dsl/source12/exnt-a_HIT_SHELL/...             /main/LATEST

element -file /vobs/dsl/source12/exnt-a_Init/...               .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_Init/...        /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_Init/...                  /main/LATEST

element -file /vobs/dsl/source12/exnt-a_lca/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_lca/...         /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_lca/...                   /main/LATEST

element -file /vobs/dsl/source12/exnt-a_mini_bh/...            .../ahaa/LATEST
element -file /vobs/dsl/source12/exnt-a_mini_bh/...     /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/exnt-a_mini_bh/...               /main/LATEST

# freeze driver for now
element       /vobs/dsl/source12/glt2-a_BSP/htm/...            .../ahaa/LATEST
element       /vobs/dsl/source12/glt2-a_BSP/htm/... MOD_GLT2-A_BSP_AH_V4.3.6.0.0
element -file /vobs/dsl/source12/glt2-a_BSP/...                .../ahaa/LATEST
element -file /vobs/dsl/source12/glt2-a_BSP/...         /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/glt2-a_BSP/...                   /main/LATEST

element -file /vobs/dsl/source12/glt2-a_FS/...                 .../ahaa/LATEST
element -file /vobs/dsl/source12/glt2-a_FS/...          /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/glt2-a_FS/...                    /main/LATEST

element -file /vobs/dsl/source12/glt2-a_Init/...               .../ahaa/LATEST
element -file /vobs/dsl/source12/glt2-a_Init/...        /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source12/glt2-a_Init/...                  /main/LATEST

# misc, redundant
element /vobs/dsl/source12/Raleigh/tmp_include/...                /main/LATEST
element /vobs/dsl/source12/Raleigh/util/...                       /main/LATEST

#####
element -file /vobs/dsl/source14/...                           .../ahaa/LATEST
element -file /vobs/dsl/source14/...                    /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source14/...                              /main/LATEST

#####
# temp rule to resolve build issues. Will be removed later
element /vobs/dsl/mibs/GPON_MIB                         MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/mibs/XDSL_MIB                         MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/mibs/GPON_MOCA_MIB                    MOD_MAPPER_AH_V4.5.5.0.3
element /vobs/dsl/mibs/GPON_VDSL_MIB                    MOD_MAPPER_AH_V4.5.5.0.3

# official
element /vobs/dsl/mibs/XDSL_MIB                .../raleigh_gpon44_temp1/LATEST


##########################################################
# CLI-Related XML sources

# -- CLI manual
# Spec: Ed01 Prop01

# XML outside the CLI tree which affects manual
element /vobs/dsl/source07/VlanBridgeMgntNt/source/vlan_management.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/source08/8021xMgntNt/export/Dot1x_management.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
# error codes
#element /vobs/dsl/source08/IGMPMgntNt/export/igmp_management.xml MOD_IGMPMGNTNT_AA_V4.0.5
element /vobs/dsl/source08/IGMPMgntNt/export/igmp_management.xml MOD_IGMPMGNTNT_AA_FDT301.V8.99.17

# main manual sources

element /vobs/dsl/source08/CLI_Language/userguide/Images/iSAM.gif RALEIGH_SW_GPON4505_CLI_SPEC_01P01

element -dir /vobs/dsl/source08/CLI_AAA                               /main/31
element /vobs/dsl/source08/CLI_AAA/*.xml      RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_AlarmReporting/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_ATM/*.xml      RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_Common/*.xml   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_CPEMGNT/*.xml  RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_DHCP/*.xml     RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_Equipment     /main/raleigh_gpon45_temp1/1
element /vobs/dsl/source08/CLI_Equipment/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
#TEMP rule for BDFam37883 till next label available
element /vobs/dsl/source08/CLI_Error/equipment_management.xml  .../ahaa/1
element /vobs/dsl/source08/CLI_Error/*.xml    RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_IGMP          /main/raleigh_gpon45_temp1/2
element /vobs/dsl/source08/CLI_IGMP/*.xml     RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_IP            /main/raleigh_gpon44_temp1/1
element /vobs/dsl/source08/CLI_IP/*.xml       RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_IPSEC/*.xml    RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_Language/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_Operators                          /main/6
element /vobs/dsl/source08/CLI_Operators/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_OSPF/*.xml     RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/source08/CLI_PPPoE/*.xml    RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_QoS           /main/raleigh_gpon45_temp1/1
element /vobs/dsl/source08/CLI_QoS/*.xml      RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_RIP/*.xml      RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_SSH/*.xml      RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_SWManagement/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_System        /main/raleigh_gpon44_temp1/1
element /vobs/dsl/source08/CLI_System/*.xml   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_Transport/*.xml RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element -dir /vobs/dsl/source08/CLI_VLAN          /main/raleigh_gpon45_temp1/2
element /vobs/dsl/source08/CLI_VLAN/*.xml     RALEIGH_SW_GPON4505_CLI_SPEC_01P01
#--
element /vobs/dsl/source08/CLI_xDSL/*.xml     RALEIGH_SW_GPON4505_CLI_SPEC_01P01

##########################################################
##########################################################
# DEVELOPMENT - MODIFIED MODULES
# ordered by file path

#####
# MOD_APPLIC_SERVICES_V1.0.1 SYNC_DIR=/cm4/fsn/app/asam/applicationServices
element /cm4/fsn/app/asam/applicationServices/export/SubsystemIds_ApplicationServices.hpp .../ahaa/LATEST

#####
# MOD_ASAM_COMMON_CLASSES_V3.2.1 SYNC_DIR=/cm4/fsn/app/asam/common/classes
element /cm4/fsn/app/asam/common/classes/headers/xapi++.h      .../ahaa/LATEST
element /cm4/fsn/app/asam/common/classes/sources/Makefile      .../ahaa/LATEST

#####
# was:MOD_ASAM_COMMON_IDL_AA_V1.0.2
# MOD_ASAM_COMMON_IDL_AA_V11.1.0 SYNC_DIR=/cm4/fsn/app/asam/common/idl
# HW reference
element /cm4/fsn/app/asam/common/idl/asam_types.idl .../ahaa/LATEST

#####
# was:MOD_ASAM_COMMON_TYPES_AA_V8.7.1 
# MOD_ASAM_COMMON_TYPES_AA_V12.6.7 SYNC_DIR=/cm4/fsn/app/asam/common/types
element /cm4/fsn/app/asam/common/types/export/com_types.h  .../ahaa/LATEST
element /cm4/fsn/app/asam/common/types/export/com_types++.h  .../ahaa/LATEST
element /cm4/fsn/app/asam/common/types/export/fixed_ports.h  .../ahaa/LATEST

################################################################
# MOD_CRAFT_AA_V8.10.34 SYNC_DIR=/cm4/fsn/app/asam/craft

#For generating tl1_summary_dynamic_ehnt-a
element /cm4/tools/ANS/dynextract/dynstubs.c     /main/LATEST
element /cm4/tools/ANS/dynextract/...            /main/LATEST
element /cm4/tools/ANS/bin5/crc32                /main/LATEST
element /cm4/tools/ANS/varsort/variants_sort     /main/LATEST
#Others
#KM45!element /cm4/tools/ANS/elf2coff/...              /main/LATEST
#KM45!element /cm4/tools/ANS/coff/...                  /main/LATEST
#KM45!element /cm4/tools/ANS/ihex2src/...              /main/LATEST
#KM45!element /cm4/tools/ANS/include/...               /main/LATEST
#KM45!element /cm4/tools/ANS/src_common/...            /main/LATEST
#KM45!element /cm4/tools/ANS/bin5/fpgabuild            /main/LATEST

### craft fixes/patches

#Try to resolve tools issues (needs improvement)
element -file /cm4/tools/ANS/binl/...    .../main/LATEST #fix
element -file /cm4/tools/ANS/clc_annex/Linux_2.4.20-8/... .../main/LATEST #fix
element -file /cm4/tools/ANS/bin5/...        CLC_ANNEX_V2.0.1
element -file /cm4/tools/ANS/clc_annex/...   CLC_ANNEX_V2.0.1
element /cm4/tools/ANS/clc_annex/...             /main/LATEST

#These probably never can be fixed in this VOB
#KM45!element -dir /cm4/fsn/app/asam/craft/new/apon  /main/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/new/qos  /main/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/new/vlan  /main/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/new                       .../ahaa/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/new/inc                   .../ahaa/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/ported1603/inc            .../ahaa/LATEST

#These will soon be unnecessary
#KM45!element -file /cm4/fsn/app/asam/craft/information/...          .../ahaa/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/information/...           .../main/LATEST
#KM45!element -dir /cm4/fsn/app/asam/craft/new/equip2                .../main/LATEST

# testbed
element /cm4/fsn/app/asam/craft/testbed/Makefile               .../ahaa/LATEST
element /cm4/fsn/app/asam/craft/testbed/include/eqsim_intf.h   .../ahaa/LATEST
element /cm4/fsn/app/asam/craft/testbed/src/snmp_stub2.cc      .../ahaa/LATEST

element -file /cm4/fsn/app/asam/craft/testbed/src_isam/eqsim/... /main/ahaa/LATEST

element /cm4/fsn/app/asam/craft/testbed/src_isam/index_conv/indexConv.cpp .../ahaa/LATEST
element /cm4/fsn/app/asam/craft/testbed/src_isam/mapping/HolderMappingSimple.cc .../ahaa/LATEST

element -dir  /cm4/fsn/app/asam/craft/testbed/src_isam/stubs      /main/LATEST
element -file /cm4/fsn/app/asam/craft/testbed/src_isam/stubs/... /main/ahaa/LATEST
element -file /cm4/fsn/app/asam/craft/testbed/src_isam/stubs/... /main/LATEST -mkbranch ahaa

#KM45!element /cm4/fsn/app/asam/craft/testbed/...           CRAFT_TESTBED_FGU4.4.0.0

# better tracing
#element /cm4/fsn/app/asam/craft/new/inc/trace_snmp.h   .../raleigh_test/LATEST
#element /cm4/fsn/app/asam/craft/new/snmp++/SnmpDbg.cc .../raleigh_test3/LATEST

### normal craft development (uncomment LATEST rules)

#element -file /cm4/fsn/app/asam/craft/...                     .../ahaa/LATEST
#element -dir /cm4/fsn/app/asam/craft/...                         /main/LATEST

# ultimately this should stand alone
#BDFma37622; BDFam38224 -- temp fix
#element /cm4/fsn/app/asam/craft/new/alarm/auto_alm2.cc  /main/ahaa/raleigh_gpon45_temp1/2
element /cm4/fsn/app/asam/craft/...                  MOD_CRAFT_AH_V4.5.5.0.4

###
# TOOLS_CLC_AA_V2.1.0 SYNC_DIR=/cm4/tools/ANS/tl1_compiler
# CLC update
element -dir /cm4/tools/ANS/bin5                                      /main/22
element /cm4/tools/ANS/tl1_compiler/...                    TOOLS_CLC_AH_V2.1.2
element /cm4/tools/ANS/tl1_compiler/...                        .../ahaa/LATEST
element /cm4/tools/ANS/tl1_compiler/...                    TOOLS_CLC_AA_V2.1.0

# end craft
################################################################

#####
# GLT2-x additions
element /cm4/fsn/app/asam/mcc_lt/...                       MOD_FTTU_MCC_V1.0.0
element /cm4/fsn/app/asam/stubs_gpon/...               .../raleigh_temp/LATEST
element /cm4/fsn/app/asam/stubs_gpon/...                  GPON_TRANSPORT_STUBS

#####
# MOD_TRANSACT_AA_V5.1.5 SYNC_DIR=/cm4/fsn/app/asam/transaction
element /cm4/fsn/app/asam/transaction/trans.c  .../ahaa/LATEST

# development part 2

element /vobs/dsl/source12/...                            /main/LATEST

#####
# was:MOD_NLSLIP_AA_V1.0.0
# MOD_NLSLIP_AA_V1.1.3 SYNC_DIR=/cm4/fsn/app/pstack/nl/slip
# M8270
element /cm4/fsn/app/pstack/nl/slip/ni_slip.c  .../ahaa/LATEST

#####
# was:MOD_IPSNMP_ASAM_AA_V3.0.2
# MOD_IPSNMP_ASAM_AA_V3.85.5 SYNC_DIR=/cm4/fsn/app/pstack/sl/ipsnmp
# default ACU IP address
element /cm4/fsn/app/pstack/sl/ipsnmp/ipcfg_snmp.c  .../ahaa/LATEST

#####
# MOD_BOOTPC_V1.4.11 SYNC_DIR=/cm4/fsn/app/servers/bootpc
element /cm4/fsn/app/servers/bootpc/bootpc.c  .../ahaa/LATEST

#####
# MOD_FCMT_ERR_AA_V4.0.0 SYNC_DIR=/cm4/fsn/app/servers/fcmt
element /cm4/fsn/app/servers/fcmt/fmSink.h  .../ahaa/LATEST
element /cm4/fsn/app/servers/fcmt/fmSinkMeas.cpp  .../ahaa/LATEST

#####
# MOD_RCOM-CLIENT_AA_V1.0.2 SYNC_DIR=/cm4/fsn/app/servers/rcom/client
element /cm4/fsn/app/servers/rcom/client/rcom_client.c  .../ahaa/LATEST

#####
# MOD_SNTP-CLIENT_AA_V1.1.0 SYNC_DIR=/cm4/fsn/app/servers/sntp/client
# reset-safe
element /cm4/fsn/app/servers/sntp/client/sntp_client.c         .../ahaa/LATEST
element /cm4/fsn/app/servers/sntp/client/Makefile              .../ahaa/LATEST

#####
# was:MOD_SNTP-SERVER_AA_V1.0.1
# MOD_SNTP-SERVER_AA_V1.0.4 SYNC_DIR=/cm4/fsn/app/servers/sntp/server
element /cm4/fsn/app/servers/sntp/server/sntp_server.c         .../ahaa/LATEST

#####
# Telnet addition
element /cm4/fsn/app/servers/telnet/sources/tnaagent.c         .../ahaa/LATEST
element /cm4/fsn/app/servers/telnet/...             MOD_TELNETAGENT_AH_V4.4.10.0.1

####
# MOD_TFTP_AA_V3.1.0 SYNC_DIR=/cm4/fsn/app/servers/tftp
element /cm4/fsn/app/servers/tftp/server/server.c .../ahaa/LATEST
element /cm4/fsn/app/servers/tftp/client/client.c .../ahaa/LATEST
element /cm4/fsn/app/servers/tftp/client/tftp_api.c  .../ahaa/LATEST

#####
# was:MOD_SNMPAGENT_AA_V3.6.32
# MOD_SNMPAGENT_AA_V4.0.18 SYNC_DIR=/cm4/fsn/app/snmp/agent
#Fix for BDFam37232
element /cm4/fsn/app/snmp/agent/snmpserv.c   /main/ahaa/LATEST
#Fix for BDFam31570
element /cm4/fsn/app/snmp/agent/export/SnmpBulkType.hpp        .../ahaa/LATEST
# Fix for WPRas04037
element /cm4/fsn/app/snmp/agent/system.c                       .../ahaa/LATEST
# dynamic LANX address
element /cm4/fsn/app/snmp/agent/SnmpLocalEngine.cpp            .../ahaa/LATEST
element /cm4/fsn/app/snmp/agent/SnmpMasterAgent.cpp .../raleigh_gpon45_temp1/LATEST #FIXME mastership requested
# Fix for BDFam29872
element /cm4/fsn/app/snmp/agent/SnmpSetType.cpp  .../ahaa/LATEST

#####
# was:/main/MOD_BLDCOMMON_V1.17.6
# MOD_BLDCOMMON_V1.18.10 SYNC_DIR=/cm4/fsn/build/co
# support Solaris 9
# add 8270 (+lint)
element /cm4/fsn/build/co/Makefile_mod  .../raleigh_gpon45_temp1/LATEST #FIXME
element /cm4/fsn/build/co/Makefile_top  .../raleigh_gpon45_temp1/LATEST #FIXME
# add 8270
element /cm4/fsn/build/co/cpu.mak      .../raleigh_gpon42_bugfix/LATEST #FIXME
element /cm4/fsn/build/co/profile.csh   .../raleigh_gpon45_temp1/LATEST #FIXME
element /cm4/fsn/build/co/profile.ksh   .../raleigh_gpon45_temp1/LATEST #FIXME
# add 8270 (fix templates, Purify)
element /cm4/fsn/build/co/tools.mak     .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_LCOM_AA_V1.0.3 SYNC_DIR=/cm4/fsn/hs/lcom
# host: don't crash on comm init
element /cm4/fsn/hs/lcom/com_ll.cpp          .../raleigh_psosun2/LATEST #FIXME

#####
# was:MOD_LSOCK_AA_V2.0.2
# MOD_LSOCK_AA_V3.0.3 SYNC_DIR=/cm4/fsn/hs/lsock
# host NT standalone
element /cm4/fsn/hs/lsock/lsock.cpp     .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_REGISTER_ACCESS_AA_V2.1.2 SYNC_DIR=/cm4/fsn/hs/service_lib/registers
element /cm4/fsn/hs/service_lib/registers/export/HwRegister.imp  .../ahaa/LATEST
element /cm4/fsn/hs/service_lib/registers/export/Register.hpp   .../ahaa/LATEST
element /cm4/fsn/hs/service_lib/registers/export/RegisterArray.imp .../ahaa/LATEST
element /cm4/fsn/hs/service_lib/registers/export/SpecialHwRegister.imp .../ahaa/LATEST

#####
# MOD_XDSLAPI-ITF_AA_V5.2.2 SYNC_DIR=/cm4/fsn/hs/xdsl_proxy/common/export
element /cm4/fsn/hs/xdsl_proxy/common/export/XdslInit.hpp  .../ahaa/LATEST

#####
# add ehnt-a, exnt-a
element /cm4/fsn/krnl/bsp/Makefile  .../ahaa/LATEST

#####
# was:MOD_BSP_DEV_PQ2_AA_V1.1.2 
# MOD_BSP_DEV_PQ2_AA_V2.1.3 SYNC_DIR=/cm4/fsn/krnl/bsp/dev/pq2
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_8260_cfg.h        .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_8260_config.h     .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_8260_msr.h        .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_8260_siu.h        .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_bat_reg.h         .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_caches.h          .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/export/mpc_mmu.h             .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_8260_clk.c               .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_8260_region.c            .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_caches.s                 .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_clk.c                    .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_exception.c              .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_isr.c                    .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_region.c                 .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2/mpc_tmcnt.c                  .../ahaa/LATEST

#####
# was:MOD_BSP_DEV_PQ2CPM_AA_V3.0.0 
# MOD_BSP_DEV_PQ2CPM_AA_V4.0.2 SYNC_DIR=/cm4/fsn/krnl/bsp/dev/pq2_cpm
element /cm4/fsn/krnl/bsp/dev/pq2_cpm/export/mpc_8260_cpm_cfg.h  .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/dev/pq2_cpm/scc/uartScc.c            .../ahaa/LATEST

#####
# MOD_BSP_EXPORT_AA_V5.1.3 SYNC_DIR=/cm4/fsn/krnl/bsp/export
element /cm4/fsn/krnl/bsp/export/prozone_appl_id.h             .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/export/scc.h                         .../ahaa/LATEST

#####
# MOD_BSP_PQ2_CO_AA_V4.0.1 SYNC_DIR=/cm4/fsn/krnl/bsp/pq2/board/co
element /cm4/fsn/krnl/bsp/pq2/board/co/comvars.c               .../ahaa/LATEST
# add boards
element /cm4/fsn/krnl/bsp/pq2/board/co/Makefile                .../ahaa/LATEST

#####
# MOD_BSP_PQ2_DBG_V1.0.10 SYNC_DIR=/cm4/fsn/krnl/bsp/pq2/bsp_dbg
element /cm4/fsn/krnl/bsp/pq2/bsp_dbg/bsp_dbg.c              /main/ahaa/LATEST
element /cm4/fsn/krnl/bsp/pq2/bsp_dbg/sharedBuf.c            /main/ahaa/LATEST

#####
# MOD_BSP_PQ2_ERR_AA_V4.0.2 SYNC_DIR=/cm4/fsn/krnl/bsp/pq2/bsp_err
# add ehnt-a, glt2-x
element /cm4/fsn/krnl/bsp/pq2/bsp_err/Makefile                 .../ahaa/LATEST

#####
# MOD_BSP_PROZONE_AA_FDT541.V8.0.3 SYNC_DIR=/cm4/fsn/krnl/bsp/prozone
element /cm4/fsn/krnl/bsp/prozone/Makefile  .../ahaa/LATEST
# fix NT host FS
#UNNECESSARY:element /cm4/fsn/krnl/bsp/prozone/export/prozoneini.h .../ahaa/LATEST
# ??
element /cm4/fsn/krnl/bsp/prozone/co_prozone.c  .../ahaa/LATEST
element /cm4/fsn/krnl/bsp/prozone/prozone.c                    .../ahaa/LATEST

#####
# allow longer command line (needed for Raleigh host)
# MOD_CMDARGS_AA_V1.0.2 SYNC_DIR=/cm4/fsn/krnl/cmdArgs
element /cm4/fsn/krnl/cmdArgs/export/cmdArgs.hpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# was:MOD_KRNLCONFIG_AA_V4.0.0
# MOD_KRNLCONFIG_AA_V7.0.3 SYNC_DIR=/cm4/fsn/krnl/config
element /cm4/fsn/krnl/config/kernel_init.cpp   .../ahaa/LATEST

#####
# MOD_KRNLCPU_EXPORT_V1.3.0 SYNC_DIR=/cm4/fsn/krnl/cpu/export
# debug additions
element /cm4/fsn/krnl/cpu/export/bp/breakpoint.h               .../ahaa/LATEST

#####
# was:MOD_KRNLCPU_M8260_AA_V2.0.0
# MOD_KRNLCPU_M8260_AA_V3.0.0 SYNC_DIR=/cm4/fsn/krnl/cpu/M8260
element -dir /cm4/fsn/krnl/cpu/M8260/debug/bp                          /main/3
element /cm4/fsn/krnl/cpu/M8260/api/m8260_api.c              /main/ahaa/LATEST
element /cm4/fsn/krnl/cpu/M8260/debug/bp/M8260_bp.c            .../ahaa/LATEST
element /cm4/fsn/krnl/cpu/M8260/debug/bp/M8260_except.s        .../ahaa/LATEST
element /cm4/fsn/krnl/cpu/M8260/debug/bp/Makefile              .../ahaa/LATEST
element /cm4/fsn/krnl/cpu/M8260/error/pq2_exception.c          .../ahaa/LATEST

#####
# was:MOD_ERROR_AA_V1.3.2
# MOD_ERROR_AA_V1.7.4 SYNC_DIR=/cm4/fsn/krnl/error
element /cm4/fsn/krnl/error/export/error.h                     .../ahaa/LATEST
element /cm4/fsn/krnl/error/error.c                            .../ahaa/LATEST
element /cm4/fsn/krnl/error/intr_error.c                     /main/ahaa/LATEST

#####
# was:MOD_FSBLKDEV_V1.0.10
# MOD_FSBLKDEV_AA_V2.0.2 SYNC_DIR=/cm4/fsn/krnl/fs/blockDevice
element /cm4/fsn/krnl/fs/blockDevice/PartTable.cpp             .../ahaa/LATEST

#####
# MOD_FSDEVS_V4.0.3 SYNC_DIR=/cm4/fsn/krnl/fs/board/co/devs
element /cm4/fsn/krnl/fs/board/co/devs/Makefile                .../ahaa/LATEST

#####
# MOD_FSDISKDEV_AA_V2.2.1 SYNC_DIR=/cm4/fsn/krnl/fs/diskDevice/compactFlash
element /cm4/fsn/krnl/fs/diskDevice/compactFlash/dev_sync.c    .../ahaa/LATEST

#####
# MOD_FSKRNL_AA_V7.1.1 SYNC_DIR=/cm4/fsn/krnl/fs/fskrnl
element /cm4/fsn/krnl/fs/fskrnl/main.cpp                       .../ahaa/LATEST
element /cm4/fsn/krnl/fs/fskrnl/export/included_maint.cc       .../ahaa/LATEST
element /cm4/fsn/krnl/fs/fskrnl/export/wxmodem.hpp             .../ahaa/LATEST
element /cm4/fsn/krnl/fs/fskrnl/wxmodem.cpp                    .../ahaa/LATEST

#####
# MOD_FSPMD_AA_V1.0.0 SYNC_DIR=/cm4/fsn/krnl/fs/pmd
element /cm4/fsn/krnl/fs/pmd/pmd.c                             .../ahaa/LATEST

#####
# MOD_FSSHELL_AA_V5.0.2 SYNC_DIR=/cm4/fsn/krnl/fs/shell
element /cm4/fsn/krnl/fs/shell/shell.cpp                       .../ahaa/LATEST
element /cm4/fsn/krnl/fs/shell/CmdFdisk.cpp                    .../ahaa/LATEST

#####
# MOD_XFS_AA_V1.0.2 SYNC_DIR=/cm4/fsn/krnl/fs/xfs
element /cm4/fsn/krnl/fs/xfs/xfs_trc_dbg.cc                    .../ahaa/LATEST
element /cm4/fsn/krnl/fs/xfs/xfs_mount.cc                      .../ahaa/LATEST

#####
# MOD_MEMMNGT_AA_V2.1.4 SYNC_DIR=/cm4/fsn/krnl/memmngt
element /cm4/fsn/krnl/memmngt/private/allocatordynamic.hpp   /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/private/allocatorsemi.hpp        .../ahaa/LATEST
element /cm4/fsn/krnl/memmngt/private/lock.hpp               /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/allocatorctrl.cpp      /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/allocatordynamic.cpp   /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/allocatorpool.cpp      /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/allocatorsemi.cpp        .../ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/allocatorwrapper.cpp   /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/factory.cpp            /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/memm_init.cpp          /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/memmngt.cpp            /main/ahaa/LATEST
element /cm4/fsn/krnl/memmngt/sources/tracedebug.cpp           .../ahaa/LATEST

#####
# MOD_KRNLMISC_AA_V3.0.13 SYNC_DIR=/cm4/fsn/krnl/misc
# correctly initialize serial mux
element /cm4/fsn/krnl/misc/scc_psos.c                          .../ahaa/LATEST
# fix a bug in rs_getchar when called by FSread on STDIN always return 1 when no chars received
element /cm4/fsn/krnl/misc/rs_shell.c                          .../ahaa/LATEST

#####
# MOD_TICKDISP_AA_V1.0.0 SYNC_DIR=/cm4/fsn/krnl/tick_disp
element /cm4/fsn/krnl/tick_disp/tick_disp.c                  /main/ahaa/LATEST

#####
# was:MOD_KRNLOS_VXWORKS_AA_V3.1.0
# MOD_KRNLOS_VXWORKS_AA_V4.0.6 SYNC_DIR=/cm4/fsn/krnl/os/VXWORKS
element /cm4/fsn/krnl/os/VXWORKS/api/sm_Lib.c                  .../ahaa/LATEST
# M8270
element /cm4/fsn/krnl/os/VXWORKS/api/t_Lib.c                   .../ahaa/LATEST
#####
# was:MOD_BH_RM_COM_AA_V1.1.4 SYNC_DIR=/cm4/fsn/prj/co/bh_rm/export
# (moved to /vobs/dsl/source04/bh_rm_com)
#???!element /cm4/fsn/prj/co/bh_rm/Makefile        .../raleigh_gpon40/LATEST #FIXME

#####
# was:MOD_RTEMS_PSOSUN_AA_V1.3.0
# MOD_RTEMS_PSOSUN_AA_V1.3.5 SYNC_DIR=/cm4/fsn/krnl/RTEMS/pSOSun
# Support Raleigh host simulation comms (harmless elsewhere)
element /cm4/fsn/krnl/RTEMS/pSOSun/main.c           .../raleigh_psosun6/LATEST

#####
# MOD_STARTUP_CO_V1.0.1 XXX_DIR=/cm4/fsn/krnl/startup/co/OS
element /cm4/fsn/krnl/startup/co/OS/Makefile                   .../ahaa/LATEST
element /cm4/fsn/krnl/startup/co/OS/resets.c                   .../ahaa/LATEST

#####
# was:MOD_STARTUP_M8250_AA_V2.1.1
# MOD_STARTUP_M8250_AA_V2.1.3 SYNC_DIR=/cm4/fsn/krnl/startup/M8250
# add ehnt-a
element /cm4/fsn/krnl/startup/M8250/OS/mmuCfg.c .../ahaa/LATEST
element /cm4/fsn/krnl/startup/M8250/OS/startup.c .../ahaa/LATEST

#####
# was:MOD_STARTUP_M8260_V1.0.22
# MOD_STARTUP_M8260_AA_V2.1.1 SYNC_DIR=/cm4/fsn/krnl/startup/M8260
element /cm4/fsn/krnl/startup/M8260/OS/startup.c  .../ahaa/LATEST

#####
# MOD_KRNLTRCPTS_V1.1.3 SYNC_DIR=/cm4/fsn/krnl/tracepoints
# debug additions
element /cm4/fsn/krnl/tracepoints/Makefile                     .../ahaa/LATEST
element /cm4/fsn/krnl/tracepoints/tandd.c                      .../ahaa/LATEST
element /cm4/fsn/krnl/tracepoints/tracepoints.c                .../ahaa/LATEST
element /cm4/fsn/krnl/tracepoints/tracepoints_int.h            .../ahaa/LATEST

#####
# MOD_KRNLTRCTOOL_AA_V3.0.1 SYNC_DIR=/cm4/fsn/krnl/tracetool
element /cm4/fsn/krnl/tracetool/rsc.cpp                      /main/ahaa/LATEST

#####
# MOD_XAPI_AA_V6.1.4 SYNC_DIR=/cm4/fsn/krnl/xapi
element /cm4/fsn/krnl/xapi/Makefile                          /main/ahaa/LATEST # FIXME bad ahaa start
element /cm4/fsn/krnl/xapi/export/xapi.h                     /main/ahaa/LATEST
element /cm4/fsn/krnl/xapi/notepad.c                         /main/ahaa/LATEST
element /cm4/fsn/krnl/xapi/x_sem.c                           /main/ahaa/LATEST
element /cm4/fsn/krnl/xapi/xb_buf.c                          /main/ahaa/LATEST
element /cm4/fsn/krnl/xapi/xtimer.c                          /main/ahaa/LATEST
element /cm4/fsn/krnl/xapi/xxqueue.c                         /main/ahaa/LATEST

#####
# MOD_LIBSYSTEM_V1.1.7 SYNC_DIR=/cm4/fsn/lib/system
element /cm4/fsn/lib/system/export/ppc2_macros.h             /main/ahaa/LATEST

#####
# MOD_ASSERT_AA_V1.0.0 SYNC_DIR=/cm4/fsn/platform/assert
# make assert non-recoverable error
element /cm4/fsn/platform/assert/export/AsamAssert.h .../raleigh_gpon45_temp1/LATEST

#####
# MOD_DATAMNGT_AA_V3.85.16 SYNC_DIR=/cm4/fsn/platform/datamngt
element -dir /cm4/fsn/platform/datamngt/export                    /main/LATEST
element -dir /cm4/fsn/platform/datamngt/headers                   /main/LATEST
element -dir /cm4/fsn/platform/datamngt/sources                   /main/LATEST
element -dir /cm4/fsn/platform/datamngt/sources/communication     /main/LATEST
element -dir /cm4/fsn/platform/datamngt/sources/sync              /main/LATEST

element /cm4/fsn/platform/datamngt/...                         .../ahaa/LATEST

#####
# MOD_IOCM_AA_V5.0.3 SYNC_DIR=/cm4/fsn/platform/iocm
element /cm4/fsn/platform/iocm/core/Node.cc                  /main/ahaa/LATEST
element /cm4/fsn/platform/iocm/core/Queue.cc                 /main/ahaa/LATEST
element /cm4/fsn/platform/iocm/core/Task.cc                  /main/ahaa/LATEST
element /cm4/fsn/platform/iocm/core/Timer.cc                 /main/ahaa/LATEST
element /cm4/fsn/platform/iocm/os/asam/AsamOSI.cpp           /main/ahaa/LATEST
element /cm4/fsn/platform/iocm/os/asam/export/AsamOSI.hpp    /main/ahaa/LATEST

####
# MOD_PERSLOSS_AA_V1.0.4 SYNC_DIR=/cm4/fsn/platform/persloss
element /cm4/fsn/platform/persloss/sources/PersLoss.cpp        .../ahaa/LATEST
#element -file /cm4/fsn/platform/persloss/...                  .../ahaa/LATEST

#####
# was:MOD_GLOB_DEFS_AA_V5.0.2
# MOD_GLOB_DEFS_AA_V8.4.1 SYNC_DIR=/cm4/fsn/prj/co/global_defs
# fix per spec and order properly
element /cm4/fsn/prj/co/global_defs/export/module_ids.h .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# was:MOD_FSTEST_V3.0.7
# MOD_FSTEST_V3.0.8 SYNC_DIR=/cm4/fsn/test/krnl/fs/dummies
# fix NT host FS
element /cm4/fsn/test/krnl/fs/dummies/cmd_test.c               .../ahaa/LATEST
element /cm4/fsn/test/krnl/fs/fs_test.c                        .../ahaa/LATEST

#####
# MOD_TEST_KRNL_STUBS_V0.0.5 SYNC_DIR=/cm4/fsn/test/krnl/stubs
element /cm4/fsn/test/krnl/stubs/inthandler/intHandler.c     /main/ahaa/LATEST

####
# MOD_DUMMY_AA_V3.1.2 SYNC_DIR=/cm4/fsn/test/prj/co/dummy
element /cm4/fsn/test/prj/co/dummy/application_init_stub.cpp  .../ahaa/LATEST

#####
# was:MOD_XML4USERGUIDE_AA_V4.1.0
#TEMP ROLLBACK 4.4.10
#KM:CLI:element /cm4/tools/BELL/xml/xml4UserGuide/commFunc.xsl .../raleigh_gpon42_bugfix/LATEST
#KM:CLI:element /cm4/tools/BELL/xml/xml4Parser/...            MOD_XML4PARSER_AA_V5.2.0
#KM:CLI:element /cm4/tools/BELL/xml/xml4UserGuide/...      MOD_XML4USERGUIDE_AA_V4.1.0
#KM:CLI:element /cm4/tools/BELL/xml/xmlCommon/...              MOD_XMLCOMMON_AA_V4.0.1

# MOD_XML4USERGUIDE_AA_V5.2.0 SYNC_DIR=/cm4/tools/BELL/xml/xml4UserGuide
#OBSOLETE?!element /cm4/tools/BELL/xml/xml4UserGuide/commFunc.xsl .../raleigh_gpon42_bugfix/LATEST

#####
# MOD_SSH_AA_V5.0.10 SYNC_DIR=/vobs/dsl/interpeak/ssh
element /vobs/dsl/interpeak/ssh/ipcom/include/ipcom_sock.h     .../ahaa/LATEST
element /vobs/dsl/interpeak/ssh/ipcom/port/xapi/src/ipcom_psock.c .../ahaa/LATEST
element /vobs/dsl/interpeak/ssh/ipssh/config/ipssh_config.c    .../ahaa/LATEST
element /vobs/dsl/interpeak/ssh/ipssh/src/ipssh.c              .../ahaa/LATEST
element /vobs/dsl/interpeak/ssh/ipssh/src/ipssh_connection.c   .../ahaa/LATEST

#####
# MIBS

# allow tree build
element /vobs/dsl/mibs/Makefile                                .../ahaa/LATEST

element /vobs/dsl/mibs/ASAM_EQPTCORENT_MIB                     .../ahaa/LATEST
element /vobs/dsl/mibs/ASAM_SYSTEM_MIB                         .../ahaa/LATEST
element /vobs/dsl/mibs/DHCP_MIB                                .../ahaa/LATEST
element /vobs/dsl/mibs/ESAM_802DOT1X_MIB                     .../fdt406/LATEST
element /vobs/dsl/mibs/IGMP_MIB                                .../ahaa/LATEST
element /vobs/dsl/mibs/Plim_mib                                .../ahaa/LATEST
element /vobs/dsl/mibs/QOS_MIB                                 .../ahaa/LATEST
element /vobs/dsl/mibs/RADIUS_MIB                            .../fdt406/LATEST
element /vobs/dsl/mibs/SSH_MIB                                 .../ahaa/LATEST
element /vobs/dsl/mibs/SYSLOG_MIB                              .../ahaa/LATEST
element /vobs/dsl/mibs/asam_traps.smi                          .../ahaa/LATEST

# 4.4 adds
element /vobs/dsl/mibs/DEF-STUBS                       .../ahaa/LATEST # TEMP!
element /vobs/dsl/mibs/IANA-ADDRESS-FAMILY-NUMBERS-MIB         .../ahaa/LATEST
element /vobs/dsl/mibs/IEEE8021_CFM_MIB                        .../ahaa/LATEST
element /vobs/dsl/mibs/IEEE8021_CFM_MIB.smiv2                  .../ahaa/LATEST
element /vobs/dsl/mibs/IF-MIB                                  .../ahaa/LATEST
element /vobs/dsl/mibs/LLDP-MIB                                .../ahaa/LATEST
element /vobs/dsl/mibs/LLDP-MIB.smiv2                          .../ahaa/LATEST
element /vobs/dsl/mibs/TRANSPORT-ADDRESS-MIB                   .../ahaa/LATEST
element /vobs/dsl/mibs/cfm_proprietary.mib                     .../ahaa/LATEST
element /vobs/dsl/mibs/lanx/lanx_all_mibs                      .../ahaa/LATEST

# 4.5 adds
element /vobs/dsl/mibs/ITF_MIB_EXT            RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/ITF-MIB.mib            RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/IANAifType-MIB.mib     RALEIGH_SW_GPON4505_CLI_SPEC_01P01

element /vobs/dsl/mibs/lanx/SMIv1/FsAlarm.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsbridge.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fscfa.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsigs.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsike.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsip.mib    RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsiss.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsla.mib    RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fslanxqos.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsrip.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsrst.mib         .../raleigh_gpon42_temp3/1
element /vobs/dsl/mibs/lanx/SMIv1/fssecv4.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fssnmp2.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsvlan.mib  RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/fsvrf.mib   RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/stdbridge.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/stdether.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/stdrmon.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element       /vobs/dsl/mibs/lanx/stdvlan.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/SMIv1/stdvlan.mib RALEIGH_SW_GPON4505_CLI_SPEC_01P01
element /vobs/dsl/mibs/lanx/stdbridge.mib                           .../ahaa/2

# controlled rollback to 4.4.x
element -file /vobs/dsl/mibs/lanx/...              MOD_GPON_RELEASE_V4.4.1.2.7

#config mgmt
element /vobs/dsl/mibs/all_mibs         .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/mibs/isam_mibs.cs                 .../raleigh_gpon41/LATEST

#### OFLMT ####

#####
# MOD_BLD_OFLMT_AA_V6.0.2 SYNC_DIR=/vobs/esam/build/oflmt/oflmt
#KM45!element -file /vobs/esam/build/oflmt/...                       .../ahaa/LATEST

#### vobs/other ####
##########################################################
# Broadcom SDK Development
# GLT2-A currently uses SDK 5.2.3

# To generate new updated broadcom libaries (this should only be done
# when an update is needed and by the SCM):
#
#  1. 1st port only:
#     cd /vobs/3rdparty/pkg002/build/vxworks-glt2
#
#     2nd port only:
#     cd /vobs/3rdparty/pkg002/build/xapi-glt2a
#
#  2. ct co -nc `find . -type f`
#
#  3. 2nd port only (to generate the wrapper header files):
#     a. cd /vobs/3rdparty/pkg002/export_inc
#     b. cmake [SDK=<pathname>] [TARGET=<name>]
#         by default SDK=/vobs/3rdparty/pkg002 and TARGET=xapi-glt2a
#
#  4. 1st port only:
#     cd /vobs/3rdparty/pkg002/systems/vxworks/glt2
#
#     2nd port only:
#     cd /vobs/3rdparty/pkg002/systems/xapi/glt2a
#  
#  5. cmake (.i.e /usr/atria/bin/clearmake -C gnu)
#  6. cd /vobs/3rdparty/pkg002
#  7. ct mklbtype <label name> (After verifying the new libraries)
#  8. ct mklabel -rec <label name> .
#  9. ct ci -c "<insert comment>" `ct lsco -cview -rec -short`
# 10. uncheckout any file which did not change.
# 11. update the config spec rule below to select the broadcom libraries
#     based upon the new label name.

# TEMP!
element /vobs/3rdparty/pkg002/include/sal/types.h .../raleigh_gpon45_temp1/LATEST #FIXME

# labeled source and (frozen) build outputs for 2nd port.
element /vobs/3rdparty/pkg002/...    MOD_GLT2_BCM_SDK2_V4.4.0.0.0 -nocheckout

# labeled source and (frozen) build outputs for 1st port.
#element /vobs/3rdparty/pkg002/...         GLT2A_BCM_SDK_5.2.3_V0.0.4

###################################################
# Broadcom SDK 5.2.3 development rules for 2nd port
###################################################
#element -dir /vobs/3rdparty/pkg002                     .../raleigh/LATEST
#element /vobs/3rdparty/pkg002/build/...           /main/LATEST
#element /vobs/3rdparty/pkg002/export_inc/...           .../raleigh/LATEST
# 
#element /vobs/3rdparty/pkg002/...   .../raleigh_2nd_port_sdk_523/LATEST
#mkbranch raleigh_2nd_port_sdk_523
#element /vobs/3rdparty/pkg002/...  BROADCOM_SDK_5.2.3 -nocheckout
#element /vobs/3rdparty/pkg002/...  /main/LATEST -nocheckout
#end mkbranch raleigh_2nd_port_sdk_523

###################################################
# Broadcom SDK 5.2.3 development rules for 1st port
###################################################
# NOTE: the raleigh_sdk_523 branch is used for all development from SDK 5.2.3 forward
# as long as the version from broadcom hasn't changed and the changes are good for
# SDK releases 5.2.3 and higher.  The raleigh branch was used for SDK 5.2.1 and the
# changes on this branch are compatible for 5.2.3 as well.
#element /vobs/3rdparty/pkg002/...        .../raleigh_sdk_523/LATEST
#element /vobs/3rdparty/pkg002/...                .../raleigh/LATEST
#mkbranch raleigh_sdk_523
#element /vobs/3rdparty/pkg002/...                BROADCOM_SDK_5.2.3
#element /vobs/3rdparty/pkg002/...                      /main/LATEST
#end mkbranch raleigh_sdk_523

######################################
# Broadcom SDK 5.2.1 development rules
######################################
# NOTE: the raleigh branch is used for all development from SDK 5.2.1 forward as long
# as the version from broadcom hasn't changed and the changes are good for all SDK
# releases.  The raleigh_sdk_521_specific branch is for changes that only apply to
# SDK 5.2.1.
#element /vobs/3rdparty/pkg002/...  .../raleigh_sdk_521_specific/LATEST
#element /vobs/3rdparty/pkg002/...                   .../raleigh/LATEST
#mkbranch raleigh
#element /vobs/3rdparty/pkg002/...                   BROADCOM_SDK_5.2.1
#element /vobs/3rdparty/pkg002/...                         /main/LATEST
#end mkbranch raleigh


#### source01 ####

#####
# was:MOD_ATM2EXPORT_AA_V6.4.1
# MOD_ATM2EXPORT_AA_V7.1.5 SYNC_DIR=/vobs/dsl/source01/Atm2Export
element /vobs/dsl/source01/Atm2Export/export/atmTypes.h  .../ahaa/LATEST

#####
# MOD_ATM2NT_AA_V12.1.3 SYNC_DIR=/vobs/dsl/source01/Atm2Nt
element /vobs/dsl/source01/Atm2Nt/core/headers/ItfMgtHandler.hpp  .../ahaa/LATEST

#### source02 ####

#####
# was:MOD_ALARM_AA_V8.3.1
# MOD_ALARM_AA_V13.2.14 SYNC_DIR=/vobs/dsl/source02/Alarm/handler
element /vobs/dsl/source02/Alarm/handler/alarm.c               .../ahaa/LATEST
element /vobs/dsl/source02/Alarm/handler/alrm_hdlr.h           .../ahaa/LATEST
element /vobs/dsl/source02/Alarm/handler/export/alarm.h        .../ahaa/LATEST
element /vobs/dsl/source02/Alarm/handler/export/alrm_init.h    .../ahaa/LATEST
element /vobs/dsl/source02/Alarm/handler/export/alrm_types.h   .../ahaa/LATEST

element /vobs/dsl/source02/Alarm/sst/...                    .../raleigh/LATEST
element /vobs/dsl/source02/Alarm/sst/...        /main/LATEST -mkbranch raleigh

#####
# MOD_ALIVEPING_AA_V1.85.1 SYNC_DIR=/vobs/dsl/source02/AlivePing
element /vobs/dsl/source02/AlivePing/AlivePing.cpp  .../ahaa/LATEST

#####
# MOD_ASAMPROXY_AA_V1.1.3 SYNC_DIR=/vobs/dsl/source02/AsamProxy
#rules needed for Reconfigurable Mgnt Vlans (BDFam30598)
element /vobs/dsl/source02/AsamProxy/asamProxyMain.c  .../ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_BLDUMMYGANTC_AA_V3.1.0 SYNC_DIR=/vobs/dsl/source02/BlDummyGantc
# support M8270
element /vobs/dsl/source02/BlDummyGantc/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_BOOTLDRESAMBCMLSM_AA_V4.0.5 SYNC_DIR=/vobs/dsl/source02/BootLdrEsamBCMLsm
element /vobs/dsl/source02/BootLdrEsamBCMLsm/source/classes/DownloadRecordEth.cc .../raleigh_gpon45_temp1/LATEST #FIXME not used in OSW
element -file /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt2-a/... .../ahaa/LATEST
element -file /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt2-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt2-a/... /main/LATEST
element -file /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt4-a/... .../ahaa/LATEST
element -file /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt4-a/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source02/BootLdrEsamBCMLsm/board/glt4-a/... /main/LATEST

#####
# was:MOD_CONFIGDATACOMMON_AA_V3.2.4
# MOD_CONFIGDATACOMMON_AA_V3.3.6 SYNC_DIR=/vobs/dsl/source02/ConfigDataCommon
# conditionally fix ROT cipher
# (bugfix workaround: read-only file not found)
element /vobs/dsl/source02/ConfigDataCommon/sources/InstallReadonlyData.cpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# was:MOD_CONFIGDATAXML_AA_V4.13.7
# MOD_CONFIGDATAXML_AA_V8.10.25 SYNC_DIR=/vobs/dsl/source02/ConfigDataXml/src
element /vobs/dsl/source02/ConfigDataXml/src/Makefile          .../ahaa/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.5/... .../ahaa/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.5/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source02/ConfigDataXml/releaseFGU4.5/...  /main/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.4/... .../ahaa/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.4/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source02/ConfigDataXml/releaseFGU4.4/...  /main/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.3/... .../ahaa/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.3/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source02/ConfigDataXml/releaseFGU4.3/...  /main/LATEST
element -file /vobs/dsl/source02/ConfigDataXml/releaseFGU4.2/... .../ahaa/LATEST
element -dir  /vobs/dsl/source02/ConfigDataXml/releaseFGU4.2/...  /main/LATEST

#####
# MOD_CPULOADCONTROL_AA_V2.1.0 SYNC_DIR=/vobs/dsl/source02/CpuLoadControl
element /vobs/dsl/source02/CpuLoadControl/Makefile             .../ahaa/LATEST
element /vobs/dsl/source02/CpuLoadControl/cpuload_monitor.cpp  .../ahaa/LATEST
element /vobs/dsl/source02/CpuLoadControl/load_control.cpp     .../ahaa/LATEST

#####
# MOD_CPUPQ2PROAPI_AA_V1.0.0 SYNC_DIR=/vobs/dsl/source02/CPUPQ2PROApi
element /vobs/dsl/source02/CPUPQ2PROApi/m8260_api.c          /main/ahaa/LATEST

#####
# MOD_CPUPQ2PROERROR_AA_V1.0.3 SYNC_DIR=/vobs/dsl/source02/CPUPQ2PROError
element /vobs/dsl/source02/CPUPQ2PROError/pq2_error.c          .../ahaa/LATEST
element /vobs/dsl/source02/CPUPQ2PROError/pq2_exception.c      .../ahaa/LATEST

#####
# MOD_ETHHLDRV_AA_V6.4.3 SYNC_DIR=/vobs/dsl/source02/EthHlDrv/.DeliveryList
element -dir /vobs/dsl/source02/EthHlDrv                               /main/5
element /vobs/dsl/source02/EthHlDrv/Config.cpp                 .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/DummyLlEthDev.hpp          .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/EthDevice.cpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/EthDevice.hpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/EthHlCb.cpp                .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/EthHlCb.h                  .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/FccMiiAccess.hpp           .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/LlEthDevTD.cpp             .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/LlEthDevTD.hpp             .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/MacConfig.cpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/Makefile                   .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/MiiAccessItf.cpp           .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/MiiAccessItf.hpp           .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/Trace.hpp                  .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/Wrapper.cpp                .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/Wrapper.hpp                .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/ethdDebug.cpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthHlDrv/DevBufMngt.hpp             .../ahaa/LATEST

# other
#KM45!element /vobs/dsl/source02/EthHlDrv/MiiAccess.hpp       .../ahaa/LATEST

#####
# MOD_ETHHLLLITF_AA_V5.1.0 SYNC_DIR=/vobs/dsl/source02/EthHlLlItf
element /vobs/dsl/source02/EthHlLlItf/export/Config.hpp        .../ahaa/LATEST
element /vobs/dsl/source02/EthHlLlItf/export/LlDevItf.hpp      .../ahaa/LATEST

#####
# MOD_ETHLLDRV_AA_V2.3.4 SYNC_DIR=/vobs/dsl/source02/EthLlDrv
element /vobs/dsl/source02/EthLlDrv/HostCfg.cpp                .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthDbg.cpp               .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthDev.cpp               .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthDev.hpp               .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthDrv.cpp               .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthDrv.hpp               .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthHost.cpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/LlEthHost.hpp              .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/Makefile                   .../ahaa/LATEST
element /vobs/dsl/source02/EthLlDrv/PseudoEthDrv.cpp           .../ahaa/LATEST

#####
# MOD_FILETRANSFER_AA_V1.2.10 SYNC_DIR=/vobs/dsl/source02/FileTransfer
element /vobs/dsl/source02/FileTransfer/FileTransfer_snmpMapper.c .../ahaa/LATEST

#####
# MOD_FLHCOMMON_V
# ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source02/FlhCommon
# allow more than 256 clients
element /vobs/dsl/source02/FlhCommon/export/flh.h              .../ahaa/LATEST
element /vobs/dsl/source02/FlhCommon/flh.c                     .../ahaa/LATEST
element /vobs/dsl/source02/FlhCommon/flh_intern.h              .../ahaa/LATEST

#####
# MOD_HOSTNTHWSIMULATION_AA_V2.0.4 SYNC_DIR=/vobs/dsl/source02/HostNtHwSimulation
# Stop error logs associated with ACU
#KM45!element /vobs/dsl/source02/HostNtHwSimulation/source/HostNtHwSimulation.cpp .../raleigh_gpon42_temp1/LATEST

####
# MOD_INITLT_AA_V4.1.7 SYNC_DIR=/vobs/dsl/source02/InitLt
element /vobs/dsl/source02/InitLt/platform_init.cpp            .../ahaa/LATEST

####
# MOD_INITNT_AA_V12.2.1 SYNC_DIR=/vobs/dsl/source02/InitNt/app
element /vobs/dsl/source02/InitNt/Makefile                     .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/NTInit.cpp               .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/NTInit.hpp               .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/application_init.cpp     .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/application_init.hpp     .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/communication_init.cpp .../ahaa/LATEST 
element /vobs/dsl/source02/InitNt/app/hds_init.cpp .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/app/platform_init.cpp .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/export/initLanxItf.h         .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/interfaces/SyncIfc.cpp       .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/interfaces/initLanxItf.c     .../ahaa/LATEST
element /vobs/dsl/source02/InitNt/interfaces/RedcyState.cpp    .../ahaa/LATEST

####
# was:MOD_IP_AA_V5.0.2
# MOD_IP_AA_V5.4.11 SYNC_DIR=/vobs/dsl/source02/IP
element /vobs/dsl/source02/IP/export/ipadr.h .../ahaa/LATEST
element /vobs/dsl/source02/IP/etherarp.cpp .../ahaa/LATEST
element /vobs/dsl/source02/IP/ip.cpp .../ahaa/LATEST
element /vobs/dsl/source02/IP/ipvlan.cpp .../ahaa/LATEST
element /vobs/dsl/source02/IP/ipadr.cpp .../ahaa/LATEST
element /vobs/dsl/source02/IP/route.cpp .../ahaa/LATEST
element /vobs/dsl/source02/IP/subnet.cpp .../ahaa/LATEST
#KM45!element -file /vobs/dsl/source02/IP/...                        .../ahaa/LATEST


####
# MOD_LICENSEKEYMONITOR_AA_V4.1.0 SYNC_DIR=/vobs/dsl/source02/LicenseKeyMonitor
element -dir /vobs/dsl/source02/LicenseKeyMonitor/sources              /main/4
element -dir /vobs/dsl/source02/LicenseKeyMonitor/export               /main/3
element /vobs/dsl/source02/LicenseKeyMonitor/export/LicenseKeyMonMgr.hpp .../ahaa/LATEST
# Raleigh new
element /vobs/dsl/source02/LicenseKeyMonitor/export/LicenseDM.hpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/LicenseDM.cpp .../ahaa/LATEST
# Baseline mod
element /vobs/dsl/source02/LicenseKeyMonitor/export/LicensePvcLineMapping.h .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/Makefile  .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/asamSystemLicenseMgmt_minimap.cpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/asamSystemLicenseMgmt_minimap.hpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/asamSystemLicenseMgmt_minimap_Implement.hpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/licenseKeyMonMapper.cpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/sources/licenseKeyMonMgr.cpp .../ahaa/LATEST
element /vobs/dsl/source02/LicenseKeyMonitor/export/LicenseKeyMonMgr.hpp .../ahaa/LATEST

#####
# was:MOD_NLETH_AA_V6.0.4
# MOD_NLETH_AA_V7.1.2 SYNC_DIR=/vobs/dsl/source02/NlEth
element /vobs/dsl/source02/NlEth/export/ni_eth.h .../ahaa/LATEST
element /vobs/dsl/source02/NlEth/export/OntSession.h .../ahaa/LATEST #FIXME
element /vobs/dsl/source02/NlEth/export/ethd.h .../ahaa/LATEST
element /vobs/dsl/source02/NlEth/Makefile .../ahaa/LATEST
element /vobs/dsl/source02/NlEth/OntSession.c .../ahaa/LATEST
element /vobs/dsl/source02/NlEth/eth_dfw.cpp .../ahaa/LATEST
element /vobs/dsl/source02/NlEth/ni_eth.cpp .../ahaa/LATEST
#KM45!element /vobs/dsl/source02/NlEth/...                           .../ahaa/LATEST

#####
# was:MOD_NLNIF_AA_V5.2.0
# MOD_NLNIF_AA_V6.1.1 SYNC_DIR=/vobs/dsl/source02/NlNif
element /vobs/dsl/source02/NlNif/export/cid.h           .../ahaa/LATEST #FIXME
element /vobs/dsl/source02/NlNif/ni.cpp .../ahaa/LATEST
#KM45!element /vobs/dsl/source02/NlNif/...                           .../ahaa/LATEST

#####
# MOD_NLNMISC_AA_V4.1.1 SYNC_DIR=/vobs/dsl/source02/NlNmisc
element /vobs/dsl/source02/NlNmisc/osx.c                     /main/ahaa/LATEST

####
# MOD_PMHCOMMON_AA_V5.2.1 SYNC_DIR=/vobs/dsl/source02/PmhCommon
element /vobs/dsl/source02/PmhCommon/pmh_tmr.c                 .../ahaa/LATEST
element /vobs/dsl/source02/PmhCommon/pmh_cntr.c                .../ahaa/LATEST

#####
#JOB02.008 MOD_QOSMGNTLSM_AA_V4.0.7 SYNC_DIR=/vobs/dsl/source02/QoSMgntLsm
#TEMP? ROLLBACK TO 4.4.10
element /vobs/dsl/source02/QoSMgntLsm/...                      .../ahaa/LATEST
# rollback
element /vobs/dsl/source02/QoSMgntLsm/...             MOD_QOSMGNTLSM_AA_V2.1.6

#####
# (ISAM ref) MOD_QOSMGNTNT_AA_V8.3.23
# MOD_QOSMGNTNT_AA_V6.4.7 SYNC_xxx=/vobs/dsl/source02/QoSMgntNt
element -file /vobs/dsl/source02/QoSMgntNt/...                 .../ahaa/LATEST
# rollback
element /vobs/dsl/source02/QoSMgntNt/...              MOD_QOSMGNTNT_AA_V3.0.11

#####
# MOD_RACK_AA_V7.0.1 SYNC_DIR=/vobs/dsl/source02/Rack
element /vobs/dsl/source02/Rack/rack_dbg.cpp                   .../ahaa/LATEST
element /vobs/dsl/source02/Rack/itl.cpp                        .../ahaa/LATEST

#####
# MOD_SFTP_AA_V4.1.1 SYNC_DIR=/vobs/dsl/source02/SFTP
element /vobs/dsl/source02/SFTP/src/SftpClient.c               .../ahaa/LATEST
element /vobs/dsl/source02/SFTP/src/SftpMgnt.c                 .../ahaa/LATEST

#####
# MOD_SOCKET_AA_V10.0.7 SYNC_DIR=/vobs/dsl/source02/Socket
element /vobs/dsl/source02/Socket/export/in.h                /main/ahaa/LATEST
# M8270
element /vobs/dsl/source02/Socket/socket.cpp    .../raleigh_gpon45_bugfix/LATEST

#####
# MOD_SSH_GLUE_AA_V6.0.8 SYNC_DIR=/vobs/dsl/source02/SSH_Glue
element /vobs/dsl/source02/SSH_Glue/SSH_Init.c                 .../ahaa/LATEST
element /vobs/dsl/source02/SSH_Glue/export/SSH_Common.h        .../ahaa/LATEST
element /vobs/dsl/source02/SSH_Glue/mapper/SSH_Scalar.c        .../ahaa/LATEST
element /vobs/dsl/source02/SSH_Glue/... 	 MOD_SSH_GLUE_AH_V4.5.0.1

#####
# MOD_SSHTL1AGENT_AA_V4.0.2 SYNC_DIR=/vobs/dsl/source02/SshTL1Agent
element /vobs/dsl/source02/SshTL1Agent/...              MOD_SSHTL1AGENT_AH_V4.5.0.1

#####
# was:MOD_SYSLOGMGNT_AA_V3.1.4
# MOD_SYSLOGMGNT_AA_V3.1.5 SYNC_DIR=/vobs/dsl/source02/SyslogMgnt
element -dir /vobs/dsl/source02/SyslogMgnt/export                     /main/12
element -dir /vobs/dsl/source02/SyslogMgnt/mgnt                       /main/10
#later:
#element /vobs/dsl/source02/SyslogMgnt/...                     .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/Makefile  			   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/dispatch/SysLogDispatch.cpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogConfiguredObject.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogDispatch.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogInit.hpp    .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogKeyFileMgnt.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogManager.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogMgnt.hpp    .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogProxy.hpp   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogServer.hpp  .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogServerTable.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogSyncMsg.hpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/SysLogUpload.hpp  .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/export/sysloginterface.h .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mapper/SysLogMapper.cpp  .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogConfig.cpp    .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogInit.cpp	   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogInterface.cpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogKeyFileMgnt.cpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogManager.cpp   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogMgnt.cpp	   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogProxy.cpp     .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogServer.cpp    .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogServerTable.cpp .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogSyncMsg.cpp   .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogTrace.cpp     .../ahaa/LATEST
element /vobs/dsl/source02/SyslogMgnt/mgnt/SysLogUpload.cpp    .../ahaa/LATEST

#####
# MOD_USERIPMGNTCOMMON_AA_V9.1.15 SYNC_DIR=/vobs/dsl/source02/UserIpMgntCommon
element /vobs/dsl/source02/UserIpMgntCommon/IPoXitfTable.cpp  .../ahaa/LATEST
element /vobs/dsl/source02/UserIpMgntCommon/export/IPlimits.h  .../ahaa/LATEST

#####
# MOD_USERIPMGNTNT_AA_V9.1.13 SYNC_DIR=/vobs/dsl/source02/UserIpMgntNt
element -file /vobs/dsl/source02/UserIpMgntNt/...              .../ahaa/LATEST

#### source03 ####

#####
# MOD_ACUCTRL_AA_V6.0.9 SYNC_DIR=/vobs/dsl/source03/AcuCtrl
# conditionalize SML alarms
element /vobs/dsl/source03/AcuCtrl/nt/acuDrv/AcuDriver.cpp     .../ahaa/LATEST
element /vobs/dsl/source03/AcuCtrl/nt/acuDrv/AcuDriver.hpp     .../ahaa/LATEST
# fix daughter interface
element /vobs/dsl/source03/AcuCtrl/nt/acuMgnt/AcuManager.cpp   .../ahaa/LATEST
element /vobs/dsl/source03/AcuCtrl/nt/acuMgnt/AcuManager.hpp   .../ahaa/LATEST

#####
# MOD_ASAMDLD_AA_V2.5.5 SYNC_DIR=/vobs/dsl/source03/AsamDld
element /vobs/dsl/source03/AsamDld/source/classes/DldDebug.cc  .../ahaa/LATEST
element /vobs/dsl/source03/AsamDld/source/classes/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/AsamDld/source/classes/Manager.cc  .../ahaa/LATEST
element /vobs/dsl/source03/AsamDld/source/messages/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/AsamDld/source/process/Makefile  .../ahaa/LATEST

#####
# was:MOD_ASAMIDCONV_AA_V4.0.0 
# MOD_ASAMIDCONV_AA_V5.3.4 SYNC_DIR=/vobs/dsl/source03/AsamIdConv
# default hardware type
element /vobs/dsl/source03/AsamIdConv/IdcvTraceAndDebug.cpp  .../ahaa/LATEST
# FTTU methods
element /vobs/dsl/source03/AsamIdConv/export/indexConv.hpp  .../ahaa/LATEST
element /vobs/dsl/source03/AsamIdConv/indexConv.cpp  .../ahaa/LATEST

#####
# MOD_CAPABILITYMGR_AA_V7.8.11 SYNC_DIR=/vobs/dsl/source03/CapabilityMgr
element /vobs/dsl/source03/CapabilityMgr/srclt/CapabilityMgrLtSubsystem.cpp  .../ahaa/LATEST

#####
#JOB03.002 MOD_COMMMEDIUMMONITOR_AA_V3.0.8 SYNC_DIR=/vobs/dsl/source03/CommMediumMonitor
element /vobs/dsl/source03/CommMediumMonitor/app/CMMAlivePing.cpp   /main/ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_DEFENSE_AA_V6.1.0 SYNC_DIR=/vobs/dsl/source03/Defense
# support ehnt-a
element /vobs/dsl/source03/Defense/common/export/DefenseConfig.hpp  .../ahaa/LATEST

#####
# was:MOD_EQPTCOMMON_AA_V8.2.0
#JOB03.004 MOD_EQPTCOMMON_AA_V11.5.3 SYNC_DIR=/vobs/dsl/source03/EqptCommon
# stop duplicate definitions
element /vobs/dsl/source03/EqptCommon/export/eqptCommonItf.h .../ahaa/LATEST
# add hardware types
element /vobs/dsl/source03/EqptCommon/data/types/boardTypes.hh .../ahaa/LATEST
element /vobs/dsl/source03/EqptCommon/data/types/functionalTypes.hh .../ahaa/LATEST
element /vobs/dsl/source03/EqptCommon/data/types/holderTypes.hh .../ahaa/LATEST

#####
# MOD_EQPTCORECOMMON_AA_V8.2.6 SYNC_DIR=/vobs/dsl/source03/EqptCoreCommon
element /vobs/dsl/source03/EqptCoreCommon/export/TraceAndDebugCommand.hh /main/aaaa/2 #FIXME!

#####
# was:MOD_EQPTCOREEXTLSM_AA_V8.2.0
# MOD_EQPTCOREEXTLSM_AA_V11.4.3 SYNC_DIR=/vobs/dsl/source03/EqptCoreExtLsm
element /vobs/dsl/source03/EqptCoreExtLsm/app/global/BoardNumberMapping.cc .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreExtLsm/app/interfaces/Initialization.cc .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_EQPTCORENT_AA_V11.1.31 SYNC_DIR=/vobs/dsl/source03/EqptCoreNt
#
element /vobs/dsl/source03/EqptCoreNt/app/alarm/PluginAlarmStatus.cpp  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/alarm/RackAlarmStatus.cpp  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/alarm/RackAlarmStatus.hpp  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/boards/Board.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/boards/Lsm.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/boards/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/boards/Nt.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/boards/SwBoard.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/callbacks/AcuEqptSubscriber.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/callbacks/AliveChanges.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/callbacks/BoardChanges.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/callbacks/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/factories/BoardFactory.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/factories/FactoryManager.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/global/AsamBuilder.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/global/EqptMemory.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/global/ItfCollection.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/global/ItfCollection.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/holders/Asam.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/holders/Asam.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/holders/ProtectedShelfConversion.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/holders/Shelf.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/IndexConversion.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/IndexConversion.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/Initialization.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/NewBoardTypesRegistration.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/PeerNt.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/interfaces/Restart.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/AsamRestartHandler.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/AsamRestartHandler.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/EsamLanxState.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/EscalationHandler.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/EscalationHandler.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/states/Makefile  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/timers/EqptTimeOut.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/timers/NtRestartDelayTimer.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/traceAndDebug/BoardCommands.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/app/traceAndDebug/BoardCommands.hh  .../ahaa/LATEST
element /vobs/dsl/source03/EqptCoreNt/mapper/CoreNtMapper.cc  .../ahaa/LATEST

#####
## CRITICAL: Alive message format has been changed from ISAM.
## Dependencies between different boards, binaries, releases.
##
# MOD_EQPTCTRLCOMMON_AA_V4.1.7 SYNC_DIR=/vobs/dsl/source03/EqptCtrlCommon
element /vobs/dsl/source03/EqptCtrlCommon/export/AliveMessages.hpp .../ahaa/LATEST

#####
## CRITICAL: Alive message format has been changed from ISAM.
## Dependencies between different boards, binaries, releases.
##
# MOD_EQPTCTRLNT_AA_V6.1.6 SYNC_DIR=/vobs/dsl/source03/EqptCtrlNt
element /vobs/dsl/source03/EqptCtrlNt/centre/System.cpp        .../ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_EQPTEDSEPROXY_AA_V4.1.6 SYNC_DIR=/vobs/dsl/source03/EqptEdseProxy
# conditionally disable ACU code
element /vobs/dsl/source03/EqptEdseProxy/app/EdseProxyReport.cpp  .../ahaa/LATEST

#####
# MOD_EQPTEXPANDERMGNT_AA_V3.2.7 SYNC_DIR=/vobs/dsl/source03/EqptExpanderMgnt
# conditionalize SFP items
element /vobs/dsl/source03/EqptExpanderMgnt/EqptExpanderSem.cpp  .../ahaa/LATEST

#####
# MOD_EXTALMCONF_AA_V3.0.5 SYNC_DIR=/vobs/dsl/source03/EXTALMCONF
element /vobs/dsl/source03/EXTALMCONF/ExtAlmConfData.cc  .../ahaa/LATEST
element /vobs/dsl/source03/EXTALMCONF/ExtAlmConfProfile.cpp  .../ahaa/LATEST

####
# was:ISR24_FGN30_18__REBL
# MOD_FIRMWAREMGNT_AA_V3.1.8 SYNC_DIR=/vobs/dsl/source03/FirmwareMgnt
element /vobs/dsl/source03/FirmwareMgnt/app/Core.cpp /main/aaaa/raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source03/FirmwareMgnt/app/Core.hpp /main/ahaa/raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source03/FirmwareMgnt/idl/FirmwareMgntCore.idl .../ahaa/LATEST

#####
# was:MOD_INFRANT_AA_V6.5.0
# MOD_INFRANT_AA_V8.1.9 SYNC_DIR=/vobs/dsl/source03/InfraNt
element /vobs/dsl/source03/InfraNt/app/FttnLanxMapping.cpp  .../ahaa/LATEST
element /vobs/dsl/source03/InfraNt/app/InfraOamMgnt.cpp  .../ahaa/LATEST
#rules needed for Reconfigurable Mgnt Vlans (BDFam30598)
element /vobs/dsl/source03/InfraNt/app/InfraOamMgnt.hh  .../ahaa/LATEST
element /vobs/dsl/source03/InfraNt/idl/infra.idl               .../ahaa/LATEST
element /vobs/dsl/source03/InfraNt/interfaces/InfraOamCom.cpp  .../ahaa/LATEST
element /vobs/dsl/source03/InfraNt/interfaces/export/InfraOamCom.hh .../ahaa/LATEST

#####
# MOD_INITCOMMON_AA_V2.2.1 SYNC_DIR=/vobs/dsl/source03/InitCommon
element /vobs/dsl/source03/InitCommon/initSignal.c           /main/ahaa/LATEST

#####
# MOD_INTERFACES_AA_V12.2.39 SYNC_DIR=/vobs/dsl/source03/Interfaces
element -file /vobs/dsl/source03/Interfaces/...                .../ahaa/LATEST

####
#JOB03.009 MOD_INTERFACESCOMMON_AA_V5.4.1 SYNC_DIR=/vobs/dsl/source03/InterfacesCommon
element -file /vobs/dsl/source03/InterfacesCommon/...          .../ahaa/LATEST

####
# was:MOD_INTERFACESLT_AA_V6.1.0
#JOB03.010 MOD_INTERFACESLT_AA_V8.4.10 SYNC_DIR=/vobs/dsl/source03/InterfacesLt
element /vobs/dsl/source03/InterfacesLt/app/ItfmCustomerId.cpp  .../ahaa/LATEST
element -file /vobs/dsl/source03/InterfacesLt/...              .../ahaa/LATEST

####
# was:MOD_LANXMGNT_AA_V5.2.0
# MOD_LANXMGNT_AA_V10.1.8 SYNC_DIR=/vobs/dsl/source03/LanxMgnt
element -dir /vobs/dsl/source03/LanxMgnt/export                        /main/6
element -file /vobs/dsl/source03/LanxMgnt/...                  .../ahaa/LATEST

####
# was MOD_LANXPROXY_AA_V2.0.28
#JOB03.012 ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source03/LanxProxy
element -file /vobs/dsl/source03/LanxProxy/...                 .../ahaa/LATEST

#####
# MOD_LLUMGNTNT_AA_V2.3.5 SYNC_DIR=/vobs/dsl/source03/LLUMgntNt
# remove duplicate defines
element /vobs/dsl/source03/LLUMgntNt/export/LLUMgrDefines.h .../raleigh_gpon45_bugfix/LATEST

#####
# MOD_MTA_NT_AA_V7.1.13 SYNC_DIR=/vobs/dsl/source03/MTA_NT
# remove hard-coded eant-a
element /vobs/dsl/source03/MTA_NT/app/MtaTestApplItf.h .../raleigh_gpon45_bugfix/LATEST

#####
# was:MOD_REDCY_APS_AA_V1.0.7 
# ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source03/REDCY_APS
element /vobs/dsl/source03/REDCY_APS/app/ApsCore.cpp           .../ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_REDCY_BPS_AA_V3.0.1 SYNC_DIR=/vobs/dsl/source03/REDCY_BPS
#element /vobs/dsl/source03/REDCY_BPS/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME
element -file /vobs/dsl/source03/REDCY_BPS/...                 .../ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL 
# MOD_REDCY_PROTMGNT_AA_V5.1.6 SYNC_DIR=/vobs/dsl/source03/REDCY_protMgnt
element -file /vobs/dsl/source03/REDCY_protMgnt/...            .../ahaa/LATEST

#####
# was:MOD_REDCY_SWOLO_AA_V2.0.17 
# MOD_REDCY_SWOLO_AA_V6.1.6 SYNC_DIR=/vobs/dsl/source03/REDCY_swolo
#element /vobs/dsl/source03/REDCY_swolo/engine/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/REDCY_swolo/engineResult/SwitchReason.cpp .../ahaa/LATEST #FIXME
#element /vobs/dsl/source03/REDCY_swolo/engineResult/SwitchReason.hpp .../ahaa/LATEST
element -file /vobs/dsl/source03/REDCY_swolo/...               .../ahaa/LATEST

#####
#JOB03.019 MOD_REDCY_SYNCHRONIZER_AA_V2.0.13 SYNC_DIR=/vobs/dsl/source03/REDCY_synchronizer
element /vobs/dsl/source03/REDCY_synchronizer/Makefile .../ahaa/LATEST
element /vobs/dsl/source03/REDCY_synchronizer/app/SynchronizerCore.cpp .../ahaa/LATEST
element /vobs/dsl/source03/REDCY_synchronizer/app/SynchronizerCore.hpp .../ahaa/LATEST
element /vobs/dsl/source03/REDCY_synchronizer/app/SynchronizerInterface.cpp .../ahaa/LATEST
element /vobs/dsl/source03/REDCY_synchronizer/app/SynchronizerLanxEvents.cpp .../ahaa/LATEST
element /vobs/dsl/source03/REDCY_synchronizer/app/SynchronizerInit.cpp .../ahaa/LATEST

#####
# MOD_RELAYMGNTNT_AA_V1.3.1 SYNC_DIR=/vobs/dsl/source03/RelayMgntNt
element /vobs/dsl/source03/RelayMgntNt/app/TAURelayItf.hpp  .../ahaa/LATEST


####
#JOB03.020 MOD_SWBMGNT_AA_V1.1.1 SYNC_DIR=/vobs/dsl/source03/SwBMgnt
element /vobs/dsl/source03/SwBMgnt/nt/LocalIncludes  .../ahaa/LATEST
element /vobs/dsl/source03/SwBMgnt/nt/app/SwBoardTraceAndDebug.cc .../ahaa/LATEST
element /vobs/dsl/source03/SwBMgnt/nt/idl/SwCfg.idl            .../ahaa/LATEST
element /vobs/dsl/source03/SwBMgnt/nt/interfaces/SwCfg.cc      .../ahaa/LATEST
element /vobs/dsl/source03/SwBMgnt/nt/interfaces/SwCfg.hh      .../ahaa/LATEST
#KM45!element -file /vobs/dsl/source03/SwBMgnt/...                   .../ahaa/LATEST

####
# was:MOD_SWM_AA_V6.0.1
#JOB03.019 MOD_SWM_AA_V8.3.7 SYNC_DIR=/vobs/dsl/source03/Swm

#element /vobs/dsl/source03/Swm/dbfilemgnt/SwmDBFLanxHook.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/SwmDBFMgnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/SwmDBFSnmp.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/SwmDBFTransfer.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/export/SwmDBFLanxHook.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/export/SwmDBFSnmp.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/dbfilemgnt/export/SwmDBFTransfer.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/export/TaskClassIds_SwMgnt.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/filemgnt/SwmFMFileMgnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/filemgnt/export/SwmFMFileMgnt.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/oswptrees/SwmOSWPDirHook.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source03/Swm/oswptrees/SwmOSWPSnmp.cpp .../raleigh_gpon42_bugfix/LATEST #FIXME
#element /vobs/dsl/source03/Swm/oswptrees/SwmOSWPTrees.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/oswptrees/export/SwmOSWPTrees.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source03/Swm/parser/langdef/SwmPARSSyntax.lex .../raleigh_gpon42_bugfix/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/SwmSPMEquipSWMgnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/SwmSPMPktMgnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/SwmSPMSnmp.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/export/SwmSPMEquipSWMgnt.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/export/SwmSPMError.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/export/SwmSPMPktMgnt.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/export/SwmSPMSnmp.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/gen/SwmSPMIniItf.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/gen/SwmSPMIniItf.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/statemachine/SwmSPMInitStartup.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/swpktmgnt/statemachine/SwmSPMState.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/syncmgnt/SyncMgr.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
#element /vobs/dsl/source03/Swm/export/SwmConfig.h              .../ahaa/LATEST
#element /vobs/dsl/source03/Swm/swpktmgnt/export/SwmSPMDbg.hpp  .../ahaa/LATEST
#element /vobs/dsl/source03/Swm/swpktmgnt/idl/SwmSPMPktMgnt.idl .../ahaa/LATEST
#element /vobs/dsl/source03/Swm/swpktmgnt/statemachine/SwmSPMInitStartup.hpp  .../ahaa/LATEST
#element /vobs/dsl/source03/Swm/syncmgnt/SyncMgr.hpp            .../ahaa/LATEST

element -file /vobs/dsl/source03/Swm/...                            .../ahaa/LATEST

#####
# MOD_TESTMGNTNT_AA_V1.3.9 SYNC_DIR=/vobs/dsl/source03/TestMgntNt
# stop crash in error print (now not reached)
element /vobs/dsl/source03/TestMgntNt/app/ITSCModuleMgrCb.cpp .../raleigh_gpon45_bugfix/LATEST #FIXME

#### source04 ####

#####
# MOD_ALARMEVENTHDS_AA_V6.1.3 SYNC_DIR=/vobs/dsl/source04/AlarmEventHds
element /vobs/dsl/source04/AlarmEventHds/export/AlarmEventHandlingNt.hpp .../ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/board_independent/SwIntrSource.cpp /main/ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/board_independent/SwIntrSource.hpp /main/ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/board_independent/SwIntrSource8.cpp /main/ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/board_independent/SwTimer.cpp /main/ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/board_independent/XapiTimer.cpp /main/ahaa/LATEST
element /vobs/dsl/source04/AlarmEventHds/private/nt/AlarmEventHandlingNt.cpp .../ahaa/LATEST # DOUBLE-CHECK

#####
# MOD_BSPDEVDDRPQ2PRO_AA_V1.1.3 SYNC_DIR=/vobs/dsl/source04/BspDevDdrPq2Pro
element /vobs/dsl/source04/BspDevDdrPq2Pro/ddr.c               .../ahaa/LATEST
element /vobs/dsl/source04/BspDevDdrPq2Pro/export/ddr.h        .../ahaa/LATEST
element /vobs/dsl/source04/BspDevDdrPq2Pro/export/ddr_ext.h    .../ahaa/LATEST

#####
# MOD_BSPDEVPITPQ2PRO_AA_V1.0.3 SYNC_DIR=/vobs/dsl/source04/BspDevPitPq2Pro
element /vobs/dsl/source04/BspDevPitPq2Pro/mpc_8347_pit.c      .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPitPq2Pro/export/mpc_8347_pit.h .../ahaa/LATEST

#####
# MOD_BSPDEVPQ2PRO_AA_V1.0.17 SYNC_DIR=/vobs/dsl/source04/BspDevPq2Pro/dprmm.c
element -dir /vobs/dsl/source04/BspDevPq2Pro                          /main/16
element -dir /vobs/dsl/source04/BspDevPq2Pro/export                   /main/18
element /vobs/dsl/source04/BspDevPq2Pro/Makefile               .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/cpmRiscTimers.c        .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/i2c_pq2pro.c           .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_8347_region.c      .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_8347_vector.s      .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_hidx.s             .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_io_ports.c         .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_io_ports_init.c    .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_isr.c              .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_lbc.c              .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_region.c           .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_siu.c              .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/mpc_vectors.s          .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/quicc_ucc.c            .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/reset_config.s         .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/i2c_pq2pro.h    .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_cfg.h  .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_config.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_cpm.h  .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_cpm_risc_timers.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_io_ports.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_mem_ctrl.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_region.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_8347_siu.h  .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_clk_reg_init.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_isr_itf.h   .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/mpc_lbc_reg_init.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevPq2Pro/export/quicc_mmap.h    .../ahaa/LATEST

element -file /vobs/dsl/source04/BspDevPq2Pro/...              .../ahaa/LATEST

#####
# MOD_BSPDEVUARTPQ2PRO_AA_V1.0.7 SYNC_DIR=/vobs/dsl/source04/BspDevUartPq2Pro/.DeliveryList
element -dir /vobs/dsl/source04/BspDevUartPq2Pro                       /main/6
element -dir /vobs/dsl/source04/BspDevUartPq2Pro/export                /main/5
element /vobs/dsl/source04/BspDevUartPq2Pro/Makefile           .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/16c552.c           .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/scc.c              .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/uartUcc.c          .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/uartUcc.h          .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/export/mpc_8347_uart.h .../ahaa/LATEST
element /vobs/dsl/source04/BspDevUartPq2Pro/export/quicc_uartUcc.h .../ahaa/LATEST

#####
# was:MOD_BSP_PQ2_MMU_AA_V1.0.3
# ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source04/BspPq2Mmu
element /vobs/dsl/source04/BspPq2Mmu/mmuImpl/mpc_mmu.c         .../ahaa/LATEST

#####
# MOD_BSPPQ2PROCO_AA_V1.0.2 SYNC_DIR=/vobs/dsl/source04/BspPq2ProCo
element /vobs/dsl/source04/BspPq2ProCo/export/asmmacros.h    /main/ahaa/LATEST
element /vobs/dsl/source04/BspPq2ProCo/export/mpc_8347_mmap.h  .../ahaa/LATEST

#####
# MOD_BSPPQ2PRODEBUG_AA_V1.0.2 SYNC_DIR=/vobs/dsl/source04/BspPq2ProDebug
element /vobs/dsl/source04/BspPq2ProDebug/bsp_dbg.c .../ahaa/LATEST

#####
# MOD_BSPPQ2PROERR_AA_V1.0.2 SYNC_DIR=/vobs/dsl/source04/BspPq2ProErr
element /vobs/dsl/source04/BspPq2ProErr/bspdErr.c .../ahaa/LATEST

#####
# MOD_BSPPQ2PROMMU_AA_V1.0.7 SYNC_DIR=/vobs/dsl/source04/BspPq2ProMmu/mpc_mmu_a.s
element -dir /vobs/dsl/source04/BspPq2ProMmu                           /main/6
element /vobs/dsl/source04/BspPq2ProMmu/Makefile .../raleigh_gpon44/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/mpc_pte.s              .../ahaa/LATEST
element /vobs/dsl/source04/BspPq2ProMmu/mmuImpl/mpc_mmu.c      .../ahaa/LATEST
element /vobs/dsl/source04/BspPq2ProMmu/export/mpc_mmu.h .../raleigh_gpon44/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/export/mpc_mmuItf.h .../raleigh_gpon44/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/mmuImpl/mpc_mmu.c .../raleigh_gpon45/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/mmuItf/mpc_mmuDbg.c .../raleigh_gpon44/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/mmuItf/mpc_mmuItf.c .../raleigh_gpon44/LATEST #FIXME
element /vobs/dsl/source04/BspPq2ProMmu/mpc_caches.s           .../ahaa/LATEST

#####
# was:MOD_EQUIPHDS_AA_V5.4.5 
# MOD_EQUIPHDS_AA_V8.2.1 SYNC_DIR=/vobs/dsl/source04/EquipHdS
element /vobs/dsl/source04/EquipHdS/export/BoardsHclLsm.hpp    .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/LocalExtender.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/LocalHclLsm.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/LocalHclLsm.hpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/LocalNt.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/RemoteLsm.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/holders/RemoteTaus.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/EOConvSensorNt.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/RedundancySensorNt.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/ShelfSensorNtExt.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/ShelfSensorNtExt.hpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/SlotSensorHclLsm.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/sensors/SlotSensorHclLsm.hpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/private/subsystem/BoardsHclLsm.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/trace_debug/EOConvSensorNtTraceDebug.cpp .../ahaa/LATEST
element /vobs/dsl/source04/EquipHdS/trace_debug/ShelfSensorNtExtTraceDebug.cpp .../ahaa/LATEST

#####
# MOD_GECOMM_HWW_AA_V5.2.2 SYNC_DIR=/vobs/dsl/source04/GEComm_hww
element /vobs/dsl/source04/GEComm_hww/ge_drv.c                 .../ahaa/LATEST

#####
# MOD_GENLXFWDWRAPITF_AA_V6.4.3 SYNC_DIR=/vobs/dsl/source04/GenLxFwdWrapItf
element /vobs/dsl/source04/GenLxFwdWrapItf/Makefile            .../ahaa/LATEST
element /vobs/dsl/source04/GenLxFwdWrapItf/debug/lxfwd_dbgVlan.cpp .../ahaa/LATEST
element /vobs/dsl/source04/GenLxFwdWrapItf/export/lxFwd_WrapItf.h .../ahaa/LATEST
element /vobs/dsl/source04/GenLxFwdWrapItf/export/lxFwd_WrapItf_Types.h .../ahaa/LATEST
element /vobs/dsl/source04/GenLxFwdWrapItf/stubs/lxFwd_WrapItf_QOS.c .../ahaa/LATEST
element /vobs/dsl/source04/GenLxFwdWrapItf/stubs/lxFwd_WrapItf_debug.cpp .../ahaa/LATEST
# other ahaa branches must be obsoleted

#####
# was:MOD_HSASICS_AA_V7.3.0
#JOB04.005 MOD_HSASICS_AA_V9.1.0 SYNC_DIR=/vobs/dsl/source04/HsAsics
# control CPLD 1.0/1.1 per board
element /vobs/dsl/source04/HsAsics/Makefile                    .../ahaa/LATEST
# disable E/O & exnt-a updates
element /vobs/dsl/source04/HsAsics/private/cgl/implementation/Cgl.cpp .../ahaa/LATEST
# BDFam25038 - SML/CGL register array overrun
element /vobs/dsl/source04/HsAsics/private/cgl/implementation/CglHwTable.cpp .../ahaa/LATEST
# remove changes not supported by our SML driver - LT17,18 
element /vobs/dsl/source04/HsAsics/export/Sml.hpp              .../ahaa/LATEST
element /vobs/dsl/source04/HsAsics/private/sml/implementation/Sml.cpp .../ahaa/LATEST
element /vobs/dsl/source04/HsAsics/private/sml/trace_debug/SmlCommand.cpp .../ahaa/LATEST
# exnt-a related updates
element /vobs/dsl/source04/HsAsics/export/Cgl.hpp .../ahaa/LATEST
element /vobs/dsl/source04/HsAsics/private/cgl/implementation/CglHwTable.hpp .../ahaa/LATEST
element /vobs/dsl/source04/HsAsics/private/cgl/trace_debug/CglCommand.cpp .../ahaa/LATEST

#####
# was:MOD_HSHWWRAPPER_AA_V7.0.0
#JOB04.006 MOD_HSHWWRAPPER_AA_V10.0.4 SYNC_DIR=/vobs/dsl/source04/HsHwWrapper
element /vobs/dsl/source04/HsHwWrapper/private/HWwrapperForHclLsm.cpp .../ahaa/LATEST
element /vobs/dsl/source04/HsHwWrapper/Makefile                .../ahaa/LATEST

#####
# MOD_HSRIP_BOARDS_AA_V9.1.4 SYNC_DIR=/vobs/dsl/source04/HsRip_Boards/.DeliveryList
element /vobs/dsl/source04/HsRip_Boards/Makefile               .../ahaa/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_LEDDRV_AA_V5.1.3 SYNC_DIR=/vobs/dsl/source04/LedDrv
element /vobs/dsl/source04/LedDrv/led_drv.c                    .../ahaa/LATEST
element /vobs/dsl/source04/LedDrv/led_drv_app_if.c             .../ahaa/LATEST
element /vobs/dsl/source04/LedDrv/export/led_drv.h             .../ahaa/LATEST
element /vobs/dsl/source04/LedDrv/export/led_drv_app_if.h      .../ahaa/LATEST

#####
# MOD_NP_LXFWD_ITFWRAP_ATM_AA_V3.1.6 SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_ATM
element /vobs/dsl/source04/NP_LxFwd_itfwrap_ATM/source/lxFwd_ATM.cpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
#JOB04.009 MOD_NP_LXFWD_ITFWRAP_INIT_AA_V6.0.0 SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_INIT
#KM45!element /vobs/dsl/source04/NP_LxFwd_itfwrap_INIT/source/lxFwd_Init.c .../ahaa/LATEST

#####
#JOB04.010 ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_L3fwd
#KM45!element -file /vobs/dsl/source04/NP_LxFwd_itfwrap_L3fwd/...    .../ahaa/LATEST

#####
#JOB04.011 ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_MC
#KM45!element /vobs/dsl/source04/NP_LxFwd_itfwrap_MC/source/npIxpLx_mc.c .../ahaa/LATEST

#####
#JOB04.012 MOD_NP_LXFWD_ITFWRAP_PH_AA_V6.0.2 SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_PH
#KM45!element /vobs/dsl/source04/NP_LxFwd_itfwrap_PH/source/lxFwd_ph.c .../ahaa/LATEST

#####
# was:MOD_NP_LXFWD_ITFWRAP_PPPOAOE_AA_V5.0.1
#JOB04.013 MOD_NP_LXFWD_ITFWRAP_PPPOAOE_AA_V4.2.8 SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_PPPoAoE
element /vobs/dsl/source04/NP_LxFwd_itfwrap_PPPoAoE/source/npIxpLxFwd_Pppoa.c .../raleigh_gpon45_temp1/LATEST #FIXME

#####
#JOB04.014 MOD_NP_LXFWD_ITFWRAP_VLAN_AA_V4.1.2 SYNC_DIR=/vobs/dsl/source04/NP_LxFwd_itfwrap_Vlan
element /vobs/dsl/source04/NP_LxFwd_itfwrap_Vlan/source/lxFwd_Vlan.c .../raleigh_gpon45_temp1/LATEST #FIXME
#KM45!element /vobs/dsl/source04/NP_LxFwd_itfwrap_Vlan/source/lxFwd_Vlan.c .../ahaa/LATEST
element /vobs/dsl/source04/NP_LxFwd_itfwrap_Vlan/export/npIxpLx_vlan.h .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_PQ2PRO_STARTUP_BOOT_AA_V2.1.1 SYNC_DIR=/vobs/dsl/source04/Pq2Pro_Startup_Boot
element /vobs/dsl/source04/Pq2Pro_Startup_Boot/Makefile .../ahaa/LATEST
element /vobs/dsl/source04/Pq2Pro_Startup_Boot/fsSelect.c .../ahaa/LATEST
element /vobs/dsl/source04/Pq2Pro_Startup_Boot/startup.c .../ahaa/LATEST

#####
# MOD_PQ2PRO_STARTUP_FS_AA_V1.0.4 SYNC_DIR=/vobs/dsl/source04/Pq2Pro_Startup_FS
element /vobs/dsl/source04/Pq2Pro_Startup_FS/startup.c         .../ahaa/LATEST

#####
# MOD_RIPCO_AA_V7.0.1 SYNC_DIR=/vobs/dsl/source04/RipCo
element /vobs/dsl/source04/RipCo/Makefile                      .../ahaa/LATEST
element /vobs/dsl/source04/RipCo/dbg_rip.c                     .../ahaa/LATEST
element /vobs/dsl/source04/RipCo/export/rip.h                  .../ahaa/LATEST
element /vobs/dsl/source04/RipCo/rip.c                         .../ahaa/LATEST

#####
# was:MOD_RIPSPI_AA_V3.3.1
# MOD_RIPSPI_AA_V5.1.5 SYNC_DIR=/vobs/dsl/source04/RipSpi
# conditionalize for older SML
element /vobs/dsl/source04/RipSpi/spi_drv.c   .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_TEMPERATUREHDS_AA_V8.1.0 SYNC_DIR=/vobs/dsl/source04/TemperatureHds/.DeliveryList
# KM temp from Julia
element /vobs/dsl/source04/TemperatureHds/low_level/ahds_ll_temp_measurement.c .../raleigh_gpon45_temp1/LATEST
# TEMP 
element -dir  /vobs/dsl/source04/TemperatureHds/low_level/board/... .../raleigh/LATEST #FIXME
element -dir  /vobs/dsl/source04/TemperatureHds/low_level/board/... /main/LATEST -mkbranch raleigh #FIXME
# real
element /vobs/dsl/source04/TemperatureHds/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME
element -file /vobs/dsl/source04/TemperatureHds/low_level/board/... .../ahaa/LATEST
element -file /vobs/dsl/source04/TemperatureHds/low_level/board/... /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source04/TemperatureHds/low_level/board/... /main/LATEST

#### source05 ####

####
# MOD_ASAMTRAP_AA_V1.2.3 SYNC_DIR=/vobs/dsl/source05/AsamTrap
element /vobs/dsl/source05/AsamTrap/trap.c                     .../ahaa/LATEST
element /vobs/dsl/source05/AsamTrap/trapmib.c  MOD_ASAMTRAP_AH_V4.4.0.1 #FIXME
element /vobs/dsl/source05/AsamTrap/asam_trap.c .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source05/AsamTrap/export/asam_trap.h .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source05/AsamTrap/export/asam_trap.mib .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source05/AsamTrap/export/asam_trap.rc        .../ahaa/LATEST

#### source06 ####

#####
#was: MOD_PQIIETHMGNT_AA_V3.1.0
element /vobs/dsl/source06/PQIIEthMgnt/ether_mau_proto.c     /main/ahaa/LATEST
# rollbacks to 4.4.1x
element /vobs/dsl/source06/PQIIEthMgnt/...           MOD_PQIIETHMGNT_AA_V3.0.1

#####
# was:MOD_SELTLITELT_AA_V4.0.0
# MOD_SELTLITELT_AA_V5.1.2 SYNC_DIR=/vobs/dsl/source06/SELTLiteLt
element /vobs/dsl/source06/SELTLiteLt/SeltManLsm.cpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# was:MOD_XDSLBONDINGMGNTNT_AA_V1.9.7
# MOD_XDSLBONDINGMGNTNT_AA_V7.0.31 SYNC_DIR=/vobs/dsl/source06/xDSLBondingMgntNt
# remove hard-coded eant-a
element /vobs/dsl/source06/xDSLBondingMgntNt/export/BondingTypes.hpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# was:MOD_XDSLMGR-COMMON_AA_V8.6.9
# MOD_XDSLMGR-COMMON_AA_V10.2.7 SYNC_DIR=/vobs/dsl/source06/xDSLMGR-COMMON
# remove hard-coded eant-a
element /vobs/dsl/source06/xDSLMGR-COMMON/common/Xdsl_GlobalConst.hpp .../raleigh_gpon45_temp1/LATEST #FIXME
# make reproducible
element /vobs/dsl/source06/xDSLMGR-COMMON/generate.mak .../raleigh_gpon45_temp1/LATEST #FIXME

#### source07 ####

####
#JOB07.001 MOD_VLANBRIDGEMGNTCOMMON_AA_V6.5.1 SYNC_DIR=/vobs/dsl/source07/VlanBridgeMgntCommon
element -file /vobs/dsl/source07/VlanBridgeMgntCommon/...      .../ahaa/LATEST
#TEMP freeze to 4.4.10
element /vobs/dsl/source07/VlanBridgeMgntCommon/... MOD_VLANBRIDGEMGNTCOMMON_AA_V6.5.1

####
#JOB07.002 MOD_VLANBRIDGEMGNTLSM_AA_V7.2.12 SYNC_DIR=/vobs/dsl/source07/VlanBridgeMgntLsm
element -file /vobs/dsl/source07/VlanBridgeMgntLsm/...         .../ahaa/LATEST
element /vobs/dsl/source07/VlanBridgeMgntLsm/...     .../raleigh_gpon41/LATEST
element /vobs/dsl/source07/VlanBridgeMgntLsm/...     .../raleigh_gpon40/LATEST
#TEMP freeze to 4.4.10
element /vobs/dsl/source07/VlanBridgeMgntLsm/...  MOD_VLANBRIDGEMGNTLSM_AA_V7.2.12

####
#JOB07.003 MOD_VLANBRIDGEMGNTNT_AA_V7.5.23 SYNC_DIR=/vobs/dsl/source07/VlanBridgeMgntNt
element -file /vobs/dsl/source07/VlanBridgeMgntNt/...          .../ahaa/LATEST
#TEMP freeze to 4.4.10
element /vobs/dsl/source07/VlanBridgeMgntNt/... MOD_VLANBRIDGEMGNTNT_AA_V7.5.23

#### source08 ####

#####
#JOB08.001 MOD_8021XMGNTLSM_AA_V5.1.2 SYNC_DIR=/vobs/dsl/source08/8021xMgntLsm
element -dir  /vobs/dsl/source08/8021xMgntLsm/...                 /main/LATEST
element -file /vobs/dsl/source08/8021xMgntLsm/...              .../ahaa/LATEST
element /vobs/dsl/source08/8021xMgntLsm/inc/Dot1xMgntLsm_Timer.hpp MOD_8021XMGNTLSM_AA_V3.7.2
element /vobs/dsl/source08/8021xMgntLsm/src/Dot1xMgntLsm_Timer.cpp MOD_8021XMGNTLSM_AA_V3.7.2
element -file /vobs/dsl/source08/8021xMgntLsm/...   MOD_8021XMGNTLSM_AA_V5.1.2

#####
#JOB08.002 MOD_8021XMGNTNT_AA_V7.0.2 SYNC_DIR=/vobs/dsl/source08/8021xMgntNt
element -dir  /vobs/dsl/source08/8021xMgntNt/...                  /main/LATEST
element -file /vobs/dsl/source08/8021xMgntNt/...             /main/ahaa/LATEST
element       /vobs/dsl/source08/8021xMgntNt/...     MOD_8021XMGNTNT_AA_V7.0.2

#####
#JOB08.003 MOD_8021XPRTCLS_AA_V4.1.1 SYNC_DIR=/vobs/dsl/source08/8021xPrtcls
element -dir  /vobs/dsl/source08/8021xPrtcls/src    .../ahaa/LATEST #can't fix
element -dir  /vobs/dsl/source08/8021xPrtcls/...                  /main/LATEST
element -file /vobs/dsl/source08/8021xPrtcls/...             /main/ahaa/LATEST
element       /vobs/dsl/source08/8021xPrtcls/...     MOD_8021XPRTCLS_AA_V4.1.1

#####
#JOB08.004 MOD_CLUSTERMGNT_AA_V3.0.0 SYNC_DIR=/vobs/dsl/source08/ClusterMgnt
element -file /vobs/dsl/source08/ClusterMgnt/app/sources/classes/TopologyApplication.cpp .../ahaa/LATEST

#####
#JOB08.005 MOD_AAASERVER_AA_V8.0.2 SYNC_DIR=/vobs/dsl/source08/AAAServer
element /vobs/dsl/source08/AAAServer/src/DataMngnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME - temp workaround
element -dir  /vobs/dsl/source08/AAAServer/...                    /main/LATEST
element -file /vobs/dsl/source08/AAAServer/...               /main/ahaa/LATEST
element       /vobs/dsl/source08/AAAServer/...         MOD_AAASERVER_AA_V8.0.2
#####
#JOB08.006 MOD_AAASERVER_ITF_AA_V1.2.0 SYNC_DIR=/vobs/dsl/source08/AAAServer_Itf
element -dir  /vobs/dsl/source08/AAAServer_Itf/...                /main/LATEST
element -file /vobs/dsl/source08/AAAServer_Itf/...           /main/ahaa/LATEST
element       /vobs/dsl/source08/AAAServer_Itf/... MOD_AAASERVER_ITF_AA_V1.2.0

####### BEGIN CLI MODULES #######

# MOD_CLI_AAA_AA_V6.0.4 SYNC_DIR=/vobs/dsl/source08/CLI_AAA
element /vobs/dsl/source08/CLI_AAA/...                 MOD_CLI_AAA_AH_V4.5.0.2

# was:MOD_CLI_AGENT_AA_V6.8.8
# MOD_CLI_AGENT_AA_V11.5.27 SYNC_DIR=/vobs/dsl/source08/CLI_Agent
element /vobs/dsl/source08/CLI_Agent/...           MOD_CLI_AGENT_AH_V4.5.0.8

# was:MOD_CLI_ALARMREPORTING_AA_V7.0.5 
# MOD_CLI_ALARMREPORTING_AA_V12.4.5 xxxx_DIR=/vobs/dsl/source08/CLI_AlarmReporting

# MOD_CLI_ATM_AA_V3.2.1 xxxx_DIR=/vobs/dsl/source08/CLI_ATM

# MOD_CLI_AUTHENTICATOR_AA_V3.2.1 SYNC_DIR=/vobs/dsl/source08/CLI_Authenticator
# -- CLI logging
element /vobs/dsl/source08/CLI_Authenticator/... MOD_CLI_AUTHENTICATOR_AH_V4.5.0.5

# MOD_CLI_COMMON_AA_V2.2.0 xxxx_DIR=/vobs/dsl/source08/CLI_Common
# MOD_CLI_CPEMGNT_AA_V1.0.4 xxxx_DIR=/vobs/dsl/source08/CLI_CPEMGNT

# MOD_CLI_DHCP_AA_V5.3.3 SYNC_DIR=/vobs/dsl/source08/CLI_DHCP

# MOD_CLI_EQUIPMENT_AA_V5.4.12 SYNC_DIR=/vobs/dsl/source08/CLI_Equipment
element /vobs/dsl/source08/CLI_Equipment/...  MOD_CLI_EQUIPMENT_AH_V4.5.0.2

# MOD_CLI_ERROR_AA_V1.3.4 xxxx_DIR=/vobs/dsl/source08/CLI_Error

# MOD_CLI_IGMP_AA_V6.2.3 SYNC_DIR=/vobs/dsl/source08/CLI_IGMP
element /vobs/dsl/source08/CLI_IGMP/...              MOD_CLI_IGMP_AH_V4.5.0.1

# MOD_CLI_IP_AA_V3.1.1 xxxx_DIR=/vobs/dsl/source08/CLI_IP
element /vobs/dsl/source08/CLI_IP/...                   MOD_CLI_IP_AH_V4.5.0.1

#####
# MOD_CLI_IPSEC_AH_V xxxx_DIR=/vobs/dsl/source08/CLI_IPSEC (development)
element /vobs/dsl/source08/CLI_IPSEC/...             MOD_CLI_IPSEC_AH_V4.5.0.2
element -file /vobs/dsl/source08/CLI_IPSEC/...                 .../ahaa/LATEST
element -file /vobs/dsl/source08/CLI_IPSEC/...          /main/0 -mkbranch ahaa
element -dir  /vobs/dsl/source08/CLI_IPSEC/...                    /main/LATEST

# was:MOD_CLI_LANGUAGE_AA_V7.4.5
# MOD_CLI_LANGUAGE_AA_V11.3.11 SYNC_DIR=/vobs/dsl/source08/CLI_Language
element /vobs/dsl/source08/CLI_Language/...        MOD_CLI_LANGUAGE_AH_V4.5.0.3

# MOD_CLI_OPERATORS_AA_V6.0.4 SYNC_DIR=/vobs/dsl/source08/CLI_Operators
element /vobs/dsl/source08/CLI_Operators/...     MOD_CLI_OPERATORS_AH_V4.5.0.3

# MOD_CLI_OSPF_AA_V3.1.1 xxxx_DIR=/vobs/dsl/source08/CLI_OSPF
# MOD_CLI_PPPOE_AA_V3.1.0 xxxx_DIR=/vobs/dsl/source08/CLI_PPPoE

# was MOD_CLI_QOS_AA_V3.1.0
# ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source08/CLI_QoS
element /vobs/dsl/source08/CLI_QoS/...     MOD_CLI_QOS_AH_V4.5.0.3

# MOD_CLI_RIP_AA_V3.1.3 xxxx_DIR=/vobs/dsl/source08/CLI_RIP
element /vobs/dsl/source08/CLI_RIP/...                   MOD_CLI_RIP_AH_V4.5.0.1

# MOD_CLI_SSH_AA_V2.0.1 xxxx_DIR=/vobs/dsl/source08/CLI_SSH

# MOD_CLI_SWMANAGEMENT_AA_V3.1.1 xxxx_DIR=/vobs/dsl/source08/CLI_SWManagement
element /vobs/dsl/source08/CLI_SWManagement/... MOD_CLI_SWMANAGEMENT_AH_V4.5.0.1

# MOD_CLI_SYSTEM_AA_V7.1.3 SYNC_DIR=/vobs/dsl/source08/CLI_System
element /vobs/dsl/source08/CLI_System/...        MOD_CLI_SYSTEM_AH_V4.5.0.3

# was:MOD_CLI_TRANSPORT_AA_V6.0.2

# MOD_CLI_TRANSPORT_AA_V11.1.12 SYNC_DIR=/vobs/dsl/source08/CLI_Transport
element /vobs/dsl/source08/CLI_Transport/...       MOD_CLI_TRANSPORT_AH_V4.5.0.4

# was:MOD_CLI_VLAN_AA_V6.3.6 
# MOD_CLI_VLAN_AA_V11.5.15 SYNC_DIR=/vobs/dsl/source08/CLI_VLAN
element /vobs/dsl/source08/CLI_VLAN/...            MOD_CLI_VLAN_AH_V4.5.0.3

# MOD_CLI_XDSL_AA_V3.2.11 xxxx_DIR=/vobs/dsl/source08/CLI_xDSL

####### END CLI MODULES #######

#####
# was:MOD_CPEMGNTRELAYNT_AA_V2.3.0
# MOD_CPEMGNTRELAYNT_AA_V3.2.3 SYNC_DIR=/vobs/dsl/source08/CPEMgntRelayNt
# remove hard-coded eant-a
element /vobs/dsl/source08/CPEMgntRelayNt/export/CpeConsts.h .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source08/CPEMgntRelayNt/header/CpeMgntSysModeTable.hpp  .../ahaa/LATEST
element /vobs/dsl/source08/CPEMgntRelayNt/header/CpeMgntIpProxyVlanTable.hpp  .../ahaa/LATEST

#####
# MOD_DHCPRELAY_AA_V4.0.7 SYNC_DIR=/vobs/dsl/source08/DHCPRelay
element -file /vobs/dsl/source08/DHCPRelay/...                 .../ahaa/LATEST
element /vobs/dsl/source08/DHCPRelay/...               MOD_DHCPRELAY_AA_V4.0.7

#####
#JOB08.008 MOD_DHCPRELAYMGNTLSM_AA_V4.2.0 SYNC_DIR=/vobs/dsl/source08/DHCPRelayMgntLsm/export
element -file /vobs/dsl/source08/DHCPRelayMgntLsm/...          .../ahaa/LATEST
#TEMP ROLLBACK
element /vobs/dsl/source08/DHCPRelayMgntLsm/... MOD_DHCPRELAYMGNTLSM_AA_V4.2.0

#####
# was:MOD_DHCPRELAYMGNTNT_AA_V5.6.3
#JOB08.009 MOD_DHCPRELAYMGNTNT_AA_V9.1.8 SYNC_DIR=/vobs/dsl/source08/DHCPRelayMgntNt
#TEMP ROLLBACK
element -file /vobs/dsl/source08/DHCPRelayMgntNt/...           .../ahaa/LATEST
element -file /vobs/dsl/source08/DHCPRelayMgntNt/... MOD_DHCPRELAYMGNTNT_AA_V5.6.3 #FIXME

#####
# MOD_ENVMONMGNT_AA_V1.1.1 SYNC_DIR=/vobs/dsl/source08/EnvMonMgnt
element /vobs/dsl/source08/EnvMonMgnt/EnvMonMgnt.cpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_FORMATMGNTLSM_AA_V2.1.5 SYNC_DIR=/vobs/dsl/source08/FormatMgntLsm
element -file /vobs/dsl/source08/FormatMgntLsm/...             .../ahaa/LATEST

#####
#JOB08.011 MOD_IGMPCDRMGNTLSM_AA_V3.99.6 SYNC_DIR=/vobs/dsl/source08/IGMPCDRMgntLsm
#FROZEN
element /vobs/dsl/source08/IGMPCDRMgntLsm/...                  .../ahaa/LATEST
element /vobs/dsl/source08/IGMPCDRMgntLsm/...    MOD_IGMPCDRMGNTLSM_AA_V3.99.6

#####
#JOB08.012 MOD_IGMPCDRMGNTNT_AA_V3.99.13 SYNC_DIR=/vobs/dsl/source08/IGMPCDRMgntNt
element /vobs/dsl/source08/IGMPCDRMgntNt/source/IgmpCDRNt.cpp .../ahaa/LATEST
element /vobs/dsl/source08/IGMPCDRMgntNt/source/IgmpCDRTest.cpp .../ahaa/LATEST
#FROZEN
element /vobs/dsl/source08/IGMPCDRMgntNt/...                   .../ahaa/LATEST
element /vobs/dsl/source08/IGMPCDRMgntNt/export/IgmpCDRTask.hpp MOD_IGMPCDRMGNTNT_AA_V3.99.18 #BAD!
element /vobs/dsl/source08/IGMPCDRMgntNt/...     MOD_IGMPCDRMGNTNT_AA_V3.99.13

#####
#JOB08.013 ISR24_FGN30_18__REBL SYNC_DIR=/vobs/dsl/source08/IGMPHandler (ISAM)
#FROZEN
element -file /vobs/dsl/source08/IGMPHandler/...               .../ahaa/LATEST
element /vobs/dsl/source08/IGMPHandler/...           MOD_IGMPHANDLER_AA_V4.0.2

#####
#JOB08.014 MOD_IGMPHANDLERAOS_AA_FDT301.V1.99.24 SYNC_DIR=/vobs/dsl/source08/IGMPHandlerAOS
#FROZEN
element /vobs/dsl/source08/IGMPHandlerAOS/...                  .../ahaa/LATEST
element /vobs/dsl/source08/IGMPHandlerAOS/... MOD_IGMPHANDLERAOS_AA_FDT301.V1.99.24

#####
#JOB08.015 MOD_IGMPMGNTCOMMON_AA_FDT301.V6.99.2 SYNC_DIR=/vobs/dsl/source08/IGMPMgntCommon
#FROZEN
element /vobs/dsl/source08/IGMPMgntCommon/...                  .../ahaa/LATEST
element /vobs/dsl/source08/IGMPMgntCommon/... MOD_IGMPMGNTCOMMON_AA_FDT301.V6.99.2

#####
#JOB08.016 MOD_IGMPMGNTLSM_AA_FDT301.V8.99.24 SYNC_DIR=/vobs/dsl/source08/IGMPMgntLsm
#FROZEN
element /vobs/dsl/source08/IGMPMgntLsm/...                     .../ahaa/LATEST
element /vobs/dsl/source08/IGMPMgntLsm/...              MOD_IGMPMGNTLSM_AA_FDT301.V8.99.24

#####
# MOD_IGMPMGNTNT_AA_V4.0.5 SYNC_DIR=/vobs/dsl/source08/IGMPMgntNt
#FROZEN
element /vobs/dsl/source08/IGMPMgntNt/mapper/IgmpMapper.cpp MOD_IGMPMGNTNT_AH_V4.5.0.6
element /vobs/dsl/source08/IGMPMgntNt/headers/IgmpMapper.hpp MOD_IGMPMGNTNT_AH_V4.5.0.6

#better way
element /vobs/dsl/source08/IGMPMgntNt/export/igmp.rc .../raleigh_gpon45_temp1/LATEST #FIXME
#don't: element /vobs/dsl/source08/IGMPMgntNt/export/common.rc          -none

element /vobs/dsl/source08/IGMPMgntNt/...                      .../ahaa/LATEST
element /vobs/dsl/source08/IGMPMgntNt/...             MOD_IGMPMGNTNT_AA_V4.0.5

#####
#JOB08.018 MOD_IGMPSTACK_AA_FDT301.V6.99.13 SYNC_DIR=/vobs/dsl/source08/IGMPStack
#FROZEN
element /vobs/dsl/source08/IGMPStack/...                       .../ahaa/LATEST
element /vobs/dsl/source08/IGMPStack/...      MOD_IGMPSTACK_AA_FDT301.V6.99.13

#####
#JOB08.??? MOD_IPOXIWLMGNTNT_AA_V6.0.2 SYNC_DIR=/vobs/dsl/source08/IPoXIWLMgntNt
element /vobs/dsl/source08/IPoXIWLMgntNt/IPoXIWLMgntNt_if.cpp .../raleigh_gpon45_temp1/LATEST

#####
#JOB08.019 MOD_PPPOXRELAYMGNTNT_AA_V3.2.7 SYNC_DIR=/vobs/dsl/source08/PPPoXRelayMgntNt
# remove hard-coded eant-a
element /vobs/dsl/source08/PPPoXRelayMgntNt/Makefile .../raleigh_gpon45_temp1/LATEST #FIXME
# fix compiles
element /vobs/dsl/source08/PPPoXRelayMgntNt/mapper/pppCcNt_MapperFunctions.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source08/PPPoXRelayMgntNt/src/pppCcNt_IOCM.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source08/PPPoXRelayMgntNt/src/pppCcNt_Task.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source08/PPPoXRelayMgntNt/src/pppCcNt_Utils.cpp .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/dsl/source08/PPPoXRelayMgntNt/src/pppCcNt_application.cpp .../raleigh_gpon45_temp1/LATEST #FIXME

#####
#JOB08.020 MOD_PPPOERELAYPRTCLS_AA_V4.2.1 SYNC_DIR=/vobs/dsl/source08/PPPoERelayPrtcls
element -file /vobs/dsl/source08/PPPoERelayPrtcls/...          .../ahaa/LATEST


#####
#JOB08.021 MOD_PPPOXRELAYMGNTLSM_AA_V3.1.1 SYNC_DIR=/vobs/dsl/source08/PPPoXRelayMgntLsm
#KM45!element /vobs/dsl/source08/PPPoXRelayMgntLsm/Makefile          .../ahaa/LATEST

#####
#JOB08.022 MOD_RADIUSCLIENT_AA_V4.2.1 SYNC_DIR=/vobs/dsl/source08/RadiusClient
element -dir  /vobs/dsl/source08/RadiusClient/...                 /main/LATEST
element -file /vobs/dsl/source08/RadiusClient/...            /main/ahaa/LATEST
element       /vobs/dsl/source08/RadiusClient/...   MOD_RADIUSCLIENT_AA_V4.2.1

#####
#JOB08.023 MOD_SERVICEAVAILMGR_AA_V2.0.0 SYNC_DIR=/vobs/dsl/source08/ServiceAvailMgr
#KM45!element /vobs/dsl/source08/ServiceAvailMgr/nt/SAMCommonNt.cpp .../raleigh_gpon42_temp1/LATEST

#####
# was:ISR24_FGN30_18__REBL
# MOD_TRANSCEIVERBUFLIB_AA_V6.3.0 SYNC_DIR=/vobs/dsl/source08/TransceiverBufLib
element /vobs/dsl/source08/TransceiverBufLib/export/TransceiverBufLib.h .../ahaa/LATEST

#####
#JOB08.025 MOD_TRANSCEIVERPOOLMGR_AA_V4.0.0 SYNC_DIR=/vobs/dsl/source08/TransceiverPoolMgr
element /vobs/dsl/source08/TransceiverPoolMgr/src/TransceiverPoolMgr.c .../ahaa/LATEST

#### source09 ####

#####
# MOD_ASAMSYST_AA_V8.2.3 SYNC_DIR=/vobs/dsl/source09/AsamSyst
element -file /vobs/dsl/source09/AsamSyst/...                  .../ahaa/LATEST

#####
# MOD_STARTUPCO_AA_V3.0.1 SYNC_DIR=/vobs/dsl/source09/StartupCo
element /vobs/dsl/source09/StartupCo/OS/Makefile               .../ahaa/LATEST
element /vobs/dsl/source09/StartupCo/OS/resets.c               .../ahaa/LATEST

#####
# MOD_SYSTEMMGNTLSM_AA_V1.0.7 SYNC_DIR=/vobs/dsl/source09/SystemMgntLsm
element -file /vobs/dsl/source09/SystemMgntLsm/...             .../ahaa/LATEST

#### source10 ####

#####
# was:MOD_COMMONINCLUDE_AA_V3.2.0
# MOD_COMMONINCLUDE_AA_V4.0.2 SYNC_DIR=/vobs/dsl/source10/CommonInclude
element /vobs/dsl/source10/CommonInclude/export/communication_types.h .../raleigh_gpon45_temp1/LATEST #FIXME

#####
# MOD_ASAMIDS_AA_V7.3.1 SYNC_DIR=/vobs/dsl/source10/AsamIds
element /vobs/dsl/source10/AsamIds/export/SubsystemIds_ServiceAppls.hpp .../ahaa/LATEST
element /vobs/dsl/source10/AsamIds/export/SubsystemIds_Vbridge.hpp .../ahaa/LATEST

#####
# TOOLS_XML_V1.0.7 SYNC_DIR=/vobs/tools/ALCATEL/xml
# show meaningful error messages
element /vobs/tools/ALCATEL/xml/xml4Parser/node.xsl .../raleigh_gpon45_temp1/LATEST #FIXME
element /vobs/tools/ALCATEL/xml/xml4Parser/parameterTypes.xsl .../raleigh_gpon45_temp1/LATEST #FIXME

##########################################################
# BASELINE DELTA LABELS
# build fix
#KM45!element -dir /cm4/tools/GNU/...                      MOD_DIRS_TOOLS_GNU_V1.0.1

# upgrade SYSLOG
#KM45!element /vobs/dsl/source02/SyslogMgnt/...             MOD_SYSLOGMGNT_AA_V3.1.4

# DOWNGRADE to ISAM R2.x
#KM45!element /vobs/dsl/source03/AcuCtrl/nt/acuDrv/AcuDriver.hpp   .../ahaa/LATEST
#KM45!element /vobs/dsl/source03/AcuCtrl/nt/acuDrv/AcuDriver.cpp   .../ahaa/LATEST
#KM45!element /vobs/dsl/source03/AcuCtrl/...                  MOD_ACUCTRL_AA_V2.0.12

# Recommended label set by Kanata (related to SML changes for LT 17/18)
#KM45!element /vobs/dsl/source04/AlarmEventHds/...       MOD_ALARMEVENTHDS_AA_V3.5.2
#KM45!element /vobs/dsl/source04/HsAsics/...                   MOD_HSASICS_AA_V7.3.0
#KM45!element /vobs/dsl/source04/EquipHdS/...                 MOD_EQUIPHDS_AA_V5.4.5

# upgrade protocols
#KM45!element /vobs/dsl/source08/8021xMgntLsm/...         MOD_8021XMGNTLSM_AA_V3.6.0

# upgrade SYSLOG
#KM45!element /vobs/dsl/source08/CLI_Syslog/...             MOD_CLI_SYSLOG_AA_V2.1.0

# enable LOC
element /cm4/tools/ANS/LOC/...                                    /main/LATEST
element /cm4/tools/ANS/bin5                                           /main/21
element -dir /cm4/tools/ANS/...                                   /main/LATEST

# temp: stop mibco on errors
#element /cm4/tools/BELL/src/mibco/SunOS_5.6/bin/mibco  .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/backhand.c           .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/build_types.c        .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/gen_mibtree.c        .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/gen_proto.c          .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/mibco.c              .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/mibpars.y            .../raleigh_test/LATEST
#element /cm4/tools/BELL/src/mibco/mibutil.c            .../raleigh_test/LATEST

# other modules

#####
# (ISAM: MOD_CLOCK_AA_V6.0.2)
# Wipro versions copied from /cm4/fsn
element /vobs/dsl/source04/Clock/ClockManager.cc             /main/ahaa/LATEST
element /vobs/dsl/source04/Clock/export/ClockManager.hpp     /main/ahaa/LATEST
element /vobs/dsl/source04/Clock/...                       MOD_CLOCK_AH_V1.0.0
element /cm4/fsn/app/asam/clock/...               WIPRO_PLATFORM_BITS_V4.1.0.3

#####
# Wipro versions copied from /cm4/fsn
element /vobs/dsl/source04/Gets/acs8510/sources/ACS8510_Init.cpp .../ahaa/LATEST
element /vobs/dsl/source04/Gets/acs8510/sources/ACS8510_IrqHandler.cpp .../ahaa/LATEST
element /vobs/dsl/source04/Gets/acs8510/sources/ACS8510_ClockConfiguration.cpp .../ahaa/LATEST
element /vobs/dsl/source04/Gets/acs8510/sources/ACS8510.cpp    .../ahaa/LATEST
element /vobs/dsl/source04/Gets/...                         MOD_GETS_AH_V1.0.0
element /cm4/fsn/hs/gets/...                      WIPRO_PLATFORM_BITS_V4.1.0.3

#####
# Add DataExpert
element /vobs/tools/DEE/src/DataExpert/...                     .../asam/LATEST
element /vobs/tools/DEE/lib/...                                .../asam/LATEST
element /vobs/tools/DEE/...                     MOD_ASAM_V1.0.9 -mkbranch asam
element /vobs/tools/Dev_Tools/...                                 /main/LATEST
element /cm4/tools/BELL/src/cmtools/cnfmgnt/scm/.MinVersion TOOLS_CMSCM_V1.8.3


##########################################################
# BASELINE

#---- entering 0 /vobs/esam/configspecs/ISAM_mainstream.cs@@/main/aaaa/isr33/isr3301/18
element /vobs/esam/configspecs/ISAM_mainstream.cs                /main/aaaa/isr33/isr3301/18
element -dir /vobs/dsl/source01 			      /main/7 #INTEGRATE-LATEST
element -dir /vobs/dsl/source02 			      /main/106 #INTEGRATE-LATEST
element -dir /vobs/dsl/source03 			      /main/51 #INTEGRATE-LATEST
element -dir /vobs/dsl/source04 			      /main/201 #INTEGRATE-LATEST
element -dir /vobs/dsl/source05 			      /main/5 #INTEGRATE-LATEST
element -dir /vobs/dsl/source06 			      /main/22 #INTEGRATE-LATEST
element -dir /vobs/dsl/source07 			      /main/6 #INTEGRATE-LATEST
element -dir /vobs/dsl/source08 			      /main/82 #INTEGRATE-LATEST
element -dir /vobs/dsl/source09 			      /main/4 #INTEGRATE-LATEST
element -dir /vobs/dsl/source10 			      /main/38 #INTEGRATE-LATEST
element -dir /vobs/dsl/source11 			      /main/5 #INTEGRATE-LATEST
#excluded:element -dir /vobs/dsl/source13 			      /main/36 #INTEGRATE-LATEST
#excluded:element -dir /vobs/dsl/infineon                               /main/27 #INTEGRATE-LATEST
#excluded:element -dir /vobs/gpon/sw/src02                              /main/1 #INTEGRATE-LATEST
element -dir /vobs/gpon/sw/src03                              /main/3 #INTEGRATE-LATEST
element -dir /vobs/gpon/sw/src03/apps                         /main/3 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/flat  			      /main/431 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include			      /main/428 #INTEGRATE-LATEST
element -dir /vobs/dsl/mibs				      /main/115 #INTEGRATE-LATEST
element -dir /vobs/esam/build/eblt-n                          /main/2 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/evlt-f                        /main/0
#excluded:element -dir /vobs/esam/objects/nalt-c                        /main/0
#excluded:element -dir /vobs/esam/objects/smlt-h                        /main/0
#excluded:element -dir /vobs/esam/objects/nalt-b                        /main/0
#excluded:element -dir /vobs/esam/objects/nvlt-a                        /main/0
#excluded:element -dir /vobs/esam/objects/nvlt-b                        /main/0
#excluded:element -dir /vobs/esam/objects/nvlt-c                        /main/0
#excluded:element -dir /vobs/esam/objects/rvlt-a                        /main/0
element -dir /vobs/esam/build/rvlt-a                          /main/5 #INTEGRATE-LATEST
element -dir /vobs/esam/build/iwsm-a			      /main/9 #INTEGRATE-LATEST
element -dir /vobs/esam/build				      /main/73 #INTEGRATE-LATEST
element -dir /vobs/esam/build/ecnt-b			      /main/7 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/esam/ecnt-c                         /main/7 #INTEGRATE-LATEST
element -dir /vobs/esam/build/itsc-a			      /main/3 #INTEGRATE-LATEST
element -dir /vobs/esam/build/eblt-m			      /main/2 #INTEGRATE-LATEST
element -dir /cm4/fsn/include/ecnt-c			      /main/1 #INTEGRATE-LATEST
element -dir /vobs/esam/build/eblt-j			      /main/2 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nant-a			      /main/8 #INTEGRATE-LATEST
element /vobs/esam/build/nant-a/boot* 			      -none
element /vobs/esam/build/nant-a/OS    		              -none
element -dir /vobs/esam/build/nalt-a			      /main/2 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nalt-b			      /main/3 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nalt-c                          /main/4 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nvlt-c                          /main/2 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/nvlt-c                /main/5 #INTEGRATE-LATEST
element -dir /cm4/tools/BELL/src                              /main/98 #INTEGRATE-LATEST
element -dir /cm4/fsn/test/prj/esam/evlt-c        	      /main/2 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/nvps-a                /main/4 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nvps-a                    /main/2 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nvlt-a                          /main/2 #INTEGRATE-LATEST
element -dir /vobs/esam/build/smlt-h                          /main/2 #INTEGRATE-LATEST
element -dir /vobs/esam/build/npot-a                         /main/2 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/esam/polt-a                         /main/2
element -dir /cm4/fsn/krnl/fs/board                           /main/117
element -dir /cm4/fsn/krnl                                    /main/52
element -dir /vobs/dsl/sw/include/board/nslt-a                /main/3 #INTEGRATE-LATEST
element -dir /vobs/esam/build/nslt-a                          /main/2 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/nslt-a                        /main/0
element -dir /vobs/dsl/sw/include/board/evlt-a          /main/7 #INTEGRATE-LATEST
element -dir /vobs/esam/build/evlt-f                          /main/4 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/evlt-f                /main/7 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/esam/smlt-h             /main/1
element -dir /vobs/dsl/sw/include/board/smlt-h    /main/5
element -dir /cm4/fsn/krnl/bsp/board /main/164 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/itsc-a /main/0
element -dir /cm4/fsn/prj/esam/itsc-a             /main/2
element -dir /vobs/dsl/sw/include/board/itsc-a    /main/1
element -dir /cm4/fsn/include/iwsm-a			      /main/1 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/esam  			      /main/30 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/esam/iwsm-a			      /main/1 #INTEGRATE-LATEST
element -dir /cm4/fsn/prj/asam  			      /main/359 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/iwsm-a  	      /main/1 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/iwsm-a  		      /main/0
element -dir /vobs/esam/build/polt-a			/main/5 #INTEGRATE-LATEST
element -dir /vobs/esam/build/polt-b			/main/1 #INTEGRATE-LATEST
#excluded:element /vobs/esam/objects/polt-b/...		        /main/0
element /vobs/dsl/sw/include/board/polt-b               /main/5 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/nant-a                        /main/0
element -dir /vobs/dsl/sw/include/board                       /main/48 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/nant-a                /main/5 #INTEGRATE-LATEST
element -directory /cm4/fsn/include                           /main/197 #INTEGRATE-LATEST
element -dir /vobs/esam/build/asem-b /main/2
element -dir /vobs/dsl/sw/include/board/asem-b /main/2
#excluded:element -dir /vobs/esam/objects/asem-b /main/0
#excluded:element -dir /vobs/dsl/ikanos                                 /main/1 #INTEGRATE-LATEST
#excluded:element -dir /vobs/esam/objects/nelt-a			       /main/0
element -dir /vobs/esam/build/nelt-a 			       /main/5 #INTEGRATE-LATEST
element -dir /vobs/dsl/sw/include/board/nelt-a                 /main/6 #INTEGRATE-LATEST
#excluded:element -dir /vobs/dsl/envoy 		                      	/main/LATEST
element /vobs/tools/GNU/... TOOLS_COMMON_V1.0.4
element /vobs/tools/SUN/... TOOLS_COMMON_V1.0.4
element /vobs/tools/GHS/... TOOLS_COMMON_V1.0.4
element -dir /vobs/tools/ALCATEL      				/main/20
element /vobs/tools/ALCATEL/check/... TOOLS_CHECK_V1.0.0
element /vobs/tools/ALCATEL/dml2dm/... TOOLS_DML2DM_V1.0.0
element /vobs/tools/ALCATEL/genInitFies/... TOOLS_GENINITFIES_V1.0.0
element /vobs/tools/ALCATEL/idlco/... TOOLS_IDLCO_V1.0.0
element /vobs/tools/ALCATEL/mib/... TOOLS_MIB_V1.0.0
element -dir /cm4/tools/BELL                                   /main/28 #INTEGRATE-LATEST
element -dir /cm4/tools/GNU                                    /main/25 #INTEGRATE-LATEST
element /cm4/tools/WRS/tornado /main/3
element /cm4/tools/WRS/tornado/ppc/... TORNADO_V2.0_1_PATCH_9
element /cm4/tools/GHS/integrity/ppc/INTEGRITY-include/INTEGRITY_types.h  GHS_INTEGRITY_PPC_V5.0.4_PATCH5
element /cm4/fsn/krnl/bsp/Makefile                             /main/7
element /cm4/tools/GHS/integrity/...                           GHS_INTEGRITY_PPC_V5.0.4_PATCH4
element /cm4/tools/GHS/ppc/solaris2/...                        GHS_PPC_MULTI2000_V4.0.7_PATCH6
element -dir /cm4/tools/WRS/tornado/ppc                        /main/12
element /cm4/tools/WRS/tornado/ppc/target/lib/libPPC860gnuvx.a /main/mieghehu_try/1
element /cm4/tools/WRS/tornado/ppc/target/h/types/vxArch.h     /main/changes/2
element /cm4/tools/WRS/tornado/ppc/target/lib/libPPCEC603gnuvx.a          /main/mieghehu_try/3
element /cm4/tools/WRS/tornado/ppc/target/config/comps/src/usrWdbBanner.c /main/raleigh_test/2
element /cm4/tools/WRS/tornado/ppc/target/config/comps/src/version.c      /main/raleigh_test/2
element /cm4/tools/WRS/tornado/ppc/host/sun4-solaris2/bin/ESTsrvrALL      -none
element /cm4/tools/WRS/tornado/ppc/...                        TORNADO_V2.0_1_PATCH_8
element /cm4/tools/WRS/tornado/ppc/...                        TORNADO_V2.0_1
element /cm4/tools/GHS/arm/...                                GHS_ARM_PATCH_1558_1591
element -dir /cm4/tools/WRS                                   /main/10
element -dir /cm4/tools/WRS/tornado                           /main/changes/1
element -dir /cm4/tools/WRS/tornado/active                    /main/ppc/1
element /cm4/tools/WRS/tornado/SA_XScale/target/lib           /main/IXP23xxxBitShiftErratumPatch/2
element /cm4/tools/WRS/tornado/SA_XScale/...                  itl18_042006
element /cm4/tools/WRS/tornado/SA_XScale/target/h/types/vxArch.h /main/changes/2
element /cm4/tools/WRS/tornado/SA_XScale/target/config/ixdp2401_be/... IXDP2401_BE_V1.0.2
element /cm4/tools/WRS/tornado/SA_XScale/target/config/ixdp2401_be/... IXDP2401_BE_V1.0.1
element /cm4/tools/WRS/tornado/SA_XScale/target/config/ixdp2400_be/... IXDP2400_BE_V1.0.4
element /cm4/tools/WRS/tornado/SA_XScale/target/h/types/...   ARM_TORNADO_ISAM_V1.0.0
element /cm4/tools/WRS/tornado/SA_XScale/host/...             ARM_TORNADO_LINUX_V2.2.1
element /cm4/tools/WRS/tornado/SA_XScale/...                  ARM_TORNADO_V2.2.1_PATCH2
element /cm4/tools/WRS/tornado/SA_XScale/...                  ARM_TORNADO_V2.2.1_PATCH1
element /cm4/tools/WRS/tornado/SA_XScale/...                  ARM_TORNADO_V2.2.1
element -dir /cm4/tools/GNU/SunOS_5.6/lib	  /main/8
element /cm4/tools/GNU/SunOS_5.6/lib/libpcap.a    /main/fdt031/1
element /vobs/esam/configspecs/@@/main/50/ISAM_GHS.cs  /main/1
#include /view/LATEST/vobs/esam/configspecs/@@/main/50/ISAM_GHS.cs@@/main/1
#---- entering 1 /view/LATEST/vobs/esam/configspecs/@@/main/50/ISAM_GHS.cs@@/main/1
element -directory /cm4/tools/GHS /main/12
element -directory /cm4/tools/GHS/arm /main/1
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7_PATCH5
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7_PATCH4
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7_PATCH3
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7_PATCH2
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7_PATCH1
element /cm4/tools/GHS/ppc/...  GHS_PPC_MULTI2000_V4.0.7
#---- leaving  1 /view/LATEST/vobs/esam/configspecs/@@/main/50/ISAM_GHS.cs@@/main/1
element /vobs/dsl/source09/AsamSyst/...                        MOD_ASAMSYST_AA_V8.2.3
element /vobs/dsl/source03/EqptCoreNt/...                      MOD_EQPTCORENT_AA_V11.1.31
element /vobs/dsl/ISSLoad/ECNT-C/...                           MOD_ISS_ECNT-C_V3.3.20.4
element /vobs/dsl/source06/xDSLMGR-NT/...                      MOD_XDSLMGR-NT_AA_V11.0.24
element /vobs/dsl/source03/AcuCtrl/...                         MOD_ACUCTRL_AA_V6.0.9
element /vobs/dsl/source04/RipSpi/...                          MOD_RIPSPI_AA_V5.1.5
element /vobs/dsl/source01/Atm2Nt/...                          MOD_ATM2NT_AA_V12.1.3
element /cm4/fsn/krnl/debug/...                                MOD_TRDB_AA_V5.0.0
element /vobs/dsl/source03/Interfaces/...                      MOD_INTERFACES_AA_V12.2.39
element /cm4/fsn/platform/datamngt/...                         MOD_DATAMNGT_AA_V3.85.16
element /vobs/dsl/source04/NP_IXP2350_UC_EB_Image/...          MOD_NP_IXP2350_UC_EB_IMAGE_AA_V3.2.17
element /vobs/dsl/source04/NP_IXP2350_UC_Image/...             MOD_NP_IXP2350_UC_IMAGE_AA_V7.2.17
element /vobs/dsl/source04/NP_IXP2350_UC_NELTA_Image/...       MOD_NP_IXP2350_UC_NELTA_IMAGE_AA_V2.2.18
element /vobs/dsl/source04/NP_IXP2350_UC_REM_IMAGE/...         MOD_NP_IXP2350_UC_REM_IMAGE_AA_V4.2.17
element /vobs/dsl/source04/NP_IXP2350_UC_SHDSL_Image/...       MOD_NP_IXP2350_UC_SHDSL_IMAGE_AA_V4.2.18
element /vobs/dsl/source04/NP_IXP2350_UC_SLB_Image/...         MOD_NP_IXP2350_UC_SLB_IMAGE_AA_V5.2.16
element /vobs/dsl/source04/NP_IXP2350_UC_VDSL_Image/...        MOD_NP_IXP2350_UC_VDSL_IMAGE_AA_V6.2.16
element /vobs/dsl/source04/NP_IXP2400_IWSM_Image/...           MOD_NP_IXP2400_IWSM_IMAGE_AA_V5.4.16
element /vobs/dsl/source04/NP_IXP2400_UC_Image/...             MOD_NP_IXP2400_UC_IMAGE_AA_V9.4.16
element /vobs/dsl/source04/NP_IXP2400_UC_PPPoAoE/...           MOD_NP_IXP2400_UC_PPPOAOE_AA_V4.0.8
element /vobs/dsl/source04/NP_IXP2400_UC_Prot_Filters/...      MOD_NP_IXP2400_UC_PROT_FILTERS_AA_V7.2.2
element /vobs/dsl/source04/NP_IXP2400_UC_VDSL_Image/...        MOD_NP_IXP2400_UC_VDSL_IMAGE_AA_V7.6.16
element /vobs/dsl/source11/NP_IXP2400_hww_QoS/...              MOD_NP_IXP2400_HWW_QOS_AA_V9.2.8
element /cm4/fsn/platform/ObjectServices/TaskConverter/...     MOD_TASKCONVERTER_AA_V1.0.2
element /vobs/dsl/source03/LLUMgntNt/...                       MOD_LLUMGNTNT_AA_V2.3.5
element /vobs/dsl/source08/CLI_AlarmReporting/...              MOD_CLI_ALARMREPORTING_AA_V12.4.5
element /cm4/fsn/app/asam/craft/...                            MOD_CRAFT_AA_V13.5.34
element /vobs/dsl/source10/AsamIds/...                         MOD_ASAMIDS_AA_V7.3.1
element /vobs/esam/build/eant-a/OS/...                         MOD_BLD_OS_EANT-A_AA_V8.10.3
element /vobs/esam/build/ecnt-c/OS/...                         MOD_BLD_OS_ECNT-C_AA_V4.5.1
element /vobs/dsl/source04/EquipHdS/...                        MOD_EQUIPHDS_AA_V8.2.1
element /cm4/fsn/hs/HwWrappersIds/...                          MOD_HWWRAPPERS_IDS_AA_V1.0.0
element /vobs/dsl/source04/I2C_driver/...                      MOD_I2C_DRIVER_AA_V2.2.1
element /vobs/dsl/source02/InitNt/...                          MOD_INITNT_AA_V12.2.1
element /vobs/dsl/source10/NcncHww/...                         MOD_NCNCHWW_AA_V1.0.0
element /vobs/dsl/source10/SfpHww/...                          MOD_SFPHWW_AA_V1.0.0
element /vobs/dsl/source03/SfpMgnt/...                         MOD_SFPMGNT_AA_V5.3.1
element /vobs/dsl/source03/InterfacesLt/...                    MOD_INTERFACESLT_AA_V8.4.10
element /vobs/dsl/source04/NP_LxFwd_itfwrap_QoS/...            MOD_NP_LXFWD_ITFWRAP_QOS_AA_V7.2.10
element /vobs/dsl/source04/ShdslProxy-IFX/...                  MOD_SHDSLPROXY-IFX_AA_V3.3.3
element /vobs/dsl/source02/IP/...                              MOD_IP_AA_V5.4.11
element /vobs/dsl/source07/VlanBridgeMgntNt_migCode/...        MOD_VLANBRIDGEMGNTNT_MIGCODE_AA_V9.2.10
element /vobs/dsl/source02/QoSMgntNt/...                       MOD_QOSMGNTNT_AA_V8.3.23
element /vobs/dsl/source08/CLI_QoS/...                         MOD_CLI_QOS_AA_V11.2.18
element /vobs/dsl/source06/xDSLMGR-LT/...                      MOD_XDSLMGR-LT_AA_V10.1.24
#excluded:element /vobs/dsl/ikanos/xdslproxy_ika/...          MOD_XDSLPROXY_IKA_AA_V6.31.0
element /vobs/dsl/source04/AlarmEventHds/...                   MOD_ALARMEVENTHDS_AA_V6.1.3
element /vobs/dsl/source08/CLI_Equipment/...                   MOD_CLI_EQUIPMENT_AA_V11.5.20
element /vobs/dsl/source02/Alarm/...                           MOD_ALARM_AA_V13.2.14
element /vobs/dsl/source04/BspIxp2400Mmu/...                   MOD_BSPIXP2400MMU_AA_V3.1.1
element /vobs/dsl/source04/Westport_Startup/...                MOD_WESTPORT_STARTUP_AA_V4.2.6
element /vobs/dsl/ISSLoad/...                                  MOD_ISSCODE_V3.3.18.3
element /vobs/dsl/ISSLoad/HostBuild/...                        MOD_ISSCODEHOST_V3.3.18.3
element /vobs/dsl/source08/CLI_System/...                      MOD_CLI_SYSTEM_AA_V11.3.5
element /vobs/dsl/source08/CLI_VLAN/...                        MOD_CLI_VLAN_AA_V11.5.15
element /vobs/dsl/source08/DHCPRelayMgntNt/...                 MOD_DHCPRELAYMGNTNT_AA_V9.1.8
element /vobs/dsl/source04/nslt-a_BSP/...                      MOD_NSLT-A_BSP_AA_V2.0.1
element /vobs/dsl/source04/nslt-a_HWW/...                      MOD_NSLT-A_HWW_AA_V2.0.0
element /vobs/dsl/source07/VlanBridgeMgntLsm/...               MOD_VLANBRIDGEMGNTLSM_AA_V9.2.16
element /vobs/dsl/source02/IpConfig/...                        MOD_IPCONFIG_AA_V9.2.1
element /vobs/dsl/source02/QoSMgntLsm/...                      MOD_QOSMGNTLSM_AA_V7.2.7
element /vobs/dsl/source07/VlanBridgeMgntNt/...                MOD_VLANBRIDGEMGNTNT_AA_V10.1.31
element /vobs/dsl/source02/nvlt-c_Init/...                     MOD_NVLT-C_INIT_AA_V1.1.9
#excluded:element /vobs/dsl/ikanos/xdslproxy_ika/...                     MOD_XDSLPROXY_IKA_AA_V6.27.0
element /vobs/dsl/source04/nelt-a_MISC_TS/...                  MOD_NELT-A_MISC_TS_AA_V1.2.3
element /vobs/dsl/source02/SSH_Glue/...                        MOD_SSH_GLUE_AA_V6.0.8
element /vobs/dsl/source03/CapabilityMgr/...                   MOD_CAPABILITYMGR_AA_V7.8.11
element /vobs/dsl/source02/ConfigDataXml/...                   MOD_CONFIGDATAXML_AA_V8.10.25
element /vobs/dsl/source02/UserIpMgntCommon/...                MOD_USERIPMGNTCOMMON_AA_V9.1.15
element /vobs/dsl/source04/NP_IXP2350_ucode/...                MOD_NP_IXP2350_UCODE_AA_V7.2.4
element /vobs/dsl/source04/nelt-a_TRAFFIC_TS/...               MOD_NELT-A_TRAFFIC_TS_AA_V1.2.1
element /vobs/dsl/source04/NP_LxFwd_itfwrap_PH/...             MOD_NP_LXFWD_ITFWRAP_PH_AA_V9.1.9
element /vobs/dsl/source08/CLI_IP/...                          MOD_CLI_IP_AA_V11.3.11
element /vobs/dsl/source08/CLI_IndexTranslator/...             MOD_CLI_INDEXTRANSLATOR_AA_V11.6.4
element /vobs/dsl/source03/Swm/...                             MOD_SWM_AA_V8.3.7
element /vobs/esam/build/evlt-c/OS/...                         MOD_BLD_OS_EVLT-C_AA_V6.5.1
element /vobs/esam/build/rvlt-a/OS/...                         MOD_BLD_OS_RVLT-A_AA_V4.3.1
element /vobs/dsl/source02/Socket/...                          MOD_SOCKET_AA_V10.0.7
element /vobs/dsl/source02/TCP/...                             MOD_TCP_AA_V2.0.10
element /vobs/dsl/source03/LanxProxy/...                       MOD_LANXPROXY_AA_V7.2.1
element /vobs/dsl/source05/PBMigrationTool/...                 MOD_PBMIGRATIONTOOL_AA_V1.91.20
element /vobs/dsl/source06/xDSLBondingMgntNt/...               MOD_XDSLBONDINGMGNTNT_AA_V7.0.31
element /vobs/esam/build/nvlt-c/oflt_bh/...                    MOD_BLD_OFLT_BH_NVLT-C_AA_V1.1.8
#excluded:element /vobs/dsl/ikanos/ofltproxy_ika/...                     MOD_OFLTPROXY_IKA_AA_V1.12.13
element /vobs/esam/build/nvlt-c/oflt_bh/...                    MOD_BLD_OFLT_BH_NVLT-C_AA_V1.1.8
#excluded:element /vobs/dsl/ikanos/ofltproxy_ika/...                     MOD_OFLTPROXY_IKA_AA_V1.12.13
element /vobs/dsl/source04/nslt-a_TRAFFIC_TS/...               MOD_NSLT-A_TRAFFIC_TS_AA_V1.1.3
element /vobs/dsl/source04/smlt-h_TRAFFIC_TS/...               MOD_SMLT-H_TRAFFIC_TS_AA_V2.1.4
element /vobs/dsl/source08/PPPoEServerMgntNt/...               MOD_PPPOESERVERMGNTNT_AA_V9.1.7
element /vobs/dsl/source02/smlt-h_Init/...                     MOD_SMLT-H_INIT_AA_V3.5.1
element /vobs/esam/build/nelt-a/OS/...                         MOD_BLD_OS_NELT-A_AA_V2.1.7
element /vobs/dsl/source04/pm8374a_driver/...                  MOD_PM8374A_DRIVER_AA_V1.1.5
element /vobs/dsl/source04/NP_LxFwd_itfwrap_PH/...             MOD_NP_LXFWD_ITFWRAP_PH_AA_V9.1.8
element /vobs/dsl/source04/NP_LxFwd_itfwrap_Vlan/...           MOD_NP_LXFWD_ITFWRAP_VLAN_AA_V8.2.8
element /vobs/dsl/source02/ConfigDataXml/...                   MOD_CONFIGDATAXML_AA_V8.10.24
element /vobs/dsl/source02/UserIpMgntCommon/...                MOD_USERIPMGNTCOMMON_AA_V9.1.14
element /vobs/dsl/source06/ShdslMgntCommon/...                 MOD_SHDSLMGNTCOMMON_AA_V3.1.10
element /vobs/dsl/source06/ShdslMgntNt/...                     MOD_SHDSLMGNTNT_AA_V3.1.7
element /vobs/dsl/source08/IGMPMgntNt/...                      MOD_IGMPMGNTNT_AA_V10.4.19
element /vobs/dsl/source03/EqptCoreExtLsm/...                  MOD_EQPTCOREEXTLSM_AA_V11.4.3
element /vobs/dsl/source06/xDSLMGR_migCode/...                 MOD_XDSLMGR_MIGCODE_AA_V3.1.8
element /vobs/dsl/source08/CLI_xDSL/...                        MOD_CLI_XDSL_AA_V11.2.16
element /vobs/dsl/ISSLoad/Migration/...                        MOD_ISSLANXMIGRATION_V1.34.0
element /vobs/dsl/source02/rvlt-a_Init/...                     MOD_RVLT-A_INIT_AA_V3.5.1
element /vobs/dsl/source04/ikanos/...                          MOD_IKANOS_AA_V1.1.7
element /vobs/dsl/source08/IGMPMgntLsm/...                     MOD_IGMPMGNTLSM_AA_V9.4.16
element /vobs/dsl/source04/nvlt-c_TRAFFIC_TS/...               MOD_NVLT-C_TRAFFIC_TS_AA_V1.1.6
element /vobs/dsl/source08/ProtocolTracingMgntNt/...           MOD_PROTOCOLTRACINGMGNTNT_AA_V1.1.8
element /vobs/dsl/source08/CLI_Agent/...                       MOD_CLI_AGENT_AA_V11.5.27
element /vobs/dsl/source08/CLI_Authenticator/...               MOD_CLI_AUTHENTICATOR_AA_V11.1.8
element /vobs/dsl/source08/CLI_Operators/...                   MOD_CLI_OPERATORS_AA_V11.3.2
element /vobs/dsl/source08/CLI_ATM/...                         MOD_CLI_ATM_AA_V11.2.5
element /vobs/dsl/source03/LanxMgnt/...                        MOD_LANXMGNT_AA_V10.1.8
element /vobs/dsl/source08/CLI_Syslog/...                      MOD_CLI_SYSLOG_AA_V2.1.6
element /vobs/dsl/source06/EFMMgntNt/...                       MOD_EFMMGNTNT_AA_V1.1.12
element /vobs/dsl/source08/IGMPMgnt_migCode/...                MOD_IGMPMGNT_MIGCODE_AA_V5.2.9
element /vobs/dsl/source08/CLI_Language/...                    MOD_CLI_LANGUAGE_AA_V11.3.11
element /vobs/dsl/source04/nvlt-c_BOARD/...                    MOD_NVLT-C_BOARD_AA_V1.1.7
element /vobs/dsl/source04/spi_driver/...                      MOD_SPI_DRIVER_AA_V1.1.2
element /vobs/tools/ALCATEL/xml/...                            TOOLS_XML_V1.0.7
element /vobs/esam/build/nslt-a/flashwrite/...                 MOD_BLD_FLASHWRITE_NSLT-A_AA_V1.1.1
element /vobs/esam/build/nslt-a/loader/...                     MOD_BLD_LOADER_NSLT-A_AA_V1.1.3
element /vobs/esam/build/nslt-a/OS/...                         MOD_BLD_OS_NSLT-A_AA_V2.1.6
element /vobs/dsl/source08/CLI_SWManagement/...                MOD_CLI_SWMANAGEMENT_AA_V11.2.13
element /vobs/esam/build/eblt-e/OS/...                         MOD_BLD_OS_EBLT-E_AA_V6.5.1
element /vobs/dsl/source03/Interfaces_migCode/...              MOD_INTERFACES_MIGCODE_AA_V3.0.7
element /vobs/dsl/source08/ProtocolTracingMgntLsm/...          MOD_PROTOCOLTRACINGMGNTLSM_AA_V1.1.3
element /vobs/dsl/source06/EFMMgntLsm/...                      MOD_EFMMGNTLSM_AA_V1.1.2
element /vobs/dsl/source04/NP_IXP2400_ucode/...                MOD_NP_IXP2400_UCODE_AA_V8.3.4
element /vobs/dsl/source02/nslt-a_Init/...                     MOD_NSLT-A_INIT_AA_V1.1.8
element /vobs/dsl/source03/TransportRepository/...             MOD_TRANSPORTREPOSITORY_AA_V1.1.1
element /vobs/dsl/source04/eblt-c_BSP/...                      MOD_EBLT-C_BSP_AA_V2.2.3
element /vobs/dsl/source04/ExtAlarmHds/...                     MOD_EXTALARMHDS_AA_V2.1.10
element /cm4/fsn/hs/xdsl_proxy/ikanos/... MOD_XDSLPROXY-IKA_AA_V5.26.1
element /vobs/dsl/source08/PPPoXRelayMgntLsm/...               MOD_PPPOXRELAYMGNTLSM_AA_V6.0.5
element /vobs/dsl/source03/EqptCoreCommon/...                  MOD_EQPTCORECOMMON_AA_V8.2.6
element /cm4/fsn/krnl/xapi/...                                 MOD_XAPI_AA_V6.1.4
element /vobs/dsl/source01/Atm2Lsm/...                         MOD_ATM2LSM_AA_V8.1.9
element /cm4/fsn/prj/esam/eant-a/export/...                    MOD_ECFG_ESAM-EANT-A_AA_V6.1.1
element /vobs/dsl/source08/IGMPHandlerAOS/...                  MOD_IGMPHANDLERAOS_AA_V4.1.10
element /vobs/dsl/source03/InfraNt/...                         MOD_INFRANT_AA_V8.1.9
element /vobs/dsl/source06/FacMgnt/...                         MOD_FACMGNT_AA_V3.3.7
element /vobs/dsl/mibs/isam_mibs.cs                            3FE21961EAAA_E3.3.0.8
#include /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.8
#---- entering 1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.8
element /vobs/dsl/mibs/...                          3FE21961EAAA_E3.3.0.8
element -dir /vobs/dsl/mibs                         /main/110
element -dir /vobs/dsl/mibs/smilint                 /main/1
element /vobs/dsl/mibs/all_mibs                     /main/aaaa/5
element /vobs/dsl/mibs/Makefile                     /main/aaaa/6
element /vobs/dsl/mibs/isam_mibs.cs                 /main/aaaa/isr33/1
element /vobs/dsl/mibs/mibco.rc                     /main/eaaa/1
element /vobs/dsl/mibs/common.rc                    /main/aaaa/3
element /vobs/dsl/mibs/README                       /main/aaaa/3
element /vobs/dsl/mibs/README.alcatel               /main/aaaa/1
element /vobs/dsl/mibs/.DeliveryList                /main/aaaa/17
element /vobs/dsl/mibs/RFC1493_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/RFC2674_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/lanx/...              MOD_ISS_MIBS_ALC_AA_V3.3.16.0.0
element /vobs/dsl/mibs/rfc1573.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/IANAifType-MIB.mib                        3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/ITF-MIB.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/rfc1155.smi                               3EC36726EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1212.smi                               3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1212.mib                      3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1213.mib                               3EC15591EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1443.mib                               3EC36728EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1215.smi                               3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1215.mib                      3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/SYSTEM_MIB                                3FE23453EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SYSTEM_MIB                           3EC15532EAAA_V3.3.0.3.0
element /vobs/dsl/mibs/ASAM-TC-MIB                               3EC17922EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/TRANSACTION_MIB                           3EC15597EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/TRAP_MIB                                  3EC15362EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/asam_traps.smi                            3EC37309EAAA_V3.1.0.0.2
element /vobs/dsl/mibs/ERROR_MIB                                 3EC15583EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ALARM_MIB                                 3EC15363EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/SNTP_MIB                                  3EC15584EAAA_V3.2.0.2.0
element /vobs/dsl/mibs/ipconfig.mib                              3EC15533EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/IANA_RTPROTO_MIB                          3FE23181EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/INET_ADDRESS_MIB                          3FE23182EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/VRF_MIB                                   3FE21838EAAA_V3.1.0.0.1
element /vobs/dsl/mibs/IPOX_MIB                                  3FE22920EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/ASAM_EQPTCORENT_MIB                       3EC36485EAAA_V3.3.0.0.2
element /vobs/dsl/mibs/ITF_MIB_EXT                               3EC15506EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SWDB_MIB                             3EC36484EAAA_E3.3.2.1
element /vobs/dsl/mibs/ETHER_DOT3_MIB                            3EC17925EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ETHER_MAU_MIB                             3EC17923EAAA_V1.0.0.0.2
element /vobs/dsl/mibs/IGMP_MIB                                  3FE20080EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/Plim_mib                                  3EC37662EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/ATM_MIB                                   3EC15358EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ATM-TC-MIB                                3EC16471EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ATM_EXT_MIB                               3EC15357EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ATM-M4_MIB                                3EC17924EAAA_V3.2.0.1.1
element /vobs/dsl/mibs/XDSL_MIB                                  3FE21279EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/IQ_ACCESS_MIB	                         3EC15596EAAA_V2.4.0.0.0
element /vobs/dsl/mibs/SELT_MIB                                  3FE24290EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/BONDING_MIB                               3FE22952EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/CPEPROXYMIB                               3FE24629EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/DHCP_MIB                                  3FE21837EAAA_V3.1.0.1.0
element /vobs/dsl/mibs/AAA_MIB                                   3FE22800EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/RADIUS_MIB                                3FE50082EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/IPPOOL_MIB                                3FE29189EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ESAM_802DOT1X_MIB                         3FE22192EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_802DOT1X_EXT_MIB                     3FE22638EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_PPP_MIB                              3FE22732EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/QOS_MIB                                  3FE22870EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/PPPOXRELAY_MIB                            3FE23869EAAA_V3.1.0.0.1
element /vobs/dsl/mibs/CLUSTER_MIB                               3FE24378EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc3411_SNMP_FRAMEWORK_MIB                3FE25473AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3412_SNMP_MPD_MIB                      3FE25474AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.rc                3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB                   3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.smiv2             3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3414_SNMP_USM_MIB                      3FE25478AAAA_V1.0.0.1.1
element /vobs/dsl/mibs/rfc3415_SNMP_VACM_MIB                     3FE25479AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/SSH_MIB                                   3FE25576EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/ESAM_SFP_MIB                              3FE25209EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/IPOA_L2_MIB                               3FE25208EAAA_V3.2.0.1.0
element  /vobs/dsl/mibs/L2CP_MIB                                 3FE27269AAAA_V2.4.0.1.3
element /vobs/dsl/mibs/SYSLOG_MIB                                 3FE25213EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/INT_TEST_SEAL_CUR_MIB                      3FE26729EAAA_V3.1.0.2.0
element /vobs/dsl/mibs/SIP-MIB.mib                                3FE25582EAAA_V3.3.0.0.2
element /vobs/dsl/mibs/IMA_MIB                                    3FE20281EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_IMA_MIB                               3FE20282EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SHDSL_MIB                             3EC17695EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/EXTEND-ETHER-MIB                           3FE23284EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/FILE-TRANSFER-MIB                          3FE29223EAAA_V3.3.0.2.1
element /vobs/dsl/mibs/rfc2864.mib                                3FE26708EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/TROUBLESHOOTING-MIB                        3FE28654EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/.DeliveryList*                             /main/eaaa/LATEST
element /vobs/dsl/mibs/.DeliveryList*                             /main/aaaa/LATEST
element /vobs/dsl/mibs/... -error
#---- leaving  1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.8
element /vobs/dsl/source02/UserIpMgntNt/...                    MOD_USERIPMGNTNT_AA_V9.1.13
element /vobs/dsl/interpeak/ssh/...                            MOD_SSH_AA_V5.0.10
element /vobs/dsl/source08/CLI_IGMP/...                        MOD_CLI_IGMP_AA_V11.2.10
element /cm4/fsn/krnl/error/...                                MOD_ERROR_AA_V1.7.4
element /cm4/fsn/krnl/config/...                               MOD_KRNLCONFIG_AA_V7.0.3
element /vobs/dsl/source08/PPPoEServerMgntLsm/...              MOD_PPPOESERVERMGNTLSM_AA_V9.1.4
element /vobs/dsl/source08/PPPoEServerPrtcls/...               MOD_PPPOESERVERPRTCLS_AA_V9.1.3
element /vobs/dsl/source03/EqptLib_data/...                    MOD_EQPTLIB_DATA_AA_V1.1.4
element /vobs/dsl/source03/EqptLib_migCode/...                 MOD_EQPTLIB_MIGCODE_AA_V3.0.3
element /vobs/dsl/source06/xDSLBondingMgntNt_migCode/...       MOD_XDSLBONDINGMGNTNT_MIGCODE_AA_V5.0.2
element /vobs/dsl/source04/NP_IXP2350_UC_SHDSL_Image/Target/smlt_wp_target.uof /main/aaaa/fdt433/6
element /vobs/dsl/source08/IGMPCDRMgntNt/...                   MOD_IGMPCDRMGNTNT_AA_V3.99.18
element /vobs/dsl/source02/MainTaskINTEGRITY/...               MOD_MAINTASKINTEGRITY_AA_V3.1.3
element /vobs/dsl/source02/PSOS2INTEGRITY/...                  MOD_PSOS2INTEGRITY_AA_V1.0.25
element /vobs/dsl/source03/ITSCModuleMgnt/...                  MOD_ITSCMODULEMGNT_AA_V1.3.8
element /vobs/dsl/source08/CLI_IP/...                          MOD_CLI_IP_AA_V11.3.10
element /vobs/dsl/source10/CommonInclude/...                   MOD_COMMONINCLUDE_AA_V4.0.2
element /cm4/fsn/krnl/fs/promdrv/...                           MOD_FSPROM_AA_V2.1.4
element /vobs/dsl/source04/GEComm_hww/...                      MOD_GECOMM_HWW_AA_V5.2.2
element /vobs/dsl/source02/InitLt/...                          MOD_INITLT_AA_V4.1.7
element /cm4/fsn/app/asam/transaction/...                      MOD_TRANSACT_AA_V5.1.5
element /vobs/dsl/source03/HWW_ITFM/...                        MOD_HWW_ITFM_AA_V10.3.2
element /vobs/dsl/source06/ShdslMgntLsm/...                    MOD_SHDSLMGNTLSM_AA_V3.0.3
element /vobs/dsl/source08/L2CPNt/...                          MOD_L2CPNT_AA_V3.0.5
element /cm4/fsn/hs/xdsl_proxy/bcm6410/...                     MOD_XDSLPROXY-BCM_V6.11.0
element /vobs/dsl/source04/eblt-m_RI_HAL/...                   MOD_EBLT-M_RI_HAL_AA_V1.1.2
element /cm4/fsn/app/servers/login/...                         MOD_LOGIN_AA_V3.0.2
element /vobs/dsl/mibs/ASAM_EQPTCORENT_MIB                     3EC36485EAAA_FDT433.V3.3.0.2.2
element /vobs/dsl/source04/NP_IXP2400_UC_PP_L2/...             MOD_NP_IXP2400_UC_PP_L2_AA_V8.2.5
element /vobs/dsl/source04/NP_IXP2350_UC_Rx_Tx_Drivers/...     MOD_NP_IXP2350_UC_RX_TX_DRIVERS_AA_V8.1.5
element /vobs/esam/build/release_info/release 		      /main/aaaa/isr33/1
element /vobs/dsl/source04/nelt-a_BSP/...                      MOD_NELT-A_BSP_AA_V1.2.5
element /vobs/dsl/source08/CLI_PPPoE/...                       MOD_CLI_PPPOE_AA_V11.1.3
element /vobs/dsl/source08/CLI_ETHITF/...                      MOD_CLI_ETHITF_AA_V11.1.7
element /vobs/dsl/source08/PPPoXRelayMgntNt/...                MOD_PPPOXRELAYMGNTNT_AA_V6.1.5
element /vobs/dsl/source03/CapabilityMgr/...                   MOD_CAPABILITYMGR_AA_V7.8.10
element /vobs/dsl/source04/NP_LxFwd_itfwrap_ATM/...            MOD_NP_LXFWD_ITFWRAP_ATM_AA_V3.1.6
#excluded:element /vobs/dsl/conexant/...                                 MOD_CONEXANT_AA_V3.91.19
element /vobs/dsl/source04/nelt-a_EPLD_HAL/...                 MOD_NELT-A_EPLD_HAL_AA_V1.1.1
element /vobs/dsl/source04/nelt-a_MISC_TS/...                  MOD_NELT-A_MISC_TS_AA_V1.2.2
element /vobs/dsl/source04/GenLxFwdWrapItf/...                 MOD_GENLXFWDWRAPITF_AA_V3.5.3
element /vobs/dsl/source03/REDCY_protMgnt/...                  MOD_REDCY_PROTMGNT_AA_V5.1.6
element /vobs/dsl/source03/REDCY_synchronizer/...              MOD_REDCY_SYNCHRONIZER_AA_V6.0.4
element /vobs/dsl/source08/CLI_Transport/...                   MOD_CLI_TRANSPORT_AA_V11.1.12
#excluded:element /vobs/dsl/source13/VoiceAppMgntNt/...                  MOD_VOICEAPPMGNTNT_AA_V2.0.9
element /vobs/dsl/source04/NP_IXP2400_hww_L3fwd/...            MOD_NP_IXP2400_HWW_L3FWD_AA_V6.1.5
element /cm4/fsn/krnl/bsp/dev/pic/...                          MOD_BSP_DEV_PIC_AA_V3.0.0
element /vobs/dsl/source02/HostGenericLLDriver/...             MOD_HOSTGENERICLLDRIVER_AA_V3.0.0
element /vobs/dsl/source11/NP_IXP2400_hww_Vlan/...             MOD_NP_IXP2400_HWW_VLAN_AA_V8.0.9
element /vobs/dsl/source03/EqptExpanderMgnt/...                MOD_EQPTEXPANDERMGNT_AA_V3.2.7
element /cm4/fsn/krnl/misc/...                                 MOD_KRNLMISC_AA_V3.0.13
#include /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.7
#---- entering 1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.7
element /vobs/dsl/mibs/...                          3FE21961EAAA_E3.3.0.7
element -dir /vobs/dsl/mibs                         /main/110
element -dir /vobs/dsl/mibs/smilint                 /main/1
element /vobs/dsl/mibs/all_mibs                     /main/aaaa/5
element /vobs/dsl/mibs/Makefile                     /main/aaaa/6
element /vobs/dsl/mibs/isam_mibs.cs                 /main/aaaa/110
element /vobs/dsl/mibs/mibco.rc                     /main/eaaa/1
element /vobs/dsl/mibs/common.rc                    /main/aaaa/3
element /vobs/dsl/mibs/README                       /main/aaaa/3
element /vobs/dsl/mibs/README.alcatel               /main/aaaa/1
element /vobs/dsl/mibs/.DeliveryList                /main/aaaa/17
element /vobs/dsl/mibs/RFC1493_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/RFC2674_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/lanx/...              MOD_ISS_MIBS_ALC_AA_V3.3.16.0.0
element /vobs/dsl/mibs/rfc1573.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/IANAifType-MIB.mib                        3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/ITF-MIB.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/rfc1155.smi                               3EC36726EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1212.smi                               3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1212.mib                      3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1213.mib                               3EC15591EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1443.mib                               3EC36728EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1215.smi                               3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1215.mib                      3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/SYSTEM_MIB                                3FE23453EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SYSTEM_MIB                           3EC15532EAAA_V3.3.0.3.0
element /vobs/dsl/mibs/ASAM-TC-MIB                               3EC17922EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/TRANSACTION_MIB                           3EC15597EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/TRAP_MIB                                  3EC15362EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/asam_traps.smi                            3EC37309EAAA_V3.1.0.0.2
element /vobs/dsl/mibs/ERROR_MIB                                 3EC15583EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ALARM_MIB                                 3EC15363EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/SNTP_MIB                                  3EC15584EAAA_V3.2.0.2.0
element /vobs/dsl/mibs/ipconfig.mib                              3EC15533EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/IANA_RTPROTO_MIB                          3FE23181EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/INET_ADDRESS_MIB                          3FE23182EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/VRF_MIB                                   3FE21838EAAA_V3.1.0.0.1
element /vobs/dsl/mibs/IPOX_MIB                                  3FE22920EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/ASAM_EQPTCORENT_MIB                       3EC36485EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/ITF_MIB_EXT                               3EC15506EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SWDB_MIB                             3EC36484EAAA_E3.3.2.1
element /vobs/dsl/mibs/ETHER_DOT3_MIB                            3EC17925EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ETHER_MAU_MIB                             3EC17923EAAA_V1.0.0.0.2
element /vobs/dsl/mibs/IGMP_MIB                                  3FE20080EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/Plim_mib                                  3EC37662EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/ATM_MIB                                   3EC15358EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ATM-TC-MIB                                3EC16471EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ATM_EXT_MIB                               3EC15357EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ATM-M4_MIB                                3EC17924EAAA_V3.2.0.1.1
element /vobs/dsl/mibs/XDSL_MIB                                  3FE21279EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/IQ_ACCESS_MIB	                         3EC15596EAAA_V2.4.0.0.0
element /vobs/dsl/mibs/SELT_MIB                                  3FE24290EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/BONDING_MIB                               3FE22952EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/CPEPROXYMIB                               3FE24629EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/DHCP_MIB                                  3FE21837EAAA_V3.1.0.1.0
element /vobs/dsl/mibs/AAA_MIB                                   3FE22800EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/RADIUS_MIB                                3FE50082EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/IPPOOL_MIB                                3FE29189EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ESAM_802DOT1X_MIB                         3FE22192EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_802DOT1X_EXT_MIB                     3FE22638EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_PPP_MIB                              3FE22732EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/QOS_MIB                                  3FE22870EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/PPPOXRELAY_MIB                            3FE23869EAAA_V3.1.0.0.1
element /vobs/dsl/mibs/CLUSTER_MIB                               3FE24378EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc3411_SNMP_FRAMEWORK_MIB                3FE25473AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3412_SNMP_MPD_MIB                      3FE25474AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.rc                3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB                   3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.smiv2             3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3414_SNMP_USM_MIB                      3FE25478AAAA_V1.0.0.1.1
element /vobs/dsl/mibs/rfc3415_SNMP_VACM_MIB                     3FE25479AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/SSH_MIB                                   3FE25576EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/ESAM_SFP_MIB                              3FE25209EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/IPOA_L2_MIB                               3FE25208EAAA_V3.2.0.1.0
element  /vobs/dsl/mibs/L2CP_MIB                                 3FE27269AAAA_V2.4.0.1.3
element /vobs/dsl/mibs/SYSLOG_MIB                                 3FE25213EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/INT_TEST_SEAL_CUR_MIB                      3FE26729EAAA_V3.1.0.2.0
element /vobs/dsl/mibs/SIP-MIB.mib                                3FE25582EAAA_V3.3.0.0.2
element /vobs/dsl/mibs/IMA_MIB                                    3FE20281EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_IMA_MIB                               3FE20282EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SHDSL_MIB                             3EC17695EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/EXTEND-ETHER-MIB                           3FE23284EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/FILE-TRANSFER-MIB                          3FE29223EAAA_V3.3.0.2.1
element /vobs/dsl/mibs/rfc2864.mib                                3FE26708EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/TROUBLESHOOTING-MIB                        3FE28654EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/.DeliveryList*                             /main/eaaa/LATEST
element /vobs/dsl/mibs/.DeliveryList*                             /main/aaaa/LATEST
element /vobs/dsl/mibs/... -error
#---- leaving  1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.7
element /vobs/dsl/source07/VlanBridgeMgntCommon/...            MOD_VLANBRIDGEMGNTCOMMON_AA_V7.2.6
element /vobs/dsl/source06/EthMgntNt/...                       MOD_ETHMGNTNT_AA_V1.1.11
element /cm4/fsn/krnl/os/VXWORKS/...                           MOD_KRNLOS_VXWORKS_AA_V4.0.6
element /vobs/dsl/source08/UserIpForwarding/...                MOD_USERIPFORWARDING_AA_V3.1.2
element /vobs/dsl/source02/FileTransfer/...                    MOD_FILETRANSFER_AA_V1.2.10
element /vobs/dsl/source02/SSH_Glue/...                        MOD_SSH_GLUE_AA_V6.0.7
element /vobs/dsl/source08/IpNetToMedia/...                    MOD_IPNETTOMEDIA_AA_V3.1.22
#excluded:element /vobs/dsl/source13/polt-a_Init/...                     MOD_POLT-A_INIT_AA_V2.2.3
element /vobs/dsl/source02/FTPClient/...                       MOD_FTPCLIENT_AA_V1.2.4
element /vobs/dsl/source04/IMA_hww/...                         MOD_IMA_HWW_AA_V2.2.4
element /vobs/dsl/source04/eblt-c_BOARD/...                    MOD_EBLT-C_BOARD_AA_V5.0.2
element /vobs/dsl/source04/eblt-c_RI/...                       MOD_EBLT-C_RI_AA_V1.0.14
element /vobs/dsl/source08/DHCPRelay/...                       MOD_DHCPRELAY_AA_V10.1.12
element /vobs/dsl/source06/EthMgntCommon/...                   MOD_ETHMGNTCOMMON_AA_V1.1.8
element /vobs/dsl/source04/NP_IXP2400_UC_Packet_Editing/...    MOD_NP_IXP2400_UC_PACKET_EDITING_AA_V7.2.5
element /vobs/dsl/source04/NP_IXP2400_UC_VLAN/...              MOD_NP_IXP2400_UC_VLAN_AA_V10.2.2
element /vobs/esam/build/oflmt/oflmt/...                       MOD_BLD_OFLMT_AA_V10.1.3
element /vobs/esam/build/eblt-c/OS/...                         MOD_BLD_OS_EBLT-C_AA_V8.2.3
element /vobs/esam/build/eblt-g/OS/...                         MOD_BLD_OS_EBLT-G_AA_V4.2.3
element /vobs/esam/build/evlt-a/OS/...                         MOD_BLD_OS_EVLT-A_AA_V8.1.4
element /vobs/dsl/source08/LocalIPAddressMgnt/...              MOD_LOCALIPADDRESSMGNT_AA_V5.0.1
element /cm4/fsn/krnl/bsp/Makefile  /main/fdt433/2
element /vobs/dsl/source03/REDCY_swolo/...                     MOD_REDCY_SWOLO_AA_V6.1.6
element /cm4/fsn/app/asam/common/types/...                     MOD_ASAM_COMMON_TYPES_AA_V12.6.7
element /vobs/dsl/source06/xDSLMGR-COMMON/...                  MOD_XDSLMGR-COMMON_AA_V10.2.7
element /vobs/dsl/source08/CLI_SSH/...                         MOD_CLI_SSH_AA_V3.1.8
element /vobs/dsl/source03/AsamDld/...                         MOD_ASAMDLD_AA_V2.5.5
element /vobs/esam/build/ealt-a/OS/...                         MOD_BLD_OS_EALT-A_AA_V7.2.2
element /vobs/esam/build/eblt-a/OS/...                         MOD_BLD_OS_EBLT-A_AA_V5.2.2
element /vobs/esam/build/eblt-j/OS/...                         MOD_BLD_OS_EBLT-J_AA_V4.5.2
element /vobs/esam/build/nalt-a/OS/...                         MOD_BLD_OS_NALT-A_AA_V2.1.1
element /vobs/dsl/source03/EqptEdseProxy/...                   MOD_EQPTEDSEPROXY_AA_V4.1.6
element /vobs/dsl/source03/ResourceAndChainMgnt/...            MOD_RESOURCEANDCHAINMGNT_AA_V2.1.4
element /vobs/dsl/source02/evlt-f_Init/...                     MOD_EVLT-F_INIT_AA_V2.2.4
element /vobs/dsl/source02/nalt-a_Init/...                     MOD_NALT-A_INIT_AA_V2.1.1
element /vobs/dsl/source02/nelt-a_Init/...                     MOD_NELT-A_INIT_AA_V1.2.3
element /vobs/dsl/source03/AsamDld/...                         MOD_ASAMDLD_AA_V2.5.5
element /vobs/dsl/source05/AsamTrap/...                        MOD_ASAMTRAP_AA_V1.2.3
element /vobs/dsl/source04/Clock/...                           MOD_CLOCK_AA_V6.0.2
element /vobs/dsl/source03/MTA_NT/...                          MOD_MTA_NT_AA_V7.1.13
element /cm4/fsn/platform/persloss/...                         MOD_PERSLOSS_AA_V1.0.4
element /vobs/dsl/source02/Rack/...                            MOD_RACK_AA_V7.0.1
element /vobs/dsl/source03/RelayMgntNt/...                     MOD_RELAYMGNTNT_AA_V1.3.1
element /cm4/fsn/app/snmp/agent/...                            MOD_SNMPAGENT_AA_V4.0.18
element /vobs/dsl/source02/LanxCallTableInit/...               MOD_LANXCALLTABLEINIT_AA_V2.2.0
element /vobs/dsl/source04/EthLine_hww/...                     MOD_ETHLINE_HWW_AA_V1.2.3
element /cm4/fsn/app/asam/systemDataMgnt/common/...            MOD_SYSDATMGR-COMMON_AA_V2.0.6
element /vobs/esam/build/polt-b/OS/...                         MOD_BLD_OS_POLT-B_AA_V1.3.4
#excluded:element /vobs/dsl/source13/DHCPClient/...                      MOD_DHCPCLIENT_AA_V1.0.3
element /vobs/dsl/source03/LLUMgntLt/...                       MOD_LLUMGNTLT_AA_V3.1.4
#excluded:element /vobs/dsl/source13/SipWrapper/...                      MOD_SIPWRAPPER_AA_V1.0.10
element /vobs/gpon/sw/src03/apps/VoIP/...                      MOD_VOIP_AA_V1.1.8
#excluded:element /vobs/dsl/source13/VoiceAppMgntLsm/...                 MOD_VOICEAPPMGNTLSM_AA_V1.0.14
#excluded:element /vobs/dsl/source13/polt-a_BSP/...                      MOD_POLT-A_BSP_AA_V2.1.6
#excluded:element /vobs/dsl/source13/polt-a_PtpxVin/...                  MOD_POLT-A_PTPXVIN_AA_V3.0.6
element /vobs/dsl/source04/nslt-a_BOARD/...                    MOD_NSLT-A_BOARD_AA_V1.1.2
element /vobs/dsl/source04/smlt-h_IMA/...                      MOD_SMLT-H_IMA_AA_V2.1.3
element /vobs/dsl/source03/EqptCtrlLt/...                      MOD_EQPTCTRLLT_AA_V7.3.10
element /vobs/dsl/source04/HsHwWrapper/...                     MOD_HSHWWRAPPER_AA_V10.0.4
element /vobs/dsl/source04/HsRip_Boards/...                    MOD_HSRIP_BOARDS_AA_V9.1.4
element /vobs/dsl/source04/EthLine_hww/...                     MOD_ETHLINE_HWW_AA_V1.2.3
element /vobs/dsl/source02/UserIpMgntLsm/...                   MOD_USERIPMGNTLSM_AA_V4.1.2
#excluded:element /vobs/dsl/source13/polt-a_GePhy/...                    MOD_POLT-A_GEPHY_AA_V2.1.4
element /vobs/dsl/source06/SELTLiteLt/...                      MOD_SELTLITELT_AA_V5.1.2
element /vobs/dsl/source08/craft_migCode/...                   MOD_CRAFT_MIGCODE_AA_V2.0.3
element /vobs/dsl/source08/IGMPStack/...                       MOD_IGMPSTACK_AA_V7.3.6
element /vobs/dsl/source11/NP_IXP2400_hww_DEBUG/...            MOD_NP_IXP2400_HWW_DEBUG_AA_V7.2.5
element /vobs/dsl/source11/NP_IXP2400_hww_MC/...               MOD_NP_IXP2400_HWW_MC_AA_V4.1.1
element /vobs/dsl/source04/NP_LxFwd_itfwrap_MC/...             MOD_NP_LXFWD_ITFWRAP_MC_AA_V3.1.4
element /vobs/dsl/source02/evlt-c_Init/...                     MOD_EVLT-C_INIT_AA_V6.4.1
element /vobs/dsl/source02/eblt-k_Init/...                     MOD_EBLT-K_INIT_AA_V4.3.1
element /vobs/dsl/source02/evlt-a_Init/...                     MOD_EVLT-A_INIT_AA_V6.4.1
element /vobs/dsl/mibs/ALARM_MIB                               3EC15363EAAA_V3.3.0.2.0
element /vobs/dsl/source11/NP_IXP2400_hww_ATM/...              MOD_NP_IXP2400_HWW_ATM_AA_V5.2.1
element /vobs/dsl/source04/NP_IXP2400_hww_PPPoAoE/...          MOD_NP_IXP2400_HWW_PPPOAOE_AA_V5.0.2
element /vobs/dsl/source04/NP_LxFwd_itfwrap_L3fwd/...          MOD_NP_LXFWD_ITFWRAP_L3FWD_AA_V5.1.3
element /vobs/dsl/source08/CLI_IndexTranslator/...             MOD_CLI_INDEXTRANSLATOR_AA_V11.6.3
element /vobs/dsl/source04/NP_IXP2400_UC_Rx_Tx_Drivers/...     MOD_NP_IXP2400_UC_RX_TX_DRIVERS_AA_V8.1.4
element /vobs/dsl/source02/GenLxFwdAdapter/...                 MOD_GENLXFWDADAPTER_AA_V3.1.4
element /vobs/dsl/source02/ecnt-c_Init/...                     MOD_ECNT-C_INIT_AA_V1.3.6
element /cm4/tools/GHS/integrity/ppc/ECNTC_ABSP/...            MOD_ECNTC_ABSP_BIN_AA_V3.0.1
element /vobs/dsl/source04/INTEGRITY_ECNTC_ABSP/...            MOD_INTEGRITY_ECNTC_ABSP_AA_V3.0.1
element /vobs/dsl/source04/BootLdrNepWestportLsm/...           MOD_BOOTLDRNEPWESTPORTLSM_AA_V2.3.4
element /vobs/dsl/source04/nelt-a_BOARD/...                    MOD_NELT-A_BOARD_AA_V1.2.2
element /vobs/dsl/source04/pm8374a_phy/...                     MOD_PM8374A_PHY_AA_V1.3.1
element /vobs/dsl/source04/eblt-j_Init/...                     MOD_EBLT-J_INIT_AA_V4.1.3
element /vobs/dsl/source06/ImaMgntNt/...                       MOD_IMAMGNTNT_AA_V2.1.11
element /vobs/dsl/source08/CLI_SHDSL/...                       MOD_CLI_SHDSL_AA_V3.0.6
element /vobs/esam/build/evlt-f/OS/...                         MOD_BLD_OS_EVLT-F_AA_V3.1.3
element /vobs/esam/build/nvlt-c/OS/...                         MOD_BLD_OS_NVLT-C_AA_V2.2.2
element /vobs/dsl/source02/SFTP/...                            MOD_SFTP_AA_V4.1.1
element /vobs/dsl/source02/SshTL1Agent/...                     MOD_SSHTL1AGENT_AA_V4.0.2
element /vobs/esam/build/polt-b/loader/...                     MOD_BLD_LOADER_POLT-B_AA_V1.1.5
element /vobs/dsl/source03/EqptCtrlCommon/...                  MOD_EQPTCTRLCOMMON_AA_V4.1.7
element /vobs/dsl/source03/EqptCtrlNt/...                      MOD_EQPTCTRLNT_AA_V6.1.6
element /vobs/dsl/source03/EqptCtrlSlave/...                   MOD_EQPTCTRLSLAVE_AA_V4.2.3
element /vobs/dsl/source04/IFX_Vinetic4M/...                   MOD_IFX_VINETIC4M_AA_V1.3.8
element /cm4/fsn/app/asam/common/memlib/...                    MOD_ASAM_MEMLIB_V1.0.2
element /vobs/dsl/source01/Atm2Common/...                      MOD_ATM2COMMON_AA_V8.1.1
element /vobs/dsl/source03/InitCommon/...                      MOD_INITCOMMON_AA_V2.2.1
element /vobs/dsl/source03/MTA_Common/...                      MOD_MTA_COMMON_AA_V5.4.1
element /vobs/dsl/source08/AAAServer/...                       MOD_AAASERVER_AA_V8.0.2
element /vobs/dsl/source08/SNMPv3MAPPER/...                    MOD_SNMPV3MAPPER_AA_V6.0.5
element /vobs/dsl/source03/InfraNt/...                         MOD_INFRANT_AA_V8.1.8
element /cm4/fsn/krnl/types/...                                MOD_KTYPES_AA_V1.0.2
element /vobs/dsl/source08/CLI_AAA/...                         MOD_CLI_AAA_AA_V9.2.3
element /vobs/dsl/source08/CLI_CPEMGNT/...                     MOD_CLI_CPEMGNT_AA_V3.2.3
element /vobs/dsl/source08/CLI_Cluster/...                     MOD_CLI_CLUSTER_AA_V5.0.3
element /vobs/dsl/source08/CLI_DHCP/...                        MOD_CLI_DHCP_AA_V11.1.4
element /vobs/dsl/source08/CLI_Debug/...                       MOD_CLI_DEBUG_AA_V1.1.3
element /vobs/dsl/source08/CLI_Error/...                       MOD_CLI_ERROR_AA_V11.4.4
element /vobs/dsl/source08/CLI_IMA/...                         MOD_CLI_IMA_AA_V2.1.5
element /vobs/dsl/source08/CLI_IPOACC/...                      MOD_CLI_IPOACC_AA_V11.0.2
element /vobs/dsl/source08/CLI_L2CP/...                        MOD_CLI_L2CP_AA_V11.0.2
element /vobs/dsl/source08/CLI_MSTP/...                        MOD_CLI_MSTP_AA_V1.1.3
element /vobs/dsl/source08/CLI_OSPF/...                        MOD_CLI_OSPF_AA_V11.0.3
element /vobs/dsl/source08/CLI_RIP/...                         MOD_CLI_RIP_AA_V11.0.5
element /vobs/dsl/source08/CLI_SIP/...                         MOD_CLI_SIP_AA_V9.1.12
element /vobs/dsl/source08/CLI_CPEMGNT/...                     MOD_CLI_CPEMGNT_AA_V3.2.3
element /vobs/dsl/source08/CLI_Cluster/...                     MOD_CLI_CLUSTER_AA_V5.0.3
element /vobs/dsl/source08/CLI_IPOACC/...                      MOD_CLI_IPOACC_AA_V11.0.2
element /vobs/dsl/source08/IGMPMgntCommon/...                  MOD_IGMPMGNTCOMMON_AA_V8.3.2
element /vobs/dsl/source08/IPoXIWLMgntNt/...                   MOD_IPOXIWLMGNTNT_AA_V6.0.2
element /cm4/fsn/app/pstack/rfc/...                            MOD_RFC_AA_V1.0.3
element /vobs/dsl/source02/ealt-a_Init/...                     MOD_EALT-A_INIT_AA_V9.3.2
element /vobs/dsl/source02/itsc-a_Init/...                     MOD_ITSC-A_INIT_AA_V1.4.1
element /vobs/dsl/source08/8021xMgntNt/...                     MOD_8021XMGNTNT_AA_V7.0.2
element /vobs/dsl/source02/QoSMgnt_migCode/...                 MOD_QOSMGNT_MIGCODE_AA_V5.0.0
element /vobs/dsl/source03/InterfacesCommon/...                MOD_INTERFACESCOMMON_AA_V8.4.5
element /vobs/dsl/source04/NP_IXP2350_UC_SHDSL_HDS_BOOT/...     MOD_NP_IXP2350_UC_SHDSL_HDS_BOOT_AA_V2.1.3
element /vobs/dsl/source04/NP_IXP2350_UC_SHDSL_HDS_BOOT_BLD/... MOD_NP_IXP2350_UC_SHDSL_HDS_BOOT_BLD_AA_V2.1.3
element /vobs/dsl/source04/ACS_driver/...                      MOD_ACS_DRIVER_AA_V1.1.3
element /vobs/esam/build/asem-b/OS/...                         MOD_BLD_OS_ASEM-B_AA_V2.2.2
element /vobs/esam/build/eblt-k/OS/...                         MOD_BLD_OS_EBLT-K_AA_V3.2.2
element /vobs/esam/build/iwsm-a/OS/...                         MOD_BLD_OS_IWSM-A_AA_V3.2.3
element /vobs/esam/build/smlt-h/OS/...                         MOD_BLD_OS_SMLT-H_AA_V4.1.3
element /vobs/esam/build/vsem-a/OS/...                         MOD_BLD_OS_VSEM-A_AA_V5.1.2
element /vobs/dsl/source11/NP_IXP2350_hww_include/...          MOD_NP_IXP2350_HWW_INCLUDE_AA_V3.2.1
element /vobs/dsl/source04/NP_IXP2350_ucode/...                MOD_NP_IXP2350_UCODE_AA_V7.2.3
element /vobs/dsl/source11/NP_IXP2400_hww_INIT/...             MOD_NP_IXP2400_HWW_INIT_AA_V9.4.2
element /vobs/dsl/source08/8021xMgntLsm/...                    MOD_8021XMGNTLSM_AA_V5.1.2
element /vobs/esam/pSOSun/esim/...                             MOD_ESIM_AA_V8.1.7
element /cm4/fsn/hs/xdsl_proxy/common/export/...               MOD_XDSLAPI-ITF_AA_V5.2.2
element /vobs/esam/build/nvps-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NVPS-A_AA_V1.0.0
element /vobs/esam/build/nvps-a/bootprom/...                   MOD_BLD_BOOTPROM_NVPS-A_AA_V1.0.0
element /vobs/dsl/source09/AsamSyst_migCode/...                MOD_ASAMSYST_MIGCODE_AA_V5.0.2
element /vobs/dsl/source02/PmhCommon/...                       MOD_PMHCOMMON_AA_V5.2.1
element /vobs/esam/build/evlt-f/superflash/...                 MOD_BLD_SUPERFLASH_EVLT-F_AA_V1.0.0
element /cm4/fsn/test/prj/esam/...                             MOD_TEST_ESAM_AA_V4.4.1
element /cm4/tools/BELL/src/idlco/...                          TOOLS_IDLCO_AA_V1.1.3
element /vobs/dsl/mibs/lanx/...                                MOD_ISS_MIBS_ALC_AA_V3.3.16.0.0
element /vobs/esam/build/nvlt-a/superflash/...                 MOD_BLD_SUPERFLASH_NVLT-A_AA_V1.0.4
element /cm4/fsn/app/snmp/mib/...                              MOD_SNMPMIB_AA_V1.1.2
element /vobs/dsl/source04/ecnt-c_BSP/...                      MOD_ECNT-C_BSP_AA_V2.1.4
element /cm4/fsn/build/co/...                                  MOD_BLDCOMMON_V1.18.10
element /cm4/tools/BELL/src/install_usr_dsl/...                TOOLS_INSTALL_USR_DSL_V1.0.5
element /cm4/fsn/krnl/fs/shell/...                             MOD_FSSHELL_AA_V5.0.2
element /cm4/fsn/app/servers/rfs/co/...                        MOD_ASAMRFSCOMMON_AA_V3.0.0
element /vobs/dsl/source04/IMA_driver/...                      MOD_IMA_DRIVER_AA_V2.1.1
element /vobs/dsl/source06/ImaMgntCommon/...                   MOD_IMAMGNTCOMMON_AA_V2.1.10
element /vobs/dsl/source04/UARToI2C/...                        MOD_UARTOI2C_AA_V2.1.1
element /cm4/fsn/krnl/fs/fsapi/...                             MOD_FSAPI_AA_V8.1.1
element /vobs/dsl/source02/ConfigDataCommon/...                MOD_CONFIGDATACOMMON_AA_V3.3.6
element /vobs/dsl/source02/ConfigDataTools/...                 MOD_CONFIGDATATOOLS_AA_V4.1.2
element /vobs/esam/build/nvlt-c/flashwrite/...                 MOD_BLD_FLASHWRITE_NVLT-C_AA_V1.1.2
element /vobs/dsl/source04/nvlt-c_flash/...                    MOD_NVLT-C_FLASH_AA_V1.1.2
element /cm4/fsn/app/pstack/sl/ipsnmp/...                      MOD_IPSNMP_ASAM_AA_V3.85.5
element /cm4/fsn/prj/esam/eant-a/krnlcfg/...                   MOD_KCFG_ESAM_EANT-A_AA_V2.4.1
element /cm4/fsn/app/pstack/sl/ipcfg/...                       MOD_IPCFG_ASAM_AA_V2.1.4
element /vobs/dsl/source03/EXTALMCONF/...                      MOD_EXTALMCONF_AA_V3.0.5
element /cm4/fsn/hs/xdsl_proxy/common/XdslApiDriver/...        MOD_XDSLAPI-DRIVER_AA_V6.4.6
element /vobs/dsl/source04/nvlt-c_ACCESS_TS/...                MOD_NVLT-C_ACCESS_TS_AA_V1.1.4
element /vobs/dsl/source04/smlt-h_RI_HAL/...                   MOD_SMLT-H_RI_HAL_AA_V2.1.2
element /vobs/dsl/source04/LedDrv/...                          MOD_LEDDRV_AA_V5.1.3
element /vobs/gpon/sw/src03/IPTK/...                           MOD_IPTK_AA_V1.0.4
element /vobs/dsl/source08/FormatMgntLsm/...                   MOD_FORMATMGNTLSM_AA_V2.1.5
element /cm4/fsn/test/prj/esam/evlt-c/superflash/...           MOD_BLD_SUPERFLASH_EVLT-C_AA_V1.0.3
element /vobs/dsl/source02/nelt-a_BSP_TEST/...                 MOD_NELT-A_BSP_TEST_AA_V1.2.1
element /vobs/dsl/source04/nvlt-c_BSP/...                      MOD_NVLT-C_BSP_AA_V1.1.4
element /vobs/dsl/source04/nvlt-c_BSP_TEST/...                 MOD_NVLT-C_BSP_TEST_AA_V1.1.3
element /vobs/dsl/source04/bh_rm_com/...                       MOD_BH_RM_COM_AA_V1.1.4
element /vobs/dsl/source04/ACCELITY_HAL/...                    MOD_ACCELITY_HAL_AA_V3.1.2
element /vobs/esam/build/evlt-f/oflt_bh/...                    MOD_BLD_OFLT_BH_EVLT-F_AA_V2.1.1
element /vobs/dsl/source04/evlt-f_BOARD/...                    MOD_EVLT-F_BOARD_AA_V2.1.1
element /vobs/dsl/source04/evlt-f_MISC_TS/...                  MOD_EVLT-F_MISC_TS_AA_V2.1.1
element /vobs/dsl/source04/evlt-f_RI_TS/...                    MOD_EVLT-F_RI_TS_AA_V2.1.1
element /vobs/dsl/source04/evlt-f_TRAFFIC_TS/...               MOD_EVLT-F_TRAFFIC_TS_AA_V2.1.1
element /vobs/dsl/source04/NP_LxFwd_itfwrap_INIT/...           MOD_NP_LXFWD_ITFWRAP_INIT_AA_V9.2.3
element /vobs/dsl/source04/evlt-f_HWW/...                      MOD_EVLT-F_HWW_AA_V2.1.1
element /vobs/esam/build/itsc-a/OS/...                         MOD_BLD_OS_ITSC-A_AA_V1.3.3
element /cm4/tools/BELL/src/dataMgnt/offLineTool/migrator/...  MOD_DMTOOL_AA_V10.1.4
element /vobs/dsl/source03/AsamIdConv/...                      MOD_ASAMIDCONV_AA_V5.3.4
element /vobs/dsl/source03/TestMgntNt/...                      MOD_TESTMGNTNT_AA_V1.3.9
element /vobs/dsl/source03/EqptCoreNt_migCode/...              MOD_EQPTCORENT_MIGCODE_AA_V1.83.4
element /vobs/tools/ALCATEL/idlco/...                          TOOLS_IDL_V1.0.1
element /vobs/esam/build/nelt-a/pmd/...                        MOD_BLD_PMD_NELT-A_AA_V1.2.1
element /vobs/esam/build/nslt-a/pmd/...                        MOD_BLD_PMD_NSLT-A_AA_V1.1.3
element /vobs/dsl/source04/nslt-a_BSP_TEST/...                 MOD_NSLT-A_BSP_TEST_AA_V1.2.1
element /vobs/dsl/source04/LcaProxy/...                        MOD_LCAPROXY_AA_E2.7.0.9
element /vobs/tools/ALCATEL/idlco/...                          TOOLS_IDL_V1.0.1
element /vobs/dsl/source03/TestAndSealCurrMgntItsc/...         MOD_TESTANDSEALCURRMGNTITSC_AA_V1.3.7
element /vobs/dsl/source03/TestMgntNt/...                      MOD_TESTMGNTNT_AA_V1.3.9
element /vobs/dsl/source08/CLI_Common/...                      MOD_CLI_COMMON_AA_V11.1.1
element /vobs/dsl/source01/Atm2Export/...                      MOD_ATM2EXPORT_AA_V7.1.5
element /vobs/dsl/source08/PPPoXRelayMgntNt_migCode/...        MOD_PPPOXRELAYMGNTNT_MIGCODE_AA_V2.2.5
element /vobs/dsl/source03/EqptCommon/...                      MOD_EQPTCOMMON_AA_V11.5.3
element /vobs/dsl/source02/IAL/...                             MOD_IAL_AA_V3.1.2
element /vobs/dsl/source04/BootLdrEsamWestportLsm/...          MOD_BOOTLDRESAMWESTPORTLSM_AA_FDT017.V7.0.0
element /vobs/dsl/source04/rvlt-a_BSP/...                      MOD_RVLT-A_BSP_AA_V4.0.1
element /vobs/dsl/source04/vsem-a_BSP/...                      MOD_VSEM-A_BSP_AA_V5.0.1
element /vobs/dsl/source04/WESTPORT_HAL/...                    MOD_WESTPORT_HAL_AA_V3.1.1
element /vobs/dsl/source04/nvlt-c_HWW/...                      MOD_NVLT-C_HWW_AA_V1.1.2
element /vobs/esam/build/nelt-a/loader/...                     MOD_BLD_LOADER_NELT-A_AA_V1.2.2
element /vobs/dsl/source08/FormatMgntNt/...                    MOD_FORMATMGNTNT_AA_V2.1.1
element /vobs/dsl/source06/SELTLiteNt/...                      MOD_SELTLITENT_AA_V5.1.3
element /vobs/dsl/source08/EnvMonMgnt/...                      MOD_ENVMONMGNT_AA_V1.1.1
element /vobs/dsl/source01/Atm2ItfPortMgnt/...                 MOD_ATM2ITFPORTMGNT_AA_V5.4.1
element /vobs/dsl/mibs/SIP-MIB.mib                             3FE25582EAAA_V3.3.0.0.2
element /vobs/dsl/source04/evlt-c_TRAFFIC_TS/...               MOD_EVLT-C_TRAFFIC_TS_AA_V3.0.4
element /cm4/tools/BELL/src/dataMgnt/offLineTool/migAppInit/... MOD_MIGINT_AA_V7.0.3
element /cm4/fsn/app/servers/sntp/client/...                   MOD_SNTP-CLIENT_AA_V1.1.0
element /cm4/fsn/app/servers/sntp/mapper/...                   MOD_SNTP-MAPPER_AA_V1.2.0
element /cm4/fsn/prj/co/global_defs/...                        MOD_GLOB_DEFS_AA_V8.4.1
element /vobs/dsl/mibs/ASAM_SYSTEM_MIB                         3EC15532EAAA_V3.3.0.3.0
element /vobs/esam/build/nelt-a/chipsim/...                    MOD_CHIPSIM_NELT-A_AA_V2.1.2
element /vobs/dsl/source04/mdio_driver/...                     MOD_MDIO_DRIVER_AA_V1.3.1
element /vobs/dsl/source04/NP_IXP2400_UC_QoS/...               MOD_NP_IXP2400_UC_QOS_AA_V10.2.1
element /vobs/dsl/source03/REDCY_BPS/...                       MOD_REDCY_BPS_AA_V3.0.1
element /vobs/dsl/source04/RipCo/...                           MOD_RIPCO_AA_V7.0.1
#excluded:element /vobs/dsl/envoy/Envoy-CE2CE4_HAL/...                   MOD_ENVOY-CE2CE4_HAL_AA_V1.2.3
element /cm4/fsn/test/prj/co/dummy/...                         MOD_DUMMY_AA_V3.1.2
element /vobs/esam/build/ealt-a/bootprom/...                   MOD_BLD_BOOTPROM_EALT-A_AA_V1.0.1
element /vobs/esam/build/eblt-a/bootprom/...                   MOD_BLD_BOOTPROM_EBLT-A_AA_V1.0.1
element /vobs/esam/build/eblt-j/bootprom/...                   MOD_BLD_BOOTPROM_EBLT-J_AA_V2.0.2
element /vobs/esam/build/ecnt-c/bootprom/...                   MOD_BLD_BOOTPROM_ECNT-C_AA_V1.0.12
element /vobs/esam/build/itsc-a/bootprom/...                   MOD_BLD_BOOTPROM_ITSC-A_AA_V1.2.1
element /vobs/esam/build/asem-b/pmd/...                        MOD_BLD_PMD_ASEM-B_AA_V1.0.3
element /vobs/esam/build/eblt-e/pmd/...                        MOD_BLD_PMD_EBLT-E_AA_V1.0.2
element /vobs/esam/build/eblt-k/pmd/...                        MOD_BLD_PMD_EBLT-K_AA_V1.0.2
element /vobs/esam/build/evlt-f/pmd/...                        MOD_BLD_PMD_EVLT-F_AA_V2.1.1
element /vobs/esam/build/nvlt-c/pmd/...                        MOD_BLD_PMD_NVLT-C_AA_V1.1.1
element /vobs/esam/build/rvlt-a/pmd/...                        MOD_BLD_PMD_RVLT-A_AA_V2.1.2
element /vobs/esam/build/smlt-h/pmd/...                        MOD_BLD_PMD_SMLT-H_AA_V2.1.1
element /vobs/esam/build/vsem-a/pmd/...                        MOD_BLD_PMD_VSEM-A_AA_V1.0.3
element /vobs/esam/build/nant-a/OS/...                         MOD_BLD_OS_NANT-A_AA_V2.13.1
element /vobs/dsl/source04/LibIdl/...                          MOD_LIBIDL_AA_V1.0.4
element /vobs/dsl/source04/Pq2Pro_Startup_Boot/...             MOD_PQ2PRO_STARTUP_BOOT_AA_V2.1.1
element /vobs/tools/ALCATEL/tl1/...                            TOOLS_TL1_TOOLS_V1.2.2
element /cm4/tools/BELL/src/dataMgnt/offLineTool/MAIN/...      MOD_MIGMAIN_AA_V7.1.2
element /vobs/dsl/source04/nvlt-c_CPLD_HAL/...                 MOD_NVLT-C_CPLD_HAL_AA_V1.1.3
element /vobs/dsl/source04/nvlt-c_MISC_TS/...                  MOD_NVLT-C_MISC_TS_AA_V1.1.3
element /vobs/dsl/source04/temperature_sensor_ts/...           MOD_TEMPERATURE_SENSOR_TS_AA_V1.1.2
element /vobs/dsl/source04/Gets/...                            MOD_GETS_AA_V5.1.1
element /vobs/dsl/source04/nelt-a_HWW/...                      MOD_NELT-A_HWW_AA_V1.2.2
element /vobs/dsl/source04/evlt-c_RI/...                       MOD_EVLT-C_RI_AA_V1.1.3
element /vobs/dsl/source08/8021xPrtcls/...                     MOD_8021XPRTCLS_AA_V4.1.1
element /vobs/dsl/source04/BspWestportCo/...                   MOD_BSPWESTPORTCO_AA_V3.1.1
element /cm4/fsn/krnl/bsp/pq2/bsp_dbg/...                      MOD_BSP_PQ2_DBG_V1.0.10
element /cm4/fsn/krnl/bsp/board/pSOSun/...                     MOD_BSP_PSOSUN_AA_V1.1.3
element /vobs/dsl/source03/FirmwareMgnt/...                    MOD_FIRMWAREMGNT_AA_V3.1.8
element /vobs/dsl/source04/eblt-e_BSP_TEST/...                 MOD_EBLT-E_BSP_TEST_AA_V2.1.1
element /vobs/dsl/source04/evlt-a_BSP/...                      MOD_EVLT-A_BSP_AA_V2.2.2
element /vobs/dsl/source04/evlt-c_BSP/...                      MOD_EVLT-C_BSP_AA_V2.2.2
element /vobs/dsl/source04/iwsm-a_BSP/...                      MOD_IWSM-A_BSP_AA_V3.1.1
element /vobs/dsl/source04/nant-a_BSP/...                      MOD_NANT-A_BSP_AA_V1.0.2
element /vobs/dsl/source04/smlt-h_BSP_TEST/...                 MOD_SMLT-H_BSP_TEST_AA_V2.1.1
element /cm4/fsn/platform/syncChannel/...                      MOD_SYNCCHANNEL_V1.0.3
element /vobs/dsl/source02/SyslogMgnt/...                      MOD_SYSLOGMGNT_AA_V3.1.5
element /vobs/dsl/source04/BCM_LxFwd_Itfwrap_VLAN/...          MOD_BCM_LXFWD_ITFWRAP_VLAN_AA_V4.5.1
element /vobs/dsl/source02/UDP/...                             MOD_UDP_AA_V1.0.3
element /vobs/esam/build/rvlt-a/osba/...                       MOD_BLD_OSBA_RVLT-A_AA_V4.0.1
element /vobs/dsl/source09/StartupCo/...                       MOD_STARTUPCO_AA_V3.0.1
element /vobs/dsl/mibs/PPPOXRELAY_MIB                          3FE23869EAAA_V3.1.0.0.1
element /cm4/fsn/krnl/ctxt_switch/...                          MOD_CTXTSWITCH_AA_V1.1.2
element /vobs/dsl/source03/RelayMgntLsm/...                    MOD_RELAYMGNTLSM_AA_V1.2.1
element /vobs/dsl/source04/asem-b_BSP/...                      MOD_ASEM-B_BSP_AA_V1.0.2
element /vobs/dsl/source04/eblt-e_BSP/...                      MOD_EBLT-E_BSP_AA_V3.1.3
element /vobs/dsl/source04/eblt-k_BSP/...                      MOD_EBLT-K_BSP_AA_V2.0.2
element /vobs/dsl/source04/evlt-f_BSP/...                      MOD_EVLT-F_BSP_AA_V2.1.1
element /vobs/dsl/source04/smlt-h_BSP/...                      MOD_SMLT-H_BSP_AA_V2.2.2
element /vobs/dsl/mibs/SNTP_MIB                                3EC15584EAAA_V3.2.0.2.0
element /vobs/dsl/source03/Defense/...                         MOD_DEFENSE_AA_V6.1.0
element /vobs/dsl/source04/HsAsics/...                         MOD_HSASICS_AA_V9.1.0
element /vobs/dsl/source04/HsAsicsECNTC/...                    MOD_HSASICSECNTC_AA_V2.1.0
element /cm4/tools/GNU/src/perl_mods/...                       TOOLS_PERL_MODULES_V1.2.0
element /vobs/dsl/source08/8021xMgntNt_migCode/...             MOD_8021XMGNTNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source01/ATMMgnt_migCode/...                 MOD_ATMMGNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source08/CLI_Community_Mig_Vacm/...          MOD_CLI_COMMUNITY_MIG_VACM_AA_V5.0.3
element /vobs/dsl/source08/CPEMgnt_MigCode/...                 MOD_CPEMGNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source08/DHCPRelayMgntNT_migCode/...         MOD_DHCPRELAYMGNTNT_MIGCODE_AA_V3.4.2
element /vobs/dsl/source08/IPoXIWLMgnt_migCode/...             MOD_IPOXIWLMGNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source08/PPPoEServerMgnt_migCode/...         MOD_PPPOESERVERMGNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source02/SSH_Glue_NT_migCode/...             MOD_SSH_GLUE_NT_MIGCODE_AA_V2.1.2
element /vobs/dsl/source02/UserIpMgnt_migCode/...              MOD_USERIPMGNT_MIGCODE_AA_V4.0.1
element /vobs/dsl/source03/ItfmBroker/...                      MOD_ITFMBROKER_AA_V1.0.2
element /vobs/esam/build/evlt-a/oflt_bh/...                    MOD_BLD_OFLT_BH_EVLT-A_AA_V3.92.1
element /vobs/esam/build/evlt-a/osba/...                       MOD_BLD_OSBA_EVLT-A_AA_V3.1.1
element /vobs/esam/build/asem-b/loader/...                     MOD_BLD_LOADER_ASEM-B_AA_V1.0.6
element /vobs/esam/build/eblt-c/loader/...                     MOD_BLD_LOADER_EBLT-C_AA_V3.1.2
element /vobs/esam/build/eblt-e/loader/...                     MOD_BLD_LOADER_EBLT-E_AA_V1.0.6
element /vobs/esam/build/eblt-g/loader/...                     MOD_BLD_LOADER_EBLT-G_AA_V1.1.2
element /vobs/esam/build/eblt-k/loader/...                     MOD_BLD_LOADER_EBLT-K_AA_V1.0.5
element /vobs/esam/build/evlt-a/loader/...                     MOD_BLD_LOADER_EVLT-A_AA_V3.1.2
element /vobs/esam/build/evlt-c/loader/...                     MOD_BLD_LOADER_EVLT-C_AA_V2.1.2
element /vobs/esam/build/evlt-f/loader/...                     MOD_BLD_LOADER_EVLT-F_AA_V2.1.2
element /vobs/esam/build/iwsm-a/loader/...                     MOD_BLD_LOADER_IWSM-A_AA_V1.1.2
element /vobs/esam/build/nalt-a/loader/...                     MOD_BLD_LOADER_NALT-A_AA_V1.1.3
element /vobs/esam/build/nalt-c/loader/...                     MOD_BLD_LOADER_NALT-C_AA_V1.2.2
element /vobs/esam/build/nvlt-a/loader/...                     MOD_BLD_LOADER_NVLT-A_AA_V1.2.2
element /vobs/esam/build/nvlt-c/loader/...                     MOD_BLD_LOADER_NVLT-C_AA_V1.1.3
element /vobs/esam/build/rvlt-a/loader/...                     MOD_BLD_LOADER_RVLT-A_AA_V2.1.4
element /vobs/esam/build/smlt-h/loader/...                     MOD_BLD_LOADER_SMLT-H_AA_V2.2.2
element /vobs/esam/build/vsem-a/loader/...                     MOD_BLD_LOADER_VSEM-A_AA_V1.0.7
element /vobs/dsl/source04/nslt-a_OFLT_MAIN/...                MOD_NSLT-A_OFLT_MAIN_AA_V1.1.1
element /vobs/dsl/source04/nslt-a_SOCRATES/...                 MOD_NSLT-A_SOCRATES_AA_V1.1.2
element /cm4/fsn/platform/iocm/...                             MOD_IOCM_AA_V5.0.3
element /vobs/dsl/source02/DataPathSim/...                     MOD_DATAPATHSIM_AA_V4.1.0
element /vobs/dsl/source02/PMTConfigTool/...                   MOD_PMTCONFIGTOOL_AA_V1.1.0
element /vobs/dsl/source03/RelayMgnt/...                       MOD_RELAYMGNT_AA_V1.2.0
element /vobs/dsl/source04/SLB_LxFwd_itfwrap_Bonding/...       MOD_SLB_LXFWD_ITFWRAP_BONDING_AA_V3.2.1
element /vobs/dsl/source06/xDSLBondingMgntLsm/...              MOD_XDSLBONDINGMGNTLSM_AA_V1.4.21
element /vobs/dsl/source04/SLBIM_HWW/...                       MOD_SLBIM_HWW_AA_V3.1.1
element /vobs/dsl/source08/PPPoERelayPrtcls/...                MOD_PPPOERELAYPRTCLS_AA_V9.1.2
element /vobs/dsl/source03/SACUDrvNt/...                       MOD_SACUDRVNT_AA_V1.3.1
element /vobs/dsl/source08/PPPoAoERelayPrtcls/...              MOD_PPPOAOERELAYPRTCLS_AA_V9.1.2
element /vobs/dsl/mibs/EXTEND-ETHER-MIB            3FE23284EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/FILE-TRANSFER-MIB           3FE29223EAAA_V3.3.0.2.1
element /vobs/dsl/mibs/QOS_MIB                     3FE22870EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/PRTCL_TRACE_MIB             3FE28654EAAA_FDT466.V1.1.0.0.0
#include /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.2
#---- entering 1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.2
element /vobs/dsl/mibs/...                          3FE21961EAAA_E3.3.0.2
element -dir /vobs/dsl/mibs                         /main/103
element -dir /vobs/dsl/mibs/smilint                 /main/1
element /vobs/dsl/mibs/all_mibs                     /main/aaaa/5
element /vobs/dsl/mibs/Makefile                     /main/aaaa/5
element /vobs/dsl/mibs/isam_mibs.cs                 /main/aaaa/105
element /vobs/dsl/mibs/common.rc                    /main/aaaa/3
element /vobs/dsl/mibs/README                       /main/aaaa/3
element /vobs/dsl/mibs/README.alcatel               /main/aaaa/1
element /vobs/dsl/mibs/.DeliveryList                /main/aaaa/11
element /vobs/dsl/mibs/RFC1493_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/RFC2674_MIB             MOD_ISS_V2.0.3.6_SMIv1_merge
element /vobs/dsl/mibs/lanx/...              MOD_ISS_MIBS_ALC_AA_V3.3.12.0.0
element /vobs/dsl/mibs/rfc1573.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/IANAifType-MIB.mib                        3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/ITF-MIB.mib                               3EC15505EAAA_V2.4.1.0.1
element /vobs/dsl/mibs/rfc1155.smi                               3EC36726EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1212.smi                               3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1212.mib                      3EC36727EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/rfc1213.mib                               3EC15591EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1443.mib                               3EC36728EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1215.smi                               3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/smilint/RFC-1215.mib                      3EC37310EAAA_V2.4.1.0.0
element /vobs/dsl/mibs/SYSTEM_MIB                                3FE23453EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SYSTEM_MIB                           3EC15532EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/ASAM-TC-MIB                               3EC17922EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/TRANSACTION_MIB                           3EC15597EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/TRAP_MIB                                  3EC15362EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/asam_traps.smi                            3EC37309EAAA_V3.1.0.0.2
element /vobs/dsl/mibs/ERROR_MIB                                 3EC15583EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ALARM_MIB                                 3EC15363EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/SNTP_MIB                                  3EC15584EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ipconfig.mib                              3EC15533EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/IANA_RTPROTO_MIB                          3FE23181EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/INET_ADDRESS_MIB                          3FE23182EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/VRF_MIB                                   3FE21838EAAA_V3.1.0.0.1
element /vobs/dsl/mibs/IPOX_MIB                                  3FE22920EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/ASAM_EQPTCORENT_MIB                       3EC36485EAAA_V3.1.0.0.5
element /vobs/dsl/mibs/ITF_MIB_EXT                               3EC15506EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SWDB_MIB                             3EC36484EAAA_E3.3.2.1
element /vobs/dsl/mibs/ETHER_DOT3_MIB                            3EC17925EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ETHER_MAU_MIB                             3EC17923EAAA_V1.0.0.0.2
element /vobs/dsl/mibs/IGMP_MIB                                  3FE20080EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/Plim_mib                                  3EC37662EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/ATM_MIB                                   3EC15358EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ATM-TC-MIB                                3EC16471EAAA_V1.0.0.0.1
element /vobs/dsl/mibs/ATM_EXT_MIB                               3EC15357EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ATM-M4_MIB                                3EC17924EAAA_V3.2.0.1.1
element /vobs/dsl/mibs/XDSL_MIB                                  3FE21279EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/IQ_ACCESS_MIB	                         3EC15596EAAA_V2.4.0.0.0
element /vobs/dsl/mibs/SELT_MIB                                  3FE24290EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/BONDING_MIB                               3FE22952EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/CPEPROXYMIB                               3FE24629EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/DHCP_MIB                                  3FE21837EAAA_V3.1.0.1.0
element /vobs/dsl/mibs/AAA_MIB                                   3FE22800EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/RADIUS_MIB                                3FE50082EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/IPPOOL_MIB                                3FE29189EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ESAM_802DOT1X_MIB                         3FE22192EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_802DOT1X_EXT_MIB                     3FE22638EAAA_V1.1.0.0.1
element /vobs/dsl/mibs/ESAM_PPP_MIB                              3FE22732EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/QOS_MIB                                  3FE22870EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/PPPOXRELAY_MIB                            3FE23869EAAA_V3.1.0.0.0
element /vobs/dsl/mibs/CLUSTER_MIB                               3FE24378EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc3411_SNMP_FRAMEWORK_MIB                3FE25473AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3412_SNMP_MPD_MIB                      3FE25474AAAA_V1.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.rc                3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB                   3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3413_SNMP_TARGET_MIB.smiv2             3FE25475AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/rfc3414_SNMP_USM_MIB                      3FE25478AAAA_V1.0.0.1.1
element /vobs/dsl/mibs/rfc3415_SNMP_VACM_MIB                     3FE25479AAAA_V2.0.0.0.1
element /vobs/dsl/mibs/SSH_MIB                                   3FE25576EAAA_V3.3.0.1.1
element /vobs/dsl/mibs/ESAM_SFP_MIB                              3FE25209EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/IPOA_L2_MIB                               3FE25208EAAA_V3.2.0.1.0
element  /vobs/dsl/mibs/L2CP_MIB                                 3FE27269AAAA_V2.4.0.1.3
element /vobs/dsl/mibs/SYSLOG_MIB                                 3FE25213EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/INT_TEST_SEAL_CUR_MIB                      3FE26729EAAA_V3.1.0.2.0
element /vobs/dsl/mibs/SIP-MIB.mib                                3FE25582EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/IMA_MIB                                    3FE20281EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_IMA_MIB                               3FE20282EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SHDSL_MIB                             3EC17695EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/EXTEND-ETHER-MIB                           3FE23284EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/FILE-TRANSFER-MIB                          3FE29223EAAA_V3.3.0.2.0
element /vobs/dsl/mibs/rfc2864.mib                                3FE26708EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/TROUBLESHOOTING-MIB                        3FE28654EAAA_V3.3.0.0.1
element /vobs/dsl/mibs/.DeliveryList*                             /main/eaaa/LATEST
element /vobs/dsl/mibs/.DeliveryList*                             /main/aaaa/LATEST
element /vobs/dsl/mibs/... -error
#---- leaving  1 /view/LATEST/vobs/dsl/mibs/.@@/main/75/isam_mibs.cs@@/3FE21961EAAA_E3.3.0.2
#excluded:element /vobs/dsl/source13/ZL50408-BCM5461_ETHERNET_HDS_Test/... MOD_ZL50408-BCM5461_ETHERNET_HDS_TES_AA_V3.1.2
#excluded:element /vobs/dsl/source13/PEF3324-3304_VINETIC_HDS_Test/...   MOD_PEF3324-3304_VINETIC_HDS_TEST_AA_V3.1.2
element /vobs/dsl/source08/EnvMonRelay/...                     MOD_ENVMONRELAY_AA_V1.1.2
element /vobs/dsl/source04/EBIM_HAL/...                        MOD_EBIM_HAL_AA_V2.1.1
element /vobs/dsl/source04/Westport_driver/...                 MOD_WESTPORT_DRIVER_AA_V1.1.2
element /vobs/esam/build/polt-b/oflt_bh/...                    MOD_BLD_OFLT_BH_POLT-B_AA_V1.0.4
element /vobs/dsl/mibs/EXTEND-ETHER-MIB                        3FE23284EAAA_V3.3.0.1.1
element /vobs/dsl/source04/nelt-a_RI_HAL/...                   MOD_NELT-A_RI_HAL_AA_V1.2.1
#excluded:element /vobs/dsl/source13/polt-a_PKHD/...                     MOD_POLT-A_PKHD_AA_V2.0.6
#excluded:element /vobs/dsl/source13/polt-a_PtpxItf/...                  MOD_POLT-A_PTPXITF_AA_V3.0.5
element /vobs/dsl/mibs/FILE-TRANSFER-MIB                       3FE29223EAAA_V3.3.0.2.1
element /vobs/dsl/mibs/QOS_MIB                                 3FE22870EAAA_V3.3.0.1.1
element /vobs/dsl/source04/SLB_LxFwd_itfwrap_ATM/...           MOD_SLB_LXFWD_ITFWRAP_ATM_AA_V3.2.2
element /vobs/dsl/source08/CPEMgntRelayLsm/...                 MOD_CPEMGNTRELAYLSM_AA_V8.0.1
element /vobs/dsl/source08/LocalUsrAuthentic_NT_migCode/...    MOD_LOCALUSRAUTHENTIC_NT_MIGCODE_AA_V1.0.2
element /vobs/dsl/source08/ClusterMgnt/...                     MOD_CLUSTERMGNT_AA_V5.0.5
element /vobs/esam/build/ealt-a/loader/...                     MOD_BLD_LOADER_EALT-A_AA_V3.1.1
element /vobs/esam/build/eblt-j/loader/...                     MOD_BLD_LOADER_EBLT-J_AA_V2.1.1
element /vobs/esam/build/nalt-b/loader/...                     MOD_BLD_LOADER_NALT-B_AA_V1.1.4
element /vobs/dsl/source04/BCM_LxFwd_Itfwrap_INIT/...          MOD_BCM_LXFWD_ITFWRAP_INIT_AA_V6.1.0
element /vobs/dsl/source04/BCM_LxFwd_Itfwrap_MC/...            MOD_BCM_LXFWD_ITFWRAP_MC_AA_V3.1.0
element /vobs/dsl/source04/BCM_LxFwd_Itfwrap_PH/...            MOD_BCM_LXFWD_ITFWRAP_PH_AA_V6.1.0
element /vobs/dsl/source11/NP_IXP2350_hww_LIB/...              MOD_NP_IXP2350_HWW_LIB_AA_V3.1.0
element /vobs/dsl/source11/NP_IXP2350_hww_RM/...               MOD_NP_IXP2350_HWW_RM_AA_V2.87.0
element /vobs/dsl/source04/NP_IXP2400_UC_PP_L3/...             MOD_NP_IXP2400_UC_PP_L3_AA_V6.1.0
element /vobs/dsl/source04/NP_IXP2400_UC_VDSL_Drivers/...      MOD_NP_IXP2400_UC_VDSL_DRIVERS_AA_V5.1.0
element /vobs/dsl/source04/NP_IXP2400_hww_CCL/...              MOD_NP_IXP2400_HWW_CCL_AA_V4.1.0
element /vobs/dsl/source11/NP_IXP2400_hww_RM/...               MOD_NP_IXP2400_HWW_RM_AA_V6.1.0
element /vobs/dsl/source11/NP_IXP2400_hww_include/...          MOD_NP_IXP2400_HWW_INCLUDE_AA_V7.3.0
element /vobs/dsl/source08/TransceiverBufLib/...               MOD_TRANSCEIVERBUFLIB_AA_V6.3.0
element /vobs/dsl/source02/LicenseKeyMonitor/...               MOD_LICENSEKEYMONITOR_AA_V4.1.0
element /vobs/dsl/source08/DHCPRelayMgntLsm/...                MOD_DHCPRELAYMGNTLSM_AA_V9.1.0
element /cm4/fsn/app/asam/common/idl/...                       MOD_ASAM_COMMON_IDL_AA_V11.1.0
element /vobs/dsl/mibs/IGMP_MIB                                3FE20080EAAA_V3.3.0.1.0
element /vobs/dsl/mibs/Plim_mib                                3EC37662EAAA_V3.3.0.2.0
element /vobs/dsl/source04/NP_IXP2350_UC_NELTA_HDS_BOOT/...     MOD_NP_IXP2350_UC_NELTA_HDS_BOOT_AA_FDT541.V1.1.0
element /vobs/dsl/source04/NP_IXP2350_UC_NELTA_HDS_BOOT_BLD/... MOD_NP_IXP2350_UC_NELTA_HDS_BOOT_BLD_AA_FDT541.V1.1.0
element /vobs/dsl/source04/BspDevUartPq2Pro/...                MOD_BSPDEVUARTPQ2PRO_AA_V1.0.7
element /vobs/dsl/source02/ICMP/...                            MOD_ICMP_AA_V1.0.2
element /cm4/fsn/app/pstack/sl/sif/...                         MOD_SIF_AA_V1.0.3
element /cm4/fsn/app/pstack/sl/network/...                     MOD_SLNETWORK_V3.2.2
element /cm4/fsn/prj/co/lca/lca_cokim/...                      MOD_LCACOKIM_AA_V1.2.3
element /vobs/esam/build/iwsm-a/osba/...                       MOD_BLD_OSBA_IWSM-A_AA_V1.1.1
element /cm4/fsn/krnl/fs/fskrnl/...                            MOD_FSKRNL_AA_V7.1.1
element /cm4/fsn/krnl/taskdel/...                              MOD_TASKDEL_AA_V1.0.1
element /cm4/fsn/krnl/bsp/dev/pq2/...                          MOD_BSP_DEV_PQ2_AA_V2.1.3
element /cm4/fsn/krnl/startup/M8250/...                        MOD_STARTUP_M8250_AA_V2.1.3
element /cm4/fsn/app/asam/systemDataMgnt/nt/...                MOD_SYSDATMGR-NT_AA_V3.1.5
element /vobs/dsl/source08/RadiusClient/...                    MOD_RADIUSCLIENT_AA_V4.2.1
element /vobs/dsl/source08/IPoXIWLMgntLsm/...                  MOD_IPOXIWLMGNTLSM_AA_V3.0.1
element /vobs/dsl/source02/BootLdrNepLsm/...                   MOD_BOOTLDRNEPLSM_AA_V1.1.4
element /vobs/esam/build/nelt-a/oflt_bh/...                    MOD_BLD_OFLT_BH_NELT-A_AA_V1.2.0
#excluded:element /vobs/dsl/envoy/Envoy-drv/...                          MOD_ENVOY-DRV_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_ACCESS_TS/...                MOD_NELT-A_ACCESS_TS_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_CE4/...                      MOD_NELT-A_CE4_AA_FDT541.V1.0.2
element /vobs/dsl/source04/nelt-a_OFLT_MAIN/...                MOD_NELT-A_OFLT_MAIN_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_RI_TS/...                    MOD_NELT-A_RI_TS_AA_FDT541.V1.0.0
element /vobs/dsl/source04/nelt-a_TRAFFIC_TS/...               MOD_NELT-A_TRAFFIC_TS_AA_FDT541.V1.0.2
element /vobs/dsl/source04/nelt-a_mini_bh/...                  MOD_NELT-A_MINI_BH_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_post/...                     MOD_NELT-A_POST_AA_V1.2.0
element /vobs/dsl/source08/AAAServer_Itf/...                   MOD_AAASERVER_ITF_AA_V2.1.0
element /vobs/dsl/source06/EthMgntLsm/...                      MOD_ETHMGNTLSM_AA_FDT541.V1.0.1
element /vobs/dsl/source06/PQIIEthMgnt/...                     MOD_PQIIETHMGNT_AA_V3.1.0
element /vobs/esam/build/nelt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NELT-A_AA_FDT541.V1.0.4
element /vobs/esam/build/nelt-a/bootprom/...                   MOD_BLD_BOOTPROM_NELT-A_AA_FDT541.V1.0.6
element /vobs/esam/build/nelt-a/flashwrite/...                 MOD_BLD_FLASHWRITE_NELT-A_AA_V1.2.0
element /vobs/esam/build/nelt-a/osba/...                       MOD_BLD_OSBA_NELT-A_AA_V1.2.0
element /cm4/fsn/krnl/bsp/prozone/...                          MOD_BSP_PROZONE_AA_FDT541.V8.0.3
element /vobs/dsl/source04/I2C_sim_driver/...                  MOD_I2C_SIM_DRIVER_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_BspProzone/...               MOD_NELT-A_BSPPROZONE_AA_V1.2.0
element /vobs/dsl/source04/nelt-a_FS/...                       MOD_NELT-A_FS_AA_V1.2.0
element /vobs/esam/build/nslt-a/osba/...                       MOD_BLD_OSBA_NSLT-A_AA_V1.1.0
element /vobs/esam/build/nslt-a/chipsim/...                    MOD_CHIPSIM_NSLT-A_AA_V1.1.0
element /vobs/dsl/source04/evlt-a_INTERFACE_TS/...             MOD_EVLT-A_INTERFACE_TS_AA_V2.1.1
element /vobs/dsl/mibs/SSH_MIB                                 3FE25576EAAA_V3.3.0.1.1
element /vobs/esam/build/eant-a/bootpackage/...                MOD_BLD_BOOTPACKAGE_EANT-A_AA_V1.0.2
element /vobs/esam/build/eant-a/bootprom/...                   MOD_BLD_BOOTPROM_EANT-A_AA_V1.0.1
element /vobs/esam/build/asem-b/flashwrite/...                 MOD_BLD_FLASHWRITE_ASEM-B_AA_V1.0.4
element /vobs/esam/build/ealt-a/flashwrite/...                 MOD_BLD_FLASHWRITE_EALT-A_AA_V1.0.1
element /vobs/esam/build/eant-a/flashwrite/...                 MOD_BLD_FLASHWRITE_EANT-A_AA_V2.0.1
element /vobs/esam/build/eblt-c/flashwrite/...                 MOD_BLD_FLASHWRITE_EBLT-C_AA_V1.1.1
element /vobs/esam/build/eblt-e/flashwrite/...                 MOD_BLD_FLASHWRITE_EBLT-E_AA_V1.0.4
element /vobs/esam/build/eblt-j/flashwrite/...                 MOD_BLD_FLASHWRITE_EBLT-J_AA_V1.1.1
element /vobs/esam/build/eblt-k/flashwrite/...                 MOD_BLD_FLASHWRITE_EBLT-K_AA_V1.0.2
element /vobs/esam/build/evlt-a/flashwrite/...                 MOD_BLD_FLASHWRITE_EVLT-A_AA_V1.2.1
element /vobs/esam/build/evlt-c/flashwrite/...                 MOD_BLD_FLASHWRITE_EVLT-C_AA_V2.1.1
element /vobs/esam/build/itsc-a/flashwrite/...                 MOD_BLD_FLASHWRITE_ITSC-A_AA_V1.0.1
element /vobs/esam/build/iwsm-a/flashwrite/...                 MOD_BLD_FLASHWRITE_IWSM-A_AA_V1.1.1
element /vobs/esam/build/nalt-a/flashwrite/...                 MOD_BLD_FLASHWRITE_NALT-A_AA_V1.1.1
element /vobs/esam/build/smlt-h/flashwrite/...                 MOD_BLD_FLASHWRITE_SMLT-H_AA_V2.2.1
element /vobs/esam/build/npot-a/oflt_bh/...                    MOD_BLD_OFLT_BH_NPOT-A_AA_V1.1.2
element /vobs/esam/build/evlt-a/pmd/...                        MOD_BLD_PMD_EVLT-A_AA_V1.1.1
element /vobs/esam/build/itsc-a/superflash/...                 MOD_BLD_SUPERFLASH_ITSC-A_AA_V1.0.1
element /vobs/esam/build/ecnt-a/bootpackage/...                MOD_BLD_BOOTPACKAGE_ECNT-A_AA_V2.0.2
element /vobs/esam/build/eblt-g/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-G_AA_V1.3.1
element /vobs/esam/build/eblt-h/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-H_AA_V1.2.1
element /vobs/esam/build/nslt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NSLT-A_AA_V1.1.1
element /vobs/dsl/source04/nslt-a_ACCESS_TS/...                MOD_NSLT-A_ACCESS_TS_AA_V1.1.1
element /vobs/dsl/source04/nslt-a_CPLD_HAL/...                 MOD_NSLT-A_CPLD_HAL_AA_V1.1.1
element /vobs/dsl/source04/nslt-a_MISC_TS/...                  MOD_NSLT-A_MISC_TS_AA_V1.1.1
element /vobs/dsl/source02/NlNif/...                           MOD_NLNIF_AA_V6.1.1
element /cm4/fsn/build/co/toolpath.mak  /main/fdt433/antms29515/1
element /vobs/dsl/source04/NP_IXP2350_UC_EBIM_HDS_BOOT/...     MOD_NP_IXP2350_UC_EBIM_HDS_BOOT_AA_V2.1.1
element /vobs/dsl/source04/NP_IXP2350_UC_EBIM_HDS_BOOT_BLD/... MOD_NP_IXP2350_UC_EBIM_HDS_BOOT_BLD_AA_V2.1.1
element /cm4/fsn/krnl/bsp/dev/scc/...                          MOD_BSP_DEV_SCC_AA_V1.1.3
element /vobs/dsl/source04/NP_IXP2400_HDS_BOOT_BLD/...         MOD_NP_IXP2400_HDS_BOOT_BLD_AA_V2.0.5
element /vobs/dsl/source04/eblt-c_INTERFACE_TS/...             MOD_EBLT-C_INTERFACE_TS_AA_V2.0.3
element /vobs/dsl/source04/eblt-c_MISC_TS/...                  MOD_EBLT-C_MISC_TS_AA_V2.0.2
element /vobs/dsl/source04/eblt-g_INTERFACE_TS/...             MOD_EBLT-G_INTERFACE_TS_AA_V1.0.3
element /cm4/fsn/krnl/tracetool/...                            MOD_KRNLTRCTOOL_AA_V3.0.1
element /cm4/tools/BELL/src/mibco/...                          MOD_MIBCO_V1.19.13
element /cm4/fsn/hs/xdsl_proxy/common/XdslApiStub/...          MOD_XDSLPROXY-STUB_AA_V6.1.1
element /cm4/fsn/hs/xdsl_proxy/common/XdslApiDefault/...       MOD_XDSLAPI-DEFAULT_AA_V2.1.1
element /cm4/fsn/app/snmp/miniman/...                          MOD_MINIMAN_AA_V1.0.3
element /vobs/dsl/source03/InfraLt/...                         MOD_INFRALT_AA_V5.1.2
element /vobs/dsl/mibs/ASAM_SWDB_MIB                           3EC36484EAAA_FDT553.E3.3.0.2
element /vobs/dsl/source04/NP_LxFwd_itfwrap_PPPoAoE/...        MOD_NP_LXFWD_ITFWRAP_PPPOAOE_AA_V4.2.8
element /vobs/dsl/source02/NlEth/...                           MOD_NLETH_AA_V7.1.2
element /vobs/dsl/source04/RelayController/...                 MOD_RELAYCONTROLLER_AA_V6.2.1
element /vobs/dsl/source02/CpuLoadControl/...                  MOD_CPULOADCONTROL_AA_V2.1.0
element /vobs/dsl/source08/ServiceAvailMgr/...                 MOD_SERVICEAVAILMGR_AA_V3.1.0
element /vobs/dsl/source08/TransceiverPoolMgr/...              MOD_TRANSCEIVERPOOLMGR_AA_V8.1.0
element /vobs/dsl/source02/asem-b_Init/...                     MOD_ASEM-B_INIT_AA_V2.3.0
element /vobs/dsl/source02/eblt-c_Init/...                     MOD_EBLT-C_INIT_AA_V8.3.0
element /vobs/dsl/source02/iwsm-a_Init/...                     MOD_IWSM-A_INIT_AA_V4.1.0
element /vobs/dsl/source02/vsem-a_Init/...                     MOD_VSEM-A_INIT_AA_V2.3.0
element /vobs/dsl/mibs/TROUBLESHOOTING-MIB                     3FE28654EAAA_FDT466.V3.3.0.0.0
element /vobs/dsl/mibs/PRTCL_TRACE_MIB 3FE28654EAAA_FDT466.V1.1.0.0.0
element /vobs/dsl/source02/NlNmisc/...                         MOD_NLNMISC_AA_V4.1.1
element /cm4/fsn/app/servers/tftp/...                          MOD_TFTP_AA_V3.1.0
element /vobs/dsl/mibs/rfc2864.mib                             3FE26708EAAA_FDT454.V3.3.0.0.0
element /cm4/fsn/prj/asam/cokim/vxworks/...                    MOD_COKIM_VXPRJ_AA_V2.0.1
element /cm4/fsn/app/pstack/nl/idl/...                         MOD_NLIDL_AA_V6.0.5
element /cm4/fsn/app/pstack/nl/llc/...                         MOD_NLLLC_AA_V5.1.1
element /cm4/fsn/app/pstack/nl/slip/...                        MOD_NLSLIP_AA_V1.1.3
element /cm4/fsn/app/pstack/nl/sock/...                        MOD_NLSOCK_AA_V4.1.1
element /cm4/fsn/lib/snprintf/...                              MOD_SNPRINTF_AA_V1.1.1
element /cm4/fsn/krnl/bsp/dev/pq2_cpm/...                      MOD_BSP_DEV_PQ2CPM_AA_V4.0.2
element /cm4/fsn/krnl/bsp/pq2/board/co/...                     MOD_BSP_PQ2_CO_AA_V4.0.1
element /cm4/fsn/krnl/bsp/pq2/bsp_err/...                      MOD_BSP_PQ2_ERR_AA_V4.0.2
element /vobs/dsl/source04/ATM_HDS_Itf/...                     MOD_ATM_HDS_ITF_AA_V7.1.0
element /vobs/dsl/source08/VBAS/...                            MOD_VBAS_AA_V6.2.0
element /vobs/esam/build/nvlt-c/lca/...                        MOD_BLD_LCA_NVLT-C_AA_V1.1.1
element /vobs/dsl/source04/EBIM_HWW/...                        MOD_EBIM_HWW_AA_V2.1.1
element /vobs/dsl/source04/HdSCommon/...                       MOD_HDSCOMMON_AA_V2.1.1
element /vobs/dsl/source04/pm8374a_hal/...                     MOD_PM8374A_HAL_AA_V1.2.1
element /vobs/dsl/source04/ixp_ucode_loader/...                MOD_IXP_UCODE_LOADER_AA_V1.1.1
element /vobs/dsl/source04/ri_driver/...                       MOD_RI_DRIVER_AA_V1.1.1
element /vobs/dsl/source04/ri_ts/...                           MOD_RI_TS_AA_V1.1.1
element /vobs/dsl/source04/temperature_sensor_driver/...       MOD_TEMPERATURE_SENSOR_DRIVER_AA_V1.1.1
element /vobs/esam/build/eblt-g/bootpromfs/...                 MOD_BLD_BOOTPROMFS-EBLT-G_AA_V1.1.0
element /vobs/esam/build/eblt-c/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EBLT-C_AA_V3.1.0
element /vobs/esam/build/evlt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EVLT-A_AA_V3.1.0
element /vobs/esam/build/evlt-c/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EVLT-C_AA_V2.1.0
element /vobs/esam/build/iwsm-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_IWSM-A_AA_V1.2.0
element /vobs/esam/build/asem-b/miniOS/...                     MOD_BLD_MINIOS_ASEM-B_AA_V1.1.0
element /vobs/esam/build/itsc-a/miniOS/...                     MOD_BLD_MINIOS_ITSC-A_AA_V1.1.0
element /vobs/esam/build/eblt-c/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-C_AA_V3.2.0
element /vobs/esam/build/iwsm-a/oflt_bh/...                    MOD_BLD_OFLT_BH_IWSM-A_AA_V2.2.0
element /vobs/esam/build/eblt-c/osba/...                       MOD_BLD_OSBA_EBLT-C_AA_V3.1.0
element /vobs/esam/build/evlt-c/osba/...                       MOD_BLD_OSBA_EVLT-C_AA_V2.1.0
element /vobs/dsl/source03/DldMgntItsc/...                     MOD_DLDMGNTITSC_AA_V1.3.0
element /cm4/fsn/prj/esam/eant-a/init/...                      MOD_INIT_EANT-A_V1.1.0
element /vobs/dsl/source02/eblt-e_Init/...                     MOD_EBLT-E_INIT_AA_V4.2.0
element /vobs/tools/ALCATEL/object_file_utils/...              TOOLS_OBJECT_FILE_UTILS_V1.1.0
element /cm4/tools/BELL/src/wink/...                           TOOLS_WINK_V1.0.1
element /cm4/tools/BELL/src/wink/...                           TOOLS_WINK_V1.0.1
element /vobs/dsl/source02/ProDataLayout1/...                  MOD_PRODATALAYOUT1_AA_V4.0.1
element /vobs/dsl/mibs/ESAM_SFP_MIB                            3FE25209EAAA_FDT433.V3.3.0.3.0
element /vobs/dsl/source02/HostNtHwSimulation/...              MOD_HOSTNTHWSIMULATION_AA_V2.1.0
element /cm4/fsn/krnl/bsp/board/eant-a/...                     MOD_ECNT-B_BSP_AA_V3.0.4
element /vobs/dsl/source08/FScommon/...                        MOD_FSCOMMON_AA_V4.0.1
element /vobs/dsl/source04/eblt-c_FS/...                       MOD_EBLT-C_FS_AA_V1.0.8
element /vobs/dsl/source04/eblt-c_OFLT_MAIN/...                MOD_EBLT-C_OFLT_MAIN_AA_V2.0.2
element /vobs/dsl/source04/eblt-c_mini_bh/...                  MOD_EBLT-C_MINI_BH_AA_V1.0.12
element /vobs/dsl//source04/NP_IXP2350_UC_EB_Image/Target/isam_wp_target.uof  /main/aaaa/3
element /vobs/esam/build/nvlt-c/chipsim/...                    MOD_BLD_CHIPSIM_NVLT-C_AA_V1.1.1
element /vobs/dsl/mibs/XDSL_MIB                                3FE21279EAAA_FDT502.V3.3.0.0.1
element /vobs/dsl/source06/SELTLiteCommon/...                  MOD_SELTLITECOMMON_AA_V5.1.0
element /vobs/dsl/mibs/SELT_MIB                                3FE24290EAAA_FDT502.V3.3.0.0.1
element /cm4/fsn/krnl/bsp/prozone/...                          MOD_BSP_PROZONE_AA_V8.2.0
element /vobs/dsl/source03/MTA_LT/...                          MOD_MTA_LT_AA_V7.2.0
element /vobs/dsl/source03/ODMProxy/...                        MOD_ODMPROXY_AA_V4.1.0
element /vobs/dsl/source04/TemperatureHds/...                  MOD_TEMPERATUREHDS_AA_V8.1.0
element /cm4/tools/BELL/xml/xml4Parser/...                     MOD_XML4PARSER_AA_V7.2.0
element /cm4/tools/BELL/xml/xml4UserGuide/...                  MOD_XML4USERGUIDE_AA_V5.2.0
element /cm4/tools/BELL/xml/xmlCommon/...                      MOD_XMLCOMMON_AA_V6.2.0
element /vobs/esam/build/nslt-a/bootprom/...                   MOD_BLD_BOOTPROM_NSLT-A_AA_V1.1.0
element /vobs/dsl/source02/nslt-a_FS/...                       MOD_NSLT-A_FS_AA_V1.1.0
element /vobs/esam/build/nslt-a/oflt_bh/...                    MOD_BLD_OFLT_BH_NSLT-A_AA_V1.1.0
element /vobs/dsl/source04/nslt-a_IMA/...                      MOD_NSLT-A_IMA_AA_V1.1.0
element /vobs/dsl/source08/IGMPCDRMgntLsm/...                  MOD_IGMPCDRMGNTLSM_AA_V3.99.6
element /vobs/dsl/mibs/SYSLOG_MIB                              3FE25213EAAA_FDT498.V3.3.0.0.0
element /vobs/dsl/source04/NP_IXP2400_VDSL_ucode/...           MOD_NP_IXP2400_VDSL_UCODE_AA_V4.1.0
element /vobs/dsl/source04/evlt-a_FPGA/...                     MOD_EVLT-A_FPGA_AA_V1.85.1
element /vobs/esam/build/nvlt-c/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NVLT-C_AA_V1.0.2
element /vobs/dsl/source04/COMMON_GDV_TS/...                   MOD_COMMON_GDV_TS_AA_V2.1.0
element /vobs/dsl/source04/Westport_POST/...                   MOD_WESTPORT_POST_AA_V2.1.0
element /vobs/dsl/source02/nvlt-c_FS/...                       MOD_NVLT-C_FS_AA_V1.1.0
element /vobs/esam/build/release_info/...                      MOD_BLD_RELEASE_INFO_AA_V2.1.5
element /vobs/dsl/source04/evlt-a_ACCESS_TS/...                MOD_EVLT-A_ACCESS_TS_AA_V2.1.0
element /vobs/dsl/source04/evlt-a_BOARD/...                    MOD_EVLT-A_BOARD_AA_V2.1.0
element /vobs/dsl/source04/evlt-a_MISC_TS/...                  MOD_EVLT-A_MISC_TS_AA_V2.1.0
element /vobs/dsl/source04/evlt-a_OFLT_MAIN/...                MOD_EVLT-A_OFLT_MAIN_AA_V2.1.0
element /vobs/dsl/source04/evlt-a_RI/...                       MOD_EVLT-A_RI_AA_V2.1.0
element /vobs/dsl/source04/evlt-a_TRAFFIC_TS/...               MOD_EVLT-A_TRAFFIC_TS_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_ACCESS_TS/...                MOD_EVLT-F_ACCESS_TS_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_OFLT_MAIN/...                MOD_EVLT-F_OFLT_MAIN_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_RI_HAL/...                   MOD_EVLT-F_RI_HAL_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_TEMP_SENSOR_TS/...           MOD_EVLT-F_TEMP_SENSOR_TS_AA_V2.1.0
element /vobs/dsl/source04/FPGALoader/...                      MOD_FPGALOADER_AA_V2.1.0
element /vobs/dsl/source04/Westport_POST/...                   MOD_WESTPORT_POST_AA_V2.1.0
element /vobs/esam/build/nvlt-c/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NVLT-C_AA_V1.0.2
element /vobs/esam/build/nvlt-c/bootprom/...                   MOD_BLD_BOOTPROM_NVLT-C_AA_V1.1.0
element /vobs/esam/build/nvlt-c/osba/...                       MOD_BLD_OSBA_NVLT-C_AA_V1.1.0
element /vobs/dsl/source02/nvlt-c_FS/...                       MOD_NVLT-C_FS_AA_V1.1.0
element /vobs/dsl/source04/COMMON_GDV_TS/...                   MOD_COMMON_GDV_TS_AA_V2.1.0
element /vobs/dsl/source04/ixp2350_sdram_ts/...                MOD_IXP2350_SDRAM_TS_AA_V1.1.0
element /vobs/esam/build/evlt-f/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EVLT-F_AA_V2.1.0
element /vobs/esam/build/evlt-f/bootprom/...                   MOD_BLD_BOOTPROM_EVLT-F_AA_V2.1.0
element /vobs/esam/build/evlt-f/flashwrite/...                 MOD_BLD_FLASHWRITE_EVLT-F_AA_V2.1.0
element /vobs/esam/build/evlt-f/lca/...                        MOD_BLD_LCA_EVLT-F_AA_V2.1.0
element /vobs/esam/build/evlt-f/osba/...                       MOD_BLD_OSBA_EVLT-F_AA_V2.1.0
element /vobs/dsl/source04/BspDevWestport/...                  MOD_BSPDEVWESTPORT_AA_V3.1.0
element /vobs/dsl/source04/Westport_FS/...                     MOD_WESTPORT_FS_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_BSP_TEST/...                 MOD_EVLT-F_BSP_TEST_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_CPLD_HAL/...                 MOD_EVLT-F_CPLD_HAL_AA_V2.1.0
element /vobs/dsl/source04/evlt-f_FS/...                       MOD_EVLT-F_FS_AA_V2.1.0
element /vobs/dsl/source02/DataUtilities/...                   MOD_DATAUTILITIES_AA_V2.1.6
element /vobs/esam/build/ecnt-c/bootpackage/...                MOD_BLD_BOOTPACKAGE_ECNT-C_AA_V1.0.11
element /cm4/fsn/app/snmp/fs/...                               MOD_SNMPFS_AA_V1.0.1
element /vobs/dsl/source11/NP_IXP2400_hww_CCI/...              MOD_NP_IXP2400_HWW_CCI_AA_V2.1.3
element /vobs/dsl/source04/evlt-c_CPLD_HAL/...                 MOD_EVLT-C_CPLD_HAL_AA_V1.0.3
element /cm4/fsn/hs/h_hdlc/...                                 MOD_HL_HDLC_AA_FDT015.V5.0.0
element /cm4/fsn/krnl/loadcontrol/...                          MOD_KRNLLDCTRL_FDT015.V1.0.3
element /vobs/dsl/source04/itsc-a_OFLT_MAIN/...                MOD_ITSC-A_OFLT_MAIN_AA_V1.0.3
element /vobs/dsl/source04/itsc-a_VINETIC_TS/...               MOD_ITSC-A_VINETIC_TS_AA_V1.0.2
element /vobs/dsl/source04/Ixp2400_Startup_Boot/...            MOD_IXP2400_STARTUP_BOOT_AA_V2.2.6
element /vobs/dsl/source04/smlt-h_MISC_TS/...                  MOD_SMLT-H_MISC_TS_AA_V2.1.2
element /vobs/dsl/source04/smlt-h_SOCRATES/...                 MOD_SMLT-H_SOCRATES_AA_V2.1.2
element /vobs/dsl/source02/bitmap/...                          MOD_BITMAPTABLE_AA_V1.0.1
element /cm4/fsn/krnl/memmngt/...                              MOD_MEMMNGT_AA_V2.1.4
element /vobs/dsl/source04/rvlt-a_HWW/...                      MOD_RVLT-A_HWW_AA_V2.0.3
element /vobs/dsl/source04/eblt-e_FS/...                       MOD_EBLT-E_FS_AA_V1.0.2
#excluded:element /vobs/dsl/source13/polt-a_bh/...                       MOD_POLT-A_BH_AA_V3.1.1
element /vobs/dsl/source04/smlt-h_BOARD/...                    MOD_SMLT-H_BOARD_AA_V2.1.1
element /vobs/dsl/source04/smlt-h_OFLT_MAIN/...                MOD_SMLT-H_OFLT_MAIN_AA_V2.1.1
element /vobs/dsl/source04/smlt-h_HWW/...                      MOD_SMLT-H_HWW_AA_V2.1.1
element /vobs/dsl/source08/ReduceSwp/...                       TOOLS_REDUCESWP_AA_FDT011.V2.1.7
element /cm4/fsn/krnl/fs/xfs/...                               MOD_XFS_AA_V1.0.2
element /vobs/dsl/source02/ITSCRemoteTraceDebug/...            MOD_ITSCREMOTETRACEDEBUG_AA_V1.1.1
element /cm4/fsn/krnl/startup/M859/...                         MOD_STARTUP_M859_AA_V2.0.2
element /vobs/dsl/source03/EqptLib/...                         MOD_EQPTLIB_AA_V1.1.3
element /vobs/esam/build/nant-a/bootprom/...                   MOD_BLD_BOOTPROM_NANT-A_AA_V1.0.1
element /vobs/dsl/source04/BCM6411_HAL/...                     MOD_BCM6411_HAL_AA_V2.2.1
element /vobs/dsl/source04/eblt-g_OFLT_MAIN/...                MOD_EBLT-G_OFLT_MAIN_AA_V1.0.3
element /vobs/dsl/source04/eblt-g_RI/...                       MOD_EBLT-G_RI_AA_V1.0.2
element /vobs/dsl/source04/eblt-h_OFLT_MAIN/...                MOD_EBLT-H_OFLT_MAIN_AA_V1.0.1
element /vobs/dsl/source02/EthHlDrv/...                        MOD_ETHHLDRV_AA_V6.4.3
element /vobs/dsl/tools/...                                    MOD_DIRS_DSL_TOOLS_V1.1.9
element /cm4/fsn/prj/co/vxworks/...                            MOD_CO_VXPRJ_AA_V2.0.2
element /vobs/dsl/source02/evlt-c_ProjectVx/...                MOD_EVLT-C_PROJECTVX_AA_V1.0.2
element /vobs/dsl/source02/iwsm-a_ProjectVx/...                MOD_IWSM-A_PROJECTVX_AA_V1.0.1
element /vobs/dsl/source04/BspDevPq1Cpm/...                    MOD_BSPDEVPQ1CPM_AA_V3.0.1
element /cm4/fsn/krnl/bsp/export/...                           MOD_BSP_EXPORT_AA_V5.1.3
element /vobs/dsl/source02/BootLdrEsamBCMLsm/...               MOD_BOOTLDRESAMBCMLSM_AA_V4.0.5
element /vobs/esam/build/nant-a/oflt_bh/...                    MOD_BLD_OFLT_BH_NANT-A_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_ACCESS_TS/...                MOD_NCNC-B_ACCESS_TS_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_EPLD_HAL/...                 MOD_NCNC-B_EPLD_HAL_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_HDS_DRV/...                  MOD_NCNC-B_HDS_DRV_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_INTERFACE_TS/...             MOD_NCNC-B_INTERFACE_TS_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_MISC_TS/...                  MOD_NCNC-B_MISC_TS_AA_V1.1.1
element /vobs/dsl/source04/ncnc-b_BOARD/...                    MOD_NCNC-B_BOARD_AA_FDT519.V1.0.5
#excluded:element /vobs/dsl/source13/polt-a_oflt_MISC_TS/...               MOD_POLT-A_OFLT_MISC_TS_AA_V3.0.2
#excluded:element /vobs/dsl/source13/polt-a_oflt_RI/...                    MOD_POLT-A_OFLT_RI_AA_V3.1.2
element /cm4/fsn/app/asam/eqptDomain/eqptCtrl/chain/...        MOD_EQPTCTRL_MASTER_AA_V3.0.1
element /vobs/esam/pSOSun/esim/sbp/sbp.cc /main/aaaa/fdt461/22
element /vobs/esam/pSOSun/esim/cmdHdlr/export/CmdHist.h /main/aaaa/3
element /vobs/esam/pSOSun/esim/cmdHdlr/export/CmdMain.h /main/aaaa/5
element /vobs/esam/pSOSun/esim/cmdHdlr/CmdHist.cc /main/aaaa/4
element /cm8/auto/tools/pbscript/launchTestBatch  /main/ata_wipro/patrick/4
element /vobs/dsl/mibs/VRF_MIB                                 3FE21838EAAA_V3.1.0.0.1
element /vobs/dsl/source03/CommMediumMonitor/...               MOD_COMMMEDIUMMONITOR_AA_V3.0.8
element /vobs/dsl/source04/NP_IXP2400_UC_HDS_BOOT/...          MOD_NP_IXP2400_UC_HDS_BOOT_AA_V2.0.4
element /vobs/dsl/source03/ITSCMessageHandlerNt/...            MOD_ITSCMESSAGEHANDLERNT_AA_V1.5.2
element /vobs/esam/build/asem-b/chipsim/...                    MOD_CHIPSIM_ASEM-B_AA_V1.0.2
element /vobs/esam/build/vsem-a/chipsim/...                    MOD_CHIPSIM_VSEM-A_AA_V1.0.1
element /cm4/fsn/krnl/RTEMS/pSOSun/...                         MOD_RTEMS_PSOSUN_AA_V1.3.5
element /vobs/esam/build/rvlt-a/bootprom/...                   MOD_BLD_BOOTPROM_RVLT-A_AA_V2.1.2
element /vobs/dsl/source02/bootps/...                          MOD_BOOTPS_AA_V3.0.2
element /vobs/dsl/source02/EthLlDrv/...                        MOD_ETHLLDRV_AA_V2.3.4
element /vobs/dsl/mibs/Makefile                     /main/aaaa/fdt015/1
element /vobs/dsl/source04/evlt-c_BOARD/...                    MOD_EVLT-C_BOARD_AA_V1.2.3
element /vobs/esam/build/evlt-c/oflt_bh/...                    MOD_BLD_OFLT_BH_EVLT-C_AA_V2.1.1
element /vobs/esam/build/evlt-e/oflt_bh/...                    MOD_BLD_OFLT_BH_EVLT-E_AA_V1.0.2
element /cm4/fsn/krnl/startup/M870/...                         MOD_STARTUP_M870_AA_V2.1.1
element /vobs/dsl/mibs/AAA_MIB                                 3FE22800EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/IPPOOL_MIB                              3FE29189EAAA_V3.2.0.0.0
element /cm4/tools/BELL/SunOS_5.8/...                        MOD_BELLBIN_V1.6.10
element /vobs/dsl/source04/asem-b_ACCESS_TS/...                MOD_ASEM-B_ACCESS_TS_AA_V1.0.2
element /vobs/dsl/source04/asem-b_BOARD/...                    MOD_ASEM-B_BOARD_AA_V1.0.5
element /vobs/dsl/source04/asem-b_MISC_TS/...                  MOD_ASEM-B_MISC_TS_AA_V1.0.2
element /vobs/dsl/source03/ITSCMessageHandlerCommon/...        MOD_ITSCMESSAGEHANDLERCOMMON_AA_V1.3.1
element /cm4/fsn/krnl/cmdArgs/...                              MOD_CMDARGS_AA_V1.0.2
element /cm4/fsn/krnl/ldApp/...                                MOD_KRNLLDAPP_AA_V1.0.1
element /cm4/fsn/krnl/sw_wd/...                                MOD_KRNLSWWD_AA_V1.0.1
element /vobs/esam/build/nant-a/bootpackage/...                MOD_BLD_BOOTPACKAGE_NANT-A_AA_V1.0.2
element /vobs/esam/build/ealt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EALT-A_AA_V2.0.1
element /vobs/esam/build/eblt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EBLT-A_AA_V2.0.1
element /vobs/esam/build/eblt-j/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EBLT-J_AA_V2.0.2
element /vobs/esam/build/itsc-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_ITSC-A_AA_V1.2.1
element /vobs/esam/build/vsem-a/flashwrite/...                 MOD_BLD_FLASHWRITE_VSEM-A_AA_V1.0.3
element /cm4/fsn/krnl/fs/board/eant-a/...                      MOD_FSBOARD_EANT-A_AA_V1.1.1
element /vobs/dsl/source04/ecnt-c_FS/...                       MOD_ECNT-C_FS_AA_V1.1.2
element /vobs/dsl/source04/nant-a_FS/...                       MOD_NANT-A_FS_AA_V1.0.1
element /vobs/dsl/source08/CPEMgntMgntNt/...                   MOD_CPEMGNTMGNTNT_AA_V4.2.1
element /vobs/dsl/source08/LocalUsrAuthentic/...               MOD_LOCALUSRAUTHENTIC_AA_V3.2.1
element /vobs/dsl/source04/HsAsicsNANTA/...                    MOD_HSASICSNANTA_AA_V1.1.2
element /cm4/tools/BELL/SunOS_5.8/...                          MOD_BELLBIN_V1.6.10
element /vobs/dsl/mibs/...                                     3FE21961EAAA_FDT015.E3.1.1.1
element /cm4/tools/ANS/tl1_compiler/...                        TOOLS_CLC_AA_V5.1.0
element /vobs/esam/build/nant-a/chipsim/...                    MOD_CHIPSIM_NANT-A_AA_V1.0.1
element /vobs/dsl/source02/HdlcMmiAdapter/...                  MOD_HDLCMMIADAPTER_AA_V2.0.1
element /cm4/fsn/krnl/startup/M8260/...                        MOD_STARTUP_M8260_AA_V2.1.1
#excluded:element /vobs/dsl/source13/polt-a_Zips/...                     MOD_POLT-A_ZIPS_AA_V3.1.3
element /vobs/dsl/source04/evlt-c_OFLT_MAIN/...                MOD_EVLT-C_OFLT_MAIN_AA_V1.1.0
element /cm4/tools/Sun/java/...                                TOOLS_JAVA_AA_V2.0.3
element /cm4/fsn/prj/esam/eant-a/co_hds/...                    MOD_EANT-A_CO_HDS_AA_V5.0.3
element /vobs/esam/build/rvlt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_RVLT-A_AA_V2.1.1
element /vobs/esam/build/rvlt-a/lca/...                        MOD_BLD_LCA_RVLT-A_AA_V2.1.1
element /vobs/dsl/source04/evlt-c_OFLT_MAIN/...                MOD_EVLT-C_OFLT_MAIN_AA_V1.1.0
element /vobs/dsl/source04/evlt-c_mini_bh/...                  MOD_EVLT-C_MINI_BH_AA_V1.0.3
element /vobs/dsl/source04/ncnc-b_OFLT_MAIN/...                MOD_NCNC-B_OFLT_MAIN_AA_V1.1.0
element /vobs/dsl/source04/eblt-e_TRAFFIC_TS/...               MOD_EBLT-E_TRAFFIC_TS_AA_V2.0.1
#excluded:element /vobs/dsl/source13/NP_IXP2400_hww_NAPT/...             MOD_NP_IXP2400_HWW_NAPT_AA_V1.0.7
element /vobs/dsl/mibs/CLUSTER_MIB                             3FE24378EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM-TC-MIB                             3EC17922EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/SYSTEM_MIB                              3FE23453EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/TRANSACTION_MIB                         3EC15597EAAA_V3.2.0.0.1
element /vobs/dsl/mibs/ipconfig.mib                            3EC15533EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1213.mib                             3EC15591EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/rfc1443.mib                             3EC36728EAAA_V3.2.0.1.0
element -dir /cm4/fsn/include/nant-a                           /main/0 #NO_INTEGRATE-LATEST
element /vobs/esam/build/ecnt-b/DNI_bootprom/...               MOD_DNI_BOOTPROM_AA_V1.0.4
element /vobs/dsl/source03/SwBMgnt/...                         MOD_SWBMGNT_AA_V1.3.0
element /cm4/fsn/krnl/RTEMS/exec/...                           MOD_RTEMS_EXEC_AA_V2.0.1
element /cm4/fsn/hs/chipsim/...                                MOD_CHIPSIM_AA_V1.0.1
element /vobs/dsl/source02/HostLtHwSimulation/...              MOD_HOSTLTHWSIMULATION_AA_V2.0.1
element /vobs/dsl/source02/HdlcMmiIocmItf/...                  MOD_HDLCMMIIOCMITF_AA_V1.1.4
element /cm4/fsn/app/servers/rcom/server/...                   MOD_RCOM-SERVER_AA_V1.0.1
element /vobs/dsl/source09/SystemMgntLsm/...                   MOD_SYSTEMMGNTLSM_AA_V1.0.7
element /vobs/dsl/source04/BootLdrNepIxpLsm/...                MOD_BOOTLDRNEPIXPLSM_AA_V1.1.0
element /vobs/dsl/source04/Ixp2400_Startup_BootLoader/...      MOD_IXP2400_STARTUP_BOOTLOADER_AA_V7.1.0
element /vobs/dsl/mibs/ASAM_IMA_MIB                            3FE20282EAAA_V3.2.0.1.0
element /vobs/esam/build/smlt-h/bootpromfs/...                 MOD_BLD_BOOTPROMFS_SMLT-H_AA_V2.1.0
element /vobs/esam/build/smlt-h/bootprom/...                   MOD_BLD_BOOTPROM_SMLT-H_AA_V2.1.0
element /vobs/esam/build/smlt-h/osba/...                       MOD_BLD_OSBA_SMLT-H_AA_V2.1.0
element /vobs/esam/build/smlt-h/chipsim/...                    MOD_CHIPSIM_SMLT-H_AA_V2.1.0
element /vobs/dsl/mibs/IMA_MIB                                 3FE20281EAAA_V3.2.0.1.0
element /vobs/dsl/source06/ImaMgntLsm/...                      MOD_IMAMGNTLSM_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_BspProzone/...               MOD_SMLT-H_BSPPROZONE_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_FS/...                       MOD_SMLT-H_FS_AA_V2.1.0
element /vobs/esam/build/smlt-h/oflt_bh/...                     MOD_BLD_OFLT_BH_SMLT-H_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_ACCESS_TS/...                 MOD_SMLT-H_ACCESS_TS_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_EPLD_HAL/...                  MOD_SMLT-H_EPLD_HAL_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_RI_TS/...                     MOD_SMLT-H_RI_TS_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_mini_bh/...                   MOD_SMLT-H_MINI_BH_AA_V2.1.0
element /vobs/dsl/source04/smlt-h_post/...                      MOD_SMLT-H_POST_AA_V2.1.0
element /vobs/dsl/mibs/DHCP_MIB                                3FE21837EAAA_V3.1.0.1.0
element /vobs/dsl/source02/AsamProxy/...                       MOD_ASAMPROXY_AA_V1.1.7
element /vobs/dsl/source08/CPEMgntRelayNt/...                  MOD_CPEMGNTRELAYNT_AA_V3.2.3
element /vobs/dsl/source04/ealt-a_BSP/...                      MOD_EALT-A_BSP_AA_V1.1.2
element /vobs/dsl/source04/Ixp2400_Startup_OSBA/...            MOD_IXP2400_STARTUP_OSBA_AA_V1.0.10
element /vobs/dsl/source04/asem-b_TRAFFIC_TS/...               MOD_ASEM-B_TRAFFIC_TS_AA_V1.0.2
element /vobs/dsl/mibs/BONDING_MIB                             3FE22952EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ITF_MIB_EXT                             3EC15506EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/IPOA_L2_MIB                             3FE25208EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ASAM_SHDSL_MIB                          3EC17695EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ATM-M4_MIB                              3EC17924EAAA_V3.2.0.1.1
element /vobs/dsl/mibs/ATM_EXT_MIB                             3EC15357EAAA_V3.2.0.0.0
element /vobs/dsl/mibs/ATM_MIB                                 3EC15358EAAA_V3.2.0.1.0
element /vobs/dsl/mibs/ESAM_PPP_MIB                            3FE22732EAAA_V3.2.0.1.0
element /cm4/fsn/app/servers/rfs/client/...                    MOD_ASAMRFSCLIENT_AA_V3.0.1
element /vobs/dsl/source02/AlivePing/...                       MOD_ALIVEPING_AA_V1.85.1
element /vobs/dsl/source03/EOConvMgnt/...                      MOD_EOCONVMGNT_AA_V2.0.2
element /vobs/dsl/source03/EponAdaptor/...                     MOD_EPONADAPTOR_AA_V3.1.1
element /vobs/dsl/source03/PortTranslation/...                 MOD_PORTTRANSLATION_AA_V1.0.4
element /cm4/fsn/app/servers/rcom/client/...                   MOD_RCOM-CLIENT_AA_V1.0.2
element /cm4/fsn/app/servers/sntp/server/...                   MOD_SNTP-SERVER_AA_V1.0.4
element /cm4/fsn/test/krnl/debug/...                           MOD_TRDB_TEST_AA_V1.0.1
element /vobs/esam/build/evlt-c/chipsim/...                    MOD_CHIPSIM_EVLT-C_AA_V2.1.0
element /vobs/esam/build/nalt-a/bootpromfs/...                 MOD_BLD_BOOTPROMFS_NALT-A_AA_V1.1.0
element /vobs/esam/build/nalt-a/bootprom/...                   MOD_BLD_BOOTPROM_NALT-A_AA_V1.1.0
element /vobs/esam/build/nalt-a/oflt_bh/...                    MOD_BLD_OFLT_BH_NALT-A_AA_V1.1.0
element /vobs/esam/build/nalt-a/osba/...                       MOD_BLD_OSBA_NALT-A_AA_V1.1.0
element /vobs/esam/build/nalt-a/pmd/...                        MOD_BLD_PMD_NALT-A_AA_V1.1.0
element /vobs/esam/build/nalt-a/chipsim/...                    MOD_CHIPSIM_NALT-A_AA_V1.1.0
element /vobs/dsl/source04/nalt-a_BSP/...                      MOD_NALT-A_BSP_AA_V1.0.1
element /vobs/dsl/source04/nalt-a_FS/...                       MOD_NALT-A_FS_AA_V1.0.1
element /vobs/dsl/source04/nalt-a_mini_bh/...                  MOD_NALT-A_MINI_BH_AA_V1.0.2
element /vobs/dsl/source04/BspDevPq1/...                       MOD_BSPDEVPQ1_AA_V4.1.0
element /vobs/dsl/source04/BspPq1Mmu/...                       MOD_BSPPQ1MMU_AA_V5.0.1
element /vobs/dsl/source02/BootLdrEsamIFXLsm/...               MOD_BOOTLDRESAMIFXLSM_AA_V1.1.0
element /vobs/dsl/source04/nalt-a_IFX_HAL/...                  MOD_NALT-A_IFX_HAL_AA_V1.1.0
element /vobs/dsl/source04/nalt-a_MISC_TS/...                  MOD_NALT-A_MISC_TS_AA_V1.1.0
element /vobs/dsl/source04/nalt-a_RI/...                       MOD_NALT-A_RI_AA_V1.1.0
#excluded:element /vobs/dsl/infineon/nalt-a_oflt_IFX/...                 MOD_NALT-A_OFLT_IFX_AA_V1.1.2
element /vobs/dsl/source04/nalt-a_OFLT_MAIN/...                MOD_NALT-A_OFLT_MAIN_AA_V1.1.0
#excluded:element /vobs/dsl/infineon/IFX_IWF_Drivers/...                 MOD_IFX_IWF_DRIVERS_AA_V1.3.12
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_ATM/...           MOD_IFX_LXFWD_ITFWRAP_ATM_AA_V1.3.3
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_INIT/...          MOD_IFX_LXFWD_ITFWRAP_INIT_AA_V1.3.13
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_L3FWD/...         MOD_IFX_LXFWD_ITFWRAP_L3FWD_AA_V1.3.10
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_MC/...            MOD_IFX_LXFWD_ITFWRAP_MC_AA_V1.3.2
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_PH/...            MOD_IFX_LXFWD_ITFWRAP_PH_AA_V1.3.10
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_PPPoAoE/...       MOD_IFX_LXFWD_ITFWRAP_PPPOAOE_AA_V1.3.11
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_QoS/...           MOD_IFX_LXFWD_ITFWRAP_QOS_AA_V1.3.4
#excluded:element /vobs/dsl/infineon/IFX_LxFwd_Itfwrap_VLAN/...          MOD_IFX_LXFWD_ITFWRAP_VLAN_AA_V1.3.10
#excluded:element /vobs/dsl/infineon/IFX_Modem_Drivers/...               MOD_IFX_MODEM_DRIVERS_AA_V1.0.9
#excluded:element /vobs/dsl/infineon/IFX_xDslProxy/...                   MOD_IFX_XDSLPROXY_AA_V1.0.29
element /vobs/dsl/source04/eblt-e_BOARD/...                    MOD_EBLT-E_BOARD_AA_V3.1.0
element /vobs/dsl/source04/82559_HAL/...                       MOD_82559_HAL_AA_V2.1.0
element /vobs/dsl/source04/BspIxp2400PCI/...                   MOD_BSPIXP2400PCI_AA_V2.1.0
#excluded:element /vobs/dsl/source13/NP_IXP2350_NAPT/...                 MOD_NP_IXP2350_NAPT_AA_V1.0.1
#excluded:element /vobs/dsl/source13/NP_LxFwd_itfwrap_NAPT/...           MOD_NP_LXFWD_ITFWRAP_NAPT_AA_V1.0.4
element /vobs/dsl/source04/BspDevIxp2400/...                   MOD_BSPDEVIXP2400_AA_V7.1.0
element /vobs/dsl/source04/BspCommon/...                       MOD_BSPCOMMON_AA_V3.0.1
element /vobs/dsl/source04/Ixp2400_Startup_OS/...              MOD_IXP2400_STARTUP_OS_AA_V2.2.0
element /vobs/esam/build/eblt-m/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-M_AA_V1.1.0
element /vobs/esam/build/eblt-k/chipsim/...                    MOD_CHIPSIM_EBLT-K_AA_V2.1.0
element /vobs/dsl/source04/eblt-k_BOARD/...                    MOD_EBLT-K_BOARD_AA_V2.1.0
element /vobs/dsl/source04/eblt-k_HWW/...                      MOD_EBLT-K_HWW_AA_V1.1.0
element /vobs/dsl/source04/eblt-k_TRAFFIC_TS/...               MOD_EBLT-K_TRAFFIC_TS_AA_V2.4.0
element /vobs/dsl/source04/eblt-m_RI_TS/...                    MOD_EBLT-M_RI_TS_AA_V1.1.0
element /vobs/dsl/source04/iwsm-a_BOARD/...                    MOD_IWSM-A_BOARD_AA_V3.2.0
element /vobs/esam/build/nalt-b/oflt_bh/...                    MOD_BLD_OFLT_BH_NALT-B_AA_V1.1.2
element /vobs/dsl/source03/SACUDrvItsc/...                     MOD_SACUDRVITSC_AA_V1.3.1
element -directory /vobs/dsl/sw/include/board/rvlt-a           /main/4
element /vobs/esam/build/iwsm-a/bootprom/...                   MOD_BLD_BOOTPROM_IWSM-A_AA_V1.0.5
element /vobs/esam/build/eant-a/oflt_bh/...                    MOD_BLD_OFLT_BH_EANT-A_AA_V1.0.1
element /vobs/esam/build/itsc-a/chipsim/...                    MOD_CHIPSIM_ITSC-A_AA_V1.1.0
element /vobs/dsl/source03/EqptCoreItsc/...                    MOD_EQPTCOREITSC_AA_V1.2.0
element /vobs/esam/build/rvlt-a/chipsim/...                    MOD_CHIPSIM_RVLT-A_AA_V2.1.0
element /vobs/dsl/source04/NP_IXP2350_UC_REM_HDS_BOOT/...      MOD_NP_IXP2350_UC_REM_HDS_BOOT_AA_V2.0.0
element /vobs/dsl/source04/NP_IXP2350_UC_REM_HDS_BOOT_BLD/...  MOD_NP_IXP2350_UC_REM_HDS_BOOT_BLD_AA_V2.0.0
element /vobs/dsl/source04/rvlt-a_BOARD/...                    MOD_RVLT-A_BOARD_AA_V2.2.0
element /vobs/dsl/source04/rvlt-a_CPLD_HAL/...                 MOD_RVLT-A_CPLD_HAL_AA_V2.0.0
element /vobs/dsl/source04/rvlt-a_FS/...                       MOD_RVLT-A_FS_AA_V2.0.0
element /vobs/dsl/source04/rvlt-a_mini_bh/...                  MOD_RVLT-A_MINI_BH_AA_V2.0.0
element /vobs/esam/build/ecnt-b/oflt_bh/...                    MOD_BLD_OFLT_BH_ECNT-B_AA_V1.0.1
element /cm4/fsn/prj/esam/eant-a/oflt/...                      MOD_EANT-A_OFLT_AA_FDT468.V1.0.1
element /vobs/esam/build/itsc-a/oflt_bh/...                    MOD_BLD_OFLT_BH_ITSC-A_AA_V1.0.2
element /vobs/dsl/source04/itsc-a_RI/...                       MOD_ITSC-A_RI_AA_V1.0.1
element /vobs/dsl/source04/iwsm-a_INTERFACE_TS/...             MOD_IWSM-A_INTERFACE_TS_AA_V2.0.7
element /vobs/dsl/source04/iwsm-a_MISC_TS/...                  MOD_IWSM-A_MISC_TS_AA_V2.0.4
element /vobs/dsl/source04/iwsm-a_OFLT_MAIN/...                MOD_IWSM-A_OFLT_MAIN_AA_V2.1.4
element /vobs/esam/build/eblt-n/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-N_AA_V1.1.0
element /vobs/dsl/source04/eblt-k_ACCESS_TS/...                MOD_EBLT-K_ACCESS_TS_AA_V1.1.0
element /vobs/dsl/source04/eblt-k_MISC_TS/...                  MOD_EBLT-K_MISC_TS_AA_V3.1.0
element /vobs/dsl/source04/eblt-m_OFLT_MAIN/...                MOD_EBLT-M_OFLT_MAIN_AA_V1.1.0
element /vobs/dsl/source04/eblt-n_BOARD/...                    MOD_EBLT-N_BOARD_AA_V1.1.0
element /vobs/dsl/source04/BCM5325E_HAL/...                    MOD_BCM5325E_HAL_AA_V2.0.1
element /vobs/esam/build/eblt-j/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-J_AA_V2.0.1
element /vobs/esam/build/eblt-j/osba/...                       MOD_BLD_OSBA_EBLT-J_AA_V2.0.1
element /vobs/esam/build/eblt-e/chipsim/...                    MOD_CHIPSIM_EBLT-E_AA_V2.0.1
element /vobs/esam/build/eblt-k/bootpromfs/...                 MOD_BLD_BOOTPROMFS_EBLT-K_AA_V1.0.1
element /vobs/esam/build/eblt-k/bootprom/...                   MOD_BLD_BOOTPROM_EBLT-K_AA_V2.0.3
element /vobs/esam/build/eblt-k/lca/...                        MOD_BLD_LCA_EBLT-K_AA_V1.0.2
element /vobs/esam/build/eblt-k/osba/...                       MOD_BLD_OSBA_EBLT-K_AA_V1.0.1
element /vobs/esam/build/eblt-e/bootprom/...                   MOD_BLD_BOOTPROM_EBLT-E_AA_V1.0.2
element /vobs/esam/build/eblt-e/oflt_bh/...                    MOD_BLD_OFLT_BH_EBLT-E_AA_V1.0.4
element /vobs/esam/build/eblt-e/osba/...                       MOD_BLD_OSBA_EBLT-E_AA_V1.0.2
element /vobs/esam/build/eblt-j/pmd/...                        MOD_BLD_PMD_EBLT-J_AA_V1.0.0
element /vobs/dsl/source04/vsem-a_RI_HAL/...                   MOD_VSEM-A_RI_HAL_AA_V2.0.1
element /vobs/dsl/source04/vsem-a_BOARD/...                    MOD_VSEM-A_BOARD_AA_FDT295.V4.0.1
element /vobs/dsl/source04/vsem-a_TRAFFIC_TS/...               MOD_VSEM-A_TRAFFIC_TS_AA_FDT295.V2.0.1
element /vobs/dsl/source02/BlDummyGantc/...                    MOD_BLDUMMYGANTC_AA_V3.1.0
element /vobs/dsl/source04/BspIxp2400Debug/...                 MOD_BSPIXP2400DEBUG_AA_V2.1.0
element /vobs/dsl/source04/BspXscaleManzanoMmu/...             MOD_BSPXSCALEMANZANOMMU_AA_V2.1.0
element /cm4/fsn/prj/esam/eant-a/mini_bh/...                   MOD_POST_EANT-A_AA_V2.0.1
#excluded:element /vobs/dsl/source13/BootldrEsamZalLsm/...               MOD_BOOTLDRESAMZALLSM_AA_FDT471.V2.0.0
element /cm4/fsn/krnl/test_print/...                           MOD_TEST_PRINT_AA_FDT471.V1.0.0
element /vobs/dsl/source04/BspVxWorks/...                      MOD_BSP_PQ1_VXWORKS_V1.0.3
element /vobs/dsl/source04/itsc-a_mini_bh/...                  MOD_ITSC-A_MINI_BH_AA_V1.1.1
element /vobs/dsl/source04/itsc-a_BSP/...                      MOD_ITSC-A_BSP_AA_V1.2.1
element /vobs/dsl/source03/InfraCommon/...                     MOD_INFRACOMMON_AA_V3.2.1
element /vobs/dsl/source04/iwsm-a_CPLD_HAL/...                 MOD_IWSM-A_CPLD_HAL_AA_V1.0.3
element /vobs/dsl/source04/TestAndSealCurr_itfwrap/...         MOD_TESTANDSEALCURR_ITFWRAP_AA_V1.1.0
element /vobs/dsl/source04/BspPq1Debug/...                     MOD_BSPPQ1DEBUG_AG_FDT408.V1.1.0
element /vobs/dsl/source03/ITSCMessageHandlerItsc/...          MOD_ITSCMESSAGEHANDLERITSC_AA_V1.1.0
element /vobs/esam/build/asem-b/bootpromfs/...                 MOD_BLD_BOOTPROMFS_ASEM-B_AA_V1.0.2
element /vobs/esam/build/asem-b/bootprom/...                   MOD_BLD_BOOTPROM_ASEM-B_AA_V1.0.2
element /vobs/esam/build/asem-b/oflt_bh/...                    MOD_BLD_OFLT_BH_ASEM-B_AA_V1.0.2
element /vobs/esam/build/asem-b/osba/...                       MOD_BLD_OSBA_ASEM-B_AA_V1.0.2
element /vobs/dsl/source04/asem-b_CPLD_HAL/...                 MOD_ASEM-B_CPLD_HAL_AA_V1.0.2
element /vobs/dsl/source04/asem-b_FS/...                       MOD_ASEM-B_FS_AA_V1.0.1
element /vobs/dsl/source04/asem-b_HWW/...                      MOD_ASEM-B_HWW_AA_V1.0.1
element /vobs/dsl/source04/asem-b_OFLT_MAIN/...                MOD_ASEM-B_OFLT_MAIN_AA_V1.0.1
element /vobs/dsl/source04/asem-b_RI_HAL/...                   MOD_ASEM-B_RI_HAL_AA_V1.0.1
element /vobs/dsl/source04/asem-b_RI_TS/...                    MOD_ASEM-B_RI_TS_AA_V1.0.1
element /vobs/dsl/source04/asem-b_mini_bh/...                  MOD_ASEM-B_MINI_BH_AA_V1.0.1
element /vobs/dsl/source04/asem-b_post/...                     MOD_ASEM-B_POST_AA_V1.0.1
element /vobs/dsl/source06/ASM/...                             MOD_ASM_AA_V1.3.13
element /vobs/dsl/source02/TsecLlDrv/...                       MOD_TSECLLDRV_AA_V2.0.1
element /vobs/dsl/source04/eblt-e_RI_HAL/...                   MOD_EBLT-E_RI_HAL_AA_V1.1.0
element /vobs/dsl/source04/eblt-e_EPLD_HAL/...                 MOD_EBLT-E_EPLD_HAL_AA_V1.1.0
element /vobs/dsl/source08/L2CPData/...                        MOD_L2CPDATA_AA_V1.1.4
element /vobs/dsl/source02/Alarm_migCode/...		       MOD_ALARM_MIGCODE_AA_V1.0.0
element /vobs/dsl/source04/itsc-a_MISC_TS/...		       MOD_ITSC-A_MISC_TS_AA_V1.0.3
element /vobs/dsl/source04/nant-a_BspProzone/...	       MOD_NANT-A_BSPPROZONE_AA_V1.0.0
element /vobs/dsl/source04/nant-a_mini_bh/...		       MOD_NANT-A_MINI_BH_AA_V1.0.0
element /vobs/esam/build/nalt-b/chipsim/...		       MOD_CHIPSIM_NALT-B_AA_V1.1.0
element /vobs/dsl/source04/nalt-b_MISC_TS/...		       MOD_NALT-B_MISC_TS_AA_V1.0.0
element /vobs/dsl/source04/nalt-b_OFLT_MAIN/... 	       MOD_NALT-B_OFLT_MAIN_AA_V1.0.0
element /vobs/dsl/source04/nalt-b_RI/...		       MOD_NALT-B_RI_AA_V1.0.0
element /vobs/dsl/source04/nalt-b_oflt_BCM/...  	       MOD_NALT-B_OFLT_BCM_AA_V1.0.0
element /cm4/fsn/prj/esam/eant-a/bh/... 		       MOD_EANT-A_BH_AA_V2.0.1
element /cm4/fsn/include/...				       MOD_INCLUDE_AA_V6.0.1
element /cm4/fsn/krnl/cpu/M8260/...			       MOD_KRNLCPU_M8260_AA_V3.0.0
element /cm4/fsn/krnl/startup/board/... 		       MOD_STARTUP_BOARD_V2.0.0
#excluded:element /vobs/dsl/source13/polt-a_FS/...		       MOD_POLT-A_FS_AA_V2.0.0
element /vobs/esam/build/vsem-a/bootpromfs/...  	       MOD_BLD_BOOTPROMFS_VSEM-A_AA_V2.0.0
element /vobs/esam/build/vsem-a/bootprom/...		       MOD_BLD_BOOTPROM_VSEM-A_AA_V2.0.0
element /vobs/dsl/source04/SLB_LxFwd_itfwrap_ASM/...	       MOD_SLB_LXFWD_ITFWRAP_ASM_AA_V2.1.2
element /cm4/tools/GHS/integrity/ppc  /main/4
element -directory /cm4/tools/BELL			       /main/26
element /cm4/tools/BELL/grf/... 			       MOD_GRF_TOOLS_AA_V1.0.0
element /vobs/esam/build/ecnt-b/osba/...		       MOD_BLD_OSBA_ECNT-B_AA_V1.0.0
element /cm4/fsn/app/osba/...				       MOD_OSBA_AA_V2.1.0
element /vobs/esam/build/vsem-a/oflt_bh/...		       ISR24_FGN30_18__REBL
element /vobs/dsl/source04/vsem-a_ACCESS_TS/... 	       ISR24_FGN30_18__REBL
element /vobs/dsl/source04/vsem-a_CPLD_HAL/...  	       ISR24_FGN30_18__REBL
element /vobs/dsl/source04/vsem-a_OFLT_MAIN/... 	       ISR24_FGN30_18__REBL
element /cm4/fsn/build/co/compiler.mak  		      /main/ghs/MOD_BLDCOMMON_V1.17.7
element /cm4/fsn/build/co/host_arch.mak 		      /main/solaris/MOD_BLDCOMMON_V1.17.7
element /cm4/fsn/build/co/target_os.mak 		      /main/vxworks/MOD_BLDCOMMON_V1.17.7
element /cm4/fsn/build/co/target_arch.mak		      /main/IXP2400/MOD_BLDCOMMON_V1.17.7
element -directory /cm4/tools/GHS/integrity		      /main/1
element /cm4/tools/GHS/integrity/ppc/bsp/bsp_export.h	      -none
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4_PATCH3
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4_PATCH2
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4_PATCH1
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4_PQ2PRO_02
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4_PQ2PRO_01
element /cm4/tools/GHS/integrity/ppc/...		      GHS_INTEGRITY_PPC_V5.0.4
element -directory /cm4/fsn/prj/esam/ecnt-c		      /main/2
element  /vobs/dsl/sw/include/board/ecnt-c/...  	      /main/3
#excluded:element -directory /vobs/esam/objects/ecnt-c		      /main/0
element -directory /cm4/fsn/include			      /main/171
element /vobs/dsl/source04/NP_IXP2350_UC_VDSL_Drivers/...      MOD_NP_IXP2350_UC_VDSL_DRIVERS_AA_V4.0.0
element /cm4/tools/GNU/src/binutils/...       BINUTILS-2.10.3
element /cm4/tools/GNU/src/flex/...	      FLEX-2.5.4b
element /cm4/tools/GNU/src/bison/...	      BISON-1.28.3
element /cm4/tools/BELL/src/octopus/...       MOD_OCTOPUS_V1.2.1
element /cm4/tools/GNU/src/gcc-2.7.2/...      MOD_GNUCRT_V2.0.1
element /cm4/tools/GNU/...		      MOD_DIRS_TOOLS_GNU_V1.0.4
element /cm4/tools/ETCA/...		      MOD_CHOITOOLS-RUBY_V1.0.1
element -dir  /cm4/tools/ANS/...	      TOOLS_DIR_ANS_V1.0.0
element /cm4/tools/BELL/Linux_2.4.7-10/...    MOD_BELLBIN_V1.6.9
element /cm4/tools/BELL/Linux_2.4.20-8/...    MOD_BELLBIN_V1.6.9
element /vobs/dsl/source02/EthHlLlItf/...		       MOD_ETHHLLLITF_AA_V5.1.0
element /cm4/fsn/platform/assert/...			       MOD_ASSERT_AA_V1.0.0
element /vobs/esam/build/ecnt-c/flashwrite/...  	       MOD_BLD_FLASHWRITE_ECNT-C_AA_V1.0.7
element /vobs/esam/build/ecnt-c/osba/...		       MOD_BLD_OSBA_ECNT-C_AA_V1.0.0
element /vobs/esam/build/ecnt-c/pmd/... 		       MOD_BLD_PMD_ECNT-C_AA_V1.0.0
element /cm4/fsn/krnl/bsp/sys/...			       MOD_BSP_SYS_AA_V1.1.0
element /vobs/dsl/source04/BspDevDdrPq2Pro/...  	       MOD_BSPDEVDDRPQ2PRO_AA_V1.1.3
element /vobs/dsl/source04/BspDevPitPq2Pro/...  	       MOD_BSPDEVPITPQ2PRO_AA_V1.0.3
element /vobs/dsl/source04/BspDevPq2Pro/...		       MOD_BSPDEVPQ2PRO_AA_V1.0.17
element /vobs/dsl/source04/BspPq2ProBp/...		       MOD_BSPPQ2PROBP_AA_V1.0.0
element /vobs/dsl/source04/BspPq2ProCo/...		       MOD_BSPPQ2PROCO_AA_V1.0.2
element /vobs/dsl/source04/BspPq2ProDebug/...		       MOD_BSPPQ2PRODEBUG_AA_V1.0.2
element /vobs/dsl/source04/BspPq2ProErr/...		       MOD_BSPPQ2PROERR_AA_V1.0.2
element /vobs/dsl/source04/BspPq2ProMmu/...		       MOD_BSPPQ2PROMMU_AA_V1.0.7
element /vobs/esam/build/ecnt-c/chipsim/...		       MOD_CHIPSIM_ECNT-C_AA_V1.0.0
element /vobs/dsl/source02/CPUPQ2PROApi/...		       MOD_CPUPQ2PROAPI_AA_V1.0.0
element /vobs/dsl/source02/CPUPQ2PRODebug/...		       MOD_CPUPQ2PRODEBUG_AA_V1.0.0
element /vobs/dsl/source02/CPUPQ2PROError/...		       MOD_CPUPQ2PROERROR_AA_V1.0.3
element /cm4/fsn/krnl/fs/blockDevice/...		       MOD_FSBLKDEV_AA_V2.0.2
element /cm4/fsn/krnl/fs/diskDevice/... 		       MOD_FSDISKDEV_AA_V2.2.1
element /cm4/fsn/krnl/fs/pmd/...			       MOD_FSPMD_AA_V1.0.0
element /cm4/fsn/test/krnl/fs/...			       MOD_FSTEST_V3.0.8
element /cm4/fsn/krnl/fs/whost_fs/...			       MOD_FSWHOST_AA_V1.0.0
element /vobs/dsl/source04/INTEGRITY_ECNTA_ABSP/...	       MOD_INTEGRITY_ECNTA_ABSP_AA_V1.0.0
element /vobs/dsl/source04/Pq2Pro_StartupTest/...	       MOD_PQ2PRO_STARTUPTEST_AA_V1.0.2
element /vobs/dsl/source04/Pq2Pro_Startup_FS/...	       MOD_PQ2PRO_STARTUP_FS_AA_V1.0.4
element /vobs/dsl/source04/Pq2Pro_Startup_OSBA/...	       MOD_PQ2PRO_STARTUP_OSBA_AA_V1.0.0
element /vobs/dsl/source02/SimpleTrace/...		       MOD_SIMPLETRACE_AA_V1.1.1
element /cm4/fsn/test/krnl/xapi/xapiTest/...		       MOD_XAPITEST_AA_V1.4.1
element /vobs/dsl/source04/ecnt-c_BspProzone/...	       MOD_ECNT-C_BSPPROZONE_AA_V1.0.0
element /vobs/dsl/source04/ecnt-c_flash/...		       MOD_ECNT-C_FLASH_AA_V1.0.0
element /cm4/fsn/hs/lsock/...				       MOD_LSOCK_AA_V3.0.3
element /vobs/dsl/source04/eblt-k_RI_HAL/...		       MOD_EBLT-K_RI_HAL_AA_V3.0.0
element /cm4/tools/WRS/tornado/target/lib/libPPC860gnuvx.a /main/mieghehu_try/1
element /cm4/fsn/krnl/RTEMS/cpu/HOST/...		       MOD_RTEMS_CPU_HOST_AA_V2.0.2
element /vobs/dsl/source03/ACUFIRMWARE/...		       MOD_ACUFIRMWARE_AA_V2.1.1
element /vobs/dsl/source04/NP_WESTPORT_HDS_BOOT_BLD/...        MOD_NP_WESTPORT_HDS_BOOT_BLD_AA_V1.0.1
element /vobs/dsl/source04/NP_WESTPORT_UC_HDS_BOOT/...         MOD_NP_WESTPORT_UC_HDS_BOOT_AA_V1.0.1
element /cm4/fsn/krnl/RTEMS/cpu/solaris2_mkcontext/...         MOD_RTEMS_CPU_SOLARIS_AA_V2.1.2
element /vobs/dsl/mibs/rfc1155.smi 3EC36726AAAA_V6.0.0.1.0
element /vobs/dsl/mibs/rfc1215.smi  /main/1
element /cm4/tools/ANS/clc_annex/...			       TOOLS_CLC_ANNEX_AA_FDT031.V2.0.0
element /vobs/esam/build/evlt-f/chipsim/...		       MOD_CHIPSIM_EVLT-F_AA_V1.1.0
element -dir /vobs/esam/build/evlt-f			/main/3
element -dir /cm4/tools/GNU/SunOS_5.6/lib	  /main/8
element /cm4/tools/GNU/SunOS_5.6/lib/libpcap.a    /main/fdt031/1
element /vobs/esam/build/ecnt-b/lca/... 		       MOD_BLD_LCA_HYXT_A_AA_V1.0.0
element /cm4/fsn/krnl/startup/M8270/... 		       MOD_STARTUP_M8270_AA_V1.0.0
element  -dir /cm4/fsn/prj/co/lca  /main/2
element  -dir /vobs/esam/build/ecnt-b	/main/6
element /cm4/tools/BELL/src/check/...			       MOD_CHECK_V1.2.2
element /cm4/fsn/app/servers/fcmt/...			       MOD_FCMT_ERR_AA_V4.0.0
element /cm4/fsn/krnl/fs/host_fs/...			       MOD_FSHOST_AA_V3.0.0
element /cm4/tools/TROLLTECH/src/qt/... 			MOD_QT_V1.0.2
element /cm4/tools/BELL/src/snmpTest/snmpMib/total		/main/asb_ESAM1.0/2
element /cm4/tools/BELL/src/snmpApi/... 			MOD_SNMPAPI_V1.3.11
element -dir /cm4/tools/BELL/src/snmpTest			MOD_SNMPTESTTOOL_V3.0.9
element /cm4/tools/BELL/src/snmpTest/...			MOD_SNMPTESTTOOL_V3.0.11
element /cm4/tools/BELL/src/snmpTestMacros/...  		MOD_SNMPTESTMACROS_V3.0.2
element /cm4/tools/BELL/src/snmpTest/Makefile			/main/bangalore_5/linux_testing/3
element /cm4/tools/BELL/lib/snmpTestToolLibs			/main/bangalore_5/5
element /vobs/dsl/source04/ecnt-c_mini_bh/...		       MOD_ECNT-C_MINI_BH_AA_V1.0.1
element /cm4/fsn/krnl/bsp/dev/pit/...			       MOD_BSP_DEV_PIT_AA_V1.0.3
element /cm4/fsn/krnl/fs/...				       MOD_FS_AA_V7.0.4
element /cm4/tools/GNU/src/libsmi/...			      TOOLS_LIBSMI_V1.0.4.3
element /vobs/dsl/source11/NP_IXP2400_hww_LIB/...	       MOD_NP_IXP2400_HWW_LIB_AA_V3.0.0
element /vobs/dsl/source04/iwsm-a_mini_bh/...		       MOD_IWSM-A_MINI_BH_AA_V1.0.3
element /vobs/dsl/source04/IXF1104_HAL/...		       MOD_IXF1104_HAL_AA_V4.0.1
element /vobs/dsl/source04/iwsm-a_FS/...		       MOD_IWSM-A_FS_AA_V1.1.1
element /cm4/tools/BELL/src/check/...			       MOD_CHECK_V1.2.2
element /cm4/tools/BELL/SunOS_5.6/...			       MOD_BELLBIN_V2.0.0
element /vobs/esam/build/itsc-a/osba/...		       MOD_BLD_OSBA_ITSC-A_AA_V1.0.0
element /vobs/dsl/source04/itsc-a_FS/...		       MOD_ITSC-A_FS_AA_V1.1.0
element /vobs/dsl/source04/itsc-a_OSBA/...		       MOD_ITSC-A_OSBA_AA_V1.0.0
element /vobs/dsl/source04/itsc-a_Startup_Boot/...	       MOD_ITSC-A_STARTUP_BOOT_AA_V1.1.0
element /vobs/dsl/source04/itsc-a_Startup_FS/...	       MOD_ITSC-A_STARTUP_FS_AA_V1.1.0
element /cm4/tools/BELL/src/strip/...			       TOOLS_STRIP_V2.0.1
element /vobs/esam/build/eblt-k/oflt_bh/...		       MOD_BLD_OFLT_BH_EBLT-K_AA_V2.0.2
element /vobs/dsl/source04/NP_IXP2350_UC_SLB_HDS_BOOT/...      MOD_NP_IXP2350_UC_SLB_HDS_BOOT_AA_V2.0.3
element /vobs/dsl/source04/NP_IXP2350_UC_SLB_HDS_BOOT_BLD/...  MOD_NP_IXP2350_UC_SLB_HDS_BOOT_BLD_AA_V2.0.2
element /vobs/dsl/source04/SLBIM_HAL/...		       MOD_SLBIM_HAL_AA_V2.0.2
element /vobs/dsl/source04/eblt-k_OFLT_MAIN/... 	       MOD_EBLT-K_OFLT_MAIN_AA_V2.0.3
element /vobs/dsl/source02/BootLdrEsamIxpLsm/...	       MOD_BOOTLDRESAMIXPLSM_AA_V6.0.0
element /vobs/esam/build/iwsm-a/chipsim/...		       MOD_CHIPSIM_IWSM-A_AA_V1.0.0
element /vobs/dsl/source04/iwsm-a_BspProzone/...	       MOD_IWSM-A_BSPPROZONE_AA_V1.0.1
element /vobs/dsl/source04/iwsm-a_post/...		       MOD_IWSM-A_POST_AA_V1.0.1
element /vobs/esam/build/ecnt-b/chipsim/...		       MOD_CHIPSIM_ECNT-B_AA_V1.1.0
element /vobs/dsl/source04/iwsm-a_ACCESS_TS/... 	       MOD_IWSM-A_ACCESS_TS_AA_V2.0.0
element /vobs/dsl/source02/ASM_TESTBENCH/...		       MOD_ASM_TESTBENCH_AA_V1.1.0
element /vobs/esam/build/ealt-a/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eant-a/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eblt-a/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eblt-c/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eblt-e/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eblt-g/... ISR24_FGN30_18__REBL
element /vobs/esam/build/eblt-j/... ISR24_FGN30_18__REBL
element /vobs/esam/build/ecnt-a/... ISR24_FGN30_18__REBL
element /vobs/esam/build/ecnt-b/... ISR24_FGN30_18__REBL
element /vobs/esam/build/evlt-a/... ISR24_FGN30_18__REBL
element /vobs/esam/build/evlt-c/... ISR24_FGN30_18__REBL
element /vobs/esam/build/vsem-a/... ISR24_FGN30_18__REBL
element /vobs/dsl/source02/...      ISR24_FGN30_18__REBL
element /vobs/dsl/source03/...      ISR24_FGN30_18__REBL
element /vobs/dsl/source04/...      ISR24_FGN30_18__REBL
element /vobs/dsl/source05/...      ISR24_FGN30_18__REBL
element /vobs/dsl/source08/...      ISR24_FGN30_18__REBL
element /vobs/dsl/source11/...      ISR24_FGN30_18__REBL
#excluded:element -dir /vobs/esam/objects/ecnt-b /main/0
element /cm4/fsn/hs/service_lib/registers/...		       MOD_REGISTER_ACCESS_AA_V2.1.2
element /cm4/fsn/krnl/os/export/...			       MOD_KRNLOS_EXPORT_AA_V1.0.0
element /cm4/fsn/krnl/tick_disp/...			       MOD_TICKDISP_AA_V1.0.0
element /cm4/tools/BELL/src/elf2coff/... MOD_ELF2COFF_V1.2.3
element /vobs/dsl/tools/configspecs/cmtools.cs 3FQ40072AAAA_LATEST
#include /view/LATEST/vobs/dsl/tools/configspecs/cmtools.cs@@/3FQ40072AAAA_LATEST
#---- entering 1 /view/LATEST/vobs/dsl/tools/configspecs/cmtools.cs@@/3FQ40072AAAA_LATEST
element /cm4/tools/BELL/src/cmtools/bldmgnt/lib/... TOOLS_BLDMGNTCODELIBRARY_V1.1.1
element /cm4/tools/BELL/src/cmtools/cnfmgnt/checkDeliveries/... TOOLS_CMCHECKDELIVERIES_V1.1.0
element /cm4/tools/BELL/src/cmtools/cnfmgnt/datadump/...        TOOLS_CMDATADUMP_V1.0.0
element /cm4/tools/BELL/src/cmtools/cnfmgnt/deliver/...         TOOLS_CMDELIVER_V2.9.1
element /cm4/tools/BELL/src/cmtools/cnfmgnt/maintenance/...     TOOLS_CMMAINTENANCE_V1.0.1
element /cm4/tools/BELL/src/cmtools/cnfmgnt/scm/...             TOOLS_CMSCM_V1.11.14
element /cm4/tools/BELL/src/cmtools/cnfmgnt/syncdb/...          TOOLS_CMSYNCDB_V1.2.0
element /cm4/tools/BELL/src/cmtools/cnfmgnt/test/...            TOOLS_CMTEST_V1.0.0
element /cm4/tools/BELL/src/cmtools/lib/...                     MOD_CMTOOLSCODELIBRARY_V1.2.1
element /cm4/tools/BELL/src/cmtools/data/...                    /main/LATEST
element /cm4/tools/BELL/src/cmtools/doc/...                     /main/LATEST
element /cm4/tools/BELL/src/cmtools/html/...                    /main/LATEST
element -directory /cm4/tools/BELL/src/cmtools/...              MOD_DIR_CMTOOLS_V2.0.0
element /vobs/admin/cc_admin/src/triggers/scm/...               3FQ40070AAAA_LATEST
element -directory /vobs/admin/cc_admin/...                     /main/LATEST
element /cm4/tools/Rational/...                                 TOOLS_RATIONAL_AA_V1.1.6
element /cm4/tools/BELL/src/tar_buildview/...                   3EC20703AAAA_V1.1.1
element /cm4/tools/BELL/src/build/...                           TOOLS_BUILD_V1.6.4
element /cm4/tools/BELL/src/cntbld/...                          TOOLS_CNTBLD_V1.2.9
element /cm4/tools/BELL/src/scanwarnings/scanwarnings           /main/snahws_tmp/5
element /cm4/tools/BELL/src/scanwarnings/...                    TOOLS_SCANWARNINGS_V1.0.0
element /cm4/tools/GNU/src/ActiveTcl/...                        ActiveTcl8.4.14.0.272572
element /cm4/tools/BELL/src/ghsmap/...                          TOOLS_GHS_MAP_V1.0.0
element /cm4/tools/BELL/src/fsterm/...                          MOD_FSTERM_V1.1.1
element /cm4/tools/BELL/src/termServ/...                        TOOLS_TERMSERV_V1.0.0
element /cm4/tools/BELL/src/BW/...                              TOOLS_BUILDWRAPPER_V1.0.2
element /cm4/tools/BELL/src/clidiff/...                         TOOLS_CLIDIFF_V1.0.4
element /cm4/tools/BELL/src/package/...                         TOOLS_PACKAGE_V1.0.14
element /cm4/tools/BELL/src/makeSWCD/...                        TOOLS_MAKESWCD_V1.0.0
element /cm4/tools/BELL/src/XmiSpy/...                          TOOLS_XMISPY_AA_V1.4.2
element /vobs/tools/ALCATEL/sst/...                             TOOLS_SMART_TEST_ENGINE_V1.0.2
element /cm4/tools/BELL/src/install_usr_dsl/...                 TOOLS_INSTALL_USR_DSL_V1.1.0
element /vobs/dsl/tools                                         /main/17
#---- leaving  1 /view/LATEST/vobs/dsl/tools/configspecs/cmtools.cs@@/3FQ40072AAAA_LATEST
element /cm4/tools/GNU/src/gcc/...			       TOOLS_GCC-2.95.3_V1.0.0
element /cm4/fsn/krnl/bsp/pq2/VxWorks/...		       MOD_BSP_VXWORKS_V1.0.7
element /cm4/fsn/krnl/bsp/vx_wrappers/...		       MOD_VXWRAP_V1.0.8
element /vobs/dsl/ISSCode/...		     MOD_ISSCODE_V2.4.6.1
element /vobs/esam/build/droptests/...  		       BTC_ISAM_DROPTEST_AA_V1.0.0
element /cm4/fsn/platform/zlib/...			       MOD_ZLIB_AA_V2.0.1
element -dir /vobs/dsl/sw/include/board/eblt-e /main/11
element -dir /vobs/dsl/sw/include/board/vsem-a /main/3
element -dir /vobs/dsl/sw/include/board/eblt-k /main/3
#excluded:element -dir /vobs/esam/objects/eblt-k /main/0
element -dir /cm4/fsn/krnl/bsp  		/main/23
element -dir /cm4/fsn/krnl/bsp/dev		/main/16
element /cm4/fsn/krnl/os/RTEMS/...			MOD_KRNLOS_RTEMS_AA_V1.2.2
element -dir /vobs/esam/build/evlt-e			 /main/1
element /cm4/tools/BELL/src/scanpurelog 		       MOD_GVTTOOLS_V1.0.2
#excluded:element -dir /vobs/esam/objects/evlt-e  		 /main/0
element /vobs/dsl/source02/Password/... -none
element /vobs/dsl/source04/LibCrypt/... -none
element /vobs/dsl/source04/LibVT100/... -none
element /vobs/dsl/source04/LibEnv/... -none
element /cm4/fsn/hs/common/... -none
element -dir /vobs/esam/build/eblt-k			       /main/4
element -dir /vobs/dsl/interpeak /main/1
element -dir /vobs/esam/build/eblt-g /main/6
element -dir /vobs/esam/build/eblt-h /main/1
element -dir /vobs/dsl/sw/include/board/eblt-g /main/1
element -dir /vobs/dsl/sw/include/board/eblt-h /main/1
element -dir /vobs/dsl/sw/include/board/eblt-j /main/3
element /cm4/fsn/krnl/hw_wd/... MOD_KRNLHWWD_AA_V2.0.0
element /cm4/fsn/app/asam/systemDataMgnt/extLsm/... MOD_SYSDATMGR-EXTLSM_AA_V1.0.1
element /cm4/tools/BELL/src/raw2lz77/... MOD_RAW2LZ77_V1.0.0
element -dir /vobs/esam/build/vsem-a /main/1
#excluded:element -dir /vobs/esam/objects/vsem-a /main/0
element -dir /cm4/tools/PARASOFT /main/3
element -dir /cm4/tools/PARASOFT/BellScripts /main/2
element /cm4/tools/PARASOFT/... TOOLS_CWF_V1.1.0
element -dir /cm4/tools/PARASOFT/CodeWizard /main/1
element /cm4/tools/PARASOFT/... TOOLS_CODEWIZARD_V1.0.5
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2_PATCH2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH3
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH2
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2
element -dir /cm4/fsn/prj/co/oflt MOD_OFLT_COMMON_DIR_V1.0.0
element -dir /cm4/fsn/prj/co/oflt/lt MOD_OFLT_COMMON_LT_V1.11.0
element -dir /cm4/fsn/prj/co/oflt/lt/broadcom MOD_OFLT_COMMON_LT_V1.11.0
element /cm4/fsn/prj/co/oflt/lt/broadcom/MCS6430F_Reference_Host_Code/... MOD_BCM_FW_BETA_AA_V1.0.0
element -dir /vobs/esam/build/oflmt /main/7
element /cm4/fsn/lib/CRC/... MOD_LIBCRC_V1.2.3
element -dir /vobs/dsl/sw/include/THIRDPARTY /main/7
element -dir /vobs/esam/build/eblt-e /main/7
#excluded:element -dir /vobs/esam/objects/eblt-e /main/0
#excluded:element -dir /vobs/esam/objects/eblt-g /main/0
#excluded:element -dir /vobs/esam/objects/eblt-j /main/0
element /cm4/fsn/krnl/bsp/crcProm/... MOD_BSP_CRCPROM_AA_V2.0.0
element -dir /vobs/esam/configspecs/ESAM_2.3 /main/24
element -dir /vobs/esam/configspecs /main/32
element /vobs/esam/configspecs/ESAM_R2.2_mainstream.cs /main/aaaa/40
element /cm4/fsn/krnl/tracepoints/... MOD_KRNLTRCPTS_V1.1.3
element /cm4/fsn/test/krnl/random/... MOD_RANDOM_V1.0.1
element -dir /vobs/esam/build/evlt-a /main/7
element -dir /vobs/esam/build/evlt-c /main/2
element -dir /vobs/dsl/sw/include/board/evlt-c /main/1
element -dir /cm4/fsn/prj/esam/evlt-c /main/1
#excluded:element -dir /vobs/esam/objects/evlt-c /main/0
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2_PATCH2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH2
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2
element -dir /cm4/fsn/platform /main/14
element /cm4/fsn/app/servers/rfs/server/... MOD_ASAMRFSSERVER_V3.0.10
element /cm4/tools/BELL/src/scanwarnings MOD_GVTTOOLS_V1.0.2
element /cm4/tools/BELL/src/CodeSizeMetrics/... MOD_BUILDCODESIZE_V1.0.8
element /cm4/tools/BELL/build/tools/... MOD_BUILDTOOLS_V1.3.29
element /cm4/tools/GNU/src		       /main/24
element /cm4/tools/GNU/src/perl/...	       PERL5.8.3_V1.0.0
element /cm4/tools/GNU/src/expat/...	       EXPAT_V1.95.7
element /cm4/tools/GNU/src/libxml2/...         LIBXML2-V2.6.8
element /cm4/tools/GNU/src/libxslt/...         LIBXSLT_V1.1.6
element -dir /vobs/esam/configspecs/ESAM_2.2 /main/8
element /vobs/esam/configspecs/ESAM_R2.1_mainstream.cs /main/aaaa/28
element -dir /cm4/tools/TROLLTECH/... MOD_DIRS_TOOLS_TROLLTECH_V1.0.1
element /cm4/tools/TROLLTECH/src/... MOD_DIRS_TOOLS_TROLLTECH_V1.0.1
element /cm4/tools/BELL/src/snmpTest/snmpMib/total /main/asb_ESAM1.0/2
element /cm4/tools/BELL/src/snmpApi/... MOD_SNMPAPI_V1.3.7
element /cm4/tools/BELL/lib/snmpTestToolLibs/... MOD_SNMPTESTLIBS_V3.0.1
element -dir /cm4/fsn/hs/xdsl_proxy/common /main/2
#excluded:element -dir /vobs/esam/objects/evlt-a /main/0
element -dir /cm4/fsn/prj/esam/evlt-a /main/2
element -dir /cm4/fsn/app/asam/xdsl /main/VOB_TRANSFER/1
element -dir /vobs/esam/configspecs/ESAM_2.1 /main/LATEST
element /vobs/esam/configspecs/ESAM_2.1/... /main/aaaa/LATEST
element /vobs/esam/build/regrtests/... /main/LATEST
element /vobs/esam/build/smoketests/... /main/LATEST
element /vobs/esam/configspecs/ESAM_R1.1.5_mainstream.cs /main/aaaa/21
element -dir /vobs/esam/build/eblt-c /main/11
element /cm4/fsn/krnl/bsp/board/cokim/export/... -error
element /cm4/tools/BELL/src/dataMgnt /main/2
element -dir /cm4/fsn/prj/asam/gant-c MOD_DIRS_V5.0.15
element /cm4/fsn/prj/asam/gant-c/export/... MOD_ECFG_ASAM-GANT-C_V5.1.2
element /cm4/fsn/krnl/bsp/board/cokim/... MOD_BSP_COKIM_V1.1.36
element /cm4/tools/BELL/src/mibpp  MOD_MIBPP_V1.0.1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH2
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2
element -dir /vobs/dsl/sw/include/board/eblt-c /main/11
element /vobs/esam/configspecs/ESAM_R1.1_mainstream.cs /main/aaaa/LATEST
element /vobs/esam/configspecs/ESAM_R1.1_XScale_mainstream.cs /main/aaaa/14
element /vobs/esam/configspecs/ESAM_1.1/PT_specific.cs /main/aaaa/LATEST
element /cm4/fsn/krnl/boot/xapi/... MOD_XAPIBOOT_V1.1.0
element /cm4/fsn/lib/clib/... MOD_CLIB_ASAM_V1.0.0
element /cm4/fsn/lib/str_io/... 			       MOD_STRIO_AA_V1.0.0
element /cm4/fsn/lib/system/... MOD_LIBSYSTEM_V1.1.7
element /cm4/fsn/platform/tarUntar/... MOD_TARUNTAR_V1.1.5
element /cm4/fsn/app/asam/common/classes/... MOD_ASAM_COMMON_CLASSES_V3.2.1
element -dir /vobs/esam/build/eblt-a /main/3
element -dir /vobs/esam/build/ecnt-a /main/5
element -dir /vobs/esam/build/ecnt-c /main/1
element -dir /vobs/esam/objects/eblt-a /main/0
element -dir /vobs/esam/objects/eblt-c /main/0
element -dir /vobs/dsl/extra /main/LATEST
element -dir /vobs/dsl/fsn /main/3
element -dir /vobs/dsl/source07 /main/5
element -dir /vobs/dsl/sw/include/board/ixdp2400 /main/2
element -dir /cm4/fsn/app/asam/prodata/board /main/14
element -dir /cm4/fsn/app/co /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/pstack /main/VOB_TRANSFER/2
element -dir /cm4/fsn/app/pstack/nl /main/VOB_TRANSFER/2
element -dir /cm4/fsn/krnl/boot /main/1
element -dir /cm4/fsn/krnl/cpu/IXP2400 /main/1
element -dir /cm4/fsn/prj/esam/eblt-c /main/1
element -dir /cm4/tools/BELL/xml /main/2
element -dir /cm4/tools/Sun /main/1
element -dir /cm8/SWdel /main/90
element -dir /cm8/SWdel/oflmt /main/5
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2_PATCH1
element /cm4/tools/GHS/arm/... GHS_ARM_VXWORKS_V4.0.2
element /cm4/tools/GHS/arm/... GHS_ARM_MULTI2000_V4.0.2
element /cm4/tools/WRS/visionXD/... VISIONXD_3.6_PATCH1
element /cm4/tools/WRS/visionXD/... VISIONXD_3.6
element /cm4/tools/BELL/src/coff2lz77/coff2lz77.c /main/ASAM_R50_PQII_MMU/1
element /cm4/tools/BELL/src/coff2lz77/coff.h /main/ASAM_R50_PQII_MMU/1
element /cm4/tools/BELL/src/coff2lz77/coff2lz77 /main/ASAM_R50_PQII_MMU/1
element /cm4/tools/BELL/src/coff/coff.h /main/2
element /cm8/SWdel/oflmt/LYC9 /main/isam20_migration/LATEST
element /cm4/tools/BELL/src/dataMgnt/offLineTool/ASAM_CODE/... MOD_MIGSTUB_V1.0.5
element /cm4/tools/BELL/src/dataMgnt/offLineTool/version/... MOD_VERSION_V1.0.12
element /cm4/tools/BELL/src/dataMgnt/offLineTool/... MOD_MIGTOOL_V1.0.2
element /cm4/tools/BELL/src/oracle/... MOD_ORACLE_8.1.7_ANTWERP_V1.0.0
element -dir /cm8/auto/testcases ASAM_CORE_5.1.2.2
element -dir /cm8/auto/testcases/config_spec/... ASAM_TS_5.1.2.2
element * ESAM_SERVICEAPPLS_CPEMGNT_FTCPE_5.1.6.1
element * ESAM_SERVICEAPPLS_CPEMGNT_FTRELAY_5.1.6.1
element * ESAM_SERVICEAPPLS_CPEMGNT_FTCFG_5.1.6.1
element * ESAM_FT_5.1.6.1
element -dir /cm4/test /main/8
element -dir /cm4/test/baseline /main/7
element /cm4/test/baseline/isam_test_baseline.cs /main/6
element /cm4/test/asamScripts/qpthread/export/qp_timer.h /main/blr_lit_r50.10/1
element /cm4/test/asamScripts/Makefile /main/23
element /cm4/test/include/... LIT_INCLUDE_V0.0.4
element /cm4/test/lib/... LIT_LIB_V0.0.4
element /cm4/test/asamScripts/alarm/... ISAM_FDT1.1_ALM_V1.0.0
element /cm4/test/asamScripts/eqptMgnt/... ISAM_FDT1.1_EQPT_V1.0.5
element /cm4/test/asamScripts/itfm_lit/... ISAM_FDT1.1_ITF_V1.0.3
element /cm4/test/asamScripts/itfm/... ISAM_FDT1.1_ITFM_V1.0.0
element /cm4/test/asamScripts/om/... ISAM_FDT1.1_OM_V1.0.0
element /cm4/test/asamScripts/platform/tran/... ISAM_FDT1.1_TRAN_V1.0.0
element /cm4/test/asamScripts/platform/sntp/... ISAM_FDT1.1_SNTP_V1.0.1
element /cm4/test/asamScripts/platform/tftp/... ISAM_FDT1.1_TFTP_V1.0.0
element /cm4/test/asamScripts/platform/faup/... ISAM_FDT1.1_FAUP_V1.0.0
element /cm4/test/asamScripts/platform/persloss/... ISAM_FDT1.1_PELO_V1.0.1
element /cm4/test/asamScripts/platform/... ISAM_FDT1.1_PLATFORM_V1.0.1
element /cm4/test/asamScripts/SwMgnt/... ISAM_FDT1.1_SWM_V1.0.0
element /cm4/test/asamScripts/... ISAMSCRIPTS_FDT1.1_V1.0.1
element -dir /cm8/auto/testcases/Design /main/LATEST
element -dir /cm8/auto/testcases/Design/ESAM /main/LATEST
element /cm8/auto/testcases/Design/ESAM/MGMT/... ISAM_ARSSCRIPTS_FDT1.1_V1.0.6
element /cm4/tools/BELL/src/snmpTestScript/... MOD_SRC_SNMPTESTSCRIPT_V1.0.0
element /cm8/auto/tools/aries/GEN/SETUP/itf_desc.txt /main/13
element /cm8/auto/tools/aries/GEN/SETUP/IMPL/GEN_SETUP.tcl /main/95
element /cm8/auto/tools/... ARIES_5.1.2.2
element * ARIES_GEN_COM_5.1.5.12b
element * ARIES_GEN_SYSTEM_5.1.6.0
element * ARIES_GEN_SETUP_5.1.6.3
element * ARIES_GEN_CORE_5.1.6.4
element * OSCAR_5.1.6.4
element * TAPID_5.1.6.4
element * FREEWARE_TOOLS_2.0.0.0
element * ARIES_AX4000_MAXIP_WPR_5.1.7.1
element * ARIES_AX4000_ETH_5.1.6.4
element * ARIES_CPE_NE_5.1.6.4
element * ARIES_CPE_SYS_5.1.5.12
element * ARIES_GENERATORS_4.2.4.1
element * ARIES_STRUCT_5.1.6.4
element * ARIES_GEN_TD_5.1.5.12
element * ARIES_TOOLS_5.1.7.1
element * ARIES_TSE_5.1.5.0
element * ARIES_AX4000_ATM_5.1.6.2
element * PC_TA_1.0.0.14
element * ARIES_AX4000_GEN_5.1.6.2
element * ARIES_SMARTBITS_GEN_5.1.5.4
element * ARIES_SMARTBITS_ATM_5.1.5.7
element * ARIES_SMARTBITS_ETH_5.1.5.7
element /vobs/esam/configspecs/ESAM_R1.0.10_mainstream.cs /main/aaaa/8
element * ARIES_GEN_COM_5.1.5.12b
element * ARIES_GEN_SYSTEM_5.1.6.0
element * ARIES_GEN_SETUP_5.1.6.3
element * ARIES_GEN_CORE_5.1.6.4
element * OSCAR_5.1.6.4
element * TAPID_5.1.6.4
element * FREEWARE_TOOLS_2.0.0.0
element * ARIES_AX4000_ETH_5.1.6.4
element * ARIES_CPE_NE_5.1.6.4
element * ARIES_CPE_SYS_5.1.5.12
element * ARIES_GENERATORS_4.2.4.1
element * ARIES_STRUCT_5.1.6.4
element * ARIES_GEN_TD_5.1.5.12
element * ARIES_TSE_5.1.5.0
element * ARIES_AX4000_ATM_5.1.6.2
element * ARIES_AX4000_GEN_5.1.6.2
element * ARIES_SMARTBITS_GEN_5.1.5.4
element * ARIES_SMARTBITS_ATM_5.1.5.7
element * ARIES_SMARTBITS_ETH_5.1.5.7
element /cm4/fsn/app/asam/mta/... -none
element -dir /cm4/tools/ETCA /main/7
element -dir /cm4/fsn/app/asam /main/VOB_TRANSFER/asb_ESAM1.0/1
element /cm4/fsn/app/asam/licenseMgnt/... MOD_LICENSEMGR_V1.0.0
element /cm4/fsn/build/prj/asam/salt-c/OS/chipsim/rip.dat /main/ESAM_HDS_1.0/1
element /cm4/fsn/build/prj/asam/gant-c/OS/chipsim/rip.dat /main/ESAM_HDS_1.0/3
element -dir /cm4/fsn/hs/xdsl_proxy /main/4
element -dir /cm4/fsn/build/prj /main/15
element -dir /cm4/fsn/test/prj /main/20
element -dir /cm4/fsn/krnl/bsp/pq1 /main/2
element -dir /cm4/fsn/krnl/bsp/pq1/board /main/1
element -dir /cm4/fsn/krnl/cpu /main/3
element -dir /cm4/fsn/krnl/fs/board/co /main/1
element -dir /cm4/fsn/krnl/startup /main/8
element -dir /cm4/fsn/krnl/startup/co /main/1
element -dir /cm4/fsn/krnl/startup/co/OS /main/1
element -dir /cm4/fsn/prj /main/18
element -dir /cm4/fsn/prj/esam/eant-a /main/2
element -dir /cm4/fsn/prj/esam/ealt-a /main/2
element -dir /cm4/fsn/prj/co /main/VOB_TRANSFER/1
element -dir /cm4/fsn/build/prj/esam /main/3
element -dir /cm4/fsn/build/prj/esam/eant-a /main/5
element -dir /cm4/fsn/hs/rip/board /main/VOB_TRANSFER/1
element -dir /vobs/esam/configspecs/ESAM_1.0/... /main/LATEST
element -dir /vobs/esam/configspecs/ESAM_1.1/... /main/LATEST
element -dir /vobs/esam/configspecs/ESAM_1.0.10/... /main/LATEST
element /vobs/esam/configspecs/ESAM_1.0/... /main/aaaa/LATEST
element /vobs/esam/configspecs/ESAM_1.0.10/... /main/aaaa/LATEST
element /vobs/esam/pSOSun /main/2
element /cm4/fsn/app/asam/prodata/Makefile /main/temp_esam/1
element /cm4/fsn/app/asam/download/lt5/source/commit/Makefile /main/temp_esam/1
element /cm4/fsn/hs/lcom/... MOD_LCOM_AA_V1.0.3
element /cm4/fsn/hs/service_lib/asic/... MOD_ASIC_ESAM_AA_V1.0.0
element /cm4/fsn/krnl/cpu/M859/... MOD_KRNLCPU_M859_V1.0.4
element /cm4/fsn/krnl/startup/HOST/... MOD_STARTUP_HOST_V1.0.0
element /cm4/fsn/krnl/startup/co/OS/... MOD_STARTUP_CO_V1.0.1
element /cm4/fsn/krnl/startup/co/... MOD_STARTUP_CO_V1.0.1
element /cm4/fsn/krnl/prozone/... MOD_PROZONE_V1.4.0
element /cm4/fsn/krnl/fs/docs/... MOD_FSDOCS_V1.0.5
element /cm4/fsn/krnl/fs/board/co/devs/... MOD_FSDEVS_V4.0.3
element /cm4/fsn/krnl/fs/fsapi++/... MOD_FSAPIPP_V1.0.9
element /cm4/fsn/krnl/fs/lz77/... MOD_FSLZ77_V2.0.2
element /vobs/esam/build/ealt-a /main/11
element /vobs/esam/build/eant-a /main/7
element -dir /vobs/esam/objects/eant-a /main/0
element -dir /vobs/esam/objects/ealt-a /main/0
element /cm4/fsn/krnl/fs/board/salt-c/export/target.h /main/orv_main/ESAM_R1.0/1
element /cm4/fsn/krnl/bsp/board/salt-c/export/bspcfg.h /main/orv_main/ESAM_R1.0/1
element -dir /cm4/fsn/app/asam/itfm /main/VOB_TRANSFER/2
element -dir /cm4/fsn/app /main/VOB_TRANSFER/2
element -dir /cm4/fsn/app/pstack/sl /main/VOB_TRANSFER/2
element -dir /cm4/fsn/app/asam/eqptDomain/infraMgnt /main/VOB_TRANSFER/4
element -dir /cm4/fsn/hs /main/VOB_TRANSFER/7
element -dir /cm4/fsn/app/asam/eqptDomain/eqptCtrl /main/VOB_TRANSFER/4
element -dir /cm4/fsn/lib /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/asam/eqptDomain/eqptMgntCore /main/VOB_TRANSFER/1
element -dir /cm4/fsn/platform/ObjectServices /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/asam/init /main/VOB_TRANSFER/2
element -dir /cm4/fsn/app/asam/eqptDomain /main/VOB_TRANSFER/3
element -dir /cm4/fsn/app/asam/tables /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/asam/download /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/asam/common /main/VOB_TRANSFER/2
element -dir /cm4/fsn/hs/rip /main/VOB_TRANSFER/1
element -dir /cm4/fsn/krnl/bsp/pq2 /main/VOB_TRANSFER/1
element -dir /cm4/fsn/app/asam/ethernet /main/VOB_TRANSFER/1
element -dir /vobs/dsl/sw /main/1
element -dir /vobs/dsl/sw/include/board/ealt-a /main/3
element -dir /vobs/dsl/sw/include/board/ealt-b /main/1
element -dir /vobs/dsl/sw/include/board/eant-a /main/1
element -dir /vobs/dsl/sw/include/board/eant-b /main/1
element -dir /vobs/dsl/sw/include/board/salt-c /main/1
element /vobs/dsl/source08/IGMPHandler/... -error
element /cm4/fsn/prj/asam/gant-c/... -error
element /cm4/fsn/app/asam/init/lt/... -error
element /cm4/fsn/test/prj/asam/gant-c/baselineDummy/... -error
element /cm4/fsn/prj/asam/salt-c/init/pltf_app_init.cpp ESAM_CHANGES_V0.0.1
element /cm4/fsn/build/prj/asam/salt-c/OS/Makefile ESAM_CHANGES_V0.0.1
element -dir /cm4/fsn/build/prj/asam/gant-c /main/11
element -dir /cm4/fsn/test/prj/asam/gant-c /main/1
element /cm4/fsn/build/prj/asam/gant-c/OS/chipsim/... CFG_CHIPSIM_GANT-C_V1.0.2
element /cm4/fsn/build/prj/asam/gant-c/OS/... MOD_BLD_ASAM-GANT-C_V5.0.1.1.8
element -dir /cm4/fsn/app/asam/uas -error
element /cm4/fsn/build/prj/asam/gant-c/lca/... MOD_BLD_LCA_GANT-C_V5.0.0.5
element /cm4/fsn/... MOD_DIRS_V5.0.15
element /cm4/modem/... MOD_DIRS_V4.2.0
element /cm4/fsn/build/prj/asam/salt-c/OS/chipsim/... CFG_CHIPSIM_SALT-C_V1.0.0
element /cm4/fsn/build/prj/asam/salt-c/OS/... MOD_BLD_ASAM-SALT-C_V5.0.1.0.2
element -dir /cm4/fsn/build/prj/asam/salt-c /main/orv_main/4
element /cm4/fsn/prj/asam/salt-c/init/... MOD_INIT_ASAM_SALT-C_V5.0.13
element /cm4/fsn/prj/asam/salt-c/OS/... MOD_OCFG_ASAM_SALT-C_V1.0.1
element /cm4/fsn/prj/asam/salt-c/export/... MOD_ECFG_ASAM_SALT-C_V1.0.9
element /cm4/fsn/prj/asam/salt-c/krnlcfg/... MOD_KCFG_ASAM_SALT-C_V5.0.10
element /cm4/fsn/app/asam/adsl/common/... -error
element /cm4/fsn/app/asam/adsl/nt/... -error
element /cm4/fsn/app/asam/applicationServices/... MOD_APPLIC_SERVICES_V1.0.1
element /cm4/fsn/app/asam/aps/... -error
element /cm4/fsn/app/asam/atm2/common/... -error
element /cm4/fsn/app/asam/atm2/export/... -error
element /cm4/fsn/app/asam/atm2/nt/... -error
element /cm4/fsn/app/asam/atm2/lt/... -error
element /cm4/fsn/app/asam/boardMemMgnt/... MOD_BOARDMEMMGNT_V1.1.1
element /cm4/fsn/app/asam/common/NewDelOvl/... MOD_ASAM_NEWDELOVL_V1.0.0
element /cm4/fsn/app/asam/download/lt5/... MOD_ASAMEXTLSM-BOOT_V5.0.20
element /cm4/fsn/app/asam/eqptDomain/eqptCtrl/shelf/... MOD_EQPTCTRL_XT_V1.0.15
element /cm4/fsn/app/asam/eqptDomain/eqptCtrl/... MOD_EQPTCTRL_V1.3.17
element /cm4/fsn/app/asam/eqptDomain/eqptMgntCore/lsm/... MOD_EQPTCORE-LSM_V1.0.0
element /cm4/fsn/app/asam/eqptDomain/redcyLite/... -error
element /cm4/fsn/app/asam/eqptDomain/... MOD_EQPTDOMAIN_V1.0.9
element /cm4/fsn/app/asam/error/... MOD_ASAM_ERROR_V1.1.8
element /cm4/fsn/app/asam/fac1/... -error
element /cm4/fsn/app/asam/fac3/... -error
element /cm4/fsn/app/asam/golden/... -error
element /cm4/fsn/app/asam/igmp/... -error
element /cm4/fsn/app/asam/ilmi2/export/... -error
element /cm4/fsn/app/asam/ima/... -error
element /cm4/fsn/app/asam/prodata/board/adse-c/... MOD_ASAMPRODATA_ADSE-C_V1.0.5
element /cm4/fsn/app/asam/prodata/... MOD_ASAMPRODATA_V1.2.4
element /cm4/fsn/app/asam/ipgw/... -error
element /cm4/fsn/app/asam/itfm/common/... MOD_INTERFACES_COMMON_V1.0.1
element /cm4/fsn/app/asam/mcast/... -error
element /cm4/fsn/app/asam/migrator/... MOD_ASAM_MIGR_V1.0.17
element /cm4/fsn/app/asam/osba/... MOD_OSBA_V3.0.0
element /cm4/fsn/app/asam/psTransport/... -error
element /cm4/fsn/app/asam/redcy/... -error
element /cm4/fsn/app/asam/shdsl/any_nt/... -error
element /cm4/fsn/app/asam/shdsl/common/... -error
element /cm4/fsn/app/asam/shdsl/headers/... -error
element /cm4/fsn/app/asam/sonet2/... -error
element /cm4/fsn/app/asam/stable_mib/... MOD_STMIB_V0.0.10
element /cm4/fsn/app/asam/svc/caco/... -error
element /cm4/fsn/app/asam/svc/common/... -error
element /cm4/fsn/app/asam/svc/include/... -error
element /cm4/fsn/app/asam/svc/mapper/... -error
element /cm4/fsn/app/asam/svc/mgmt/... -error
element /cm4/fsn/app/asam/svc/saal/... -error
element /cm4/fsn/app/asam/svc/signaling/... -error
element /cm4/fsn/app/asam/synchronizer/... -error
element -dir /cm4/fsn/app/asam/systemDataMgnt MOD_SYSDATMGR_V1.0.0
element /cm4/fsn/app/asam/tables/bitmap/... MOD_BITMAPTABLE_V1.1.8
element /cm4/fsn/app/asam/tl1_relay/... -error
element /cm4/fsn/app/asam/transport/... -error
element /cm4/fsn/app/pstack/co/... MOD_PSTACK_V1.0.0
element /cm4/fsn/app/pstack/lib/vbuf/... MOD_VBLIB_V1.0.13
element /cm4/fsn/app/pstack/nl/adpt/... MOD_NLADPT_V1.0.9
element /cm4/fsn/app/pstack/nl/atm/... -error
element /cm4/fsn/app/pstack/sl/igmp/... -error
element /cm4/fsn/app/servers/bootpc/... MOD_BOOTPC_V1.4.11
element /cm4/fsn/app/servers/debug/... MOD_UDPSRV_V1.3.1
element /cm4/fsn/app/servers/sntp/co/... MOD_SNTP-COMMON_V1.1.0
element /cm4/fsn/app/snmp/party/... MOD_SNMPPARTY_V1.0.1
element /cm4/fsn/app/snmp/rfc/... MOD_RFCMIBS_V1.2.2
element /cm4/fsn/hs/CAM/... MOD_CAM_V1.1.2
element /cm4/fsn/hs/IndexMgr/... MOD_INDEXMGR_V1.0.2
element /cm4/fsn/hs/MmcLibs/export/... MOD_MMCLIBS_EXPORT_V1.0.1
element /cm4/fsn/hs/MmcLibs/BOARD_IS/... MOD_MMCLIBS_BOARD_IS_V1.0.1
element /cm4/fsn/hs/MmcLibs/BOARD_IS_asam/... MOD_MMCLIBS_BOARD_IS_ASAM_V1.0.1
element /cm4/fsn/hs/MmcLibs/CLIB/... MOD_MMCLIBS_CLIB_V1.0.4
element /cm4/fsn/hs/MmcLibs/DELAY/... MOD_MMCLIBS_DELAY_V1.0.1
element /cm4/fsn/hs/MmcLibs/DELAY_asam/... MOD_MMCLIBS_DELAY_ASAM_V1.0.1
element /cm4/fsn/hs/MmcLibs/MMCE_errhndler/... MOD_MMCLIBS_ERRHNDLER_V1.0.1
element /cm4/fsn/hs/MmcLibs/MMCU/... MOD_MMCLIBS_MMCU_V1.0.3
element /cm4/fsn/hs/MmcLibs/OS/... MOD_MMCLIBS_OS_V1.0.1
element /cm4/fsn/hs/MmcLibs/OS_xapi/... MOD_MMCLIBS_OSXAPI_V1.0.3
element /cm4/fsn/hs/asics/htim/... MOD_HTIM_V5.0.3.5
element /cm4/fsn/hs/asics/... MOD_ASICS_HDS_V1.0.38
element /cm4/fsn/hs/hdlc/... MOD_LL_HDLC_V5.0.2.5
element /cm4/fsn/hs/icon/... -error
element /cm4/fsn/hs/itf/CAM/... MOD_HS_ITF_CAM_V1.0.0
element /cm4/fsn/hs/itf/adsl/... MOD_ADSLDEF_V1.3.0
element /cm4/fsn/hs/itf/comm_wrapper/... MOD_HS_ITF_COMMW_V1.0.1
element -dir /cm4/fsn/hs/itf MOD_ITF_V1.0.0
element /cm4/fsn/hs/itf/common/... MOD_HS_ITF_COMMON_V1.0.2
element /cm4/fsn/hs/logswitch/... -error
element /cm4/fsn/hs/mmc2/... -error
element /cm4/fsn/hs/np_ucode/... -error
element /cm4/fsn/hs/np/... -error
element /cm4/fsn/hs/regaccess/... MOD_GRM_V1.1.0
element /cm4/fsn/hs/rip/board/cokim/... MOD_RIP_BOARD_COKIM_V1.0.2
element /cm4/fsn/hs/sdh_hds/... -error
element /cm4/fsn/hs/service_lib/JobScheduler/... MOD_JOBSCHEDULER_V1.0.2
element /cm4/fsn/hs/service_lib/lists/... MOD_LISTS_HDS_V1.0.7
element /cm4/fsn/hs/service_lib/lock/... MOD_LOCK_V1.0.2
element /cm4/fsn/hs/service_lib/traceDebug/... MOD_TRACE_DEBUG_V1.0.8
element /cm4/fsn/hs/service_lib/... MOD_SERVICE_LIB_V1.0.4
element /cm4/fsn/hs/uiac/... -error
element /cm4/fsn/krnl/RTEMS/pSOSapi/... MOD_RTEMS_PSOSAPI_V2.4.7
element /cm4/fsn/krnl/bob/... MOD_BOB_V1.0.3
element /cm4/fsn/krnl/bsp/board/co/... MOD_BSP_BOARD_CO_V1.0.2
element /cm4/fsn/krnl/bsp/board/gant-c/... MOD_BSP_GANT-C_V2.1.1
element /cm4/fsn/krnl/bsp/board/salt-c/... MOD_BSP_SALT-C_V5.1.3
element /cm4/fsn/krnl/bsp/dev/i960/... MOD_BSP_DEV_I960_V1.0.1
element /cm4/fsn/krnl/cpu/HOST/... MOD_KRNLCPU_HOST_V1.3.0
element /cm4/fsn/krnl/cpu/export/... MOD_KRNLCPU_EXPORT_V1.3.0
element /cm4/fsn/krnl/cpuload/... MOD_CPULOAD_V1.2.1
element /cm4/fsn/krnl/fs/board/gant-c/... MOD_FSBOARD_GANT-C_V2.0.3
element /cm4/fsn/krnl/fs/board/salt-c/... MOD_FSBOARD_SALT-C_V5.0.9
element /cm4/fsn/krnl/init/modargs/... MOD_KRNLINIT_MODARGS_V1.1.1
element /cm4/fsn/lib/getopt/... MOD_LIBGETOPT_V1.0.1
element /cm4/fsn/lib/writepid/... MOD_LIB_WRITEPID_V1.0.1
element /cm4/fsn/test/krnl/eh/... MOD_EHTEST_V1.2.1
element /cm4/fsn/test/krnl/stubs/... MOD_TEST_KRNL_STUBS_V0.0.5
element /cm4/fsn/test/krnl/tcfwk/... MOD_TCFWK_V1.1.0
element /cm4/fsn/test/krnl/xapi/notepad/... MOD_NOTEPAD_TEST_V1.0.1
element /cm4/fsn/test/krnl/xapi/loadApp/...		       MOD_LDAPP_AA_V1.0.0
element /cm4/fsn/build/prj/asam/co/... MOD_BLD_ASAM-CO_V5.0.0.7.9
element /cm4/tools/GNU/src/gdb/... gdb_4.17
element -dir /cm4/tools/ISI/... MOD_DIRS_V4.2.0
element -dir /cm4/tools/MRI/... MOD_DIRS_V4.2.0
element /cm4/tools/BELL/lib/... MOD_BELL_LIB_V1.0.0
element /cm4/tools/BELL/src/bin2ddl/... MOD_BIN2DDL_V5.0.1
element /cm4/tools/BELL/src/bin2lz77/... MOD_BIN2LZ77_V1.0.0
element /cm4/tools/BELL/src/buildTypeALt/... MOD_BUILDTYPEALT_V5.0.3
element /cm4/tools/BELL/src/coff/... MOD_COFF_V1.0.5
element /cm4/tools/BELL/src/coff2lz77/... MOD_COFF2LZ77_V1.0.3
element /cm4/tools/BELL/src/coff_ddl/... MOD_COFF2DDL_V1.0.2
element /cm4/tools/BELL/src/fpga/... MOD_FPGABLD_V5.0.1
element /cm4/tools/BELL/src/genInitFies/... MOD_GENINITFIES_V1.0.0
element /cm4/tools/BELL/src/writeCF/... MOD_WRITECF_V1.1.1
element /cm4/tools/BELL/build/... MOD_BUILDTOOLS_V1.3.8
element /cm4/tools/BELL/src/swHdr/... MOD_SWHDR_V1.0.0
element /cm4/tools/BELL/bin4/... MOD_BELLBIN_V1.4.2
element /cm4/tools/BELL/bin2/... MOD_BELLBIN_V1.5.11
element /cm4/tools/BELL/win32/... MOD_COMPUTER_RES_MNGT_V1.0.0
element /cm4/tools/ANS/bin5/get_dbgenable MOD_DBGENABLE_V1.0.0
element /cm4/tools/GNU/bin4/... MOD_GNUBIN_V2.0.0
element /cm4/tools/GNU/doxygen/... MOD_GNUDOXYGEN_V1.0.2
element /cm4/tools/GNU/java/... MOD_SUNJAVA_V1.2.0
element /cm4/tools/GNU/lib4/... MOD_GNULIB_V2.0.0
element /cm4/tools/GNU/rsm/... MOD_RSM_V6.01.1
element /cm4/tools/GNU/src/autoconf/... AUTOCONF-2.13
element /cm4/tools/GNU/src/ddd/... DDD-3.3
element /cm4/tools/GNU/src/gperf/... GPERF-2.7.2
element /cm4/tools/GNU/src/rtems/c/... MOD_LIBRTEMS_V2.3.0
element /cm4/tools/GNU/src/... MOD_GNUSRC_V2.0.0
element /cm4/tools/ISI/pSOS/... ISI_PSOS_2.2.1_BE_patch19970313_BELL.3
element /cm4/tools/ISI/pSOS/... ISI_PSOS_2.2.1_BE
element /cm4/tools/GHS/ghs_960/... GHS_I960_MULTI2000_V3.0_PATCH_2
element /cm4/tools/GHS/ghs_960/... GHS_I960_MULTI2000_V3.0_INSTALLED
element /cm4/tools/WRS/... MOD_DIRS_V5.0.0
element /cm4/tools/WRS/visionICE/... VISIONICE_V1.0.0
element /cm4/tools/WRS/tornado/... TORNADO_V2.0_1
element -file * /main/0 -mkbranch aaaa
element * -error
#---- leaving  0 /vobs/esam/configspecs/ISAM_mainstream.cs@@/main/aaaa/isr33/isr3301/18

##########################################################
# default

element * -error
