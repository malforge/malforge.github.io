# Manual Installation (Advanced)

> [!WARNING]
> This guide is for advanced users who prefer not to use MDK Hub or need to set up MDK2 in special environments. **Most users should use [MDK Hub](Getting-Started-with-MDK-Hub.html) instead** - it's simpler and handles these steps automatically.

If you're here because you're having issues with the Hub, consider [filing an issue](https://github.com/malforge/mdk2/issues) so we can improve the experience for everyone.

## Prerequisites

1. **.NET 9 SDK** - Download from [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download)
   - Verify installation: `dotnet --list-sdks`
   - You should see at least one `9.x.x` version listed

2. **Space Engineers** - Required for game assembly references
   - The game must be installed and findable by MDK
   - On Linux: Note your installation path (you'll need to configure it manually)

3. **IDE** (optional but recommended):
   - Visual Studio 2022 (17.10 or later) with .NET desktop development workload
   - Visual Studio Code with C# Dev Kit extension
   - JetBrains Rider

## Installing Templates

1. Open a terminal/command prompt.
2. Run:
   ```
   dotnet new install Mal.Mdk2.ScriptTemplates
   ```
3. Verify installation:
   ```
   dotnet new list | grep mdk2
   ```
   You should see `mdk2pbscript` and `mdk2pbmixin` templates listed.

### Troubleshooting Template Installation

If you get an error about NuGet sources:

1. Check your NuGet sources:
   ```
   dotnet nuget list source
   ```
2. If `nuget.org` is missing, add it:
   ```
   dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org
   ```
3. Try the template installation again.

> [!NOTE]
> Some users need to restart their computer after installing .NET 9 before template installation will work.

## Creating a Project

### Option 1: Command Line

```bash
dotnet new mdk2pbscript -n MyScriptName -o MyScriptName
```

Replace `MyScriptName` with your desired project name.

### Option 2: IDE Template

- **Visual Studio**: File → New → Project → Search for "MDK"
- **Rider**: New Solution → Search for "MDK"
- **VSCode**: Use command line method, then open folder in VSCode

## Configuration (Linux Users & Non-Hub Users)

If you're on Linux, Space Engineers isn't auto-detected, or you're not using MDK Hub:

1. Create or edit `MyScriptName.mdk.local.ini` in your project folder.
2. Add:
   ```ini
   [mdk]
   binarypath=/path/to/SpaceEngineers/Bin64
   output=/path/to/.local/share/SpaceEngineers/IngameScripts/local
   interactive=DoNothing
   ```

Replace paths with your actual Space Engineers installation and desired output location.

> [!NOTE]
> The `interactive=DoNothing` setting prevents MDK from showing Hub notifications. This is recommended if you're not using the Hub or running in CI/CD environments.

## Building

### From Command Line
```bash
cd MyScriptName
dotnet build
```

### From IDE
- **Visual Studio**: Press `Ctrl+Shift+B` or Build → Build Solution
- **Rider**: Press `Ctrl+Shift+F9` or Build → Build Solution
- **VSCode**: Press `Ctrl+Shift+B` or run `dotnet build` in terminal

Your compiled script will appear in the configured output path (or the default Space Engineers local scripts folder on Windows).

## Updating Templates

To update to the latest template version:

```bash
dotnet new update
```

Or to update a specific template:

```bash
dotnet new install Mal.Mdk2.ScriptTemplates --force
```

## Updating NuGet Packages

MDK2 uses NuGet packages for analyzers, packagers, and references. To update:

### Command Line
```bash
dotnet list package --outdated
dotnet add package Mal.Mdk2.PbPackager
dotnet add package Mal.Mdk2.PbAnalyzers
dotnet add package Mal.Mdk2.References
```

### IDE
- **Visual Studio**: Right-click project → Manage NuGet Packages → Updates tab
- **Rider**: Right-click project → Manage NuGet Packages → Updates tab
- **VSCode**: Use command line method

## Why Use Hub Instead?

MDK Hub provides several benefits over manual installation:

- **Automatic setup** - No manual .NET checks, template installs, or NuGet source troubleshooting
- **Centralized management** - See all projects in one place, update packages in bulk
- **Build notifications** - Desktop notifications when builds complete
- **Visual configuration** - Edit `mdk.ini` settings through a GUI
- **Project detection** - Automatically finds and imports existing projects
- **Cross-platform** - Works on both Windows and Linux

If you're doing manual installation due to a Hub issue, please report it - we want to make the Hub work for everyone!

## Next Steps

- **[Configure your project](MDK²-Project-Configuration-Guide.html)** - Set minification levels, ignore patterns, etc.
- **[IDE-specific guides](index.html#getting-started)** - Learn IDE-specific workflows
- **[Advanced topics](index.html#configuration)** - File ordering, minifier preservation, mixin projects
