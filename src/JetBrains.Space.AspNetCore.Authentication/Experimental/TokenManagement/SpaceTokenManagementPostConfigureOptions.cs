using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Authentication.Experimental.TokenManagement;

/// <summary>
/// An <see cref="IPostConfigureOptions{T}"/> that configures <see cref="SpaceOptions"/>.
/// </summary>
[UsedImplicitly]
public class SpaceTokenManagementPostConfigureOptions : IPostConfigureOptions<SpaceOptions>
{
    /// <inheritdoc />
    public void PostConfigure(string name, SpaceOptions options)
    {
        // Ensure refresh tokens are provided and stored
        options.AccessType = AccessType.Offline;
        options.SaveTokens = true;
    }
}