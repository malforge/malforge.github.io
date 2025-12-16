1. Start by pressing your Windows or Start button, then type  
  `terminal`  
and press enter (you can also use `Command Prompt` for this instead of terminal if you prefer).
![image](https://github.com/user-attachments/assets/396abbe3-e0f3-4486-b346-a5256b392edb)  

- - -

2. To see if there are any update available, type:  
  `dotnet new update --check-only`  
and press enter.  
![image](https://github.com/user-attachments/assets/b5787d9c-0f26-4c64-bda7-b785fe1489a2)  
Here we can see that we have 2.0.4 installed of the Script template, but there's a 2.0.5 available.

- - -

3. Update the template. You can either do the quick thing, simply typing  
  `dotnet new update`  
and press enter, which will simply update every template you have to the newest version,
or if you wish to update the template specifically, follow the instructions shown in the 
screenshot above, in this particular case  
  `dotnet new install Mal.Mdk2.ScriptTemplates::2.0.5`  
to update the templates to version 2.0.5.

