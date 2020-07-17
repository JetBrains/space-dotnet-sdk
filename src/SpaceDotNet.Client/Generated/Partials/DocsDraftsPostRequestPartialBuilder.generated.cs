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

namespace SpaceDotNet.Client.DocsDraftsPostRequestPartialBuilder
{
    public static class DocsDraftsPostRequestPartialExtensions
    {
        public static Partial<DocsDraftsPostRequest> WithTitle(this Partial<DocsDraftsPostRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<DocsDraftsPostRequest> WithText(this Partial<DocsDraftsPostRequest> it)
            => it.AddFieldName("text");
        
        public static Partial<DocsDraftsPostRequest> WithTextVersion(this Partial<DocsDraftsPostRequest> it)
            => it.AddFieldName("textVersion");
        
        public static Partial<DocsDraftsPostRequest> WithType(this Partial<DocsDraftsPostRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<DocsDraftsPostRequest> WithType(this Partial<DocsDraftsPostRequest> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<DocsDraftsPostRequest> WithPublicationDetails(this Partial<DocsDraftsPostRequest> it)
            => it.AddFieldName("publicationDetails");
        
        public static Partial<DocsDraftsPostRequest> WithPublicationDetails(this Partial<DocsDraftsPostRequest> it, Func<Partial<DraftPublicationDetailsDto>, Partial<DraftPublicationDetailsDto>> partialBuilder)
            => it.AddFieldName("publicationDetails", partialBuilder(new Partial<DraftPublicationDetailsDto>(it)));
        
    }
    
}