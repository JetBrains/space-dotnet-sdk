// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.M2PackageDeletedDetailsPartialBuilder
{
    public static class M2PackageDeletedDetailsPartialExtensions
    {
        public static Partial<M2PackageDeletedDetails> WithPkg(this Partial<M2PackageDeletedDetails> it)
            => it.AddFieldName("pkg");
        
        public static Partial<M2PackageDeletedDetails> WithPkg(this Partial<M2PackageDeletedDetails> it, Func<Partial<PackageVersionInfo>, Partial<PackageVersionInfo>> partialBuilder)
            => it.AddFieldName("pkg", partialBuilder(new Partial<PackageVersionInfo>(it)));
        
    }
    
}
