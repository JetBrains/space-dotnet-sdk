using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Base64UrlTextEncoder = Microsoft.AspNetCore.Authentication.Base64UrlTextEncoder;

namespace JetBrains.Space.AspNetCore.Authentication
{
    /// <summary>
    /// A Space authentication handler for ASP.NET Core authentication.
    /// </summary>
    [UsedImplicitly]
    public class SpaceHandler : OAuthHandler<SpaceOptions>
    {
        private static readonly RandomNumberGenerator CryptoRandom = RandomNumberGenerator.Create();
        
        /// <summary>
        /// Creates a new <see cref="SpaceHandler"/> instance.
        /// </summary>
        /// <param name="options">Monitors for the <see cref="SpaceOptions"/> configuration of the current <see cref="SpaceHandler"/>.</param>
        /// <param name="logger">A <see cref="ILoggerFactory"/> for the current <see cref="SpaceHandler"/>.</param>
        /// <param name="encoder">A <see cref="UrlEncoder"/> for the current <see cref="SpaceHandler"/>.</param>
        /// <param name="clock">A <see cref="ISystemClock"/> for the current <see cref="SpaceHandler"/>.</param>
        public SpaceHandler(IOptionsMonitor<SpaceOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock) { }

        /// <inheritdoc />
        protected override async Task<AuthenticationTicket> CreateTicketAsync(
            ClaimsIdentity identity,
            AuthenticationProperties properties,
            OAuthTokenResponse tokens)
        {
            // Get the Space user
            var request = new HttpRequestMessage(HttpMethod.Get, Options.UserInformationEndpoint);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokens.AccessToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            
            var response = await Backchannel.SendAsync(request, Context.RequestAborted);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"An error occurred when retrieving Space user information ({response.StatusCode}). Please check if the authentication information is correct.");
            }
                            
            using var payload = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());
            var context = new OAuthCreatingTicketContext(new ClaimsPrincipal(identity), properties, Context, Scheme, Options, Backchannel, tokens, payload.RootElement);
            context.RunClaimActions();
            await Events.CreatingTicket(context);
            
            return new AuthenticationTicket(context.Principal!, context.Properties, Scheme.Name);
        }

        /// <inheritdoc />
        protected override string BuildChallengeUrl(AuthenticationProperties properties, string redirectUri)
        {
            var scopeParameter = properties.GetParameter<ICollection<string>>(OAuthChallengeProperties.ScopeKey);
            var scope = scopeParameter != null ? FormatScope(scopeParameter) : FormatScope();

            var parameters = new Dictionary<string, string?>
            {
                { "client_id", Options.ClientId },
                { "scope", scope },
                { "response_type", "code" },
                { "redirect_uri", redirectUri },
                { "request_credentials", Options.RequestCredentials.ToEnumString() },
                { "access_type", Options.AccessType.ToEnumString() }
            };

            if (Options.UsePkce)
            {
                var bytes = new byte[32];
                CryptoRandom.GetBytes(bytes);
                var codeVerifier = Base64UrlTextEncoder.Encode(bytes);

                // Store this for use during the code redemption.
                properties.Items.Add(OAuthConstants.CodeVerifierKey, codeVerifier);

                using var sha256 = SHA256.Create();
                var challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
                var codeChallenge = WebEncoders.Base64UrlEncode(challengeBytes);

                parameters[OAuthConstants.CodeChallengeKey] = codeChallenge;
                parameters[OAuthConstants.CodeChallengeMethodKey] = OAuthConstants.CodeChallengeMethodS256;
            }

            parameters["state"] = Options.StateDataFormat.Protect(properties);

            return QueryHelpers.AddQueryString(Options.AuthorizationEndpoint, parameters);
        }

        /// <inheritdoc />
        protected override async Task<OAuthTokenResponse> ExchangeCodeAsync(OAuthCodeExchangeContext context)
        {
            var tokenRequestParameters = new Dictionary<string, string?>
            {
                { "client_id", Options.ClientId },
                { "redirect_uri", context.RedirectUri },
                { "client_secret", Options.ClientSecret },
                { "code", context.Code },
                { "grant_type", "authorization_code" }
            };

            // PKCE https://tools.ietf.org/html/rfc7636#section-4.5, see BuildChallengeUrl
            if (context.Properties.Items.TryGetValue(OAuthConstants.CodeVerifierKey, out var codeVerifier))
            {
                tokenRequestParameters.Add(OAuthConstants.CodeVerifierKey, codeVerifier);
                context.Properties.Items.Remove(OAuthConstants.CodeVerifierKey);
            }

#pragma warning disable 8620 // new Dictionary<string, string?> -> new FormUrlEncodedContent(tokenRequestParameters)
            var requestContent = new FormUrlEncodedContent(tokenRequestParameters);
#pragma warning restore 8620

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, Options.TokenEndpoint);
            requestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse(
                "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Options.ClientId}:{Options.ClientSecret}")));
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Content = requestContent;
            var response = await Backchannel.SendAsync(requestMessage, Context.RequestAborted);
            if (response.IsSuccessStatusCode)
            {
                var payload = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
                return OAuthTokenResponse.Success(payload);
            }

            var error = "OAuth token endpoint failure: " + await Display(response);
            return OAuthTokenResponse.Failed(new Exception(error));
        }

        private static async Task<string> Display(HttpResponseMessage response)
        {
            var output = new StringBuilder();
            output.Append("Status: " + response.StatusCode + ";");
            output.Append("Headers: " + response.Headers + ";");
            output.Append("Body: " + await response.Content.ReadAsStringAsync() + ";");
            return output.ToString();
        }
    }
}