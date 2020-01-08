using System.Text.Json.Serialization;

namespace SpaceDotNet.Client
{
    /// <summary>
    /// Represents an error retrieved from Space.
    /// </summary>
    public class SpaceError
    {
        /// <summary>
        /// Short description of the error.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }
        
        /// <summary>
        /// Full description of the error.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string Description { get; set; }
    }
}