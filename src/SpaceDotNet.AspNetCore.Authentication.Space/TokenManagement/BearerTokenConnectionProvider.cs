using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using SpaceDotNet.Common;

namespace SpaceDotNet.AspNetCore.Authentication.Space.TokenManagement
{
    internal class BearerTokenConnectionProvider
    {
        private readonly SpaceTokenManagementOptions _options;
        private readonly IOptionsSnapshot<SpaceOptions> _spaceOptions;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BearerTokenConnectionProvider(
            IOptions<SpaceTokenManagementOptions> options,
            IOptionsSnapshot<SpaceOptions> spaceOptions,
            IAuthenticationSchemeProvider schemeProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _options = options.Value;
            _spaceOptions = spaceOptions;
            _schemeProvider = schemeProvider;
            _httpContextAccessor = httpContextAccessor;
        }
        
        public async Task<BearerTokenConnection> CreateAsync()
        {
            var spaceOptions = await GetSpaceOptionsAsync();
            var httpContext = _httpContextAccessor.HttpContext;

            var accessToken = await httpContext.GetTokenAsync("access_token");
            return new BearerTokenConnection(spaceOptions.ServerUrl.ToString(), new AuthenticationTokens(accessToken, null, null));
        }
        
        private async Task<SpaceOptions> GetSpaceOptionsAsync()
        {
            if (string.IsNullOrEmpty(_options.Scheme))
            {
                var scheme = await _schemeProvider.GetDefaultChallengeSchemeAsync();
                return _spaceOptions.Get(scheme.Name);
            }
            else
            {
                return _spaceOptions.Get(_options.Scheme);
            }
        }

    }
}