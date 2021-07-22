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

namespace JetBrains.Space.Client.TodayBillingReportPartialBuilder
{
    public static class TodayBillingReportPartialExtensions
    {
        public static Partial<TodayBillingReport> WithPlan(this Partial<TodayBillingReport> it)
            => it.AddFieldName("plan");
        
        public static Partial<TodayBillingReport> WithPlan(this Partial<TodayBillingReport> it, Func<Partial<PurchasedBillingPlan>, Partial<PurchasedBillingPlan>> partialBuilder)
            => it.AddFieldName("plan", partialBuilder(new Partial<PurchasedBillingPlan>(it)));
        
        public static Partial<TodayBillingReport> WithActiveUsers(this Partial<TodayBillingReport> it)
            => it.AddFieldName("activeUsers");
        
        public static Partial<TodayBillingReport> WithChargedUsers(this Partial<TodayBillingReport> it)
            => it.AddFieldName("chargedUsers");
        
        public static Partial<TodayBillingReport> WithUserBalance(this Partial<TodayBillingReport> it)
            => it.AddFieldName("userBalance");
        
        public static Partial<TodayBillingReport> WithStorageActualLimitB(this Partial<TodayBillingReport> it)
            => it.AddFieldName("storageActualLimitB");
        
        public static Partial<TodayBillingReport> WithStorageTotalUsage(this Partial<TodayBillingReport> it)
            => it.AddFieldName("storageTotalUsage");
        
        public static Partial<TodayBillingReport> WithStorageBalance(this Partial<TodayBillingReport> it)
            => it.AddFieldName("storageBalance");
        
        public static Partial<TodayBillingReport> WithBandwidthTotalUsage(this Partial<TodayBillingReport> it)
            => it.AddFieldName("bandwidthTotalUsage");
        
        public static Partial<TodayBillingReport> WithBandwidthBalance(this Partial<TodayBillingReport> it)
            => it.AddFieldName("bandwidthBalance");
        
        public static Partial<TodayBillingReport> WithCiUsage(this Partial<TodayBillingReport> it)
            => it.AddFieldName("ciUsage");
        
        public static Partial<TodayBillingReport> WithCiBalance(this Partial<TodayBillingReport> it)
            => it.AddFieldName("ciBalance");
        
        public static Partial<TodayBillingReport> WithAppUsage(this Partial<TodayBillingReport> it)
            => it.AddFieldName("appUsage");
        
        public static Partial<TodayBillingReport> WithChatUsage(this Partial<TodayBillingReport> it)
            => it.AddFieldName("chatUsage");
        
        public static Partial<TodayBillingReport> WithTotalBalance(this Partial<TodayBillingReport> it)
            => it.AddFieldName("totalBalance");
        
    }
    
}
