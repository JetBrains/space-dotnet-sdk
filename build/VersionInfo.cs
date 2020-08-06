public class VersionInfo
{
    public string AssemblySemVer { get; }
    public string AssemblySemFileVer { get; }
    public string InformationalVersion { get; }
    public string NuGetVersion { get; }

    public VersionInfo(string assemblySemVer, string assemblySemFileVer, string informationalVersion, string nuGetVersion)
    {
        AssemblySemVer = assemblySemVer;
        AssemblySemFileVer = assemblySemFileVer;
        InformationalVersion = informationalVersion;
        NuGetVersion = nuGetVersion;
    }
}