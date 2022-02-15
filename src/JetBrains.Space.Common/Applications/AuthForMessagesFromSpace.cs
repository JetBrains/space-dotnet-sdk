using JetBrains.Annotations;

namespace JetBrains.Space.Common.Applications;

/// <summary>
/// Authentication for messages from Space.
/// </summary>
[PublicAPI]
public enum AuthForMessagesFromSpace
{
    /// <summary>
    /// Use public key signature.
    /// </summary>
    PublicKeySignature,
    
    /// <summary>
    /// Use signing key.
    /// </summary>
    SigningKey
}