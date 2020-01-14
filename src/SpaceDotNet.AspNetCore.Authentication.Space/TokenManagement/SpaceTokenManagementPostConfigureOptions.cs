using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace SpaceDotNet.AspNetCore.Authentication.Space.TokenManagement
{
    [UsedImplicitly]
    public class SpaceTokenManagementPostConfigureOptions : IPostConfigureOptions<SpaceOptions>
    {
        public void PostConfigure(string name, SpaceOptions options)
        {
            // Ensure refresh tokens are provided and stored
            options.AccessType = AccessType.Offline;
            options.SaveTokens = true;
        }
    }
}