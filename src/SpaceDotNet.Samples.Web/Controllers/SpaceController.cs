using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SpaceDotNet.Client;
using SpaceDotNet.Common;
using SpaceDotNet.Samples.Web.Controllers.Handlers;

namespace SpaceDotNet.Samples.Web.Controllers
{
    [Route("space")]
    public class SpaceController : Controller
    {
        private readonly Connection _connection;
        
        public SpaceController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            // NOTE: In the current application, the auto-wired Space clients will always act on behalf of the current user.
            // To work with chat callbacks, we need to act on behalf of he application itself.
            _connection = new ClientCredentialsConnection(
                configuration["Space:ServerUrl"],
                configuration["Space:ClientId"],
                configuration["Space:ClientSecret"],
                httpClientFactory.CreateClient());
        }
        
        [HttpPost]
        [Route("receive")]
        public async Task<IActionResult> Receive([FromBody]ApplicationPayload payload)
        {
            switch (payload)
            {
                // List commands?
                case ListCommandsPayload _:
                    // noop
                    return Ok();
                
                // Message?
                case MessagePayload messagePayload:
                    await new CateringChatHandler(_connection)
                        .HandleAsync(messagePayload);
                    return Ok();
                
                // Action?
                case MessageActionPayload actionPayload:
                    if (actionPayload.ActionId.StartsWith(CateringChatHandler.ActionIdPrefix))
                    {
                        await new CateringChatHandler(_connection)
                            .HandleAsync(actionPayload);
                        return Ok();
                    }
                
                    return BadRequest($"Action with id '{actionPayload.ActionId}' is not supported.");
            }

            return BadRequest($"Payload is not supported.");
        }
    }
}