using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Utilities;

/// <summary>
/// Extensions for <see cref="String"/>.
/// </summary>
[PublicAPI]
public static class StringExtensions
{
    /// <summary>
    /// Converts the first character of <paramref name="subject"/> to uppercase.
    /// </summary>
    /// <param name="subject">The input <see cref="String"/>.</param>
    /// <returns>A <see cref="String"/> with the first character converted to uppercase. If the <paramref name="subject"/> is null or empty, the original <paramref name="subject"/> will be returned.</returns>
    public static string? ToUppercaseFirst([NotNullIfNotNull(nameof(subject))] this string? subject)
    {
        if (!string.IsNullOrEmpty(subject) && subject.Length == 1)
        {
            return subject.ToUpperInvariant();
        }

        if (!string.IsNullOrEmpty(subject) && subject.Length >= 2)
        {
            return subject.Substring(0, 1).ToUpperInvariant() + subject.Substring(1);
        }

        return subject;
    }
        
    /// <summary>
    /// Removes <paramref name="prefix"/> from <paramref name="subject"/> input.
    /// </summary>
    /// <param name="subject">The input <see cref="String"/>.</param>
    /// <param name="prefix">The prefix <see cref="String"/> to remove, if it exists.</param>
    /// <returns>A <see cref="String"/> with the <paramref name="prefix"/> removed. If the <paramref name="subject"/> or <paramref name="prefix"/> is null or empty, the original <paramref name="subject"/> will be returned.</returns>
    public static string? RemovePrefix([NotNullIfNotNull("subject")] this string? subject, string prefix)
    {
        if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(prefix) || !subject.StartsWith(prefix))
        {
            return subject;
        }
            
        var prefixLength = prefix.Length;
        return subject.Substring(prefixLength, subject.Length - prefixLength);
    }
        
    /// <summary>
    /// From <paramref name="subject"/> input, retrieve the substring before <paramref name="delimiter"/>.
    /// </summary>
    /// <param name="subject">The input <see cref="String"/>.</param>
    /// <param name="delimiter">The delimiter <see cref="String"/>.</param>
    /// <param name="comparisonType">The <see cref="StringComparison"/> to use when comparing strings.</param>
    /// <returns>The substring of <paramref name="subject"/>, before <paramref name="delimiter"/> removed. If the <paramref name="subject"/> or <paramref name="delimiter"/> is null or empty, or the <paramref name="subject"/> does not contain <paramref name="delimiter"/>, the original <paramref name="subject"/> will be returned.</returns>
    public static string? SubstringBefore([NotNullIfNotNull("subject")] this string? subject, string delimiter, StringComparison comparisonType = StringComparison.CurrentCulture)
    {
        if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(delimiter))
        {
            return subject;
        }

        var indexOf = subject.IndexOf(delimiter, comparisonType);
        return indexOf < 0 
            ? subject 
            : subject.Substring(0, indexOf);
    }
}