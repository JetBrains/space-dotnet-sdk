using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Represents an error retrieved from Space.
    /// </summary>
    [PublicAPI]
    public class SpaceError
    {
        /// <summary>
        /// Short description of the error.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; } = default!;
        
        /// <summary>
        /// Full description of the error.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string Description { get; set; } = default!;
    }
}