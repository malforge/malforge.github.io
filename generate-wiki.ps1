# API Index Generator - Generate Script
# Generates documentation and API index for both PB and Mod APIs

param(
    # Use the game data already in the repository instead of fetching the current published data first.
    [switch] $SkipDataUpdate
)

$pbDocgenOutput = "$PSScriptRoot\input\pb"
$modDocgenOutput = "$PSScriptRoot\input\mod"
$mdkDocsInput = "$PSScriptRoot\input\mdk2"
$pbApiOutput = "$PSScriptRoot\docs\spaceengineers\pbapi"
$modApiOutput = "$PSScriptRoot\docs\spaceengineers\modapi"
$mdkDocsOutput = "$PSScriptRoot\docs\spaceengineers\mdk2"

# Passed to DocGen explicitly rather than relying on it finding them in the current directory, so this script
# works from anywhere.
$pbWhitelist = "$PSScriptRoot\pbwhitelist.dat"
$modWhitelist = "$PSScriptRoot\modwhitelist.dat"
$terminals = "$PSScriptRoot\terminal.dat"

if (-not $SkipDataUpdate) {
    Write-Host "Step 0: Updating game data..." -ForegroundColor Cyan
    Write-Host ""

    & "$PSScriptRoot\update-gamedata.ps1"

    if ($LASTEXITCODE -ne 0) {
        Write-Host ""
        Write-Host "Game data update failed!" -ForegroundColor Red
        exit 1
    }
    Write-Host ""
}

Write-Host "Step 1: Generating PB API documentation with DocGen..." -ForegroundColor Cyan
Write-Host "Whitelist: $pbWhitelist" -ForegroundColor Gray
Write-Host "Output:    $pbDocgenOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\DocGen\docgen.exe" api,terminals,sprites,types,json --whitelist $pbWhitelist --terminal $terminals --output $pbDocgenOutput

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "PB API DocGen failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 2: Generating Mod API documentation with DocGen..." -ForegroundColor Cyan
Write-Host "Whitelist: $modWhitelist" -ForegroundColor Gray
Write-Host "Output:    $modDocgenOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\DocGen\docgen.exe" api,types,json --whitelist $modWhitelist --terminal $terminals --output $modDocgenOutput

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

& "$PSScriptRoot\bin\MdkApiGen.exe" --input $pbDocgenOutput --output $pbApiOutput --index-file "_pb-index.md" --api-type "pb"

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

& "$PSScriptRoot\bin\MdkApiGen.exe" --input $modDocgenOutput --output $modApiOutput --index-file "_mod-index.md" --api-type "mod"

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "Mod API Index generation failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 5: Generating MDK2 Documentation..." -ForegroundColor Cyan
Write-Host "Input:  $mdkDocsInput" -ForegroundColor Gray
Write-Host "Output: $mdkDocsOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\MdkApiGen.exe" --docs --input $mdkDocsInput --output $mdkDocsOutput --title "MDK2 Documentation"

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Green
    Write-Host "API documentation generated successfully!" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Green
    Write-Host ""
    Write-Host "PB API:   $pbApiOutput\index.html" -ForegroundColor Yellow
    Write-Host "Mod API:  $modApiOutput\index.html" -ForegroundColor Yellow
    Write-Host "MDK2 Docs: $mdkDocsOutput\index.html" -ForegroundColor Yellow
    Write-Host ""
} else {
    Write-Host ""
    Write-Host "MDK2 documentation generation failed!" -ForegroundColor Red
    exit 1
}
