# Entities

Entities represent domain objects that are **defined by identity**, not by their attributes.

Joaoaalves.DDD provides a base `Entity` class that supports:

* Domain event registration
* Business rule validation

Entities are expected to be mutable and to protect their invariants internally.