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

namespace JetBrains.Space.Client.RdRepositoryExternalRepositoryPartialBuilder;

public static class RdRepositoryExternalRepositoryPartialExtensions
{
    public static Partial<RdRepositoryExternalRepository> WithName(this Partial<RdRepositoryExternalRepository> it)
        => it.AddFieldName("name");
    
    public static Partial<RdRepositoryExternalRepository> WithAccessUrl(this Partial<RdRepositoryExternalRepository> it)
        => it.AddFieldName("accessUrl");
    
    public static Partial<RdRepositoryExternalRepository> WithStatus(this Partial<RdRepositoryExternalRepository> it)
        => it.AddFieldName("status");
    
    public static Partial<RdRepositoryExternalRepository> WithStatus(this Partial<RdRepositoryExternalRepository> it, Func<Partial<RdRepositoryStatus>, Partial<RdRepositoryStatus>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<RdRepositoryStatus>(it)));
    
}

