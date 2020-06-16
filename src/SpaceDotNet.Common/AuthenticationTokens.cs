using System;

namespace SpaceDotNet.Common
{
    public class AuthenticationTokens
    {
        public AuthenticationTokens(string? accessToken, string? refreshToken = null, DateTimeOffset? expires = null)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Expires = expires;
        }

        public string? AccessToken { get; }
        public string? RefreshToken { get; }
        public DateTimeOffset? Expires { get; }

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