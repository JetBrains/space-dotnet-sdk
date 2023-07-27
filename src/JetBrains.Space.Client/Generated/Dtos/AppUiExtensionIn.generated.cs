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

public interface AppUiExtensionIn
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static ChatBotUiExtensionIn ChatBotUiExtensionIn()
        => new ChatBotUiExtensionIn();
    
    public static ExternalIssueTrackerUiExtensionIn ExternalIssueTrackerUiExtensionIn(string domain, string trackerName, bool canCreateIssues)
        => new ExternalIssueTrackerUiExtensionIn(domain: domain, trackerName: trackerName, canCreateIssues: canCreateIssues);
    
    public static GettingStartedUiExtensionIn GettingStartedUiExtensionIn(string gettingStartedUrl, string gettingStartedTitle, bool? openInNewTab = null)
        => new GettingStartedUiExtensionIn(gettingStartedUrl: gettingStartedUrl, gettingStartedTitle: gettingStartedTitle, openInNewTab: openInNewTab);
    
    public static TopLevelPageUiExtensionIn TopLevelPageUiExtensionIn(string displayName, string uniqueCode, string? description = null, string? iframeUrl = null)
        => new TopLevelPageUiExtensionIn(displayName: displayName, uniqueCode: uniqueCode, description: description, iframeUrl: iframeUrl);
    
}

