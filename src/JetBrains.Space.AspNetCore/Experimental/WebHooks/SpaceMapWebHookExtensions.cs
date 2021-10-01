using System;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Builder;

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
            
        // Is a handler registered?
        var handler = endpoints.ServiceProvider.GetService<TWebHookHandler?>();
        if (handler == null)
        {
            throw new InvalidOperationException(
                $"Unable to resolve the scoped {typeof(TWebHookHandler)} service. Make sure to call {nameof(SpaceAddWebHookExtensions.AddSpaceWebHookHandler)}<{typeof(TWebHookHandler)}>(...) in ConfigureServices(...)");
        }

        // Map webhook handler to request
        return endpoints.MapPost(path, async context =>
        {
            var optionsName = typeof(TWebHookHandler).Name;
            var requestHandler = context.RequestServices.GetRequiredService<SpaceWebHookRequestHandler<TWebHookHandler>>();
            await requestHandler.HandleAsync(context, optionsName);
        });
    }
}