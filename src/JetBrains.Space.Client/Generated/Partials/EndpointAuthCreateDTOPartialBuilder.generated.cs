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

namespace JetBrains.Space.Client.EndpointAuthCreateDTOPartialBuilder;

public static class EndpointAuthCreateDTOPartialExtensions
{
    public static Partial<EndpointAuthCreateDTO> WithAppLevelAuth(this Partial<EndpointAuthCreateDTO> it)
        => it.AddFieldName("appLevelAuth");
    
    public static Partial<EndpointAuthCreateDTO> WithAppLevelAuth(this Partial<EndpointAuthCreateDTO> it, Func<Partial<EndpointAuthCreate>, Partial<EndpointAuthCreate>> partialBuilder)
        => it.AddFieldName("appLevelAuth", partialBuilder(new Partial<EndpointAuthCreate>(it)));
    
    public static Partial<EndpointAuthCreateDTO> WithSslKeystore(this Partial<EndpointAuthCreateDTO> it)
        => it.AddFieldName("sslKeystore");
    
    public static Partial<EndpointAuthCreateDTO> WithSslKeystore(this Partial<EndpointAuthCreateDTO> it, Func<Partial<SSLKeystoreEndpointAuth>, Partial<SSLKeystoreEndpointAuth>> partialBuilder)
        => it.AddFieldName("sslKeystore", partialBuilder(new Partial<SSLKeystoreEndpointAuth>(it)));
    
}

