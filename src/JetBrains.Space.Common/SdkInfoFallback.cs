#if USE_SDKINFO_FALLBACK
// ReSharper disable once CheckNamespace
namespace JetBrains.Space.Client;

/// <summary>
/// Fallback version of the JetBrains Space SDK for .NET.
/// </summary>
/// <remarks>
/// This class is only present when compiling before code is generated.
/// </remarks>
public static class SdkInfo
{
    public const string Version = "Fallback";
}
#endif