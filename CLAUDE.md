# Joaoaalves.DDD

Lightweight .NET library providing Domain-Driven Design building blocks. No external dependencies. No framework constraints. Everything lives inside the Domain layer.

## What This Library Provides

| Type | Namespace | Purpose |
|------|-----------|---------|
| `Entity` | `Joaoaalves.DDD.Common` | Base class for entities — manages domain events and rule enforcement |
| `IAggregateRoot` | `Joaoaalves.DDD.Common` | Marker interface for aggregate roots (consistency boundaries) |
| `ValueObject` | `Joaoaalves.DDD.Common` | Base class for value objects with structural equality |
| `TypedIdValueBase` | `Joaoaalves.DDD.Common` | Base for strongly-typed GUID identifiers |
| `IgnoreMemberAttribute` | `Joaoaalves.DDD.Common` | Excludes a property from `ValueObject` equality comparison |
| `IBusinessRule` | `Joaoaalves.DDD.Rules` | Contract for domain invariants |
| `BusinessRuleValidationException` | `Joaoaalves.DDD.Rules` | Thrown when a business rule is violated |
| `IDomainEvent` | `Joaoaalves.DDD.Events` | Marker interface for domain events |

## Core Patterns

- **Enforce invariants** inside entity methods or value object constructors: `CheckRule(new SomeDomainRule(...))`
- **Raise domain events** inside entity methods: `AddDomainEvent(new SomethingHappenedEvent(...))`
- **Aggregate roots** are entities that implement `IAggregateRoot` — they own their consistency boundary
- **Value objects** should be immutable; use `[IgnoreMember]` to exclude computed/internal properties from equality
- The library **does not dispatch domain events** — that is the infrastructure's responsibility

## Project Structure

```
src/Joaoaalves.DDD/
  Common/        Entity, IAggregateRoot, ValueObject, TypedIdValueBase, IgnoreMemberAttribute
  Events/        IDomainEvent
  Rules/         IBusinessRule, BusinessRuleValidationException

tests/Joaoaalves.DDD.Tests/   Unit tests for all building blocks
docs/                         Documentation (Docsify — served at https://joaoaalves.github.io/DDD)
```

## Documentation

Full documentation: **https://joaoaalves.github.io/DDD**

Raw Markdown sources are in `/docs`. Each file maps directly to its URL path on the docs site (e.g., `docs/entities.md` → `https://joaoaalves.github.io/DDD/entities.md`).

## Claude Code Skill

A Claude Code slash command is available at `.claude/commands/ddd.md`. Run `/ddd` inside Claude Code to get documentation-aware assistance for this library.

To install the skill in a project that uses this library, see [docs/claude-skill.md](docs/claude-skill.md).
