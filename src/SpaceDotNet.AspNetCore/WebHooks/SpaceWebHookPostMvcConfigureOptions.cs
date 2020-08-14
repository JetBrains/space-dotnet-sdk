using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SpaceDotNet.AspNetCore.WebHooks.Formatters;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    [UsedImplicitly]
    public class SpaceWebHookPostMvcConfigureOptions : IPostConfigureOptions<MvcOptions>
    {
        private readonly SpaceActionPayloadInputFormatter _inputFormatter;

        public SpaceWebHookPostMvcConfigureOptions(SpaceActionPayloadInputFormatter inputFormatter)
        {
            _inputFormatter = inputFormatter;
        }
        
        public void PostConfigure(string name, MvcOptions options) =>
            options.InputFormatters.Insert(0, _inputFormatter);
    }
}