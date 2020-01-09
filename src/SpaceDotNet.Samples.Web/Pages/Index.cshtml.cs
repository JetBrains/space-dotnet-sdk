using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            var bearerToken = await HttpContext.GetTokenAsync("access_token");
            
            var connection = new BearerTokenConnection(
                _configuration["Space:BaseUrl"], 
                bearerToken);

            var teamDirectoryClient = new TeamDirectoryClient(connection);

            MemberProfile = await teamDirectoryClient.ProfilesMeGetMe();
        }
    }
}