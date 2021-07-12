#pragma warning disable 1998 // This async method lacks 'await' operators

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks;
using JetBrains.Space.Client;
using Microsoft.Extensions.Hosting;

namespace JetBrains.Space.Samples.App.WebHooks
{
    public class CateringWebHookHandlerStartupTask : BackgroundService
    {
        private readonly ApplicationClient _applicationClient;

        public CateringWebHookHandlerStartupTask(ApplicationClient applicationClient)
        {
            _applicationClient = applicationClient;
        }
        
        /// <summary>
        /// To register menu items in Space, we have to make a call
        /// to <see cref="ApplicationClient.RefreshMenuAsync"/> once in the application's lifetime.
        ///
        /// Space will then reach out to your application and will
        /// invoke <see cref="SpaceWebHookHandler.HandleListMenuExtensionsAsync"/>.
        ///
        /// Note that ideally this is done just after startup, as <see cref="ApplicationClient.RefreshMenuAsync"/>
        /// is an expensive call that only has to happen when available menu items change.
        ///
        /// Currently, menu registrations expire. Therefore, this method re-registers menu items every two hours.
        /// </summary>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _applicationClient.RefreshMenuAsync(cancellationToken: stoppingToken);
                await Task.Delay(TimeSpan.FromHours(2), stoppingToken);
            }
        }
    }
    
    [UsedImplicitly]
    public class CateringWebHookHandler : SpaceWebHookHandler
    {
        private static readonly ConcurrentDictionary<string, CateringSession> Sessions = new ConcurrentDictionary<string, CateringSession>();
        
        private readonly ChatClient _chatClient;

        public CateringWebHookHandler(ChatClient chatClient)
        {
            _chatClient = chatClient;
        }

        public override async Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload)
        {
            return new Commands(new List<CommandDetail>
            {
                new CommandDetail("new", "Create a new catering request."),
                new CommandDetail("help", "Get more info about this application.")
            });
        }

        public override async Task<MenuExtensions> HandleListMenuExtensionsAsync(ListMenuExtensionsPayload payload)
        {
            // TIP: Remove menu items/update menu items by returning a different shape of collection
            return new MenuExtensions();
            // return new MenuExtensions(new List<MenuExtensionDetail>
            // {
            //     new MenuExtensionDetail(MenuId.Global.Add, "Catering request", "Request catering (demo)")
            // });
        }
        
        public override async Task<ApplicationExecutionResult> HandleMenuActionAsync(MenuActionPayload payload)
        {
            await StartNewSession(payload.UserId);
            return new ApplicationExecutionResult("Catering request created.");
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
                    recipient: MessageRecipient.Channel(ChatChannel.FromId(payload.Message.ChannelId)),
                    content: ChatMessage.Text("You said: " + messageText.Text),
                    unfurlLinks: false);
            }
            else
            {
                await _chatClient.Messages.SendMessageAsync(
                    recipient: MessageRecipient.Channel(ChatChannel.FromId(payload.Message.ChannelId)),
                    content: ChatMessage.Text("You said many things!"),
                    unfurlLinks: false);
            }
        }

        private async Task StartNewSession(string userId)
        {
            var cateringSession = new CateringSession();
            Sessions[userId] = cateringSession;
            
            await SendOrEditMessageAsync(
                channelId: null,
                recipient: MessageRecipient.Member(ProfileIdentifier.Id(userId)),
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
                                    MessageControlElement.MessageButton("Yes, please", MessageButtonStyle.PRIMARY, 
                                        MessageAction.Post("catering-start", ""))
                                })
                            }
                        }
                    },
                    style: MessageStyle.PRIMARY),
                cateringSession: cateringSession);
        }

        public override async Task<ApplicationExecutionResult> HandleMessageActionAsync(MessageActionPayload payload)
        {
            Sessions.TryGetValue(payload.UserId, out var cateringSession);

            // Start session
            if (payload.ActionId == ActionId.Skip)
            {
                return new ApplicationExecutionResult("Catering request has been skipped.");
            } 
            else if (cateringSession == null)
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
                                            MessageAction.Post(ActionId.Food, "🍗 Chicken")),
                                        MessageControlElement.MessageButton("Pasta", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Food, "🍝 Pasta")),
                                        MessageControlElement.MessageButton("No food", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Food, "🤷 None"))
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
                                            MessageAction.Post(ActionId.Drinks, "🥛 Water")),
                                        MessageControlElement.MessageButton("Coffee", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.Drinks, "☕ Coffee")),
                                        MessageControlElement.MessageButton("Tea", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.Drinks, "☕ Tea")),
                                        MessageControlElement.MessageButton("No drinks", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.Drinks, "🤷 None"))
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
                                            MessageAction.Post(ActionId.DrinkAdditions, "with milk")),
                                        MessageControlElement.MessageButton("Milk and Sugar", MessageButtonStyle.REGULAR,
                                            MessageAction.Post(ActionId.DrinkAdditions, "with milk and sugar")),
                                        MessageControlElement.MessageButton("No additions", MessageButtonStyle.REGULAR, 
                                            MessageAction.Post(ActionId.DrinkAdditions, "no additions"))
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

                Sessions.TryRemove(payload.UserId, out _);
            }

            return new ApplicationExecutionResult("Catering choice was received.");
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
        
        private static class ActionId
        {
            public static readonly string Food = "catering-food";
            public static readonly string Drinks = "catering-drinks";
            public static readonly string DrinkAdditions = "catering-drinkadditions";
            public static readonly string Skip = "catering-skip";
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