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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class ReviewSorting : Enumeration
    {
        private ReviewSorting(string value) : base(value) { }
        
        public static readonly ReviewSorting CreatedAtAsc = new ReviewSorting("CreatedAtAsc");
        public static readonly ReviewSorting CreatedAtDesc = new ReviewSorting("CreatedAtDesc");
        public static readonly ReviewSorting LastUpdatedAsc = new ReviewSorting("LastUpdatedAsc");
        public static readonly ReviewSorting LastUpdatedDesc = new ReviewSorting("LastUpdatedDesc");
    }
    
}
