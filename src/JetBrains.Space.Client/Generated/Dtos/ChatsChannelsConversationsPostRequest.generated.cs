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

internal class ChatsChannelsConversationsPostRequest
     : IPropagatePropertyAccessPath
{
    public ChatsChannelsConversationsPostRequest() { }
    
    public ChatsChannelsConversationsPostRequest(List<string> profileIds, string? subject = null)
    {
        ProfileIds = profileIds;
        Subject = subject;
    }
    
    private PropertyValue<List<string>> _profileIds = new PropertyValue<List<string>>(nameof(ChatsChannelsConversationsPostRequest), nameof(ProfileIds), "profileIds", new List<string>());
    
    [Required]
    [JsonPropertyName("profileIds")]
    public List<string> ProfileIds
    {
        get => _profileIds.GetValue(InlineErrors);
        set => _profileIds.SetValue(value);
    }

    private PropertyValue<string?> _subject = new PropertyValue<string?>(nameof(ChatsChannelsConversationsPostRequest), nameof(Subject), "subject");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("subject")]
    public string? Subject
    {
        get => _subject.GetValue(InlineErrors);
        set => _subject.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profileIds.SetAccessPath(parentChainPath, validateHasBeenSet);
        _subject.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

