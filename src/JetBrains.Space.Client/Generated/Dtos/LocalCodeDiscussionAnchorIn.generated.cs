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

public sealed class LocalCodeDiscussionAnchorIn
     : IPropagatePropertyAccessPath
{
    public LocalCodeDiscussionAnchorIn() { }
    
    public LocalCodeDiscussionAnchorIn(string revision, string filename, int? line = null, int? oldLine = null)
    {
        Revision = revision;
        Filename = filename;
        Line = line;
        OldLine = oldLine;
    }
    
    private PropertyValue<string> _revision = new PropertyValue<string>(nameof(LocalCodeDiscussionAnchorIn), nameof(Revision), "revision");
    
    [Required]
    [JsonPropertyName("revision")]
    public string Revision
    {
        get => _revision.GetValue(InlineErrors);
        set => _revision.SetValue(value);
    }

    private PropertyValue<string> _filename = new PropertyValue<string>(nameof(LocalCodeDiscussionAnchorIn), nameof(Filename), "filename");
    
    [Required]
    [JsonPropertyName("filename")]
    public string Filename
    {
        get => _filename.GetValue(InlineErrors);
        set => _filename.SetValue(value);
    }

    private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(LocalCodeDiscussionAnchorIn), nameof(Line), "line");
    
    [JsonPropertyName("line")]
    public int? Line
    {
        get => _line.GetValue(InlineErrors);
        set => _line.SetValue(value);
    }

    private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(LocalCodeDiscussionAnchorIn), nameof(OldLine), "oldLine");
    
    [JsonPropertyName("oldLine")]
    public int? OldLine
    {
        get => _oldLine.GetValue(InlineErrors);
        set => _oldLine.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _revision.SetAccessPath(parentChainPath, validateHasBeenSet);
        _filename.SetAccessPath(parentChainPath, validateHasBeenSet);
        _line.SetAccessPath(parentChainPath, validateHasBeenSet);
        _oldLine.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

