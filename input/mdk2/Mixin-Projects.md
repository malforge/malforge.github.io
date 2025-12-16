A **mixin project** is a specialized project type that allows you to combine reusable code components or libraries with your main script. This feature is especially useful when you have code that can be shared across multiple projects, such as utility functions or common classes.

### When to Use a Mixin Project
- **Code Reusability:** If you have common logic that needs to be used across different programmable block scripts, a mixin project helps modularize this functionality.
- **Separation of Concerns:** Keeps your core script focused on its specific logic while externalizing reusable components.
- **Maintainability:** Centralizing shared code makes it easier to maintain and update in one location.

### How to Create a Mixin Project
When creating a new mixin project, select the template called **"MDK Mixin (MDK2)"**. 

### How Mixin Projects Work
During the build process, code from the mixin project is merged into the main script. This gives you access to all the methods and classes defined in the mixin without duplicating the code. Since mixins are designed for reuse, they keep your scripts modular and prevent unnecessary repetition.
