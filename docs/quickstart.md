# Quickstart

### Defining an Entity

```csharp
public class Order : Entity, IAggregateRoot
{
    public OrderId Id { get; private set; }

    public void Confirm()
    {
        CheckRule(new OrderMustHaveItemsRule(this));
        AddDomainEvent(new OrderConfirmedDomainEvent(Id));
    }
}
```

### Defining a Value Object

```csharp
public sealed class Money : ValueObject
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        CheckRule(new CurrencyMustBeValidRule(currency));

        Amount = amount;
        Currency = currency;
    }
}

