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
    public sealed class HAResourceDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(HAResourceDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<HAPathDto> _path = new PropertyValue<HAPathDto>(nameof(HAResourceDto), nameof(Path));
        
        [Required]
        [JsonPropertyName("path")]
        public HAPathDto Path
        {
            get { return _path.GetValue(); }
            set { _path.SetValue(value); }
        }
    
        private PropertyValue<string> _displaySingular = new PropertyValue<string>(nameof(HAResourceDto), nameof(DisplaySingular));
        
        [Required]
        [JsonPropertyName("displaySingular")]
        public string DisplaySingular
        {
            get { return _displaySingular.GetValue(); }
            set { _displaySingular.SetValue(value); }
        }
    
        private PropertyValue<string> _displayPlural = new PropertyValue<string>(nameof(HAResourceDto), nameof(DisplayPlural));
        
        [Required]
        [JsonPropertyName("displayPlural")]
        public string DisplayPlural
        {
            get { return _displayPlural.GetValue(); }
            set { _displayPlural.SetValue(value); }
        }
    
        private PropertyValue<HAResourceDto?> _parentResource = new PropertyValue<HAResourceDto?>(nameof(HAResourceDto), nameof(ParentResource));
        
        [JsonPropertyName("parentResource")]
        public HAResourceDto? ParentResource
        {
            get { return _parentResource.GetValue(); }
            set { _parentResource.SetValue(value); }
        }
    
        private PropertyValue<List<HAEndpointDto>> _endpoints = new PropertyValue<List<HAEndpointDto>>(nameof(HAResourceDto), nameof(Endpoints));
        
        [Required]
        [JsonPropertyName("endpoints")]
        public List<HAEndpointDto> Endpoints
        {
            get { return _endpoints.GetValue(); }
            set { _endpoints.SetValue(value); }
        }
    
        private PropertyValue<List<HAResourceDto>> _nestedResources = new PropertyValue<List<HAResourceDto>>(nameof(HAResourceDto), nameof(NestedResources));
        
        [Required]
        [JsonPropertyName("nestedResources")]
        public List<HAResourceDto> NestedResources
        {
            get { return _nestedResources.GetValue(); }
            set { _nestedResources.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _path.SetAccessPath(path + "->WithPath()", validateHasBeenSet);
            _displaySingular.SetAccessPath(path + "->WithDisplaySingular()", validateHasBeenSet);
            _displayPlural.SetAccessPath(path + "->WithDisplayPlural()", validateHasBeenSet);
            _parentResource.SetAccessPath(path + "->WithParentResource()", validateHasBeenSet);
            _endpoints.SetAccessPath(path + "->WithEndpoints()", validateHasBeenSet);
            _nestedResources.SetAccessPath(path + "->WithNestedResources()", validateHasBeenSet);
        }
    
    }
    
}
