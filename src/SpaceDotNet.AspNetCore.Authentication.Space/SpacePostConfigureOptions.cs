using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace SpaceDotNet.AspNetCore.Authentication.Space
{
    [UsedImplicitly]
    public class SpacePostConfigureOptions : IPostConfigureOptions<SpaceOptions>
    {
        public void PostConfigure(string name, SpaceOptions options)
        {
            if (options.Scope.Count == 0)
            {
                // REVIEW: Should we use a more narrow scope here? https://www.jetbrains.com/help/space/client-credentials.html#request
                options.Scope.Add("**");
            }
        }
    }
}