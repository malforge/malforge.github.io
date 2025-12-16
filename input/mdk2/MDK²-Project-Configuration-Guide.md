The MDK project configuration is managed through two `.ini` files, which handle various settings related to script generation, debugging, and output. These files enable flexibility by distinguishing between project-specific configurations and machine-specific overrides.

### File Overview

1. **`[projectname].mdk.ini`**  
   This file contains project-specific settings and should be checked into source control to maintain consistent configurations across different environments.

2. **`[projectname].mdk.local.ini`**  
   This file is specific to the local machine and is not meant to be checked into version control. It allows developers to apply local customizations (e.g., output paths) without affecting the project-wide settings.

### Configuration Settings

#### `[mdk]`
This section applies to both `.ini` files. All settings can be defined in either file, with the local file (`.mdk.local.ini`) taking precedence over the project file for overrides.

#### `type=programmableblock|mod`
- **Description:** Defines the type of project. **This value should not be changed.** The project is a programmable block script, or it is a mod project. This value should have been set by the project template.

#### `trace=on|off`
- **Description:** This setting is mainly for debugging by the tool developer. You may be asked to enable this if something goes wrong with the tool, as it helps provide more detailed logs for troubleshooting.
- **Default:** `off`.

#### `minify=none|trim|stripcomments|lite|full`
- **Description:** Configures the level of minification applied to the code. This affects the size and structure of the output but not its functionality.
    - **none:** No minification.
    - **trim:** Unused types (not members) are removed from the output.
    - **stripcomments:** Builds on `trim`, removing comments from the code.
    - **lite:** Builds on `stripcomments`, removing leading/trailing whitespace.
    - **full:** The highest level of minification, renaming identifiers to shorter names in addition to `lite`.

#### `ignores=[glob patterns]`
- **Description:** Specifies files and directories to exclude when building the script. The value is a comma-separated list of [glob patterns](https://code.visualstudio.com/docs/editor/glob-patterns). Use this setting to prevent certain files (e.g., build artifacts, debug files) from being included in the output.
    - **Example:** `obj/**/*, MDK/**/*, **/*.debug.cs`

#### `donotclean=[glob patterns]`
- **Description:** Specifies files and directories to exclude when building a mod (this value is not use when building scripts). The value is a comma-separated list of [glob patterns](https://code.visualstudio.com/docs/editor/glob-patterns). Use this setting to prevent certain files (e.g., mod meta information) from being deleted when MDK is cleaning out the output in preparation for a new build.

### Local-Specific Settings

The following settings are typically defined in the `.mdk.local.ini` file to apply machine-specific configurations. These are not required to be shared across developers or environments, providing flexibility in setup.

#### `output=auto|[specific path]`
- **Description:** Specifies where the generated script output should be saved.
    - **auto:** Automatically determines the best location for the output. This will usually be resolved to where Space Engineers itself places local scripts, which is usually in the folder `%AppData%\SpaceEngineers\IngameScripts\local`[<sup>1</sup>](#1)
    - **[specific path]:** A custom path where the script will be saved locally.

#### `binarypath=auto|[specific path]`
- **Description:** Allows overriding the default binary path used during the build process.
    - **auto:** Automatically selects the appropriate binary path. This would usually be resolved to the `Bin64` subfolder of your Space Engineer's installation folder.
    - **[specific path]:** A custom binary path can be provided for local use cases.

---

### How the Files Work Together

Both `.mdk.ini` and `.mdk.local.ini` can contain the same settings, but typically, project-wide configurations go into the `.mdk.ini` file, while machine-specific settings that should not be shared go into `.mdk.local.ini`. Settings in the `.mdk.local.ini` file will always override those in the `.mdk.ini` if both are defined.

- - - 
**Footnotes:**  
<a class="anchor" id="1"></a>
1: `%AppData%` is a Windows macro that will resolve to a special folder on your computer. If you wish to find it, open a Windows Explorer and type it into the address bar and press `enter`.
