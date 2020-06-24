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
    public sealed class ImportTransactionRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ImportTransactionRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ImportTransactionRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDto> _importer = new PropertyValue<CPrincipalDto>(nameof(ImportTransactionRecordDto), nameof(Importer));
        
        [Required]
        [JsonPropertyName("importer")]
        public CPrincipalDto Importer
        {
            get { return _importer.GetValue(); }
            set { _importer.SetValue(value); }
        }
    
        private PropertyValue<string> _externalSource = new PropertyValue<string>(nameof(ImportTransactionRecordDto), nameof(ExternalSource));
        
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
