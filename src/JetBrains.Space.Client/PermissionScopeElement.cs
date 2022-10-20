using JetBrains.Annotations;

namespace JetBrains.Space.Client;

/// <summary>
/// Represents a permission scope element.
/// </summary>
[PublicAPI]
public class PermissionScopeElement
{
    /// <summary>
    /// THe context in which the permission applies.
    /// </summary>
    public PermissionContextIdentifier Context { get; set; } 
    
    /// <summary>
    /// The permission identifier.
    /// </summary>
    public PermissionIdentifier Permission { get; set; }
}