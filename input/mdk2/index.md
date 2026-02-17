# MDK² Documentation

Welcome to MDK² (Malware's Development Kit for Space Engineers), a comprehensive toolkit for developing programmable block scripts and mods for Space Engineers.

## Getting Started

The quickest way to get started is to install MDK Hub, which handles all the setup automatically. Once that's done, you can use your preferred IDE to write code.

**[Get Started with MDK Hub](Getting-Started-with-MDK-Hub.html)** - Install the Hub and let it set up .NET, templates, and project management for you.

After the Hub is set up, choose your development environment:

- **[Visual Studio](Getting-Started-using-Visual-Studio.html)**
- **[Jetbrains Rider](Getting-Started-using-Jetbrains-Rider.html)**
- **[VSCode](Getting-Started-using-VSCode.html)**  

If you prefer not to use the Hub, the **[Manual Installation Guide](Manual-Installation.html)** covers advanced setup for those who want more control.

> [!NOTE]
> **Upgrading from MDK (version 1)?** Due to significant architectural changes, we recommend creating a new MDK² project and copying your code files over rather than attempting to upgrade existing projects.

---

## Project Types

MDK² supports three project types:

**Programmable Block Scripts** - In-game scripts for programmable blocks. These are combined into a single file and deployed to Space Engineers.

**Mods** - Full game modifications that extend Space Engineers functionality.

**[Mixin Projects](Mixin-Projects.html)** - Shared code libraries that can be referenced from multiple scripts or mods. Perfect for reusing utility functions, helper classes, or common logic across your projects.

---

## Configuration

Start with the **[MDK² Project Configuration Guide](MDK²-Project-Configuration-Guide.html)** to configure minification, output paths, and other settings. 

## Advanced Features

- **[Controlling File Order](Controlling-File-Order-in-MDK²-Projects.html)** - Manage how your files are combined in the final output
- **[Using Macros](Using-Macros-in-MDK².html)** - Use text replacement macros for build timestamps, version numbers, and custom values
- **[Preserving Types During Minification](Using-the-Minifier-and-Preserve-Regions-in-MDK².html)** - Keep specific code unminified

---

## Updates & Maintenance

The Hub makes it easy to keep everything current. You can update templates directly from the Hub's update checker or use the **[command-line method](Updating-the-MDK2-templates.html)**.

For NuGet packages, the Hub shows update indicators in the project list. Select a project that needs updates, and you'll see "MDK Package Updates" in the actions panel with two options: "Update This Project" or "Update All Projects" to handle updates across your codebase.

If you prefer using your IDE's package manager instead:

- **[Visual Studio](Updating-the-MDK2-Nuget-packages-using-Visual-Studio.html)**
- **[Jetbrains Rider](Updating-the-MDK2-Nuget-packages-using-Jetbrains-Rider.html)**
- **[VSCode or command line](Updating-the-MDK2-Nuget-packages-using-VSCode-or-command-line.html)**

---

## Contributing to Documentation

Found an error or have a suggestion? We'd love to hear about it. You can report issues or contribute fixes through the [malforge.github.io repository](https://github.com/malforge/malforge.github.io) on GitHub. The documentation source files are in the `input/mdk2/` folder.

Your contributions help make MDK² better for everyone!
