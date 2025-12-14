# Contributing Community Examples and Tips

Thank you for your interest in contributing to the Space Engineers Programmable Block API documentation! Community contributions help make this resource more valuable for everyone.

## What Can You Contribute?

You can add **examples, tips, common pitfalls, and best practices** to any API documentation page. Good contributions include:

- **Code examples** showing real-world usage
- **Common mistakes** and how to avoid them
- **Performance tips** and optimization tricks
- **Best practices** for using specific APIs
- **Helpful links** to tutorials or related documentation

## How to Contribute

### 1. Find the Target Page

Navigate to the API page you want to enhance (e.g., `IMyProgrammableBlock`, `Vector3D`, etc.)

### 2. Copy the Filename

The filename is shown in your browser's address bar. For example:
- URL: `.../Sandbox.ModAPI.Ingame.IMyProgrammableBlock.html`
- Filename: `Sandbox.ModAPI.Ingame.IMyProgrammableBlock`

### 3. Create Your Markdown File

In the `www/spaceengineers/pbapi/community-additions/` folder, create a new file with:
- **Name:** Same as the HTML filename, but with `.md` extension
- **Example:** `Sandbox.ModAPI.Ingame.IMyProgrammableBlock.md`

### 4. Write Your Content

Use standard Markdown syntax. Your content will be added to the page under a "Community Contributions" heading.

**Example:**

```markdown
## Quick Example

Here's how to use Run() with argument handling:

\`\`\`csharp
public void Main(string argument)
{
    if (string.IsNullOrEmpty(argument))
    {
        Echo("No argument provided!");
        return;
    }
    
    // Process argument
    Echo($"Received: {argument}");
}
\`\`\`

## Common Pitfalls

⚠️ **Warning:** Don't forget these important points:

- Always check for null before accessing properties
- The PB has a 100,000 instruction limit per tick
- Use `Echo()` for debugging, not exceptions

## Best Practices

1. **Cache references** - Don't call `GridTerminalSystem.GetBlockWithName()` every tick
2. **Use state machines** - Break long operations across multiple ticks
3. **Handle errors gracefully** - Wrap risky code in try-catch blocks
```

### 5. Submit a Pull Request

1. Fork the repository
2. Add your markdown file to `www/spaceengineers/pbapi/community-additions/`
3. Commit your changes
4. Open a Pull Request

The GitHub Actions workflow will automatically inject your contribution into the HTML page when merged.

## File Naming Rules

- **Match exactly:** Use the same filename as the HTML page (without extension)
- **Case-sensitive:** `IMyProgrammableBlock.md` ≠ `imyprogrammableblock.md`
- **Include namespace:** Use the full path like `Sandbox.ModAPI.Ingame.IMyProgrammableBlock.md`
- **Works for members too:** You can target specific methods like `IMyProgrammableBlock@Run.md`

## Content Guidelines

### ✅ Good Contributions

- Practical, working code examples
- Clear explanations of complex concepts
- Real-world use cases
- Performance comparisons
- Links to helpful external resources

### ❌ Avoid

- Incorrect or untested code
- Very basic examples (covered in official docs)
- Opinion pieces without practical value
- Promotional content
- Duplicate information already on the page

## Markdown Features Supported

All standard Markdown is supported via Markdig:

- **Headers:** `## Heading`
- **Code blocks:** ` ```csharp ... ``` `
- **Inline code:** `` `code` ``
- **Lists:** Ordered and unordered
- **Links:** `[text](url)`
- **Bold/Italic:** `**bold**` and `*italic*`
- **Blockquotes:** `> quote`
- **Tables:** GitHub-flavored markdown tables

## Example Contributions

Check out these examples for inspiration:

- `Sandbox.ModAPI.Ingame.IMyProgrammableBlock.md` - Shows various content types
- `VRageMath.Vector3D.md` - Math examples and common operations

## Review Process

1. **Automated injection** - The GitHub Actions workflow runs when you create a PR
2. **Manual review** - Maintainers will review your contribution for quality and accuracy
3. **Feedback** - You may receive comments requesting changes
4. **Merge** - Once approved, your contribution goes live!

## Questions?

If you have questions or need help:

- Open an issue on GitHub
- Check existing community contributions for examples
- Review this guide carefully

---

**Thank you for helping make Space Engineers scripting documentation better for everyone!** 🚀
