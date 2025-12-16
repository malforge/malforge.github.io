1. Make sure you have installed DotNet 9.
   * Make sure to close VSCode before this step.
   * Open a Terminal window by pressing the Windows/Start button and typing `Terminal` (or `Command Prompt` if you prefer)

   ![Start menu showing Terminal and Command Prompt highlighted](https://github.com/malforge/mdk2/assets/4653628/f6d70f83-3869-4aa6-9cf1-fbe8d68510f1)

   * Type `dotnet --list-sdks` and press `enter`.

   ![image](https://github.com/user-attachments/assets/c81cbc52-b297-423c-82a2-3bac7b2f591b)

   If you do not have any .NET 9 versions, you need to go to <https://dotnet.microsoft.com/en-us/download>.

2. Install the DotNet New template package.
   * Make sure to close Visual Studio before this step.
   * Open a Terminal window by pressing the Windows/Start button and typing `Terminal` (or `Command Prompt` if you prefer)

   ![Start menu showing Terminal and Command Prompt highlighted](https://github.com/malforge/mdk2/assets/4653628/f6d70f83-3869-4aa6-9cf1-fbe8d68510f1)

   * Type `dotnet new install Mal.Mdk2.ScriptTemplates` and press `enter`

   ![image](https://github.com/malforge/mdk2/assets/4653628/09ad40eb-3dc8-45ac-af50-f4157e89cb83)

> [!NOTE]
> Some people get this message:  
>  
> ![image](https://github.com/user-attachments/assets/0e3a164c-1740-4ae7-a01e-b173e7f2bb14)  
>  
> This usually means that for whatever reason, the nuget primary package source has not been added to your nuget package manager. You can
> double check this by typing `dotnet nuget list source`. If everything is as it should, it should at least list an entry with the official
> nuget source:  
>  
> ![image](https://github.com/user-attachments/assets/e8df7247-f76d-4222-8af9-634896aa810f)  
>  
> If it doesn't, you can add it by typing in `dotnet nuget add source "https://api.nuget.org/v3/index.json" --name "NuGet.org"`.
> After this, you can try adding the template package again.  

> [!NOTE]
> Some people were not able to run the install command before restarting their computer after installing DotNet 9 or Visual Studio.

3. Create your first script project
   * Open another Terminal window (or continue using the one you opened earlier)
   * Type `dotnet new mdk2pbscript -n MyFirstScript -o MyFirstScript`  
   ![image](https://github.com/malforge/mdk2/assets/4653628/88843e20-8951-4a0f-bb7c-62967c4da5dd)

4. Open the project in VSCode
   * Open VSCode
   * Close any welcome dialogs or other stuff VSCode might throw at you

   ![image](https://github.com/malforge/mdk2/assets/4653628/842d4602-9393-4f78-a5bf-43eb451a414a)

   * Drag your new script folder into VSCode  
     VSCode may show you a dialog (you may have to actually select one of the code files, like `Program.cs`, before it does).

     ![image](https://github.com/malforge/mdk2/assets/4653628/ac174c05-316b-4847-9c56-463fb74a151a)

     You want this extension, install it and make sure it's active (it _should_ activate automatically when installed).
   * When you get back to the Explorer now, your project should be loaded and ready for you.
