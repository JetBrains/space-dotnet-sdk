job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2048
            memory = 2048
        }

        mountDir = "/mnt/mySpace"
        workDir = "/mnt/mySpace/work"
        user = "root"
        entrypoint("/bin/bash")
        args("./build.sh")
    }
}
