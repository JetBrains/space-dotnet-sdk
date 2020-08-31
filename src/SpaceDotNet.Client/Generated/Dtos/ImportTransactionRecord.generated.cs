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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ImportTransactionRecord
         : IPropagatePropertyAccessPath
    {
        public ImportTransactionRecord() { }
        
        public ImportTransactionRecord(string id, bool archived, CPrincipal importer, string externalSource)
        {
            Id = id;
            IsArchived = archived;
            Importer = importer;
            ExternalSource = externalSource;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ImportTransactionRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ImportTransactionRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<CPrincipal> _importer = new PropertyValue<CPrincipal>(nameof(ImportTransactionRecord), nameof(Importer));
        
        [Required]
        [JsonPropertyName("importer")]
        public CPrincipal Importer
        {
            get { return _importer.GetValue(); }
            set { _importer.SetValue(value); }
        }
    
        private PropertyValue<string> _externalSource = new PropertyValue<string>(nameof(ImportTransactionRecord), nameof(ExternalSource));
        
        [Required]
        [JsonPropertyName("externalSource")]
        public string ExternalSource
        {
            get { return _externalSource.GetValue(); }
            set { _externalSource.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _importer.SetAccessPath(path, validateHasBeenSet);
            _externalSource.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
