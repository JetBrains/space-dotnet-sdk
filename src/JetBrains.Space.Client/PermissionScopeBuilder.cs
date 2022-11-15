using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    /// Build a <see cref="PermissionScope"/> based on a <see cref="PermissionScopeElement"/>.
    /// </summary>
    /// <param name="element">The <see cref="PermissionScopeElement"/> to build a scope for.</param>
    /// <returns>A <see cref="PermissionScope"/> that represents the set of <see cref="PermissionScopeElement"/>.</returns>
    [SuppressMessage("ReSharper", "RedundantToStringCall")]
    public static PermissionScope FromElement(PermissionScopeElement element) =>
        new($"{element.Context}:{element.Permission}");

    /// <summary>
    /// Build a <see cref="PermissionScope"/> based on a set of <see cref="PermissionScopeElement"/>.
    /// </summary>
    /// <param name="elements">The enumerable of <see cref="PermissionScopeElement"/> to build a scope for.</param>
    /// <returns>A <see cref="PermissionScope"/> that represents the set of <see cref="PermissionScopeElement"/>.</returns>
    [SuppressMessage("ReSharper", "RedundantToStringCall")]
    public static PermissionScope FromElements(IEnumerable<PermissionScopeElement> elements) =>
        new(string.Join(" ", elements.Select(
            it => it.Context.ToString() + ":" + it.Permission.ToString())));

    /// <summary>
    /// Build a <see cref="PermissionScope"/> based on a set of <see cref="PermissionScopeElement"/>.
    /// </summary>
    /// <param name="elements">The <see cref="PermissionScopeElement"/> to build a scope for.</param>
    /// <returns>A <see cref="PermissionScope"/> that represents the set of <see cref="PermissionScopeElement"/>.</returns>
    [SuppressMessage("ReSharper", "RedundantToStringCall")]
    public static PermissionScope FromElements(params PermissionScopeElement[] elements) =>
        new(string.Join(" ", elements.Select(
            it => it.Context.ToString() + ":" + it.Permission.ToString())));
}