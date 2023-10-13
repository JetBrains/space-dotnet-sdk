using System.Text.Json;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization.Polymorphism;

public class DeserializerTests
{
    [Fact]
    public void CanDeserializeObjectWithPolymorphClasses()
    {
        var inputJsonString = "{\"className\":\"MessagePayload\",\"message\":{\"className\":\"MessageContext\",\"messageId\":\"Awz170S411h\",\"channelId\":\"Bwz170S411h\",\"body\":{\"className\":\"ChatMessage.Text\",\"text\":\"\"},\"attachments\":[{\"className\":\"ImageAttachment\",\"id\":\"2kiQQS3p8rqs\",\"name\":\"image.png\",\"width\":62,\"height\":83,\"previewBytes\":\"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAAFElEQVQoU2P8////fwY8gHFkKAAANHof6XqBXl0AAAAASUVORK5CYII=\",\"variants\":[{\"className\":\"ImageAttachmentVariant\",\"id\":\"34KD5j2kEAXg\",\"name\":\"chat-image-preview\",\"width\":62,\"height\":83},{\"className\":\"ImageAttachmentVariant\",\"id\":\"398MlK4XsNuH\",\"name\":\"chat-image-preview-2x\",\"width\":62,\"height\":83}]}],\"createdTime\":\"2020-08-14T10:48:05.622Z\"},\"accessToken\":\"aaaaaaaa\",\"verificationToken\":\"aaaaaaaaaaa\",\"userId\":\"faaaaaaaO\"}";

        var result = JsonSerializer.Deserialize(inputJsonString, typeof(ApplicationPayload), Defaults.CreateSerializerOptions());

        Assert.NotNull(result);
        Assert.IsType<MessagePayload>(result);
        if (result is MessagePayload messagePayload)
        {
            Assert.NotNull(messagePayload.Message.Body);
                
            Assert.IsType<ChatMessageText>(messagePayload.Message.Body);
            if (messagePayload.Message.Body is ChatMessageText messageText)
            {
                Assert.NotNull(messageText.Text);
            }
                
            Assert.NotNull(messagePayload.Message.Attachments);
            Assert.NotEmpty(messagePayload.Message.Attachments!);
        }
    }

    [Fact] // https://github.com/JetBrains/space-dotnet-sdk/issues/3
    public void CanDeserializeObjectWithPolymorphClasses_Repro_GH3()
    {
        var inputJsonString = "{\"customFields\":{\"Custom Field\":{\"className\":\"EnumListCFValue\",\"values\":[{\"id\":\"abcdefg1\",\"value\":\"Field value 1\"},{\"id\":\"abcdefg2\",\"value\":\"Field value 2\"}]}}}";

        var result = JsonSerializer.Deserialize(inputJsonString, typeof(Issue), Defaults.CreateSerializerOptions());

        Assert.NotNull(result);
        Assert.IsType<Issue>(result);
        if (result is Issue issue)
        {
            Assert.NotNull(issue.CustomFields);
            Assert.Equal("Custom Field", issue.CustomFields.Keys.First());

            var customField = issue.CustomFields.Values.First();
                
            Assert.NotNull(customField);
            Assert.IsType<EnumListCFValue>(customField);
            if (customField is EnumListCFValue customFieldValue)
            {
                Assert.NotEmpty(customFieldValue.Values);
                Assert.Equal("abcdefg1", customFieldValue.Values[0].Id);
                Assert.Equal("abcdefg2", customFieldValue.Values[1].Id);
            }
        }
    }

    [Fact]
    public void CanDeserializeObjectWithPolymorphClasses_Repro_PayloadContextNull()
    {
        var inputJsonString = "{\n  \"className\": \"MenuActionPayload\",\n  \"menuItemUniqueCode\": \"translate-message\",\n  \"context\": {\n    \"className\": \"ChannelMessageMenuActionContext\",\n    \"channelIdentifier\": {\n      \"className\": \"ChannelIdentifier.Id\",\n      \"id\": \"channelId\"\n    },\n    \"messageIdentifier\": {\n      \"className\": \"ChatMessageIdentifier.InternalId\",\n      \"id\": \"messageId\"\n    }\n  },\n  \"clientId\": \"clientId\",\n  \"userId\": \"userId\",\n  \"verificationToken\": null\n}";

        var result = JsonSerializer.Deserialize(inputJsonString, typeof(ApplicationPayload), Defaults.CreateSerializerOptions());

        Assert.NotNull(result);
        Assert.IsType<MenuActionPayload>(result);
        if (result is MenuActionPayload menuActionPayload)
        {
            Assert.NotNull(menuActionPayload.Context);
            Assert.IsType<ChannelMessageMenuActionContext>(menuActionPayload.Context);

            if (menuActionPayload.Context is ChannelMessageMenuActionContext channelMessageMenuActionContext)
            {
                Assert.NotNull(channelMessageMenuActionContext.ChannelIdentifier);
                Assert.IsType<ChannelIdentifier.ChannelIdentifierId>(channelMessageMenuActionContext.ChannelIdentifier);
                if (channelMessageMenuActionContext.ChannelIdentifier is ChannelIdentifier.ChannelIdentifierId channelIdentifier)
                {
                    Assert.NotNull(channelIdentifier.Id);
                    Assert.Equal("channelId", channelIdentifier.Id);
                }

                Assert.NotNull(channelMessageMenuActionContext.MessageIdentifier);
                Assert.IsType<ChatMessageIdentifier.ChatMessageIdentifierInternalId>(channelMessageMenuActionContext.MessageIdentifier);
                if (channelMessageMenuActionContext.MessageIdentifier is ChatMessageIdentifier.ChatMessageIdentifierInternalId messageIdentifier)
                {
                    Assert.NotNull(messageIdentifier.Id);
                    Assert.Equal("messageId", messageIdentifier.Id);
                }
            }
        }
    }
}