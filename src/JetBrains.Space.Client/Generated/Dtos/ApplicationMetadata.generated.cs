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

public interface ApplicationMetadata
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AdHocConnectedAppMetadata AdHocConnectedAppMetadata(string? lastSentServerUrl = null, AppConnectionStatus? connectionStatus = null, AppUninstallationStatus? uninstallationStatus = null, DateTime? uninstallationStartedAt = null)
        => new AdHocConnectedAppMetadata(lastSentServerUrl: lastSentServerUrl, connectionStatus: connectionStatus, uninstallationStatus: uninstallationStatus, uninstallationStartedAt: uninstallationStartedAt);
    
    public static AutomationServiceMetadata AutomationServiceMetadata(PRProject project)
        => new AutomationServiceMetadata(project: project);
    
    public static FeaturedIntegrationAppMetadata FeaturedIntegrationAppMetadata(FeaturedIntegrationType type, AppConnectionStatus? connectionStatus = null, AppUninstallationStatus? uninstallationStatus = null, DateTime? uninstallationStartedAt = null)
        => new FeaturedIntegrationAppMetadata(type: type, connectionStatus: connectionStatus, uninstallationStatus: uninstallationStatus, uninstallationStartedAt: uninstallationStartedAt);
    
    public static MarketplaceAppMetadata MarketplaceAppMetadata(string marketplaceAppId, string lastSentServerUrl, AppConnectionStatus connectionStatus, AppUninstallationStatus? uninstallationStatus = null, DateTime? uninstallationStartedAt = null)
        => new MarketplaceAppMetadata(marketplaceAppId: marketplaceAppId, lastSentServerUrl: lastSentServerUrl, connectionStatus: connectionStatus, uninstallationStatus: uninstallationStatus, uninstallationStartedAt: uninstallationStartedAt);
    
    public static SubscriptionMetadata SubscriptionMetadata(M2ChannelRecord channel, string subscription, string subscriptionName)
        => new SubscriptionMetadata(channel: channel, subscription: subscription, subscriptionName: subscriptionName);
    
}

