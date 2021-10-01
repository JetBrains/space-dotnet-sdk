using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// A class that defines an enumeration of values.
/// Inheritors can define the main value, and add extra properties when needed.
/// </summary>
[PublicAPI]
public abstract class Enumeration : IComparable
{
    /// <summary>
    /// Get the value of this <see cref="Enumeration"/>.
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Creates a new <see cref="Enumeration"/> instance.
    /// </summary>
    /// <param name="value">The value of this <see cref="Enumeration"/>.</param>
    protected Enumeration(string value)
    {
        Value = value;
    }

    /// <inheridoc />
    public override string ToString() => Value;

    /// <summary>
    /// Returns all potential values of an <see cref="Enumeration"/>.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="Enumeration"/>.</typeparam>
    /// <returns>All values of the <see cref="Enumeration"/></returns>
    public static IEnumerable<T> GetAll<T>() where T : Enumeration
    {
        var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

        return fields.Select(f => f.GetValue(null)).Cast<T>();
    }
        
    /// <summary>
    /// Creates a <see cref="Enumeration"/> value from a given <see cref="String"/> value.
    /// </summary>
    /// <param name="value">The value string to create a <see cref="Enumeration"/> value from.</param>
    /// <typeparam name="T">The type of <see cref="Enumeration"/>.</typeparam>
    /// <returns>The <see cref="Enumeration"/> value for the given <paramref name="value"/>.</returns>
    public static T? FromValue<T>(string value) where T : Enumeration
    {
        var matchingItem = GetAll<T>().FirstOrDefault(it => string.Equals(it.Value, value, StringComparison.OrdinalIgnoreCase));
        return matchingItem;
    }
        
    /// <summary>
    /// Creates a <see cref="Enumeration"/> value from a given <see cref="String"/> value.
    /// </summary>
    /// <param name="enumerationType">The type of <see cref="Enumeration"/>.</param>
    /// <param name="value">The value string to create a <see cref="Enumeration"/> value from.</param>
    /// <returns>The <see cref="Enumeration"/> value for the given <paramref name="value"/>.</returns>
    public static Enumeration? FromValue(Type enumerationType, string value)
    {
        var fields = enumerationType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            
        var matchingItem = fields
            .Select(f => f.GetValue(null))
            .Cast<Enumeration>()
            .FirstOrDefault(it => string.Equals(it.Value, value, StringComparison.OrdinalIgnoreCase));
        return matchingItem;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        var otherValue = obj as Enumeration;

        if (otherValue == null)
        {
            return false;
        }

        var typeMatches = GetType() == obj?.GetType();
        var valueMatches = Value.Equals(otherValue.Value);

        return typeMatches && valueMatches;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        // ReSharper disable once NonReadonlyMemberInGetHashCode
        return StringComparer.OrdinalIgnoreCase.GetHashCode(Value);
    }
        
    /// <summary>
    /// Determines whether the specified object instances are considered equal.</summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>
    /// <see langword="true" /> if the objects are considered equal; otherwise, <see langword="false" />.
    /// </returns>
    public static bool operator ==(Enumeration? left, Enumeration? right)
    {
        return Equals(left, right);
    }

    /// <summary>
    /// Determines whether the specified object instances are considered unequal.</summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>
    /// <see langword="true" /> if the objects are considered unequal; otherwise, <see langword="false" />.
    /// </returns>
    public static bool operator !=(Enumeration? left, Enumeration? right)
    {
        return !Equals(left, right);
    }

    /// <inheritdoc />
    public int CompareTo(object? other) => string.Compare(Value, (other as Enumeration)?.Value, StringComparison.OrdinalIgnoreCase);
}