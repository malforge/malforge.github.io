## Using MDK Hub (Recommended)

1. Open MDK Hub.
2. Click the **"Check for Updates"** button (or look for the update notification badge).
3. If template updates are available, you'll see them listed.
4. Click **"Update Templates"** to install the latest version.

The Hub will handle the update automatically and notify you when complete.

## Using Command Line

1. Open a terminal (Terminal, Command Prompt, or PowerShell).

   ![image](https://github.com/user-attachments/assets/396abbe3-e0f3-4486-b346-a5256b392edb)

2. Check for available updates:
   ```
   dotnet new update --check-only
   ```

   ![image](https://github.com/user-attachments/assets/b5787d9c-0f26-4c64-bda7-b785fe1489a2)

   This shows your current version and any available updates.

3. Update the templates:
   - **Update all templates**: 
     ```
     dotnet new update
     ```
   - **Update MDK templates specifically** (as shown in the screenshot):
     ```
     dotnet new install Mal.Mdk2.ScriptTemplates::[version]
     ```

The command line method updates the templates globally for all IDEs (Visual Studio and Rider have template UIs; VSCode users use `dotnet new`).

