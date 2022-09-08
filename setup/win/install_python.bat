:: This script will install/upgrade Python via Choco.

:: Requirements:
:: - Choco is installed and enabled on your Windows machine.

@ECHO OFF

:: Re-run script with elevated privileges (needed for Choco installs)
set "params=%*"
cd /d "%~dp0" && ( if exist "%temp%\getadmin.vbs" del "%temp%\getadmin.vbs" ) && fsutil dirty query %systemdrive% 1>nul 2>nul || (  echo Set UAC = CreateObject^("Shell.Application"^) : UAC.ShellExecute "cmd.exe", "/k cd ""%~sdp0"" && %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs" && "%temp%\getadmin.vbs" && exit /B )

:: Install/upgrade Python via Choco
choco install python -y
choco upgrade python -y

:: Install global Python modules
:: Install pip
python -m ensurepip --upgrade

EXIT /B 0