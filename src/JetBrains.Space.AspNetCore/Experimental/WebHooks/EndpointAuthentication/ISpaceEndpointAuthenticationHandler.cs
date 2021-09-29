using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using Microsoft.AspNetCore.Http;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication
{
    /// <summary>
    /// Handle Space endpoint authentication.
    /// </summary>
    [PublicAPI]
    public interface ISpaceEndpointAuthenticationHandler
    {
        /// <summary>
        /// Handles the Space endpoint request represented by <paramref name="payload"/>
        /// </summary>
        /// <param name="optionsName">The (optional) name of the <see cref="SpaceWebHookOptions"/> options that apply.</param>
        /// <param name="context">The HTTP context.</param>
        /// <param name="requestBody">The HTTP request body as string.</param>
        /// <param name="payload">The payload to validate.</param>
        /// <returns><see langword="true"/> if the request is valid or the current <see cref="ISpaceEndpointAuthenticationHandler"/> is not applicable; <see langword="false"/> otherwise.</returns>
        Task<bool> AuthenticateRequestAsync(
            string? optionsName,
            HttpContext context, 
            string requestBody, 
            ApplicationPayload? payload);
    }
}