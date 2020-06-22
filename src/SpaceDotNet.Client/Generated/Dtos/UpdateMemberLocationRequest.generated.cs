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
    public class UpdateMemberLocationRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string?> _member = new PropertyValue<string?>(nameof(UpdateMemberLocationRequest), nameof(Member));
        
        [JsonPropertyName("member")]
        public string? Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<string?> _location = new PropertyValue<string?>(nameof(UpdateMemberLocationRequest), nameof(Location));
        
        [JsonPropertyName("location")]
        public string? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(UpdateMemberLocationRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(UpdateMemberLocationRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<string?> _previousLocation = new PropertyValue<string?>(nameof(UpdateMemberLocationRequest), nameof(PreviousLocation));
        
        [JsonPropertyName("previousLocation")]
        public string? PreviousLocation
        {
            get { return _previousLocation.GetValue(); }
            set { _previousLocation.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path + "->WithMember()", validateHasBeenSet);
            _location.SetAccessPath(path + "->WithLocation()", validateHasBeenSet);
            _since.SetAccessPath(path + "->WithSince()", validateHasBeenSet);
            _till.SetAccessPath(path + "->WithTill()", validateHasBeenSet);
            _previousLocation.SetAccessPath(path + "->WithPreviousLocation()", validateHasBeenSet);
        }
    
    }
    
}
