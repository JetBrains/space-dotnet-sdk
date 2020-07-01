job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2048
            memory = 2048
        }
        
        env.set("JB_SPACE_NUGET_URL", "https://packages.jetbrains.team/nuget/p/evan/spacedotnet/v3/index.json")

        mountDir = "/mnt/mySpace"
        workDir = "/mnt/mySpace/work"
        user = "root"
        entrypoint("/bin/bash")
        args("./build.sh")
    }
}
