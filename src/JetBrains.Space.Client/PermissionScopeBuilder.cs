using System.Linq;
using JetBrains.Annotations;
using JetBrains.Space.Common;

namespace JetBrains.Space.Client;

/// <summary>
/// Utility class to create new <see cref="PermissionScope"/>.
/// </summary>
[PublicAPI]
public static class PermissionScopeBuilder
{
    /// <summary>
    /// Build a <see cref="PermissionScope"/> based on a set of <see cref="PermissionScopeElement"/>.
    /// </summary>
    /// <param name="elements">The <see cref="PermissionScopeElement"/> to build a scope for.</param>
    /// <returns>A <see cref="PermissionScope"/> that represents the set of <see cref="PermissionScopeElement"/>.</returns>
    public static PermissionScope Build(params PermissionScopeElement[] elements) =>
        new(string.Join(" ", elements.Select(
            // ReSharper disable once RedundantToStringCall
            it => it.Context.ToString() + ":" + it.Permission.ToString())));
}