#pragma warning disable 1998 // This async method lacks 'await' operators

using System.Collections.Concurrent;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks;
using JetBrains.Space.Client;

namespace JetBrains.Space.Samples.App.WebHooks;
    
[UsedImplicitly]
public class CateringWebHookHandler : SpaceWebHookHandler
{
    private static readonly ConcurrentDictionary<string, CateringSession> Sessions = new();
        
    private readonly ChatClient _chatClient;

    public CateringWebHookHandler(ChatClient chatClient)
    {
        _chatClient = chatClient;
    }

    public override async Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload)
    {
        return new Commands(new List<CommandDetail>
        {
            new("new", "Create a new catering request."),
            new("help", "Get more info about this application.")
        });
    }

    public override async Task HandleMessageAsync(MessagePayload payload)
    {
        if (payload.Message.Body is ChatMessageText messageText && !string.IsNullOrEmpty(messageText.Text))
        {
            if (messageText.Text.Trim().Equals("new", StringComparison.OrdinalIgnoreCase))
            {
                await StartNewSession(payload.UserId);
                return;
            }

            await _chatClient.Messages.SendMessageAsync(
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Text("You said: " + messageText.Text),
                unfurlLinks: false);
        }
        else
        {
            await _chatClient.Messages.SendMessageAsync(
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Text("You said many things!"),
                unfurlLinks: false);
        }
    }

    private async Task StartNewSession(string userId)
    {
        var cateringSession = new CateringSession();
        Sessions[userId] = cateringSession;
            
        await SendOrEditMessageAsync(
            channelIdentifier: null,
            recipient: MessageRecipient.Member(ProfileIdentifier.Id(userId)),
            content: ChatMessage.Block(
                outline: new MessageOutline("Anything to eat or drink while we are on our way to Space?"),
                messageData: "Anything to eat or drink while we are on our way to Space?",
                sections: new()
                {
                    MessageSectionElement.MessageSection(
                        elements: new()
                        {
                            MessageBlockElement.MessageText("JetBrains Space - Catering", size: MessageTextSize.SMALL),
                            
                            MessageBlockElement.MessageText("Anything to eat or drink while we are on our way to Space?"),
                            MessageBlockElement.MessageControlGroup(new List<MessageControlElement>
                            {
                                MessageControlElement.MessageButton("Yes, please", MessageButtonStyle.PRIMARY, 
                                    MessageAction.Post("catering-start", ""))
                            })
                        })
                },
                style: MessageStyle.PRIMARY),
            cateringSession: cateringSession);
    }

    public override async Task<AppUserActionExecutionResult> HandleMessageActionAsync(MessageActionPayload payload)
    {
        Sessions.TryGetValue(payload.UserId, out var cateringSession);

        // Start session
        if (payload.ActionId == ActionId.Skip) return AppUserActionExecutionResult.Success();

        if (cateringSession == null)
        {
            cateringSession = new CateringSession();
            Sessions[payload.UserId] = cateringSession;
        }

        // Store choices
        if (payload.ActionId == ActionId.Food)
        {
            cateringSession.SelectedFood = payload.ActionValue;
        }
        if (payload.ActionId == ActionId.Drinks)
        {
            cateringSession.SelectedDrinks = payload.ActionValue;
        }
        if (payload.ActionId == ActionId.DrinkAdditions)
        {
            cateringSession.SelectedDrinkAdditions = payload.ActionValue;
        }
            
        // More choices to make?
        if (string.IsNullOrEmpty(cateringSession.SelectedFood))
        {
            await SendOrEditMessageAsync(
                channelIdentifier: ChannelIdentifier.Profile(ProfileIdentifier.Id(payload.UserId)), 
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Block(
                    outline: new MessageOutline("Would you prefer chicken or pasta?"),
                    messageData: "Would you prefer chicken or pasta?",
                    sections: new()
                    {
                        MessageSectionElement.MessageSection(
                            elements: new()
                            {
                                MessageBlockElement.MessageText("JetBrains Space - Catering", size: MessageTextSize.SMALL),
                                
                                MessageBlockElement.MessageText("Would you prefer chicken or pasta?"),
                                MessageBlockElement.MessageControlGroup(new List<MessageControlElement>
                                {
                                    MessageControlElement.MessageButton("Chicken", MessageButtonStyle.REGULAR,
                                        MessageAction.Post(ActionId.Food, "🍗 Chicken")),
                                    MessageControlElement.MessageButton("Pasta", MessageButtonStyle.REGULAR,
                                        MessageAction.Post(ActionId.Food, "🍝 Pasta")),
                                    MessageControlElement.MessageButton("No food", MessageButtonStyle.REGULAR,
                                        MessageAction.Post(ActionId.Food, "🤷 None"))
                                })
                            })
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);
        }
        else if (string.IsNullOrEmpty(cateringSession.SelectedDrinks))
        {
            await SendOrEditMessageAsync(
                channelIdentifier: ChannelIdentifier.Profile(ProfileIdentifier.Id(payload.UserId)),
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Block(
                    outline: new MessageOutline("Any drinks? Coffee or tea?"),
                    messageData: "Any drinks? Coffee or tea?",
                    sections: new()
                    {
                        MessageSectionElement.MessageSection(
                            elements: new()
                            {
                                MessageBlockElement.MessageText("JetBrains Space - Catering", size: MessageTextSize.SMALL),
                                
                                MessageBlockElement.MessageText("Any drinks? Coffee or tea?"),
                                MessageBlockElement.MessageControlGroup(new List<MessageControlElement>
                                {
                                    MessageControlElement.MessageButton("Water", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.Drinks, "🥛 Water")),
                                    MessageControlElement.MessageButton("Coffee", MessageButtonStyle.REGULAR,
                                        MessageAction.Post(ActionId.Drinks, "☕ Coffee")),
                                    MessageControlElement.MessageButton("Tea", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.Drinks, "☕ Tea")),
                                    MessageControlElement.MessageButton("Juice", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.Drinks, "🧃 Juice")),
                                    MessageControlElement.MessageButton("No drinks", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.Drinks, "🤷 None"))
                                })
                            })
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);
        }
        else if (!string.IsNullOrEmpty(cateringSession.SelectedDrinks) 
                 && cateringSession.SelectedDrinks.Contains("coffee", StringComparison.OrdinalIgnoreCase)
                 && string.IsNullOrEmpty(cateringSession.SelectedDrinkAdditions))
        {
            await SendOrEditMessageAsync(
                channelIdentifier: ChannelIdentifier.Profile(ProfileIdentifier.Id(payload.UserId)),
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Block(
                    outline: new MessageOutline("How would you like your coffee?"),
                    messageData: "How would you like your coffee?",
                    sections: new()
                    {
                        MessageSectionElement.MessageSection(
                            elements: new()
                            {
                                MessageBlockElement.MessageText("JetBrains Space - Catering", size: MessageTextSize.SMALL),
                                
                                MessageBlockElement.MessageText("How would you like your coffee?"),
                                MessageBlockElement.MessageControlGroup(new List<MessageControlElement>
                                {
                                    MessageControlElement.MessageButton("Milk", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.DrinkAdditions, "🥛 with milk")),
                                    MessageControlElement.MessageButton("Sugar", MessageButtonStyle.REGULAR,
                                        MessageAction.Post(ActionId.DrinkAdditions, "🍁 with sugar")),
                                    MessageControlElement.MessageButton("Milk & sugar", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.DrinkAdditions, "🥛🍁 with milk and sugar")),
                                    MessageControlElement.MessageButton("No additions", MessageButtonStyle.REGULAR, 
                                        MessageAction.Post(ActionId.DrinkAdditions, "🤷 no additions"))
                                })
                            })
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);
        }
        else
        {
            await SendOrEditMessageAsync(
                channelIdentifier: ChannelIdentifier.Profile(ProfileIdentifier.Id(payload.UserId)),
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(payload.UserId)),
                content: ChatMessage.Block(
                    outline: new MessageOutline("Thank you, we'll be right there!"),
                    messageData: "Thank you, we'll be right there!",
                    sections: new()
                    {
                        MessageSectionElement.MessageSection(
                            elements: new()
                            {
                                MessageBlockElement.MessageText("JetBrains Space - Catering", size: MessageTextSize.SMALL),
                                
                                MessageBlockElement.MessageText("Thank you, we'll be right there!"),
                                MessageBlockElement.MessageFields(new List<MessageFieldElement>
                                {
                                    MessageFieldElement.MessageField("Food choice:", cateringSession.SelectedFood),
                                    MessageFieldElement.MessageField("Drinks choice:", cateringSession.SelectedDrinks
                                        + (cateringSession.SelectedDrinkAdditions != null
                                            ? " (" + cateringSession.SelectedDrinkAdditions + ")"
                                            : ""))
                                })
                            })
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);

            Sessions.TryRemove(payload.UserId, out _);
        }

        return AppUserActionExecutionResult.Success();
    }

    public override async Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload)
    {
        if (payload.Payload is PingWebhookEvent)
        {
            return new ApplicationExecutionResult("Pong!");
        }
            
        return new ApplicationExecutionResult($"This endpoint has no support for {payload.Payload.GetType()}", statusCode: 400);
    }

    private async Task SendOrEditMessageAsync(
        ChannelIdentifier? channelIdentifier, 
        MessageRecipient recipient, 
        ChatMessage content,
        CateringSession cateringSession)
    {
        if (string.IsNullOrEmpty(cateringSession.ExistingMessageId) || channelIdentifier == null)
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
                channel: channelIdentifier,
                message: ChatMessageIdentifier.InternalId(cateringSession.ExistingMessageId),
                content: content,
                unfurlLinks: false);
        }
    }
        
    private static class ActionId
    {
        public const string Food = "catering-food";
        public const string Drinks = "catering-drinks";
        public const string DrinkAdditions = "catering-drinkadditions";
        public const string Skip = "catering-skip";
    }

    private class CateringSession
    {
        public string? ExistingMessageId { get; set; }
        public string? SelectedFood { get; set; }
        public string? SelectedDrinks { get; set; }
        public string? SelectedDrinkAdditions { get; set; }
    }
}