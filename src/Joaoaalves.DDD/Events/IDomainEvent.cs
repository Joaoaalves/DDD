namespace Joaoaalves.DDD.Events
{
    /// <summary>
    /// Represents a domain event that indicates something important has happened within the domain.
    /// </summary>
    public interface IDomainEvent
    {
        /// <summary>
        /// Gets the timestamp indicating when the domain event occurred.
        /// </summary>
        DateTime OccurredOn { get; }
    }
}
