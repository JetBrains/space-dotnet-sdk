using JetBrains.Annotations;

namespace JetBrains.Space.Client;

/// <summary>
/// Represents a permission scope element.
/// </summary>
[PublicAPI]
public class PermissionScopeElement
{
    /// <summary>
    /// The context in which the permission applies.
    /// </summary>
#if NET6_0_OR_GREATER
    public PermissionContextIdentifier Context { get; init; }
#else
    public PermissionContextIdentifier Context { get; set; }
#endif

    /// <summary>
    /// The permission identifier.
    /// </summary>
#if NET6_0_OR_GREATER
    public PermissionIdentifier Permission { get; init; }
#else
    public PermissionIdentifier Permission { get; set; }
#endif

    /// <summary>
    /// Creates a new <see cref="PermissionScopeElement"/>.
    /// </summary>
#pragma warning disable CS8618
    public PermissionScopeElement()
#pragma warning restore CS8618
    {
    }

    /// <summary>
    /// Creates a new <see cref="PermissionScopeElement"/>.
    /// </summary>
    /// <param name="context">The context in which the permission applies.</param>
    /// <param name="permission">The permission identifier.</param>
    public PermissionScopeElement(
        PermissionContextIdentifier context,
        PermissionIdentifier permission)
    {
        Context = context;
        Permission = permission;
    }
}
