# Running Examples

1. Use git to clone the OCI SDK for .NET repository:
```
git clone https://github.com/oracle/oci-dotnet-sdk.git
```
2. Create a configuration file in your home directory (`~/.oci/config`). See [SDK and Tool Configuration](https://docs.us-phoenix-1.oraclecloud.com/Content/API/Concepts/sdkconfig.htm) for more information.
3. Change directory into the .NET Examples folder. For example:
```
cd ./oci-dotnet-sdk/Examples/
```
4. All of the examples require the environment variable `OCI_COMPARTMENT_ID` populated with the tenant ID or compartment ID. More environment variables might be required depending on the example.
5. From the command line, run `dotnet run` . The Audit Example runs by default.
6. To run any other example, make sure it has a `Main()` function.
