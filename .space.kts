job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1") {
        mountDir = "/mnt/mySpace"
        workDir = "/mnt/mySpace/work"
        user = "root"
        entrypoint("/bin/sh")
        args("./build.sh")
    }
}
