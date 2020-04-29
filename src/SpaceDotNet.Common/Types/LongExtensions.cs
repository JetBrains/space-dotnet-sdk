using System;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public static class LongExtensions
    {
        public static DateTime AsDateTime(this long subject) => DateTimeOffset.FromUnixTimeMilliseconds(subject).DateTime;
    }
}