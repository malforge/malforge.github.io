## Prerequisites

> [!NOTE]
> Before following this guide, make sure you've installed and set up **[MDK Hub](Getting-Started-with-MDK-Hub.html)**. The Hub handles .NET SDK installation, template setup, and project management for you.

## Creating a New Project

### Option 1: Using the Command Line

1. Open a Terminal window (Command Prompt, PowerShell, or your preferred terminal).
2. Navigate to where you want to create your project.
3. Run:
   ```
   dotnet new mdk2pbscript -n MyFirstScript -o MyFirstScript
   ```
   Replace `MyFirstScript` with your desired project name.

   ![image](https://github.com/malforge/mdk2/assets/4653628/88843e20-8951-4a0f-bb7c-62967c4da5dd)

### Option 2: Using MDK Hub

Click **"New Project"** in the Hub dashboard and let it create the project for you.

## Opening the Project in VSCode

1. Open VSCode.
2. Close any welcome dialogs.

   ![image](https://github.com/malforge/mdk2/assets/4653628/842d4602-9393-4f78-a5bf-43eb451a414a)

3. Drag your project folder into VSCode (or use `File` → `Open Folder`).
4. If prompted, install the **C# Dev Kit** extension:

   ![image](https://github.com/malforge/mdk2/assets/4653628/ac174c05-316b-4847-9c56-463fb74a151a)

   This extension provides IntelliSense, debugging, and build support for C# projects.

## Building Your Script

1. Make your code changes in `Program.cs` or add new `.cs` files as needed.
2. Build the project:
   - Press `Ctrl+Shift+B` (or `Cmd+Shift+B` on Mac)
   - Or open the terminal and run: `dotnet build`
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
