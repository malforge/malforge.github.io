# API Index Generator - Build Script
# Builds the API index generator and DocGen

Write-Host "Building API Index Generator..." -ForegroundColor Cyan
Set-Location "$PSScriptRoot\Source\MdkApiGen"
dotnet publish -c Release -o "$PSScriptRoot\bin" --self-contained false /p:PublishSingleFile=true

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "API Index Generator build failed!" -ForegroundColor Red
    exit 1
}

Write-Host "Copying CSS, JS, HTML template, and image files..." -ForegroundColor Cyan
Copy-Item "$PSScriptRoot\Source\MdkApiGen\styles.css" "$PSScriptRoot\bin\styles.css" -Force
Copy-Item "$PSScriptRoot\Source\MdkApiGen\api-index.js" "$PSScriptRoot\bin\api-index.js" -Force
Copy-Item "$PSScriptRoot\Source\MdkApiGen\page-template.html" "$PSScriptRoot\bin\page-template.html" -Force
Copy-Item "$PSScriptRoot\Source\MdkApiGen\*.png" "$PSScriptRoot\bin\" -Force -ErrorAction SilentlyContinue

Write-Host ""
Write-Host "Building DocGen..." -ForegroundColor Cyan
Set-Location "$PSScriptRoot\Source\DocGen"
dotnet publish -c Release -o "$PSScriptRoot\bin\DocGen" --self-contained false

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "Build successful!" -ForegroundColor Green
    Write-Host ""
    Write-Host "To generate the API index, run:" -ForegroundColor Yellow
    Write-Host "  .\generate-wiki.ps1" -ForegroundColor White
    Write-Host ""
} else {
    Write-Host ""
    Write-Host "DocGen build failed!" -ForegroundColor Red
    exit 1
}
