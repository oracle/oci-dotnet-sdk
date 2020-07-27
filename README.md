# Oracle Cloud Infrastructure SDK for .NET

## About

The oci-dotnet-sdk provides an SDK for .NET that you can use to manage your Oracle Cloud Infrastructure resources.

The project is open source and maintained by Oracle Corp.

## Dependencies

- [.NETStandard 2.0](https://dotnet.microsoft.com/platform/dotnet-standard)

## SDK Organization

The oci-dotnet-sdk contain the following 3 groups of packages:

- **Common package**: Found in the [Common](/Common) and [Commontests](/Commontests) (unit tests for common package) directories.
  The common package provides supporting classes and methods used by service packages.
  It includes HTTP request/response (de)serialization, request signing, JSON parsing, and other helper functions.
  Most of the functions in this package are meant to be used by the service packages.
- **Examples package**: Found in the [Examples](/Examples) directory. It includes some working examples on how to use
  oci-dotnet-sdk to manage Oracle Cloud Infrastracture resources.
- **Service packages**: All packages except [Common](/Common), [Commontests](/Commontests), and [Examples](/Examples). These packages represent
  the Oracle Cloud Infrastructure services supported by the .NET SDK. Each package represents a service.
  These packages include the service client(s) with methods to interact with the service, classes for the requests,
  responses, and input and output parameters.

## Install Packages

The SDK is published as Nuget packages.

Use either dotnet CLI or Visual Studio to install and consume a package from [nuget.org](https://www.nuget.org/profiles/oci-dotnet-sdk).

- **dotnet CLI**:

```
dotnet add package <PACKAGE_ID> --version <VERSION> (If version not specified then it pulls the latest version)

Example:
dotnet add package OCI.DotNetSDK.Core
dotnet add package OCI.DotNetSDK.Identity
dotnet add package OCI.DotNetSDK.Identity -v 1.0.0
```

- **Visual Studio**:
  Right-click a project and select "Manage Nuget Packages" and then search for the package name and version number to install.

## Documentation

Public documentation and API Reference for the sdk can be found [here](https://docs.cloud.oracle.com/en-us/iaas/Content/API/SDKDocs/dotnetsdk.htm).

## Working with the .NET SDK

To start working with oci-dotnet-sdk, you need to create a .NET project, install packages, create a client, and then use that client to send requests to service endpoint.

### Configuring

Before using the SDK, set up a config file with the required credentials. See [SDK and Tool Configuration](https://docs.us-phoenix-1.oraclecloud.com/Content/API/Concepts/sdkconfig.htm) for instructions.

### Creating Client

To create a service client, you need to set up the client to use the credentials.
Check [here](https://docs.cloud.oracle.com/en-us/iaas/Content/API/SDKDocs/dotnetsdkgettingstarted.htm#configuring) on how to configure it.

Example that shows creating the Audit Service client using ConfigFileAuthenticationDetailsProvider Class for configuring credentials:

```
var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
var client = new AuditClient(provider, new ClientConfiguration());
```

### Sending Request

To send a request to an Oracle Cloud Infrastructure service endpoint, build a request object and send it using the client created above.

```
var listEventsRequest = new ListEventsRequest
{
    // Assumption: the compartment id has been set in environment variable.
    CompartmentId = compartmentId,
    StartTime = DateTime.Now.AddDays(-1),
    EndTime = DateTime.Now
};

try
{
    var response = await client.ListEvents(listEventsRequest);
}
catch (Exception e)
{
    // Handle the exception.
}
```

## Examples

Examples can be found [here](/Examples).

## Building and Testing

### Build

Building the SDK can be done at the root of the whole solution or at individual project level under it.
At the root level, to build the whole solution, run with dotnet cli command:

```
dotnet build
```

or use the included Makefile:

```
make build
```

The Makefile also provides an option to build individal projects from the root level:

```
make build PROJECT_PATH=Common
```

Alternatively, individual project and be built using dotnet cli inside project directory.

### Test

The common package has corresponding [unit tests](/Commontests).
These tests can be run using dotnet cli command or through Makefile.
To run the unit tests from the root, a test filter needs to be provided:

```
dotnet test --filter Category=Unit
```

Alternatively, running tests inside common_tests project does not require the filter.
To run tests using Makefile:

```
make unit-test
```

## Help

* The [Issues](https://github.com/oracle/oci-dotnet-sdk/issues) page of this GitHub repository.
* [Stack Overflow](https://stackoverflow.com/), use the [oracle-cloud-infrastructure](https://stackoverflow.com/questions/tagged/oracle-cloud-infrastructure) and [oci-dotnet-sdk](https://stackoverflow.com/questions/tagged/oci-dotnet-sdk) tags in your post.
* [Developer Tools](https://community.oracle.com/community/groundbreakers/oracle-cloud/cloud-infrastructure/content) section of the Oracle Cloud forums.
* [My Oracle Support](https://support.oracle.com/portal/).

## Contributing

`oci-dotnet-sdk` is an open source project. See [CONTRIBUTING](/CONTRIBUTING.md) for details.

Oracle gratefully acknowledges the contributions to oci-dotnet-sdk that have been made by the community.

## License

Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.

This SDK is dual licensed under the Universal Permissive License 1.0 and the Apache License 2.0.

See [LICENSE](/LICENSE.txt) for more details.

## Changes

See [CHANGELOG](/CHANGELOG.md)

## Known Issues

You can find information on any known issues with the SDK at [Oracle Cloud Infrastructure Known Issues](https://docs.cloud.oracle.com/en-us/iaas/Content/knownissues.htm) and under the [Issues](https://github.com/oracle/oci-dotnet-sdk/issues) tab of this project's GitHub repository.
