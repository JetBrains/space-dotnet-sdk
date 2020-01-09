using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Common;
using Xunit;

namespace SpaceDotNet.Client.Tests
{
    public class DummyTests
    {
        [Fact]
        public async Task DummyTestAsync()
        {
            var connection = new ClientCredentialsConnection(
                "TODO",
                "TODO",
                "TODO",
                new HttpClient());

            var teamDirectoryClient = new TeamDirectoryClient(connection);

            var memberProfile = await teamDirectoryClient.ProfilesGetProfileByUsername("Maarten.Balliauw");
        }
    }
}