using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.AspNetCore.WebHooks.Json.Serialization;

namespace SpaceDotNet.AspNetCore.WebHooks.Types
{
    [PublicAPI]
    public class ActionPayload
        : IWebHookPayload
    {
        [JsonPropertyName("className")]
        public string? ClassName => "ActionPayload";

        /// <summary>
        /// User that triggered the action.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Action identifier.
        /// </summary>
        [JsonPropertyName("actionId")]
        public string ActionId { get; set; } = default!;

        /// <summary>
        /// Action value.
        /// </summary>
        [JsonPropertyName("actionValue")]
        public string? ActionValue { get; set; }

        /// <summary>
        /// Access token of the current application.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// Verification token. This should be identical to the verification token for the configured application. If not, the payload should be rejected.
        /// </summary>
        [JsonPropertyName("verificationToken")]
        public string VerificationToken { get; set; } = default!;

        /// <summary>
        /// Message context.
        /// </summary>
        [JsonPropertyName("context")]
        [JsonConverter(typeof(ClassNameWebHookPayloadTypeConverter))]
        public MessageContext? Context { get; set; }
    }
}