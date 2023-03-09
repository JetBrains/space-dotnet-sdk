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

public sealed class TextDocumentRecord
     : IPropagatePropertyAccessPath
{
    public TextDocumentRecord() { }
    
    public TextDocumentRecord(string id, bool archived, DraftDocumentType type, List<AttachmentInfo>? attachments = null, List<ResolvedMentionLink>? mentions = null)
    {
        Id = id;
        IsArchived = archived;
        Type = type;
        Attachments = attachments;
        Mentions = mentions;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TextDocumentRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TextDocumentRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<DraftDocumentType> _type = new PropertyValue<DraftDocumentType>(nameof(TextDocumentRecord), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public DraftDocumentType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _attachments = new PropertyValue<List<AttachmentInfo>?>(nameof(TextDocumentRecord), nameof(Attachments), "attachments");
    
    [JsonPropertyName("attachments")]
    public List<AttachmentInfo>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<List<ResolvedMentionLink>?> _mentions = new PropertyValue<List<ResolvedMentionLink>?>(nameof(TextDocumentRecord), nameof(Mentions), "mentions");
    
    [JsonPropertyName("mentions")]
    public List<ResolvedMentionLink>? Mentions
    {
        get => _mentions.GetValue(InlineErrors);
        set => _mentions.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mentions.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

