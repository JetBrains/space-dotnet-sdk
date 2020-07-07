using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.AspNetCore.WebHooks.Types;
using SpaceDotNet.Client;
using SpaceDotNet.Common;

namespace SpaceDotNet.Samples.Web.Controllers
{
    [Route("space")]
    public class SpaceController : Controller
    {
        private readonly Connection _connection;
        private readonly string _chatChannelName = "SpaceDotNet";

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
                        outline: new MessageOutlineDto("Have you tried JetBrains Space?"),
                        messageData: "Have you tried JetBrains Space?",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("JetBrains Space is an Integrated Team Environment."),
                                    MessageElementDto.MessageText("Have you tried JetBrains Space?"),
                                    MessageElementDto.MessageDivider(),
                                    MessageElementDto.MessageControlGroup(new List<MessageControlElementDto>
                                    {
                                        MessageControlElementDto.MessageButton("Yes", MessageButtonStyle.PRIMARY, MessageActionDto.Post("tried-space", "yes")),
                                        MessageControlElementDto.MessageButton("No", MessageButtonStyle.SECONDARY, MessageActionDto.Post("tried-space", "no"))
                                    }),
                                    MessageElementDto.MessageDivider(),
                                    MessageElementDto.MessageText("Get access at https://www.jetbrains.com/space/")
                                },
                                Footer = "Check it out at https://www.jetbrains.com/space/"
                            }
                        },
                        style: MessageStyle.WARNING),
                    unfurlLinks: false);
                
                return Content($"A chat message has been sent to the channel named \"{_chatChannelName}\" in your Space organization.");
            }
        }
        
        [HttpPost]
        [Route("receive")]
        public IActionResult Receive([FromBody]ActionPayload payload)
        {
            // TODO WEBHOOK
            //X-Space-Signature	23a3f560ad8095545388b40755c3746f3904b8f04c655d29731674060cd96dbc
            //X-Space-Timestamp	1594131269767
            // val checkedSigning = HmacUtils(HmacAlgorithms.HMAC_SHA_256,
            // client.oAuthServices.signingKey(setup.service.id)).hmacHex("$timestamp:$body")

            return Content(payload.ActionId + "? " + payload.ActionValue);
        }
    }
}