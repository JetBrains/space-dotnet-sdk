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

namespace SpaceDotNet.Client.StringListCFValueExtensions
{
    public static class StringListCFValueDtoPartialExtensions
    {
        public static Partial<StringListCFValueDto> WithValues(this Partial<StringListCFValueDto> it)
            => it.AddFieldName("values");
        
        public static Partial<StringListCFValueDto> WithValues(this Partial<StringListCFValueDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("values", partialBuilder(new Partial<string>()));
        
    }
    
}