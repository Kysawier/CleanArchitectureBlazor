namespace CleanArchitecture.Domain.Abstractions.Guards;

/// <summary>
/// Used by extension methods to create new GuardClauses
/// </summary>
public interface IGuardClause;

public sealed class Guard : IGuardClause
{
    public static IGuardClause Against { get; } = new Guard();

    private Guard() { }

}