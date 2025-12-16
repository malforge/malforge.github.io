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

# Note: CSS, JS, HTML templates, and images are copied automatically by dotnet publish
# with PreserveNewest behavior (only copies if source is newer than destination)
# See Source/MdkApiGen/MdkApiGen.csproj for configuration

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
