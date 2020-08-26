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
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ReviewIdentifier : IUrlParameter
    {
        public static ReviewIdentifier Id(string id)
            => new ReviewIdentifierId(id);
        
        public static ReviewIdentifier Key(string key)
            => new ReviewIdentifierKey(key);
        
        public static ReviewIdentifier Number(int number)
            => new ReviewIdentifierNumber(number);
        
        private class ReviewIdentifierId : ReviewIdentifier
        {
            public readonly string _id;
            
            public ReviewIdentifierId(string id)
            {
                _id = id;
            }
            
            public override string ToString()
            {
                return $"id:{_id}";
            }
        }
        
        private class ReviewIdentifierKey : ReviewIdentifier
        {
            public readonly string _key;
            
            public ReviewIdentifierKey(string key)
            {
                _key = key;
            }
            
            public override string ToString()
            {
                return $"key:{_key}";
            }
        }
        
        private class ReviewIdentifierNumber : ReviewIdentifier
        {
            public readonly int _number;
            
            public ReviewIdentifierNumber(int number)
            {
                _number = number;
            }
            
            public override string ToString()
            {
                return $"number:{_number}";
            }
        }
        
    }
    
}
