using CleanArchitecture.Domain.Abstractions.Entities;

namespace CleanArchitecture.Domain.Abstractions.DomainEvents;

public class AggregateRoot : EntityBase
{
    // Probably doing smt with EF Core
    protected AggregateRoot() : this(Guid.NewGuid()) { } 
    protected AggregateRoot(Guid id) => Id = id;

    private readonly List<DomainEvent> _domainEvents = new();
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(DomainEvent eventItem) => _domainEvents.Add(eventItem);

    public void ClearDomainEvents() => _domainEvents.Clear();

}