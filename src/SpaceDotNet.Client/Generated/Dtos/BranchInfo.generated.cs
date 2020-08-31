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
    public sealed class BranchInfo
         : IPropagatePropertyAccessPath
    {
        public BranchInfo() { }
        
        public BranchInfo(string head, string @ref)
        {
            Head = head;
            Ref = @ref;
        }
        
        private PropertyValue<string> _head = new PropertyValue<string>(nameof(BranchInfo), nameof(Head));
        
        [Required]
        [JsonPropertyName("head")]
        public string Head
        {
            get { return _head.GetValue(); }
            set { _head.SetValue(value); }
        }
    
        private PropertyValue<string> _ref = new PropertyValue<string>(nameof(BranchInfo), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public string Ref
        {
            get { return _ref.GetValue(); }
            set { _ref.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _head.SetAccessPath(path, validateHasBeenSet);
            _ref.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
