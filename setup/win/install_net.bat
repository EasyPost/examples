:: This script will:
:: 	- use Microsoft's PowerShell script (https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script) to install the latest version of all required .NET SDKs.
::	- install required third-party tools for running these scripts
::	- add files to the current user's PATH environment variable

:: Requirements:
:: - PowerShell is enabled on the machine
:: - Do not install dotnet via any other method (including via installing Visual Studio/Rider). This might otherwise cause two conflicting versions of 'dotnet' to exist in your PATH

@ECHO OFF

:: .NET versions we want to install and destination
SET NetVersions=Current 6.0 5.0 3.1
SET InstallPath=C:\dotnet

:: .NET dependencies and tools we want to install
SET DepNames=Nuget

:: Install each .NET version
@ECHO Installing .NET SDKs ...
SETLOCAL
    for %%x IN (%NetVersions%) DO (
        @ECHO Installing .NET %%x ...
        powershell -NoProfile -ExecutionPolicy unrestricted -Command "[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; &([scriptblock]::Create((Invoke-WebRequest -UseBasicParsing 'https://dot.net/v1/dotnet-install.ps1'))) -InstallDir %InstallPath% -Channel %%x -Verbose"
    )
ENDLOCAL

:: Download dependencies and tools
@ECHO Downloading third-party tools ...
SETLOCAL
    for %%x IN (%DepNames%) DO (
        @ECHO Downloading %%x ...
        powershell -NoProfile -ExecutionPolicy unrestricted -Command "Find-PackageProvider -Name '%%x' | Install-PackageProvider -Verbose -Force -Scope CurrentUser"
    )
ENDLOCAL

:: Add dotnet folder to PATH
powershell -NoProfile -ExecutionPolicy unrestricted -Command "[Environment]::SetEnvironmentVariable('Path', $env:Path + ';%InstallPath%', 'User')"


EXIT /B 0