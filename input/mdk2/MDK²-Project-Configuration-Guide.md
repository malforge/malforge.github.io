The MDK project configuration is managed through `.ini` files, which handle various settings related to script generation, minification, and output paths. These files enable flexibility by distinguishing between project-specific configurations and machine-specific overrides.

> [!TIP]
> **MDK Hub users**: You can edit most configuration settings visually through the Hub's configuration editor instead of manually editing `.ini` files.

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

#### `log=[file path]`
- **Description:** Writes all console output to the specified log file. Useful for debugging build issues, troubleshooting, or capturing output in CI/CD environments.
- **Example:** `log=mdk-build.log`
- **Command-line equivalent:** `mdk pack -log mdk-build.log`
- **Note:** This is typically a local-only setting and should go in `mdk.local.ini`.

#### `trace=on|off`
- **Description:** This setting is mainly for debugging by the tool developer. You may be asked to enable this if something goes wrong with the tool, as it helps provide more detailed logs for troubleshooting.
- **Default:** `off`.

#### `interactive=OpenHub|ShowNotification|DoNothing`
- **Description:** Controls how MDK interacts with the Hub when builds complete.
    - **OpenHub:** Opens the Hub window when a build completes.
    - **ShowNotification:** Shows a toast notification when a build completes.
    - **DoNothing:** No notifications are shown.
- **Default:** `ShowNotification`.
- **Use case:** Set to `DoNothing` for CI/CD environments or if you're not using the Hub.

#### `namespaces=[comma-separated list]`
- **Description:** Specifies which namespaces are allowed in your programmable block script code. This setting only applies to programmable block projects (not mods).
- **Default:** `IngameScript` (set by the script template).
- **Primary use case:** Allowing mixin libraries to use different namespaces so they can be shared between both scripts and mods. For example, a mixin might use `MyLibrary` namespace while your script uses `IngameScript`.
- **Important:** Space Engineers strips all namespaces from the final script when you paste it into a programmable block. If you have two types with the same name in different namespaces, they will conflict. It's strongly recommended to keep all your script code in a single namespace.
- **Example:** `namespaces=IngameScript,MyHelpers`

#### `minify=none|trim|stripcomments|lite|full`
- **Description:** Configures the level of minification applied to the code. This affects the size and structure of the output but not its functionality.
    - **none:** No minification.
    - **trim:** Unused types (not members) are removed from the output.
    - **stripcomments:** Builds on `trim`, removing comments from the code.
    - **lite:** Builds on `stripcomments`, removing leading/trailing whitespace.
    - **full:** The highest level of minification, renaming identifiers to shorter names in addition to `lite`.
	
#### `minifyextraoptions=none|nomembertrimming`
- **Description:** Modifies how the minify options work.
    - **none:** No altered behavior.
	- **nomembertrimming:** The **trim** minifying process will not remove unused members, only types (legacy mode).

#### `ignores=[glob patterns]`
- **Description:** Specifies files and directories to exclude when building the script. The value is a comma-separated list of [glob patterns](https://code.visualstudio.com/docs/editor/glob-patterns). Use this setting to prevent certain files (e.g., build artifacts, debug files) from being included in the output.
    - **Example:** `obj/**/*, MDK/**/*, **/*.debug.cs`

#### `donotclean=[glob patterns]`
- **Description:** Specifies files and directories to exclude when building a mod (this value is not use when building scripts). The value is a comma-separated list of [glob patterns](https://code.visualstudio.com/docs/editor/glob-patterns). Use this setting to prevent certain files (e.g., mod meta information) from being deleted when MDK is cleaning out the output in preparation for a new build.

#### `macros=[comma-separated list]`
- **Description:** Define custom text replacement macros that are expanded during the build process. Macros use the format `$NAME$` and can be used in string literals, comments, and documentation comments.
- **Format:** `NAME1=value1,NAME2=value2` (comma-separated). Quote values that contain spaces or special characters.
- **Example:** `macros=$VERSION$=1.0.5,$AUTHOR$=YourName`
- **See also:** **[Using Macros in MDK²](Using-Macros-in-MDK².html)** for detailed documentation and examples.

### Local-Specific Settings

The following settings are typically defined in the `.mdk.local.ini` file to apply machine-specific configurations. These are not required to be shared across developers or environments, providing flexibility in setup.

#### `output=auto|[specific path]`
- **Description:** Specifies where the generated script output should be saved.
    - **auto:** Automatically determines the best location for the output. On Windows, this resolves to `%AppData%\SpaceEngineers\IngameScripts\local`[<sup>1</sup>](#1). On Linux, defaults to `~/.local/share/SpaceEngineers/IngameScripts/local` (or as configured in Hub).
    - **[specific path]:** A custom path where the script will be saved locally.

> [!NOTE]
> **Global path configuration**: Instead of setting `output` per-project, you can configure a global default in MDK Hub's settings. This is especially useful on Linux where auto-detection isn't available.

#### `binarypath=auto|[specific path]`
- **Description:** Allows overriding the default binary path used during the build process.
    - **auto:** Automatically selects the appropriate binary path. On Windows, this is auto-detected from your Space Engineers installation. On Linux, you must configure this in Hub settings.
    - **[specific path]:** A custom binary path can be provided for local use cases.

> [!NOTE]
> **Command-line users**: The command-line interface uses `-gamebin` as the parameter name, but in INI files, use `binarypath`. Both refer to the same setting (the Space Engineers Bin64 folder).

---

### How the Files Work Together

Both `.mdk.ini` and `.mdk.local.ini` can contain the same settings, but they serve different purposes. Settings in `.mdk.local.ini` will always override those in `.mdk.ini` if both are defined.

**Recommended organization (as used by MDK Hub):**

**mdk.ini** (project settings - commit to source control):
- `type` - Project type
- `namespaces` - Allowed namespaces
- `ignores` - Files to exclude from build
- `minify` - Minification level
- `minifyextraoptions` - Minification options
- `donotclean` - Files to preserve (mods only)

**mdk.local.ini** (machine-specific settings - do NOT commit):
- `output` - Where compiled scripts are deployed
- `binarypath` - Space Engineers installation path
- `interactive` - Hub notification behavior
- `trace` - Debug logging (when requested for troubleshooting)
- `log` - Build log file path

- - - 
**Footnotes:**  
<a class="anchor" id="1"></a>
1: `%AppData%` is a Windows macro that will resolve to a special folder on your computer. If you wish to find it, open a Windows Explorer and type it into the address bar and press `enter`.
