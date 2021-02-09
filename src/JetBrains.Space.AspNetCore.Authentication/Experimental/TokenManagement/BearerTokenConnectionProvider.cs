using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Authentication.Experimental.TokenManagement
{
    [SuppressMessage("ReSharper", "LogMessageIsSentenceProblem")]
    internal class BearerTokenConnectionProvider
    {
        private readonly SpaceTokenManagementOptions _options;
        private readonly IOptionsSnapshot<SpaceOptions> _spaceOptions;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<BearerTokenConnectionProvider> _logger;

        public BearerTokenConnectionProvider(
            IOptions<SpaceTokenManagementOptions> options,
            IOptionsSnapshot<SpaceOptions> spaceOptions,
            IAuthenticationSchemeProvider schemeProvider,
            IHttpContextAccessor httpContextAccessor,
            IHttpClientFactory httpClientFactory,
            ILogger<BearerTokenConnectionProvider> logger)
        {
            _options = options.Value;
            _spaceOptions = spaceOptions;
            _schemeProvider = schemeProvider;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }
        
        public async Task<BearerTokenConnection?> CreateAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                _logger.LogDebug("Could not provide a BearerTokenConnection - current HttpContext is null.");
                return null;
            }
            
            var spaceOptions = await GetSpaceOptionsAsync();
            if (spaceOptions.ServerUrl == null)
            {
                _logger.LogInformation("Could not provide a BearerTokenConnection - current Space server URL could not be determined. Set the Scheme value to the same Scheme the Space authentication handler was registered with.");
                return null;
            }

            var accessToken = await httpContext.GetTokenAsync("access_token");
            if (string.IsNullOrEmpty(accessToken))
            {
                _logger.LogInformation("Could not provide a BearerTokenConnection - access_token is not available from the current HttpContext. Cookie authentication needs to be enabled to be able to retrieve this property.");
                return null;
            }
            
            return new BearerTokenConnection(
                spaceOptions.ServerUrl, 
                new AuthenticationTokens(accessToken),
                _httpClientFactory.CreateClient());
        }
        
        private async Task<SpaceOptions> GetSpaceOptionsAsync()
        {
            if (string.IsNullOrEmpty(_options.Scheme))
            {
                var scheme = await _schemeProvider.GetDefaultChallengeSchemeAsync();
                return _spaceOptions.Get(scheme.Name);
            }

            return _spaceOptions.Get(_options.Scheme);
        }
    }
}