using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.Client;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Samples.Web.WebHooks
{
    public class CateringWebHookHandler : SpaceWebHookHandler
    {
        private static readonly Dictionary<string, CateringSession> Sessions = new Dictionary<string, CateringSession>();

        private readonly ChatClient _chatClient;
        
        public CateringWebHookHandler(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            // NOTE: In the current application, the auto-wired Space clients will always act on behalf of the current user.
            // To work with chat callbacks, we need to act on behalf of he application itself.
            var connection = new ClientCredentialsConnection(
                configuration["Space:ServerUrl"],
                configuration["Space:ClientId"],
                configuration["Space:ClientSecret"],
                httpClientFactory.CreateClient());

            _chatClient = new ChatClient(connection);
        }

        public override async Task HandleMessageAsync(MessagePayload payload)
        {
            if (payload.Message.Body is ChatMessageText messageText && !string.IsNullOrEmpty(messageText.Text))
            {
                await _chatClient.Messages.SendMessageAsync(
                    recipient: MessageRecipient.Channel(ChatChannel.FromId(payload.Message.ChannelId)),
                    content: ChatMessage.Text("You said: " + messageText.Text),
                    unfurlLinks: false);
            }

            var cateringSession = new CateringSession();
            Sessions[payload.UserId] = cateringSession;
            
            await SendOrEditMessageAsync(
                channelId: payload.Message.ChannelId,
                recipient: MessageRecipient.Channel(ChatChannel.FromId(payload.Message.ChannelId)),
                content: ChatMessage.Block(
                    outline: new MessageOutline("Anything to eat or drink while we are on our way to Space?"),
                    messageData: "Anything to eat or drink while we are on our way to Space?",
                    sections: new List<MessageSectionElement>
                    {
                        new MessageSection
                        {
                            Header = "JetBrains Space - Catering",
                            Elements = new List<MessageElement>
                            {
                                MessageElement.MessageText("Anything to eat or drink while we are on our way to Space?"),
                                MessageElement.MessageControlGroup(new List<MessageControlElement>
                                {
                                    MessageControlElement.MessageButton("Yes, please", MessageButtonStyle.PRIMARY, MessageAction.Post("catering-start", ""))
                                })
                            }
                        }
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);
        }

        public override async Task HandleMessageActionAsync(MessageActionPayload payload)
        {
            var actionId = Enumeration.FromValue<ActionId>(payload.ActionId);

            Sessions.TryGetValue(payload.UserId, out var cateringSession);

            // Start session
            if (actionId == ActionId.Skip)
            {
                return;
            } 
            else if (cateringSession == null)
            {
                cateringSession = new CateringSession();
                Sessions[payload.UserId] = cateringSession;
            }

            // Store choices
            if (actionId == ActionId.Food)
            {
                cateringSession.SelectedFood = payload.ActionValue;
            }
            if (actionId == ActionId.Drinks)
            {
                cateringSession.SelectedDrinks = payload.ActionValue;
            }
            if (actionId == ActionId.DrinkAdditions)
            {
                cateringSession.SelectedDrinkAdditions = payload.ActionValue;
            }
            
            // More choices to make?
            if (string.IsNullOrEmpty(cateringSession.SelectedFood))
            {
                await SendOrEditMessageAsync(
                    channelId: payload.Message.ChannelId,
                    recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessage.Block(
                        outline: new MessageOutline("Would you prefer chicken or pasta?"),
                        messageData: "Would you prefer chicken or pasta?",
                        sections: new List<MessageSectionElement>
                        {
                            new MessageSection
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElement>
                                {
                                    MessageElement.MessageText("Would you prefer chicken or pasta?"),
                                    MessageElement.MessageControlGroup(new List<MessageControlElement>
                                    {
                                        MessageControlElement.MessageButton("Chicken", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Food.Value, "🍗 Chicken")),
                                        MessageControlElement.MessageButton("Pasta", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Food.Value, "🍝 Pasta")),
                                        MessageControlElement.MessageButton("No food", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Food.Value, "🤷 None"))
                                    })
                                }
                            }
                        },
                        style: MessageStyle.PRIMARY),
                    cateringSession: cateringSession);
            }
            else if (string.IsNullOrEmpty(cateringSession.SelectedDrinks))
            {
                await SendOrEditMessageAsync(
                    channelId: payload.Message.ChannelId,
                    recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessage.Block(
                        outline: new MessageOutline("Any drinks? Coffee or tea?"),
                        messageData: "Any drinks? Coffee or tea?",
                        sections: new List<MessageSectionElement>
                        {
                            new MessageSection
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElement>
                                {
                                    MessageElement.MessageText("Any drinks? Coffee or tea?"),
                                    MessageElement.MessageControlGroup(new List<MessageControlElement>
                                    {
                                        MessageControlElement.MessageButton("Water", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.Drinks.Value, "🥛 Water")),
                                        MessageControlElement.MessageButton("Coffee", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Drinks.Value, "☕ Coffee")),
                                        MessageControlElement.MessageButton("Tea", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.Drinks.Value, "☕ Tea")),
                                        MessageControlElement.MessageButton("No drinks", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.Drinks.Value, "🤷 None"))
                                    })
                                }
                            }
                        },
                        style: MessageStyle.PRIMARY),
                    cateringSession: cateringSession);
            }
            else if (!string.IsNullOrEmpty(cateringSession.SelectedDrinks) 
                     && cateringSession.SelectedDrinks.IndexOf("coffee", StringComparison.OrdinalIgnoreCase) >= 0
                     && string.IsNullOrEmpty(cateringSession.SelectedDrinkAdditions))
            {
                await SendOrEditMessageAsync(
                    channelId: payload.Message.ChannelId,
                    recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessage.Block(
                        outline: new MessageOutline("How would you like your coffee?"),
                        messageData: "How would you like your coffee?",
                        sections: new List<MessageSectionElement>
                        {
                            new MessageSection
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElement>
                                {
                                    MessageElement.MessageText("How would you like your coffee?"),
                                    MessageElement.MessageControlGroup(new List<MessageControlElement>
                                    {
                                        MessageControlElement.MessageButton("Milk", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.DrinkAdditions.Value, "with milk")),
                                        MessageControlElement.MessageButton("Milk and Sugar", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.DrinkAdditions.Value, "with milk and sugar")),
                                        MessageControlElement.MessageButton("No additions", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.DrinkAdditions.Value, "no additions"))
                                    })
                                }
                            }
                        },
                        style: MessageStyle.PRIMARY),
                    cateringSession: cateringSession);
            }
            else
            {
                await SendOrEditMessageAsync(
                    channelId: payload.Message.ChannelId,
                    recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessage.Block(
                        outline: new MessageOutline("Thank you, we'll be right there!"),
                        messageData: "Thank you, we'll be right there!",
                        sections: new List<MessageSectionElement>
                        {
                            new MessageSection
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElement>
                                {
                                    MessageElement.MessageText("Thank you, we'll be right there!"),
                                    MessageElement.MessageFields(new List<MessageFieldElement>
                                    {
                                        MessageFieldElement.MessageField("Food choice:", cateringSession.SelectedFood),
                                        MessageFieldElement.MessageField("Drinks choice:", cateringSession.SelectedDrinks
                                            + (cateringSession.SelectedDrinkAdditions != null
                                                ? " (" + cateringSession.SelectedDrinkAdditions + ")"
                                                : ""))
                                    })
                                }
                            }
                        },
                        style: MessageStyle.PRIMARY),
                    cateringSession: cateringSession);

                Sessions.Remove(payload.UserId);
            }
        }

        private async Task SendOrEditMessageAsync(
            string? channelId, 
            MessageRecipient recipient, 
            ChatMessage content,
            CateringSession cateringSession)
        {
            if (string.IsNullOrEmpty(cateringSession.ExistingMessageId) || string.IsNullOrEmpty(channelId))
            {
                // Send
                var message = await _chatClient.Messages.SendMessageAsync(
                    recipient: recipient,
                    content: content,
                    unfurlLinks: false);

                cateringSession.ExistingMessageId = message.Id;
            }
            else
            {
                // Edit
                await _chatClient.Messages.EditMessageAsync(
                    channel: channelId,
                    message: ChatMessageIdentifier.InternalId(cateringSession.ExistingMessageId),
                    content: content,
                    unfurlLinks: false);
            }
        }
        
        private sealed class ActionId : Enumeration
        {
            private ActionId(string value) : base(value) { }
        
            public static readonly ActionId Food = new ActionId("catering-food");
            public static readonly ActionId Drinks = new ActionId("catering-drinks");
            public static readonly ActionId DrinkAdditions = new ActionId("catering-drinkadditions");
            public static readonly ActionId Skip = new ActionId("catering-skip");
        }

        private class CateringSession
        {
            public string? ExistingMessageId { get; set; }
            public string? SelectedFood { get; set; }
            public string? SelectedDrinks { get; set; }
            public string? SelectedDrinkAdditions { get; set; }
        }
    }
}