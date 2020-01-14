using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.Common;

namespace SpaceDotNet.AspNetCore.Authentication.Space.TokenManagement
{
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>
    /// </remarks>
    public static class SpaceTokenManagementAuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddSpaceTokenManagement(this AuthenticationBuilder builder, Action<SpaceTokenManagementOptions> options)
        {
            builder.Services.Configure(options);
            return builder.AddSpaceTokenManagement();
        }

        public static AuthenticationBuilder AddSpaceTokenManagement(this AuthenticationBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddHttpContextAccessor();
            
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SpaceOptions>, SpaceTokenManagementPostConfigureOptions>());
            
            builder.Services.AddTransient<SpaceTokenManagementCookieEvents>();
            builder.Services.AddSingleton<IConfigureOptions<CookieAuthenticationOptions>, SpaceTokenManagementConfigureCookieOptions>();

            builder.Services.AddScoped<BearerTokenConnectionProvider>();
            builder.Services.AddScoped<Connection, BearerTokenConnection>(provider => 
                provider.GetService<BearerTokenConnectionProvider>().CreateAsync().GetAwaiter().GetResult());

            return builder;
        }
    }
}