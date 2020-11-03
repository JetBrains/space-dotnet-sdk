using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using SpaceDotNet.AspNetCore.Experimental.WebHooks;
using SpaceDotNet.AspNetCore.Experimental.WebHooks.Mvc.Controllers;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Extension methods to map Space application webhook handlers on an <see cref="IEndpointRouteBuilder"/>.
    /// </summary>
    [PublicAPI]
    public static class SpaceMapWebHookExtensions
    {
        /// <summary>
        /// Map a <typeparamref name="TWebHookHandler"/> to an endpoint <paramref name="path"/>.
        /// </summary>
        /// <param name="endpoints">The <see cref="IEndpointRouteBuilder"/> input.</param>
        /// <param name="path">The URL path to register the <typeparamref name="TWebHookHandler"/> on.</param>
        /// <typeparam name="TWebHookHandler">The <see cref="ISpaceWebHookHandler"/> that handles application webhook payloads.</typeparam>
        /// <returns>An <see cref="IEndpointConventionBuilder"/> that can be used to further configure the webhook handler registration.</returns>
        /// <exception cref="ArgumentNullException">When <paramref name="path"/> is null or empty.</exception>
        /// <exception cref="InvalidOperationException">When <typeparamref name="TWebHookHandler"/> is not registered in the service provider.</exception>
        public static IEndpointConventionBuilder MapSpaceWebHookHandler<TWebHookHandler>(this IEndpointRouteBuilder endpoints, string path)
            where TWebHookHandler : class, ISpaceWebHookHandler
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }
            
            var handler = endpoints.ServiceProvider.GetService<TWebHookHandler>();
            if (handler == null)
            {
                throw new InvalidOperationException(
                    $"Unable to find {typeof(TWebHookHandler)} in {nameof(IServiceCollection)}. Make sure to call {nameof(SpaceAddWebHookExtensions.AddSpaceWebHookHandler)}<{typeof(TWebHookHandler)}>(...) in ConfigureServices(...)");
            }
            
            return endpoints.MapControllerRoute("Space_" + typeof(TWebHookHandler).Name, path,
                defaults: new
                {
                    controller = nameof(SpaceWebHookController).Replace("Controller", string.Empty),
                    action = nameof(SpaceWebHookController.Receive),
                    handlerType = typeof(TWebHookHandler), // RouteKeyConstants.HandlerType
                    optionsName = typeof(TWebHookHandler).Name // RouteKeyConstants.OptionsName
                });
        }
    }
}