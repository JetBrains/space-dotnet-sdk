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

namespace JetBrains.Space.Client.DocumentInContainerPartialBuilder
{
    public static class DocumentInContainerPartialExtensions
    {
        public static Partial<DocumentInContainer> WithId(this Partial<DocumentInContainer> it)
            => it.AddFieldName("id");
        
        public static Partial<DocumentInContainer> WithIsArchived(this Partial<DocumentInContainer> it)
            => it.AddFieldName("archived");
        
        public static Partial<DocumentInContainer> WithContainerLinkId(this Partial<DocumentInContainer> it)
            => it.AddFieldName("containerLinkId");
        
        public static Partial<DocumentInContainer> WithTitle(this Partial<DocumentInContainer> it)
            => it.AddFieldName("title");
        
        public static Partial<DocumentInContainer> WithAuthor(this Partial<DocumentInContainer> it)
            => it.AddFieldName("author");
        
        public static Partial<DocumentInContainer> WithAuthor(this Partial<DocumentInContainer> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<DocumentInContainer> WithModified(this Partial<DocumentInContainer> it)
            => it.AddFieldName("modified");
        
        public static Partial<DocumentInContainer> WithCreated(this Partial<DocumentInContainer> it)
            => it.AddFieldName("created");
        
        public static Partial<DocumentInContainer> WithModifiedBy(this Partial<DocumentInContainer> it)
            => it.AddFieldName("modifiedBy");
        
        public static Partial<DocumentInContainer> WithModifiedBy(this Partial<DocumentInContainer> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("modifiedBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<DocumentInContainer> WithIsShared(this Partial<DocumentInContainer> it)
            => it.AddFieldName("shared");
        
        public static Partial<DocumentInContainer> WithPublicationDetails2(this Partial<DocumentInContainer> it)
            => it.AddFieldName("publicationDetails2");
        
        public static Partial<DocumentInContainer> WithPublicationDetails2(this Partial<DocumentInContainer> it, Func<Partial<PublicationDetails>, Partial<PublicationDetails>> partialBuilder)
            => it.AddFieldName("publicationDetails2", partialBuilder(new Partial<PublicationDetails>(it)));
        
        public static Partial<DocumentInContainer> WithFolderRef(this Partial<DocumentInContainer> it)
            => it.AddFieldName("folderRef");
        
        public static Partial<DocumentInContainer> WithFolderRef(this Partial<DocumentInContainer> it, Func<Partial<DocumentFolder>, Partial<DocumentFolder>> partialBuilder)
            => it.AddFieldName("folderRef", partialBuilder(new Partial<DocumentFolder>(it)));
        
        public static Partial<DocumentInContainer> WithContainerInfo(this Partial<DocumentInContainer> it)
            => it.AddFieldName("containerInfo");
        
        public static Partial<DocumentInContainer> WithContainerInfo(this Partial<DocumentInContainer> it, Func<Partial<DocumentContainerInfo>, Partial<DocumentContainerInfo>> partialBuilder)
            => it.AddFieldName("containerInfo", partialBuilder(new Partial<DocumentContainerInfo>(it)));
        
        public static Partial<DocumentInContainer> WithBodyType(this Partial<DocumentInContainer> it)
            => it.AddFieldName("bodyType");
        
        public static Partial<DocumentInContainer> WithBodyType(this Partial<DocumentInContainer> it, Func<Partial<DocumentBodyType>, Partial<DocumentBodyType>> partialBuilder)
            => it.AddFieldName("bodyType", partialBuilder(new Partial<DocumentBodyType>(it)));
        
        public static Partial<DocumentInContainer> WithIsDeleted(this Partial<DocumentInContainer> it)
            => it.AddFieldName("deleted");
        
        public static Partial<DocumentInContainer> WithArchivedBy(this Partial<DocumentInContainer> it)
            => it.AddFieldName("archivedBy");
        
        public static Partial<DocumentInContainer> WithArchivedBy(this Partial<DocumentInContainer> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("archivedBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<DocumentInContainer> WithArchivedAt(this Partial<DocumentInContainer> it)
            => it.AddFieldName("archivedAt");
        
        public static Partial<DocumentInContainer> WithIsPublished(this Partial<DocumentInContainer> it)
            => it.AddFieldName("published");
        
        public static Partial<DocumentInContainer> WithAccessOrdinal(this Partial<DocumentInContainer> it)
            => it.AddFieldName("accessOrdinal");
        
        public static Partial<DocumentInContainer> WithDocumentBody(this Partial<DocumentInContainer> it)
            => it.AddFieldName("documentBody");
        
        public static Partial<DocumentInContainer> WithDocumentBody(this Partial<DocumentInContainer> it, Func<Partial<DocumentBody>, Partial<DocumentBody>> partialBuilder)
            => it.AddFieldName("documentBody", partialBuilder(new Partial<DocumentBody>(it)));
        
    }
    
}
