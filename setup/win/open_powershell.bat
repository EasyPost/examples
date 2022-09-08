:: This script will open PowerShell with elevated privileges.

:: Requirements:
:: - powershell is installed and enabled on your Windows machine.

@ECHO OFF

PowerShell Start-Process PowerShell -Verb RunAs

EXIT /B 0