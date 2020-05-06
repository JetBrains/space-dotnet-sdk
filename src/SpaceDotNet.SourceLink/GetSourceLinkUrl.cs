using System;
using JetBrains.Annotations;
using Microsoft.Build.Framework;
using Microsoft.Build.Tasks.SourceControl;

namespace SpaceDotNet.SourceLink
{
    /// <summary>
    /// The task calculates SourceLink URL for a given SourceRoot.
    /// If the SourceRoot is associated with a git repository with a recognized domain the <see cref="SourceLinkUrl"/>
    /// output property is set to the content URL corresponding to the domain, otherwise it is set to string "N/A".
    /// </summary>
    [PublicAPI]
    public sealed class GetSourceLinkUrl : GetSourceLinkUrlGitTask
    {
        protected override string HostsItemGroupName => "SourceLinkSpaceHost";
        protected override string ProviderDisplayName => "Space";

        protected override string? BuildSourceLinkUrl(Uri contentUri, Uri gitUri, string relativeUrl, string revisionId, ITaskItem? hostItem)
            => UriUtilities.Combine(UriUtilities.Combine(contentUri.ToString(), relativeUrl), "raw/" + revisionId + "/*");
    }
}