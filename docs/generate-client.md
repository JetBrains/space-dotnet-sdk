# Generate client

The JetBrains Space SDK for .NET is a set of libraries that to work with the [JetBrains Space](https://jetbrains.com/space/) API.

Some components are developed manually, while the interaction with the Space HTTP API is generated code.
* Code generation is handled by `JetBrains.Space.Generator`
* Generated code is created in `JetBrains.Space.Client/Generated`

The code generator removes all files and directories in `src/JetBrains.Space.Client/Generated`.
All changes can be committed to Git and pushed to the remote, so that CI can package all changes.

## Generate code from a remote API model:

Use the following parameters:

`--organizationUrl=https://{organization}.jetbrains.space/ --clientId={client-id} --clientSecret={client=secret}`

Where:
* `organizationUrl` is the Space organization URL to generate client code for.
* `clientId` is a Space application client id to access the HTTP API model.
* `clientSecret` is a Space application client secret to access the HTTP API model.

Version information will be retrieved from the server.

## Generate code from a HA_model.json file:

Use the following parameters:

`--model={path-to-HA_model.json} --version={version}`

Version information must be specified using the `--version` argument.