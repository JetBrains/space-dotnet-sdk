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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.StickerVariantPartialBuilder
{
    public static class StickerVariantPartialExtensions
    {
        public static Partial<StickerVariant> WithId(this Partial<StickerVariant> it)
            => it.AddFieldName("id");
        
        public static Partial<StickerVariant> WithName(this Partial<StickerVariant> it)
            => it.AddFieldName("name");
        
        public static Partial<StickerVariant> WithWidth(this Partial<StickerVariant> it)
            => it.AddFieldName("width");
        
        public static Partial<StickerVariant> WithHeight(this Partial<StickerVariant> it)
            => it.AddFieldName("height");
        
    }
    
}