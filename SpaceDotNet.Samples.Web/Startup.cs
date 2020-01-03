using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;

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

                    options.Events = new OAuthEvents
                    {
                        OnCreatingTicket = async context =>
                        {
                            var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
                            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);
                            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            
                            var response = await context.Backchannel.SendAsync(request, context.HttpContext.RequestAborted);
                            response.EnsureSuccessStatusCode();
                            
                            var me = JObject.Parse(await response.Content.ReadAsStringAsync());
                            
                            if (me["id"] != null) context.Identity.AddClaim(new Claim("urn:space:userid", me.Value<string>("id")));
                            if (me["username"] != null) context.Identity.AddClaim(new Claim("urn:space:username", me.Value<string>("username")));
                            if (me["smallAvatar"] != null) context.Identity.AddClaim(new Claim("urn:space:smallAvatar", Configuration["Space:BaseUrl"] + "/d/" + me.Value<string>("smallAvatar")));
                            if (me["profilePicture"] != null) context.Identity.AddClaim(new Claim("urn:space:profilePicture", Configuration["Space:BaseUrl"] + "/d/" +me.Value<string>("profilePicture")));

                            if (me["name"] != null)
                            {
                                context.Identity.AddClaim(new Claim("urn:space:firstName", me["name"].Value<string>("firstName")));
                                context.Identity.AddClaim(new Claim("urn:space:lastName", me["name"].Value<string>("lastName")));
                                context.Identity.AddClaim(new Claim("urn:space:fullName", me["name"].Value<string>("firstName") + " " + me["name"].Value<string>("lastName")));
                            }
                            
                            if (me["emails"] != null)
                            {
                                context.Identity.AddClaim(new Claim("urn:space:emails", me["emails"].AsJEnumerable().First().Value<string>("email")));
                            }
                            
                            context.RunClaimActions();
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