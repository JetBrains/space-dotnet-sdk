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

namespace SpaceDotNet.Client.CreateApplicationPasswordRequestExtensions
{
    public static class CreateApplicationPasswordRequestPartialExtensions
    {
        public static Partial<CreateApplicationPasswordRequest> WithName(this Partial<CreateApplicationPasswordRequest> it)    => it.AddFieldName("name");
        
        public static Partial<CreateApplicationPasswordRequest> WithScope(this Partial<CreateApplicationPasswordRequest> it)    => it.AddFieldName("scope");
        
    }
    
}
