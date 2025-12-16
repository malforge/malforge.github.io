## Prerequisites
> [!WARNING]
> If you have the original MDK installed, you should uninstall it. MDK² works quite differently, and keeping the original around might interfere or at the very least
> can throw unrelated and therefore confusing errors.

1. Make sure your Visual Studio is at least version `17.10`.
   * Open Visual Studio.
   * Open the `Help` menu and select `About Microsoft Visual Studio`.

   ![Visual Studio help menu highlighting the About item](https://github.com/malforge/mdk2/assets/4653628/c69eab80-09d6-4d4c-b168-eb7380efa7aa)

   ![Visual Studio About screen showing version highlighted](https://github.com/malforge/mdk2/assets/4653628/cbdaf733-5bf9-4300-b26e-b505bcc095e5)

2. Make sure you have installed the .NET desktop development workload.
   * Open Visual Studio Installer.
   * Select `Modify` on your Visual Studio 2022 installation

   ![image](https://github.com/user-attachments/assets/46648330-8f26-4277-90d1-f26b2338f8e4)

   * In the `Workloads` tab, Find `.NET desktop development workload` and make sure it is checked.

   ![image](https://github.com/user-attachments/assets/685e435d-5ca4-4d83-bb27-68155568596a)

   * If changes are necessary, press the `Modify` button in the lower right. Once it has done its thing, your copy should be ready for MDK.

   ![image](https://github.com/user-attachments/assets/029698b1-453a-4ca7-9fb3-6ddf69cecadb)

3. Make sure you have installed DotNet 9.
   * Make sure to close Visual Studio before this step.
   * Open a Terminal window by pressing the Windows/Start button and typing `Terminal` (or `Command Prompt` if you prefer)

   ![Start menu showing Terminal and Command Prompt highlighted](https://github.com/malforge/mdk2/assets/4653628/f6d70f83-3869-4aa6-9cf1-fbe8d68510f1)

   * Type `dotnet --list-sdks` and press `enter`.

   ![image](https://github.com/user-attachments/assets/c81cbc52-b297-423c-82a2-3bac7b2f591b)

   If you do not have any .NET 9 versions, you need to go to <https://dotnet.microsoft.com/en-us/download>.

## Installing MDK

1. Install the DotNet New template package.
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
> If it doesn't, you can add it by typing in `dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org`.
> After this, you can try adding the template package again.  

> [!NOTE]
> Some people were not able to run the install command before restarting their computer after installing DotNet 9 or Visual Studio.
 
2. Open Visual Studio again. Press "Create a new project". 
   When you search for MDK now, you will find these two projects.

   ![image](https://github.com/user-attachments/assets/3fe49151-0b47-4606-8df3-7d7add38018e)

   PS: The URL you see in the image (https://github.com/malware-dev/MDK-SE) has been superceded by https://github.com/malforge/mdk2.

> [!NOTE]
> Make sure you select the Script project and not the Mixin project when starting your new script.
