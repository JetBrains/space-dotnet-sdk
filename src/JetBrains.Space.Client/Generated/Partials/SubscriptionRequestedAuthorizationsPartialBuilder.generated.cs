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

namespace JetBrains.Space.Client.SubscriptionRequestedAuthorizationsPartialBuilder
{
    public static class SubscriptionRequestedAuthorizationsPartialExtensions
    {
        public static Partial<SubscriptionRequestedAuthorizations> WithRights(this Partial<SubscriptionRequestedAuthorizations> it)
            => it.AddFieldName("rights");
        
        public static Partial<SubscriptionRequestedAuthorizations> WithRights(this Partial<SubscriptionRequestedAuthorizations> it, Func<Partial<Right>, Partial<Right>> partialBuilder)
            => it.AddFieldName("rights", partialBuilder(new Partial<Right>(it)));
        
        public static Partial<SubscriptionRequestedAuthorizations> WithRightCodes(this Partial<SubscriptionRequestedAuthorizations> it)
            => it.AddFieldName("rightCodes");
        
        public static Partial<SubscriptionRequestedAuthorizations> WithPermissionContext(this Partial<SubscriptionRequestedAuthorizations> it)
            => it.AddFieldName("permissionContext");
        
        public static Partial<SubscriptionRequestedAuthorizations> WithPermissionContext(this Partial<SubscriptionRequestedAuthorizations> it, Func<Partial<PermissionContextApi>, Partial<PermissionContextApi>> partialBuilder)
            => it.AddFieldName("permissionContext", partialBuilder(new Partial<PermissionContextApi>(it)));
        
        public static Partial<SubscriptionRequestedAuthorizations> WithProjects(this Partial<SubscriptionRequestedAuthorizations> it)
            => it.AddFieldName("projects");
        
        public static Partial<SubscriptionRequestedAuthorizations> WithProjects(this Partial<SubscriptionRequestedAuthorizations> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("projects", partialBuilder(new Partial<PRProject>(it)));
        
    }
    
}
