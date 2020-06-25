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
    public partial class ToDoItemClient
    {
        private readonly Connection _connection;
        
        public ToDoItemClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create a new To-Do item, with an optional due date.
        /// </summary>
        public async Task<TodoItemRecordDto> CreateToDoItemAsync(string text, SpaceDate? dueDate = null, Func<Partial<TodoItemRecordDto>, Partial<TodoItemRecordDto>>? partial = null)
            => await _connection.RequestResourceAsync<TodoRequest, TodoItemRecordDto>("POST", $"api/http/todo?$fields={(partial != null ? partial(new Partial<TodoItemRecordDto>()) : Partial<TodoItemRecordDto>.Default())}", new TodoRequest{ Text = text, DueDate = dueDate });
    
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        public async Task<Batch<TodoItemRecordDto>> GetAllToDoItemsAsync(string? skip = null, int? top = null, bool? open = null, SpaceDate? from = null, SpaceDate? till = null, Func<Partial<Batch<TodoItemRecordDto>>, Partial<Batch<TodoItemRecordDto>>>? partial = null)
            => await _connection.RequestResourceAsync<Batch<TodoItemRecordDto>>("GET", $"api/http/todo?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&open={open?.ToString()?.ToLowerInvariant() ?? "null"}&from={from?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<TodoItemRecordDto>>()) : Partial<Batch<TodoItemRecordDto>>.Default())}");
        
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        public IAsyncEnumerable<TodoItemRecordDto> GetAllToDoItemsAsyncEnumerable(string? skip = null, int? top = null, bool? open = null, SpaceDate? from = null, SpaceDate? till = null, Func<Partial<TodoItemRecordDto>, Partial<TodoItemRecordDto>>? partial = null)
            => BatchEnumerator.AllItems(batchSkip => GetAllToDoItemsAsync(top: top, open: open, from: from, till: till, skip: batchSkip, partial: builder => Partial<Batch<TodoItemRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<TodoItemRecordDto>.Default())), skip);
    
        /// <summary>
        /// Update an existing To-Do item. Optional parameters will be ignored when null, and updated otherwise.
        /// </summary>
        public async Task UpdateToDoItemAsync(string id, string? text = null, SpaceDate? dueDate = null, bool? open = null)
            => await _connection.RequestResourceAsync("PATCH", $"api/http/todo/{id}", new TodoForIdRequest{ Text = text, DueDate = dueDate, Open = open });
    
        /// <summary>
        /// Delete an existing To-Do item.
        /// </summary>
        public async Task DeleteToDoItemAsync(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/todo/{id}");
    
    }
    
}
