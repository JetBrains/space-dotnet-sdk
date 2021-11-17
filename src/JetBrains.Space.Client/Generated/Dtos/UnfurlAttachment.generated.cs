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

public sealed class UnfurlAttachment
     : Attachment, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlAttachment";
    
    public UnfurlAttachment() { }
    
    public UnfurlAttachment(Unfurl unfurl, string id, bool? onlyVisibleToYou = null)
    {
        Unfurl = unfurl;
        Id = id;
        IsOnlyVisibleToYou = onlyVisibleToYou;
    }
    
    private PropertyValue<Unfurl> _unfurl = new PropertyValue<Unfurl>(nameof(UnfurlAttachment), nameof(Unfurl));
    
    [Required]
    [JsonPropertyName("unfurl")]
    public Unfurl Unfurl
    {
        get => _unfurl.GetValue();
        set => _unfurl.SetValue(value);
    }

    private PropertyValue<string> _id = new PropertyValue<string>(nameof(UnfurlAttachment), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<bool?> _onlyVisibleToYou = new PropertyValue<bool?>(nameof(UnfurlAttachment), nameof(IsOnlyVisibleToYou));
    
    [JsonPropertyName("onlyVisibleToYou")]
    public bool? IsOnlyVisibleToYou
    {
        get => _onlyVisibleToYou.GetValue();
        set => _onlyVisibleToYou.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _unfurl.SetAccessPath(path, validateHasBeenSet);
        _id.SetAccessPath(path, validateHasBeenSet);
        _onlyVisibleToYou.SetAccessPath(path, validateHasBeenSet);
    }

}

