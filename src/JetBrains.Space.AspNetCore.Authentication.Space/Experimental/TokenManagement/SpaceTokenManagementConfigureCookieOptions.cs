using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Authentication.Space.Experimental.TokenManagement
{
    /// <summary>
    /// A class that configures the <see cref="CookieAuthenticationOptions"/> options.
    /// </summary>
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>.
    /// </remarks>
    public class SpaceTokenManagementConfigureCookieOptions : IConfigureNamedOptions<CookieAuthenticationOptions>
    {
        private readonly AuthenticationScheme _scheme;

        /// <summary>
        /// Creates a new <see cref="SpaceTokenManagementConfigureCookieOptions"/> instance.
        /// </summary>
        /// <param name="provider">An <see cref="IAuthenticationSchemeProvider"/> used by the current <see cref="SpaceTokenManagementConfigureCookieOptions"/>.</param>
        public SpaceTokenManagementConfigureCookieOptions(IAuthenticationSchemeProvider provider)
        {
            _scheme = provider.GetDefaultSignInSchemeAsync().GetAwaiter().GetResult();
        }

        /// <inheritdoc />
        public void Configure(CookieAuthenticationOptions options) { }

        /// <inheritdoc />
        public void Configure(string schemeName, CookieAuthenticationOptions options)
        {
            if (schemeName == _scheme.Name)
            {
                options.EventsType = typeof(SpaceTokenManagementCookieEvents);
            }
        }
    }
}