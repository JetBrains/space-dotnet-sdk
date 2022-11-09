using System.Reflection;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Extension methods for <see cref="Enum"/>.
/// </summary>
[PublicAPI]
public static class EnumMemberExtensions
{
    /// <summary>
    /// Get string representation of a <see cref="Enum"/> value, taking into account <see cref="EnumMemberAttribute"/> when present.
    /// </summary>
    /// <param name="type">Enum value type.</param>
    /// <typeparam name="T">Enum type.</typeparam>
    /// <returns>String representation of the enum value type, taking into account <see cref="EnumMemberAttribute"/> when present.</returns>
    public static string ToEnumString<T>(this T type)
        where T : Enum
    {
        var enumType = typeof(T);
        var field = enumType.GetField(enumType.GetEnumName(type)!);
        if (field != null)
        {
            var enumMemberAttribute = field.GetCustomAttribute<EnumMemberAttribute>(true);
            return enumMemberAttribute?.Value ?? type.ToString();
        }

        return type.ToString();
    }

    /// <summary>
    /// Get string representation of a <see cref="Enum"/> value, taking into account <see cref="EnumMemberAttribute"/> when present.
    /// </summary>
    /// <param name="type">Enum value type.</param>
    /// <typeparam name="T">Enum type.</typeparam>
    /// <returns>String representation of the enum value type, taking into account <see cref="EnumMemberAttribute"/> when present. Returns <value>""</value> when the enum value is <value>null</value>.</returns>
    public static string ToEnumString<T>(this T? type)
        where T : struct, Enum
    {
        return type == null
            ? string.Empty
            : type.Value.ToEnumString();
    }
}