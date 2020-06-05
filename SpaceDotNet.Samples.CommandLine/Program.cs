using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Client;
using SpaceDotNet.Client.TDMemberProfileDtoExtensions;
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
            catch (PropertyAccessException e)
            {
                Console.WriteLine($"The Space API client tells us which partial query should be added to access {e.PropertyName}:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}