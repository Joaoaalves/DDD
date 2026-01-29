# Introduction

**Joaoaalves.DDD** is a lightweight .NET library that provides foundational building blocks for implementing **Domain-Driven Design (DDD)**.

It focuses on modeling **pure domain concerns**, such as entities, value objects, aggregate roots, domain events, and business rules, without introducing infrastructure dependencies or architectural constraints.

It is **not a framework**.
Joaoaalves.DDD does not enforce application structure, persistence strategies, or execution flows. Instead, it offers a **minimal and explicit domain model foundation** that can be composed with different architectural styles and infrastructure choices.

The primary goal of the library is to **reduce boilerplate and inconsistency** when implementing DDD patterns, while preserving full control over the domain model.

Joaoaalves.DDD is designed to support systems that adopt:

* Domain-Driven Design (DDD)
* Clean Architecture
* Hexagonal / Ports & Adapters Architecture
* Modular monoliths and microservices

---

## Design Intent

Joaoaalves.DDD is intentionally **small, explicit, and infrastructure-agnostic**.

The library focuses exclusively on **domain modeling primitives**, leaving concerns such as persistence, messaging, transactions, and orchestration to other layers or packages.

Key design principles:

* No runtime magic
* No reflection-based domain behavior
* No persistence assumptions
* No coupling to application or infrastructure layers

Everything provided by Joaoaalves.DDD is meant to live safely inside the **Domain layer**.

---

## Scope

Joaoaalves.DDD provides:

* Base abstractions for **Entities** and **Aggregate Roots**
* A robust implementation for **Value Objects**
* Support for **strongly-typed identifiers**
* A simple and explicit **Domain Events** model
* A **Business Rules** mechanism for enforcing invariants

Out of scope by design:

* Repositories
* Persistence mapping
* Transactions
* Messaging infrastructure
* Event dispatching
* Application services

These concerns are expected to be handled by higher-level packages (such as CQRS or application layers) or external libraries.

---

## Architectural Context

Joaoaalves.DDD fits naturally into architectures where:

* The **Domain layer is isolated**
* Business logic is protected from infrastructure concerns
* Aggregates enforce their own invariants
* Domain events represent meaningful business occurrences

It can be used as:

* The domain foundation of a CQRS-based system
* The core model of a modular monolith
* The domain layer of an independent microservice

Joaoaalves.DDD makes no assumptions about how the domain is executed — only how it is **modeled**.

---

## Package Overview

The package is organized around common DDD concepts:

* **Common**

  * Entity base class
  * Aggregate root marker
  * Value object base class
  * Typed identifiers
* **Events**

  * Domain event contracts
* **Rules**

  * Business rule abstractions
  * Validation exception