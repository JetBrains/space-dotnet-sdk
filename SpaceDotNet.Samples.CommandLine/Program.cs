using System;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Client;
using SpaceDotNet.Client.TDMemberProfileExtensions;
using SpaceDotNet.Common;

namespace SpaceDotNet.Samples.CommandLine
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a connection using a service account.
            // NOTE: Service accounts do not have access to all operations in Space!
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
                new HttpClient());
            
            // Get all profiles with their names
            var teamDirectoryClient = new TeamDirectoryClient(connection);
            await foreach (var profile in BatchEnumerator.AllItems(skip => teamDirectoryClient.Profiles.GetAllProfilesAsync("", false, false, skip: skip, partialBuilder: partial => partial
                .WithNext()
                .WithTotalCount()
                .WithData(data => data
                    .WithId()
                    .WithName()))))
            {
                Console.WriteLine($"{profile.Name.FirstName} {profile.Name.LastName}");
            }
        }
    }
}