# API Index Generator - Generate Script
# Generates documentation and API index for both PB and Mod APIs

$pbDocgenOutput = "$PSScriptRoot\input\pb"
$modDocgenOutput = "$PSScriptRoot\input\mod"
$pbApiOutput = "$PSScriptRoot\docs\spaceengineers\pbapi"
$modApiOutput = "$PSScriptRoot\docs\spaceengineers\modapi"

Write-Host "Step 1: Generating PB API documentation with DocGen..." -ForegroundColor Cyan
Write-Host "Whitelist: pbwhitelist.dat" -ForegroundColor Gray
Write-Host "Output:    $pbDocgenOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\DocGen\docgen.exe" api,terminals,sprites,types,json --whitelist pbwhitelist.dat --output $pbDocgenOutput

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "PB API DocGen failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 2: Generating Mod API documentation with DocGen..." -ForegroundColor Cyan
Write-Host "Whitelist: modwhitelist.dat" -ForegroundColor Gray
Write-Host "Output:    $modDocgenOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\DocGen\docgen.exe" api,types,json --whitelist modwhitelist.dat --output $modDocgenOutput

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "Mod API DocGen failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 3: Generating PB API Index..." -ForegroundColor Cyan
Write-Host "Input:  $pbDocgenOutput" -ForegroundColor Gray
Write-Host "Output: $pbApiOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\MdkApiGen.exe" --input $pbDocgenOutput --output $pbApiOutput

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "PB API Index generation failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 4: Generating Mod API Index..." -ForegroundColor Cyan
Write-Host "Input:  $modDocgenOutput" -ForegroundColor Gray
Write-Host "Output: $modApiOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\MdkApiGen.exe" --input $modDocgenOutput --output $modApiOutput

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Green
    Write-Host "API documentation generated successfully!" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Green
    Write-Host ""
    Write-Host "PB API:  $pbApiOutput\index.html" -ForegroundColor Yellow
    Write-Host "Mod API: $modApiOutput\index.html" -ForegroundColor Yellow
    Write-Host ""
} else {
    Write-Host ""
    Write-Host "Mod API Index generation failed!" -ForegroundColor Red
    exit 1
}
