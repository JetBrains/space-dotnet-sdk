using System.Xml;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Extension methods for <see cref="TimeSpan"/>.
/// </summary>
[PublicAPI]
public static class TimeSpanExtensions
{
    /// <summary>
    /// Converts the TimeSpan value of this <paramref name="subject"/> to a ISO8601 <see cref="string"/>.
    /// </summary>
    /// <param name="subject">The <see cref="TimeSpan"/> input.</param>
    /// <returns>A <see cref="string"/> from <paramref name="subject"/>.</returns>
    public static string ToIsoString(this TimeSpan subject)
    {
        return XmlConvert.ToString(subject);
    }
}