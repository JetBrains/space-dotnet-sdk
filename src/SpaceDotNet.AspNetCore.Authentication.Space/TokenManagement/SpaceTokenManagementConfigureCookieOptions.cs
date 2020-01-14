using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace SpaceDotNet.AspNetCore.Authentication.Space.TokenManagement
{
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>
    /// </remarks>
    public class SpaceTokenManagementConfigureCookieOptions : IConfigureNamedOptions<CookieAuthenticationOptions>
    {
        private readonly AuthenticationScheme _scheme;

        public SpaceTokenManagementConfigureCookieOptions(IAuthenticationSchemeProvider provider)
        {
            _scheme = provider.GetDefaultSignInSchemeAsync().GetAwaiter().GetResult();
        }

        public void Configure(CookieAuthenticationOptions options) { }

        public void Configure(string schemeName, CookieAuthenticationOptions options)
        {
            if (schemeName == _scheme.Name)
            {
                options.EventsType = typeof(SpaceTokenManagementCookieEvents);
            }
        }
    }
}