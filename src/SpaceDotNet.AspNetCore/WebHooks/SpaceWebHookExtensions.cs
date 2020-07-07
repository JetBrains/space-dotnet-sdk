using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    [PublicAPI]
    public static class SpaceWebHookExtensions
    {
        public static IServiceCollection AddSpaceWebHookReceiver(this IServiceCollection services)
        {
            // TODO WEBHOOK INJECT SETTINGS (signing key) + overloads that figure it out automatically
            
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<MvcOptions>, SpaceWebHookPostMvcConfigureOptions>());
            return services;
        }
    }
}