using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Extension methods for <see cref="bool"/>.
    /// </summary>
    [PublicAPI]
    public static class BoolExtensions
    {
        /// <summary>
        /// Converts the boolean value of this <paramref name="subject"/> to a <see cref="string"/>.
        /// </summary>
        /// <param name="subject">The <see cref="long"/> input.</param>
        /// <param name="format">The format string. Currently supported is "l", which returns a lowercase string.</param>
        /// <returns>A <see cref="string"/> from <paramref name="subject"/>.</returns>
        public static string ToString(this bool subject, string? format)
        {
            if (!string.IsNullOrEmpty(format) && format == "l")
            {
                return subject ? "true" : "false";
            }

            return subject.ToString();
        }
    }
}