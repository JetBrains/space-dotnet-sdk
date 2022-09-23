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

public sealed class UnfurlDetailsChatLink
     : InlineUnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsChatLink";
    
    public UnfurlDetailsChatLink() { }
    
    public UnfurlDetailsChatLink(string contactKey, string title)
    {
        ContactKey = contactKey;
        Title = title;
    }
    
    private PropertyValue<string> _contactKey = new PropertyValue<string>(nameof(UnfurlDetailsChatLink), nameof(ContactKey), "contactKey");
    
    [Required]
    [JsonPropertyName("contactKey")]
    public string ContactKey
    {
        get => _contactKey.GetValue(InlineErrors);
        set => _contactKey.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(UnfurlDetailsChatLink), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _contactKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
