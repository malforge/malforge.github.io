# Running MDK2 under linux
To run MDK2 under linux, you'll have to compile the mdk.exe program as a linux executable, then replace it in the ~/.nuget/packages/mal.mdk2.pbpackager directory. To do that clone [the mdk2 repo](https://github.com/malforge/mdk2) then change into it and run the following commands:
```
cd Source/Mdk.CommandLine  
dotnet publish "Mdk.CommandLine.csproj" -c Release --self-contained false -r linux-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true -o "*Undefined*Binaries"
```
Your linux-compiled mdk.exe will be in `*Undefined*Binaries/mdk` (No `.exe`) and all you have to do now is copy it into `~/.nuget/packages/mal.mdk2.pbpackager/<version>/tools/mdk.exe` -- Overwriting the one that came from the nuget package download.

Note that to use it, you'll have to manually supply the location of space engineers' Bin64 folder, as well as your script locations using `<proj>.mdk.local.ini` as MDK2 can not auto-detect this under Linux.

- - -

# Picarl's Supplemental Instructions
Accurate as of 2.1.5:

Howdy folk! I've recently had to perform an additional step to the above instructions in order to get my MDK2 NuGet package running on Linux.

Preamble: You'll want to have the MDK2 Repo downloaded and opened in the IDE of your choice to build the Linux executables below.

1. Restore / Download the MDK NuGet packages for the script project you want to build.
2. With the MDK2 Repo opened in the aforementioned IDE of your choice: 
   Edit the .csproj files for MDK.CommandLine and MDK.CheckDotNet and change the value of the <RuntimeIdentifier> tags to "linux-x64"
   ![Image](https://github.com/user-attachments/assets/c364b16c-b6af-4d4b-8833-71358d4582cd)
3. Copy the contents of mdk2/Source/Mdk.CommandLine/bin/Release/net9.0/linux-x64 to ~/.nuget/packages/mal.mdk2.pbpackager/2.1.5/tools (Merge and replace all)
4. Copy the contents of mdk2/Source/Mdk.CheckDotNet/bin/Debug/net8.0/linux-x64 to ~/.nuget/packages/mal.mdk2.pbpackager/2.1.5/tools (Merge and replace all)
5. At this point: You have a mdk.exe (built for windows) and a mdk (no extension, built for linux) file in the ~/.nuget/packages/mal.mdk2.pbpackager/2.1.5/tools directory.
   Delete mdk.exe, and rename mdk to mdk.exe in order to replace it.

6. Reload any projects you may have open, attempt to build.
7. Attempt to build your script - and hopefully you see similar results to below!
   ![Image](https://github.com/user-attachments/assets/14db05f9-ae22-48c9-a992-ede67cd13aed)

(My script is large. Disregard that.)

- - -

A note from the developer: I don't run Linux anywhere, otherwise I might as well have supported Linux out of the box seeing how simple it is to make work. A big thank you to AmandaC on Discord for doing the research and writing the guide above.