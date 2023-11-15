val buildContainerImage = "ubuntu:22.04"
val buildScript = """
    apt-get update && apt-get install -y apt-utils apt-transport-https
    apt-get install -y curl unzip wget software-properties-common git

    wget https://dot.net/v1/dotnet-install.sh
    chmod +x ./dotnet-install.sh
    ./dotnet-install.sh --channel 6.0
    ./dotnet-install.sh --channel 7.0
    ./dotnet-install.sh --channel 8.0
    PATH=${'$'}PATH:${'$'}HOME/.dotnet:${'$'}HOME/.dotnet/tools
    dotnet --list-sdks

    ./build.sh
""".trimIndent()

job("Continuous integration build") {
    startOn {
        gitPush {
            enabled = true

            branchFilter {
                -"refs/merge/*"
                -"refs/pull/*"
            }
        }
    }
    
    container(buildContainerImage) {
        resources {
            cpu = 2.cpu
            memory = 4.gb
        }
        
        env.set("DOTNET_NOLOGO", "true")
        env.set("DOTNET_SKIP_FIRST_TIME_EXPERIENCE", "true")
        env.set("DOTNET_CLI_TELEMETRY_OPTOUT", "true")

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        shellScript {
            content = buildScript
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
    
    container(buildContainerImage) {
        resources {
            cpu = 2.cpu
            memory = 4.gb
        }

        env.set("DOTNET_NOLOGO", "true")
        env.set("DOTNET_SKIP_FIRST_TIME_EXPERIENCE", "true")
        env.set("DOTNET_CLI_TELEMETRY_OPTOUT", "true")

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        env.set("JB_SPACE_NUGETORG_NUGET_URL", Params("spacedotnet_nugetorg_nuget_url"))
        env.set("JB_SPACE_NUGETORG_CLIENT_TOKEN", Secrets("spacedotnet_nugetorg_nuget_apikey"))

        shellScript {
            content = buildScript
        }
    }
}

job("Remote development images") {
    startOn {
        gitPush {
            enabled = true

            branchFilter {
                +"refs/heads/main"
                -"refs/merge/*"
                -"refs/pull/*"
            }

            pathFilter {
                +".space/*.devfile.yml"
                +".space/Dockerfile"
            }
        }
    }
    
    host {
        dockerBuildPush {
            context = "."
            file = ".space/Dockerfile"
            labels["vendor"] = "JetBrains"
            tags {
                +"registry.jetbrains.team/p/evan/dev-environments/spacedotnet:latest"
            }
        }
    }
}