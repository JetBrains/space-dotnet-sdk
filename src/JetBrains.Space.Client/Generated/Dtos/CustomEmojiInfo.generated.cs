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

public sealed class CustomEmojiInfo
     : IPropagatePropertyAccessPath
{
    public CustomEmojiInfo() { }
    
    public CustomEmojiInfo(string name, CPrincipal provider, DateTime uploaded, string? attachmentId = null, bool? deleted = null)
    {
        Name = name;
        Provider = provider;
        Uploaded = uploaded;
        AttachmentId = attachmentId;
        IsDeleted = deleted;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomEmojiInfo), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<CPrincipal> _provider = new PropertyValue<CPrincipal>(nameof(CustomEmojiInfo), nameof(Provider), "provider");
    
    [Required]
    [JsonPropertyName("provider")]
    public CPrincipal Provider
    {
        get => _provider.GetValue(InlineErrors);
        set => _provider.SetValue(value);
    }

    private PropertyValue<DateTime> _uploaded = new PropertyValue<DateTime>(nameof(CustomEmojiInfo), nameof(Uploaded), "uploaded");
    
    [Required]
    [JsonPropertyName("uploaded")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Uploaded
    {
        get => _uploaded.GetValue(InlineErrors);
        set => _uploaded.SetValue(value);
    }

    private PropertyValue<string?> _attachmentId = new PropertyValue<string?>(nameof(CustomEmojiInfo), nameof(AttachmentId), "attachmentId");
    
    [JsonPropertyName("attachmentId")]
    public string? AttachmentId
    {
        get => _attachmentId.GetValue(InlineErrors);
        set => _attachmentId.SetValue(value);
    }

    private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(CustomEmojiInfo), nameof(IsDeleted), "deleted");
    
    [JsonPropertyName("deleted")]
    public bool? IsDeleted
    {
        get => _deleted.GetValue(InlineErrors);
        set => _deleted.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _provider.SetAccessPath(parentChainPath, validateHasBeenSet);
        _uploaded.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachmentId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deleted.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

