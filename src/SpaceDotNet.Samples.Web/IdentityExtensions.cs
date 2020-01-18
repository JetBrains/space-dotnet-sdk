using System.Security.Claims;
using System.Security.Principal;

namespace SpaceDotNet.Samples.Web
{
    public static class IdentityExtensions
    {
        public static string? GetClaimValue(this IIdentity identity, string claimType)
        {
            if (identity is ClaimsIdentity claimsIdentity)
            {
                foreach (var claim in claimsIdentity.Claims)
                {
                    if (claim.Type == claimType) return claim.Value;
                }
            }

            return null;
        }
    }
}