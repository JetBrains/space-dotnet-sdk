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

namespace JetBrains.Space.Client
{
    public partial class SlackImportClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public SlackImportClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task ResetAccessTokenAsync(CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/slack-import/reset-token{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public async Task SetAccessTokenAsync(string token, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/slack-import/set-token{queryParameters.ToQueryString()}", 
                new SlackImportSetTokenPostRequest
                { 
                    Token = token,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Redirect URI for Space Slack App authentication method
        /// </summary>
        public async Task SlackOauthRedirectEndpointAsync(string code, string? state = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("code", code);
            if (state != null) queryParameters.Append("state", state);
            
            await _connection.RequestResourceAsync("GET", $"api/http/slack-import/oauth{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
    }
    
}
