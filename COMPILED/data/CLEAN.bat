@echo off
echo Cleaning...
rm banner.bin >nul 2>nul
rm icon.bin >nul 2>nul
rm banner.bnr >nul 2>nul
rm icon.icn >nul 2>nul
%~dp0\otherfiles\clean.vbs