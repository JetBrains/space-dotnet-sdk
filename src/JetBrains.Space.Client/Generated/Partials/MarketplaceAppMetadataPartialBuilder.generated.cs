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

namespace JetBrains.Space.Client.MarketplaceAppMetadataPartialBuilder;

public static class MarketplaceAppMetadataPartialExtensions
{
    public static Partial<MarketplaceAppMetadata> WithMarketplaceAppId(this Partial<MarketplaceAppMetadata> it)
        => it.AddFieldName("marketplaceAppId");
    
    public static Partial<MarketplaceAppMetadata> WithLastSentServerUrl(this Partial<MarketplaceAppMetadata> it)
        => it.AddFieldName("lastSentServerUrl");
    
    public static Partial<MarketplaceAppMetadata> WithConnectionStatus(this Partial<MarketplaceAppMetadata> it)
        => it.AddFieldName("connectionStatus");
    
    public static Partial<MarketplaceAppMetadata> WithConnectionStatus(this Partial<MarketplaceAppMetadata> it, Func<Partial<AppConnectionStatus>, Partial<AppConnectionStatus>> partialBuilder)
        => it.AddFieldName("connectionStatus", partialBuilder(new Partial<AppConnectionStatus>(it)));
    
    public static Partial<MarketplaceAppMetadata> WithUninstallationStatus(this Partial<MarketplaceAppMetadata> it)
        => it.AddFieldName("uninstallationStatus");
    
    public static Partial<MarketplaceAppMetadata> WithUninstallationStatus(this Partial<MarketplaceAppMetadata> it, Func<Partial<AppUninstallationStatus>, Partial<AppUninstallationStatus>> partialBuilder)
        => it.AddFieldName("uninstallationStatus", partialBuilder(new Partial<AppUninstallationStatus>(it)));
    
    public static Partial<MarketplaceAppMetadata> WithUninstallationStartedAt(this Partial<MarketplaceAppMetadata> it)
        => it.AddFieldName("uninstallationStartedAt");
    
}

