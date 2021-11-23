using System;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

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
        services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SpaceWebHookOptions>, SpaceSpaceWebHookPostConfigureOptions>());

        services.AddOptions<SpaceWebHookOptions>(optionsName)
            .Validate(o => o.VerifySigningKey == null || !o.VerifySigningKey.IsEnabled || !string.IsNullOrEmpty(o.VerifySigningKey.EndpointSigningKey), "Space.VerifySigningKey.EndpointSigningKey is required.")
            .Validate(o => o.VerifyHttpBearerToken == null || !o.VerifyHttpBearerToken.IsEnabled || !string.IsNullOrEmpty(o.VerifyHttpBearerToken.BearerToken), "Space.VerifyHttpBearerToken.BearerToken is required.")
            .Validate(o => o.VerifyHttpBasicAuthentication == null || !o.VerifyHttpBasicAuthentication.IsEnabled || !string.IsNullOrEmpty(o.VerifyHttpBasicAuthentication.Username), "Space.VerifyHttpBasicAuthentication.Username is required.")
            .Validate(o => o.VerifyHttpBasicAuthentication == null || !o.VerifyHttpBasicAuthentication.IsEnabled || !string.IsNullOrEmpty(o.VerifyHttpBasicAuthentication.Password), "Space.VerifyHttpBasicAuthentication.Password is required.")
            .Validate(o => o.VerifyVerificationToken == null || !o.VerifyVerificationToken.IsEnabled || !string.IsNullOrEmpty(o.VerifyVerificationToken.EndpointVerificationToken), "Space.VerifyVerificationToken.EndpointVerificationToken is required.");

        // Add webhook handler types
        services.AddScoped<TWebHookHandler>();
        services.AddScoped<SpaceWebHookRequestHandler<TWebHookHandler>>();
            
        // Add authentication handler types
        services.TryAddEnumerable(ServiceDescriptor.Transient<ISpaceEndpointAuthenticationHandler, VerifySigningKeyAuthenticationHandler>());
        services.TryAddEnumerable(ServiceDescriptor.Transient<ISpaceEndpointAuthenticationHandler, VerifyHttpBearerTokenAuthenticationHandler>());
        services.TryAddEnumerable(ServiceDescriptor.Transient<ISpaceEndpointAuthenticationHandler, VerifyHttpBasicAuthenticationHandler>());
        services.TryAddEnumerable(ServiceDescriptor.Transient<ISpaceEndpointAuthenticationHandler, VerifyVerificationTokenAuthenticationHandler>());
            
        return services;
    }
}