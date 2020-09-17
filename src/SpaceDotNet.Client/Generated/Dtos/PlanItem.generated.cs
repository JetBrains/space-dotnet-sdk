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
    public sealed class PlanItem
         : IPropagatePropertyAccessPath
    {
        public PlanItem() { }
        
        public PlanItem(string id, string checklistId, bool hasChildren, List<PlanItem> children, PlanningTag? tag = null, string? simpleText = null, bool? simpleDone = null, Issue? issue = null, string? issueProblem = null, bool? canEditIssue = null)
        {
            Id = id;
            ChecklistId = checklistId;
            Tag = tag;
            SimpleText = simpleText;
            IsSimpleDone = simpleDone;
            Issue = issue;
            IssueProblem = issueProblem;
            CanEditIssue = canEditIssue;
            IsHasChildren = hasChildren;
            Children = children;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PlanItem), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _checklistId = new PropertyValue<string>(nameof(PlanItem), nameof(ChecklistId));
        
        [Required]
        [JsonPropertyName("checklistId")]
        public string ChecklistId
        {
            get { return _checklistId.GetValue(); }
            set { _checklistId.SetValue(value); }
        }
    
        private PropertyValue<PlanningTag?> _tag = new PropertyValue<PlanningTag?>(nameof(PlanItem), nameof(Tag));
        
        [JsonPropertyName("tag")]
        public PlanningTag? Tag
        {
            get { return _tag.GetValue(); }
            set { _tag.SetValue(value); }
        }
    
        private PropertyValue<string?> _simpleText = new PropertyValue<string?>(nameof(PlanItem), nameof(SimpleText));
        
        [JsonPropertyName("simpleText")]
        public string? SimpleText
        {
            get { return _simpleText.GetValue(); }
            set { _simpleText.SetValue(value); }
        }
    
        private PropertyValue<bool?> _simpleDone = new PropertyValue<bool?>(nameof(PlanItem), nameof(IsSimpleDone));
        
        [JsonPropertyName("simpleDone")]
        public bool? IsSimpleDone
        {
            get { return _simpleDone.GetValue(); }
            set { _simpleDone.SetValue(value); }
        }
    
        private PropertyValue<Issue?> _issue = new PropertyValue<Issue?>(nameof(PlanItem), nameof(Issue));
        
        [JsonPropertyName("issue")]
        public Issue? Issue
        {
            get { return _issue.GetValue(); }
            set { _issue.SetValue(value); }
        }
    
        private PropertyValue<string?> _issueProblem = new PropertyValue<string?>(nameof(PlanItem), nameof(IssueProblem));
        
        [JsonPropertyName("issueProblem")]
        public string? IssueProblem
        {
            get { return _issueProblem.GetValue(); }
            set { _issueProblem.SetValue(value); }
        }
    
        private PropertyValue<bool?> _canEditIssue = new PropertyValue<bool?>(nameof(PlanItem), nameof(CanEditIssue));
        
        [JsonPropertyName("canEditIssue")]
        public bool? CanEditIssue
        {
            get { return _canEditIssue.GetValue(); }
            set { _canEditIssue.SetValue(value); }
        }
    
        private PropertyValue<bool> _hasChildren = new PropertyValue<bool>(nameof(PlanItem), nameof(IsHasChildren));
        
        [Required]
        [JsonPropertyName("hasChildren")]
        public bool IsHasChildren
        {
            get { return _hasChildren.GetValue(); }
            set { _hasChildren.SetValue(value); }
        }
    
        private PropertyValue<List<PlanItem>> _children = new PropertyValue<List<PlanItem>>(nameof(PlanItem), nameof(Children));
        
        [Required]
        [JsonPropertyName("children")]
        public List<PlanItem> Children
        {
            get { return _children.GetValue(); }
            set { _children.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _checklistId.SetAccessPath(path, validateHasBeenSet);
            _tag.SetAccessPath(path, validateHasBeenSet);
            _simpleText.SetAccessPath(path, validateHasBeenSet);
            _simpleDone.SetAccessPath(path, validateHasBeenSet);
            _issue.SetAccessPath(path, validateHasBeenSet);
            _issueProblem.SetAccessPath(path, validateHasBeenSet);
            _canEditIssue.SetAccessPath(path, validateHasBeenSet);
            _hasChildren.SetAccessPath(path, validateHasBeenSet);
            _children.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}