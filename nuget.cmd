pushd %~dp0
@echo.
@echo ====Building ModernUI.Charts.UWP =====
@msbuild D:\ModernUIChart\ModernUI.Charts.UWP\ModernUI.Charts.UWP.csproj /p:Configuration="Release" /p:Platform="x86"
@echo.
@msbuild  D:\ModernUIChart\ModernUI.Charts.UWP\ModernUI.Charts.UWP.csproj /p:Configuration="Release" /p:Platform="x64"
@echo.
@msbuild  D:\ModernUIChart\ModernUI.Charts.UWP\ModernUI.Charts.UWP.csproj /p:Configuration="Release" /p:Platform="ARM"
@echo.
@msbuild  D:\ModernUIChart\ModernUI.Charts.UWP\ModernUI.Charts.UWP.csproj /p:Configuration="Release" /p:Platform="AnyCPU"
@echo.

@echo === Updating files ====

ROBOCOPY D:\ModernUIChart\ModernUI.Charts.UWP\bin\x86\Release D:\ModernUIChart\Nuget\runtimes\win10-x86\lib\uap10.0 * /E
ROBOCOPY D:\ModernUIChart\ModernUI.Charts.UWP\bin\x64\Release D:\ModernUIChart\Nuget\runtimes\win10-x64\lib\uap10.0 * /E
ROBOCOPY D:\ModernUIChart\ModernUI.Charts.UWP\bin\ARM\Release D:\ModernUIChart\Nuget\runtimes\win10-ARM\lib\uap10.0 * /E
ROBOCOPY D:\ModernUIChart\ModernUI.Charts.UWP\bin\Release D:\ModernUIChart\Nuget\ref\uap10.0 * /E


@echo === Creating Nuget Package ====

@ D:\nuget.exe pack Nuget\package.nuspec

@echo.

@echo off
setlocal
:PROMPT
SET /P AREYOUSURE= do you want to push the package to Nuget?(Y/[N])?
IF /I "%AREYOUSURE%" NEQ "Y" GOTO END

SET ApiKey=

SET /P  ApiKey= Enter the Api Key
@echo.


@ D:\nuget.exe push ModernUI.Charts.UWP.1.0.1.nupkg %ApiKey% -Source https://api.nuget.org/v3/index.json

:END
endlocal

