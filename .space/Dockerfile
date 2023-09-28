FROM ubuntu:22.04

ENV LANG=C.UTF-8
ENV DEBIAN_FRONTEND=noninteractive
ENV TZ=Etc/UTC
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV PATH="$PATH:/usr/share/dotnet:/usr/share/dotnet/tools"
RUN echo "export PATH=${PATH}:/usr/share/dotnet:/usr/share/dotnet/tools" >> /root/.bashrc

RUN set -ex && \
    apt-get update && apt-get install -y apt-utils apt-transport-https

## Tools
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
    wget https://dot.net/v1/dotnet-install.sh && \
    chmod +x ./dotnet-install.sh && \
    ./dotnet-install.sh --channel 6.0 && \
    ./dotnet-install.sh --channel 7.0 && \
    ./dotnet-install.sh --channel 8.0.1xx --quality preview && \
	mv /root/.dotnet /usr/share/dotnet/ && \
    dotnet --list-sdks

## Clean up packages list
RUN rm -rf /var/lib/apt/lists/*