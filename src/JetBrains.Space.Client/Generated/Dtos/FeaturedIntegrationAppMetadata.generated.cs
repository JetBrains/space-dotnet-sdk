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

public sealed class FeaturedIntegrationAppMetadata
     : ApplicationMetadata, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "FeaturedIntegrationAppMetadata";
    
    public FeaturedIntegrationAppMetadata() { }
    
    public FeaturedIntegrationAppMetadata(FeaturedIntegrationType type, AppConnectionStatus? connectionStatus = null, AppUninstallationStatus? uninstallationStatus = null, DateTime? uninstallationStartedAt = null)
    {
        Type = type;
        ConnectionStatus = connectionStatus;
        UninstallationStatus = uninstallationStatus;
        UninstallationStartedAt = uninstallationStartedAt;
    }
    
    private PropertyValue<FeaturedIntegrationType> _type = new PropertyValue<FeaturedIntegrationType>(nameof(FeaturedIntegrationAppMetadata), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public FeaturedIntegrationType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<AppConnectionStatus?> _connectionStatus = new PropertyValue<AppConnectionStatus?>(nameof(FeaturedIntegrationAppMetadata), nameof(ConnectionStatus), "connectionStatus");
    
    [JsonPropertyName("connectionStatus")]
    public AppConnectionStatus? ConnectionStatus
    {
        get => _connectionStatus.GetValue(InlineErrors);
        set => _connectionStatus.SetValue(value);
    }

    private PropertyValue<AppUninstallationStatus?> _uninstallationStatus = new PropertyValue<AppUninstallationStatus?>(nameof(FeaturedIntegrationAppMetadata), nameof(UninstallationStatus), "uninstallationStatus");
    
    [JsonPropertyName("uninstallationStatus")]
    public AppUninstallationStatus? UninstallationStatus
    {
        get => _uninstallationStatus.GetValue(InlineErrors);
        set => _uninstallationStatus.SetValue(value);
    }

    private PropertyValue<DateTime?> _uninstallationStartedAt = new PropertyValue<DateTime?>(nameof(FeaturedIntegrationAppMetadata), nameof(UninstallationStartedAt), "uninstallationStartedAt");
    
    [JsonPropertyName("uninstallationStartedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? UninstallationStartedAt
    {
        get => _uninstallationStartedAt.GetValue(InlineErrors);
        set => _uninstallationStartedAt.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _connectionStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _uninstallationStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _uninstallationStartedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
