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
    public sealed class ExternalEntityInfoRecordDto
         : IPropagatePropertyAccessPath
    {
        public ExternalEntityInfoRecordDto() { }
        
        public ExternalEntityInfoRecordDto(string id, bool archived, ImportTransactionRecordDto transaction, string? externalId = null, string? externalUrl = null)
        {
            Id = id;
            Archived = archived;
            ExternalId = externalId;
            ExternalUrl = externalUrl;
            Transaction = transaction;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ExternalEntityInfoRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ExternalEntityInfoRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(ExternalEntityInfoRecordDto), nameof(ExternalId));
        
        [JsonPropertyName("externalId")]
        public string? ExternalId
        {
            get { return _externalId.GetValue(); }
            set { _externalId.SetValue(value); }
        }
    
        private PropertyValue<string?> _externalUrl = new PropertyValue<string?>(nameof(ExternalEntityInfoRecordDto), nameof(ExternalUrl));
        
        [JsonPropertyName("externalUrl")]
        public string? ExternalUrl
        {
            get { return _externalUrl.GetValue(); }
            set { _externalUrl.SetValue(value); }
        }
    
        private PropertyValue<ImportTransactionRecordDto> _transaction = new PropertyValue<ImportTransactionRecordDto>(nameof(ExternalEntityInfoRecordDto), nameof(Transaction));
        
        [Required]
        [JsonPropertyName("transaction")]
        public ImportTransactionRecordDto Transaction
        {
            get { return _transaction.GetValue(); }
            set { _transaction.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _externalId.SetAccessPath(path, validateHasBeenSet);
            _externalUrl.SetAccessPath(path, validateHasBeenSet);
            _transaction.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
