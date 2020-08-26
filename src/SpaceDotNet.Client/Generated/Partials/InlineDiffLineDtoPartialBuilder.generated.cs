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

namespace SpaceDotNet.Client.InlineDiffLineDtoPartialBuilder
{
    public static class InlineDiffLineDtoPartialExtensions
    {
        public static Partial<InlineDiffLineDto> WithText(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("text");
        
        public static Partial<InlineDiffLineDto> WithType(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("type");
        
        public static Partial<InlineDiffLineDto> WithType(this Partial<InlineDiffLineDto> it, Func<Partial<DiffLineType>, Partial<DiffLineType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DiffLineType>(it)));
        
        public static Partial<InlineDiffLineDto> WithOldLineNum(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("oldLineNum");
        
        public static Partial<InlineDiffLineDto> WithNewLineNum(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("newLineNum");
        
        public static Partial<InlineDiffLineDto> WithOldFileOffset(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("oldFileOffset");
        
        public static Partial<InlineDiffLineDto> WithNewFileOffset(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("newFileOffset");
        
        public static Partial<InlineDiffLineDto> WithSyntax(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("syntax");
        
        public static Partial<InlineDiffLineDto> WithSyntax(this Partial<InlineDiffLineDto> it, Func<Partial<SyntaxMarkupDto>, Partial<SyntaxMarkupDto>> partialBuilder)
            => it.AddFieldName("syntax", partialBuilder(new Partial<SyntaxMarkupDto>(it)));
        
        public static Partial<InlineDiffLineDto> WithDeletes(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("deletes");
        
        public static Partial<InlineDiffLineDto> WithDeletes(this Partial<InlineDiffLineDto> it, Func<Partial<TextRangeDto>, Partial<TextRangeDto>> partialBuilder)
            => it.AddFieldName("deletes", partialBuilder(new Partial<TextRangeDto>(it)));
        
        public static Partial<InlineDiffLineDto> WithInserts(this Partial<InlineDiffLineDto> it)
            => it.AddFieldName("inserts");
        
        public static Partial<InlineDiffLineDto> WithInserts(this Partial<InlineDiffLineDto> it, Func<Partial<TextRangeDto>, Partial<TextRangeDto>> partialBuilder)
            => it.AddFieldName("inserts", partialBuilder(new Partial<TextRangeDto>(it)));
        
    }
    
}
