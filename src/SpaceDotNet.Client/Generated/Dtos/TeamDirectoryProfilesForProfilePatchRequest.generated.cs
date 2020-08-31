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
    public class TeamDirectoryProfilesForProfilePatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfilePatchRequest() { }
        
        public TeamDirectoryProfilesForProfilePatchRequest(string? username = null, string? firstName = null, string? lastName = null, List<string>? emails = null, List<string>? phones = null, SpaceDate? birthday = null, string? about = null, List<string>? messengers = null, List<string>? links = null, bool? notAMember = null, SpaceDate? joined = null, SpaceDate? left = null, bool? speaksEnglish = null, string? pictureAttachmentId = null, AvatarCropSquare? avatarCropSquare = null, List<CustomFieldValue>? customFieldValues = null)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Emails = emails;
            Phones = phones;
            Birthday = birthday;
            About = about;
            Messengers = messengers;
            Links = links;
            IsNotAMember = notAMember;
            Joined = joined;
            Left = left;
            IsSpeaksEnglish = speaksEnglish;
            PictureAttachmentId = pictureAttachmentId;
            AvatarCropSquare = avatarCropSquare;
            CustomFieldValues = customFieldValues;
        }
        
        private PropertyValue<string?> _username = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Username));
        
        [JsonPropertyName("username")]
        public string? Username
        {
            get { return _username.GetValue(); }
            set { _username.SetValue(value); }
        }
    
        private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(FirstName));
        
        [JsonPropertyName("firstName")]
        public string? FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(LastName));
        
        [JsonPropertyName("lastName")]
        public string? LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _phones = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Phones));
        
        [JsonPropertyName("phones")]
        public List<string>? Phones
        {
            get { return _phones.GetValue(); }
            set { _phones.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _birthday = new PropertyValue<SpaceDate?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Birthday));
        
        [JsonPropertyName("birthday")]
        public SpaceDate? Birthday
        {
            get { return _birthday.GetValue(); }
            set { _birthday.SetValue(value); }
        }
    
        private PropertyValue<string?> _about = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(About));
        
        [JsonPropertyName("about")]
        public string? About
        {
            get { return _about.GetValue(); }
            set { _about.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _messengers = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Messengers));
        
        [JsonPropertyName("messengers")]
        public List<string>? Messengers
        {
            get { return _messengers.GetValue(); }
            set { _messengers.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _links = new PropertyValue<List<string>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Links));
        
        [JsonPropertyName("links")]
        public List<string>? Links
        {
            get { return _links.GetValue(); }
            set { _links.SetValue(value); }
        }
    
        private PropertyValue<bool?> _notAMember = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(IsNotAMember));
        
        [JsonPropertyName("notAMember")]
        public bool? IsNotAMember
        {
            get { return _notAMember.GetValue(); }
            set { _notAMember.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _joined = new PropertyValue<SpaceDate?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Joined));
        
        [JsonPropertyName("joined")]
        public SpaceDate? Joined
        {
            get { return _joined.GetValue(); }
            set { _joined.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _left = new PropertyValue<SpaceDate?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(Left));
        
        [JsonPropertyName("left")]
        public SpaceDate? Left
        {
            get { return _left.GetValue(); }
            set { _left.SetValue(value); }
        }
    
        private PropertyValue<bool?> _speaksEnglish = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(IsSpeaksEnglish));
        
        [JsonPropertyName("speaksEnglish")]
        public bool? IsSpeaksEnglish
        {
            get { return _speaksEnglish.GetValue(); }
            set { _speaksEnglish.SetValue(value); }
        }
    
        private PropertyValue<string?> _pictureAttachmentId = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(PictureAttachmentId));
        
        [JsonPropertyName("pictureAttachmentId")]
        public string? PictureAttachmentId
        {
            get { return _pictureAttachmentId.GetValue(); }
            set { _pictureAttachmentId.SetValue(value); }
        }
    
        private PropertyValue<AvatarCropSquare?> _avatarCropSquare = new PropertyValue<AvatarCropSquare?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(AvatarCropSquare));
        
        [JsonPropertyName("avatarCropSquare")]
        public AvatarCropSquare? AvatarCropSquare
        {
            get { return _avatarCropSquare.GetValue(); }
            set { _avatarCropSquare.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldValue>?> _customFieldValues = new PropertyValue<List<CustomFieldValue>?>(nameof(TeamDirectoryProfilesForProfilePatchRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValue>? CustomFieldValues
        {
            get { return _customFieldValues.GetValue(); }
            set { _customFieldValues.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _username.SetAccessPath(path, validateHasBeenSet);
            _firstName.SetAccessPath(path, validateHasBeenSet);
            _lastName.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _phones.SetAccessPath(path, validateHasBeenSet);
            _birthday.SetAccessPath(path, validateHasBeenSet);
            _about.SetAccessPath(path, validateHasBeenSet);
            _messengers.SetAccessPath(path, validateHasBeenSet);
            _links.SetAccessPath(path, validateHasBeenSet);
            _notAMember.SetAccessPath(path, validateHasBeenSet);
            _joined.SetAccessPath(path, validateHasBeenSet);
            _left.SetAccessPath(path, validateHasBeenSet);
            _speaksEnglish.SetAccessPath(path, validateHasBeenSet);
            _pictureAttachmentId.SetAccessPath(path, validateHasBeenSet);
            _avatarCropSquare.SetAccessPath(path, validateHasBeenSet);
            _customFieldValues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
