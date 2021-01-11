/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;


namespace Oci.Examples
{
    // This example demonstrates the following operations
    // * Launch an instance
    // * Create boot volume
    // * Create Subnet, internet gateway
    // * Create Virtual Cloud Network
    // * Add rules to the Route Table
    // * Clean up all the resources

    public class CreateInstanceExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static string OPERATING_SYSTEM = "Oracle Linux";

        public static async Task MainInstance()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");

            var identityClient = new IdentityClient(provider);
            var computeClient = new ComputeClient(provider, new ClientConfiguration());
            var virtualNetworkClient = new VirtualNetworkClient(provider);
            var blockStorageClient = new BlockstorageClient(provider);
            var networkCidrBlock = "10.0.1.0/24";

            LaunchInstanceDetails launchInstanceDetails = null;
            Instance instance = null;
            BootVolume bootVolume = null;
            Instance instanceFromBootVolume = null;
            Vcn vcn = null;
            Subnet subnet = null;
            CreateVnicDetails createVnicDetails = null;
            InternetGateway internetGateway = null;

            AvailabilityDomain availablityDomain = await getAvailabilityDomains(identityClient, compartmentId);
            logger.Info($"availability domain is {availablityDomain.Name}");

            Shape shape = await getShape(computeClient, compartmentId, availablityDomain);
            if (shape == null)
            {
                logger.Error($"No Shapes available in the availability domain: {availablityDomain.Name}");
                return;
            }
            logger.Info($"shape is {shape.ShapeProp}");
            Image image = await getImage(computeClient, compartmentId, shape);

            try
            {
                vcn = await createVcn(virtualNetworkClient, compartmentId, networkCidrBlock);

                // The Internet Gateway with updated Route Rules will enable the instance to connect to the public
                // internet. If it is not desired, remove the following two lines below that create an internet
                // gateway and add that internet gateway to the VCN route table.
                internetGateway = await createInternalGateway(virtualNetworkClient, compartmentId, vcn);
                await addInternetGatewayToDefaultRouteTable(virtualNetworkClient, vcn, internetGateway);

                subnet = await createSubnet(virtualNetworkClient, compartmentId, availablityDomain, networkCidrBlock, vcn);

                createVnicDetails = new CreateVnicDetails { SubnetId = subnet.Id };

                launchInstanceDetails = new LaunchInstanceDetails
                {
                    AvailabilityDomain = availablityDomain.Name,
                    CompartmentId = compartmentId,
                    Shape = shape.ShapeProp,
                    CreateVnicDetails = createVnicDetails,
                    ImageId = image.Id
                };

                instance = await createInstance(computeClient, launchInstanceDetails);
                await printInstance(computeClient, virtualNetworkClient, instance);

                logger.Info("Instance is being created via boot volume ...");
                // This boot volume is created based on the boot volume of previous instance which needs to be running
                bootVolume = await createBootVolume(blockStorageClient, compartmentId, availablityDomain, image);
                launchInstanceDetails = createLaunchInstanceDetailsFromBootVolume(launchInstanceDetails, bootVolume);
                instanceFromBootVolume = await createInstance(computeClient, launchInstanceDetails);
                await printInstance(computeClient, virtualNetworkClient, instanceFromBootVolume);

            }
            catch (Exception e)
            {
                logger.Error($"Failed to call LaunchInstance API: {e.Message}");
            }
            finally
            {
                logger.Info("cleaning up resources");
                if (instanceFromBootVolume != null)
                {
                    await terminateInstance(computeClient, instanceFromBootVolume);
                }

                if (instance != null)
                {
                    await terminateInstance(computeClient, instance);
                }

                if (internetGateway != null)
                {
                    await clearRouteRulesFromDefaultRouteTable(virtualNetworkClient, vcn);
                    await deleteInternetGateway(virtualNetworkClient, internetGateway);
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
                computeClient.Dispose();
                virtualNetworkClient.Dispose();
                blockStorageClient.Dispose();

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

        private static async Task<Shape> getShape(ComputeClient client, string compartmentId, AvailabilityDomain availabilityDomain)
        {
            ListShapesRequest listShapesRequest = new ListShapesRequest
            {
                CompartmentId = compartmentId,
                AvailabilityDomain = availabilityDomain.Name
            };
            ListShapesResponse listShapesResponse = await client.ListShapes(listShapesRequest);
            Shape shape = listShapesResponse.Items.Find(x => x.ShapeProp.StartsWith("VM"));

            return shape;
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

        private static async Task<InternetGateway> createInternalGateway(VirtualNetworkClient virtualNetworkClient, string compartmentId, Vcn vcn)
        {
            string internetGatewayName = "oci-dotent-sdk-example-internet-gateway";
            CreateInternetGatewayDetails createInternetGatewayDetails = new CreateInternetGatewayDetails
            {
                CompartmentId = compartmentId,
                DisplayName = internetGatewayName,
                IsEnabled = true,
                VcnId = vcn.Id
            };
            CreateInternetGatewayRequest createInternetGatewayRequest = new CreateInternetGatewayRequest { CreateInternetGatewayDetails = createInternetGatewayDetails };
            CreateInternetGatewayResponse createInternetGatewayResponse = await virtualNetworkClient.CreateInternetGateway(createInternetGatewayRequest);

            GetInternetGatewayRequest getInternetGatewayRequest = new GetInternetGatewayRequest { IgId = createInternetGatewayResponse.InternetGateway.Id };
            GetInternetGatewayResponse getInternetGatewayResponse = virtualNetworkClient.Waiters.ForInternetGateway(getInternetGatewayRequest, InternetGateway.LifecycleStateEnum.Available).Execute();
            InternetGateway internetGateway = getInternetGatewayResponse.InternetGateway;

            logger.Info($"Created internet gateway: {internetGateway.Id} and state is {internetGateway.LifecycleState}");
            return internetGateway;
        }

        private static async Task addInternetGatewayToDefaultRouteTable(VirtualNetworkClient virtualNetworkClient, Vcn vcn, InternetGateway internetGateway)
        {
            GetRouteTableRequest getRouteTableRequest = new GetRouteTableRequest { RtId = vcn.DefaultRouteTableId };
            GetRouteTableResponse getRouteTableResponse = await virtualNetworkClient.GetRouteTable(getRouteTableRequest);
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
                NetworkEntityId = internetGateway.Id
            };
            routeRules.Add(internetAccessRoute);
            UpdateRouteTableDetails updateRouteTableDetails = new UpdateRouteTableDetails { RouteRules = routeRules };
            UpdateRouteTableRequest updateRouteTableRequest = new UpdateRouteTableRequest
            {
                UpdateRouteTableDetails = updateRouteTableDetails,
                RtId = vcn.DefaultRouteTableId
            };
            UpdateRouteTableResponse updateRouteTableResponse = await virtualNetworkClient.UpdateRouteTable(updateRouteTableRequest);

            getRouteTableResponse = virtualNetworkClient.Waiters.ForRouteTable(getRouteTableRequest, RouteTable.LifecycleStateEnum.Available).Execute();
            routeRules = getRouteTableResponse.RouteTable.RouteRules;

            logger.Info("Updated Route Rules in Default Route Table");
            logger.Info("==========================================");
            routeRules.ForEach(delegate (RouteRule rule)
            {
                logger.Info($"rule: {rule.NetworkEntityId}\n");
            });
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

        private static async Task<Image> getImage(ComputeClient computeClient, string compartmentId, Shape shape)
        {
            ListImagesRequest listImagesRequest = new ListImagesRequest
            {
                Shape = shape.ShapeProp,
                CompartmentId = compartmentId,
                OperatingSystem = OPERATING_SYSTEM
            };
            ListImagesResponse response = await computeClient.ListImages(listImagesRequest);
            List<Image> images = response.Items;
            if (images.Count == 0)
            {
                logger.Error("No available image was found.");
            }

            // For demonstration, we just return the first image but for Production code you should have a better
            // way of determining what is needed.
            //
            // Note the latest version of the images for the same operating system is returned firstly.
            Image image = images[0];

            logger.Info($"Found Image: {image.DisplayName}");
            return image;
        }

        private static async Task<Instance> createInstance(ComputeClient computeClient, LaunchInstanceDetails launchInstanceDetails)
        {
            logger.Info("Launching an instance.....");
            LaunchInstanceRequest launchInstanceRequest = new LaunchInstanceRequest { LaunchInstanceDetails = launchInstanceDetails };
            LaunchInstanceResponse launchInstanceResponse = await computeClient.LaunchInstance(launchInstanceRequest);

            GetInstanceRequest getInstanceRequest = new GetInstanceRequest { InstanceId = launchInstanceResponse.Instance.Id };
            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetInstanceResponse getInstanceResponse = computeClient.Waiters.ForInstance(getInstanceRequest, waiterConfiguration, Instance.LifecycleStateEnum.Running).Execute();

            Instance instance = getInstanceResponse.Instance;

            return instance;
        }

        private static async Task printInstance(ComputeClient computeClient, VirtualNetworkClient virtualNetworkClient, Instance instance)
        {
            ListVnicAttachmentsRequest listVnicAttachmentsRequest = new ListVnicAttachmentsRequest
            {
                CompartmentId = instance.CompartmentId,
                InstanceId = instance.Id
            };
            ListVnicAttachmentsResponse listVnicAttachmentsResponse = await computeClient.ListVnicAttachments(listVnicAttachmentsRequest);
            List<VnicAttachment> vnicAttachments = listVnicAttachmentsResponse.Items;
            VnicAttachment vnicAttachment = vnicAttachments[0];

            GetVnicRequest getVnicRequest = new GetVnicRequest
            {
                VnicId = vnicAttachment.VnicId
            };
            GetVnicResponse getVnicResponse = await virtualNetworkClient.GetVnic(getVnicRequest);
            Vnic vnic = getVnicResponse.Vnic;

            logger.Info($"Virtual Network Interface Card: {vnic.Id}");

            InstanceAgentConfig instanceAgentConfig = instance.AgentConfig;
            bool monitoringEnabled = instanceAgentConfig.IsMonitoringDisabled.HasValue ? instanceAgentConfig.IsMonitoringDisabled.Value : false;
            string monitoringStatus = (monitoringEnabled ? "Enabled" : "Disabled");

            logger.Info($"Instance ID: {instance.Id} has monitoring {monitoringStatus}");
        }

        private static async Task<BootVolume> createBootVolume(BlockstorageClient blockstorageClient, string compartmentId, AvailabilityDomain availabilityDomain, Image image)
        {
            string bootVolumeName = "oci-dotnet-sdk-example-boot-volume";
            // find existing boot volume by image
            ListBootVolumesRequest listBootVolumesRequest = new ListBootVolumesRequest
            {
                AvailabilityDomain = availabilityDomain.Name,
                CompartmentId = compartmentId
            };
            ListBootVolumesResponse listBootVolumesResponse = await blockstorageClient.ListBootVolumes(listBootVolumesRequest);
            List<BootVolume> bootVolumes = listBootVolumesResponse.Items;
            BootVolume existingBootVolume = null;
            foreach (BootVolume bootVol in bootVolumes)
            {
                if (BootVolume.LifecycleStateEnum.Available.Equals(bootVol.LifecycleState) && image.Id.Equals(bootVol.ImageId))
                {
                    existingBootVolume = bootVol;
                    break;
                }
            }

            // create a new boot volume based on existing one
            logger.Info($"Found BootVolume: {existingBootVolume.Id}");
            BootVolumeSourceDetails existingBootVolumeDetails = existingBootVolume.SourceDetails;
            BootVolumeSourceDetails bootVolumeSourceDetails = new BootVolumeSourceFromBootVolumeDetails
            {
                Id = existingBootVolume.Id
            };

            CreateBootVolumeDetails createBootVolumeDetails = new CreateBootVolumeDetails
            {
                AvailabilityDomain = availabilityDomain.Name,
                CompartmentId = compartmentId,
                DisplayName = bootVolumeName,
                SourceDetails = bootVolumeSourceDetails
            };
            CreateBootVolumeRequest createBootVolumeRequest = new CreateBootVolumeRequest { CreateBootVolumeDetails = createBootVolumeDetails };
            CreateBootVolumeResponse createBootVolumeResponse = await blockstorageClient.CreateBootVolume(createBootVolumeRequest);
            logger.Info($"Provisioning new BootVolume: " + createBootVolumeResponse.BootVolume.Id);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };

            // wait for boot volume to be ready
            GetBootVolumeRequest getBootVolumeRequest = new GetBootVolumeRequest { BootVolumeId = createBootVolumeResponse.BootVolume.Id };
            GetBootVolumeResponse getBootVolumeResponse = blockstorageClient.Waiters.ForBootVolume(getBootVolumeRequest, waiterConfiguration, BootVolume.LifecycleStateEnum.Available).Execute();
            BootVolume bootVolume = getBootVolumeResponse.BootVolume;

            logger.Info($"Provisioned BootVolume: {bootVolume.Id}");
            return bootVolume;
        }

        private static LaunchInstanceDetails createLaunchInstanceDetailsFromBootVolume(LaunchInstanceDetails launchInstanceDetails, BootVolume bootVolume)
        {
            InstanceSourceViaBootVolumeDetails instanceSourceViaBootVolumeDetails = new InstanceSourceViaBootVolumeDetails
            {
                BootVolumeId = bootVolume.Id
            };
            LaunchInstanceAgentConfigDetails launchInstanceAgentConfigDetails = new LaunchInstanceAgentConfigDetails
            {
                IsMonitoringDisabled = true
            };

            return new LaunchInstanceDetails
            {
                AvailabilityDomain = launchInstanceDetails.AvailabilityDomain,
                CompartmentId = launchInstanceDetails.CompartmentId,
                Shape = launchInstanceDetails.Shape,
                CreateVnicDetails = launchInstanceDetails.CreateVnicDetails,
                ImageId = launchInstanceDetails.ImageId,
                SourceDetails = instanceSourceViaBootVolumeDetails,
                AgentConfig = launchInstanceAgentConfigDetails
            };
        }

        private static async Task terminateInstance(ComputeClient computeClient, Instance instance)
        {
            logger.Info($"Terminating Instance: {instance.Id}");
            TerminateInstanceRequest terminateInstanceRequest = new TerminateInstanceRequest { InstanceId = instance.Id };
            await computeClient.TerminateInstance(terminateInstanceRequest);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetInstanceRequest getInstanceRequest = new GetInstanceRequest { InstanceId = instance.Id };
            computeClient.Waiters.ForInstance(getInstanceRequest, waiterConfiguration, Instance.LifecycleStateEnum.Terminated).Execute();

            logger.Info($"Terminated Instance: {instance.Id}");
        }

        private static async Task clearRouteRulesFromDefaultRouteTable(VirtualNetworkClient virtualNetworkClient, Vcn vcn)
        {
            List<RouteRule> routeRules = new List<RouteRule>();
            UpdateRouteTableDetails updateRouteTableDetails = new UpdateRouteTableDetails { RouteRules = routeRules };
            UpdateRouteTableRequest updateRouteTableRequest = new UpdateRouteTableRequest
            {
                UpdateRouteTableDetails = updateRouteTableDetails,
                RtId = vcn.DefaultRouteTableId
            };
            await virtualNetworkClient.UpdateRouteTable(updateRouteTableRequest);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };

            GetRouteTableRequest getRouteTableRequest = new GetRouteTableRequest
            {
                RtId = vcn.DefaultRouteTableId
            };
            virtualNetworkClient.Waiters.ForRouteTable(getRouteTableRequest, waiterConfiguration, RouteTable.LifecycleStateEnum.Available).Execute();

            logger.Info($"Cleared route rules from route table: {vcn.DefaultRouteTableId}");
        }

        private static async Task deleteInternetGateway(VirtualNetworkClient virtualNetworkClient, InternetGateway internetGateway)
        {
            DeleteInternetGatewayRequest deleteInternetGatewayRequest = new DeleteInternetGatewayRequest
            {
                IgId = internetGateway.Id
            };
            await virtualNetworkClient.DeleteInternetGateway(deleteInternetGatewayRequest);

            logger.Info($"Deleted Internet Gateway: {internetGateway.Id}");
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
            DeleteVcnRequest deleteVcnRequest = new DeleteVcnRequest { VcnId = vcn.Id };
            await virtualNetworkClient.DeleteVcn(deleteVcnRequest);

            logger.Info($"Deleted Vcn: {vcn.Id}");
        }
    }
}
