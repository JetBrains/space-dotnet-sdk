using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.Common;

namespace SpaceDotNet.AspNetCore.Authentication.Space.Experimental.TokenManagement
{
    /// <summary>
    /// Extension methods to register and configure Space token management.
    /// </summary>
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>.
    /// </remarks>
    [PublicAPI]
    public static class SpaceTokenManagementAuthenticationBuilderExtensions
    {
        /// <summary>
        /// Register Space token management.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register Space token management.</param>
        /// <param name="configureOptions">An <see cref="Action{T}"/> that further configures <see cref="SpaceOptions"/>.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddSpaceTokenManagement(
            this AuthenticationBuilder builder, Action<SpaceTokenManagementOptions> configureOptions)
        {
            builder.Services.Configure(configureOptions);
            return builder.AddSpaceTokenManagement();
        }

        /// <summary>
        /// Register Space token management.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/> used to register Space token management.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddSpaceTokenManagement(this AuthenticationBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddHttpContextAccessor();
            
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SpaceOptions>, SpaceTokenManagementPostConfigureOptions>());
            
            builder.Services.AddTransient<SpaceTokenManagementCookieEvents>();
            builder.Services.AddSingleton<IConfigureOptions<CookieAuthenticationOptions>, SpaceTokenManagementConfigureCookieOptions>();

            builder.Services.AddScoped<BearerTokenConnectionProvider>();
            builder.Services.AddScoped<Connection, BearerTokenConnection>(provider => 
                provider.GetService<BearerTokenConnectionProvider>().CreateAsync().GetAwaiter().GetResult()!);

            return builder;
        }
    }
}