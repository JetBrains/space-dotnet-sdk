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

namespace SpaceDotNet.Client.FileAttachmentDtoPartialBuilder
{
    public static class FileAttachmentDtoPartialExtensions
    {
        public static Partial<FileAttachmentDto> WithId(this Partial<FileAttachmentDto> it)
            => it.AddFieldName("id");
        
        public static Partial<FileAttachmentDto> WithSizeBytes(this Partial<FileAttachmentDto> it)
            => it.AddFieldName("sizeBytes");
        
        public static Partial<FileAttachmentDto> WithFilename(this Partial<FileAttachmentDto> it)
            => it.AddFieldName("filename");
        
    }
    
}
