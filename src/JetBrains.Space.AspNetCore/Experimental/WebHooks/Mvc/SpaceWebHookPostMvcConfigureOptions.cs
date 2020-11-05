using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc
{
    /// <summary>
    /// An <see cref="IPostConfigureOptions{T}"/> that configures <see cref="MvcOptions"/>.
    /// </summary>
    [UsedImplicitly]
    public class SpaceWebHookPostMvcConfigureOptions : IPostConfigureOptions<MvcOptions>
    {
        private readonly SpaceActionPayloadInputFormatter _inputFormatter;

        /// <summary>
        /// Creates a new <see cref="SpaceWebHookPostMvcConfigureOptions"/> instance.
        /// </summary>
        /// <param name="inputFormatter">The <see cref="SpaceActionPayloadInputFormatter"/> to register when the current <see cref="MvcOptions"/> are configured.</param>
        public SpaceWebHookPostMvcConfigureOptions(SpaceActionPayloadInputFormatter inputFormatter)
        {
            _inputFormatter = inputFormatter;
        }
        
        /// <inheritdoc />
        public void PostConfigure(string name, MvcOptions options) =>
            options.InputFormatters.Insert(0, _inputFormatter);
    }
}