A **mixin project** is a specialized project type that allows you to combine reusable code components or libraries with your scripts or mods. This feature is especially useful when you have code that can be shared across multiple projects, such as utility functions or common classes.

### When to Use a Mixin Project
- **Code Reusability:** Share common logic across different programmable block scripts or mods.
- **Separation of Concerns:** Keep your core script or mod focused on its specific logic while externalizing reusable components.
- **Maintainability:** Centralize shared code to make it easier to maintain and update in one location.
- **Cross-Project Type Sharing:** Use the same mixin library in both scripts and mods (configure the `namespaces` setting in script projects to allow mixin namespaces).

### How to Create a Mixin Project

Mixin projects use the **"MDK Mixin (MDK2)"** template. You can create them via:

- **Visual Studio or Rider**: Use the new project dialog and search for "MDK Mixin"
- **Command line**: Run `dotnet new mdk2mixin -n MyMixinName -o MyMixinName`

After creating a mixin project, you can add it to the Hub using "Add Existing Project".

### How Mixin Projects Work
During the build process, code from the mixin project is merged into the main script or mod. This gives you access to all the methods and classes defined in the mixin without duplicating the code. Since mixins are designed for reuse, they keep your projects modular and prevent unnecessary repetition.

> [!TIP]
> When using a mixin with programmable block scripts, you may need to add the mixin's namespace to the `namespaces` setting in your script's `mdk.ini` file. See the [Project Configuration Guide](MDK²-Project-Configuration-Guide.html#namespacescomma-separated-list) for details.
