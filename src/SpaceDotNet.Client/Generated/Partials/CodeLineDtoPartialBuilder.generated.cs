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

namespace SpaceDotNet.Client.CodeLineDtoPartialBuilder
{
    public static class CodeLineDtoPartialExtensions
    {
        public static Partial<CodeLineDto> WithText(this Partial<CodeLineDto> it)
            => it.AddFieldName("text");
        
        public static Partial<CodeLineDto> WithIndex(this Partial<CodeLineDto> it)
            => it.AddFieldName("index");
        
        public static Partial<CodeLineDto> WithOffset(this Partial<CodeLineDto> it)
            => it.AddFieldName("offset");
        
        public static Partial<CodeLineDto> WithSyntax(this Partial<CodeLineDto> it)
            => it.AddFieldName("syntax");
        
        public static Partial<CodeLineDto> WithSyntax(this Partial<CodeLineDto> it, Func<Partial<SyntaxMarkupDto>, Partial<SyntaxMarkupDto>> partialBuilder)
            => it.AddFieldName("syntax", partialBuilder(new Partial<SyntaxMarkupDto>(it)));
        
    }
    
}
