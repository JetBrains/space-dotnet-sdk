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

namespace JetBrains.Space.Client.PackageVersionDataPartialBuilder
{
    public static class PackageVersionDataPartialExtensions
    {
        public static Partial<PackageVersionData> WithType(this Partial<PackageVersionData> it)
            => it.AddFieldName("type");
        
        public static Partial<PackageVersionData> WithType(this Partial<PackageVersionData> it, Func<Partial<PackageType>, Partial<PackageType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageType>(it)));
        
        public static Partial<PackageVersionData> WithRepository(this Partial<PackageVersionData> it)
            => it.AddFieldName("repository");
        
        public static Partial<PackageVersionData> WithName(this Partial<PackageVersionData> it)
            => it.AddFieldName("name");
        
        public static Partial<PackageVersionData> WithVersion(this Partial<PackageVersionData> it)
            => it.AddFieldName("version");
        
        public static Partial<PackageVersionData> WithTags(this Partial<PackageVersionData> it)
            => it.AddFieldName("tags");
        
        public static Partial<PackageVersionData> WithCreated(this Partial<PackageVersionData> it)
            => it.AddFieldName("created");
        
        public static Partial<PackageVersionData> WithLastAccessed(this Partial<PackageVersionData> it)
            => it.AddFieldName("lastAccessed");
        
        public static Partial<PackageVersionData> WithDownloads(this Partial<PackageVersionData> it)
            => it.AddFieldName("downloads");
        
        public static Partial<PackageVersionData> WithIsPinned(this Partial<PackageVersionData> it)
            => it.AddFieldName("pinned");
        
        public static Partial<PackageVersionData> WithComment(this Partial<PackageVersionData> it)
            => it.AddFieldName("comment");
        
        public static Partial<PackageVersionData> WithDiskSize(this Partial<PackageVersionData> it)
            => it.AddFieldName("diskSize");
        
    }
    
}
