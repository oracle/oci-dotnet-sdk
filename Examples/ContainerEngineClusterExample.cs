/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.ContainerengineService;
using Oci.ContainerengineService.Models;
using Oci.ContainerengineService.Requests;
using Oci.ContainerengineService.Responses;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.IdentityService;
using IdentityModels = Oci.IdentityService.Models;
using IdentityRequests = Oci.IdentityService.Requests;
using IdentityResponses = Oci.IdentityService.Responses;

namespace Oci.Examples
{
    /**
    * This class provides an example of how to create a Container Engine Cluster in the .NET SDK.
    * It will create a VCN and two subnets, one Container Engine cluster.
    * These will be deleted at the end. The class also makes some assumptions about
    * the resources it will create:
    *
    * <ul>:
    *   <li>The VCN created by this example will have a display name of oci_dotnet_sdk_example_vcn</li>
    *   <li>The subnet created by this example will have a display name of: oci_dotnet_sdk_example_subnet_1</li>
    *   <li>The subnet created by this example will have a display name of: oci_dotnet_sdk_example_subnet_2</li>
    *   <li>The VCN will have a private IP CIDR block of 10.0.0.0/16</li>
    *   <li>The subnets will have private IP CIDR blocks of 10.0.0.0/24 and 10.0.1.0/24</li>
    *   <li>The cluster created will have hardcoded display names of ContanerEngineClusterExample</li>
    *   <li>
    *      The configuration file used by service clients will be sourced from the default
    *      location (~/.oci/config) and the DEFAULT profile will be used
    *   </li>
    *   <li>Resources will be created in us-phoenix-1</li>
    *   <li>Resources will be created in the first AD returned from the ListAvailabilityDomains call</li>
    * <ul>
    */

    public class ContainerEngineClusterExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static string VcnDisplayName = "oci_dotnet_sdk_example_vcn";
        private static string[] SubnetDisplayNames = {
            "oci_dotnet_sdk_example_subnet_1", "oci_dotnet_sdk_example_subnet_2"
        };
        private static string CidrBlock = "10.0.0.0/16";
        private static string[] SubnetCidrBlocks = {
            "10.0.0.0/24", "10.0.1.0/24"
        };
        private static string ClusterDisplayName = "ContanerEngineClusterExample";
        private static string ClusterNewDisplayName = "ContanerEngineClusterExampleNew";

        public static async Task MainContainerEngine(string[] args)
        {
            logger.Info("Starting example");

            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);

            var containerEngineClient = new ContainerEngineClient(provider);
            var vcnClient = new VirtualNetworkClient(provider);
            var identityClient = new IdentityClient(provider);

            Vcn vcn = null;
            List<Subnet> subnets = null;

            Cluster cluster = null;

            try
            {

                IdentityModels.AvailabilityDomain availablityDomain = await GetAvailabilityDomain(identityClient, compartmentId);
                logger.Info($"availability domain is {availablityDomain.Name}");

                vcn = await CreateVcn(vcnClient, compartmentId);

                subnets = await CreateSubnet(vcnClient, compartmentId, availablityDomain, vcn.Id);

                //Create a Container Engine Cluster
                List<string> subnetIds = new List<string>();
                foreach (Subnet subnet in subnets)
                {
                    subnetIds.Add(subnet.Id);
                }

                var kubernetesVersion = await GetKubernetesVersion(containerEngineClient);

                cluster = await CreateCluster(containerEngineClient, vcn.Id, subnetIds, kubernetesVersion, compartmentId);

                // Update the container engine cluster
                await UpdateCluster(containerEngineClient, cluster.Id, ClusterNewDisplayName);

            }
            catch (Exception e)
            {
                logger.Error($"Failed to create container engine cluster: {e}");
            }
            finally
            {

                logger.Info("Cleaning up...");

                if (cluster != null)
                {
                    await DeleteCluster(containerEngineClient, cluster.Id);
                }

                for (int i = 0; i < 2; i++)
                {
                    if (subnets[i] != null)
                    {
                        await DeleteSubnet(vcnClient, subnets[i]);
                    }
                }

                if (vcn != null)
                {
                    await DeleteVcn(vcnClient, vcn);
                }

                containerEngineClient.Dispose();
                vcnClient.Dispose();
                identityClient.Dispose();
            }
            logger.Info("End example");
        }

        /**
        * Retrieves a list of availability domains in a compartment.
        *
        * @param identityClient the client to use to retrieve the availability domains
        * @param compartmentId the OCID of the compartment whose availability domains we're listing
        *
        * @return first one in the list of availability domains
        */
        private static async Task<IdentityModels.AvailabilityDomain> GetAvailabilityDomain(IdentityClient identityClient, string compartmentId)
        {
            IdentityRequests.ListAvailabilityDomainsRequest listAvailabilityDomainsRequest = new IdentityRequests.ListAvailabilityDomainsRequest
            {
                CompartmentId = compartmentId
            };
            IdentityResponses.ListAvailabilityDomainsResponse listAvailabilityDomainsResponse = await identityClient.ListAvailabilityDomains(listAvailabilityDomainsRequest);

            return listAvailabilityDomainsResponse.Items[0];
        }

        /**
        * Creates a VCN and waits for it to become available to use.
        *
        * @param vcnClient the service client to use to create the VCN
        * @param compartmentId the OCID of the compartment where the VCN will be created
        *
        * @return the created VCN
        */
        private static async Task<Vcn> CreateVcn(VirtualNetworkClient virtualNetworkClient, string compartmentId)
        {
            logger.Info("creating vcn");

            CreateVcnDetails createVcnDetails = new CreateVcnDetails
            {
                CidrBlock = CidrBlock,
                CompartmentId = compartmentId,
                DisplayName = VcnDisplayName
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

        /**
        * Creates subnets in a VCN and waits for the subnets to become available to use.
        *
        * @param vcnClient the service client to use to create the subnet
        * @param compartmentId the OCID of the compartment which owns the VCN
        * @param availabilityDomain the availability domain where the subnet will be created
        * @param cidrBlock the cidr block used to create subnet
        * @param vcnId the ID of the VCN which will own the subnet
        * @param subnetName the subnet that will be created
        *
        * @return the created subnets
        *
        */
        private static async Task<List<Subnet>> CreateSubnet(VirtualNetworkClient virtualNetworkClient, string compartmentId, IdentityModels.AvailabilityDomain availabilityDomain, string vcnId)
        {
            List<Subnet> subnets = new List<Subnet>();
            for (int i = 0; i < 2; i++)
            {

                CreateSubnetDetails createSubnetDetails = new CreateSubnetDetails
                {
                    AvailabilityDomain = availabilityDomain.Name,
                    CompartmentId = compartmentId,
                    DisplayName = SubnetDisplayNames[i],
                    CidrBlock = SubnetCidrBlocks[i],
                    VcnId = vcnId
                };
                CreateSubnetRequest createSubnetRequest = new CreateSubnetRequest { CreateSubnetDetails = createSubnetDetails };
                CreateSubnetResponse createSubnetResponse = await virtualNetworkClient.CreateSubnet(createSubnetRequest);

                GetSubnetRequest getSubnetRequest = new GetSubnetRequest { SubnetId = createSubnetResponse.Subnet.Id };
                GetSubnetResponse getSubnetResponse = virtualNetworkClient.Waiters.ForSubnet(getSubnetRequest, Subnet.LifecycleStateEnum.Available).Execute();
                Subnet subnet = getSubnetResponse.Subnet;

                logger.Info($"Created Subnet: {subnet.Id}");
                subnets.Add(getSubnetResponse.Subnet);

            }
            return subnets;
        }

        /**
        * Retrieve a list of Kubernetes versions
        *
        * @param containerEngineClient the service client to use to retrieve Kubernetes versions
        *
        * @return the first one in the list of Kubernetes versions
        *
        */
        private static async Task<string> GetKubernetesVersion(ContainerEngineClient containerEngineClient)
        {

            GetClusterOptionsRequest getRequest = new GetClusterOptionsRequest
            {
                ClusterOptionId = "all"
            };
            GetClusterOptionsResponse getResponse = await containerEngineClient.GetClusterOptions(getRequest);
            string kubernetesVersion = getResponse.ClusterOptions.KubernetesVersions[0];

            logger.Info($"Kubernetes version: {kubernetesVersion}");
            return kubernetesVersion;
        }

        /**
        * Creates a Cluster and waits for it to become active
        *
        * @param containerEngineClient the containerEngineclient used to create the cluster
        * @param vcnId the ID of the VCN which will own the subnets
        * @param subnetIds list of subnet ids
        * @param kubernetesVersion kubernetesVersion
        * @param compartmentId
        *
        * @return the created cluster
        */
        private static async Task<Cluster> CreateCluster(
            ContainerEngineClient containerEngineClient, string vcnId, List<string> subnetIds,
            string kubernetesVersion, string compartmentId)
        {

            logger.Info("Creating Cluster.......");

            CreateClusterDetails createClusterDetails = new CreateClusterDetails
            {
                Name = ClusterDisplayName,
                CompartmentId = compartmentId,
                VcnId = vcnId,
                KubernetesVersion = kubernetesVersion,
                Options = new ClusterCreateOptions
                {
                    ServiceLbSubnetIds = subnetIds
                }
            };
            CreateClusterRequest createClusterRequest = new CreateClusterRequest
            {
                CreateClusterDetails = createClusterDetails
            };
            CreateClusterResponse clusterResponse = await containerEngineClient.CreateCluster(createClusterRequest);

            string workRequestId = clusterResponse.OpcWorkRequestId;
            logger.Info($"cluster work request ID is {workRequestId}");

            GetWorkRequestResponse workRequestResponse = WaitForWorkRequestFinished(containerEngineClient, workRequestId);

            var clusterId = GetClusterId(workRequestResponse);
            logger.Info($"cluster ID is {clusterId}");

            GetClusterRequest getClusterRequest = new GetClusterRequest
            {
                ClusterId = clusterId
            };
            GetClusterResponse getClusterResponse = await containerEngineClient.GetCluster(getClusterRequest);

            return getClusterResponse.Cluster;
        }

        /**
        * Update a cluster and waits for it to become active
        *
        * @param containerEngineClient the service client to use to delete the cluster
        * @param clusterId the cluster ID
        * @param newClusterName The new cluster name
        *
        */
        private static async Task UpdateCluster(
            ContainerEngineClient containerEngineClient, string clusterId, string newClusterName)
        {

            UpdateClusterDetails updateClusterDetails = new UpdateClusterDetails
            {
                Name = newClusterName
            };
            UpdateClusterRequest updateClusterRequest = new UpdateClusterRequest
            {
                ClusterId = clusterId,
                UpdateClusterDetails = updateClusterDetails
            };
            UpdateClusterResponse updateClusterResponse = await containerEngineClient.UpdateCluster(updateClusterRequest);

            string workRequestId = updateClusterResponse.OpcWorkRequestId;
            GetWorkRequestResponse workRequestResponse = WaitForWorkRequestFinished(containerEngineClient, workRequestId);

            GetClusterRequest getClusterRequest = new GetClusterRequest
            {
                ClusterId = clusterId
            };
            GetClusterResponse getClusterResponse = await containerEngineClient.GetCluster(getClusterRequest);
            Cluster cluster = getClusterResponse.Cluster;

            logger.Info($"Cluster name is changed to {cluster.Name}");
        }

        /**
        * Deletes a cluster and waits for it to be deleted.
        *
        * @param containerEngineClient the service client to use to delete the cluster
        * @param cluster the cluster to delete
        */
        private static async Task DeleteCluster(ContainerEngineClient containerEngineClient, string clusterId)
        {
            DeleteClusterRequest deleteClusterRequest = new DeleteClusterRequest
            {
                ClusterId = clusterId
            };
            DeleteClusterResponse deleteClusterResponse = await containerEngineClient.DeleteCluster(deleteClusterRequest);

            string workRequestId = deleteClusterResponse.OpcWorkRequestId;
            WaitForWorkRequestFinished(containerEngineClient, workRequestId);

            logger.Info("Cluster deleted");
        }

        /**
        * Deletes a subnet and waits for it to be deleted.
        *
        * @param vcnClient the service client to use to delete the subnet
        * @param subnet the subnet to delete
        *
        * @throws Exception if there is an error waiting on the subnet to be deleted
        */
        private static async Task DeleteSubnet(VirtualNetworkClient virtualNetworkClient, Subnet subnet)
        {
            DeleteSubnetRequest deleteSubnetRequest = new DeleteSubnetRequest
            {
                SubnetId = subnet.Id
            };
            await virtualNetworkClient.DeleteSubnet(deleteSubnetRequest);

            logger.Info($"Deleted Subnet: {subnet.Id}");
        }

        /**
        * Deletes a VCN and waits for it to be deleted.
        *
        * @param vcnClient the service client to use to delete the VCN
        * @param vcn the VCN to delete
        *
        * @throws Exception if there is an error waiting on the VCN to be deleted
        */
        private static async Task DeleteVcn(VirtualNetworkClient virtualNetworkClient, Vcn vcn)
        {
            DeleteVcnRequest deleteVcnRequest = new DeleteVcnRequest { VcnId = vcn.Id };
            await virtualNetworkClient.DeleteVcn(deleteVcnRequest);

            logger.Info($"Deleted Vcn: {vcn.Id}");
        }

        /**
        * Wait for a work request finished
        * @param containerEngineClient the service client to use to get work request
        * @param workRequestId the id of work request
        *
        * @return a work request response object
        */
        private static GetWorkRequestResponse WaitForWorkRequestFinished(ContainerEngineClient containerEngineClient, string workRequestId)
        {
            var waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetWorkRequestRequest getWorkRequestRequest = new GetWorkRequestRequest
            {
                WorkRequestId = workRequestId
            };
            return containerEngineClient.Waiters.ForWorkRequest(getWorkRequestRequest, waiterConfiguration, WorkRequestStatus.Succeeded).Execute();
        }

        /**
        * Get cluster ID
        *
        * @param GetWorkRequestResponse The work request response for getting cluster ID
        *
        * @return cluster ID
        *
        */
        private static string GetClusterId(GetWorkRequestResponse getWorkRequestResponse)
        {
            string clusterId = null;
            List<WorkRequestResource> resources = getWorkRequestResponse.WorkRequest.Resources;
            foreach (WorkRequestResource resource in resources)
            {
                if (resource.EntityType.Equals("cluster"))
                {
                    clusterId = resource.Identifier;
                    break;
                }
            }

            return clusterId;
        }
    }
}
