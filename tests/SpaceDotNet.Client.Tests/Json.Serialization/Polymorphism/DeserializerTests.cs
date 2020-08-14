using System.Text.Json;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using Xunit;

namespace SpaceDotNet.Client.Tests.Json.Serialization.Polymorphism
{
    public class DeserializerTests
    {
        private JsonSerializerOptions CreateSerializerOptions() =>
            new JsonSerializerOptions
            {
                MaxDepth = 32,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }.AddSpacePolymorphismConverters();


        [Fact]
        public void CanDeserializeObjectWithPolymorphClasses()
        {
            var inputJsonString = "{\"className\":\"MessagePayload\",\"message\":{\"className\":\"MessageContext\",\"messageId\":\"Awz170S411h\",\"channelId\":\"Bwz170S411h\",\"body\":{\"className\":\"ChatMessage.Text\",\"text\":\"\"},\"attachments\":[{\"className\":\"ImageAttachment\",\"id\":\"2kiQQS3p8rqs\",\"name\":\"image.png\",\"width\":62,\"height\":83,\"previewBytes\":\"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAAFElEQVQoU2P8////fwY8gHFkKAAANHof6XqBXl0AAAAASUVORK5CYII=\",\"variants\":[{\"className\":\"ImageAttachmentVariant\",\"id\":\"34KD5j2kEAXg\",\"name\":\"chat-image-preview\",\"width\":62,\"height\":83},{\"className\":\"ImageAttachmentVariant\",\"id\":\"398MlK4XsNuH\",\"name\":\"chat-image-preview-2x\",\"width\":62,\"height\":83}]}],\"createdTime\":\"2020-08-14T10:48:05.622Z\"},\"accessToken\":\"aaaaaaaa\",\"verificationToken\":\"aaaaaaaaaaa\",\"userId\":\"faaaaaaaO\"}";

            var result = JsonSerializer.Deserialize(inputJsonString, typeof(ApplicationPayloadDto), CreateSerializerOptions());

            Assert.NotNull(result);
            Assert.IsType<MessagePayloadDto>(result);
            if (result is MessagePayloadDto messagePayloadDto)
            {
                Assert.NotNull(messagePayloadDto.Message.Body);
                
                Assert.IsType<ChatMessageTextDto>(messagePayloadDto.Message.Body);
                if (messagePayloadDto.Message.Body is ChatMessageTextDto messageTextDto)
                {
                    Assert.NotNull(messageTextDto.Text);
                }
                
                Assert.NotNull(messagePayloadDto.Message.Attachments);
                Assert.NotEmpty(messagePayloadDto.Message.Attachments!);
            }
        }
    }
}