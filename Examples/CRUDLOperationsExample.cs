/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.KeymanagementService;
using Oci.KeymanagementService.Models;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;

namespace Oci.Examples
{
    /**
    * This class demonstrates how to create, retrieve, update, list and delete Key operations
    *
    * This example assumes you already have a Vault in ACTIVE state. If you need to create a new Vault, please
    * refer to the createVaultTest method in this class. Please keep in mind that KMS does not support immediate
    * deletion of Vaults because of the high risk; instead, you need to schedule the deletion of a Vault and a
    * retention period of 7-30 days will be enforced before the Vault is deleted. During the retention period, you
    * can cancel the deletion and the Vault will be ACTIVE again. Be careful before creating a Vault to avoid
    * unnecessary expenses.
    */

    public class CRUDLOperationsExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static int DefaultKeyLength = 32;

        static CRUDLOperationsExample()
        {
            Environment.SetEnvironmentVariable("OCI_COMPARTMENT_ID", "ocid1.tenancy.oc1..aaaaaaaa3vi3ft3yi3sq4nhiql4nvbzjz6gipbn72h7werl6njs6xsq4wgdq");
            Environment.SetEnvironmentVariable("VAULT_ID", "ocid1.vault.oc1.phx.a5pmf4yfaafna.abyhqljs6zn75nbutbeaxyqy5jcmacalqwr35i7owm5hxdsbnwodi65p44ba");
        }

        public static async Task MainCRUDLOperations()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var vaultId = Environment.GetEnvironmentVariable("VAULT_ID");

            KmsVaultClient kmsVaultClient = null;
            KmsManagementClient kmsManagementClient = null;

            try
            {
                // Initialize the KMS Clients. KMS has three clients as following:
                //      * KmsVaultClient: The client for Vault management
                //      * KmsManagementClient: The client for Key management (ControlPlane)
                kmsVaultClient = new KmsVaultClient(provider);
                kmsManagementClient = new KmsManagementClient(provider);

                Vault vault = await GetVault(kmsVaultClient, vaultId);

                // The ManagementClient use Vault specific endpoints
                kmsManagementClient.SetEndpoint(vault.ManagementEndpoint);

                var waiterConfiguration = new WaiterConfiguration
                {
                    MaxAttempts = 10,
                    GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
                };

                // CRUDL operations
                string keyId = await CreateKey(kmsManagementClient, compartmentId);
                // After creating a Key, the Key will stay in CREATING state shortly and then
                // transit to ENABLED state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for Key creation to finish");
                GetKeyRequest getKeyRequest = new GetKeyRequest
                {
                    KeyId = keyId
                };
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

                await GetKey(kmsManagementClient, keyId);

                await UpdateKeyResetTags(kmsManagementClient, keyId);
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

                await UpdateKey(kmsManagementClient, keyId);
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

                await ListKeys(kmsManagementClient, compartmentId);

                await ScheduleKeyDeletion(kmsManagementClient, keyId);
                // After scheduling deletion, the Key will stay in SCHEDULING_DELETION state shortly and then
                // transit to PENDING_DELETION state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for deletion scheduling to finish");
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.PendingDeletion).Execute();
            }
            catch (Exception e)
            {
                logger.Error($"Failed to perform operations on Vault: {e}");
            }
            finally
            {
                if (kmsVaultClient != null)
                {
                    kmsVaultClient.Dispose();
                }

                if (kmsManagementClient != null)
                {
                    kmsManagementClient.Dispose();
                }
            }

            logger.Info("End example");
        }

        private static async Task<Vault> GetVault(KmsVaultClient kmsVaultClient, string vaultId)
        {
            logger.Info("Get Vault");

            GetVaultRequest getVaultRequest = new GetVaultRequest
            {
                VaultId = vaultId
            };
            GetVaultResponse getVaultResponse = await kmsVaultClient.GetVault(getVaultRequest);

            logger.Info($"Retrieved vault: {getVaultResponse.Vault.DisplayName}");
            return getVaultResponse.Vault;
        }

        private static async Task<string> CreateKey(KmsManagementClient kmsManagementClient, string compartmentId)
        {
            logger.Info("Creating Key");

            KeyShape keyShape = new KeyShape
            {
                Algorithm = KeyShape.AlgorithmEnum.Aes,
                Length = DefaultKeyLength
            };
            CreateKeyDetails createKeyDetails = new CreateKeyDetails
            {
                KeyShape = keyShape,
                CompartmentId = compartmentId,
                DisplayName = "DotNet-SDK-Key-CRUDL-test",
                FreeformTags = GetSampleFreeformTagData()
            };
            CreateKeyRequest createKeyRequest = new CreateKeyRequest
            {
                CreateKeyDetails = createKeyDetails
            };
            CreateKeyResponse createKeyResponse = await kmsManagementClient.CreateKey(createKeyRequest);

            logger.Info($"Created new key: {createKeyResponse.Key.DisplayName}");
            return createKeyResponse.Key.Id;
        }

        private static async Task GetKey(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Get Key");

            GetKeyRequest getKeyRequest = new GetKeyRequest
            {
                KeyId = keyId
            };
            GetKeyResponse getKeyResponse = await kmsManagementClient.GetKey(getKeyRequest);

            logger.Info($"Key Retrieved: {getKeyResponse.Key.DisplayName}");
        }

        public static async Task UpdateKeyResetTags(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Update Key");

            Dictionary<string, string> freeformTags = new Dictionary<string, string>();
            UpdateKeyDetails updateKeyDetails = new UpdateKeyDetails
            {
                DisplayName = "update-key-name",
                FreeformTags = freeformTags
            };
            UpdateKeyRequest updateKeyRequest = new UpdateKeyRequest
            {
                UpdateKeyDetails = updateKeyDetails,
                KeyId = keyId
            };
            UpdateKeyResponse updateKeyResponse = await kmsManagementClient.UpdateKey(updateKeyRequest);

            logger.Info($"Updated key with empty tags: {updateKeyResponse.Key.DisplayName}");
        }

        public static async Task UpdateKey(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Update Key");

            Dictionary<string, string> freeformTags = GetSampleFreeformTagData();
            freeformTags.Add("dummyfreeformkey3", "dummyfreeformvalue3");

            UpdateKeyDetails updateKeyDetails = new UpdateKeyDetails
            {
                DisplayName = "update-key-name",
                FreeformTags = freeformTags
            };
            UpdateKeyRequest updateKeyRequest = new UpdateKeyRequest
            {
                UpdateKeyDetails = updateKeyDetails,
                KeyId = keyId
            };
            UpdateKeyResponse updateKeyResponse = await kmsManagementClient.UpdateKey(updateKeyRequest);

            logger.Info($"Updated key with freeform tags: {updateKeyResponse.Key.DisplayName}");
        }

        private static async Task ListKeys(KmsManagementClient kmsManagementClient, string compartmentId)
        {
            logger.Info("List Keys");

            ListKeysRequest listKeysRequest = new ListKeysRequest
            {
                CompartmentId = compartmentId
            };
            ListKeysResponse listKeysResponse = await kmsManagementClient.ListKeys(listKeysRequest);

            logger.Info("Retrieved keys");
            foreach (var key in listKeysResponse.Items)
            {
                logger.Info($"Key: {key.DisplayName}");
            }
        }

        private static async Task ScheduleKeyDeletion(KmsManagementClient kmsManagementClient, string keyId)
        {
            ScheduleKeyDeletionDetails scheduleKeyDeletionDetails = new ScheduleKeyDeletionDetails
            {
                TimeOfDeletion = null
            };
            ScheduleKeyDeletionRequest scheduleKeyDeletionRequest = new ScheduleKeyDeletionRequest
            {
                KeyId = keyId,
                ScheduleKeyDeletionDetails = scheduleKeyDeletionDetails
            };
            ScheduleKeyDeletionResponse scheduleKeyDeletionResponse = await kmsManagementClient.ScheduleKeyDeletion(scheduleKeyDeletionRequest);

            logger.Info($"Key Scheduled deletion Successfully: {scheduleKeyDeletionResponse.Key.DisplayName}");
        }

        private static Dictionary<string, string> GetSampleFreeformTagData()
        {
            Dictionary<string, string> freeformTags = new Dictionary<string, string>();
            freeformTags.Add("dummyfreeformkey1", "dummyfreeformvalue1");
            freeformTags.Add("dummyfreeformkey2", "dummyfreeformvalue2");
            return freeformTags;
        }
    }
}
