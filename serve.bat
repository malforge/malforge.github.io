@echo off
REM Simple local web server using .NET's built-in HttpListener
REM No external dependencies needed!

echo ========================================
echo Starting local web server...
echo ========================================
echo.
echo The wiki will be available at:
echo   http://localhost:8080
echo.
echo Press Ctrl+C to stop the server
echo ========================================
echo.

cd /d "%~dp0docs"

REM Create a simple PowerShell HTTP server with error logging
powershell -NoProfile -ExecutionPolicy Bypass -Command ^
"$listener = New-Object System.Net.HttpListener; ^
$listener.Prefixes.Add('http://localhost:8080/'); ^
$listener.Start(); ^
Write-Host 'Server started at http://localhost:8080' -ForegroundColor Green; ^
Start-Process 'http://localhost:8080'; ^
try { ^
    while ($listener.IsListening) { ^
        try { ^
            $context = $listener.GetContext(); ^
            $request = $context.Request; ^
            $response = $context.Response; ^
            $path = $request.Url.LocalPath; ^
            Write-Host \"[$(Get-Date -Format 'HH:mm:ss')] Request: $path\" -ForegroundColor Cyan; ^
            $filePath = Join-Path (Get-Location) $path.TrimStart('/'); ^
            if ((Test-Path $filePath -PathType Container)) { ^
                $filePath = Join-Path $filePath 'index.html'; ^
                Write-Host \"  -> Directory, trying: index.html\" -ForegroundColor Gray; ^
            } ^
            if (Test-Path $filePath -PathType Leaf) { ^
                try { ^
                    $content = [System.IO.File]::ReadAllBytes($filePath); ^
                    $ext = [System.IO.Path]::GetExtension($filePath); ^
                    $contentType = switch ($ext) { ^
                        '.html' { 'text/html; charset=utf-8' } ^
                        '.css' { 'text/css; charset=utf-8' } ^
                        '.js' { 'application/javascript; charset=utf-8' } ^
                        '.json' { 'application/json; charset=utf-8' } ^
                        '.png' { 'image/png' } ^
                        '.jpg' { 'image/jpeg' } ^
                        '.jpeg' { 'image/jpeg' } ^
                        '.ico' { 'image/x-icon' } ^
                        default { 'application/octet-stream' } ^
                    }; ^
                    $response.ContentType = $contentType; ^
                    $response.ContentLength64 = $content.Length; ^
                    $response.OutputStream.Write($content, 0, $content.Length); ^
                    Write-Host \"  [OK] Served: $filePath ($($content.Length) bytes)\" -ForegroundColor Green; ^
                } catch { ^
                    Write-Host \"  [ERROR] Failed to read file: $filePath\" -ForegroundColor Red; ^
                    Write-Host \"  Error: $($_.Exception.Message)\" -ForegroundColor Red; ^
                    $response.StatusCode = 500; ^
                } ^
            } else { ^
                Write-Host \"  [404] Not found: $filePath\" -ForegroundColor Yellow; ^
                $response.StatusCode = 404; ^
            } ^
            $response.Close(); ^
        } catch { ^
            Write-Host \"[ERROR] Request handling failed: $($_.Exception.Message)\" -ForegroundColor Red; ^
            Write-Host \"Stack trace: $($_.ScriptStackTrace)\" -ForegroundColor Red; ^
            if ($response) { ^
                try { $response.Close() } catch {} ^
            } ^
        } ^
    } ^
} catch { ^
    Write-Host \"[FATAL] Server crashed: $($_.Exception.Message)\" -ForegroundColor Red; ^
    Write-Host \"Stack trace: $($_.ScriptStackTrace)\" -ForegroundColor Red; ^
} finally { ^
    Write-Host 'Stopping server...' -ForegroundColor Yellow; ^
    $listener.Stop(); ^
}"
