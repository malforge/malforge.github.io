# Space Engineers Programmable Block API Documentation

This repository contains the **unofficial** API documentation for Space Engineers Programmable Block scripting.

## View the Documentation

Visit the live site: [https://malforge.github.io](https://malforge.github.io) (or your GitHub Pages URL)

## What's Included

- Complete API reference for all PB-accessible classes and methods
- Searchable interface with type/member filtering
- Namespace and type hierarchy navigation
- Community-contributed examples and tips

## Contributing Community Examples

**You can help improve this documentation!** Community members can contribute:

- Code examples
- Usage tips and tricks
- Common pitfalls and solutions
- Best practices
- Performance advice

### How to Contribute

1. Find the API page you want to enhance
2. Copy its filename (e.g., `Sandbox.ModAPI.Ingame.IMyProgrammableBlock`)
3. Create a markdown file in `www/spaceengineers/pbapi/community-additions/` with the same name
4. Write your examples/tips in standard Markdown
5. Submit a Pull Request

** Full Guide:** [Contributing-Community-Examples-And-Tips.md](Contributing-Community-Examples-And-Tips.md)

## Building Locally

This site is generated from Space Engineers game files using custom tooling.

### Prerequisites

- .NET 8 SDK
- Space Engineers installed

### Build Steps

1. Run `generate-wiki.bat` to extract and generate API documentation from the game
2. Run `inject-community.bat` to inject community contributions into the HTML
3. Run `serve.bat` to start a local web server (optional)

## Repository Structure

```
malforge.github.io/
├── Source/
│   ├── MdkApiGen/          # API documentation generator
│   └── CommunityInjector/  # Community contribution injector
├── input/                   # Markdown source files
├── www/                     # Generated website (GitHub Pages serves this)
│   └── spaceengineers/
│       └── pbapi/
│           └── community-additions/  # Community contribution markdown files
└── inject-community.bat     # Script to inject community content locally
```

## ⚠️ Important Notes

- This is a **community-maintained** project, not affiliated with Keen Software House
- For official scripting guides, see the [Space Engineers Wiki](https://spaceengineers.wiki.gg/wiki/Scripting)
- Updates happen in free time - some lag behind game updates is expected

## License

This documentation is provided as-is for the Space Engineers community.
Game content is © Keen Software House.

## Questions or Issues?

- Check the [Contributing Guide](Contributing-Community-Examples-And-Tips.md)
- Open an issue on GitHub
- Review existing community contributions for examples

---

**Built with ❤️ for the Space Engineers community**
