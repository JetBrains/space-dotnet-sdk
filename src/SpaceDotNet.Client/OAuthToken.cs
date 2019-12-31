using System;

namespace SpaceDotNet.Client
{
    public class OAuthToken
    {
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