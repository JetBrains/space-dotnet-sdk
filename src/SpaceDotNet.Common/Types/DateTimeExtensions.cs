using System;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public static class DateTimeExtensions
    {
        public static SpaceDate AsSpaceDate(this DateTime subject) =>
            new SpaceDate
            {
                Iso = subject.ToString("yyyy-MM-dd"),
                Year = subject.Year,
                Month = subject.Month,
                Day = subject.Day
            };

        public static SpaceTime AsSpaceTime(this DateTime subject) =>
            new SpaceTime
            {
                Iso = subject.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                Timestamp = new DateTimeOffset(subject).ToUnixTimeMilliseconds()
            };
    }
}