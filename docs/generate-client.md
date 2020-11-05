# Generate client

The JetBrains Space SDK for .NET is a set of libraries that to work with the [JetBrains Space](https://jetbrains.com/space/) API.

Some components are developed manually, while the interaction with the Space HTTP API is generated code.
* Code generation is handled by `JetBrains.Space.Generator`
* Generated code is created in `S[aceotNet.Client.Generated`

To re-generate code, perform the following steps:

* Open a terminal, and set the following environment variables:
  * `JB_SPACE_API_URL` — The Space organization URL to generate client code for.
  * `JB_SPACE_CLIENT_ID` — A Space application client id to access the HTTP API model.
  * `JB_SPACE_CLIENT_SECRET` — A Space application client secret to access the HTTP API model.
* Change the directory to `src/JetBrains.Space.Generator/bin/{configuration}/{tfm}`, for example `src/JetBrains.Space.Generator/bin/Debug/netcoreapp3.1`.
* Run `JetBrains.Space.Generator.exe` and wait for it to finish.

The code generator removes all files and directories in `src/JetBrains.Space.Client/Generated`.
All changes can be committed to Git and pushed to the remote, so that CI can package all changes.