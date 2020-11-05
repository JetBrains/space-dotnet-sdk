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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class HADefaultValue
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "HA_DefaultValue";
        
        public static HADefaultValueCollection Collection(List<HADefaultValue> elements)
            => new HADefaultValueCollection(elements: elements);
        
        public static HADefaultValueConst Const()
            => new HADefaultValueConst();
        
        public static HADefaultValueMap Map(Dictionary<string, HADefaultValue> elements)
            => new HADefaultValueMap(elements: elements);
        
        public static HADefaultValueReference Reference(string paramName)
            => new HADefaultValueReference(paramName: paramName);
        
        public HADefaultValue() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}