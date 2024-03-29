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

public sealed class ESOAuthConsent
     : IPropagatePropertyAccessPath
{
    public ESOAuthConsent() { }
    
    public ESOAuthConsent(ESOAuthApp clientApplication, List<ESApprovedScope> approvedScopes, List<ESRefreshToken> refreshTokens)
    {
        ClientApplication = clientApplication;
        ApprovedScopes = approvedScopes;
        RefreshTokens = refreshTokens;
    }
    
    private PropertyValue<ESOAuthApp> _clientApplication = new PropertyValue<ESOAuthApp>(nameof(ESOAuthConsent), nameof(ClientApplication), "clientApplication");
    
    [Required]
    [JsonPropertyName("clientApplication")]
    public ESOAuthApp ClientApplication
    {
        get => _clientApplication.GetValue(InlineErrors);
        set => _clientApplication.SetValue(value);
    }

    private PropertyValue<List<ESApprovedScope>> _approvedScopes = new PropertyValue<List<ESApprovedScope>>(nameof(ESOAuthConsent), nameof(ApprovedScopes), "approvedScopes", new List<ESApprovedScope>());
    
    [Required]
    [JsonPropertyName("approvedScopes")]
    public List<ESApprovedScope> ApprovedScopes
    {
        get => _approvedScopes.GetValue(InlineErrors);
        set => _approvedScopes.SetValue(value);
    }

    private PropertyValue<List<ESRefreshToken>> _refreshTokens = new PropertyValue<List<ESRefreshToken>>(nameof(ESOAuthConsent), nameof(RefreshTokens), "refreshTokens", new List<ESRefreshToken>());
    
    [Required]
    [JsonPropertyName("refreshTokens")]
    public List<ESRefreshToken> RefreshTokens
    {
        get => _refreshTokens.GetValue(InlineErrors);
        set => _refreshTokens.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _clientApplication.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approvedScopes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _refreshTokens.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

