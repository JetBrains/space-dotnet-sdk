using System;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SpaceDotNet.Client;
using SpaceDotNet.Common;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Space extension methods for <see cref="IServiceCollection"/>.
    /// </summary>
    [PublicAPI]
    public static class SpaceExtensions
    {
        /// <summary>
        /// Registers a Space <see cref="Connection"/> with a <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The current <see cref="IServiceCollection"/>.</param>
        /// <param name="connectionFactory">A factory that instantiates a <see cref="Connection"/>.</param>
        /// <param name="lifetime">The <see cref="ServiceLifetime"/> for this registration. Defaults to <see cref="ServiceLifetime.Transient"/>.</param>
        /// <typeparam name="TService">A type of <see cref="Connection"/>.</typeparam>
        /// <returns>The current <see cref="IServiceCollection"/>, with a registered Space <see cref="Connection"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when no <see cref="IServiceCollection"/> is provided.</exception>
        public static IServiceCollection AddSpaceConnection<TService>(
            this IServiceCollection services,
            Func<IServiceProvider, TService> connectionFactory,
            ServiceLifetime lifetime = ServiceLifetime.Transient)
            where TService : Connection
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAdd(new ServiceDescriptor(typeof(Connection), connectionFactory, lifetime));
            return services;
        }

        /// <summary>
        /// Registers the Space Client APIs with a <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The current <see cref="IServiceCollection"/>.</param>
        /// <returns>The current <see cref="IServiceCollection"/>, with registered Space Client APIs.</returns>
        /// <param name="lifetime">The <see cref="ServiceLifetime"/> for these registrations. Defaults to <see cref="ServiceLifetime.Transient"/>.</param>
        /// <exception cref="ArgumentNullException">Thrown when no <see cref="IServiceCollection"/> is provided.</exception>
        /// <exception cref="Exception">Thrown when the current <see cref="IServiceCollection"/> does not yet contain a registration for <see cref="Connection"/>. Call <see cref="AddSpaceConnection{TService}"/> before <see cref="AddSpaceClientApi"/>, or manually register a <see cref="Connection"/>.</exception>
        public static IServiceCollection AddSpaceClientApi(
            this IServiceCollection services,
            ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            // Add prerequisites
            services.AddHttpClient();
            
            // Is a Connection registered?
            var connectionType = typeof(Connection);
            if (!services.Any(it => connectionType.IsAssignableFrom(it.ServiceType)))
            {
                throw new InvalidOperationException("The current IServiceCollection does not yet contain a registration for Connection. " +
                                    "To register the Space API client types, call AddSpaceConnection() before AddSpaceClientApi(), or manually register a Connection.");
            }
            
            // Add Space ...Client types
            var spaceClientAssembly = typeof(TeamDirectoryClient).Assembly;
            foreach (var type in spaceClientAssembly.GetTypes().Where(t => !t.IsAbstract && t.Name.EndsWith("Client")))
            {
                services.TryAdd(new ServiceDescriptor(type, type, lifetime));
            }

            return services;
        }
    }
}