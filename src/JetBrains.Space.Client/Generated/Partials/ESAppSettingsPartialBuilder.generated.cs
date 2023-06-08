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

namespace JetBrains.Space.Client.ESAppSettingsPartialBuilder;

public static class ESAppSettingsPartialExtensions
{
    public static Partial<ESAppSettings> WithIsClientCredentialsFlowEnabled(this Partial<ESAppSettings> it)
        => it.AddFieldName("clientCredentialsFlowEnabled");
    
    public static Partial<ESAppSettings> WithIsCodeFlowEnabled(this Partial<ESAppSettings> it)
        => it.AddFieldName("codeFlowEnabled");
    
    public static Partial<ESAppSettings> WithCodeFlowRedirectURIs(this Partial<ESAppSettings> it)
        => it.AddFieldName("codeFlowRedirectURIs");
    
    public static Partial<ESAppSettings> WithIsPkceRequired(this Partial<ESAppSettings> it)
        => it.AddFieldName("pkceRequired");
    
    public static Partial<ESAppSettings> WithIsImplicitFlowEnabled(this Partial<ESAppSettings> it)
        => it.AddFieldName("implicitFlowEnabled");
    
    public static Partial<ESAppSettings> WithImplicitFlowRedirectURIs(this Partial<ESAppSettings> it)
        => it.AddFieldName("implicitFlowRedirectURIs");
    
    public static Partial<ESAppSettings> WithEndpoint(this Partial<ESAppSettings> it)
        => it.AddFieldName("endpoint");
    
    public static Partial<ESAppSettings> WithEndpoint(this Partial<ESAppSettings> it, Func<Partial<EndpointDTO>, Partial<EndpointDTO>> partialBuilder)
        => it.AddFieldName("endpoint", partialBuilder(new Partial<EndpointDTO>(it)));
    
    public static Partial<ESAppSettings> WithEndpointAuth(this Partial<ESAppSettings> it)
        => it.AddFieldName("endpointAuth");
    
    public static Partial<ESAppSettings> WithEndpointAuth(this Partial<ESAppSettings> it, Func<Partial<EndpointAuthDTO>, Partial<EndpointAuthDTO>> partialBuilder)
        => it.AddFieldName("endpointAuth", partialBuilder(new Partial<EndpointAuthDTO>(it)));
    
    public static Partial<ESAppSettings> WithExternalIssueTrackerDomain(this Partial<ESAppSettings> it)
        => it.AddFieldName("externalIssueTrackerDomain");
    
}

