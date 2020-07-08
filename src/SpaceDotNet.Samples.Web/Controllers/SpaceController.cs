using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SpaceDotNet.AspNetCore.WebHooks.Types;
using SpaceDotNet.Client;
using SpaceDotNet.Common;
using SpaceDotNet.Samples.Web.Controllers.Handlers;

namespace SpaceDotNet.Samples.Web.Controllers
{
    [Route("space")]
    public class SpaceController : Controller
    {
        private readonly Connection _connection;
        
        // TODO WEBHOOKS document
        // NOTE: For this sample to work, create a channel,
        // and configure https://your-app.public.example.org/space/receive as an endpoint.
        private readonly string _chatChannelName = "Temporary-Test-Chat";

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
        
        [Route("send")]
        public async Task<IActionResult> Send()
        {
            // Send chat message?
            var chatClient = new ChatClient(_connection);
            var chatChannelExists = !await chatClient.Channels.IsNameFreeAsync(_chatChannelName);
            if (!chatChannelExists)
            {
                return Content($"Skipped sending chat message example. Create a channel named \"{_chatChannelName}\" in your Space organization and try again.");
            } 
            else
            {
                await chatClient.Messages.SendMessageAsync(
                    recipient: MessageRecipientDto.Channel(ChatChannelDto.FromName(_chatChannelName)),
                    content: ChatMessageDto.Block(
                        outline: new MessageOutlineDto("Anything to eat or drink while we are on our way to Space?"),
                        messageData: "Anything to eat or drink while we are on our way to Space?",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("Anything to eat or drink while we are on our way to Space?"),
                                    MessageElementDto.MessageControlGroup(new List<MessageControlElementDto>
                                    {
                                        MessageControlElementDto.MessageButton("Yes, please", MessageButtonStyle.PRIMARY, MessageActionDto.Post("catering-start", ""))
                                    })
                                }
                            }
                        },
                        style: MessageStyle.PRIMARY),
                    unfurlLinks: false);
                
                return Content($"A chat message has been sent to the channel named \"{_chatChannelName}\" in your Space organization.");
            }
        }
        
        [HttpPost]
        [Route("receive")]
        public async Task<IActionResult> Receive([FromBody]ActionPayload payload)
        {
            if (payload.ActionId.StartsWith(CateringChatHandler.ActionIdPrefix))
            {
                var handler = new CateringChatHandler(_connection);
                await handler.HandleAsync(payload);
                return Ok();
            }

            return BadRequest($"Action with id '{payload.ActionId}' is not supported.");
        }
    }
}