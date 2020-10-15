using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class SpaceDate : IComparable<SpaceDate>, IComparable
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; } = default!;
        
        [JsonPropertyName("year")]
        public int Year { get; set; }
        
        [JsonPropertyName("month")]
        public int Month { get; set; }
        
        [JsonPropertyName("day")]
        public int Day { get; set; }

        public DateTime AsDateTime() => new DateTime(Year, Month, Day);

        /// <inheritdoc />
        public override string ToString()
        {
            return AsDateTime().ToString("yyyy-MM-dd");
        }

        protected bool Equals(SpaceDate other)
        {
            return string.Equals(Iso, other.Iso, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SpaceDate) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(Iso);
        }

        /// <summary>
        /// Determines whether the specified object instances are considered equal.</summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns>
        /// <see langword="true" /> if the objects are considered equal; otherwise, <see langword="false" />.
        /// </returns>
        public static bool operator ==(SpaceDate? left, SpaceDate? right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether the specified object instances are considered unequal.</summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns>
        /// <see langword="true" /> if the objects are considered equal; otherwise, <see langword="false" />.
        /// </returns>
        public static bool operator !=(SpaceDate? left, SpaceDate? right)
        {
            return !Equals(left, right);
        }

        /// <inheritdoc />
        public int CompareTo(SpaceDate? other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(Iso, other.Iso, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc />
        public int CompareTo(object? obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            return obj is SpaceDate other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(SpaceDate)}");
        }
    }
}