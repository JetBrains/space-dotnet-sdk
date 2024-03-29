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

public sealed class MergeRequestBranch
     : IPropagatePropertyAccessPath
{
    public MergeRequestBranch() { }
    
    public MergeRequestBranch(string displayName, string @ref, bool deleted, string? head = null)
    {
        DisplayName = displayName;
        Ref = @ref;
        IsDeleted = deleted;
        Head = head;
    }
    
    private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(MergeRequestBranch), nameof(DisplayName), "displayName");
    
    [Required]
    [JsonPropertyName("displayName")]
    public string DisplayName
    {
        get => _displayName.GetValue(InlineErrors);
        set => _displayName.SetValue(value);
    }

    private PropertyValue<string> _ref = new PropertyValue<string>(nameof(MergeRequestBranch), nameof(Ref), "ref");
    
    [Required]
    [JsonPropertyName("ref")]
    public string Ref
    {
        get => _ref.GetValue(InlineErrors);
        set => _ref.SetValue(value);
    }

    private PropertyValue<bool> _deleted = new PropertyValue<bool>(nameof(MergeRequestBranch), nameof(IsDeleted), "deleted");
    
    [Required]
    [JsonPropertyName("deleted")]
    public bool IsDeleted
    {
        get => _deleted.GetValue(InlineErrors);
        set => _deleted.SetValue(value);
    }

    private PropertyValue<string?> _head = new PropertyValue<string?>(nameof(MergeRequestBranch), nameof(Head), "head");
    
    [JsonPropertyName("head")]
    public string? Head
    {
        get => _head.GetValue(InlineErrors);
        set => _head.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _displayName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ref.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deleted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _head.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

