using System;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc.Controllers;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to register Space application webhook handlers in an <see cref="IServiceCollection"/>.
    /// </summary>
    [PublicAPI]
    public static class SpaceAddWebHookExtensions
    {
        /// <summary>
        /// Registers a <see cref="ISpaceWebHookHandler"/> in the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register the <typeparamref name="TWebHookHandler"/> in.</param>
        /// <typeparam name="TWebHookHandler">The <see cref="ISpaceWebHookHandler"/> that handles application webhook payloads.</typeparam>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddSpaceWebHookHandler<TWebHookHandler>(this IServiceCollection services)
            where TWebHookHandler : class, ISpaceWebHookHandler
        {
            return AddSpaceWebHookHandler<TWebHookHandler>(services, _ => { });
        }

        /// <summary>
        /// Registers a <see cref="ISpaceWebHookHandler"/> in the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register the <typeparamref name="TWebHookHandler"/> in.</param>
        /// <param name="configureOptions">An <see cref="Action{T}"/> that further configures <see cref="SpaceWebHookOptions"/>.</param>
        /// <typeparam name="TWebHookHandler">The <see cref="ISpaceWebHookHandler"/> that handles application webhook payloads.</typeparam>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddSpaceWebHookHandler<TWebHookHandler>(this IServiceCollection services, Action<SpaceWebHookOptions> configureOptions)
            where TWebHookHandler : class, ISpaceWebHookHandler
        {
            // Options
            var optionsName = typeof(TWebHookHandler).Name;
            services.Configure(optionsName, configureOptions);
            
            services.AddOptions<SpaceWebHookOptions>(optionsName)
                .Validate(o => !o.ValidatePayloadSignature || !string.IsNullOrEmpty(o.EndpointSigningKey), "Space.EndpointSigningKey is required.")
                .Validate(o => !o.ValidatePayloadVerificationToken || !string.IsNullOrEmpty(o.EndpointVerificationToken), "Space.EndpointVerificationToken is required.");

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