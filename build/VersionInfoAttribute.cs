using System;
using System.Linq;
using System.Reflection;
using Nuke.Common.Tools.Git;
using Nuke.Common.ValueInjection;

namespace _build
{
    public class VersionInfoAttribute : ValueInjectionAttributeBase
    {
        public int VersionMajor { get; set; } = 1;
        public int VersionMinor { get; set; } = 0;
    
        public override object GetValue(MemberInfo member, object instance) =>
            GetFromSpace() ?? GetFromGit() ?? GetFromTime();

        bool IsMainBranch(string branch) => 
            string.Equals(branch, "refs/heads/main", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(branch, "main", StringComparison.OrdinalIgnoreCase);

        VersionInfo? GetFromSpace()
        {
            var executionNumber = Environment.GetEnvironmentVariable("JB_SPACE_EXECUTION_NUMBER");
            var branch = Environment.GetEnvironmentVariable("JB_SPACE_GIT_BRANCH")?.Replace("refs/heads/", "").Replace("/", "-");
            var revision = Environment.GetEnvironmentVariable("JB_SPACE_GIT_REVISION");

            if (!string.IsNullOrEmpty(executionNumber) && !string.IsNullOrEmpty(branch) && !string.IsNullOrEmpty(revision))
            {
                return new VersionInfo(
                    $"{VersionMajor}.{VersionMinor}.{executionNumber}.0",
                    $"{VersionMajor}.{VersionMinor}.{executionNumber}.0",
                    $"{VersionMajor}.{VersionMinor}.{executionNumber}.0+Branch.{branch}.Sha.{revision}",
                    IsMainBranch(branch) 
                        ? $"{VersionMajor}.{VersionMinor}.0-beta.{executionNumber}"
                        : $"0.1.1337-{branch}.{executionNumber}");
            }

            return null;
        }

        VersionInfo? GetFromGit()
        {
            if (!GitTasks.GitIsDetached())
            {
                var commitCount = GitTasks.Git("rev-list HEAD --count", logOutput: false).Select(x => x.Text).Single();
                var branch = GitTasks.GitCurrentBranch()?.Replace("refs/heads/", "").Replace("/", "-");
                var revision = GitTasks.Git("rev-parse HEAD", logOutput: false).Select(x => x.Text).Single();
            
                if (!string.IsNullOrEmpty(commitCount) && !string.IsNullOrEmpty(branch) && !string.IsNullOrEmpty(revision))
                {
                    return new VersionInfo(
                        $"{VersionMajor}.{VersionMinor}.{commitCount}.0",
                        $"{VersionMajor}.{VersionMinor}.{commitCount}.0",
                        $"{VersionMajor}.{VersionMinor}.{commitCount}.0+Branch.{branch}.Sha.{revision}",
                        IsMainBranch(branch) 
                            ? $"{VersionMajor}.{VersionMinor}.{commitCount}"
                            : $"{VersionMajor}.{VersionMinor}.{commitCount}-{branch}");
                }
            }

            return null;
        }

        VersionInfo GetFromTime()
        {
            // [last two digits of year][day of year number]

            var x = DateTime.UtcNow.Year.ToString().Substring(-2) + DateTime.UtcNow.DayOfYear;
            var y = DateTime.UtcNow.ToString("HHmmss");
        
            return new VersionInfo(
                $"{VersionMajor}.{VersionMinor}.{x}.{y}",
                $"{VersionMajor}.{VersionMinor}.{x}.{y}",
                $"{VersionMajor}.{VersionMinor}.{x}.{y}+development",
                $"{VersionMajor}.{VersionMinor}.{x}.{y}-development");
        }
    }
}