using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using SpaceDotNet.AspNetCore.WebHooks;
using SpaceDotNet.AspNetCore.WebHooks.Mvc.Controllers;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Builder
{
    public static class SpaceMapWebHookExtensions
    {
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