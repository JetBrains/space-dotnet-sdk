using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
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

    [Parameter("NuGet Source for Packages", Name = "JB_SPACE_NUGET_URL")]
    readonly string? NuGetSourceUrl;
    
    [Parameter("Space API URL", Name = "JB_SPACE_API_URL")]
    readonly string? SpaceApiUrl;

    [Parameter("Space API Client Id", Name = "JB_SPACE_CLIENT_ID")]
    readonly string? SpaceClientId;

    [Parameter("Space API Client Secret", Name = "JB_SPACE_CLIENT_SECRET")]
    readonly string? SpaceClientSecret;
    
    [Solution] readonly Solution? Solution;
    [GitRepository] readonly GitRepository? GitRepository;
    [GitVersion(NoFetch = true)] readonly GitVersion? GitVersion;

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
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion)
                .SetVersion(GitVersion.NuGetVersion)
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
                    .SetVersion(GitVersion.NuGetVersion)
                    .SetOutputDirectory(ArtifactsDirectory));
            }
        });

    Target PushPackages => _ => _
        .TriggeredBy(Package)
        .OnlyWhenStatic(() =>
            !string.IsNullOrEmpty(NuGetSourceUrl) && !string.IsNullOrEmpty(SpaceClientId) && !string.IsNullOrEmpty(SpaceClientSecret))
        .WhenSkipped(DependencyBehavior.Execute)
        .Executes(() =>
        {
            var packages = ArtifactsDirectory.GlobFiles("*.nupkg");

            DotNet($"nuget add source \"{NuGetSourceUrl}\" -n space -u \"{SpaceClientId}\" -p \"{SpaceClientSecret}\" --store-password-in-clear-text ");
            
            DotNetNuGetPush(_ => _
                    .SetSource(NuGetSourceUrl)
                    //.SetApiKey(SpaceClientSecret)
                    .CombineWith(packages, (_, v) => _
                        .SetTargetPath(v)),
                degreeOfParallelism: 5,
                completeOnFailure: true);
        });
}