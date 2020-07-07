using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.AspNetCore.WebHooks.Types
{
    [PublicAPI]
    public class MessageContext
        : IWebHookPayload
    {
        [JsonPropertyName("className")]
        public string? ClassName => "MessageContext";

        /// <summary>
        /// Message identifier.
        /// </summary>
        [JsonPropertyName("messageId")]
        public string MessageId { get; set; } = default!;

        /// <summary>
        ///  Channel identifier.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; } = default!;

        /// <summary>
        /// Body.
        /// </summary>
        [JsonPropertyName("body")]
        [JsonConverter(typeof(ClassNameDtoTypeConverter))]
        public IClassNameConvertible? Body { get; set; } // TODO WEBHOOK
    }
}