using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Extension methods to register and configure the Space authentication provider for ASP.NET Core.
/// </summary>
[PublicAPI]
public static class SpaceExtensions
{
    /// <summary>
    /// Register the Space authentication provider for ASP.NET Core.
    /// </summary>
    /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register the Space authentication provider.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder)
        => builder.AddSpace(SpaceDefaults.AuthenticationScheme, _ => { });

    /// <summary>
    /// Register the Space authentication provider for ASP.NET Core.
    /// </summary>
    /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register the Space authentication provider.</param>
    /// <param name="configureOptions">An <see cref="Action{T}"/> that further configures <see cref="SpaceOptions"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, Action<SpaceOptions> configureOptions)
        => builder.AddSpace(SpaceDefaults.AuthenticationScheme, configureOptions);

    /// <summary>
    /// Register the Space authentication provider for ASP.NET Core.
    /// </summary>
    /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register the Space authentication provider.</param>
    /// <param name="authenticationScheme">The authentication scheme name for the Space authentication provider.</param>
    /// <param name="configureOptions">An <see cref="Action{T}"/> that further configures <see cref="SpaceOptions"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, string authenticationScheme, Action<SpaceOptions> configureOptions)
        => builder.AddSpace(authenticationScheme, SpaceDefaults.DisplayName, configureOptions);

    /// <summary>
    /// Register the Space authentication provider for ASP.NET Core.
    /// </summary>
    /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register the Space authentication provider.</param>
    /// <param name="authenticationScheme">The authentication scheme name for the Space authentication provider.</param>
    /// <param name="displayName">The display name for the Space authentication provider.</param>
    /// <param name="configureOptions">An <see cref="Action{T}"/> that further configures <see cref="SpaceOptions"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, string authenticationScheme, string displayName, Action<SpaceOptions> configureOptions)
    {
        builder.Services.AddOptions<SpaceOptions>(authenticationScheme)
            .Validate(o => o.ServerUrl != null, "Space.ServerUrl is required.")
            .Validate(o => !string.IsNullOrEmpty(o.ClientId), "Space.ClientId is required.")
            .Validate(o => !string.IsNullOrEmpty(o.ClientSecret), "Space.ClientSecret is required.");

        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SpaceOptions>, SpacePostConfigureOptions>());

        return builder.AddOAuth<SpaceOptions, SpaceHandler>(authenticationScheme, displayName, configureOptions);
    }
}