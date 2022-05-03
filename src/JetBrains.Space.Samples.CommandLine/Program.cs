﻿using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Space.Client;
using JetBrains.Space.Client.TDMemberProfilePartialBuilder;
using JetBrains.Space.Common;

namespace JetBrains.Space.Samples.CommandLine;

public static class Program
{
    // ReSharper disable once UnusedParameter.Local
    public static async Task Main()
    {
        // Create a connection using a service account.
        // NOTE: Service accounts do not have access to all operations in Space!
        var connection = new ClientCredentialsConnection(
            new Uri(Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!), 
            Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
            Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
            new HttpClient());
            
        var teamDirectoryClient = new TeamDirectoryClient(connection);
            
        // User to add to chat later on
        var chatChannelName = "SpaceDotNet";
            
        // Get all profiles with their names
        await foreach (var profile in teamDirectoryClient.Profiles.GetAllProfilesAsyncEnumerable("", false, false, partial: _ => _
            .WithId()
            .WithName()))
        {
            Console.WriteLine($"{profile.Name.FirstName} {profile.Name.LastName}");
        }
            
        // Get profiles with their Id and Logins.
        var firstProfile = await teamDirectoryClient.Profiles.GetAllProfilesAsyncEnumerable("", false, false, partial: _ => _
            .WithId()
            .WithLogins(_ => _
                .WithAllFieldsWildcard())).FirstAsync();
        
        // -- Accessing another property (such as name) will throw.
        try
        {
            // This will fail...
            Console.WriteLine($"{firstProfile.Name.FirstName} {firstProfile.Name.LastName}");
        }
        catch (PropertyNotRequestedException e)
        {
            Console.WriteLine($"The Space API client tells us which partial query should be added to access {e.PropertyName}:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
            
        // -- The Logins property is not accessible, and will throw.
        try
        {
            // This will fail...
            foreach (var login in firstProfile.Logins)
            {
                Console.WriteLine($"{login.Identifier}");
            }
        }
        catch (PropertyValueInaccessibleException e)
        {
            Console.WriteLine($"The Space API client tells us when the {e.PropertyName} property is not accessible:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
            
        // Send chat message?
        var chatClient = new ChatClient(connection);
        var chatChannelExists = !await chatClient.Channels.IsNameFreeAsync(chatChannelName);
        if (!chatChannelExists)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skipped sending chat message example. Create a channel named \"{chatChannelName}\" in your Space organization and try again.");
            Console.ResetColor();
        } 
        else
        {
            await chatClient.Messages.SendMessageAsync(
                recipient: MessageRecipient.Channel(ChatChannel.FromName(chatChannelName)),
                content: ChatMessage.Block(
                    outline: MessageOutline.V2(new()
                    {
                        MessageInlineElement.MessageInlineText("Have you tried JetBrains Space?")
                    }),
                    messageData: "Have you tried JetBrains Space? See https://www.jetbrains.com/space/ for more information.",
                    sections: new()
                    {
                        MessageSectionElement.MessageSectionV2(
                            elements: new()
                            {
                                MessageElement.MessageText("JetBrains Space", size: MessageTextSize.LARGE),
                                
                                MessageElement.MessageText("JetBrains Space is an Integrated Team Environment.",
                                MessageAccessoryElement.MessageIcon(new ApiIcon("space"), MessageStyle.SUCCESS)),
                                MessageElement.MessageText("Have you tried JetBrains Space?"),
                                MessageElement.MessageDivider(),
                                MessageElement.MessageText("Get access at https://www.jetbrains.com/space/"),
                                
                                MessageElement.MessageText("Check it out at https://www.jetbrains.com/space/", size: MessageTextSize.SMALL)
                            })
                    },
                    style: MessageStyle.SUCCESS),
                unfurlLinks: false);
                
            Console.WriteLine($"A chat message has been sent to the channel named \"{chatChannelName}\" in your Space organization.");
        }
    }
}