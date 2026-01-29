# Value Objects

Value objects are immutable and compared by **structural equality**.

The `ValueObject` base class provides:

* Automatic equality comparison
* Hash code generation
* Member exclusion via `IgnoreMemberAttribute`

Only public properties and fields participate in equality by default.
