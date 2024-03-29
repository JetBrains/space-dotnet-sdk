// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class ChannelInfoAttachment
     : IPropagatePropertyAccessPath
{
    public ChannelInfoAttachment() { }
    
    public ChannelInfoAttachment(DateTime time, string messageId, string channelId, string contactKey, Attachment? details = null)
    {
        Details = details;
        Time = time;
        MessageId = messageId;
        ChannelId = channelId;
        ContactKey = contactKey;
    }
    
    private PropertyValue<Attachment?> _details = new PropertyValue<Attachment?>(nameof(ChannelInfoAttachment), nameof(Details), "details");
    
    [JsonPropertyName("details")]
    public Attachment? Details
    {
        get => _details.GetValue(InlineErrors);
        set => _details.SetValue(value);
    }

    private PropertyValue<DateTime> _time = new PropertyValue<DateTime>(nameof(ChannelInfoAttachment), nameof(Time), "time");
    
    [Required]
    [JsonPropertyName("time")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Time
    {
        get => _time.GetValue(InlineErrors);
        set => _time.SetValue(value);
    }

    private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(ChannelInfoAttachment), nameof(MessageId), "messageId");
    
    [Required]
    [JsonPropertyName("messageId")]
    public string MessageId
    {
        get => _messageId.GetValue(InlineErrors);
        set => _messageId.SetValue(value);
    }

    private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(ChannelInfoAttachment), nameof(ChannelId), "channelId");
    
    [Required]
    [JsonPropertyName("channelId")]
    public string ChannelId
    {
        get => _channelId.GetValue(InlineErrors);
        set => _channelId.SetValue(value);
    }

    private PropertyValue<string> _contactKey = new PropertyValue<string>(nameof(ChannelInfoAttachment), nameof(ContactKey), "contactKey");
    
    [Required]
    [JsonPropertyName("contactKey")]
    public string ContactKey
    {
        get => _contactKey.GetValue(InlineErrors);
        set => _contactKey.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _details.SetAccessPath(parentChainPath, validateHasBeenSet);
        _time.SetAccessPath(parentChainPath, validateHasBeenSet);
        _messageId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channelId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _contactKey.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

