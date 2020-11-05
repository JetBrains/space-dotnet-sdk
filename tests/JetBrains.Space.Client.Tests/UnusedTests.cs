using System;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Space.Client.TDMemberProfilePartialBuilder;
using JetBrains.Space.Client.TDProfileNamePartialBuilder;
using JetBrains.Space.Common;
using Xunit;

namespace JetBrains.Space.Client.Tests
{
    public class UnusedTests
    {
        [Fact(Skip = "Skipped as it has no use yet.")]
        public async Task UnusedTestAsync()
        {
            var connection = new ClientCredentialsConnection(
                new Uri("TODO"), 
                "TODO",
                "TODO",
                new HttpClient());

            var teamDirectoryClient = new TeamDirectoryClient(connection);

            // ReSharper disable once UnusedVariable
            var memberProfile = await teamDirectoryClient.Profiles
                .GetProfileAsync(ProfileIdentifier.Username("Heather.Stewart"), partial => partial
                    .WithAllFieldsWildcard() // Include all first-level fields
                    .WithManagers(manager => manager
                        .WithId()
                        .WithUsername()
                        .WithName(name => name
                            .WithFirstName()
                            .WithLastName())));
        }
    }
}