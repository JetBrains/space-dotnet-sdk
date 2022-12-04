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

namespace JetBrains.Space.Client;

public partial class BillingAdminClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public BillingAdminClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Grant permissions to other members</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task ActivateTrialAsync(Tier trialTier, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("PUT", $"api/http/billing-admin/trial{queryParameters.ToQueryString()}", 
            new BillingAdminTrialPutRequest
            { 
                TrialTier = trialTier,
            }, requestHeaders: null, functionName: "ActivateTrial", cancellationToken: cancellationToken);
    }
    

    public OverdraftClient Overdrafts => new OverdraftClient(_connection);
    
    public partial class OverdraftClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public OverdraftClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View usage data</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<Overdrafts> GetOverdraftsAsync(Func<Partial<Overdrafts>, Partial<Overdrafts>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<Overdrafts>()) : Partial<Overdrafts>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<Overdrafts>("GET", $"api/http/billing-admin/overdrafts{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetOverdrafts", cancellationToken: cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Update overdrafts</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task SetOverdraftsAsync(int storage, int bandwidth, int ciCredits, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("PUT", $"api/http/billing-admin/overdrafts{queryParameters.ToQueryString()}", 
                new BillingAdminOverdraftsPutRequest
                { 
                    Storage = storage,
                    Bandwidth = bandwidth,
                    CiCredits = ciCredits,
                }, requestHeaders: null, functionName: "SetOverdrafts", cancellationToken: cancellationToken);
        }
        
    
    }

    public ReportClient Reports => new ReportClient(_connection);
    
    public partial class ReportClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ReportClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Returns a billing report for the given billing period
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View usage data</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<BillingReport> GetBillingReportAsync(string billingPeriod, Func<Partial<BillingReport>, Partial<BillingReport>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<BillingReport>()) : Partial<BillingReport>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<BillingReport>("GET", $"api/http/billing-admin/reports/{billingPeriod}{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetBillingReport", cancellationToken: cancellationToken);
        }
        
    
        public TodayClient Today => new TodayClient(_connection);
        
        public partial class TodayClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public TodayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Returns a billing report for today
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View usage data</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<TodayBillingReport> GetBillingReportForTodayAsync(DateTime date, Func<Partial<TodayBillingReport>, Partial<TodayBillingReport>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("date", date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<TodayBillingReport>()) : Partial<TodayBillingReport>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<TodayBillingReport>("GET", $"api/http/billing-admin/reports/today{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetBillingReportForToday", cancellationToken: cancellationToken);
            }
            
        
        }
    
    }

}

