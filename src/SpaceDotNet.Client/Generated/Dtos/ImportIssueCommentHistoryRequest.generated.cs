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
    public class ImportIssueCommentHistoryRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<List<MessageForImportDto>> _comments = new PropertyValue<List<MessageForImportDto>>(nameof(ImportIssueCommentHistoryRequest), nameof(Comments));
        
        [Required]
        [JsonPropertyName("comments")]
        public List<MessageForImportDto> Comments
        {
            get { return _comments.GetValue(); }
            set { _comments.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _comments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
