:: This script will install Choco via PowerShell.

:: Requirements:
:: - PowerShell is installed and enabled on your Windows machine.

@ECHO OFF

:: Install Choco via PowerShell
powershell -NoProfile -ExecutionPolicy unrestricted -Command "Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))"

EXIT /B 0