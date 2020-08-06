using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    public static int Main () => Execute<Build>(x => x.Package);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("NuGet target (Space)", Name = "JB_SPACE_NUGET_URL")]
    readonly string? NuGetTargetUrlSpace;

    [Parameter("NuGet target API key / access token (Space)", Name = "JB_SPACE_CLIENT_TOKEN")]
    readonly string? NuGetTargetApiKeySpace;

    [Parameter("NuGet target (MyGet)", Name = "MYGET_NUGET_URL")]
    readonly string? NuGetTargetUrlMyGet;

    [Parameter("NuGet target API key / access token (MyGet)", Name = "MYGET_CLIENT_TOKEN")]
    readonly string? NuGetTargetApiKeyMyGet;
    
    [Solution] readonly Solution? Solution;
    [VersionInfo(VersionMajor = 0, VersionMinor = 1)] readonly VersionInfo? VersionInfo;
    // [GitVersion] readonly GitVersion? GitVersion; // NOTE: Does not work in Space due to sparse checkout

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";

    Target Clean => _ => _
        .Executes(() =>
        {
            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            EnsureCleanDirectory(ArtifactsDirectory);
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(_ => _
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(VersionInfo.AssemblySemVer)
                .SetFileVersion(VersionInfo.AssemblySemFileVer)
                .SetInformationalVersion(VersionInfo.InformationalVersion)
                .SetVersion(VersionInfo.NuGetVersion)
                .SetProperty("GeneratePackageOnBuild", "False")
                .EnableNoRestore());
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .EnableNoBuild());
        });

    Target Package => _ => _
        .DependsOn(Test)
        .Executes(() =>
        {
            foreach (var project in Solution.AllProjects.Where(p => p.GetProperty<bool>("GeneratePackageOnBuild")).ToList())
            {
                DotNetPack(_ => _
                    .SetProject(project)
                    .EnableIncludeSource()
                    .EnableIncludeSymbols()
                    .EnableNoRestore()
                    .EnableNoBuild()
                    .SetVersion(VersionInfo.NuGetVersion)
                    .SetOutputDirectory(ArtifactsDirectory));
            }
        });

    Target PushPackagesToSpace => _ => _
        .TriggeredBy(Package)
        .OnlyWhenStatic(() =>
            !string.IsNullOrEmpty(NuGetTargetUrlSpace) &&
            !string.IsNullOrEmpty(NuGetTargetApiKeySpace))
        .WhenSkipped(DependencyBehavior.Execute)
        .Executes(() =>
        {
            var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            
            DotNetNuGetPush(_ => _
                    .SetSource(NuGetTargetUrlSpace)
                    .SetApiKey(NuGetTargetApiKeySpace)
                    .CombineWith(packages, (_, v) => _
                        .SetTargetPath(v)),
                degreeOfParallelism: 5,
                completeOnFailure: true);
        });

    Target PushPackagesToMyGet => _ => _
        .TriggeredBy(Package)
        .OnlyWhenStatic(() =>
            !string.IsNullOrEmpty(NuGetTargetUrlMyGet) &&
            !string.IsNullOrEmpty(NuGetTargetApiKeyMyGet))
        .WhenSkipped(DependencyBehavior.Execute)
        .Executes(() =>
        {
            var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            
            DotNetNuGetPush(_ => _
                    .SetSource(NuGetTargetUrlMyGet)
                    .SetApiKey(NuGetTargetApiKeyMyGet)
                    .CombineWith(packages, (_, v) => _
                        .SetTargetPath(v)),
                degreeOfParallelism: 5,
                completeOnFailure: true);
        });
}