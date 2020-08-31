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

namespace SpaceDotNet.Client.ImportedEntityInfoPartialBuilder
{
    public static class ImportedEntityInfoPartialExtensions
    {
        public static Partial<ImportedEntityInfo> WithSource(this Partial<ImportedEntityInfo> it)
            => it.AddFieldName("source");
        
        public static Partial<ImportedEntityInfo> WithSource(this Partial<ImportedEntityInfo> it, Func<Partial<ImportSource>, Partial<ImportSource>> partialBuilder)
            => it.AddFieldName("source", partialBuilder(new Partial<ImportSource>(it)));
        
        public static Partial<ImportedEntityInfo> WithExternalName(this Partial<ImportedEntityInfo> it)
            => it.AddFieldName("externalName");
        
        public static Partial<ImportedEntityInfo> WithExternalUrl(this Partial<ImportedEntityInfo> it)
            => it.AddFieldName("externalUrl");
        
    }
    
}
