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
    public sealed class MeetingOrganizerApplication
         : MeetingOrganizer, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MeetingOrganizer.Application";
        
        public MeetingOrganizerApplication() { }
        
        public MeetingOrganizerApplication(ESService? appRef = null, ESApp? applicationRef = null)
        {
            AppRef = appRef;
            ApplicationRef = applicationRef;
        }
        
        private PropertyValue<ESService?> _appRef = new PropertyValue<ESService?>(nameof(MeetingOrganizerApplication), nameof(AppRef));
        
        [JsonPropertyName("appRef")]
        public ESService? AppRef
        {
            get => _appRef.GetValue();
            set => _appRef.SetValue(value);
        }
    
        private PropertyValue<ESApp?> _applicationRef = new PropertyValue<ESApp?>(nameof(MeetingOrganizerApplication), nameof(ApplicationRef));
        
        [JsonPropertyName("applicationRef")]
        public ESApp? ApplicationRef
        {
            get => _applicationRef.GetValue();
            set => _applicationRef.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _appRef.SetAccessPath(path, validateHasBeenSet);
            _applicationRef.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
