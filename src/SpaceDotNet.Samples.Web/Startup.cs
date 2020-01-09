using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = "Space";
                })
                .AddCookie()
                .AddOAuth("Space", options =>
                {
                    options.ClientId = Configuration["Space:ClientId"];
                    options.ClientSecret = Configuration["Space:ClientSecret"];
                    options.CallbackPath = new PathString("/signin-space");

                    options.AuthorizationEndpoint = Configuration["Space:AuthorizationEndpoint"];
                    options.TokenEndpoint = Configuration["Space:TokenEndpoint"];
                    
                    options.BackchannelHttpHandler = new ClientCredentialsForTokenEndpointHttpClientHandler(
                        options.ClientId, options.ClientSecret);

                    options.Scope.Add("**");
                    
                    options.UserInformationEndpoint = Configuration["Space:UserInformationEndpoint"];
                    
                    options.SaveTokens = true;

                    options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
                    options.ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
                    options.ClaimActions.MapJsonKey("urn:space:userid", "id");
                    options.ClaimActions.MapJsonKey("urn:space:username", "username");
                    options.ClaimActions.MapCustomJson("urn:space:smallAvatar", element => element.TryGetProperty("smallAvatar", out var p) ? Configuration["Space:BaseUrl"] + "/d/" + p.GetString() : null);
                    options.ClaimActions.MapCustomJson("urn:space:profilePicture", element => element.TryGetProperty("profilePicture", out var p) ? Configuration["Space:BaseUrl"] + "/d/" + p.GetString() : null);
                    options.ClaimActions.MapJsonSubKey("urn:space:firstName", "name", "firstName");
                    options.ClaimActions.MapJsonSubKey("urn:space:lastName", "name", "lastName");
                    options.ClaimActions.MapCustomJson("urn:space:email", element =>
                    {
                        if (element.TryGetProperty("emails", out var emailElements))
                        {
                            var emailElement = emailElements.EnumerateArray().FirstOrDefault();
                            if (emailElement.TryGetProperty("email", out var email))
                            {
                                return email.GetString();
                            }
                        }

                        return null;
                    });


                    options.Events = new OAuthEvents
                    {
                        OnCreatingTicket = async context =>
                        {
                            var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
                            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);
                            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            
                            var response = await context.Backchannel.SendAsync(request, context.HttpContext.RequestAborted);
                            response.EnsureSuccessStatusCode();
                            
                            using var meDocument = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
                            var me = meDocument.RootElement;
                            
                            context.RunClaimActions(me);
                        }
                    };
                });
            
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