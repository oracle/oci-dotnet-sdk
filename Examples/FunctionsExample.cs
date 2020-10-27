/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.FunctionsService;
using Oci.FunctionsService.Models;
using Oci.FunctionsService.Requests;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    /**
     * This is a basic example of how to register and invoke a serverless Function
     * on OCI using the .NET SDK.
     *
     * The example has some pre-requisites. In particular you will need to create a
     * Function image and publish it to OCI Registry. The best way to do this is with the 'Fn
     * CLI':
     *
     * 1. Install Fn CLI : https://github.com/fnproject/cli
     *
     * 2. Create Function - Quick Guide :
     * https://github.com/fnproject/fn/blob/master/README.md
     *
     * This sample will do following things:
     *
     * 1. Create VCN and subnets - Provide an endpoint on which your function can be
     * invoked.
     *
     * 2. Create Application and Function - Register and configure your function.
     *
     * 3. Invoke Function - How your function can be invoked.
     *
     * 4. Clean-up - Tidy up the resources created above.
     *
     * NB: To simplify things, this example is hardcoded to use the 'us-phoenix-1' OCI
     * region.
     *
     * NB: Currently, after invoking a function we must wait up to 30 minutes before
     * clearing down any supporting Subnets and VCN.
     *
     * @param environment variables to provide to the example. The following arguments are expected:
     * <ul>
     *   <li>The operation to perform: OPERATION - 'setup', 'invoke' or 'teardown'.</li>
     *   <li>The OCID of the compartment where the function and associated resources will be created: OCI_COMPARTMENT_ID</li>
     *   <li>A valid OCI Registry function image: IMAGE</li>
     *   <li>The payload to be sent to the function on invocation (optional): PAYLOAD</li>
     * </ul>
     */

    public class FunctionsExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static string Setup = "setup";
        private static string Invoke = "invoke";
        private static string TearDown = "teardown";

        private static string VcnCidrBlock = "10.0.0.0/16";
        private static string SubnetCidrBlock = "10.0.0.0/24";

        private static string PrefixName = "oci-dotnet-sdk-function-example";
        private static string SubnetName = $"{PrefixName}-subnet";
        private static string VcnName = $"{PrefixName}-vcn";
        private static string AppName = $"{PrefixName}-app";
        private static string FunctionName = $"{PrefixName}-function";
        private static string IgName = $"{PrefixName}-ig";
        private static string RouteTableName = $"{PrefixName}-routetable";

        public static async Task MainFunctions()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var command = Environment.GetEnvironmentVariable("OPERATION");
            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var image = Environment.GetEnvironmentVariable("IMAGE");
            var payload = Environment.GetEnvironmentVariable("PAYLOAD");

            try
            {
                if (command.Equals(Setup, StringComparison.OrdinalIgnoreCase))
                {
                    await SetUpResources(provider, compartmentId, image);
                }

                if (command.Equals(Invoke, StringComparison.OrdinalIgnoreCase))
                {
                    await InvokeFunction(provider, compartmentId, payload);
                }

                if (command.Equals(TearDown, StringComparison.OrdinalIgnoreCase))
                {
                    await TearDownResources(provider, compartmentId);
                }
            }
            catch (Exception e)
            {
                logger.Error($"command {command} failed: {e}");
            }
        }

        /**
        * Create all the OCI and Fn resources required to invoke a function.
        *
        * @param provider      the OCI credentials provider.
        * @param compartmentId the compartment in which to create the required
        *                      resources.
        * @param image         a valid OCI Registry image for the function.
        */
        private static async Task SetUpResources(IBasicAuthenticationDetailsProvider provider, string compartmentId, string image)
        {
            logger.Info("Setting up resources");

            var identityClient = new IdentityClient(provider);
            var vcnClient = new VirtualNetworkClient(provider);
            var fnManagementClient = new FunctionsManagementClient(provider);

            Vcn vcn = null;
            Subnet subnet = null;
            InternetGateway internetGateway = null;

            try
            {

                AvailabilityDomain availablityDomain = await GetAvailabilityDomain(identityClient, compartmentId);
                logger.Info($"availability domain is {availablityDomain.Name}");

                vcn = await CreateVcn(vcnClient, compartmentId);

                internetGateway = await CreateInternalGateway(vcnClient, compartmentId, vcn);
                await AddInternetGatewayToDefaultRouteTable(vcnClient, vcn.DefaultRouteTableId, internetGateway.Id);

                subnet = await CreateSubnet(vcnClient, compartmentId, availablityDomain.Name, vcn.Id);
                var subnetIds = new List<string>(){
                    subnet.Id
                };
                Application app = await CreateApplication(fnManagementClient, compartmentId, subnetIds);

                long memoryInMBs = 128L;
                int timeoutInSeconds = 30;
                Function fn = await CreateFunction(fnManagementClient, app.Id, image, memoryInMBs, timeoutInSeconds);

            }
            catch (Exception e)
            {
                logger.Error($"failed to setup resources: {e}");
            }
            finally
            {
                fnManagementClient.Dispose();
                vcnClient.Dispose();
                identityClient.Dispose();
            }
        }

        /**
        * Invoke a function.
        *
        * @param provider      the OCI credentials provider.
        * @param compartmentId the compartment in which to created the required
        *                      resources.
        * @param payload       the payload to be sent to the function on invocation.
        */
        private static async Task InvokeFunction(IBasicAuthenticationDetailsProvider provider, string compartmentId, string payload)
        {
            var fnManagementClient = new FunctionsManagementClient(provider);
            var fnInvokeClient = new FunctionsInvokeClient(provider);

            try
            {
                // Invoke the function
                var fn = await GetUniqueFunctionByName(fnManagementClient, compartmentId);
                var response = await InvokeFunction(fnInvokeClient, fn, payload);
                if (response != null)
                {
                    logger.Info($"Response from function: {response}");
                }
            }
            catch (Exception e)
            {
                logger.Error($"Failed to invoke function: {e}");
            }
            finally
            {
                fnInvokeClient.Dispose();
                fnManagementClient.Dispose();
            }
        }

        /**
        * Invokes a function.
        *
        * @param fnInvokeClient the service client to use to delete the Function.
        * @param function the Function to invoke.
        * @param payload the payload to pass to the function.
        */
        private static async Task<string> InvokeFunction(FunctionsInvokeClient fnInvokeClient, FunctionSummary function, string payload)
        {
            string response = null;
            try
            {
                logger.Info($"Invoking function endpoint: {function.InvokeEndpoint}");

                // Configure the client to use the assigned function endpoint.
                fnInvokeClient.SetEndpoint(function.InvokeEndpoint);
                var invokeFunctionRequest = new InvokeFunctionRequest
                {
                    FunctionId = function.Id,
                    InvokeFunctionBody = GenerateStreamFromString(payload)
                };

                // Invoke the function
                var invokeFunctionResponse = await fnInvokeClient.InvokeFunction(invokeFunctionRequest);

                // Handle the response
                response = new StreamReader(invokeFunctionResponse.InputStream).ReadToEnd();
            }
            catch (Exception e)
            {
                logger.Error($"Failed to invoke function: {e}");
            }

            return response;
        }

        /**
        * Remove all resources created by the 'setup' operation.
        *
        * NB: Resources can only be removed 30 minutes after the last Function
        * invocation.
        *
        * @param provider      the OCI credentials provider.
        * @param region        the OCI region in which to create the required
        *                      resources.
        * @param compartmentId the compartment in which to created the required
        *                      resources.
        * @param name          a name prefix to easily identify the resources.
        */
        private static async Task TearDownResources(IBasicAuthenticationDetailsProvider provider, string compartmentId)
        {
            var identityClient = new IdentityClient(provider);
            var vcnClient = new VirtualNetworkClient(provider);
            var fnManagementClient = new FunctionsManagementClient(provider);

            try
            {
                logger.Info("Cleaning up....");

                var vcn = await GetUniqueVcnByName(vcnClient, compartmentId);
                var ig = await GetUniqueInternetGatewayByName(vcnClient, compartmentId, vcn.Id);
                var rt = await GetUniqueRouteTableByName(vcnClient, compartmentId, vcn.Id);
                var subnet = await GetUniqueSubnetByName(vcnClient, compartmentId, vcn.Id);
                var application = await GetUniqueApplicationByName(fnManagementClient, compartmentId);
                var fn = await GetUniqueFunctionByName(fnManagementClient, application.Id, FunctionName);

                if (fn != null)
                {
                    await DeleteFunction(fnManagementClient, fn.Id);
                }

                if (application != null)
                {
                    await DeleteApplication(fnManagementClient, application.Id);
                }

                if (ig != null)
                {
                    await ClearRouteRulesFromDefaultRouteTable(vcnClient, vcn.DefaultRouteTableId);
                    await DeleteInternetGateway(vcnClient, ig.Id);
                }

                if (subnet != null)
                {
                    await DeleteSubnet(vcnClient, subnet);
                }

                if (vcn != null)
                {
                    await DeleteVcn(vcnClient, vcn);
                }
            }
            catch (Exception e)
            {
                logger.Error($"Failed to clean the resources: {e}");
            }
            finally
            {
                fnManagementClient.Dispose();
                vcnClient.Dispose();
                identityClient.Dispose();
            }
        }

        /**
        * Gets the first availability domain from the list.
        *
        * @param identityClient the service client to use to fetch the
        *                       AvailabilityDomains.
        * @param compartmentId  the OCID of the compartment to check.
        * @return the first availability domain.
        */
        private static async Task<AvailabilityDomain> GetAvailabilityDomain(IdentityClient identityClient, string compartmentId)
        {
            ListAvailabilityDomainsRequest listAvailabilityDomainsRequest = new ListAvailabilityDomainsRequest
            {
                CompartmentId = compartmentId
            };
            ListAvailabilityDomainsResponse listAvailabilityDomainsResponse = await identityClient.ListAvailabilityDomains(listAvailabilityDomainsRequest);

            return listAvailabilityDomainsResponse.Items[0];
        }

        /**
        * Creates a VCN and waits for it to become available to use.
        *
        * @param vcnClient          the service client to use to create the VCN.
        * @param compartmentId      the OCID of the compartment where the VCN will be
        *                           created.
        * @return the created VCN.
        */
        private static async Task<Vcn> CreateVcn(VirtualNetworkClient vcnClient, string compartmentId)
        {
            logger.Info("creating vcn");

            CreateVcnDetails createVcnDetails = new CreateVcnDetails
            {
                CidrBlock = VcnCidrBlock,
                CompartmentId = compartmentId,
                DisplayName = VcnName
            };
            CreateVcnRequest createVcnRequest = new CreateVcnRequest
            {
                CreateVcnDetails = createVcnDetails
            };
            CreateVcnResponse createVcnResponse = await vcnClient.CreateVcn(createVcnRequest);

            GetVcnRequest getVcnRequest = new GetVcnRequest
            {
                VcnId = createVcnResponse.Vcn.Id
            };
            GetVcnResponse getVcnResponse = vcnClient.Waiters.ForVcn(getVcnRequest, Vcn.LifecycleStateEnum.Available).Execute();
            Vcn vcn = getVcnResponse.Vcn;

            logger.Info($"Created vcn: {vcn.Id} and state is {vcn.LifecycleState}");
            return vcn;
        }

        private static async Task<InternetGateway> CreateInternalGateway(VirtualNetworkClient vcnClient, string compartmentId, Vcn vcn)
        {

            CreateInternetGatewayDetails createInternetGatewayDetails = new CreateInternetGatewayDetails
            {
                CompartmentId = compartmentId,
                DisplayName = IgName,
                IsEnabled = true,
                VcnId = vcn.Id
            };
            CreateInternetGatewayRequest createInternetGatewayRequest = new CreateInternetGatewayRequest { CreateInternetGatewayDetails = createInternetGatewayDetails };
            CreateInternetGatewayResponse createInternetGatewayResponse = await vcnClient.CreateInternetGateway(createInternetGatewayRequest);

            GetInternetGatewayRequest getInternetGatewayRequest = new GetInternetGatewayRequest { IgId = createInternetGatewayResponse.InternetGateway.Id };
            GetInternetGatewayResponse getInternetGatewayResponse = vcnClient.Waiters.ForInternetGateway(getInternetGatewayRequest, InternetGateway.LifecycleStateEnum.Available).Execute();
            InternetGateway internetGateway = getInternetGatewayResponse.InternetGateway;

            logger.Info($"Created internet gateway: {internetGateway.Id} and state is {internetGateway.LifecycleState}");
            return internetGateway;
        }

        /**
        * Configure the default RouteTable of the specified InternetGateway to ensure it
        * contains a single outbound route for all traffic.
        *
        * NB: You should restrict these routes further if you keep this piece of
        *     OCI infrastructure.
        *
        * @param vcnClient      the service client to use to query a RouteTable.
        * @param routeTableId   of the default route table associated with the VCN.
        * @param igId           of the RouteTable's associated InternetGateway.
        */
        private static async Task AddInternetGatewayToDefaultRouteTable(VirtualNetworkClient vcnClient, string routeTableId, string igId)
        {
            GetRouteTableRequest getRouteTableRequest = new GetRouteTableRequest
            {
                RtId = routeTableId
            };
            GetRouteTableResponse getRouteTableResponse = await vcnClient.GetRouteTable(getRouteTableRequest);
            var routeRules = getRouteTableResponse.RouteTable.RouteRules;

            logger.Info("Current Route Rules in Default Route Table");
            logger.Info("==========================================");
            routeRules.ForEach(delegate (RouteRule rule)
            {
                logger.Info($"rule: {rule.NetworkEntityId}");
            });

            RouteRule internetAccessRoute = new RouteRule
            {
                Destination = "0.0.0.0/0",
                DestinationType = RouteRule.DestinationTypeEnum.CidrBlock,
                NetworkEntityId = igId
            };
            routeRules.Add(internetAccessRoute);
            UpdateRouteTableDetails updateRouteTableDetails = new UpdateRouteTableDetails
            {
                RouteRules = routeRules,
                DisplayName = RouteTableName
            };
            UpdateRouteTableRequest updateRouteTableRequest = new UpdateRouteTableRequest
            {
                UpdateRouteTableDetails = updateRouteTableDetails,
                RtId = routeTableId
            };
            UpdateRouteTableResponse updateRouteTableResponse = await vcnClient.UpdateRouteTable(updateRouteTableRequest);

            getRouteTableResponse = vcnClient.Waiters.ForRouteTable(getRouteTableRequest, RouteTable.LifecycleStateEnum.Available).Execute();
            routeRules = getRouteTableResponse.RouteTable.RouteRules;

            logger.Info("Updated Route Rules in Default Route Table");
            logger.Info("==========================================");
            routeRules.ForEach(delegate (RouteRule rule)
            {
                logger.Info($"rule: {rule.NetworkEntityId}\n");
            });
        }

        /**
        * Creates a subnet in a VCN and waits for the subnet to become available to use.
        *
        * @param vcnClient the service client to use to create the subnet.
        * @param compartmentId the OCID of the compartment which owns the VCN.
        * @param vcnId the ID of the VCN which will own the subnet.
        * @param availabilityDomain the availability domain where the subnet will be created.
        * @return the created subnet.
        */
        private static async Task<Subnet> CreateSubnet(VirtualNetworkClient vcnClient, string compartmentId, string availabilityDomain, string vcnId)
        {
            logger.Info("Creating subnet");

            CreateSubnetDetails createSubnetDetails = new CreateSubnetDetails
            {
                AvailabilityDomain = availabilityDomain,
                CompartmentId = compartmentId,
                DisplayName = SubnetName,
                CidrBlock = SubnetCidrBlock,
                VcnId = vcnId
            };
            CreateSubnetRequest createSubnetRequest = new CreateSubnetRequest { CreateSubnetDetails = createSubnetDetails };
            CreateSubnetResponse createSubnetResponse = await vcnClient.CreateSubnet(createSubnetRequest);

            GetSubnetRequest getSubnetRequest = new GetSubnetRequest { SubnetId = createSubnetResponse.Subnet.Id };
            GetSubnetResponse getSubnetResponse = vcnClient.Waiters.ForSubnet(getSubnetRequest, Subnet.LifecycleStateEnum.Available).Execute();
            Subnet subnet = getSubnetResponse.Subnet;

            logger.Info($"Created Subnet: {subnet.Id}");
            return subnet;
        }

        /**
        * Creates an Application and waits for it to become available to use.
        *
        * @param fnManagementClient the service client to use to create the application.
        * @param compartmentId the OCID of the compartment which owns the Application.
        * @param displayName the display name of the created Application.
        * @param subnetIds a List of subnets (in different ADs) that will expose the function.
        * @return the created application.
        */
        private static async Task<Application> CreateApplication(FunctionsManagementClient fnManagementClient,
            string compartmentId, List<string> subnetIds)
        {
            logger.Info("Creating application");
            // Create a new Application
            var createApplicationDetails = new CreateApplicationDetails
            {
                CompartmentId = compartmentId,
                DisplayName = AppName,
                SubnetIds = subnetIds
            };
            var createApplicationRequest = new CreateApplicationRequest
            {
                CreateApplicationDetails = createApplicationDetails
            };
            var createApplicationResponse = await fnManagementClient.CreateApplication(createApplicationRequest);

            logger.Info("Waiting for application to become Active");
            var getApplicationRequest = new GetApplicationRequest
            {
                ApplicationId = createApplicationResponse.Application.Id
            };
            var getApplicationResponse = fnManagementClient.Waiters.ForApplication(getApplicationRequest, Application.LifecycleStateEnum.Active).Execute();
            logger.Info($"Application: {getApplicationResponse.Application.DisplayName} is Active");

            return getApplicationResponse.Application;
        }

        /**
        * Creates a Function and waits for the it to become available to use.
        *
        * @param fnManagementClient the service client to use to create the Application.
        * @param applicationId the OCID of the Application which owns the Function.
        * @param displayName the display name of created Function.
        * @param image an accessible OCI Registry image implementing the function to be executed.
        * @param memoryInMBs the maximum amount of memory available (128, 256, 512, 1024) to the function in MB.
        * @param timeoutInSeconds the maximum amount of time a function can execute (30 - 120) in seconds.
        * @return the created Function.
        */
        private static async Task<Function> CreateFunction(FunctionsManagementClient fnManagementClient, string applicationId, string image, long memoryInMBs, int timeoutInSeconds)
        {
            logger.Info("Creating function");

            // Create a new function
            var createFunctionDetails = new CreateFunctionDetails
            {
                ApplicationId = applicationId,
                DisplayName = FunctionName,
                Image = image,
                MemoryInMBs = memoryInMBs,
                TimeoutInSeconds = timeoutInSeconds
            };
            var createFunctionRequest = new CreateFunctionRequest
            {
                CreateFunctionDetails = createFunctionDetails
            };
            var createFunctionResponse = await fnManagementClient.CreateFunction(createFunctionRequest);

            logger.Info("Waiting for Function to be in Active state");
            var getFunctionRequest = new GetFunctionRequest
            {
                FunctionId = createFunctionResponse.Function.Id
            };
            var getFunctionResponse = fnManagementClient.Waiters.ForFunction(getFunctionRequest, Function.LifecycleStateEnum.Active).Execute();
            logger.Info($"Function: {FunctionName} is Active");

            return getFunctionResponse.Function;
        }

        /**
        * Gets Function information. This is an expensive operation and the results should be cached.
        *
        * @param fnManagementClient the service client to use to get the Function information.
        * @param compartmentId of the application and function.
        * @return the FunctionSummary.
        */
        private static async Task<FunctionSummary> GetUniqueFunctionByName(FunctionsManagementClient fnManagementClient, string compartmentId)
        {
            var application = await GetUniqueApplicationByName(fnManagementClient, compartmentId);

            return await GetUniqueFunctionByName(fnManagementClient, application.Id, FunctionName);
        }

        /**
        * Gets Function information. This is an expensive operation and the results should be cached.
        *
        * @param fnManagementClient the service client to use to get the Function information.
        * @param applicationId of the application.
        * @param functionDisplayName the function name to search for.
        * @return the FunctionSummary.
        */
        private static async Task<FunctionSummary> GetUniqueFunctionByName(FunctionsManagementClient fnManagementClient, string applicationId, string functionDisplayName)
        {

            var listFunctionsRequest = new ListFunctionsRequest
            {
                ApplicationId = applicationId,
                DisplayName = functionDisplayName
            };
            var listFunctionsResponse = await fnManagementClient.ListFunctions(listFunctionsRequest);

            if (listFunctionsResponse.Items.Count != 1)
            {
                logger.Error($"Could not find function with name: {functionDisplayName} in application: {applicationId}");
                return null;
            }

            return listFunctionsResponse.Items[0];
        }

        /**
        * Gets the Application info of a single uniquely named Application in the specified compartment.
        *
        * @param fnManagementClient the service client to use to get the Application information.
        * @param compartmentId of the application.
        * @param applicationDisplayName of the application.
        * @return the ApplicationSummary.
        */
        private static async Task<ApplicationSummary> GetUniqueApplicationByName(FunctionsManagementClient fnManagementClient, string compartmentId)
        {
            var listApplicationRequest = new ListApplicationsRequest
            {
                DisplayName = AppName,
                CompartmentId = compartmentId
            };
            var listApplicationResponse = await fnManagementClient.ListApplications(listApplicationRequest);

            if (listApplicationResponse.Items.Count != 1)
            {
                logger.Error($"Could not find unique application with name: {AppName} in compartment: {compartmentId}");
                return null;
            }

            return listApplicationResponse.Items[0];
        }

        /**
        * Gets VCN info of a single uniquely named VCN in the specified compartment.
        *
        * @param vcnClient      the service client to use to query the VCN.
        * @param compartmentId  of the VCN.
        * @param vcnDisplayName of the VCN.
        * @return               the VCN.
        */
        private static async Task<Vcn> GetUniqueVcnByName(VirtualNetworkClient vcnClient, string compartmentId)
        {
            // Find the Vcn in a specific compartment
            var listVcnsRequest = new ListVcnsRequest
            {
                CompartmentId = compartmentId,
                DisplayName = VcnName
            };
            var listVcnsResponse = await vcnClient.ListVcns(listVcnsRequest);

            if (listVcnsResponse.Items.Count != 1)
            {
                logger.Error($"Could not find unique VCN with name: {VcnName} in compartment: {compartmentId}");
                return null;
            }

            return listVcnsResponse.Items[0];
        }

        /**
        * Gets InternetGateway info of a single uniquely named InternetGateway in the
        * specified compartment.
        *
        * @param vcnClient     the service client to use to query the InternetGateway.
        * @param compartmentId of the InternetGateway.
        * @param vcnId         of the InternetGateway's associated VCN.
        * @return the InternetGateway.
        */
        private static async Task<InternetGateway> GetUniqueInternetGatewayByName(VirtualNetworkClient vcnClient, string compartmentId, string vcnId)
        {
            // Find the Internet gateway in a specific compartment
            var listInternetGatewaysRequest = new ListInternetGatewaysRequest
            {
                CompartmentId = compartmentId,
                VcnId = vcnId,
                DisplayName = IgName
            };
            var listInternetGatewaysResponse = await vcnClient.ListInternetGateways(listInternetGatewaysRequest);

            if (listInternetGatewaysResponse.Items.Count != 1)
            {
                logger.Error($"Could not find unique InternetGateway with name: {IgName} in compartment: {compartmentId}");
                return null;
            }

            return listInternetGatewaysResponse.Items[0];
        }

        /**
        * Gets RouteTable info of a single uniquely named RouteTable in the
        * specified compartment.
        *
        * @param vcnClient     the service client to use to query a RouteTable.
        * @param compartmentId of the RouteTable.
        * @param vcnId         of the RouteTable's associated VCN.
        * @return the InternetGateway.
        */
        private static async Task<RouteTable> GetUniqueRouteTableByName(VirtualNetworkClient vcnClient, string compartmentId, string vcnId)
        {
            // Find the route table in a specific compartment
            var listRouteTablesRequest = new ListRouteTablesRequest
            {
                CompartmentId = compartmentId,
                VcnId = vcnId,
                DisplayName = RouteTableName
            };
            var listRouteTablesResponse = await vcnClient.ListRouteTables(listRouteTablesRequest);

            if (listRouteTablesResponse.Items.Count != 1)
            {
                logger.Error($"Could not find unique RouteTable with name: {RouteTableName} in compartment: {compartmentId}");
                return null;
            }

            return listRouteTablesResponse.Items[0];
        }

        /**
        * Gets Subnet info of a single uniquely named Subnet in the specified compartment.
        *
        * @param vcnClient the service client to use to query the Subnet.
        * @param compartmentId of the Subnet.
        * @param vcnId of the Subnet.
        * @return the Subnet.
        */
        private static async Task<Subnet> GetUniqueSubnetByName(VirtualNetworkClient vcnClient, string compartmentId, string vcnId)
        {
            // Find the Subnet in a specific comparment
            var listSubnetsRequest = new ListSubnetsRequest
            {
                CompartmentId = compartmentId,
                VcnId = vcnId,
                DisplayName = SubnetName
            };
            var listSubnetsResponse = await vcnClient.ListSubnets(listSubnetsRequest);

            if (listSubnetsResponse.Items.Count != 1)
            {
                logger.Error($"Could not find unique subnet with name: {SubnetName} in compartment: {compartmentId}");
                return null;
            }

            return listSubnetsResponse.Items[0];
        }

        /**
        * Deletes a Function and waits for it to be deleted.
        *
        * @param fnManagementClient the service client to use to delete the Function.
        * @param functionId the Function to delete.
        */
        private static async Task DeleteFunction(FunctionsManagementClient fnManagementClient, string functionId)
        {
            // Delete the specified function
            var deleteFunctionRequest = new DeleteFunctionRequest
            {
                FunctionId = functionId
            };
            await fnManagementClient.DeleteFunction(deleteFunctionRequest);

            logger.Info($"Function deleted: {FunctionName}");
        }

        /**
        * Deletes an Application and waits for it to be deleted.
        *
        * @param fnManagementClient the service client to use to delete the Application.
        * @param applicationId the Application to delete.
        */
        private static async Task DeleteApplication(FunctionsManagementClient fnManagementClient, string applicationId)
        {
            // Delete the specified Application
            var deleteApplicationRequest = new DeleteApplicationRequest
            {
                ApplicationId = applicationId
            };
            await fnManagementClient.DeleteApplication(deleteApplicationRequest);

            logger.Info($"Application deleted: {AppName}");
        }

        /**
        * Clear the Route rule in a Route Table
        *
        * @param vcnClient the service client to use to clear the route rule
        * @param routeTableId the Route Table to clear from.
        */
        private static async Task ClearRouteRulesFromDefaultRouteTable(VirtualNetworkClient vcnClient, string routeTableId)
        {
            List<RouteRule> routeRules = new List<RouteRule>();
            UpdateRouteTableDetails updateRouteTableDetails = new UpdateRouteTableDetails { RouteRules = routeRules };
            UpdateRouteTableRequest updateRouteTableRequest = new UpdateRouteTableRequest
            {
                UpdateRouteTableDetails = updateRouteTableDetails,
                RtId = routeTableId
            };
            await vcnClient.UpdateRouteTable(updateRouteTableRequest);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };

            GetRouteTableRequest getRouteTableRequest = new GetRouteTableRequest
            {
                RtId = routeTableId
            };
            vcnClient.Waiters.ForRouteTable(getRouteTableRequest, waiterConfiguration, RouteTable.LifecycleStateEnum.Available).Execute();

            logger.Info($"Cleared route rules from route table: {routeTableId}");
        }

        /**
        * Deletes a InternetGateway and waits for it to be deleted.
        *
        * @param vcnClient the service client to use to delete the InternetGateway.
        * @param igId      the InternetGateway to delete.
        */
        private static async Task DeleteInternetGateway(VirtualNetworkClient vcnClient, string igId)
        {
            DeleteInternetGatewayRequest deleteInternetGatewayRequest = new DeleteInternetGatewayRequest
            {
                IgId = igId
            };
            await vcnClient.DeleteInternetGateway(deleteInternetGatewayRequest);

            logger.Info($"Deleted Internet Gateway: {igId}");
        }

        /**
        * Deletes a subnet and waits for it to be deleted.
        *
        * @param vcnClient the service client to use to delete the subnet.
        * @param subnetId the subnet to delete.
        */
        private static async Task DeleteSubnet(VirtualNetworkClient vcnClient, Subnet subnet)
        {
            DeleteSubnetRequest deleteSubnetRequest = new DeleteSubnetRequest
            {
                SubnetId = subnet.Id
            };
            await vcnClient.DeleteSubnet(deleteSubnetRequest);

            logger.Info($"Deleted Subnet: {subnet.Id}");
        }

        /**
        * Deletes a VCN and waits for it to be deleted.
        *
        * @param vcnClient the service client to use to delete the VCN.
        * @param vcn       the VCN to delete.
        */
        private static async Task DeleteVcn(VirtualNetworkClient vcnClient, Vcn vcn)
        {
            DeleteVcnRequest deleteVcnRequest = new DeleteVcnRequest { VcnId = vcn.Id };
            await vcnClient.DeleteVcn(deleteVcnRequest);

            logger.Info($"Deleted Vcn: {vcn.Id}");
        }

        /**
        * Generates a stream from a string
        *
        * @param inputString the string to convert to stream
        */
        private static Stream GenerateStreamFromString(string inputString)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(inputString);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
