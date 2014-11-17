@echo off
%~dp0\otherfiles\1.vbs

cd %~dp0\ctpk_48x48icon\
call convert.bat
cd %~dp0
cd %~dp0\ctpk_24x24icon\
call convert.bat
cd %~dp0


%~dp0\otherfiles\2.vbs

cd %~dp0\cbmd_bannerImage\
call convert.bat
cd %~dp0


%~dp0\otherfiles\3.vbs

if exist banner.bin rm banner.bin (
if exist icon.bin rm icon.bin (
if exist banner.bnr rm banner.bnr (
if exist icon.icn rm icon.icn (

_buildscript.py

%~dp0\otherfiles\4.vbs

rename *.bnr *.bin
rename *.icn *.bin

echo Done.

%~dp0\otherfiles\5.vbs