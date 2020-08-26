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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class UnfurlClient
    {
        private readonly Connection _connection;
        
        public UnfurlClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Block link unfurling.
        /// </summary>
        public async Task BlockUnfurlAsync(string link, bool wholeHost)
            => await _connection.RequestResourceAsync("POST", $"api/http/unfurls/block-unfurl", 
                new UnfurlsBlockUnfurlPostRequest { 
                    Link = link,
                    WholeHost = wholeHost,
                }
        );
    
        /// <summary>
        /// Block link unfurling for organization.
        /// </summary>
        public async Task BlockUnfurlGlobalAsync(string link, bool wholeHost)
            => await _connection.RequestResourceAsync("POST", $"api/http/unfurls/block-unfurl-global", 
                new UnfurlsBlockUnfurlGlobalPostRequest { 
                    Link = link,
                    WholeHost = wholeHost,
                }
        );
    
        public async Task<bool> CheckBlockedAsync(string link)
            => await _connection.RequestResourceAsync<UnfurlsCheckBlockedPostRequest, bool>("POST", $"api/http/unfurls/check-blocked", 
                new UnfurlsCheckBlockedPostRequest { 
                    Link = link,
                }
        );
    
        /// <summary>
        /// Disable link unfurling.
        /// </summary>
        public async Task UnblockUnfurlAsync(string link, bool wholeHost)
            => await _connection.RequestResourceAsync("POST", $"api/http/unfurls/unblock-unfurl", 
                new UnfurlsUnblockUnfurlPostRequest { 
                    Link = link,
                    WholeHost = wholeHost,
                }
        );
    
        /// <summary>
        /// Disable blocking link unfurling for organization.
        /// </summary>
        public async Task UnblockUnfurlGlobalAsync(string link, bool wholeHost)
            => await _connection.RequestResourceAsync("POST", $"api/http/unfurls/unblock-unfurl-global", 
                new UnfurlsUnblockUnfurlGlobalPostRequest { 
                    Link = link,
                    WholeHost = wholeHost,
                }
        );
    
        public async Task<Batch<UnfurlsBlockListEntryDto>> ListBlockedAsync(string? skip = null, int? top = 100, Func<Partial<Batch<UnfurlsBlockListEntryDto>>, Partial<Batch<UnfurlsBlockListEntryDto>>>? partial = null)
            => await _connection.RequestResourceAsync<Batch<UnfurlsBlockListEntryDto>>("GET", $"api/http/unfurls/list-blocked?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<UnfurlsBlockListEntryDto>>()) : Partial<Batch<UnfurlsBlockListEntryDto>>.Default())}");
        
        public IAsyncEnumerable<UnfurlsBlockListEntryDto> ListBlockedAsyncEnumerable(string? skip = null, int? top = 100, Func<Partial<UnfurlsBlockListEntryDto>, Partial<UnfurlsBlockListEntryDto>>? partial = null)
            => BatchEnumerator.AllItems(batchSkip => ListBlockedAsync(top: top, skip: batchSkip, partial: builder => Partial<Batch<UnfurlsBlockListEntryDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<UnfurlsBlockListEntryDto>.Default())), skip);
    
    }
    
}
