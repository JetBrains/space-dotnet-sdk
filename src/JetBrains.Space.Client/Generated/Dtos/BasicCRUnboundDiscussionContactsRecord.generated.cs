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

public sealed class BasicCRUnboundDiscussionContactsRecord
     : BasicThreadContactsRecord, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "BasicCRUnboundDiscussionContactsRecord";
    
    public BasicCRUnboundDiscussionContactsRecord() { }
    
    public BasicCRUnboundDiscussionContactsRecord(List<BasicCRUnboundDiscussionContactRecord> discussions, bool archived, string id)
    {
        Discussions = discussions;
        IsArchived = archived;
        Id = id;
    }
    
    private PropertyValue<List<BasicCRUnboundDiscussionContactRecord>> _discussions = new PropertyValue<List<BasicCRUnboundDiscussionContactRecord>>(nameof(BasicCRUnboundDiscussionContactsRecord), nameof(Discussions), "discussions", new List<BasicCRUnboundDiscussionContactRecord>());
    
    [Required]
    [JsonPropertyName("discussions")]
    public List<BasicCRUnboundDiscussionContactRecord> Discussions
    {
        get => _discussions.GetValue(InlineErrors);
        set => _discussions.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(BasicCRUnboundDiscussionContactsRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _id = new PropertyValue<string>(nameof(BasicCRUnboundDiscussionContactsRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _discussions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

