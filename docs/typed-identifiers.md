# Typed Identifiers

Typed identifiers provide **strongly-typed IDs** backed by `Guid`.

They help prevent:

* Accidental ID mixing
* Primitive obsession
* Ambiguous method signatures

Example:

```csharp
public sealed class OrderId : TypedIdValueBase
{
    public OrderId(Guid value) : base(value) { }
}
```