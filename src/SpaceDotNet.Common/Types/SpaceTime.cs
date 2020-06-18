using System;
using System.Globalization;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class SpaceTime : IComparable<SpaceTime>, IComparable
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; } = default!;
        
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        public DateTime AsDateTime() => Timestamp.AsDateTime();

        public override string ToString() => AsDateTime().ToString("s", CultureInfo.InvariantCulture);

        protected bool Equals(SpaceTime other)
        {
            return string.Equals(Iso, other.Iso, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SpaceTime) obj);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(Iso);
        }

        public static bool operator ==(SpaceTime? left, SpaceTime? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SpaceTime? left, SpaceTime? right)
        {
            return !Equals(left, right);
        }

        public int CompareTo(SpaceTime? other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(Iso, other.Iso, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(object? obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            return obj is SpaceTime other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(SpaceTime)}");
        }
    }
}