@echo off
REM API Index Generator - Build Script
REM Builds the API index generator and DocGen

echo Building API Index Generator...
cd /d "%~dp0Source\MdkApiGen"
dotnet publish -c Release -o "%~dp0bin" --self-contained false /p:PublishSingleFile=true

if %ERRORLEVEL% NEQ 0 (
    echo.
    echo API Index Generator build failed!
    exit /b 1
)

echo Copying CSS and JS files...
copy /Y "%~dp0Source\MdkApiGen\styles.css" "%~dp0bin\styles.css"
copy /Y "%~dp0Source\MdkApiGen\api-index.js" "%~dp0bin\api-index.js"

echo.
echo Building DocGen...
cd /d "%~dp0Source\DocGen"
dotnet publish -c Release -o "%~dp0bin\DocGen" --self-contained false

if %ERRORLEVEL% EQU 0 (
    echo.
    echo Build successful!
    echo.
    echo To generate the API index, run:
    echo   generate-wiki.bat
    echo.
) else (
    echo.
    echo DocGen build failed!
    exit /b 1
)
