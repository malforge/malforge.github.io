# API Index Generator - Generate Script
# Generates documentation and API index

$docgenOutput = "$PSScriptRoot\input"
$apiOutput = "$PSScriptRoot\docs\spaceengineers\pbapi"

Write-Host "Step 1: Generating documentation with DocGen..." -ForegroundColor Cyan
Write-Host "Output: $docgenOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\DocGen\docgen.exe" api,terminals,sprites,types,json --output $docgenOutput

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "DocGen failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Step 2: Generating API Index..." -ForegroundColor Cyan
Write-Host "Input:  $docgenOutput" -ForegroundColor Gray
Write-Host "Output: $apiOutput" -ForegroundColor Gray
Write-Host ""

& "$PSScriptRoot\bin\MdkApiGen.exe" --input $docgenOutput --output $apiOutput

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Green
    Write-Host "API index generated successfully!" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Green
    Write-Host ""
    Write-Host "Output location: $apiOutput" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "To view the API tree, open: $apiOutput\index.html" -ForegroundColor Yellow
    Write-Host ""
} else {
    Write-Host ""
    Write-Host "Generation failed!" -ForegroundColor Red
    exit 1
}
