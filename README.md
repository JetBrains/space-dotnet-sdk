# SpaceDotNet

The JetBrains Space SDK for .NET is a .NET library to work with the [JetBrains Space](https://jetbrains.com/space) API. 

## Getting Started

Default package: SpaceDotNet.Client
Generated client, depends on SpaceDotNet.Common for JSON serialization and more.

* Authentication/OAuth
* Various clients
* Partials (Default, Specific + extension methods)
* Batch vs IAsyncEnumerable

ASP.NET Core - SpaceDotNet.AspNetCore - Not required but helper to register all Space clients
IServiceCollection AddSpaceClientApi(this IServiceCollection services)
            services.AddHttpClient();
            + Add Space ...Client types (transient)
            
ASP.NET Core Authentication - SpaceDotNet.AspNetCore.Authentication.Space
Add Space auth, needs options:
            builder.Services.AddOptions<SpaceOptions>(authenticationScheme)
                .Validate(o => o.ServerUrl != null, "Space.ServerUrl is required.")
                .Validate(o => !string.IsNullOrEmpty(o.ClientId), "Space.ClientId is required.")
                .Validate(o => !string.IsNullOrEmpty(o.ClientSecret), "Space.ClientSecret is required.");

If not using identity model, can be used for token management to access Space API. Note this is experimental!

## Contributing

TODO