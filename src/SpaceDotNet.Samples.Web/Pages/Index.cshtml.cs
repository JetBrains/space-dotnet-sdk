using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpaceDotNet.Client;
using SpaceDotNet.Common;

namespace SpaceDotNet.Samples.Web.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;

        public TDMemberProfileDto MemberProfile { get; set; }

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task OnGet()
        {
            var authenticationInfo = await HttpContext.AuthenticateAsync();
            
            var authenticationTokens = new AuthenticationTokens(
                authenticationInfo.Properties.GetTokenValue("access_token"),
                authenticationInfo.Properties.GetTokenValue("refresh_token"),
                DateTimeOffset.Parse(authenticationInfo.Properties.GetTokenValue("expires_at")));
            
            var connection = new RefreshTokenConnection(
                _configuration["Space:BaseUrl"], 
                _configuration["Space:ClientId"],
                _configuration["Space:ClientSecret"],
                authenticationTokens);
            
            var teamDirectoryClient = new TeamDirectoryClient(connection);
            
            MemberProfile = await teamDirectoryClient.ProfilesMeGetMe();

            authenticationInfo.Properties.UpdateTokenValue("access_token", connection.AuthenticationTokens.AccessToken);
            authenticationInfo.Properties.UpdateTokenValue("refresh_token", connection.AuthenticationTokens.RefreshToken);
            authenticationInfo.Properties.UpdateTokenValue("expires_at", connection.AuthenticationTokens.Expires?.ToString("O"));
        }
    }
}