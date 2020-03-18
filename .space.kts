job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1") {
        args("build.sh")
    }
}
