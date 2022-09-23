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

public sealed class UnfurlDetailsImage
     : AttachmentUnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsImage";
    
    public UnfurlDetailsImage() { }
    
    public UnfurlDetailsImage(string title, ImageAttachment image, string? icon = null)
    {
        Icon = icon;
        Title = title;
        Image = image;
    }
    
    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(UnfurlDetailsImage), nameof(Icon), "icon");
    
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(UnfurlDetailsImage), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<ImageAttachment> _image = new PropertyValue<ImageAttachment>(nameof(UnfurlDetailsImage), nameof(Image), "image");
    
    [Required]
    [JsonPropertyName("image")]
    public ImageAttachment Image
    {
        get => _image.GetValue(InlineErrors);
        set => _image.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _image.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
