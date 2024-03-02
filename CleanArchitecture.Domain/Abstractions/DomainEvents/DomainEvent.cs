using MediatR;

namespace CleanArchitecture.Domain.Abstractions.DomainEvents;

public abstract record DomainEvent : INotification;