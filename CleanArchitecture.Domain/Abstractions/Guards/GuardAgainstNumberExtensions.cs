using System.Runtime.CompilerServices;

namespace CleanArchitecture.Domain.Abstractions.Guards;

public static partial class GuardClauseExtensions
{
    public static void LessThan(
        this IGuardClause guardClause,
        decimal input,
        decimal minValue,
        [CallerArgumentExpression($"{nameof(input)}")]
        string? paramName = null,
        string units = "",
        string? message = null)
    {
        if (input < minValue) Error(message ?? $"'{paramName}' must be greater than {minValue}{units}.");
    }
    
    public static void ValueOutOfRange(
        this IGuardClause guardClause,
        decimal input,
        decimal minValue,
        decimal maxValue,
        [CallerArgumentExpression($"{nameof(input)}")]
        string? paramName = null,
        string units = "",
        string? message = null)
    {
        if (input < minValue ||
            input > maxValue) Error(message ?? $"'{paramName}' must be greater than {minValue}{units}.");
    }
    
}