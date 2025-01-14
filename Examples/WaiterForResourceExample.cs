/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;

using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.CoreService;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;

namespace Oci.Examples
{
    /**
    * This class demonstrates how to use waiter for a resource by Copying a Boot Volume backup from one region to another region.
    */

    public class WaiterExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        const string OciConfigSourceProfileName = "DEFAULT";
        const string OciConfigDestinationProfileName = "DEST";
        public static async Task MainWaiter()
        {
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigSourceProfileName);
            string bootVolumeBackup = Environment.GetEnvironmentVariable("OCI_BOOT_VOLUME_BACKUP_ID");
            string destinationRegion = Environment.GetEnvironmentVariable("OCI_DESTINATION_REGION");

            // Create clients for the service to enable using its APIs
            var blockStorageClient = new BlockstorageClient(provider, new ClientConfiguration());
            try
            {
                // Copy Boot Volume backup
                var backupCopyId = await CopyBootVolumeBackup(blockStorageClient, bootVolumeBackup, destinationRegion);
                logger.Info($"Create backup copy with OCID:{backupCopyId}");

                // Create new client for making a retrying call for new backup copy in destination region
                var destinationProvider = new ConfigFileAuthenticationDetailsProvider(OciConfigDestinationProfileName);
                blockStorageClient = new BlockstorageClient(destinationProvider, new ClientConfiguration());
                var state = GetBootVolumeBackup(blockStorageClient, backupCopyId);

                logger.Info($"Successfully create backup copy with Lifecyle State:{state}");

                // Delete the backup copy for cleanup
                await DeleteBootVolumeBackup(blockStorageClient, backupCopyId);
            }
            catch (Exception e)
            {
                logger.Info($"Received exception due to {e.Message}");
            }
            finally
            {
                blockStorageClient.Dispose();
            }
        }

        private static async Task<string> CopyBootVolumeBackup(BlockstorageClient client, string bootVolumeBackupId, string destinationRegion)
        {
            CopyBootVolumeBackupRequest copyBootVolumeBackupRequest = new CopyBootVolumeBackupRequest
            {
                BootVolumeBackupId = bootVolumeBackupId,
                CopyBootVolumeBackupDetails = new CopyBootVolumeBackupDetails
                {
                    DestinationRegion = destinationRegion,
                    DisplayName = "Backup-copy-example"
                }
            };

            // Pass copyBootVolumeBackupRequest to client to create the boot volume backup
            logger.Info($"Creating backup at {destinationRegion}");
            logger.Info("=============");
            CopyBootVolumeBackupResponse copyBootVolumeBackupResponse = await client.CopyBootVolumeBackup(copyBootVolumeBackupRequest);
            return copyBootVolumeBackupResponse.BootVolumeBackup.Id;
        }

        private static BootVolumeBackup.LifecycleStateEnum GetBootVolumeBackup(BlockstorageClient client, string bootVolumeBackupId)
        {
            GetBootVolumeBackupRequest getBootVolumeBackupRequest = new GetBootVolumeBackupRequest
            {
                BootVolumeBackupId = bootVolumeBackupId
            };

            WaiterConfiguration waiterConfiguration = new WaiterConfiguration
            {
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds,
                MaxAttempts = 30
            };

            GetBootVolumeBackupResponse getBootVolumeBackupResponse =
                client.Waiters.ForBootVolumeBackup(getBootVolumeBackupRequest,
                    waiterConfiguration, new BootVolumeBackup.LifecycleStateEnum[] { BootVolumeBackup.LifecycleStateEnum.Available }).Execute();
            return getBootVolumeBackupResponse.BootVolumeBackup.LifecycleState.Value;
        }

        private static async Task DeleteBootVolumeBackup(BlockstorageClient client, string bootVolumeBackupId)
        {
            DeleteBootVolumeBackupRequest deleteBootVolumeBackupRequest = new DeleteBootVolumeBackupRequest
            {
                BootVolumeBackupId = bootVolumeBackupId
            };
            // Delete the boot volume backup
            logger.Info($"Deleting backup with id {bootVolumeBackupId}");
            logger.Info("=============");
            await client.DeleteBootVolumeBackup(deleteBootVolumeBackupRequest);
            logger.Info("Backup deleted!");
        }
    }
}
