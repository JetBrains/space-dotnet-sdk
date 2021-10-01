using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Extension methods for <see cref="NameValueCollection"/>.
/// </summary>
[PublicAPI]
public static class NameValueCollectionExtensions
{
    /// <summary>
    /// Adds an entry with the specified name and value into the <see cref='System.Collections.Specialized.NameValueCollection'/>.
    /// </summary>
    /// <param name="subject">The <see cref="NameValueCollection"/> to add a name/value to.</param>
    /// <param name="name">The name to add.</param>
    /// <param name="value">The value to add.</param>
    /// <returns>The current <see cref="NameValueCollection"/>.</returns>
    public static NameValueCollection Append(this NameValueCollection subject, string? name, string? value)
    {
        subject.Add(name, value);
        return subject;
    }
        
    /// <summary>
    /// Adds a collection of entries with the specified name and values into the <see cref='System.Collections.Specialized.NameValueCollection'/>.
    /// </summary>
    /// <param name="subject">The <see cref="NameValueCollection"/> to add a name/value to.</param>
    /// <param name="name">The name to add.</param>
    /// <param name="values">The values to add.</param>
    /// <returns>The current <see cref="NameValueCollection"/>.</returns>
    public static NameValueCollection Append(this NameValueCollection subject, string? name, IEnumerable<string?> values)
    {
        foreach (var value in values)
        {
            subject.Add(name, value);
        }

        return subject;
    }
        
    /// <summary>
    /// Converts the <see cref="NameValueCollection"/> into a query string representation.
    /// </summary>
    /// <param name="subject">The <see cref="NameValueCollection"/> to build a query string for.</param>
    /// <returns>A query string representation of the current <see cref="NameValueCollection"/>,</returns>
    public static string ToQueryString(this NameValueCollection subject)
    {
        var sb = new StringBuilder();

        foreach (var key in subject.AllKeys)
        {
            if (string.IsNullOrWhiteSpace(key)) continue;

            var values = subject.GetValues(key);
            if (values == null) continue;

            foreach (string value in values)
            {
                sb.Append(sb.Length == 0 ? "?" : "&");
                sb.Append($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value)}");
            }
        }

        return sb.ToString();
    }
}