using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpaceDotNet.AspNetCore.Authentication.Space;
using SpaceDotNet.AspNetCore.Authentication.Space.TokenManagement;
using SpaceDotNet.Client;

namespace SpaceDotNet.Samples.Web
{
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
            services.AddScoped<TeamDirectoryClient>();

            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = SpaceDefaults.AuthenticationScheme;
                })
                .AddCookie()
                .AddSpace(options => Configuration.Bind("Space", options))
                .AddSpaceTokenManagement(); // auto-refreshes tokens in the background and provides a Space connection

            // - or: -
                // .AddSpace(options =>
                // {
                //     options.ServerUrl = new Uri(Configuration["Space:ServerUrl"]);
                //     options.ClientId = Configuration["Space:ClientId"];
                //     options.ClientSecret = Configuration["Space:ClientSecret"];
                //
                //     options.Scope.Add("**");
                //     options.AccessType = AccessType.Offline;
                //     options.SaveTokens = true;
                // });
            
            services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}