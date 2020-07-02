# Oracle Cloud Infrastructure SDK for .NET

## About

The oci-dotnet-sdk provides an SDK for .NET that you can use to manage your Oracle Cloud Infrastructure resources.

The project is open source and maintained by Oracle Corp.

## Dependencies

- .NETStandard 2.0

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

## Nuget Packages

The SDK is published as Nuget packages.

Use either dotnet CLI or Visual Studio to install and consume a package from nuget.org.

- **dotnet CLI**:

```
dotnet add package <PACKAGE_ID> --version <VERSION>
```

- **Visual Studio**:
  Right-click a project and select "Manage Nuget Packages" and then search for the package name and version number to install.

## Working with the .NET SDK

To start working with oci-dotnet-sdk, you need to create a .NET project, install packages, create a client, and then use that client to send requests to service endpoint.

### Configuring

Before using the SDK, set up a config file with the required credentials. See [SDK and Tool Configuration](https://docs.us-phoenix-1.oraclecloud.com/Content/API/Concepts/sdkconfig.htm) for instructions.

Note that currently the .NET SDK only support the default configuration file option.

### Creating Client

With the default confguration file, create a client:

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

//...
try
{
    var response = await client.ListEvents(request);
}
catch (Exception e)
{
    // Handle the exception.
}
```

## Examples

Some examples can be found [here](/Examples).

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

## License

Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.

This SDK is dual licensed under the Universal Permissive License 1.0 and the Apache License 2.0.

See [LICENSE](/LICENSE.txt) for more details.
