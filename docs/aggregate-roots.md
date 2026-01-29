# Aggregate Roots

Aggregate roots are **consistency boundaries**.

In Joaoaalves.DDD, an aggregate root is represented by:

* A domain entity
* That implements the `IAggregateRoot` marker interface

The marker interface is intentionally empty and exists to:

* Make aggregate boundaries explicit
* Enable compile-time constraints in repositories or application layers
