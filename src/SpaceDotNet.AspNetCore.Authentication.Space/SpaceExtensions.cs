using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.Authentication.Space;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class SpaceExtensions
    {
        public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder)
            => builder.AddSpace(SpaceDefaults.AuthenticationScheme, _ => { });

        public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, Action<SpaceOptions> configureOptions)
            => builder.AddSpace(SpaceDefaults.AuthenticationScheme, configureOptions);

        public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, string authenticationScheme, Action<SpaceOptions> configureOptions)
            => builder.AddSpace(authenticationScheme, SpaceDefaults.DisplayName, configureOptions);

        public static AuthenticationBuilder AddSpace(this AuthenticationBuilder builder, string authenticationScheme, string displayName, Action<SpaceOptions> configureOptions)
        {
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SpaceOptions>, SpacePostConfigureOptions>());
            
            builder.Services.AddOptions<SpaceOptions>(authenticationScheme)
                .Validate(o => o.ServerUrl != null, "Space.ServerUrl is required.")
                .Validate(o => !string.IsNullOrEmpty(o.ClientId), "Space.ClientId is required.")
                .Validate(o => !string.IsNullOrEmpty(o.ClientSecret), "Space.ClientSecret is required.");

            return builder.AddOAuth<SpaceOptions, SpaceHandler>(authenticationScheme, displayName, configureOptions);
        }
    }
}