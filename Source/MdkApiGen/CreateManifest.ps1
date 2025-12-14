# Script to create .mdkapigen manifest from existing www folder contents
param(
    [string]$TargetDir = "D:\Repos\Malforge\malforge.github.io\www\spaceengineers\pbapi"
)

Write-Host "Scanning $TargetDir for existing files..."

$files = @()
$directories = @()

# Get all files recursively, excluding .git folder
Get-ChildItem -Path $TargetDir -Recurse -File | Where-Object {
    $_.FullName -notlike "*\.git\*" -and $_.Name -ne ".mdkapigen"
} | ForEach-Object {
    $relativePath = $_.FullName.Substring($TargetDir.Length + 1).Replace('\', '/')
    $files += $relativePath
}

# Get all directories recursively, excluding .git folder
Get-ChildItem -Path $TargetDir -Recurse -Directory | Where-Object {
    $_.FullName -notlike "*\.git\*" -and $_.FullName -notlike "*\.git"
} | ForEach-Object {
    $relativePath = $_.FullName.Substring($TargetDir.Length + 1).Replace('\', '/') + '/'
    $directories += $relativePath
}

# Sort for consistency
$files = $files | Sort-Object
$directories = $directories | Sort-Object

Write-Host "Found $($files.Count) files and $($directories.Count) directories"

# Create manifest object
$manifest = @{
    Generated = (Get-Date).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")
    Files = $files
    Directories = $directories
} | ConvertTo-Json -Depth 10

# Write manifest file
$manifestPath = Join-Path $TargetDir ".mdkapigen"
$manifest | Out-File -FilePath $manifestPath -Encoding UTF8 -NoNewline

Write-Host "Created manifest at: $manifestPath"
Write-Host "Sample files:"
$files | Select-Object -First 5 | ForEach-Object { Write-Host "  - $_" }
if ($directories.Count -gt 0) {
    Write-Host "Sample directories:"
    $directories | Select-Object -First 5 | ForEach-Object { Write-Host "  - $_" }
}
