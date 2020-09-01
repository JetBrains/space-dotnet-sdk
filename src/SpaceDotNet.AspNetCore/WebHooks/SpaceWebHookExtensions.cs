using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.AspNetCore.WebHooks.Mvc;
using SpaceDotNet.AspNetCore.WebHooks.Mvc.Formatters;

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
}