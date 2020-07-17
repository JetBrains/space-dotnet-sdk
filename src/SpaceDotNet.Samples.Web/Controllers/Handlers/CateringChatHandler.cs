using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpaceDotNet.AspNetCore.WebHooks.Types;
using SpaceDotNet.Client;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Samples.Web.Controllers.Handlers
{
    public class CateringChatHandler
    {
        public const string ActionIdPrefix = "catering-";
        
        private static Dictionary<string, CateringSession> Sessions = new Dictionary<string, CateringSession>();

        private readonly ChatClient _chatClient;

        public CateringChatHandler(Connection connection)
        {
            _chatClient = new ChatClient(connection);
        }

        public async Task HandleAsync(ActionPayload payload)
        {
            var actionId = Enumeration.FromValue<ActionId>(payload.ActionId);

            Sessions.TryGetValue(payload.UserId, out var cateringSession);

            // Start session
            if (actionId == ActionId.Skip)
            {
                return;
            } 
            else if (actionId == ActionId.Start || cateringSession == null)
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
                    channelId: payload.Context?.ChannelId,
                    recipient: MessageRecipientDto.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessageDto.Block(
                        outline: new MessageOutlineDto("Would you prefer chicken or pasta?"),
                        messageData: "Would you prefer chicken or pasta?",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("Would you prefer chicken or pasta?"),
                                    MessageElementDto.MessageControlGroup(new List<MessageControlElementDto>
                                    {
                                        MessageControlElementDto.MessageButton("Chicken", MessageButtonStyle.REGULAR,
                                            MessageActionDto.Post(ActionId.Food.Value, "🍗 Chicken")),
                                        MessageControlElementDto.MessageButton("Pasta", MessageButtonStyle.REGULAR,
                                            MessageActionDto.Post(ActionId.Food.Value, "🍝 Pasta")),
                                        MessageControlElementDto.MessageButton("No food", MessageButtonStyle.REGULAR,
                                            MessageActionDto.Post(ActionId.Food.Value, "🤷 None"))
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
                    channelId: payload.Context?.ChannelId,
                    recipient: MessageRecipientDto.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessageDto.Block(
                        outline: new MessageOutlineDto("Any drinks? Coffee or tea?"),
                        messageData: "Any drinks? Coffee or tea?",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("Any drinks? Coffee or tea?"),
                                    MessageElementDto.MessageControlGroup(new List<MessageControlElementDto>
                                    {
                                        MessageControlElementDto.MessageButton("Water", MessageButtonStyle.REGULAR, 
                                            MessageActionDto.Post(ActionId.Drinks.Value, "🥛 Water")),
                                        MessageControlElementDto.MessageButton("Coffee", MessageButtonStyle.REGULAR,
                                            MessageActionDto.Post(ActionId.Drinks.Value, "☕ Coffee")),
                                        MessageControlElementDto.MessageButton("Tea", MessageButtonStyle.REGULAR, 
                                            MessageActionDto.Post(ActionId.Drinks.Value, "☕ Tea")),
                                        MessageControlElementDto.MessageButton("No drinks", MessageButtonStyle.REGULAR, 
                                            MessageActionDto.Post(ActionId.Drinks.Value, "🤷 None"))
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
                    channelId: payload.Context?.ChannelId,
                    recipient: MessageRecipientDto.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessageDto.Block(
                        outline: new MessageOutlineDto("How would you like your coffee?"),
                        messageData: "How would you like your coffee?",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("How would you like your coffee?"),
                                    MessageElementDto.MessageControlGroup(new List<MessageControlElementDto>
                                    {
                                        MessageControlElementDto.MessageButton("Milk", MessageButtonStyle.REGULAR, 
                                            MessageActionDto.Post(ActionId.DrinkAdditions.Value, "with milk")),
                                        MessageControlElementDto.MessageButton("Milk and Sugar", MessageButtonStyle.REGULAR,
                                            MessageActionDto.Post(ActionId.DrinkAdditions.Value, "with milk and sugar")),
                                        MessageControlElementDto.MessageButton("No additions", MessageButtonStyle.REGULAR, 
                                            MessageActionDto.Post(ActionId.DrinkAdditions.Value, "no additions"))
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
                    channelId: payload.Context?.ChannelId,
                    recipient: MessageRecipientDto.Member(ProfileIdentifier.Id(payload.UserId)),
                    content: ChatMessageDto.Block(
                        outline: new MessageOutlineDto("Thank you, we'll be right there!"),
                        messageData: "Thank you, we'll be right there!",
                        sections: new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space - Catering",
                                Elements = new List<MessageElementDto>
                                {
                                    MessageElementDto.MessageText("Thank you, we'll be right there!"),
                                    MessageElementDto.MessageFields(new List<MessageFieldElementDto>
                                    {
                                        MessageFieldElementDto.MessageField("Food choice:", cateringSession.SelectedFood),
                                        MessageFieldElementDto.MessageField("Drinks choice:", cateringSession.SelectedDrinks
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
            string? channelId, MessageRecipientDto recipient, ChatMessageDto content, CateringSession cateringSession)
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
        
            public static readonly ActionId Start = new ActionId("catering-start");
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