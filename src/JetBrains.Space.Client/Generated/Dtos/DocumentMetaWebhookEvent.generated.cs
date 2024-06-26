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

public sealed class DocumentMetaWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DocumentMetaWebhookEvent";
    
    public DocumentMetaWebhookEvent() { }
    
    public DocumentMetaWebhookEvent(KMetaMod meta, string document, Modification<bool?>? deleted = null, Modification<bool?>? published = null)
    {
        Meta = meta;
        Document = document;
        Deleted = deleted;
        Published = published;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(DocumentMetaWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<string> _document = new PropertyValue<string>(nameof(DocumentMetaWebhookEvent), nameof(Document), "document");
    
    [Required]
    [JsonPropertyName("document")]
    public string Document
    {
        get => _document.GetValue(InlineErrors);
        set => _document.SetValue(value);
    }

    private PropertyValue<Modification<bool?>?> _deleted = new PropertyValue<Modification<bool?>?>(nameof(DocumentMetaWebhookEvent), nameof(Deleted), "deleted");
    
    [JsonPropertyName("deleted")]
    public Modification<bool?>? Deleted
    {
        get => _deleted.GetValue(InlineErrors);
        set => _deleted.SetValue(value);
    }

    private PropertyValue<Modification<bool?>?> _published = new PropertyValue<Modification<bool?>?>(nameof(DocumentMetaWebhookEvent), nameof(Published), "published");
    
    [JsonPropertyName("published")]
    public Modification<bool?>? Published
    {
        get => _published.GetValue(InlineErrors);
        set => _published.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _document.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deleted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _published.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

