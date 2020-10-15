using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// A class that represents a pair structure.
    /// </summary>
    /// <typeparam name="T">The type that is referenced.</typeparam>
    [PublicAPI]
    public class Reference<T>
    {
        /// <summary>
        /// Get/set the reference identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
    }
}