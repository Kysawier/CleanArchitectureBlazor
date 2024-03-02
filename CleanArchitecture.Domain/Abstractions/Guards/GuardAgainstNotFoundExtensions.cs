namespace CleanArchitecture.Domain.Abstractions.Guards;

public static partial class GuardClauseExtensions
{
    public static T NotNull<T>(
        this IGuardClause guardClause, 
        T? aggregate, 
        string? message = null) where T : class
    {
        if (aggregate is null) Error(message ?? "Not found");
        return aggregate!;
    }
    
}