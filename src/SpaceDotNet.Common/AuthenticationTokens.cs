using System;

namespace SpaceDotNet.Common
{
    public class AuthenticationTokens
    {
        public AuthenticationTokens(string? accessToken, string? refreshToken, DateTimeOffset? expires)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Expires = expires;
        }

        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTimeOffset? Expires { get; set; }

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