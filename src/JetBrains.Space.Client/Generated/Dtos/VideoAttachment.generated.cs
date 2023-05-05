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

public sealed class VideoAttachment
     : MediaAttachment, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "VideoAttachment";
    
    public VideoAttachment() { }
    
    public VideoAttachment(string id, long sizeBytes, string? name = null, int? width = null, int? height = null)
    {
        Id = id;
        Name = name;
        Width = width;
        Height = height;
        SizeBytes = sizeBytes;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(VideoAttachment), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(VideoAttachment), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<int?> _width = new PropertyValue<int?>(nameof(VideoAttachment), nameof(Width), "width");
    
    [JsonPropertyName("width")]
    public int? Width
    {
        get => _width.GetValue(InlineErrors);
        set => _width.SetValue(value);
    }

    private PropertyValue<int?> _height = new PropertyValue<int?>(nameof(VideoAttachment), nameof(Height), "height");
    
    [JsonPropertyName("height")]
    public int? Height
    {
        get => _height.GetValue(InlineErrors);
        set => _height.SetValue(value);
    }

    private PropertyValue<long> _sizeBytes = new PropertyValue<long>(nameof(VideoAttachment), nameof(SizeBytes), "sizeBytes");
    
    [Required]
    [JsonPropertyName("sizeBytes")]
    public long SizeBytes
    {
        get => _sizeBytes.GetValue(InlineErrors);
        set => _sizeBytes.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _width.SetAccessPath(parentChainPath, validateHasBeenSet);
        _height.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sizeBytes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

