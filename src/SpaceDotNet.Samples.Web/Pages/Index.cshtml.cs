using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpaceDotNet.Client;

namespace SpaceDotNet.Samples.Web.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;
        private readonly TeamDirectoryClient _teamDirectoryClient;

        public TDMemberProfileDto MemberProfile { get; set; }

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger, TeamDirectoryClient teamDirectoryClient)
        {
            _configuration = configuration;
            _logger = logger;
            _teamDirectoryClient = teamDirectoryClient;
        }

        public async Task OnGet()
        {
            MemberProfile = await _teamDirectoryClient.ProfilesMeGetMe();
        }
    }
}