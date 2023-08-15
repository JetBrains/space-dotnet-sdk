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

public sealed class UnfurlDetailsExternalIssueId
     : InlineUnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsExternalIssueId";
    
    public UnfurlDetailsExternalIssueId() { }
    
    public UnfurlDetailsExternalIssueId(ExternalIssueId id, string? marketplaceAppId = null)
    {
        Id = id;
        MarketplaceAppId = marketplaceAppId;
    }
    
    private PropertyValue<ExternalIssueId> _id = new PropertyValue<ExternalIssueId>(nameof(UnfurlDetailsExternalIssueId), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public ExternalIssueId Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string?> _marketplaceAppId = new PropertyValue<string?>(nameof(UnfurlDetailsExternalIssueId), nameof(MarketplaceAppId), "marketplaceAppId");
    
    [JsonPropertyName("marketplaceAppId")]
    public string? MarketplaceAppId
    {
        get => _marketplaceAppId.GetValue(InlineErrors);
        set => _marketplaceAppId.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _marketplaceAppId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
