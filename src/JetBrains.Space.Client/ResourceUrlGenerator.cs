#nullable enable

using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace JetBrains.Space.Client;

/// <summary>
/// This class provides methods to generate URLs for various resources in a Space organization.
/// </summary>
[PublicAPI]
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.Experimental("SPC101")]
#elif NET6_0_OR_GREATER
[Obsolete("ResourceUrlGenerator is an experimental feature.", DiagnosticId = "SPC101")]
#else
    [Obsolete("ResourceUrlGenerator is an experimental feature.")]
#endif
public class ResourceUrlGenerator
{
    private readonly Uri _serverUrl;

    /// <summary>
    /// Instantiates a new <see cref="ResourceUrlGenerator"/> to generate URLs for various resources in a Space organization.
    /// </summary>
    /// <param name="serverUrl">The Space organization URL to generate URLs for.</param>
    public ResourceUrlGenerator(Uri serverUrl)
    {
        _serverUrl = serverUrl;
    }

    /// <summary>
    /// Generates a profile URL for the given profile identifier.
    /// </summary>
    /// <param name="profileIdentifier">The profile identifier to generate the URL for.</param>
    /// <returns>The URL for the profile.</returns>
    public Uri GenerateProfileUrl(
        ProfileIdentifier.ProfileIdentifierUsername profileIdentifier)
    {
        var builder = new UriBuilder(_serverUrl)
        {
            Path = $"/m/{profileIdentifier}"
        };
        return builder.Uri;
    }

    /// <summary>
    /// Generates the URL for a user profile in a Space organization.
    /// </summary>
    /// <param name="profileIdentifier">The profile identifier of the user.</param>
    /// <returns>The URL for the user's profile.</returns>
    public Uri GenerateProfileUrl(
        ProfileIdentifier.ProfileIdentifierMe profileIdentifier)
    {
        var builder = new UriBuilder(_serverUrl)
        {
            Path = $"/m/{profileIdentifier}"
        };
        return builder.Uri;
    }

    /// <summary>
    /// Generates a URL for a project in a Space organization.
    /// </summary>
    /// <param name="projectKey">The key of the project.</param>
    /// <returns>A <see cref="System.Uri"/> representing the URL of the project.</returns>
    public Uri GenerateProjectUrl(
        ProjectIdentifier.ProjectIdentifierKey projectKey)
    {
        var builder = new UriBuilder(_serverUrl)
        {
            Path = $"/p/{projectKey}"
        };
        return builder.Uri;
    }

    /// <summary>
    /// Generates a URL for a repository in a Space organization.
    /// </summary>
    /// <param name="projectKey">The key of the project.</param>
    /// <param name="repositoryName">The name of the repository.</param>
    /// <returns>The URL of the repository.</returns>
    public Uri GenerateRepositoryUrl(
        ProjectIdentifier.ProjectIdentifierKey projectKey,
        string repositoryName)
    {
        var builder = new UriBuilder(_serverUrl)
        {
            Path = $"/p/{projectKey}/repositories/{repositoryName.Trim()}"
        };
        return builder.Uri;
    }

    /// <summary>
    /// Generates a URL for a code review in a Space project.
    /// </summary>
    /// <param name="projectKey">The key of the project.</param>
    /// <param name="reviewNumber">The number of the code review.</param>
    /// <returns>The URL of the code review.</returns>
    public Uri GenerateCodeReviewUrl(
        ProjectIdentifier.ProjectIdentifierKey projectKey,
        ReviewIdentifier.ReviewIdentifierNumber reviewNumber)
    {
        var builder = new UriBuilder(_serverUrl)
        {
            Path = $"/p/{projectKey}/code-reviews/{reviewNumber}"
        };
        return builder.Uri;
    }
}