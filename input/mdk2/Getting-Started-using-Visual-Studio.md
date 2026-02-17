## Prerequisites

> [!NOTE]
> Before following this guide, make sure you've installed and set up **[MDK Hub](Getting-Started-with-MDK-Hub.html)**. The Hub handles .NET SDK installation, template setup, and project management for you.

> [!WARNING]
> If you have the original MDK (version 1) installed, you should uninstall it. MDK² works quite differently, and keeping the original around may cause conflicts.

## Creating a New Project

1. Open Visual Studio.
2. Click **"Create a new project"** (or `File` → `New` → `Project`).
3. Search for **"MDK"** in the template search box.
4. Select **"Programmable Block Script (MDK2)"**.

   ![image](https://github.com/user-attachments/assets/3fe49151-0b47-4606-8df3-7d7add38018e)

   > The URL shown in the screenshot (https://github.com/malware-dev/MDK-SE) is outdated. The current repository is https://github.com/malforge/mdk2.

5. Choose a name and location for your project, then click **"Create"**.

> [!NOTE]
> Make sure you select the **Script** project template, not the **Mixin** project. Mixin projects are for advanced shared code libraries.

> [!TIP]
> **Having trouble?** If you can't find the MDK templates or encounter issues creating a project, you can use the Hub to create projects instead. Just click "New Project" in the Hub dashboard.

## Building Your Script

1. Make your code changes in `Program.cs` or add new `.cs` files as needed.
2. Build the project (`Ctrl+Shift+B` or `Build` → `Build Solution`).
3. MDK will automatically:
   - Combine all your `.cs` files into a single script
   - Apply minification (if configured)
   - Deploy the script to your Space Engineers IngameScripts folder
   - Show a notification when complete (if Hub is running)

Your compiled script will be available in Space Engineers under **Programmable Block** → **Edit** → **Browse Scripts** (the folder icon).

## Next Steps

- **[Configure your project](MDK²-Project-Configuration-Guide.html)** - Adjust minification levels, ignore patterns, and more
- **[Control file order](Controlling-File-Order-in-MDK²-Projects.html)** - Manage how your files are combined
- **[Preserve code during minification](Using-the-Minifier-and-Preserve-Regions-in-MDK².html)** - Keep specific types/methods unminified
