using System;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SpaceDotNet.Client;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    [PublicAPI]
    public static class SpaceExtensions
    {
        public static IServiceCollection AddSpaceClientApi(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            // Add prerequisites
            services.AddHttpClient();
            
            // Add Space ...Client types
            var spaceClientAssembly = typeof(TeamDirectoryClient).Assembly;
            foreach (var type in spaceClientAssembly.GetTypes().Where(t => !t.IsAbstract && t.Name.EndsWith("Client")))
            {
                services.TryAddTransient(type);
            }

            return services;
        }
    }
}