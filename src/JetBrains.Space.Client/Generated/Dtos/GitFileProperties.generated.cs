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

public sealed class GitFileProperties
     : IPropagatePropertyAccessPath
{
    public GitFileProperties() { }
    
    public GitFileProperties(List<GitFileAttribute> attributes, bool? lfs = null, bool? executable = null)
    {
        IsLfs = lfs;
        IsExecutable = executable;
        Attributes = attributes;
    }
    
    private PropertyValue<bool?> _lfs = new PropertyValue<bool?>(nameof(GitFileProperties), nameof(IsLfs), "lfs");
    
    [JsonPropertyName("lfs")]
    public bool? IsLfs
    {
        get => _lfs.GetValue(InlineErrors);
        set => _lfs.SetValue(value);
    }

    private PropertyValue<bool?> _executable = new PropertyValue<bool?>(nameof(GitFileProperties), nameof(IsExecutable), "executable");
    
    [JsonPropertyName("executable")]
    public bool? IsExecutable
    {
        get => _executable.GetValue(InlineErrors);
        set => _executable.SetValue(value);
    }

    private PropertyValue<List<GitFileAttribute>> _attributes = new PropertyValue<List<GitFileAttribute>>(nameof(GitFileProperties), nameof(Attributes), "attributes", new List<GitFileAttribute>());
    
    [Required]
    [JsonPropertyName("attributes")]
    public List<GitFileAttribute> Attributes
    {
        get => _attributes.GetValue(InlineErrors);
        set => _attributes.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _lfs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _executable.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attributes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

