job("Continuous integration build") {
    startOn {
        gitPush { enabled = true }
    }
    
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2.cpu
            memory = 2.gb
        }

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        shellScript {
            content = """
                mkdir .nuke/temp/
                curl -Lsfo .nuke/temp/dotnet-install.sh https://dot.net/v1/dotnet-install.sh
                chmod -x .nuke/temp/dotnet-install.sh
                
                ./dotnet-install.sh --channel 3.1
                ./dotnet-install.sh --channel 5.0
            
            	./build.sh
            """.trimIndent()
        }
    }
}

job("Build and publish to NuGet.org (manual)") {
    startOn {
        gitPush { enabled = false } // disable the default gitPush trigger
    }
    
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2.cpu
            memory = 2.gb
        }

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        env.set("JB_SPACE_NUGETORG_NUGET_URL", Params("spacedotnet_nugetorg_nuget_url"))
        env.set("JB_SPACE_NUGETORG_CLIENT_TOKEN", Secrets("spacedotnet_nugetorg_nuget_apikey"))

        shellScript {
            content = """
            	./build.sh
            """.trimIndent()
        }
    }
}