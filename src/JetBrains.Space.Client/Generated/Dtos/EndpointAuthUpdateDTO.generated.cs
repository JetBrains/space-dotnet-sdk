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

public sealed class EndpointAuthUpdateDTO
     : IPropagatePropertyAccessPath
{
    public EndpointAuthUpdateDTO() { }
    
    public EndpointAuthUpdateDTO(EndpointAppLevelAuthUpdateType? appLevelAuth = null, string? basicAuthUsername = null, string? basicAuthPassword = null, string? bearerAuthToken = null, bool? hasVerificationToken = null, string? sslKeystoreAuth = null)
    {
        AppLevelAuth = appLevelAuth;
        BasicAuthUsername = basicAuthUsername;
        BasicAuthPassword = basicAuthPassword;
        BearerAuthToken = bearerAuthToken;
        IsHasVerificationToken = hasVerificationToken;
        SslKeystoreAuth = sslKeystoreAuth;
    }
    
    private PropertyValue<EndpointAppLevelAuthUpdateType?> _appLevelAuth = new PropertyValue<EndpointAppLevelAuthUpdateType?>(nameof(EndpointAuthUpdateDTO), nameof(AppLevelAuth), "appLevelAuth");
    
    [JsonPropertyName("appLevelAuth")]
    public EndpointAppLevelAuthUpdateType? AppLevelAuth
    {
        get => _appLevelAuth.GetValue(InlineErrors);
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthUsername = new PropertyValue<string?>(nameof(EndpointAuthUpdateDTO), nameof(BasicAuthUsername), "basicAuthUsername");
    
    [JsonPropertyName("basicAuthUsername")]
    public string? BasicAuthUsername
    {
        get => _basicAuthUsername.GetValue(InlineErrors);
        set => _basicAuthUsername.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthPassword = new PropertyValue<string?>(nameof(EndpointAuthUpdateDTO), nameof(BasicAuthPassword), "basicAuthPassword");
    
    [JsonPropertyName("basicAuthPassword")]
    public string? BasicAuthPassword
    {
        get => _basicAuthPassword.GetValue(InlineErrors);
        set => _basicAuthPassword.SetValue(value);
    }

    private PropertyValue<string?> _bearerAuthToken = new PropertyValue<string?>(nameof(EndpointAuthUpdateDTO), nameof(BearerAuthToken), "bearerAuthToken");
    
    [JsonPropertyName("bearerAuthToken")]
    public string? BearerAuthToken
    {
        get => _bearerAuthToken.GetValue(InlineErrors);
        set => _bearerAuthToken.SetValue(value);
    }

    private PropertyValue<bool?> _hasVerificationToken = new PropertyValue<bool?>(nameof(EndpointAuthUpdateDTO), nameof(IsHasVerificationToken), "hasVerificationToken");
    
    [JsonPropertyName("hasVerificationToken")]
    public bool? IsHasVerificationToken
    {
        get => _hasVerificationToken.GetValue(InlineErrors);
        set => _hasVerificationToken.SetValue(value);
    }

    private PropertyValue<string?> _sslKeystoreAuth = new PropertyValue<string?>(nameof(EndpointAuthUpdateDTO), nameof(SslKeystoreAuth), "sslKeystoreAuth");
    
    [JsonPropertyName("sslKeystoreAuth")]
    public string? SslKeystoreAuth
    {
        get => _sslKeystoreAuth.GetValue(InlineErrors);
        set => _sslKeystoreAuth.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _appLevelAuth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _basicAuthUsername.SetAccessPath(parentChainPath, validateHasBeenSet);
        _basicAuthPassword.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bearerAuthToken.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hasVerificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sslKeystoreAuth.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

