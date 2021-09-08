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

namespace JetBrains.Space.Client.ConfigurePermissionsActionPartialBuilder
{
    public static class ConfigurePermissionsActionPartialExtensions
    {
        public static Partial<ConfigurePermissionsAction> WithApp(this Partial<ConfigurePermissionsAction> it)
            => it.AddFieldName("app");
        
        public static Partial<ConfigurePermissionsAction> WithApp(this Partial<ConfigurePermissionsAction> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
            => it.AddFieldName("app", partialBuilder(new Partial<ESApp>(it)));
        
        public static Partial<ConfigurePermissionsAction> WithContext(this Partial<ConfigurePermissionsAction> it)
            => it.AddFieldName("context");
        
        public static Partial<ConfigurePermissionsAction> WithContext(this Partial<ConfigurePermissionsAction> it, Func<Partial<PermissionContextIdentifier>, Partial<PermissionContextIdentifier>> partialBuilder)
            => it.AddFieldName("context", partialBuilder(new Partial<PermissionContextIdentifier>(it)));
        
    }
    
}
