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
    public sealed class M2AbsenceItemApproveDeletedContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2AbsenceItemApproveDeletedContent";
        
        public M2AbsenceItemApproveDeletedContentDto() { }
        
        public M2AbsenceItemApproveDeletedContentDto(AbsenceRecordDto absence, TDMemberProfileDto by, bool approve)
        {
            Absence = absence;
            By = by;
            Approve = approve;
        }
        
        private PropertyValue<AbsenceRecordDto> _absence = new PropertyValue<AbsenceRecordDto>(nameof(M2AbsenceItemApproveDeletedContentDto), nameof(Absence));
        
        [Required]
        [JsonPropertyName("absence")]
        public AbsenceRecordDto Absence
        {
            get { return _absence.GetValue(); }
            set { _absence.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _by = new PropertyValue<TDMemberProfileDto>(nameof(M2AbsenceItemApproveDeletedContentDto), nameof(By));
        
        [Required]
        [JsonPropertyName("by")]
        public TDMemberProfileDto By
        {
            get { return _by.GetValue(); }
            set { _by.SetValue(value); }
        }
    
        private PropertyValue<bool> _approve = new PropertyValue<bool>(nameof(M2AbsenceItemApproveDeletedContentDto), nameof(Approve));
        
        [Required]
        [JsonPropertyName("approve")]
        public bool Approve
        {
            get { return _approve.GetValue(); }
            set { _approve.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _absence.SetAccessPath(path, validateHasBeenSet);
            _by.SetAccessPath(path, validateHasBeenSet);
            _approve.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
