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

namespace SpaceDotNet.Client.CreatePointRequestExtensions
{
    public static class CreatePointRequestPartialExtensions
    {
        public static Partial<CreatePointRequest> WithX(this Partial<CreatePointRequest> it)    => it.AddFieldName("x");
        
        public static Partial<CreatePointRequest> WithY(this Partial<CreatePointRequest> it)    => it.AddFieldName("y");
        
        public static Partial<CreatePointRequest> WithMapId(this Partial<CreatePointRequest> it)    => it.AddFieldName("mapId");
        
    }
    
}