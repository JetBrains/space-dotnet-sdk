using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks.Formatters;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    [UsedImplicitly]
    public class SpaceWebHookPostMvcConfigureOptions : IPostConfigureOptions<MvcOptions>
    {
        private readonly ILoggerFactory _loggerFactory;

        public SpaceWebHookPostMvcConfigureOptions(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        
        public void PostConfigure(string name, MvcOptions options)
        {
            // TODO WEBHOOK INJECT SETTINGS (signing key) + overloads that figure it out automatically
            
            options.InputFormatters.Add(new SpaceActionPayloadInputFormatter(
                _loggerFactory.CreateLogger<SpaceActionPayloadInputFormatter>()));
        }
    }
}