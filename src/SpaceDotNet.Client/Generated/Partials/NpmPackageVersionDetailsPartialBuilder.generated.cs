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

namespace SpaceDotNet.Client.NpmPackageVersionDetailsPartialBuilder
{
    public static class NpmPackageVersionDetailsPartialExtensions
    {
        public static Partial<NpmPackageVersionDetails> WithType(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("type");
        
        public static Partial<NpmPackageVersionDetails> WithType(this Partial<NpmPackageVersionDetails> it, Func<Partial<PackageType>, Partial<PackageType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageType>(it)));
        
        public static Partial<NpmPackageVersionDetails> WithRepository(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("repository");
        
        public static Partial<NpmPackageVersionDetails> WithName(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("name");
        
        public static Partial<NpmPackageVersionDetails> WithVersion(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("version");
        
        public static Partial<NpmPackageVersionDetails> WithTags(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("tags");
        
        public static Partial<NpmPackageVersionDetails> WithCreated(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("created");
        
        public static Partial<NpmPackageVersionDetails> WithAccessed(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("accessed");
        
        public static Partial<NpmPackageVersionDetails> WithDownloads(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("downloads");
        
        public static Partial<NpmPackageVersionDetails> WithDiskSize(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("diskSize");
        
        public static Partial<NpmPackageVersionDetails> WithAuthor(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("author");
        
        public static Partial<NpmPackageVersionDetails> WithAuthor(this Partial<NpmPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<NpmPackageVersionDetails> WithAuthors(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("authors");
        
        public static Partial<NpmPackageVersionDetails> WithAuthors(this Partial<NpmPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<NpmPackageVersionDetails> WithMetadata(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("metadata");
        
        public static Partial<NpmPackageVersionDetails> WithMetadata(this Partial<NpmPackageVersionDetails> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<string>(it)));
        
        public static Partial<NpmPackageVersionDetails> WithDescription(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("description");
        
        public static Partial<NpmPackageVersionDetails> WithDependencies(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<NpmPackageVersionDetails> WithDependencies(this Partial<NpmPackageVersionDetails> it, Func<Partial<NpmPackageDependency>, Partial<NpmPackageDependency>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<NpmPackageDependency>(it)));
        
        public static Partial<NpmPackageVersionDetails> WithKeywords(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("keywords");
        
        public static Partial<NpmPackageVersionDetails> WithLicense(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("license");
        
        public static Partial<NpmPackageVersionDetails> WithProjectUrl(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("projectUrl");
        
        public static Partial<NpmPackageVersionDetails> WithRepositoryUrl(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("repositoryUrl");
        
        public static Partial<NpmPackageVersionDetails> WithRepositoryRevision(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("repositoryRevision");
        
        public static Partial<NpmPackageVersionDetails> WithReadme(this Partial<NpmPackageVersionDetails> it)
            => it.AddFieldName("readme");
        
    }
    
}
