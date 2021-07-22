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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.DocsDraftsForIdPatchRequestPartialBuilder
{
    public static class DocsDraftsForIdPatchRequestPartialExtensions
    {
        public static Partial<DocsDraftsForIdPatchRequest> WithTitle(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithText(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("text");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithTextVersion(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("textVersion");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithType(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithType(this Partial<DocsDraftsForIdPatchRequest> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<DocsDraftsForIdPatchRequest> WithFolder(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("folder");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithPublicationDetails2(this Partial<DocsDraftsForIdPatchRequest> it)
            => it.AddFieldName("publicationDetails2");
        
        public static Partial<DocsDraftsForIdPatchRequest> WithPublicationDetails2(this Partial<DocsDraftsForIdPatchRequest> it, Func<Partial<PublicationDetails>, Partial<PublicationDetails>> partialBuilder)
            => it.AddFieldName("publicationDetails2", partialBuilder(new Partial<PublicationDetails>(it)));
        
    }
    
}
