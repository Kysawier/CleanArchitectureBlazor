namespace CleanArchitecture.Domain.Abstractions.Exceptions;

public class DomainException(string message) : Exception(message);