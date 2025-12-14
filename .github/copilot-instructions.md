# GitHub Copilot Instructions for malforge.github.io

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
