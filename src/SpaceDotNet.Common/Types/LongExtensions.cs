using System;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Extension methods for <see cref="long"/>.
    /// </summary>
    [PublicAPI]
    public static class LongExtensions
    {
        /// <summary>
        /// Convert a <see cref="long"/> into a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="subject">The <see cref="long"/> input.</param>
        /// <returns>A <see cref="DateTime"/> from <paramref name="subject"/>.</returns>
        public static DateTime AsDateTime(this long subject) => DateTimeOffset.FromUnixTimeMilliseconds(subject).DateTime;
    }
}