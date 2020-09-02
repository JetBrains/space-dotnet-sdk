using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.AspNetCore.WebHooks.Mvc;
using SpaceDotNet.AspNetCore.WebHooks.Mvc.Controllers;
using SpaceDotNet.AspNetCore.WebHooks.Mvc.Formatters;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    [PublicAPI]
    public static class SpaceAddWebHookExtensions
    {
        public static IServiceCollection AddSpaceWebHookHandler<TWebHookHandler>(this IServiceCollection services)
            where TWebHookHandler : class, ISpaceWebHookHandler
        {
            return AddSpaceWebHookHandler<TWebHookHandler>(services, _ => { });
        }
        
        public static IServiceCollection AddSpaceWebHookHandler<TWebHookHandler>(this IServiceCollection services, Action<SpaceWebHookOptions> configureOptions)
            where TWebHookHandler : class, ISpaceWebHookHandler
        {
            // Options
            var optionsName = "Space_" + typeof(TWebHookHandler).Name;
            services.Configure(optionsName, configureOptions);
            
            services.AddOptions<SpaceWebHookOptions>(optionsName)
                .Validate(o => !string.IsNullOrEmpty(o.EndpointSigningKey), "Space.EndpointSigningKey is required.")
                .Validate(o => !string.IsNullOrEmpty(o.EndpointVerificationToken), "Space.EndpointVerificationToken is required.");

            // We're leaning on MVC, so need to have a minimal setup of that...
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<MvcOptions>, SpaceWebHookPostMvcConfigureOptions>());
            services.TryAddSingleton<SpaceActionPayloadInputFormatter>();
            services.AddControllers();
            
            // Add controller + handler
            services.TryAddTransient<SpaceWebHookController>();
            services.AddTransient<TWebHookHandler>();
            
            return services;
        }
    }
}