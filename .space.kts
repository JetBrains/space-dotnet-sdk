val dotNetInstallScript = """
    apt-get update && apt-get install -y apt-utils apt-transport-https
    apt-get install -y curl unzip wget software-properties-common git
    
    wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    dpkg -i packages-microsoft-prod.deb
    rm packages-microsoft-prod.deb
    apt-get update
    apt-get install -y dotnet-sdk-3.1 dotnet-sdk-6.0

""".trimIndent()

job("Continuous integration build") {
    startOn {
        gitPush { enabled = true }
    }
    
    container("mcr.microsoft.com/dotnet/sdk:6.0-focal") {
        resources {
            cpu = 2.cpu
            memory = 2.gb
        }
        
        env.set("DOTNET_SKIP_FIRST_TIME_EXPERIENCE", "1")
        env.set("DOTNET_CLI_TELEMETRY_OPTOUT", "1")

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        shellScript {
            content = dotNetInstallScript + """            
            	./build.sh
            """.trimIndent()
        }
    }
}

job("Build and publish to NuGet.org (manual)") {
    startOn {
        gitPush { enabled = false } // disable the default gitPush trigger
    }
    
    container("Initiate Space deployment", image = "openjdk:11") {
        resources {
            cpu = 0.5.cpu
            memory = 512.mb
        }
        
        kotlinScript { api ->
            api.space().projects.automation.deployments.start(
                project = api.projectIdentifier(),
                targetIdentifier = TargetIdentifier.Key("nuget"),
                version = api.executionNumber().toString(),
                syncWithAutomationJob = true
            )
        }
    }
    
    container("mcr.microsoft.com/dotnet/sdk:6.0-focal") {
        resources {
            cpu = 2.cpu
            memory = 2.gb
        }
        
        env.set("DOTNET_SKIP_FIRST_TIME_EXPERIENCE", "1")
        env.set("DOTNET_CLI_TELEMETRY_OPTOUT", "1")

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        env.set("JB_SPACE_NUGETORG_NUGET_URL", Params("spacedotnet_nugetorg_nuget_url"))
        env.set("JB_SPACE_NUGETORG_CLIENT_TOKEN", Secrets("spacedotnet_nugetorg_nuget_apikey"))

        shellScript {
            content = dotNetInstallScript + """            
            	./build.sh
            """.trimIndent()
        }
    }
}

job("Warmup - Rider") {
    git {
        depth = UNLIMITED_DEPTH
        refSpec = "refs/*:refs/*"
    }

    startOn {
        schedule { cron("0 0 * * *") }

        gitPush {
            enabled = true

            branchFilter {
                +"refs/heads/main"
            }
        }
    }

    warmup(ide = Ide.Rider) {
        scriptLocation = "dev-env-warmup.sh"
        devfile = ".space/devfile.yml"
    }
}