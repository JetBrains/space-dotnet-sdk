using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.AspNetCore.WebHooks.Formatters;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    [PublicAPI]
    public static class SpaceWebHookExtensions
    {
        public static IServiceCollection AddSpaceWebHookReceiver(this IServiceCollection services)
            => AddSpaceWebHookReceiver(services, _ => { });
        
        public static IServiceCollection AddSpaceWebHookReceiver(this IServiceCollection services, Action<SpaceWebHookOptions> configureOptions)
        {
            services.Configure(configureOptions);
            
            services.AddOptions<SpaceWebHookOptions>()
                .Validate(o => !string.IsNullOrEmpty(o.EndpointSigningKey), "Space.EndpointSigningKey is required.")
                .Validate(o => !string.IsNullOrEmpty(o.EndpointVerificationToken), "Space.EndpointVerificationToken is required.");
            
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<MvcOptions>, SpaceWebHookPostMvcConfigureOptions>());

            services.TryAddSingleton<SpaceActionPayloadInputFormatter>();
            
            return services;
        }
    }

    /// <summary>
    /// Configuration options for Space WebHooks integration.
    /// </summary>
    [PublicAPI]
    public class SpaceWebHookOptions
    {
        /// <summary>
        /// Endpoint signing key. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string EndpointSigningKey { get; set; } = default!;

        /// <summary>
        /// Endpoint verification token. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string EndpointVerificationToken { get; set; } = default!;
    }
}