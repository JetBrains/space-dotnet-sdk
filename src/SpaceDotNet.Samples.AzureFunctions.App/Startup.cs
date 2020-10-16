using System;
using System.IO;
using System.Net.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceDotNet.Common;
using SpaceDotNet.Samples.AzureFunctions.App.WebHooks;

[assembly: FunctionsStartup(typeof(SpaceDotNet.Samples.AzureFunctions.App.Startup))]

namespace SpaceDotNet.Samples.AzureFunctions.App
{
    public class Startup : FunctionsStartup
    {
        public IConfiguration Configuration { get; set; }
        
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            var context = builder.GetContext();

            builder.ConfigurationBuilder
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, "appsettings.json"), optional: true, reloadOnChange: false)
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, $"appsettings.{context.EnvironmentName}.json"), optional: true, reloadOnChange: false)
                .AddUserSecrets<Startup>(optional: true, reloadOnChange: false)
                .AddEnvironmentVariables();

            Configuration = builder.ConfigurationBuilder.Build();
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();

            // Space client API
            builder.Services.AddSingleton<Connection>(provider => 
                new ClientCredentialsConnection(
                    new Uri(Configuration["Space:ServerUrl"]),
                    Configuration["Space:ClientId"],
                    Configuration["Space:ClientSecret"],
                    provider.GetService<IHttpClientFactory>().CreateClient()));
            builder.Services.AddSpaceClientApi();
            
            // Space webhook handler
            builder.Services.AddSpaceWebHookHandler<CateringWebHookHandler>(options => Configuration.Bind("Space", options));
            //builder.Services.AddHostedService<CateringWebHookHandlerStartupTask>();

            // - or: -
            // builder.Services.AddSpaceWebHookHandler<CateringWebHookHandler>(options =>
            // {
            //     options.EndpointSigningKey = Configuration["Space:EndpointSigningKey"];
            //     options.EndpointVerificationToken = Configuration["Space:EndpointVerificationToken"];
            // });
        }
    }
}