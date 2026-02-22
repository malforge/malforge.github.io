# GitHub Copilot Instructions for malforge.github.io

## Project Scope

- This repository generates and publishes **unofficial Space Engineers API reference docs** for:
  - Programmable Block API (`docs\spaceengineers\pbapi`)
  - Mod API (`docs\spaceengineers\modapi`)
- The source generators live in `Source\DocGen` and `Source\MdkApiGen`; `docs\` is generated output.

## Git Commit Policy

**CRITICAL: Never commit changes to the git repository without explicit user permission.**

- Do NOT run `git add`, `git commit`, `git push`, or any other git commands that modify the repository history
- You may run read-only git commands like `git status`, `git diff`, `git log`, etc.
- Always wait for the user to explicitly request a commit before proceeding
- When changes are ready, inform the user and ask if they would like to commit them
- This applies to every single commit - there are no exceptions or automatic commits allowed

## General Guidelines

- Make minimal, surgical changes to achieve the requested goal
- Validate changes don't break existing functionality
- Use ecosystem tools when appropriate

## Build, Test, and Local Run Commands

- Build both generator binaries (primary workflow):
  - `.\build.ps1`
- Regenerate PB + Mod API content and site pages:
  - `.\generate-wiki.ps1`
- Serve generated docs locally:
  - `.\serve.ps1` (serves `docs\` at `http://localhost:8080`)
- Build/test via solution directly:
  - `dotnet test .\Source\Malforge.sln -c Release -p:Platform=x64`
- Single-test command:
  - No test projects currently exist in this repository, so there is no per-test command yet.
- Lint command:
  - No dedicated lint target is currently defined.

## High-Level Architecture

1. **Doc extraction stage (`DocGen`, .NET Framework 4.8)**
   - Entrypoint: `Source\DocGen\Program.cs`
   - Reads Space Engineers assemblies + XML docs and whitelist/terminal cache inputs.
   - Generates markdown/API data (`api`, `terminals`, `sprites`, `types`, `json` commands).
   - Uses `.docgen-manifest.json` to skip unchanged generations unless `--force` is used.

2. **Site/index stage (`MdkApiGen`, .NET 8)**
   - Entrypoint: `Source\MdkApiGen\Program.cs`
   - Converts generated markdown into HTML pages and API index/search outputs.
   - Supports API mode switching via `--api-type pb|mod`.
   - Writes `.mdkapigen` manifest and only cleans/rewrites tracked generated files.

3. **Pipeline orchestration (repo root scripts)**
   - `build.ps1` publishes both tools into `bin\`.
   - `generate-wiki.ps1` runs DocGen first (`input\pb`, `input\mod`), then MdkApiGen to final docs output.

## Key Repository Conventions

- Run generation scripts from repo root; they depend on root-level data files (`pbwhitelist.dat`, `modwhitelist.dat`, `terminal.dat`, `docgen-overrides.txt`).
- Default file lookup pattern in both generators: current working directory first, then executable directory (`FileHelpers.FindDefaultFile`).
- For PB/Mod index pages, custom root markdown files are `_pb-index.md` and `_mod-index.md`; `_searchfeedback.md` is used for search guidance text.
- `MdkApiGen.csproj` copies template/static assets (`*.css`, `*.js`, `*.html`, `*.png`) via `PreserveNewest`; avoid manual copy steps in scripts.
- `DocGen` supports multi-command invocation as a comma-separated first argument (for example `api,terminals,sprites,types,json`), which is the expected batch pattern in this repo.
