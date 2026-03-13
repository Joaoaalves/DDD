# Claude Code Skill

Joaoaalves.DDD ships a **Claude Code slash command** that gives any AI assistant in your project full, up-to-date knowledge of the library's API and documentation.

Once installed, invoking `/ddd` loads the complete library context — building blocks, patterns, documentation map, and guidance on how to use each feature correctly.

---

## What the skill does

When you run `/ddd` in Claude Code, the assistant:

- Knows every building block provided by the library and its purpose
- Knows exactly which documentation page to fetch for each topic
- Provides library-specific code examples instead of generic DDD advice
- Checks your implementation against common pitfalls and design guidelines

---

## Installation

Run this command at the root of your project:

```bash
mkdir -p .claude/commands && curl -fsSL https://raw.githubusercontent.com/Joaoaalves/DDD/main/.claude/commands/ddd.md -o .claude/commands/ddd.md
```

This downloads the skill file into `.claude/commands/ddd.md`, which is the location Claude Code looks for custom slash commands.

> The skill file is maintained in the library repository, so you can re-run the command at any time to get the latest version.

---

## Usage

Open Claude Code in your project and type:

```
/ddd
```

The assistant will load the full library context and ask what you need help with.

### Example prompts after invoking `/ddd`

- *"Help me model an Order aggregate with items and a total price"*
- *"How should I implement a business rule that prevents confirming an empty order?"*
- *"Review my entity — am I doing anything wrong?"*
- *"What's the difference between a domain event and an integration event in this library?"*

---

## What gets installed

The skill is a single Markdown file (`.claude/commands/ddd.md`) that contains:

- A summary of the library's building blocks and patterns
- A map of every documentation section and its fetchable URL
- Instructions for the assistant on how to help with implementation, design review, and debugging

No code is executed during installation. The file is read-only context for the AI assistant.
