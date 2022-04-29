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

public sealed class UnfurlDeploymentDetails
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDeploymentDetails";
    
    public UnfurlDeploymentDetails() { }
    
    public UnfurlDeploymentDetails(DeploymentRecord deploymentRef, bool? showLinkIcon = null, bool? showDetails = null, bool? showStatus = null)
    {
        DeploymentRef = deploymentRef;
        IsShowLinkIcon = showLinkIcon;
        IsShowDetails = showDetails;
        IsShowStatus = showStatus;
    }
    
    private PropertyValue<DeploymentRecord> _deploymentRef = new PropertyValue<DeploymentRecord>(nameof(UnfurlDeploymentDetails), nameof(DeploymentRef), "deploymentRef");
    
    [Required]
    [JsonPropertyName("deploymentRef")]
    public DeploymentRecord DeploymentRef
    {
        get => _deploymentRef.GetValue(InlineErrors);
        set => _deploymentRef.SetValue(value);
    }

    private PropertyValue<bool?> _showLinkIcon = new PropertyValue<bool?>(nameof(UnfurlDeploymentDetails), nameof(IsShowLinkIcon), "showLinkIcon");
    
    [JsonPropertyName("showLinkIcon")]
    public bool? IsShowLinkIcon
    {
        get => _showLinkIcon.GetValue(InlineErrors);
        set => _showLinkIcon.SetValue(value);
    }

    private PropertyValue<bool?> _showDetails = new PropertyValue<bool?>(nameof(UnfurlDeploymentDetails), nameof(IsShowDetails), "showDetails");
    
    [JsonPropertyName("showDetails")]
    public bool? IsShowDetails
    {
        get => _showDetails.GetValue(InlineErrors);
        set => _showDetails.SetValue(value);
    }

    private PropertyValue<bool?> _showStatus = new PropertyValue<bool?>(nameof(UnfurlDeploymentDetails), nameof(IsShowStatus), "showStatus");
    
    [JsonPropertyName("showStatus")]
    public bool? IsShowStatus
    {
        get => _showStatus.GetValue(InlineErrors);
        set => _showStatus.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _deploymentRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _showLinkIcon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _showDetails.SetAccessPath(parentChainPath, validateHasBeenSet);
        _showStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

