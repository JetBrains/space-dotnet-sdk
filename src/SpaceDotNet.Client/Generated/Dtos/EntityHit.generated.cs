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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class EntityHit
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "EntityHit";
        
        public static ArticleHit ArticleHit(string id, double score, string title, string body, ArticleRecord @ref)
            => new ArticleHit(id: id, score: score, title: title, body: body, @ref: @ref);
        
        public static BookHit BookHit(string id, double score, KBBook @ref, string title, string summary)
            => new BookHit(id: id, score: score, @ref: @ref, title: title, summary: summary);
        
        public static FolderHit FolderHit(string id, double score, KBBook bookRef, KBFolder @ref, string name)
            => new FolderHit(id: id, score: score, bookRef: bookRef, @ref: @ref, name: name);
        
        public static KbArticleHit KbArticleHit(string id, double score, KBBook bookRef, string title, string body)
            => new KbArticleHit(id: id, score: score, bookRef: bookRef, title: title, body: body);
        
        public static MessageHit MessageHit(string id, string parentItemId, double score, M2ChannelRecord channel, M2ChatReader readerRef, ChannelItemRecord @ref, string message, bool threadStarter, string? thread = null)
            => new MessageHit(id: id, parentItemId: parentItemId, score: score, channel: channel, readerRef: readerRef, @ref: @ref, message: message, threadStarter: threadStarter, thread: null);
        
        public static ProfileHit ProfileHit(string id, double score, string firstName, string lastName, string userName, List<string> phones, List<string> emails, List<string> links, List<string> messengers, List<string> internationalNames, bool notAMember, TDMemberProfile @ref, ProfileAbsencesRecord absencesRef, ProfileMembershipRecord membershipRef, ProfileLocationsRecord locationsRef, List<CustomFieldHit> customFields)
            => new ProfileHit(id: id, score: score, firstName: firstName, lastName: lastName, userName: userName, phones: phones, emails: emails, links: links, messengers: messengers, internationalNames: internationalNames, notAMember: notAMember, @ref: @ref, absencesRef: absencesRef, membershipRef: membershipRef, locationsRef: locationsRef, customFields: customFields);
        
        public static ProjectHit ProjectHit(string id, double score, string key, string name, PRProject @ref, string? description = null)
            => new ProjectHit(id: id, score: score, key: key, name: name, @ref: @ref, description: null);
        
        public EntityHit() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
