@echo off
cd %~dp0\ctpk_48x48icon\
call convert.bat
cd %~dp0
cd %~dp0\ctpk_24x24icon\
call convert.bat
cd %~dp0
cd %~dp0\cbmd_bannerImage\
call convert.bat
cd %~dp0

_buildscript.py

echo Done.