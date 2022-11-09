using System.Collections.Concurrent;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common.Json.Serialization.Polymorphism;

/// <summary>
/// Utility for working with Space API instances that expose a className JSON property.
/// </summary>
internal static class ClassNameTypeUtility
{
    // ReSharper disable once StaticMemberInGenericType
    private static readonly ConcurrentDictionary<string, Type> TypeMap = new(StringComparer.OrdinalIgnoreCase);
    
    /// <summary>
    /// The namespace name containing common classes for JetBrains.Space.
    /// </summary>
    internal const string SpaceDotNetCommonNamespace = "JetBrains.Space.Common";
    
    /// <summary>
    /// The namespace name containing generated classes for JetBrains.Space.
    /// </summary>
    internal const string SpaceDotNetClientNamespace = "JetBrains.Space.Client";

    /// <summary>
    /// The assembly name containing generated classes for JetBrains.Space.
    /// </summary>
    // ReSharper disable once MemberCanBePrivate.Global
    internal const string SpaceDotNetClientAssemblyName = "JetBrains.Space.Client";

    static ClassNameTypeUtility()
    {
        // Redirect HA_InlineError.* to JetBrains.Space.Common types
        TypeMap.TryAdd("HA_InlineError", typeof(ApiInlineError));
        TypeMap.TryAdd("HA_InlineError.InaccessibleFields", typeof(ApiInlineErrorInaccessibleFields));
    }

    public static bool TryResolve(string className, string spaceDotNetCSharpTypeName, out Type? targetType)
    {
        // Try resolve from cache
        if (TypeMap.TryGetValue(className, out targetType)) return true;
        
        // Try resolve from type system
        targetType = Type.GetType(spaceDotNetCSharpTypeName);
        if (targetType != null)
        {
            TypeMap[className] = targetType;
            return true;
        }

        return false;
    }
}