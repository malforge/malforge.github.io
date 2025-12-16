1. Start by pressing your Windows or Start button, then type  
  `terminal`  
and press enter (you can also use `Command Prompt` for this instead of terminal if you prefer).
![image](https://github.com/user-attachments/assets/396abbe3-e0f3-4486-b346-a5256b392edb)  

- - -

2. Make sure you stand in your project folder. Type
  `cd D:\Repos\Mdk.PbScript1\`
and press enter. Obviously `Mdk.PbScript1` is an example placeholder here.

- - -

3. To see if there are any update available, type:  
  `dotnet list package --outdated`  
and press enter.  
![image](https://github.com/user-attachments/assets/bbd77478-f9b2-44ba-81e2-8b24ed5518d2)  
Here we can see that we have two MDK2 packages with updates available.

- - -

4. Update an individual package. Type
   `dotnet add package Mal.Mdk2.PbAnalyzers`  
and press enter.  
![image](https://github.com/user-attachments/assets/eb1100d3-2be9-4e29-811f-0e1dd3d90a22)  
Repeat this for all the packages you want to update.
