// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class M2MembershipContent
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "M2MembershipContent";
        
        public static M2MembershipCreatedContent M2MembershipCreatedContent(TDMembership membership)
            => new M2MembershipCreatedContent(membership: membership);
        
        public static M2MembershipRequestedContent M2MembershipRequestedContent(TDMembership membership, bool leave)
            => new M2MembershipRequestedContent(membership: membership, leave: leave);
        
        public static M2MembershipTerminatedContent M2MembershipTerminatedContent(TDMembership membership)
            => new M2MembershipTerminatedContent(membership: membership);
        
        public M2MembershipContent() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
