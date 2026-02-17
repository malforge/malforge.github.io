# Updating MDK² NuGet Packages using VSCode or Command Line

> [!TIP]
> **Using MDK Hub?** The Hub can update packages automatically. See the [Updates & Maintenance](index.html#updates--maintenance) section for details.

## Using Command Line

1. Open a terminal (Terminal, Command Prompt, or PowerShell).

   ![image](https://github.com/user-attachments/assets/396abbe3-e0f3-4486-b346-a5256b392edb)

2. Navigate to your project folder:
   ```
   cd path\to\your\project
   ```

3. Check for outdated packages:
   ```
   dotnet list package --outdated
   ```

   ![image](https://github.com/user-attachments/assets/bbd77478-f9b2-44ba-81e2-8b24ed5518d2)

   This shows which packages have updates available.

4. Update packages individually:
   ```
   dotnet add package Mal.Mdk2.PbAnalyzers
   dotnet add package Mal.Mdk2.PbPackager
   dotnet add package Mal.Mdk2.References
   ```

   ![image](https://github.com/user-attachments/assets/eb1100d3-2be9-4e29-811f-0e1dd3d90a22)

   Repeat for each package you want to update. The command automatically installs the latest version.
