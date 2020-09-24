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
    public class ChatModification
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "ChatModification";
        
        public static DeleteMessage DeleteMessage(string id)
            => new DeleteMessage(id: id);
        
        public static EditMessage EditMessage(string text, string id, List<Attachment>? attachments = null)
            => new EditMessage(text: text, id: id, attachments: null);
        
        public static NewMessage NewMessage(string text, string temporaryId, bool pending, List<Attachment>? attachments = null, string? draftTag = null)
            => new NewMessage(text: text, temporaryId: temporaryId, pending: pending, attachments: null, draftTag: null);
        
        public static PublishMessage PublishMessage(string id)
            => new PublishMessage(id: id);
        
        public ChatModification() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}