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

namespace JetBrains.Space.Client.PurchasedBillingPlanPartialBuilder
{
    public static class PurchasedBillingPlanPartialExtensions
    {
        public static Partial<PurchasedBillingPlan> WithId(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("id");
        
        public static Partial<PurchasedBillingPlan> WithJetSalesId(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("jetSalesId");
        
        public static Partial<PurchasedBillingPlan> WithPlan(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("plan");
        
        public static Partial<PurchasedBillingPlan> WithBillingPeriod(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("billingPeriod");
        
        public static Partial<PurchasedBillingPlan> WithSince(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("since");
        
        public static Partial<PurchasedBillingPlan> WithTill(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("till");
        
        public static Partial<PurchasedBillingPlan> WithCurrency(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("currency");
        
        public static Partial<PurchasedBillingPlan> WithCurrency(this Partial<PurchasedBillingPlan> it, Func<Partial<Currency>, Partial<Currency>> partialBuilder)
            => it.AddFieldName("currency", partialBuilder(new Partial<Currency>(it)));
        
        public static Partial<PurchasedBillingPlan> WithAddUserPrice(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("addUserPrice");
        
        public static Partial<PurchasedBillingPlan> WithAddStoragePrice(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("addStoragePrice");
        
        public static Partial<PurchasedBillingPlan> WithAddBandwidthPrice(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("addBandwidthPrice");
        
        public static Partial<PurchasedBillingPlan> WithAddCiCreditPrice(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("addCiCreditPrice");
        
        public static Partial<PurchasedBillingPlan> WithMinActiveUsers(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("minActiveUsers");
        
        public static Partial<PurchasedBillingPlan> WithPrepaidUsers(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("prepaidUsers");
        
        public static Partial<PurchasedBillingPlan> WithStoragePerUser(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("storagePerUser");
        
        public static Partial<PurchasedBillingPlan> WithStorageOverall(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("storageOverall");
        
        public static Partial<PurchasedBillingPlan> WithBandwidthPerUser(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("bandwidthPerUser");
        
        public static Partial<PurchasedBillingPlan> WithBandwidthOverall(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("bandwidthOverall");
        
        public static Partial<PurchasedBillingPlan> WithCiCredits(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("ciCredits");
        
        public static Partial<PurchasedBillingPlan> WithCiCreditsReserve(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("ciCreditsReserve");
        
        public static Partial<PurchasedBillingPlan> WithCiCreditsRateForExternalWorker(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("ciCreditsRateForExternalWorker");
        
        public static Partial<PurchasedBillingPlan> WithIntegrations(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("integrations");
        
        public static Partial<PurchasedBillingPlan> WithSearchHistory(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("searchHistory");
        
        public static Partial<PurchasedBillingPlan> WithBalance(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("balance");
        
        public static Partial<PurchasedBillingPlan> WithHardLimitAmount(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("hardLimitAmount");
        
        public static Partial<PurchasedBillingPlan> WithIsRecurrentPaymentEnabled(this Partial<PurchasedBillingPlan> it)
            => it.AddFieldName("recurrentPaymentEnabled");
        
    }
    
}
