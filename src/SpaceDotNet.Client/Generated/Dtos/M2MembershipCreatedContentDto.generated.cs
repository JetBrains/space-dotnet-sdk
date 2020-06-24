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
    public sealed class M2MembershipCreatedContentDto
         : M2MembershipContentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<TDMembershipDto> _membership = new PropertyValue<TDMembershipDto>(nameof(M2MembershipCreatedContentDto), nameof(Membership));
        
        [Required]
        [JsonPropertyName("membership")]
        public TDMembershipDto Membership
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
