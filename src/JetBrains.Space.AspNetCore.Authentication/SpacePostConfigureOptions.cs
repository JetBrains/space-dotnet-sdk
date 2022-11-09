using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Authentication;

/// <summary>
/// An <see cref="IPostConfigureOptions{T}"/> that configures <see cref="SpaceOptions"/>.
/// </summary>
[UsedImplicitly]
public class SpacePostConfigureOptions : IPostConfigureOptions<SpaceOptions>
{
    /// <inheritdoc />
    public void PostConfigure(string? name, SpaceOptions options)
    {
        if (options.Scope.Count == 0)
        {
            // REVIEW: Should we use a more narrow scope here by default? https://www.jetbrains.com/help/space/client-credentials.html#request
            options.Scope.Add("**");
        }
    }
}