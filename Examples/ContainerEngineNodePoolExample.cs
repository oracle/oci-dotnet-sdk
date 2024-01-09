/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    * This class provides an example of how to create a Container Engine node pool in the .NET SDK.
    * It will create a VCN and two subnets, one Container Engine cluster and add one node pool in the cluster.
    * These will be deleted at the end. The class also makes some assumptions about
    * the resources it will create:
    *
    * <ul>:
    *   <li>The VCN created by this example will have a display name of oci_dotnet_sdk_example_vcn</li>
    *   <li>The subnet created by this example will have a display name of: oci_dotnet_sdk_example_subnet_1</li>
    *   <li>The subnet created by this example will have a display name of: oci_dotnet_sdk_example_subnet_2</li>
    *   <li>The VCN will have a private IP CIDR block of 10.0.0.0/16</li>
    *   <li>The subnets will have private IP CIDR blocks of 10.0.0.0/24 and 10.0.1.0/24 </li>
    *   <li>The cluster created will have hardcoded display names of ContainerEngineExampleCluster</li>
    *   <li>The node pool created will have hardcoded display names of ContainerEngineNodePoolExample</li>
    *   <li>The first subnet are used for creating cluster</li>
    *   <li>The second subnet is used for creating node pool</li>
    *   <li>
    *      The configuration file used by service clients will be sourced from the default
    *      location (~/.oci/config) and the DEFAULT profile will be used
    *   </li>
    *   <li>Resources will be created in us-phoenix-1</li>
    *   <li>Resources will be created in the first AD returned from the ListAvailabilityDomains call</li>
    * <ul>
    */

    public class ContainerEngineNodePoolExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static string VcnDisplayName = "oci_dotnet_sdk_example_vcn";
        private static string[] SubnetDisplayNames = {
            "oci_dotnet_sdk_example_subnet_1",
            "oci_dotnet_sdk_example_subnet_2"
        };
        private static string CidrBlock = "10.0.0.0/16";
        private static string[] SubnetCidrBlocks = {
            "10.0.0.0/24", "10.0.1.0/24"
        };
        private static string ClusterDisplayName = "ContainerEngineClusterTest";
        private static string NodePoolDisplayName = "ContainerEngineNodePool";
        private static string NewNodePoolDisplayName = "ContainerEngineNodePoolNew";
        private static string NodeImageName = "Oracle-Linux-7.6";
        private static string NodeShape = "VM.Standard2.1";

        public static async Task MainContainerEngineNodePool()
        {
            logger.Info("Starting example");

            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);

            var containerEngineClient = new ContainerEngineClient(provider);
            var vcnClient = new VirtualNetworkClient(provider);
            var identityClient = new IdentityClient(provider);

            Vcn vcn = null;
            List<Subnet> subnets = null;
            List<string> lbSubnetIds = new List<string>();
            List<string> poolSubnetIds = new List<string>();
            Cluster cluster = null;
            NodePool nodePool = null;

            try
            {

                List<IdentityModels.AvailabilityDomain> availablityDomains = await GetAvailabilityDomains(identityClient, compartmentId);

                vcn = await CreateVcn(vcnClient, compartmentId);
                subnets = await CreateSubnets(vcnClient, compartmentId, vcn);
                lbSubnetIds.Add(subnets[0].Id);
                poolSubnetIds.Add(subnets[1].Id);

                var kubernetesVersion = await GetKubernetesVersion(containerEngineClient);

                cluster = await CreateCluster(containerEngineClient, vcn.Id, lbSubnetIds, kubernetesVersion, compartmentId);

                // Add node pool in the cluster
                KeyValue keyValue = new KeyValue
                {
                    Key = "key1",
                    Value = "value1"
                };
                List<KeyValue> initialNodeLabels = new List<KeyValue> { keyValue };

                List<NodePoolPlacementConfigDetails> nodePoolPlacementConfigDetails = new List<NodePoolPlacementConfigDetails>();
                foreach (var availabilityDomain in availablityDomains)
                {
                    nodePoolPlacementConfigDetails.Add(new NodePoolPlacementConfigDetails
                    {
                        AvailabilityDomain = availabilityDomain.Name,
                        SubnetId = poolSubnetIds[0]
                    });
                };

                var createNodePoolNodeConfigDetails = new CreateNodePoolNodeConfigDetails
                {
                    Size = availablityDomains.Count,
                    PlacementConfigs = nodePoolPlacementConfigDetails
                };
                nodePool = await CreateNodePool(containerEngineClient, compartmentId, cluster.Id, NodePoolDisplayName,
                    kubernetesVersion, NodeImageName, NodeShape, initialNodeLabels, createNodePoolNodeConfigDetails);
                logger.Info("Created node pool");

                // Update the node pool
                await UpdateNodePool(containerEngineClient, nodePool.Id, NewNodePoolDisplayName);

            }
            catch (Exception e)
            {
                logger.Error($"Failed to create container engine cluster: {e}");
            }
            finally
            {
                logger.Info("Cleaning up...");

                if (nodePool != null)
                {
                    await DeleteNodePool(containerEngineClient, nodePool.Id);
                }
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
        * @return a list of all availability domains in a compartment
        */
        private static async Task<List<IdentityModels.AvailabilityDomain>> GetAvailabilityDomains(IdentityClient identityClient, string compartmentId)
        {
            IdentityRequests.ListAvailabilityDomainsRequest listAvailabilityDomainsRequest = new IdentityRequests.ListAvailabilityDomainsRequest
            {
                CompartmentId = compartmentId
            };
            IdentityResponses.ListAvailabilityDomainsResponse listAvailabilityDomainsResponse = await identityClient.ListAvailabilityDomains(listAvailabilityDomainsRequest);

            return listAvailabilityDomainsResponse.Items;
        }

        /**
        * Creates a VCN and waits for it to become available to use.
        *
        * @param virtualNetworkClient the service client to use to create the VCN
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
        * @param vcnId the ID of the VCN which will own the subnet
        * @param subnetName the subnet that will be created
        * @param cidrBlock the cidr block used to create subnet
        *
        * @return the created subnets
        */
        private static async Task<List<Subnet>> CreateSubnets(VirtualNetworkClient virtualNetworkClient, string compartmentId, Vcn vcn)
        {
            List<Subnet> subnets = new List<Subnet>();
            for (int i = 0; i < 2; i++)
            {
                CreateSubnetDetails createSubnetDetails = new CreateSubnetDetails
                {
                    CompartmentId = compartmentId,
                    DisplayName = SubnetDisplayNames[i],
                    CidrBlock = SubnetCidrBlocks[i],
                    VcnId = vcn.Id,
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
        * @return the first Kubernetes version
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
        * Creates a Cluster and waits until the work request finished
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

            var clusterId = GetWorkRequestResourceId(workRequestResponse, "cluster");
            logger.Info($"cluster ID is {clusterId}");

            GetClusterRequest getClusterRequest = new GetClusterRequest
            {
                ClusterId = clusterId
            };
            GetClusterResponse getClusterResponse = await containerEngineClient.GetCluster(getClusterRequest);

            return getClusterResponse.Cluster;
        }

        /**
        * Deletes a cluster and waits for it to be deleted.
        *
        * @param containerEngineClient the service client to use to delete the cluster
        * @param clusterId the ID of the cluster to be deleted
        *
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
        }

        /**
        * Deletes a subnet and waits for it to be deleted.
        *
        * @param virtualNetworkClient the service client to use to delete the subnet
        * @param subnet the subnet to delete
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
        * @param virtualNetworkClient the service client to use to delete the VCN
        * @param vcn the VCN to delete
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
        * Creates a node pool in a cluster and waits until the work request finished
        *
        * @param containerEngineClient the containerEngineclient used to create the node pool
        * @param compartmentId The compartment ID
        * @param clusterId The ID of the cluster that the node pool is added in
        * @param displayName The display name of the node pool
        * @param kubernetesVersion kubernetesVersion
        * @param nodeImageName The image to use on each node in the node pool
        * @param nodeShape The number of CPUs and the amount of memory allocated to each node in the node pool
        * @param initialNodeLabels The initial node label
        * @param nodePoolNodeConfigDetails The node pool size and the placementConfig of nodes.
        * @return the created node pool
        */
        private static async Task<NodePool> CreateNodePool(ContainerEngineClient containerEngineClient, string compartmentId,
            string clusterId, string displayName, string kubernetesVersion, string nodeImageName,
            string nodeShape, List<KeyValue> initialNodeLabels, CreateNodePoolNodeConfigDetails nodePoolNodeConfigDetails)
        {
            var createNodePoolDetails = new CreateNodePoolDetails
            {
                CompartmentId = compartmentId,
                ClusterId = clusterId,
                Name = displayName,
                KubernetesVersion = kubernetesVersion,
                NodeImageName = nodeImageName,
                InitialNodeLabels = initialNodeLabels,
                NodeConfigDetails = nodePoolNodeConfigDetails,
                NodeShape = nodeShape
            };
            var createNodePoolRequest = new CreateNodePoolRequest
            {
                CreateNodePoolDetails = createNodePoolDetails
            };
            var createNodePoolResponse = await containerEngineClient.CreateNodePool(createNodePoolRequest);

            string workRequestId = createNodePoolResponse.OpcWorkRequestId;
            logger.Info($"Create node pool work request ID: {workRequestId}");

            GetWorkRequestResponse workRequestResponse = WaitForWorkRequestFinished(containerEngineClient, workRequestId);
            var nodePoolId = GetWorkRequestResourceId(workRequestResponse, "nodepool");
            logger.Info($"Node pool ID is {nodePoolId}");

            GetNodePoolRequest getNodePoolRequest = new GetNodePoolRequest
            {
                NodePoolId = nodePoolId
            };
            GetNodePoolResponse getNodePoolResponse = await containerEngineClient.GetNodePool(getNodePoolRequest);
            return getNodePoolResponse.NodePool;
        }

        /**
        * Update a node pool and waits until the work request finished
        *
        * @param containerEngineClient the service client to use to update the node pool
        * @param nodePoolId the node pool ID
        * @param newNodePoolName The new node pool name
        *
        */
        private static async Task UpdateNodePool(ContainerEngineClient containerEngineClient, string nodePoolId,
            string newDisplayName)
        {
            var updateNodePoolDetails = new UpdateNodePoolDetails
            {
                Name = newDisplayName
            };
            var updateNodePoolRequest = new UpdateNodePoolRequest
            {
                NodePoolId = nodePoolId,
                UpdateNodePoolDetails = updateNodePoolDetails
            };
            var updateNodePoolResponse = await containerEngineClient.UpdateNodePool(updateNodePoolRequest);

            string workRequestId = updateNodePoolResponse.OpcWorkRequestId;
            var workRequestResponse = WaitForWorkRequestFinished(containerEngineClient, workRequestId);

            GetNodePoolRequest getNodePoolRequest = new GetNodePoolRequest
            {
                NodePoolId = nodePoolId
            };
            GetNodePoolResponse getNodePoolResponse = await containerEngineClient.GetNodePool(getNodePoolRequest);
            NodePool nodePool = getNodePoolResponse.NodePool;
            logger.Info($"Node pool name changed to {nodePool.Name}");
        }

        /**
        * Deletes a node pool and waits for it to be deleted.
        *
        * @param containerEngineClient the service client to use to delete the node pool
        * @param nodePoolId the ID of the node pool to be deleted
        *
        */
        private static async Task DeleteNodePool(ContainerEngineClient containerEngineClient, string nodePoolId)
        {
            DeleteNodePoolRequest deleteNodePoolRequest = new DeleteNodePoolRequest
            {
                NodePoolId = nodePoolId
            };
            DeleteNodePoolResponse deleteNodePoolResponse = await containerEngineClient.DeleteNodePool(deleteNodePoolRequest);

            string workRequestId = deleteNodePoolResponse.OpcWorkRequestId;
            WaitForWorkRequestFinished(containerEngineClient, workRequestId);
        }

        /**
        * Get the first work request resource ID that match the entity type
        *
        * @param getWorkRequestResponse The work request response for getting work request resource ID
        * @param entityType resource entity type
        *
        * @return work request resource ID
        */
        private static string GetWorkRequestResourceId(GetWorkRequestResponse getWorkRequestResponse, string entityType)
        {
            string resourceId = null;
            var resources = getWorkRequestResponse.WorkRequest.Resources;
            foreach (var resource in resources)
            {
                if (resource.EntityType.Equals(entityType))
                {
                    resourceId = resource.Identifier;
                    break;
                }
            }
            return resourceId;
        }
    }
}
