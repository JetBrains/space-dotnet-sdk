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

public partial class ChecklistClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public ChecklistClient(Connection connection)
    {
        _connection = connection;
    }
    
    public ItemClient Items => new ItemClient(_connection);
    
    public partial class ItemClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ItemClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create plan item as the last element of the top level in a checklist if parent plan item is null, or as the last child if parent plan item is provided.
        /// </summary>
        public async Task<PlanItem> CreatePlanItemAsync(ChecklistIdentifier checklist, string itemText, PlanItemIdentifier? parentItem = null, Func<Partial<PlanItem>, Partial<PlanItem>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<PlanItem>()) : Partial<PlanItem>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ChecklistsForChecklistItemsPostRequest, PlanItem>("POST", $"api/http/checklists/{checklist}/items{queryParameters.ToQueryString()}", 
                new ChecklistsForChecklistItemsPostRequest
                { 
                    ParentItem = parentItem,
                    ItemText = itemText,
                }, requestHeaders: null, functionName: "CreatePlanItem", cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Move plan item in a checklist
        /// </summary>
        public async Task<PlanItem> MovePlanItemAsync(ChecklistIdentifier checklist, PlanItemIdentifier planItem, PlanItemIdentifier targetParent, PlanItemIdentifier? afterItem = null, Func<Partial<PlanItem>, Partial<PlanItem>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<PlanItem>()) : Partial<PlanItem>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ChecklistsForChecklistItemsForPlanItemMovePostRequest, PlanItem>("POST", $"api/http/checklists/{checklist}/items/{planItem}/move{queryParameters.ToQueryString()}", 
                new ChecklistsForChecklistItemsForPlanItemMovePostRequest
                { 
                    TargetParent = targetParent,
                    AfterItem = afterItem,
                }, requestHeaders: null, functionName: "MovePlanItem", cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Get plan item by its identifier in a checklist
        /// </summary>
        public async Task<PlanItem> GetPlanItemAsync(ChecklistIdentifier checklist, PlanItemIdentifier planItem, Func<Partial<PlanItem>, Partial<PlanItem>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<PlanItem>()) : Partial<PlanItem>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<PlanItem>("GET", $"api/http/checklists/{checklist}/items/{planItem}{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetPlanItem", cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Update plan item in a checklist
        /// </summary>
        public async Task<PlanItem> UpdatePlanItemAsync(ChecklistIdentifier checklist, PlanItemIdentifier planItem, string? itemText = null, bool? itemDone = null, Func<Partial<PlanItem>, Partial<PlanItem>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<PlanItem>()) : Partial<PlanItem>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ChecklistsForChecklistItemsForPlanItemPatchRequest, PlanItem>("PATCH", $"api/http/checklists/{checklist}/items/{planItem}{queryParameters.ToQueryString()}", 
                new ChecklistsForChecklistItemsForPlanItemPatchRequest
                { 
                    ItemText = itemText,
                    IsItemDone = itemDone,
                }, requestHeaders: null, functionName: "UpdatePlanItem", cancellationToken: cancellationToken);
        }
        
    
        /// <summary>
        /// Delete plan item and its children from a checklist
        /// </summary>
        public async Task DeletePlanItemAsync(ChecklistIdentifier checklist, PlanItemIdentifier planItem, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/checklists/{checklist}/items/{planItem}{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "DeletePlanItem", cancellationToken: cancellationToken);
        }
        
    
    }

}

