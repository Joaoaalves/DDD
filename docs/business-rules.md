# Business Rules

Business rules encapsulate **domain invariants**.

Each rule implements `IBusinessRule` and defines:

* When the rule is broken
* Why it is broken

Rules are enforced via `CheckRule`, which throws a `BusinessRuleValidationException`.
