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

namespace SpaceDotNet.Client.MavenPackageFilePartialBuilder
{
    public static class MavenPackageFilePartialExtensions
    {
        public static Partial<MavenPackageFile> WithName(this Partial<MavenPackageFile> it)
            => it.AddFieldName("name");
        
        public static Partial<MavenPackageFile> WithCreated(this Partial<MavenPackageFile> it)
            => it.AddFieldName("created");
        
        public static Partial<MavenPackageFile> WithLength(this Partial<MavenPackageFile> it)
            => it.AddFieldName("length");
        
    }
    
}
