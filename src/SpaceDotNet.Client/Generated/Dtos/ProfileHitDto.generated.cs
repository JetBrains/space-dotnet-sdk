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
    public sealed class ProfileHitDto
         : EntityHitDto, IClassNameConvertible
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProfileHitDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(ProfileHitDto), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score { get { return _score.GetValue(); } set { _score.SetValue(value); } }
    
        private PropertyValue<string> _firstName = new PropertyValue<string>(nameof(ProfileHitDto), nameof(FirstName));
        
        [Required]
        [JsonPropertyName("firstName")]
        public string FirstName { get { return _firstName.GetValue(); } set { _firstName.SetValue(value); } }
    
        private PropertyValue<string> _lastName = new PropertyValue<string>(nameof(ProfileHitDto), nameof(LastName));
        
        [Required]
        [JsonPropertyName("lastName")]
        public string LastName { get { return _lastName.GetValue(); } set { _lastName.SetValue(value); } }
    
        private PropertyValue<string> _userName = new PropertyValue<string>(nameof(ProfileHitDto), nameof(UserName));
        
        [Required]
        [JsonPropertyName("userName")]
        public string UserName { get { return _userName.GetValue(); } set { _userName.SetValue(value); } }
    
        private PropertyValue<List<string>> _phones = new PropertyValue<List<string>>(nameof(ProfileHitDto), nameof(Phones));
        
        [Required]
        [JsonPropertyName("phones")]
        public List<string> Phones { get { return _phones.GetValue(); } set { _phones.SetValue(value); } }
    
        private PropertyValue<List<string>> _emails = new PropertyValue<List<string>>(nameof(ProfileHitDto), nameof(Emails));
        
        [Required]
        [JsonPropertyName("emails")]
        public List<string> Emails { get { return _emails.GetValue(); } set { _emails.SetValue(value); } }
    
        private PropertyValue<List<string>> _links = new PropertyValue<List<string>>(nameof(ProfileHitDto), nameof(Links));
        
        [Required]
        [JsonPropertyName("links")]
        public List<string> Links { get { return _links.GetValue(); } set { _links.SetValue(value); } }
    
        private PropertyValue<List<string>> _messengers = new PropertyValue<List<string>>(nameof(ProfileHitDto), nameof(Messengers));
        
        [Required]
        [JsonPropertyName("messengers")]
        public List<string> Messengers { get { return _messengers.GetValue(); } set { _messengers.SetValue(value); } }
    
        private PropertyValue<bool> _notAMember = new PropertyValue<bool>(nameof(ProfileHitDto), nameof(NotAMember));
        
        [Required]
        [JsonPropertyName("notAMember")]
        public bool NotAMember { get { return _notAMember.GetValue(); } set { _notAMember.SetValue(value); } }
    
        private PropertyValue<TDMemberProfileDto> _ref = new PropertyValue<TDMemberProfileDto>(nameof(ProfileHitDto), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public TDMemberProfileDto Ref { get { return _ref.GetValue(); } set { _ref.SetValue(value); } }
    
        private PropertyValue<List<CustomFieldHitDto>> _customFields = new PropertyValue<List<CustomFieldHitDto>>(nameof(ProfileHitDto), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public List<CustomFieldHitDto> CustomFields { get { return _customFields.GetValue(); } set { _customFields.SetValue(value); } }
    
    }
    
}
