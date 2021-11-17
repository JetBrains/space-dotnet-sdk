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
    
    public EndpointAuthUpdateDTO(EndpointAppLevelAuthUpdateType appLevelAuth, string basicAuthUsername, string basicAuthPassword, string bearerAuthToken, bool hasVerificationToken, string? sslKeystoreAuth = null)
    {
        AppLevelAuth = appLevelAuth;
        BasicAuthUsername = basicAuthUsername;
        BasicAuthPassword = basicAuthPassword;
        BearerAuthToken = bearerAuthToken;
        IsHasVerificationToken = hasVerificationToken;
        SslKeystoreAuth = sslKeystoreAuth;
    }
    
    private PropertyValue<EndpointAppLevelAuthUpdateType> _appLevelAuth = new PropertyValue<EndpointAppLevelAuthUpdateType>(nameof(EndpointAuthUpdateDTO), nameof(AppLevelAuth));
    
    [Required]
    [JsonPropertyName("appLevelAuth")]
    public EndpointAppLevelAuthUpdateType AppLevelAuth
    {
        get => _appLevelAuth.GetValue();
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<string> _basicAuthUsername = new PropertyValue<string>(nameof(EndpointAuthUpdateDTO), nameof(BasicAuthUsername));
    
    [Required]
    [JsonPropertyName("basicAuthUsername")]
    public string BasicAuthUsername
    {
        get => _basicAuthUsername.GetValue();
        set => _basicAuthUsername.SetValue(value);
    }

    private PropertyValue<string> _basicAuthPassword = new PropertyValue<string>(nameof(EndpointAuthUpdateDTO), nameof(BasicAuthPassword));
    
    [Required]
    [JsonPropertyName("basicAuthPassword")]
    public string BasicAuthPassword
    {
        get => _basicAuthPassword.GetValue();
        set => _basicAuthPassword.SetValue(value);
    }

    private PropertyValue<string> _bearerAuthToken = new PropertyValue<string>(nameof(EndpointAuthUpdateDTO), nameof(BearerAuthToken));
    
    [Required]
    [JsonPropertyName("bearerAuthToken")]
    public string BearerAuthToken
    {
        get => _bearerAuthToken.GetValue();
        set => _bearerAuthToken.SetValue(value);
    }

    private PropertyValue<bool> _hasVerificationToken = new PropertyValue<bool>(nameof(EndpointAuthUpdateDTO), nameof(IsHasVerificationToken));
    
    [Required]
    [JsonPropertyName("hasVerificationToken")]
    public bool IsHasVerificationToken
    {
        get => _hasVerificationToken.GetValue();
        set => _hasVerificationToken.SetValue(value);
    }

    private PropertyValue<string?> _sslKeystoreAuth = new PropertyValue<string?>(nameof(EndpointAuthUpdateDTO), nameof(SslKeystoreAuth));
    
    [JsonPropertyName("sslKeystoreAuth")]
    public string? SslKeystoreAuth
    {
        get => _sslKeystoreAuth.GetValue();
        set => _sslKeystoreAuth.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _appLevelAuth.SetAccessPath(path, validateHasBeenSet);
        _basicAuthUsername.SetAccessPath(path, validateHasBeenSet);
        _basicAuthPassword.SetAccessPath(path, validateHasBeenSet);
        _bearerAuthToken.SetAccessPath(path, validateHasBeenSet);
        _hasVerificationToken.SetAccessPath(path, validateHasBeenSet);
        _sslKeystoreAuth.SetAccessPath(path, validateHasBeenSet);
    }

}

