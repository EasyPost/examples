:: This script will install all required programming languages for a DevEx developer on Windows.

:: Requirements
:: - Run install_choco.bat first (or have Choco already installed)

:: Re-run script with elevated privileges
set "params=%*"
cd /d "%~dp0" && ( if exist "%temp%\getadmin.vbs" del "%temp%\getadmin.vbs" ) && fsutil dirty query %systemdrive% 1>nul 2>nul || (  echo Set UAC = CreateObject^("Shell.Application"^) : UAC.ShellExecute "cmd.exe", "/k cd ""%~sdp0"" && %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs" && "%temp%\getadmin.vbs" && exit /B )

:: Install Choco first
CALL "install_choco.bat"

:: Require Choco
CALL "install_python.bat"
CALL "install_ruby.bat"
CALL "install_php.bat"
CALL "install_node.bat"
CALL "install_go.bat"
CALL "install_java.bat"

:: Separate process for .NET installs
CALL "install_net.bat"

ECHO:
ECHO Installation complete. You may close this window.

EXIT /B 0