using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents a permission scope.
/// </summary>
[PublicAPI]
[JsonConverter(typeof(UrlParameterConverter))]
public class PermissionScope : IUrlParameter
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
    public static implicit operator string(PermissionScope scope) => scope._scope;

    /// <inheritdoc />
    public override int GetHashCode() => _scope.GetHashCode();

    /// <inheritdoc />
    public override string ToString() => _scope;

    /// <summary>
    /// Combines two <see cref="PermissionScope"/>.
    /// </summary>
    /// <param name="first">The first <see cref="PermissionScope"/> to combine.</param>
    /// <param name="second">The second <see cref="PermissionScope"/> to combine.</param>
    /// <returns>The combined <see cref="PermissionScope"/>.</returns>
    public static PermissionScope operator +(PermissionScope first, PermissionScope second) => first.Combine(second);

    /// <summary>
    /// Combines a <see cref="PermissionScope"/> with the current scope.
    /// </summary>
    /// <param name="other"><see cref="PermissionScope"/> to combine with the current scope.</param>
    /// <returns>The combined <see cref="PermissionScope"/>.</returns>
    public PermissionScope Combine(PermissionScope other)
    {
        var scopes = !string.IsNullOrEmpty(_scope)
            ? new HashSet<string>(_scope.Split(' ', StringSplitOptions.RemoveEmptyEntries), StringComparer.OrdinalIgnoreCase)
            : new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var otherScope in other._scope.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            scopes.Add(otherScope);
        }

        return new PermissionScope(string.Join(' ', scopes));
    }
}