using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Client;
using SpaceDotNet.Client.TDMemberProfileDtoPartialBuilder;
using SpaceDotNet.Common;

namespace SpaceDotNet.Samples.CommandLine
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            // Create a connection using a service account.
            // NOTE: Service accounts do not have access to all operations in Space!
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
                new HttpClient());
            
            // User to add to chat later on
            var chatChannelName = "SpaceDotNet";
            
            // Get all profiles with their names
            var teamDirectoryClient = new TeamDirectoryClient(connection);
            await foreach (var profile in teamDirectoryClient.Profiles.GetAllProfilesAsyncEnumerable("", false, false, partial: _ => _
                .WithId()
                .WithName()))
            {
                Console.WriteLine($"{profile.Name.FirstName} {profile.Name.LastName}");
            }
            
            // Get profiles with their Id. Accessing another property (such as name) will throw.
            var firstProfile = await teamDirectoryClient.Profiles.GetAllProfilesAsyncEnumerable("", false, false, partial: _ => _
                .WithId()).FirstOrDefaultAsync();
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
                    recipient: new MessageRecipientChannelDto { Channel = new ChatChannelFromNameDto { Name = chatChannelName } },
                    content: new ChatMessageBlockDto
                    {
                        Outline = new MessageOutlineDto { Text = "Have you tried JetBrains Space?" },
                        MessageData = "Have you tried JetBrains Space? See https://www.jetbrains.com/space/ for more information.",
                        Sections = new List<MessageSectionElementDto>
                        {
                            new MessageSectionDto
                            {
                                Header = "JetBrains Space",
                                Elements = new List<MessageElementDto>
                                {
                                    new MessageTextDto { Content = "JetBrains Space is an Integrated Team Environment." },
                                    new MessageTextDto { Content = "Have you tried JetBrains Space?" },
                                    new MessageDividerDto(),
                                    new MessageTextDto { Content = "Get access at https://www.jetbrains.com/space/" }
                                },
                                Footer = "Check it out at https://www.jetbrains.com/space/"
                            }
                        },
                        Style = MessageStyle.WARNING
                    },
                    unfurlLinks: false);
                
                Console.WriteLine($"A chat message has been sent to the channel named \"{chatChannelName}\" in your Space organization.");
            }
        }
    }
}