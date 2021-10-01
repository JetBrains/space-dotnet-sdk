using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
// TODO: Class to be removed with SpaceWebHookOptions.ValidatePayloadVerificationToken.

/// <summary>
/// An <see cref="IPostConfigureOptions{TOptions}"/> that configures <see cref="SpaceWebHookOptions"/>.
/// </summary>
[UsedImplicitly]
[Obsolete("To be removed with SpaceWebHookOptions.ValidatePayloadVerificationToken.")]
public class SpaceSpaceWebHookPostConfigureOptions : IPostConfigureOptions<SpaceWebHookOptions>
{
    /// <inheritdoc />
    public void PostConfigure(string name, SpaceWebHookOptions options)
    {
        // Handle deprecated options
        if (options.ValidatePayloadSignature &&
            options.VerifySigningKey == null && 
            options.VerifyHttpBearerToken == null &&
            options.VerifyHttpBasicAuthentication == null)
        {
            options.VerifySigningKey = new VerifySigningKeyOptions
            {
                EndpointSigningKey = options.EndpointSigningKey
            };
        }
            
        if (options.ValidatePayloadSignature && 
            options.VerifyVerificationToken == null)
        {
            options.VerifyVerificationToken = new VerifyVerificationTokenOptions
            {
                EndpointVerificationToken = options.EndpointVerificationToken
            };
        }
    }
}