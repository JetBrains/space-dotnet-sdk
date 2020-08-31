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
    public sealed class M2MembershipCreatedContent
         : M2MembershipContent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "M2MembershipCreatedContent";
        
        public M2MembershipCreatedContent() { }
        
        public M2MembershipCreatedContent(TDMembership membership)
        {
            Membership = membership;
        }
        
        private PropertyValue<TDMembership> _membership = new PropertyValue<TDMembership>(nameof(M2MembershipCreatedContent), nameof(Membership));
        
        [Required]
        [JsonPropertyName("membership")]
        public TDMembership Membership
        {
            get { return _membership.GetValue(); }
            set { _membership.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _membership.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
