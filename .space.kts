job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2048
            memory = 2048
        }
        
        env.set("JB_SPACE_NUGET_URL", Params("SPACEDOTNET_NUGET_URL"))
        env.set("JB_SPACE_CLIENT_TOKEN", Secrets("SPACEDOTNET_NUGET_APIKEY"))
        
        env.set("MYGET_NUGET_URL", Params("SPACEDOTNET_MYGET_URL"))
        env.set("MYGET_CLIENT_TOKEN", Secrets("SPACEDOTNET_MYGET_APIKEY"))

        mountDir = "/mnt/mySpace"
        workDir = "/mnt/mySpace/work"
        user = "root"
        
        shellScript {
            content = """            
            	/bin/bash ./build.sh
            """
        }
    }
}
