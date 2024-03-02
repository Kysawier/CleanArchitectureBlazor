using System.Runtime.CompilerServices;

namespace CleanArchitecture.Domain.Abstractions.Guards;

public static partial class GuardClauseExtensions 
{
    public static string NullOrEmpty(
        this IGuardClause guardClause,
        string input,
        [CallerArgumentExpression($"{nameof(input)}")]
        string? paramName = null,
        string? message = null)
    {
        if (string.IsNullOrEmpty(input)) Error(message ?? $"Required input {paramName} is missing.");
        return input;
    }
    
}