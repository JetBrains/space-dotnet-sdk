// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class ApplicationClient
    {
        private readonly Connection _connection;
        
        public ApplicationClient(Connection connection)
        {
            _connection = connection;
        }
        
        public MarketApplicationClient MarketApplications => new MarketApplicationClient(_connection);
        
        public partial class MarketApplicationClient
        {
            private readonly Connection _connection;
            
            public MarketApplicationClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<Batch<MarketApplicationRecordDto>> GetAllMarketApplicationsAsync(string? skip = null, int? top = null, string? term = null, MarketAppSortColumn? sortBy = null, ColumnSortOrder? order = null, Func<Partial<Batch<MarketApplicationRecordDto>>, Partial<Batch<MarketApplicationRecordDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<MarketApplicationRecordDto>>("GET", $"api/http/applications/market-applications?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&term={term?.ToString() ?? "null"}&sortBy={sortBy?.ToString() ?? "null"}&order={order?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<MarketApplicationRecordDto>>()) : Partial<Batch<MarketApplicationRecordDto>>.Default())}");
            
            public IAsyncEnumerable<MarketApplicationRecordDto> GetAllMarketApplicationsAsyncEnumerable(string? skip = null, int? top = null, string? term = null, MarketAppSortColumn? sortBy = null, ColumnSortOrder? order = null, Func<Partial<MarketApplicationRecordDto>, Partial<MarketApplicationRecordDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllMarketApplicationsAsync(skip: batchSkip, top, term, sortBy, order, partial: builder => Partial<Batch<MarketApplicationRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<MarketApplicationRecordDto>.Default())), skip);
        
        }
    
    }
    
}