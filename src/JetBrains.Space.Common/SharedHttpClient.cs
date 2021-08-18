using System.Net.Http;
using JetBrains.Annotations;

namespace JetBrains.Space.Common
{
    /// <summary>
    /// Represents a shared <see cref="HttpClient"/> instance that can be used by the Space SDK when no <see cref="HttpClient"/> is provided by consumers.
    /// </summary>
    [PublicAPI]
    public static class SharedHttpClient
    {
        /// <summary>
        /// Shared <see cref="HttpClient"/> instance that can be used by the Space SDK when no <see cref="HttpClient"/> is provided by consumers.
        /// </summary>
        public static readonly HttpClient Instance = new();
    }
}