using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents a permission scope.
/// </summary>
[PublicAPI]
public class PermissionScope
{
    /// <summary>
    /// All permissions scope ("**")
    /// </summary>
    public static readonly PermissionScope All = new("**");

    private readonly string _scope;

    /// <summary>
    /// Creates a new <see cref="PermissionScope"/> instance.
    /// </summary>
    /// <param name="scope">String representation of the scope.</param>
    public PermissionScope(string scope)
    {
        _scope = scope;
    }

    /// <summary>
    /// Implicit conversion from <see cref="PermissionScope"/> to a <see cref="string"/> representation.
    /// Ths conversion makes permission scopes compatible with ASP.NET Scope implementations.
    /// </summary>
    /// <param name="scope">The <see cref="PermissionScope"/> to convert.</param>
    /// <returns>The <see cref="string"/> representation for the scope.</returns>
    public static implicit operator string(PermissionScope scope) => scope.ToString();

    /// <inheritdoc />
    public override int GetHashCode() => _scope.GetHashCode();

    /// <inheritdoc />
    public override string ToString() => _scope;
}
