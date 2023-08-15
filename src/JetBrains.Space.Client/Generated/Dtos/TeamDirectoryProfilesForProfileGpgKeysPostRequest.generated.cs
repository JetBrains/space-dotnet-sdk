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

internal class TeamDirectoryProfilesForProfileGpgKeysPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileGpgKeysPostRequest() { }
    
    public TeamDirectoryProfilesForProfileGpgKeysPostRequest(string key, string comment = "")
    {
        Key = key;
        Comment = comment;
    }
    
    private PropertyValue<string> _key = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileGpgKeysPostRequest), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _comment = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileGpgKeysPostRequest), nameof(Comment), "comment");
    
    [JsonPropertyName("comment")]
    public string Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

