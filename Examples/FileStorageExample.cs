/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.Common.Waiters;
using Oci.FilestorageService;
using Oci.FilestorageService.Models;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;


namespace Oci.Examples
{
    /**
    * This class provides an example of how to use the File Storage service in the .NET SDK.
    *
    * In order to demonstrate functionality for mount targets and export sets, this script will also create a VCN
    * and subnet. These will be deleted at the end of the script. This script also makes some assumptions about
    * the resources it will create:
    *
    * <ul>
    *   <li>The VCN created by this example will have a display name of oci_dotnet_sdk_example_vcn</li>
    *   <li>The subnet created by this example will have a display name of: oci_dotnet_sdk_example_subnet</li>
    *   <li>The VCN and subnet will have a private IP CIDR block of 10.0.0.0/16</li>
    *   <li>The file system export created by this example will have a path of /files</li>
    *   <li>
    *      The configuration file used by service clients will be sourced from the default
    *      location (~/.oci/config) and the DEFAULT profile will be used
    *   </li>
    *   <li>Resources will be created in us-phoenix-1</li>
    *   <li>Resources will be created in the first AD returned from the ListAvailabilityDomains call</li>
    * <ul>
    *
    * Here we demonstrate:
    *
    *     - Creating a new file system
    *     - Creating a mount target via which the file system can be accessed. The mount target and file system must
    *       be in the same availability domain in order to export the file system from the mount target
    *     - Creating an export so that we can mount the file system (see
    *       https://docs.cloud.oracle.com/Content/File/Tasks/mountingfilesystems.htm for more information)
    *     - Creating a snapshot of the file system
    *
    * And we'll delete these resources when we're done
    */

    public class FileStorageExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static string VcnDisplayName = "oci_dotnet_sdk_example_vcn";
        private static string SubnetDisplayName = "oci_dotnet_sdk_example_subnet";
        private static string CidrBlock = "10.0.0.0/16";
        private static string ExportPath = "/files";

        public static async Task MainFileStorage()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var fileSystemDisplayName = Environment.GetEnvironmentVariable("FILE_SYSTEM_DISPLAY_NAME");

            var identityClient = new IdentityClient(provider);
            var fileStorageClient = new FileStorageClient(provider);
            var vcnClient = new VirtualNetworkClient(provider);

            Vcn vcn = null;
            Subnet subnet = null;
            FileSystem fileSystem = null;
            MountTarget mountTarget = null;
            Export export = null;
            Snapshot snapshot = null;

            try
            {
                var availablityDomain = await GetAvailabilityDomain(identityClient, compartmentId);
                logger.Info($"availability domain is {availablityDomain.Name}");

                // A VCN and subnet is required to create a mount target
                vcn = await CreateVcn(vcnClient, compartmentId);
                subnet = await CreateSubnet(vcnClient, compartmentId, availablityDomain, vcn);

                fileSystem = await CreateFileSystem(fileStorageClient, compartmentId,
                                    fileSystemDisplayName, availablityDomain);

                mountTarget = await CreateMountTarget(fileStorageClient, vcnClient,
                                    compartmentId, fileSystemDisplayName + "-mnt", availablityDomain, subnet);
                await GetExportSet(fileStorageClient, mountTarget.ExportSetId);

                export = await CreateExport(fileStorageClient, fileSystem.Id, mountTarget.ExportSetId);
                ListExports(fileStorageClient, compartmentId, fileSystem, mountTarget);

                snapshot = await CreateSnapshot(fileStorageClient, fileSystem);

            }
            catch (Exception e)
            {
                logger.Error($"Failed to mount file system: {e}");
            }
            finally
            {
                logger.Info("cleaning resources....");

                if (snapshot != null)
                {
                    await DeleteSnapshot(fileStorageClient, snapshot);
                }

                if (export != null)
                {
                    await DeleteExport(fileStorageClient, export);
                }

                if (mountTarget != null)
                {
                    await DeleteMountTarget(fileStorageClient, mountTarget);
                }

                if (fileSystem != null)
                {
                    await DeleteFileSystem(fileStorageClient, fileSystem);
                }

                if (subnet != null)
                {
                    await DeleteSubnet(vcnClient, subnet);
                }

                if (vcn != null)
                {
                    await DeleteVcn(vcnClient, vcn);
                }

                identityClient.Dispose();
                fileStorageClient.Dispose();
                vcnClient.Dispose();

                logger.Info("End example");
            }
        }

        /**
        * Creates a file system and waits for it to become available. We recommend to retry these requests
        * so that if you receive a timeout or server error and you won't run into the risk of creating multiple resources.
        *
        * @param fsClient the service client to use to create the File System
        * @param compartmentId the OCID of the compartment where the file system will be created
        * @param availabilityDomain the availability domain where the file system will be created
        *
        * @return the created file system
        */
        private static async Task<FileSystem> CreateFileSystem(FileStorageClient fsClient, string compartmentId,
            string displayName, AvailabilityDomain availabilityDomain)
        {
            logger.Info("Creating file system......");

            CreateFileSystemDetails createDetails = new CreateFileSystemDetails
            {
                DisplayName = displayName,
                CompartmentId = compartmentId,
                AvailabilityDomain = availabilityDomain.Name
            };
            CreateFileSystemRequest createRequest = new CreateFileSystemRequest
            {
                CreateFileSystemDetails = createDetails
            };
            CreateFileSystemResponse createResponse = await fsClient.CreateFileSystem(createRequest, new RetryConfiguration
            {
                MaxAttempts = 5
            });
            logger.Info($"Created file system: {createResponse.FileSystem.DisplayName}");

            GetFileSystemRequest getRequest = new GetFileSystemRequest
            {
                FileSystemId = createResponse.FileSystem.Id
            };
            GetFileSystemResponse getResponse = fsClient.Waiters.ForFileSystem(getRequest, FileSystem.LifecycleStateEnum.Active).Execute();
            logger.Info($"Waited for file system to become available: {createResponse.FileSystem.DisplayName}");

            return getResponse.FileSystem;
        }

        /**
        * Creates a mount target and waits for it to become available. We recommend to retry these requests
        * so that if you receive a timeout or server error and you won't run into the risk of creating multiple resources.
        *
        * This creates a mount target WITHOUT specifying a hostname. This means that the mount target will only be accessible
        * via its private IP address.
        *
        * @param fsClient the service client to use to create the mount target
        * @param vcnClient a client used to communiate with the Virtual Networking service
        * @param compartmentId the OCID of the compartment where the file system will be created
        * @param displayName the display name of the mount target
        * @param availabilityDomain the availability domain where the file system will be created
        * @param subnet the subnet where the mount target will reside. If no private IP address is explicitly specified at
        * creation time then the mount target will be assigned a free private IP address from the subnet
        *
        * @return the created mount target
        */
        private static async Task<MountTarget> CreateMountTarget(FileStorageClient fsClient, VirtualNetworkClient vcnClient,
            string compartmentId, string displayName, AvailabilityDomain availabilityDomain, Subnet subnet)
        {
            logger.Info("Creating mount target......");

            CreateMountTargetDetails createDetails = new CreateMountTargetDetails
            {
                AvailabilityDomain = availabilityDomain.Name,
                SubnetId = subnet.Id,
                CompartmentId = compartmentId,
                DisplayName = displayName
            };
            CreateMountTargetRequest createRequest = new CreateMountTargetRequest
            {
                CreateMountTargetDetails = createDetails
            };
            var retryConfiguration = new RetryConfiguration
            {
                MaxAttempts = 5
            };
            CreateMountTargetResponse createResponse = await fsClient.CreateMountTarget(createRequest, retryConfiguration);
            logger.Info($"Created Mount target: {createResponse.MountTarget.DisplayName}");

            logger.Info("Waiting for mount target to become available");
            GetMountTargetRequest getRequest = new GetMountTargetRequest
            {
                MountTargetId = createResponse.MountTarget.Id
            };
            GetMountTargetResponse getResponse = fsClient.Waiters.ForMountTarget(getRequest, MountTarget.LifecycleStateEnum.Active).Execute();
            logger.Info($"Mount target state: {getResponse.MountTarget.LifecycleState}");

            string mountTargetPrivateIpId = getResponse.MountTarget.PrivateIpIds[0];
            GetPrivateIpRequest getPrivateIpRequest = new GetPrivateIpRequest
            {
                PrivateIpId = mountTargetPrivateIpId
            };
            GetPrivateIpResponse getPrivateIpResponse = await vcnClient.GetPrivateIp(getPrivateIpRequest);
            logger.Info($"Mount target private IP: {getPrivateIpResponse.PrivateIp.IpAddress}");

            return getResponse.MountTarget;
        }

        /**
        * Retrieves the details of an export set for a mount target
        *
        * @param exportSetId the OCID of the export set (obtained from a MountTarget)
        */
        private static async Task GetExportSet(FileStorageClient fileStorageClient, string exportSetId)
        {
            logger.Info("Get export set for mount target");

            GetExportSetRequest getExportSetRequest = new GetExportSetRequest
            {
                ExportSetId = exportSetId
            };
            GetExportSetResponse getExportSetResponse = await fileStorageClient.GetExportSet(getExportSetRequest);
            logger.Info($"Export set for mount target: {getExportSetResponse.ExportSet.DisplayName}");
        }

        /**
        * Creates an export and waits for it to become available. This export enables us to access the file system
        * via the mount target. We recommend using a retry token on these requests
        * so that if you receive a timeout or server error and need to retry the request you won't run the risk of
        * creating multiple resources.
        *
        * There are rules around export paths and file system associations which you should review here:
        * https://docs.cloud.oracle.com/api/#/en/filestorage/20171215/Export/
        *
        * @param fsClient the service client to use to create the export
        * @param fileSystemId the OCID of the file system to associate with the export
        * @param exportSetId the OCID of the MountTarget's export set
        *
        * @return the created export
        */
        private static async Task<Export> CreateExport(FileStorageClient fsClient, string fileSystemId, string exportSetId)
        {
            logger.Info("Creating export.....");

            CreateExportDetails createExportDetails = new CreateExportDetails
            {
                ExportSetId = exportSetId,
                FileSystemId = fileSystemId,
                Path = ExportPath
            };
            CreateExportRequest createExportRequest = new CreateExportRequest
            {
                CreateExportDetails = createExportDetails
            };
            CreateExportResponse createResponse = await fsClient.CreateExport(createExportRequest,
                new RetryConfiguration
                {
                    MaxAttempts = 5
                });
            logger.Info($"Created Export");

            logger.Info($"Waiting for export to become available");
            GetExportRequest getRequest = new GetExportRequest
            {
                ExportId = createResponse.Export.Id
            };
            GetExportResponse getExportResponse = fsClient.Waiters.ForExport(getRequest, Export.LifecycleStateEnum.Active).Execute();
            logger.Info($"Export path state: {getExportResponse.Export.LifecycleState}");

            return getExportResponse.Export;
        }

        /**
        * Creates a point in time snapshot of a file system and waits for it to become available. Note that snapshot
        * names are immutable and must be unique amongst all non-DELETED snapshots for a file system.
        *
        * We recommend using a retry token on these requests so that if you receive a timeout or server error
        * and need to retry the request you won't run the risk of creating multiple resources.
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param fileSystem the file system to create the snapshot of
        */
        private static async Task<Snapshot> CreateSnapshot(FileStorageClient fsClient, FileSystem fileSystem)
        {
            logger.Info("Creating Snapshot...");

            CreateSnapshotDetails createSnapshotDetails = new CreateSnapshotDetails
            {
                FileSystemId = fileSystem.Id,
                Name = "example_snapshot"
            };
            CreateSnapshotRequest createRequest = new CreateSnapshotRequest
            {
                CreateSnapshotDetails = createSnapshotDetails
            };
            CreateSnapshotResponse createResponse = await fsClient.CreateSnapshot(createRequest);
            logger.Info($"Created snapshot: {createResponse.Snapshot.Name}");

            logger.Info($"Waiting for snapshot to become available");
            GetSnapshotRequest getRequest = new GetSnapshotRequest
            {
                SnapshotId = createResponse.Snapshot.Id
            };
            GetSnapshotResponse getResponse = fsClient.Waiters.ForSnapshot(getRequest, Snapshot.LifecycleStateEnum.Active).Execute();
            logger.Info($"Snapshot state: {getResponse.Snapshot.LifecycleState}");

            return getResponse.Snapshot;
        }

        /**
        * Demonstrates how to list exports and using various criteria. Note that listing exports is a paginated call, so we should
        * get all pages until there is no more opcNextPage token
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param compartmentId the OCID of the compartment which owns the resources
        * @param fileSystem the file system which we're working with
        * @param mountTarget the mount target which we're working with
        */
        private static void ListExports(FileStorageClient fsClient, String compartmentId, FileSystem fileSystem, MountTarget mountTarget)
        {
            // The most basic call is to list exports by comparment ID
            ListExportsRequest listExportsRequest = new ListExportsRequest
            {
                CompartmentId = compartmentId
            };

            logger.Info("Listing exports by compartment ID");
            IterateExports(fsClient, listExportsRequest);

            // We can find all exports in a given export set
            listExportsRequest.ExportSetId = mountTarget.ExportSetId;
            logger.Info("Listing exports by export set");
            IterateExports(fsClient, listExportsRequest);

            // We can find all exports for a given file system
            listExportsRequest.ExportSetId = null;
            listExportsRequest.FileSystemId = fileSystem.Id;
            logger.Info("Listing exports by file system");
            IterateExports(fsClient, listExportsRequest);
        }

        /**
        * Deletes a snapshot and waits for it to be deleted.
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param snapshot the snapshot to delete
        */
        private static async Task DeleteSnapshot(FileStorageClient fsClient, Snapshot snapshot)
        {
            logger.Info("Deleting snapshot");

            DeleteSnapshotRequest deleteSnapshotRequest = new DeleteSnapshotRequest
            {
                SnapshotId = snapshot.Id
            };
            await fsClient.DeleteSnapshot(deleteSnapshotRequest);

            GetSnapshotRequest getSnapshotRequest = new GetSnapshotRequest
            {
                SnapshotId = snapshot.Id
            };
            fsClient.Waiters.ForSnapshot(getSnapshotRequest, Snapshot.LifecycleStateEnum.Deleted).Execute();
        }

        /**
        * Deletes an export and waits for it to be deleted.
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param export the export to delete
        */
        private static async Task DeleteExport(FileStorageClient fsClient, Export export)
        {
            logger.Info("Deleting export");

            DeleteExportRequest deleteExportRequest = new DeleteExportRequest
            {
                ExportId = export.Id
            };
            await fsClient.DeleteExport(deleteExportRequest);

            GetExportRequest getExportRequest = new GetExportRequest
            {
                ExportId = export.Id
            };
            fsClient.Waiters.ForExport(getExportRequest, Export.LifecycleStateEnum.Deleted).Execute();
        }

        /**
        * Deletes a mount target and waits for it to be deleted.
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param mountTarget the mount target to delete
        */
        private static async Task DeleteMountTarget(FileStorageClient fsClient, MountTarget mountTarget)
        {
            logger.Info("Deleting mount target");

            DeleteMountTargetRequest deleteRequest = new DeleteMountTargetRequest
            {
                MountTargetId = mountTarget.Id
            };
            await fsClient.DeleteMountTarget(deleteRequest);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetMountTargetRequest getRequest = new GetMountTargetRequest
            {
                MountTargetId = mountTarget.Id
            };
            fsClient.Waiters.ForMountTarget(getRequest, waiterConfiguration, MountTarget.LifecycleStateEnum.Deleted).Execute();
        }

        /**
        * Deletes a file system and waits for it to be deleted.
        *
        * @param fsClient the service client used to communicate with the File Storage service
        * @param fileSystem the file system to delete
        */
        private static async Task DeleteFileSystem(FileStorageClient fsClient, FileSystem fileSystem)
        {
            logger.Info("Deleting file system");

            DeleteFileSystemRequest deleteRequest = new DeleteFileSystemRequest
            {
                FileSystemId = fileSystem.Id
            };
            await fsClient.DeleteFileSystem(deleteRequest);

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetFileSystemRequest getRequest = new GetFileSystemRequest
            {
                FileSystemId = fileSystem.Id
            };
            fsClient.Waiters.ForFileSystem(getRequest, waiterConfiguration, FileSystem.LifecycleStateEnum.Deleted).Execute();
        }

        /**
        * Retrieves a list of availability domains in a compartment.
        *
        * @param identityClient the client to use to retrieve the availability domains
        * @param compartmentId the OCID of the compartment whose availability domains we're listing
        *
        * @return a availability domain
        */
        private static async Task<AvailabilityDomain> GetAvailabilityDomain(IdentityClient identityClient, string compartmentId)
        {
            ListAvailabilityDomainsRequest listAvailabilityDomainsRequest = new ListAvailabilityDomainsRequest
            {
                CompartmentId = compartmentId
            };
            ListAvailabilityDomainsResponse listAvailabilityDomainsResponse = await identityClient.ListAvailabilityDomains(listAvailabilityDomainsRequest);

            foreach (AvailabilityDomain ad in listAvailabilityDomainsResponse.Items)
            {
                if (ad.Name.Equals("Iocq:PHX-AD-2"))
                {
                    return ad;
                }
            }
            return listAvailabilityDomainsResponse.Items[0];
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
        * Creates a subnet in a VCN and waits for the subnet to become available to use.
        *
        * @param virtualNetworkClient the service client to use to create the subnet
        * @param compartmentId the OCID of the compartment which owns the VCN
        * @param availabilityDomain the availability domain where the subnet will be created
        * @param vcn the VCN which will own the subnet
        *
        * @return the created subnet
        */
        private static async Task<Subnet> CreateSubnet(VirtualNetworkClient virtualNetworkClient, string compartmentId,
            AvailabilityDomain availabilityDomain, Vcn vcn)
        {
            logger.Info("Creating subnet");

            CreateSubnetDetails createSubnetDetails = new CreateSubnetDetails
            {
                AvailabilityDomain = availabilityDomain.Name,
                CompartmentId = compartmentId,
                DisplayName = SubnetDisplayName,
                CidrBlock = CidrBlock,
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
            RetryConfiguration retryConfiguration = new RetryConfiguration
            {
                MaxAttempts = 5
            };
            await virtualNetworkClient.DeleteSubnet(deleteSubnetRequest, retryConfiguration);

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
            DeleteVcnRequest deleteVcnRequest = new DeleteVcnRequest
            {
                VcnId = vcn.Id
            };
            await virtualNetworkClient.DeleteVcn(deleteVcnRequest);

            logger.Info($"Deleted Vcn: {vcn.Id}");
        }

        /**
        * Displays the export paths
        *
        * @param fsClient the service client to use to retrieve the exports
        * @param listExportsRequest contains the parameters and filters to get the exports
        */
        private static void IterateExports(FileStorageClient fsClient, ListExportsRequest listExportsRequest)
        {
            IEnumerable<ExportSummary> exportSummaries = fsClient.Paginators.ListExportsRecordEnumerator(listExportsRequest);
            foreach (ExportSummary exportSummary in exportSummaries)
            {
                logger.Info($"Export path: {exportSummary.Path}");
            }
        }
    }
}
