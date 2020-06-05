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
    public sealed class DocumentPublicationItemDto
         : PublicationItemDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _documentId = new PropertyValue<string>(nameof(DocumentPublicationItemDto), nameof(DocumentId));
        
        [Required]
        [JsonPropertyName("documentId")]
        public string DocumentId { get { return _documentId.GetValue(); } set { _documentId.SetValue(value); } }
    
        private PropertyValue<DraftDocumentType> _documentType = new PropertyValue<DraftDocumentType>(nameof(DocumentPublicationItemDto), nameof(DocumentType));
        
        [Required]
        [JsonPropertyName("documentType")]
        public DraftDocumentType DocumentType { get { return _documentType.GetValue(); } set { _documentType.SetValue(value); } }
    
    }
    
}
