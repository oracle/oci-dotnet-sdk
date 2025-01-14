/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.DatabaseService;
using Oci.DatabaseService.Models;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    // This example demonstrates the following operations
    // * DbSystem creation and termination
    // * Subnet creation and deletion
    // * Vcn creation and deletion

    public class DatabaseExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        static async Task MainDatabase(string[] args)
        {

            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            string adminPassword = Environment.GetEnvironmentVariable("PASSWORD");

            logger.Info("Starting example");
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);

            var identityClient = new IdentityClient(provider);
            var virtualNetworkClient = new VirtualNetworkClient(provider);
            var databaseClient = new DatabaseClient(provider);
            var networkCidrBlock = "10.0.1.0/24";

            Vcn vcn = null;
            Subnet subnet = null;
            string dbSystemId = null;

            AvailabilityDomain availablityDomain = await getAvailabilityDomains(identityClient, compartmentId);
            logger.Info($"availability domain is {availablityDomain.Name}");

            try
            {
                vcn = await createVcn(virtualNetworkClient, compartmentId, networkCidrBlock);

                subnet = await createSubnet(virtualNetworkClient, compartmentId, availablityDomain, networkCidrBlock, vcn);

                logger.Info("Launching Database....");

                LaunchDbSystemDetails launchDbSystemDetails = new LaunchDbSystemDetails
                {
                    AvailabilityDomain = availablityDomain.Name,
                    CompartmentId = compartmentId,
                    CpuCoreCount = 4,
                    Shape = "BM.DenseIO2.52",
                    SshPublicKeys = new List<string> { "ssh-rsa AAAAB3NzaC1yc2EAAAABIwAAAQEAyyA8wePstPC69PeuHFtOwyTecByonsHFAjHbVnZ+h0dpomvLZxUtbknNj3+c7MPYKqKBOx9gUKV/diR/mIDqsb405MlrI1kmNR9zbFGYAAwIH/Gxt0Lv5ffwaqsz7cECHBbMojQGEz3IH3twEvDfF6cu5p00QfP0MSmEi/eB+W+h30NGdqLJCziLDlp409jAfXbQm/4Yx7apLvEmkaYSrb5f/pfvYv1FEV1tS8/J7DgdHUAWo6gyGUUSZJgsyHcuJT7v9Tf0xwiFWOWL9WsWXa9fCKqTeYnYJhHlqfinZRnT/+jkz0OZ7YmXo6j4Hyms3RCOqenIX1W6gnIn+eQIkw== This is the key's comment" },
                    SubnetId = subnet.Id,
                    DatabaseEdition = LaunchDbSystemDetails.DatabaseEditionEnum.EnterpriseEdition,
                    DisplayName = "OCI DotNet SDK database",
                    Hostname = "oci-dotnetsdk-host",
                    Domain = "testdomain",
                    DbHome = new CreateDbHomeDetails
                    {
                        DbVersion = "12.1.0.2",
                        DisplayName = "Example DB Home",
                        Database = new CreateDatabaseDetails
                        {
                            DbName = "dotnetdb",
                            AdminPassword = adminPassword
                        }
                    }
                };

                LaunchDbSystemRequest launchDbSystemRequest = new LaunchDbSystemRequest
                {
                    LaunchDbSystemDetails = launchDbSystemDetails
                };
                LaunchDbSystemResponse launchDbSystemResponse = await databaseClient.LaunchDbSystem(launchDbSystemRequest);

                logger.Info($"Database ID: {launchDbSystemResponse.DbSystem.Id} and Database display name: {launchDbSystemResponse.DbSystem.DisplayName}");
                logger.Info("Waiting for Database to come to available state....");

                GetDbSystemRequest getDbSystemRequest = new GetDbSystemRequest
                {
                    DbSystemId = launchDbSystemResponse.DbSystem.Id
                };
                WaiterConfiguration waiterConfiguration = new WaiterConfiguration
                {
                    MaxAttempts = 20,
                    GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
                };
                GetDbSystemResponse getDbSystemResponse = databaseClient.Waiters.ForDbSystem(
                    getDbSystemRequest, waiterConfiguration, DbSystem.LifecycleStateEnum.Available).Execute();

                logger.Info("Database is available");
                logger.Info($"Database ID: {getDbSystemResponse.DbSystem.Id} and Database display name: {getDbSystemResponse.DbSystem.DisplayName}");
                dbSystemId = getDbSystemResponse.DbSystem.Id;

            }
            catch (Exception e)
            {
                logger.Error($"failed to launch DbSystem: {e}");
            }
            finally
            {
                if (dbSystemId != null)
                {
                    await terminateDbSystem(databaseClient, dbSystemId);
                }

                if (subnet != null)
                {
                    await deleteSubnet(virtualNetworkClient, subnet);
                }

                if (vcn != null)
                {
                    await deleteVcn(virtualNetworkClient, vcn);
                }

                identityClient.Dispose();
                virtualNetworkClient.Dispose();
                databaseClient.Dispose();

                logger.Info("End example");
            }
        }

        private static async Task<AvailabilityDomain> getAvailabilityDomains(IdentityClient identityClient, string compartmentId)
        {
            ListAvailabilityDomainsRequest listAvailabilityDomainsRequest = new ListAvailabilityDomainsRequest
            {
                CompartmentId = compartmentId
            };
            ListAvailabilityDomainsResponse listAvailabilityDomainsResponse = await identityClient.ListAvailabilityDomains(listAvailabilityDomainsRequest);

            return listAvailabilityDomainsResponse.Items[0];
        }

        private static async Task<Vcn> createVcn(VirtualNetworkClient virtualNetworkClient, string compartmentId, string networkCidrBlock)
        {
            logger.Info("creating vcn");

            string vcnName = "oci-dotnet-sdk-vcn";
            CreateVcnDetails createVcnDetails = new CreateVcnDetails
            {
                CidrBlock = networkCidrBlock,
                CompartmentId = compartmentId,
                DisplayName = vcnName
            };
            CreateVcnRequest createVcnRequest = new CreateVcnRequest
            {
                CreateVcnDetails = createVcnDetails
            };
            CreateVcnResponse createVcnResponse = await virtualNetworkClient.CreateVcn(createVcnRequest);

            GetVcnRequest getVcnRequest = new GetVcnRequest
            {
                VcnId = createVcnResponse.Vcn.Id
            };
            GetVcnResponse getVcnResponse = virtualNetworkClient.Waiters.ForVcn(getVcnRequest, Vcn.LifecycleStateEnum.Available).Execute();
            Vcn vcn = getVcnResponse.Vcn;

            logger.Info($"Created vcn: {vcn.Id} and state is {vcn.LifecycleState}");
            return vcn;
        }

        private static async Task<Subnet> createSubnet(VirtualNetworkClient virtualNetworkClient, string compartmentId, AvailabilityDomain availabilityDomain, string networkCidrBlock, Vcn vcn)
        {
            string subnetName = "oci-dotnet-sdk-example-subnet";

            // In order to launch instances in a regional subnet, build this CreateSubnetDetails with
            // the field availablityDomain set to null.
            CreateSubnetDetails createSubnetDetails = new CreateSubnetDetails
            {
                AvailabilityDomain = availabilityDomain.Name,
                CompartmentId = compartmentId,
                DisplayName = subnetName,
                CidrBlock = networkCidrBlock,
                VcnId = vcn.Id,
                RouteTableId = vcn.DefaultRouteTableId
            };
            CreateSubnetRequest createSubnetRequest = new CreateSubnetRequest { CreateSubnetDetails = createSubnetDetails };
            CreateSubnetResponse createSubnetResponse = await virtualNetworkClient.CreateSubnet(createSubnetRequest);

            GetSubnetRequest getSubnetRequest = new GetSubnetRequest { SubnetId = createSubnetResponse.Subnet.Id };
            GetSubnetResponse getSubnetResponse = virtualNetworkClient.Waiters.ForSubnet(getSubnetRequest, Subnet.LifecycleStateEnum.Available).Execute();
            Subnet subnet = getSubnetResponse.Subnet;

            logger.Info($"Created Subnet: {subnet.Id}");
            return subnet;
        }

        private static async Task terminateDbSystem(DatabaseClient databaseClient, string dbSystemId)
        {
            try
            {
                logger.Info("Terminating the Database...");

                TerminateDbSystemRequest terminateDbSystemRequest = new TerminateDbSystemRequest
                {
                    DbSystemId = dbSystemId
                };
                await databaseClient.TerminateDbSystem(terminateDbSystemRequest);

                GetDbSystemRequest getDbSystemRequest = new GetDbSystemRequest
                {
                    DbSystemId = dbSystemId
                };
                WaiterConfiguration waiterConfiguration = new WaiterConfiguration
                {
                    MaxAttempts = 20,
                    GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
                };
                databaseClient.Waiters.ForDbSystem(getDbSystemRequest, waiterConfiguration, DbSystem.LifecycleStateEnum.Terminated).Execute();

                logger.Info("Database terminated");
            }
            catch (Exception e)
            {
                logger.Error($"failed to terminate DbSystem: {e}");
            }
        }

        private static async Task deleteSubnet(VirtualNetworkClient virtualNetworkClient, Subnet subnet)
        {
            DeleteSubnetRequest deleteSubnetRequest = new DeleteSubnetRequest
            {
                SubnetId = subnet.Id
            };
            await virtualNetworkClient.DeleteSubnet(deleteSubnetRequest);

            logger.Info($"Deleted Subnet: {subnet.Id}");
        }

        private static async Task deleteVcn(VirtualNetworkClient virtualNetworkClient, Vcn vcn)
        {
            DeleteVcnRequest deleteVcnRequest = new DeleteVcnRequest
            {
                VcnId = vcn.Id
            };
            await virtualNetworkClient.DeleteVcn(deleteVcnRequest);

            logger.Info($"Deleted Vcn: {vcn.Id}");
        }
    }
}
