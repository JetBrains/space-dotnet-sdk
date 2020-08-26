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
    public sealed class M2PackageDeletedDetailsDto
         : M2PackageContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2PackageDeletedDetails";
        
        public M2PackageDeletedDetailsDto() { }
        
        public M2PackageDeletedDetailsDto(PackageVersionInfoDto pkg)
        {
            Pkg = pkg;
        }
        
        private PropertyValue<PackageVersionInfoDto> _pkg = new PropertyValue<PackageVersionInfoDto>(nameof(M2PackageDeletedDetailsDto), nameof(Pkg));
        
        [Required]
        [JsonPropertyName("pkg")]
        public PackageVersionInfoDto Pkg
        {
            get { return _pkg.GetValue(); }
            set { _pkg.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _pkg.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
