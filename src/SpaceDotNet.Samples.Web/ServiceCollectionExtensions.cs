using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SpaceDotNet.Client;

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSpaceClientApi(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            var spaceClientAssembly = typeof(TeamDirectoryClient).Assembly;
            foreach (var type in spaceClientAssembly.GetTypes().Where(t => !t.IsAbstract && t.Name.EndsWith("Client")))
            {
                services.TryAddTransient(type);
            }

            return services;
        }
    }
}