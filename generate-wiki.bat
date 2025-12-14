@echo off
REM API Index Generator - Generate Script
REM Generates documentation and API index

set DOCGEN_OUTPUT=%~dp0input
set API_OUTPUT=%~dp0docs/spaceengineers/pbapi

echo Step 1: Generating documentation with DocGen...
echo Output: %DOCGEN_OUTPUT%
echo.

"%~dp0bin\DocGen\docgen.exe" api,terminals,sprites,types,json --output "%DOCGEN_OUTPUT%"

if %ERRORLEVEL% NEQ 0 (
    echo.
    echo DocGen failed!
    exit /b 1
)

echo.
echo Step 2: Generating API Index...
echo Input:  %DOCGEN_OUTPUT%
echo Output: %API_OUTPUT%
echo.

"%~dp0bin\MdkApiGen.exe" --input "%DOCGEN_OUTPUT%" --output "%API_OUTPUT%"

if %ERRORLEVEL% EQU 0 (
    echo.
    echo ========================================
    echo API index generated successfully!
    echo ========================================
    echo.
    echo Output location: %API_OUTPUT%
    echo.
    echo To view the API tree, open: %API_OUTPUT%\index.html
    echo.
) else (
    echo.
    echo Generation failed!
    exit /b 1
)
