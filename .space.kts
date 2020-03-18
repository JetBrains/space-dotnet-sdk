job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        mountDir = "/mnt/mySpace"
        workDir = "/mnt/mySpace/work"
        user = "root"
        entrypoint("/bin/bash")
        args("./build.sh")
    }
}
