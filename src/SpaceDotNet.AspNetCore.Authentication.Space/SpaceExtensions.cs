using System;
using Microsoft.AspNetCore.Authentication;
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
            => builder.AddOAuth<SpaceOptions, SpaceHandler>(authenticationScheme, displayName, configureOptions);
    }
}