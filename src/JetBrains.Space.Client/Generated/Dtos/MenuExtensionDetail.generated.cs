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
    public sealed class MenuExtensionDetail
         : IPropagatePropertyAccessPath
    {
        public MenuExtensionDetail() { }
        
        public MenuExtensionDetail(string menuId, string name, string? description = null)
        {
            MenuId = menuId;
            Name = name;
            Description = description;
        }
        
        private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(MenuExtensionDetail), nameof(MenuId));
        
        [Required]
        [JsonPropertyName("menuId")]
        public string MenuId
        {
            get => _menuId.GetValue();
            set => _menuId.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(MenuExtensionDetail), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(MenuExtensionDetail), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _menuId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
