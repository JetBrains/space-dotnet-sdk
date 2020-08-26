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
    public class TeamDirectoryLocationsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryLocationsPostRequest() { }
        
        public TeamDirectoryLocationsPostRequest(string name, string? timezone = null, List<int>? workdays = null, List<string>? phones = null, List<string>? emails = null, List<string>? equipment = null, string? description = null, string? address = null, string? type = null, string? parentId = null)
        {
            Name = name;
            Timezone = timezone;
            Workdays = workdays;
            Phones = phones;
            Emails = emails;
            Equipment = equipment;
            Description = description;
            Address = address;
            Type = type;
            ParentId = parentId;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryLocationsPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _timezone = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public string? Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<List<int>?> _workdays = new PropertyValue<List<int>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Workdays));
        
        [JsonPropertyName("workdays")]
        public List<int>? Workdays
        {
            get { return _workdays.GetValue(); }
            set { _workdays.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _phones = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Phones));
        
        [JsonPropertyName("phones")]
        public List<string>? Phones
        {
            get { return _phones.GetValue(); }
            set { _phones.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _equipment = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Equipment));
        
        [JsonPropertyName("equipment")]
        public List<string>? Equipment
        {
            get { return _equipment.GetValue(); }
            set { _equipment.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _address = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Address));
        
        [JsonPropertyName("address")]
        public string? Address
        {
            get { return _address.GetValue(); }
            set { _address.SetValue(value); }
        }
    
        private PropertyValue<string?> _type = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Type));
        
        [JsonPropertyName("type")]
        public string? Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(ParentId));
        
        [JsonPropertyName("parentId")]
        public string? ParentId
        {
            get { return _parentId.GetValue(); }
            set { _parentId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _workdays.SetAccessPath(path, validateHasBeenSet);
            _phones.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _equipment.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _address.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _parentId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
