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

public sealed class HAEndpoint
     : IPropagatePropertyAccessPath
{
    public HAEndpoint() { }
    
    public HAEndpoint(HAResource resource, HAMethod method, List<HAParameter> parameters, HAPath path, string displayName, string functionName, HATypeObject? requestBody = null, HAType? responseBody = null, string? doc = null, HADescription? description = null, HADeprecation? deprecation = null, HAExperimental? experimental = null, List<HARight>? rights = null, string? featureFlag = null, string? optionalFeature = null)
    {
        Resource = resource;
        Method = method;
        Parameters = parameters;
        RequestBody = requestBody;
        ResponseBody = responseBody;
        Path = path;
        DisplayName = displayName;
        FunctionName = functionName;
        Doc = doc;
        Description = description;
        Deprecation = deprecation;
        Experimental = experimental;
        Rights = rights;
        FeatureFlag = featureFlag;
        OptionalFeature = optionalFeature;
    }
    
    private PropertyValue<HAResource> _resource = new PropertyValue<HAResource>(nameof(HAEndpoint), nameof(Resource), "resource");
    
    [Required]
    [JsonPropertyName("resource")]
    public HAResource Resource
    {
        get => _resource.GetValue(InlineErrors);
        set => _resource.SetValue(value);
    }

    private PropertyValue<HAMethod> _method = new PropertyValue<HAMethod>(nameof(HAEndpoint), nameof(Method), "method");
    
    [Required]
    [JsonPropertyName("method")]
    public HAMethod Method
    {
        get => _method.GetValue(InlineErrors);
        set => _method.SetValue(value);
    }

    private PropertyValue<List<HAParameter>> _parameters = new PropertyValue<List<HAParameter>>(nameof(HAEndpoint), nameof(Parameters), "parameters", new List<HAParameter>());
    
    [Required]
    [JsonPropertyName("parameters")]
    public List<HAParameter> Parameters
    {
        get => _parameters.GetValue(InlineErrors);
        set => _parameters.SetValue(value);
    }

    private PropertyValue<HATypeObject?> _requestBody = new PropertyValue<HATypeObject?>(nameof(HAEndpoint), nameof(RequestBody), "requestBody");
    
    [JsonPropertyName("requestBody")]
    public HATypeObject? RequestBody
    {
        get => _requestBody.GetValue(InlineErrors);
        set => _requestBody.SetValue(value);
    }

    private PropertyValue<HAType?> _responseBody = new PropertyValue<HAType?>(nameof(HAEndpoint), nameof(ResponseBody), "responseBody");
    
    [JsonPropertyName("responseBody")]
    public HAType? ResponseBody
    {
        get => _responseBody.GetValue(InlineErrors);
        set => _responseBody.SetValue(value);
    }

    private PropertyValue<HAPath> _path = new PropertyValue<HAPath>(nameof(HAEndpoint), nameof(Path), "path");
    
    [Required]
    [JsonPropertyName("path")]
    public HAPath Path
    {
        get => _path.GetValue(InlineErrors);
        set => _path.SetValue(value);
    }

    private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(HAEndpoint), nameof(DisplayName), "displayName");
    
    [Required]
    [JsonPropertyName("displayName")]
    public string DisplayName
    {
        get => _displayName.GetValue(InlineErrors);
        set => _displayName.SetValue(value);
    }

    private PropertyValue<string> _functionName = new PropertyValue<string>(nameof(HAEndpoint), nameof(FunctionName), "functionName");
    
    [Required]
    [JsonPropertyName("functionName")]
    public string FunctionName
    {
        get => _functionName.GetValue(InlineErrors);
        set => _functionName.SetValue(value);
    }

    private PropertyValue<string?> _doc = new PropertyValue<string?>(nameof(HAEndpoint), nameof(Doc), "doc");
    
    [Obsolete("Use description instead (since 2022-03-25) (will be removed in a future version)")]
    [JsonPropertyName("doc")]
    public string? Doc
    {
        get => _doc.GetValue(InlineErrors);
        set => _doc.SetValue(value);
    }

    private PropertyValue<HADescription?> _description = new PropertyValue<HADescription?>(nameof(HAEndpoint), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public HADescription? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<HADeprecation?> _deprecation = new PropertyValue<HADeprecation?>(nameof(HAEndpoint), nameof(Deprecation), "deprecation");
    
    [JsonPropertyName("deprecation")]
    public HADeprecation? Deprecation
    {
        get => _deprecation.GetValue(InlineErrors);
        set => _deprecation.SetValue(value);
    }

    private PropertyValue<HAExperimental?> _experimental = new PropertyValue<HAExperimental?>(nameof(HAEndpoint), nameof(Experimental), "experimental");
    
    [JsonPropertyName("experimental")]
    public HAExperimental? Experimental
    {
        get => _experimental.GetValue(InlineErrors);
        set => _experimental.SetValue(value);
    }

    private PropertyValue<List<HARight>?> _rights = new PropertyValue<List<HARight>?>(nameof(HAEndpoint), nameof(Rights), "rights");
    
    [JsonPropertyName("rights")]
    public List<HARight>? Rights
    {
        get => _rights.GetValue(InlineErrors);
        set => _rights.SetValue(value);
    }

    private PropertyValue<string?> _featureFlag = new PropertyValue<string?>(nameof(HAEndpoint), nameof(FeatureFlag), "featureFlag");
    
    [JsonPropertyName("featureFlag")]
    public string? FeatureFlag
    {
        get => _featureFlag.GetValue(InlineErrors);
        set => _featureFlag.SetValue(value);
    }

    private PropertyValue<string?> _optionalFeature = new PropertyValue<string?>(nameof(HAEndpoint), nameof(OptionalFeature), "optionalFeature");
    
    [JsonPropertyName("optionalFeature")]
    public string? OptionalFeature
    {
        get => _optionalFeature.GetValue(InlineErrors);
        set => _optionalFeature.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _resource.SetAccessPath(parentChainPath, validateHasBeenSet);
        _method.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parameters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _requestBody.SetAccessPath(parentChainPath, validateHasBeenSet);
        _responseBody.SetAccessPath(parentChainPath, validateHasBeenSet);
        _path.SetAccessPath(parentChainPath, validateHasBeenSet);
        _displayName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _functionName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _doc.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deprecation.SetAccessPath(parentChainPath, validateHasBeenSet);
        _experimental.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rights.SetAccessPath(parentChainPath, validateHasBeenSet);
        _featureFlag.SetAccessPath(parentChainPath, validateHasBeenSet);
        _optionalFeature.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

