using System;
using System.Net.Http;
using JetBrains.Space.Common;
using JetBrains.Space.Samples.App.WebHooks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JetBrains.Space.Samples.App;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Routing
        services.AddRouting(options => options.LowercaseUrls = true);
        services.AddHttpClient();

        // Space client API
        services.AddSingleton<Connection>(provider => 
            new ClientCredentialsConnection(
                new Uri(Configuration["Space:ServerUrl"]),
                Configuration["Space:ClientId"],
                Configuration["Space:ClientSecret"],
                provider.GetService<IHttpClientFactory>().CreateClient()));
        services.AddSpaceClientApi();
            
        // Space webhook handler
        services.AddSpaceWebHookHandler<CateringWebHookHandler>(options => Configuration.Bind("Space", options));

        // - or: -
        // services.AddSpaceWebHookHandler<CateringWebHookHandler>(options =>
        // {
        //     options.EndpointSigningKey = Configuration["Space:EndpointSigningKey"];
        //     options.EndpointVerificationToken = Configuration["Space:EndpointVerificationToken"];
        // });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            // Space webhook receiver endpoint
            endpoints.MapSpaceWebHookHandler<CateringWebHookHandler>("/space/receive");

            endpoints.Map("/", async context =>
            {
                context.Response.ContentType = "text/plain; charset=utf-8";
                await context.Response.WriteAsync("Space app is running.");
            });
        });
    }
}