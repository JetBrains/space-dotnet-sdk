using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Applications;

/// <summary>
/// Authentication code flow that the application will use to access the Space API.
/// </summary>
[PublicAPI]
public class SpaceAuthorizationCodeFlow
{
    /// <summary>
    /// Creates a new <see cref="SpaceAuthorizationCodeFlow"/> instance.
    /// </summary>
    /// <param name="redirectUris">Redirect URIs for the application.</param>
    /// <param name="pkceRequired">Is PKCE required? <see langword="true"/> if PKCE is required; <see langword="false"/> otherwise.</param>
    public SpaceAuthorizationCodeFlow(
        IEnumerable<Uri> redirectUris,
        bool pkceRequired)
    {
        RedirectUris = redirectUris;
        PkceRequired = pkceRequired;
    }
    
    /// <summary>
    /// Redirect URIs for the application.
    /// </summary>
    public IEnumerable<Uri> RedirectUris { get; }
    
    /// <summary>
    /// Is PKCE required?
    /// </summary>
    public bool PkceRequired { get; }
}