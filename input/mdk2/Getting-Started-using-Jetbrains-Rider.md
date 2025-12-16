## With terminal
Make sure you have installed DotNet 9.
* Make sure to close Rider before this step.
* Open a Terminal window by pressing the Windows/Start button and typing `Terminal` (or `Command Prompt` if you prefer)

![Start menu showing Terminal and Command Prompt highlighted](https://github.com/malforge/mdk2/assets/4653628/f6d70f83-3869-4aa6-9cf1-fbe8d68510f1)

* Type `dotnet --list-sdks` and press `enter`.

![image](https://github.com/user-attachments/assets/c81cbc52-b297-423c-82a2-3bac7b2f591b)

If you do not have any .NET 9 versions, you need to go to <https://dotnet.microsoft.com/en-us/download>.

Install the DotNet New template package.
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

Open JetBrain's Rider
Click the new Solution button.

![new-solution](https://github.com/user-attachments/assets/de932e77-4f4e-4070-b6e9-e2c4f958b5e7)

Now you should have two templates added, Programmable Block Script (MDK2) and Programmable Block Mixin (MDK2)

![templates](https://github.com/user-attachments/assets/5c708cd6-12fc-4850-b8e5-2f52469b392b)

## With JetBrains Interface
1. Download the nuget package [Mal.Mdk2.ScriptTemplates](https://www.nuget.org/packages/Mal.Mdk2.ScriptTemplates)

![download-nuget-package](download-nuget-package.png)

2. Open JetBrain's Rider
3. Click the new Solution button.

![new-solution](https://github.com/user-attachments/assets/01605907-0310-4621-8314-e4084f96fd10)

4. Click "Manage Templates..." button.

![manage-templates](https://github.com/user-attachments/assets/58f732dd-e6f1-4e11-98da-4a426adbd875)

5. Click "Install Template..."

![install template](install-template.png)

6. Navigate to where you downloaded the nuget package, select it and click open.

![select-nuget](https://github.com/user-attachments/assets/335453b4-2f47-45c2-8af4-2ea93e574bb5)

7. Click "close"

![close](https://github.com/user-attachments/assets/6d7cd32e-aa7e-4e83-89e5-43a5aa80e091)

Now you should have two templates added, Programmable Block Script (MDK2) and Programmable Block Mixin (MDK2)

![templates](https://github.com/user-attachments/assets/5c708cd6-12fc-4850-b8e5-2f52469b392b)

> [!NOTE]
> Make sure you select the Script project and not the Mixin project when starting your new script.

_A big thank you to [@Drew-Chase](https://github.com/Drew-Chase) who wrote up the tutorial for Rider for me._
