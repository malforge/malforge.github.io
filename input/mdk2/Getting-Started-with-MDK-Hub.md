## Installation

1. Go to the [MDK2 Releases page](https://github.com/malforge/mdk2/releases) on GitHub.
2. Download the **latest release** (or prerelease if you want to test new features):
   - **Windows Installer**: `Malforge.MdkHub-win-Setup.exe` (recommended)
   - **Windows Portable**: `Malforge.MdkHub-win-x64-[version].zip` (extract and run)
   - **Linux**: `Malforge.MdkHub-linux-x64-[version].AppImage`
3. Run the installer or extracted executable.

> [!NOTE]
> **Windows users**: You may see a SmartScreen warning because MDK Hub is not commercially code-signed (signing certificates cost hundreds of dollars annually, which isn't practical for free open-source tools). The software is safe - all source code is publicly visible on GitHub. Click "More info" and then "Run anyway" to proceed.

> [!NOTE]
> **Linux users**: You may need to make the AppImage executable:
> ```bash
> chmod +x Malforge.MdkHub-linux-x64-[version].AppImage
> ```

## First Launch

When you first open MDK Hub, it will automatically check your system and set up what's needed. If you don't have .NET 9 installed, the Hub will offer to download and install it for you. It will also install the MDK2 templates so they're available in Visual Studio and Rider (or via `dotnet new` for VSCode users).

Just follow the on-screen prompts - the Hub handles the setup for you.

> [!WARNING]
> **Linux users**: On first launch, you'll need to manually configure paths since Linux doesn't have the same auto-detection that Windows does. You'll be prompted to set your Space Engineers binary path (the `Bin64` folder), your script output path (where compiled scripts are deployed), and your mod output path.

## What You'll See

After setup completes, you'll see the Hub's main dashboard. If you've built MDK2 projects before, they'll appear here automatically (MDK2 keeps track of projects you've built). Otherwise, you'll see a clean slate ready for your first project. Quick actions for creating new projects, checking for updates, and configuring settings are readily available.

## Creating Your First Project

The Hub offers several options in the Projects panel:

**New Programmable Block Script** - Opens a dialog where you choose a name and location. The Hub creates the project using the MDK2 script template and automatically adds it to your project list.

**New Mod** - Creates a mod project.

**Add Existing Project** - If you already created a project from your IDE or command line, use this to browse for the `.csproj` file and add it to the Hub's project list.

## Next Steps

Now that the Hub is set up, you're ready to start coding. Check out the IDE-specific guides for **[Visual Studio](Getting-Started-using-Visual-Studio.html)**, **[VSCode](Getting-Started-using-VSCode.html)**, or **[Jetbrains Rider](Getting-Started-using-Jetbrains-Rider.html)** to learn your preferred workflow.

## What the Hub Does for You

The Hub provides several useful features beyond initial setup. You can view all your MDK2 projects in one place and open them in your preferred IDE with one click. The update system lets you check for Hub updates, template updates, and NuGet package updates. For packages, select a project and choose "Update This Project" or "Update All Projects" to handle updates across your codebase. When you build your scripts, you'll get desktop notifications showing whether the build succeeded or failed. The configuration editor lets you modify `mdk.ini` settings visually, and global path configuration (especially useful on Linux) can be managed from the Hub's settings.
