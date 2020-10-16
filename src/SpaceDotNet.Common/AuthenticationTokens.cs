using System;
using JetBrains.Annotations;

namespace SpaceDotNet.Common
{
    /// <summary>
    /// A class that represents authentication tokens.
    /// </summary>
    [PublicAPI]
    public class AuthenticationTokens
    {
        /// <summary>
        /// Creates a new <see cref="AuthenticationTokens"/> instance.
        /// </summary>
        /// <param name="accessToken">The access token value.</param>
        /// <param name="refreshToken">The refresh token value.</param>
        /// <param name="expires">The expiration time of the current <paramref name="accessToken"/>.</param>
        public AuthenticationTokens(string? accessToken, string? refreshToken = null, DateTimeOffset? expires = null)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Expires = expires;
        }

        /// <summary>
        /// Get the access token value.
        /// </summary>
        public string? AccessToken { get; }
        
        /// <summary>
        /// Get the refresh token value.
        /// </summary>
        public string? RefreshToken { get; }
        
        /// <summary>
        /// Get the expiration time of the current <see cref="AccessToken"/>.
        /// </summary>
        public DateTimeOffset? Expires { get; }

        /// <summary>
        /// Check whether the <see cref="AccessToken"/> is expired based on <see cref="Expires"/>.
        /// </summary>
        /// <returns><see langword="true"/> when the <see cref="AccessToken"/> is expired based on <see cref="Expires"/>; <see langword="false"/> otherwise.</returns>
        public bool HasExpired()
        {
            if (Expires.HasValue)
            {
                return Expires < DateTime.UtcNow.AddMinutes(1);
            }
            
            return false;
        }
    }
}