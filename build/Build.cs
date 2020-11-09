using System;
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

namespace _build
{
    [CheckBuildProjectConfigurations]
    [UnsetVisualStudioEnvironmentVariables]
    class Build : NukeBuild
    {
        public static int Main () => Execute<Build>(x => x.Package);

        [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
        readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

        [Parameter("Space - NuGet target URL", Name = "JB_SPACE_NUGET_URL")]
        readonly string? NuGetSpaceTargetUrl;

        [Parameter("Space - NuGet target API key / access token", Name = "JB_SPACE_CLIENT_TOKEN")]
        readonly string? NuGetSpaceTargetApiKey;

        [Parameter("Space (Public) - NuGet target URL", Name = "JB_SPACE_PUBLIC_NUGET_URL")]
        readonly string? NuGetPublicSpaceTargetUrl;

        [Parameter("Space (Public) - NuGet target API key / access token", Name = "JB_SPACE_PUBLIC_CLIENT_TOKEN")]
        readonly string? NuGetPublicSpaceTargetApiKey;
    
        [Solution] readonly Solution? Solution;
        [VersionInfo(VersionMajor = 1, VersionMinor = 0)] readonly VersionInfo? VersionInfo;

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
                !string.IsNullOrEmpty(NuGetSpaceTargetUrl) &&
                !string.IsNullOrEmpty(NuGetSpaceTargetApiKey))
            .WhenSkipped(DependencyBehavior.Execute)
            .Executes(() =>
            {
                var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            
                DotNetNuGetPush(_ => _
                        .SetSource(NuGetSpaceTargetUrl)
                        .SetApiKey(NuGetSpaceTargetApiKey)
                        .CombineWith(packages, (_, v) => _
                            .SetTargetPath(v)),
                    degreeOfParallelism: 5,
                    completeOnFailure: true);
            });

        Target PushPackagesToPublicSpace => _ => _
            .TriggeredBy(Package)
            .OnlyWhenStatic(() =>
                (Environment.GetEnvironmentVariable("JB_SPACE_GIT_BRANCH") ?? "").Contains("main", StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrEmpty(NuGetPublicSpaceTargetUrl) &&
                !string.IsNullOrEmpty(NuGetPublicSpaceTargetApiKey))
            .WhenSkipped(DependencyBehavior.Execute)
            .Executes(() =>
            {
                var packages = ArtifactsDirectory.GlobFiles("*.nupkg");
            
                DotNetNuGetPush(_ => _
                        .SetSource(NuGetPublicSpaceTargetUrl)
                        .SetApiKey(NuGetPublicSpaceTargetApiKey)
                        .CombineWith(packages, (_, v) => _
                            .SetTargetPath(v)),
                    degreeOfParallelism: 5,
                    completeOnFailure: true);
            });
    }
}