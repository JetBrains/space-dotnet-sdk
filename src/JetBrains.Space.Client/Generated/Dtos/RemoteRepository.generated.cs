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

public sealed class RemoteRepository
     : IPropagatePropertyAccessPath
{
    public RemoteRepository() { }
    
    public RemoteRepository(string url, RemoteRepositoryAuth? auth = null, string? refSpec = null)
    {
        Url = url;
        Auth = auth;
        RefSpec = refSpec;
    }
    
    private PropertyValue<string> _url = new PropertyValue<string>(nameof(RemoteRepository), nameof(Url), "url");
    
    [Required]
    [JsonPropertyName("url")]
    public string Url
    {
        get => _url.GetValue(InlineErrors);
        set => _url.SetValue(value);
    }

    private PropertyValue<RemoteRepositoryAuth?> _auth = new PropertyValue<RemoteRepositoryAuth?>(nameof(RemoteRepository), nameof(Auth), "auth");
    
    [JsonPropertyName("auth")]
    public RemoteRepositoryAuth? Auth
    {
        get => _auth.GetValue(InlineErrors);
        set => _auth.SetValue(value);
    }

    private PropertyValue<string?> _refSpec = new PropertyValue<string?>(nameof(RemoteRepository), nameof(RefSpec), "refSpec");
    
    [JsonPropertyName("refSpec")]
    public string? RefSpec
    {
        get => _refSpec.GetValue(InlineErrors);
        set => _refSpec.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _url.SetAccessPath(parentChainPath, validateHasBeenSet);
        _auth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _refSpec.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

