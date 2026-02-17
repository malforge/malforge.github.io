# Using Macros in MDK²

MDK² supports text replacement macros that are expanded during the build process. Macros are useful for embedding build timestamps, version information, or any other text that should be generated at build time.

## Macro Format

Macros use the format `$NAME$` where NAME can contain letters, digits, and underscores. For example:

```csharp
// This comment was generated at $MDK_DATETIME$
string version = "Built on $MDK_DATE$ at $MDK_TIME$";
```

## Default Macros

MDK² provides three built-in macros that are automatically available:

- **`$MDK_DATETIME$`** - Current date and time (format: `yyyy-MM-dd HH:mm`)
- **`$MDK_DATE$`** - Current date only (format: `yyyy-MM-dd`)
- **`$MDK_TIME$`** - Current time only (format: `HH:mm`)

These macros are updated every time you build your project, making them perfect for build timestamps.

## Defining Custom Macros

You can define your own custom macros in two ways:

### Using INI Configuration

Add macros to your `mdk.ini` or `mdk.local.ini` file:

```ini
[mdk]
macros=$VERSION$=1.0.5,$AUTHOR$=YourName
```

Multiple macros are comma-separated in the format `NAME=value`. If a value contains spaces or special characters, enclose it in quotes:

```ini
[mdk]
macros=$VERSION$=1.0.5,$DESCRIPTION$="My awesome script"
```

### Using Command Line

When running `mdk pack` from the command line, you can define macros using the `-macro` flag:

```bash
mdk pack MyProject.csproj -macro $BUILD_NUMBER$=42 -macro $BRANCH$=main
```

You can use `-macro` multiple times to define multiple macros.

## Where Macros Are Replaced

Macros are replaced in the following locations during the build process:

- **String literals**: `string message = "Version $VERSION$";`
- **Single-line comments**: `// Built on $MDK_DATETIME$`
- **Multi-line comments**: `/* Version $VERSION$ */`
- **Documentation comments**: `/// <summary>Version $VERSION$</summary>`
- **Instructions.readme**: Macros in your Instructions.readme file are replaced before being added as header comments to the output script

Macros are replaced everywhere in both programmable block scripts and mods.

## Unknown Macros

If you reference a macro that hasn't been defined (for example, `$UNDEFINED$`), it will be left as-is in the output. This prevents accidental text replacement and makes it safe to use dollar signs in your code for other purposes.

## Example Usage

Here's a practical example of using macros in a programmable block script:

```csharp
public Program()
{
    // Script built on $MDK_DATETIME$
    Echo("Script Version: $VERSION$");
    Echo("Build Date: $MDK_DATE$");
}
```

With macros defined in your `mdk.ini`:

```ini
[mdk]
macros=$VERSION$=2.1.0
```

After building, the output script will contain:

```csharp
public Program()
{
    // Script built on 2026-02-17 11:50
    Echo("Script Version: 2.1.0");
    Echo("Build Date: 2026-02-17");
}
```

## Tips

- Use `mdk.local.ini` for machine-specific macros (like local build numbers) that shouldn't be committed to source control
- Use `mdk.ini` for project-wide macros (like version numbers) that should be shared with all developers
- Macro names are case-insensitive: `$VERSION$` and `$version$` refer to the same macro
- Keep macro names descriptive and use UPPERCASE to make them stand out in your code
