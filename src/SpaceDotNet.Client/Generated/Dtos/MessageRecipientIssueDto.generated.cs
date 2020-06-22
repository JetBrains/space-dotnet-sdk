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
    public sealed class MessageRecipientIssueDto
         : MessageRecipientDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _issue = new PropertyValue<string>(nameof(MessageRecipientIssueDto), nameof(Issue));
        
        [Required]
        [JsonPropertyName("issue")]
        public string Issue
        {
            get { return _issue.GetValue(); }
            set { _issue.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _issue.SetAccessPath(path + "->WithIssue()", validateHasBeenSet);
        }
    
    }
    
}
