using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Common;
using Xunit;

namespace SpaceDotNet.Client.Tests
{
    public class DummyTests
    {
        [Fact(Skip = "Skipped as it has no use yet.")]
        public async Task DummyTestAsync()
        {
            var connection = new ClientCredentialsConnection(
                "TODO",
                "TODO",
                "TODO",
                new HttpClient());

            var teamDirectoryClient = new TeamDirectoryClient(connection);

            // ReSharper disable once UnusedVariable
            var memberProfile = await teamDirectoryClient.Profiles.GetProfileByUsernameAsync("Maarten.Balliauw");
        }
    }
}