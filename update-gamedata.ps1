# Game Data Updater
# Refreshes the Space Engineers data the documentation is built from: pbwhitelist.dat, modwhitelist.dat and
# terminal.dat.
#
# By default these are downloaded from the MDK2 game-data release, which is refreshed whenever MDK2 releases or
# its Refresh Game Data workflow is run. If you need data newer than that, run Refresh Game Data in the mdk2
# repository first.
#
# Use -Local when you are changing the extractor itself and need to run your working copy of it. That builds
# mdkx from an mdk2 checkout and runs it against a Space Engineers dedicated server, which takes a few minutes.

param(
    # Build and run the extractor from a local mdk2 checkout instead of downloading the published data.
    [switch] $Local,

    # -Local only. A DedicatedServer64 folder. Defaults to the MDK_SE_DEDICATED_BIN environment variable.
    [string] $SePath = $env:MDK_SE_DEDICATED_BIN,

    # -Local only. The mdk2 repository holding the extractor source.
    [string] $Mdk2Path = (Join-Path $PSScriptRoot '..\mdk2'),

    # -Local only. Download the dedicated server with steamcmd if it cannot be found (roughly 8 GB).
    [switch] $Download,

    # -Local only. Where to put a downloaded dedicated server.
    [string] $DownloadPath = (Join-Path $PSScriptRoot 'se-dedicated')
)

$ErrorActionPreference = 'Stop'

$dataFiles = @('pbwhitelist.dat', 'modwhitelist.dat', 'terminal.dat')
$before = @{}
foreach ($file in $dataFiles) {
    $path = Join-Path $PSScriptRoot $file
    $before[$file] = if (Test-Path $path) { (Get-FileHash $path -Algorithm SHA256).Hash } else { $null }
}

function Find-MSBuild {
    $command = Get-Command msbuild -ErrorAction SilentlyContinue
    if ($command) { return $command.Source }

    $vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
    if (Test-Path $vswhere) {
        $found = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe |
                 Select-Object -First 1
        if ($found) { return $found }
    }

    throw "MSBuild not found. The extractor targets .NET Framework 4.8, which the dotnet CLI cannot build on its own."
}

function Get-DedicatedServer {
    param([string] $Destination)

    $steamCmdDir = Join-Path (Split-Path $Destination -Parent) 'steamcmd'
    $steamCmd = Join-Path $steamCmdDir 'steamcmd.exe'

    if (-not (Test-Path $steamCmd)) {
        Write-Host "Downloading steamcmd..." -ForegroundColor Cyan
        New-Item -ItemType Directory -Force -Path $steamCmdDir | Out-Null
        $zip = Join-Path $steamCmdDir 'steamcmd.zip'
        Invoke-WebRequest -Uri 'https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip' -OutFile $zip
        Expand-Archive -Path $zip -DestinationPath $steamCmdDir -Force

        # The zip holds a bootstrapper. Its first run fetches the real client and exits non-zero without doing
        # what it was asked, so get that over with before it looks like a failed download.
        & $steamCmd +quit | Out-Null
    }

    Write-Host "Downloading the Space Engineers dedicated server (roughly 8 GB, this takes a while)..." -ForegroundColor Cyan
    & $steamCmd +force_install_dir $Destination +login anonymous +app_update 298740 +quit
    if ($LASTEXITCODE -ne 0) {
        throw "steamcmd failed with exit code $LASTEXITCODE"
    }
}

if (-not $Local) {

    # --- download the published data -----------------------------------------

    $baseUrl = 'https://github.com/malforge/mdk2/releases/download/game-data'
    Write-Host "Downloading game data from the MDK2 game-data release..." -ForegroundColor Cyan
    Write-Host ""

    foreach ($file in $dataFiles) {
        $target = Join-Path $PSScriptRoot $file
        Write-Host "  $file" -NoNewline -ForegroundColor Gray
        Invoke-WebRequest -Uri "$baseUrl/$file" -OutFile $target
        Write-Host ("  {0:n0} bytes" -f (Get-Item $target).Length) -ForegroundColor Gray
    }
}
else {

    # --- build and run the extractor -----------------------------------------

    $project = Join-Path $Mdk2Path 'Source\Mdk.Extractor\Mdk.Extractor.csproj'
    if (-not (Test-Path $project)) {
        Write-Host ""
        Write-Host "Cannot find the MDK2 extractor at $project" -ForegroundColor Red
        Write-Host "Pass -Mdk2Path pointing at your mdk2 checkout." -ForegroundColor Yellow
        exit 1
    }
    $Mdk2Path = (Resolve-Path $Mdk2Path).Path

    if (-not $SePath -or -not (Test-Path (Join-Path $SePath 'SpaceEngineersDedicated.exe'))) {
        $candidate = Join-Path $DownloadPath 'DedicatedServer64'
        if (Test-Path (Join-Path $candidate 'SpaceEngineersDedicated.exe')) {
            $SePath = $candidate
        }
        elseif ($Download) {
            Get-DedicatedServer -Destination $DownloadPath
            $SePath = $candidate
        }
        else {
            Write-Host ""
            Write-Host "No Space Engineers dedicated server found." -ForegroundColor Red
            Write-Host "Either:" -ForegroundColor Yellow
            Write-Host "  - set MDK_SE_DEDICATED_BIN to a DedicatedServer64 folder, or" -ForegroundColor Yellow
            Write-Host "  - pass -SePath <DedicatedServer64 folder>, or" -ForegroundColor Yellow
            Write-Host "  - pass -Download to fetch it with steamcmd (roughly 8 GB)" -ForegroundColor Yellow
            exit 1
        }
    }
    $SePath = (Resolve-Path $SePath).Path

    Write-Host "Extractor:        $project" -ForegroundColor Gray
    Write-Host "Dedicated server: $SePath" -ForegroundColor Gray
    Write-Host ""
    Write-Host "Building the extractor..." -ForegroundColor Cyan

    $msbuild = Find-MSBuild
    $env:MDK_SE_DEDICATED_BIN = $SePath

    & $msbuild $project -t:Restore -v:quiet -nologo
    if ($LASTEXITCODE -ne 0) { Write-Host "Restore failed!" -ForegroundColor Red; exit 1 }

    & $msbuild $project -t:Build -p:Configuration=Release -p:Platform=x64 -v:minimal -nologo
    if ($LASTEXITCODE -ne 0) { Write-Host "Build failed!" -ForegroundColor Red; exit 1 }

    $mdkx = Join-Path $Mdk2Path 'Source\Mdk.Extractor\bin\x64\Release\net48\mdkx.exe'
    if (-not (Test-Path $mdkx)) { Write-Host "Built, but $mdkx is missing!" -ForegroundColor Red; exit 1 }

    Write-Host ""
    Write-Host "Running the extractor. This starts a dedicated server and takes a minute or so..." -ForegroundColor Cyan
    Write-Host ""

    # pbprologue.dat is an MDK analyzer input and is not used by the site, so it goes to a scratch location.
    & $mdkx -sepath $SePath `
            -pbwhitelist  (Join-Path $PSScriptRoot 'pbwhitelist.dat') `
            -modwhitelist (Join-Path $PSScriptRoot 'modwhitelist.dat') `
            -pbprologue   (Join-Path $env:TEMP 'pbprologue.dat') `
            -terminal     (Join-Path $PSScriptRoot 'terminal.dat')

    if ($LASTEXITCODE -ne 0) {
        Write-Host ""
        Write-Host "Extraction failed!" -ForegroundColor Red
        exit 1
    }
}

# --- report -----------------------------------------------------------------

Write-Host ""
$changed = @()
foreach ($file in $dataFiles) {
    $path = Join-Path $PSScriptRoot $file
    $hash = (Get-FileHash $path -Algorithm SHA256).Hash
    if ($hash -ne $before[$file]) { $changed += $file }
}

if ($changed.Count -gt 0) {
    Write-Host "Updated:" -ForegroundColor Yellow
    $changed | ForEach-Object { Write-Host "  $_" -ForegroundColor White }
    Write-Host ""
    Write-Host "Regenerate the documentation with:" -ForegroundColor Yellow
    Write-Host "  .\generate-wiki.ps1" -ForegroundColor White
}
else {
    Write-Host "The game data was already up to date. Nothing to regenerate." -ForegroundColor Green
}
Write-Host ""

# Explicit, so a caller can test $LASTEXITCODE. The download path runs no native command, which would otherwise
# leave $LASTEXITCODE unset, and $null -ne 0 reads as a failure.
exit 0
