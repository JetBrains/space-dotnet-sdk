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

namespace SpaceDotNet.Client.DocumentFolderRecordDtoPartialBuilder
{
    public static class DocumentFolderRecordDtoPartialExtensions
    {
        public static Partial<DocumentFolderRecordDto> WithId(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<DocumentFolderRecordDto> WithArchived(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<DocumentFolderRecordDto> WithName(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("name");
        
        public static Partial<DocumentFolderRecordDto> WithParent(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<DocumentFolderRecordDto> WithParentRecursive(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("parent!");
        
        public static Partial<DocumentFolderRecordDto> WithParent(this Partial<DocumentFolderRecordDto> it, Func<Partial<DocumentFolderRecordDto>, Partial<DocumentFolderRecordDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<DocumentFolderRecordDto>(it)));
        
        public static Partial<DocumentFolderRecordDto> WithSubfolders(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("subfolders");
        
        public static Partial<DocumentFolderRecordDto> WithSubfoldersRecursive(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("subfolders!");
        
        public static Partial<DocumentFolderRecordDto> WithSubfolders(this Partial<DocumentFolderRecordDto> it, Func<Partial<DocumentFolderRecordDto>, Partial<DocumentFolderRecordDto>> partialBuilder)
            => it.AddFieldName("subfolders", partialBuilder(new Partial<DocumentFolderRecordDto>(it)));
        
        public static Partial<DocumentFolderRecordDto> WithDocuments(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("documents");
        
        public static Partial<DocumentFolderRecordDto> WithDocuments(this Partial<DocumentFolderRecordDto> it, Func<Partial<DRDraftHeaderDto>, Partial<DRDraftHeaderDto>> partialBuilder)
            => it.AddFieldName("documents", partialBuilder(new Partial<DRDraftHeaderDto>(it)));
        
        public static Partial<DocumentFolderRecordDto> WithOwner(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<DocumentFolderRecordDto> WithOwner(this Partial<DocumentFolderRecordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<DocumentFolderRecordDto> WithAlias(this Partial<DocumentFolderRecordDto> it)
            => it.AddFieldName("alias");
        
    }
    
}
