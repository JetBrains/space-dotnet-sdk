FROM mcr.microsoft.com/dotnet/sdk:7.0-jammy

ENV LANG=C.UTF-8
ENV DEBIAN_FRONTEND=noninteractive
ENV TZ=Etc/UTC
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1

RUN apt-get update && apt-get install -y apt-utils apt-transport-https

## Standard tools, Git, Docker
RUN set -ex && \
    apt-get install -y \
    # Utilities \
    curl unzip wget software-properties-common ssh socat man-db gnupg2 pass lsof \
    # VCS \
    git \
    # Docker
    docker docker-compose

## .NET
RUN set -ex && \
    wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    rm packages-microsoft-prod.deb && \
    apt-get update && \
    apt-get install -y dotnet-sdk-6.0 dotnet-sdk-7.0

## Clean up packages list
RUN rm -rf /var/lib/apt/lists/*