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
    public sealed class UnfurlDetailsIssueStatusDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsIssueStatus";
        
        public UnfurlDetailsIssueStatusDto() { }
        
        public UnfurlDetailsIssueStatusDto(IssueStatusDto status)
        {
            Status = status;
        }
        
        private PropertyValue<IssueStatusDto> _status = new PropertyValue<IssueStatusDto>(nameof(UnfurlDetailsIssueStatusDto), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public IssueStatusDto Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _status.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
