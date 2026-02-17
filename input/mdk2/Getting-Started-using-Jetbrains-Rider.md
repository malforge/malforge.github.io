## Prerequisites

> [!NOTE]
> Before following this guide, make sure you've installed and set up **[MDK Hub](Getting-Started-with-MDK-Hub.html)**. The Hub handles .NET SDK installation, template setup, and project management for you.

## Creating a New Project

### Option 1: Using Rider's Template UI

1. Open JetBrains Rider.
2. Click **"New Solution"**.

   ![new-solution](https://github.com/user-attachments/assets/de932e77-4f4e-4070-b6e9-e2c4f958b5e7)

3. In the template list, find and select **"Programmable Block Script (MDK2)"**.

   ![templates](https://github.com/user-attachments/assets/5c708cd6-12fc-4850-b8e5-2f52469b392b)

4. Choose a name and location for your project, then click **"Create"**.

### Option 2: Using the Command Line

Open a terminal and run:
```
dotnet new mdk2pbscript -n MyFirstScript -o MyFirstScript
```
Then open the project in Rider.

### Option 3: Using MDK Hub

Click **"New Project"** in the Hub dashboard and let it create the project for you, then open it in Rider.

> [!NOTE]
> Make sure you select the **Script** project template, not the **Mixin** project. Mixin projects are for advanced shared code libraries.

## Building Your Script

1. Make your code changes in `Program.cs` or add new `.cs` files as needed.
2. Build the project (`Ctrl+Shift+F9` or `Build` → `Build Solution`).
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

---

> [!NOTE]
> _A big thank you to [@Drew-Chase](https://github.com/Drew-Chase) who contributed to the Rider documentation._
