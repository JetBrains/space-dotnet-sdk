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

public class ApplicationsPostRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsPostRequest() { }
    
    public ApplicationsPostRequest(string name, string? pictureAttachmentId = null, string? defaultExternalPicture = null, string? email = null, string? clientId = null, string? clientSecret = null, bool? clientCredentialsFlowEnabled = true, bool? codeFlowEnabled = false, string? codeFlowRedirectURIs = null, bool? pkceRequired = null, bool? implicitFlowEnabled = false, string? implicitFlowRedirectURIs = null, string? endpointUri = null, bool? endpointSslVerification = null, EndpointAuthCreate? appLevelAuth = null, string? sslKeystoreAuth = null, bool? hasSigningKey = null, bool? hasPublicKeySignature = null, string? basicAuthUsername = null, string? basicAuthPassword = null, string? bearerAuthToken = null, bool? connectToSpace = false, string? state = null)
    {
        Name = name;
        PictureAttachmentId = pictureAttachmentId;
        DefaultExternalPicture = defaultExternalPicture;
        Email = email;
        ClientId = clientId;
        ClientSecret = clientSecret;
        IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled;
        IsCodeFlowEnabled = codeFlowEnabled;
        CodeFlowRedirectURIs = codeFlowRedirectURIs;
        IsPkceRequired = pkceRequired;
        IsImplicitFlowEnabled = implicitFlowEnabled;
        ImplicitFlowRedirectURIs = implicitFlowRedirectURIs;
        EndpointUri = endpointUri;
        IsEndpointSslVerification = endpointSslVerification;
        AppLevelAuth = appLevelAuth;
        SslKeystoreAuth = sslKeystoreAuth;
        IsHasSigningKey = hasSigningKey;
        IsHasPublicKeySignature = hasPublicKeySignature;
        BasicAuthUsername = basicAuthUsername;
        BasicAuthPassword = basicAuthPassword;
        BearerAuthToken = bearerAuthToken;
        IsConnectToSpace = connectToSpace;
        State = state;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ApplicationsPostRequest), nameof(Name), "name");
    
    /// <summary>
    /// Displayed application name
    /// </summary>
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _pictureAttachmentId = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(PictureAttachmentId), "pictureAttachmentId");
    
    /// <summary>
    /// Identifier of an image attachment. You can get image attachment id by uploading an image, see [Create upload URL](/extensions/httpApiPlayground?resource=hosting_xxx_site&endpoint=http_post_xxx_upload-url).
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("pictureAttachmentId")]
    public string? PictureAttachmentId
    {
        get => _pictureAttachmentId.GetValue(InlineErrors);
        set => _pictureAttachmentId.SetValue(value);
    }

    private PropertyValue<string?> _defaultExternalPicture = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(DefaultExternalPicture), "defaultExternalPicture");
    
    /// <summary>
    /// URL of an image to be used as the application icon
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("defaultExternalPicture")]
    public string? DefaultExternalPicture
    {
        get => _defaultExternalPicture.GetValue(InlineErrors);
        set => _defaultExternalPicture.SetValue(value);
    }

    private PropertyValue<string?> _email = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(Email), "email");
    
    /// <summary>
    /// Email used during Git commit verification. Can only be specified at application creation.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("email")]
    public string? Email
    {
        get => _email.GetValue(InlineErrors);
        set => _email.SetValue(value);
    }

    private PropertyValue<string?> _clientId = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ClientId), "clientId");
    
    /// <summary>
    /// `clientId` is generated automatically if this parameter is omitted. Application's `clientId` is returned in response
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("clientId")]
    public string? ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string?> _clientSecret = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ClientSecret), "clientSecret");
    
    /// <summary>
    /// `clientSecret` is generated automatically if this parameter is omitted. Application's `clientSecret` can be retrieved through [Get Client Secret](/extensions/httpApiPlayground?resource=applications_xxx_client-secret&endpoint=http_get) endpoint.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret
    {
        get => _clientSecret.GetValue(InlineErrors);
        set => _clientSecret.SetValue(value);
    }

    private PropertyValue<bool?> _clientCredentialsFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsClientCredentialsFlowEnabled), "clientCredentialsFlowEnabled");
    
    /// <summary>
    /// Client Credentials flow is enabled by default. Pass `false` if the application only uses other flows.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("clientCredentialsFlowEnabled")]
    public bool? IsClientCredentialsFlowEnabled
    {
        get => _clientCredentialsFlowEnabled.GetValue(InlineErrors);
        set => _clientCredentialsFlowEnabled.SetValue(value);
    }

    private PropertyValue<bool?> _codeFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsCodeFlowEnabled), "codeFlowEnabled");
    
    /// <summary>
    /// Pass `true` to enable Authorization Code Flow for the application. Learn more in the [documentation](https://www.jetbrains.com/help/space/authorization-code.html).
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("codeFlowEnabled")]
    public bool? IsCodeFlowEnabled
    {
        get => _codeFlowEnabled.GetValue(InlineErrors);
        set => _codeFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _codeFlowRedirectURIs = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(CodeFlowRedirectURIs), "codeFlowRedirectURIs");
    
    /// <summary>
    /// When Authorization Code Flow is enabled, specifies redirect URIs that can be used in the flow. Learn more in the [documentation](https://www.jetbrains.com/help/space/authorization-code.html).
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("codeFlowRedirectURIs")]
    public string? CodeFlowRedirectURIs
    {
        get => _codeFlowRedirectURIs.GetValue(InlineErrors);
        set => _codeFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<bool?> _pkceRequired = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsPkceRequired), "pkceRequired");
    
    /// <summary>
    /// When Authorization Code Flow is enabled, specifies whether PKCE extension must be used. Learn more in the [documentation](https://www.jetbrains.com/help/space/authorization-code.html).
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("pkceRequired")]
    public bool? IsPkceRequired
    {
        get => _pkceRequired.GetValue(InlineErrors);
        set => _pkceRequired.SetValue(value);
    }

    private PropertyValue<bool?> _implicitFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsImplicitFlowEnabled), "implicitFlowEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Implicit flow deprecated as not secure. Not available for new applications. Please use Authorization Code Flow with PKCE instead. (since 2022-11-30) (will be removed in a future version)")]
    [JsonPropertyName("implicitFlowEnabled")]
    public bool? IsImplicitFlowEnabled
    {
        get => _implicitFlowEnabled.GetValue(InlineErrors);
        set => _implicitFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _implicitFlowRedirectURIs = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ImplicitFlowRedirectURIs), "implicitFlowRedirectURIs");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Implicit flow deprecated as not secure. Not available for new applications. Please use Authorization Code Flow with PKCE instead. (since 2022-11-30) (will be removed in a future version)")]
    [JsonPropertyName("implicitFlowRedirectURIs")]
    public string? ImplicitFlowRedirectURIs
    {
        get => _implicitFlowRedirectURIs.GetValue(InlineErrors);
        set => _implicitFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<string?> _endpointUri = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(EndpointUri), "endpointUri");
    
    /// <summary>
    /// Space will send payloads (for example, `InitPayload`) to application using this URL.
    /// 
    /// This is also a default URL for webhook requests (`WebhookRequestPayload`). The URL for webhook requests can be redefined for each webhook.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri
    {
        get => _endpointUri.GetValue(InlineErrors);
        set => _endpointUri.SetValue(value);
    }

    private PropertyValue<bool?> _endpointSslVerification = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsEndpointSslVerification), "endpointSslVerification");
    
    /// <summary>
    /// SSL verification is turned on by default for connections that are established with application endpoint. Passing `false` will turn the verification off.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("endpointSslVerification")]
    public bool? IsEndpointSslVerification
    {
        get => _endpointSslVerification.GetValue(InlineErrors);
        set => _endpointSslVerification.SetValue(value);
    }

    private PropertyValue<EndpointAuthCreate?> _appLevelAuth = new PropertyValue<EndpointAuthCreate?>(nameof(ApplicationsPostRequest), nameof(AppLevelAuth), "appLevelAuth");
    
    /// <summary>
    /// Type of authentication used by application server to make sure that payloads coming from Space are authentic.
    /// 
    /// Payloads from Space contain `serverUrl` property: the URL of the Space server sending the request. Authenticating the request (making sure it indeed comes from the referenced Space server) is essential to prevent fraudulent actions with your application.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("appLevelAuth")]
    public EndpointAuthCreate? AppLevelAuth
    {
        get => _appLevelAuth.GetValue(InlineErrors);
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<string?> _sslKeystoreAuth = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(SslKeystoreAuth), "sslKeystoreAuth");
    
    /// <summary>
    /// Name of the SSL Keystore to be used when sending payloads to the application. You can create an SSL Keystore in Administration -&gt; SSL Keystores.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("sslKeystoreAuth")]
    public string? SslKeystoreAuth
    {
        get => _sslKeystoreAuth.GetValue(InlineErrors);
        set => _sslKeystoreAuth.SetValue(value);
    }

    private PropertyValue<bool?> _hasSigningKey = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsHasSigningKey), "hasSigningKey");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("hasSigningKey")]
    public bool? IsHasSigningKey
    {
        get => _hasSigningKey.GetValue(InlineErrors);
        set => _hasSigningKey.SetValue(value);
    }

    private PropertyValue<bool?> _hasPublicKeySignature = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsHasPublicKeySignature), "hasPublicKeySignature");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("hasPublicKeySignature")]
    public bool? IsHasPublicKeySignature
    {
        get => _hasPublicKeySignature.GetValue(InlineErrors);
        set => _hasPublicKeySignature.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthUsername = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BasicAuthUsername), "basicAuthUsername");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("basicAuthUsername")]
    public string? BasicAuthUsername
    {
        get => _basicAuthUsername.GetValue(InlineErrors);
        set => _basicAuthUsername.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthPassword = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BasicAuthPassword), "basicAuthPassword");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("basicAuthPassword")]
    public string? BasicAuthPassword
    {
        get => _basicAuthPassword.GetValue(InlineErrors);
        set => _basicAuthPassword.SetValue(value);
    }

    private PropertyValue<string?> _bearerAuthToken = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BearerAuthToken), "bearerAuthToken");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("bearerAuthToken")]
    public string? BearerAuthToken
    {
        get => _bearerAuthToken.GetValue(InlineErrors);
        set => _bearerAuthToken.SetValue(value);
    }

    private PropertyValue<bool?> _connectToSpace = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsConnectToSpace), "connectToSpace");
    
    /// <summary>
    /// Pass `true` to create a multi-org application and connect application server to the current Space instance. Learn more in the [documentation](https://www.jetbrains.com/help/space/distribute-your-application.html).
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("connectToSpace")]
    public bool? IsConnectToSpace
    {
        get => _connectToSpace.GetValue(InlineErrors);
        set => _connectToSpace.SetValue(value);
    }

    private PropertyValue<string?> _state = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(State), "state");
    
    /// <summary>
    /// When passing `connectToSpace = true`, Space will send `InitPayload` to the application endpoint. The `state` value is passed in that `InitPayload`. Use this to perform multi-step application installation.
    /// </summary>
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("state")]
    public string? State
    {
        get => _state.GetValue(InlineErrors);
        set => _state.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pictureAttachmentId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultExternalPicture.SetAccessPath(parentChainPath, validateHasBeenSet);
        _email.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientSecret.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientCredentialsFlowEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeFlowEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeFlowRedirectURIs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pkceRequired.SetAccessPath(parentChainPath, validateHasBeenSet);
        _implicitFlowEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _implicitFlowRedirectURIs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endpointUri.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endpointSslVerification.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appLevelAuth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sslKeystoreAuth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hasSigningKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hasPublicKeySignature.SetAccessPath(parentChainPath, validateHasBeenSet);
        _basicAuthUsername.SetAccessPath(parentChainPath, validateHasBeenSet);
        _basicAuthPassword.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bearerAuthToken.SetAccessPath(parentChainPath, validateHasBeenSet);
        _connectToSpace.SetAccessPath(parentChainPath, validateHasBeenSet);
        _state.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

