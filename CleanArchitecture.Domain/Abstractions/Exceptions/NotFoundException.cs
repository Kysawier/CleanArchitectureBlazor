namespace CleanArchitecture.Domain.Abstractions.Exceptions;

public sealed class NotFoundException(string message) : Exception(message)
{
    public NotFoundException() : this("NotFound") { }
}