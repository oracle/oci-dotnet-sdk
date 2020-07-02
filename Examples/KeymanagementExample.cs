/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    * This class contains examples which cover basic KMS usage.
    *
    * These examples assume you already have a Vault in ACTIVE state. If you need to create a new Vault, please
    * refer to the createVaultTest method in this class. Please keep in mind that KMS does not support immediate
    * deletion of Vaults because of the high risk; instead, you need to schedule the deletion of a Vault and a
    * retention period of 7-30 days will be enforced before the Vault is deleted. During the retention period, you
    * can cancel the deletion and the Vault will be ACTIVE again. Be careful before creating a Vault to avoid
    * unnecessary expenses.
    */

    public class KeyManagementExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static int DefaultKeyLength = 32;

        public static async Task MainKeyManagement()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var vaultId = Environment.GetEnvironmentVariable("VAULT_ID");

            KmsVaultClient kmsVaultClient = null;
            KmsManagementClient kmsManagementClient = null;
            KmsCryptoClient kmsCryptoClient = null;

            try
            {
                // Initialize the KMS Clients. KMS has three clients as following:
                //      * KmsVaultClient: The client for Vault management
                //      * KmsManagementClient: The client for Key management (ControlPlane)
                //      * KmsCryptoClient: The client for data encryption and decryption (DataPlane)
                kmsVaultClient = new KmsVaultClient(provider);
                kmsManagementClient = new KmsManagementClient(provider);
                kmsCryptoClient = new KmsCryptoClient(provider);

                Vault vault = await GetVault(kmsVaultClient, vaultId);

                // The ManagementClient and CryptoClient use Vault specific endpoints; Set them now.
                kmsManagementClient.SetEndpoint(vault.ManagementEndpoint);
                kmsCryptoClient.SetEndpoint(vault.CryptoEndpoint);

                // Vault Operations
                await UpdateVaultResetTags(kmsVaultClient, vault.Id);
                await UpdateVault(kmsVaultClient, vault.Id);
                await ListVaults(kmsVaultClient, compartmentId);
                await ScheduleVaultDeletion(kmsVaultClient, vault.Id);

                var waiterConfiguration = new WaiterConfiguration
                {
                    MaxAttempts = 10,
                    GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
                };

                // After scheduling deletion, the Vault will stay in SCHEDULING_DELETION state shortly and then
                // transit to PENDING_DELETION state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for the deletion scheduling to finish");
                GetVaultRequest getVaultRequest = new GetVaultRequest
                {
                    VaultId = vault.Id
                };
                kmsVaultClient.Waiters.ForVault(getVaultRequest, waiterConfiguration, Vault.LifecycleStateEnum.PendingDeletion).Execute();

                await CancelVaultDeletion(kmsVaultClient, vault.Id);
                // After cancelling deletion, the Vault will stay in CANCELLING_DELETION state shortly and then
                // transit to ACTIVE state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for the deletion cancelling to finish");
                kmsVaultClient.Waiters.ForVault(getVaultRequest, waiterConfiguration, Vault.LifecycleStateEnum.Active).Execute();

                // Management / Key Operations
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
                await DisableKey(kmsManagementClient, keyId);
                // After disabling a Key, the Key will stay in DISABLING state shortly and then
                // transit to DISABLED state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for Key disabling to finish");
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Disabled).Execute();

                await EnableKey(kmsManagementClient, keyId);
                // After enabling a Key, the Key will stay in ENABLING state shortly and then
                // transit to ENABLED state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for Key enabling to finish");
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

                await ScheduleKeyDeletion(kmsManagementClient, keyId);
                // After scheduling deletion, the Key will stay in SCHEDULING_DELETION state shortly and then
                // transit to PENDING_DELETION state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for deletion scheduling to finish");
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.PendingDeletion).Execute();

                await CancelKeyDeletion(kmsManagementClient, keyId);
                // After cancelling deletion, the Key will stay in CANCELLING_DELETION state shortly and then
                // transit to Enabled state. Wait a bit for the transition to happen.
                logger.Info("Wait a bit for deletion cancelling to finish");
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

                await CreateKeyVersion(kmsManagementClient, keyId);
                await ListKeyVersions(kmsManagementClient, keyId);

                // Crypto Operations
                string cipherText = await Encrypt(kmsCryptoClient, keyId);
                await Decrypt(kmsCryptoClient, keyId, cipherText);
                await GenerateDataEncryptionKey(kmsCryptoClient, keyId);
                kmsManagementClient.Waiters.ForKey(getKeyRequest, waiterConfiguration, Key.LifecycleStateEnum.Enabled).Execute();

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

                if (kmsCryptoClient != null)
                {
                    kmsCryptoClient.Dispose();
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

        private static async Task ListVaults(KmsVaultClient kmsVaultClient, string compartmentId)
        {
            logger.Info("List Vaults");

            ListVaultsRequest listVaultsRequest = new ListVaultsRequest
            {
                CompartmentId = compartmentId
            };
            ListVaultsResponse listVaultsResponse = await kmsVaultClient.ListVaults(listVaultsRequest);

            logger.Info("Retrieved vaults");
            foreach (var response in listVaultsResponse.Items)
            {
                logger.Info($"Vault: {response.DisplayName}");
            }

        }

        private static async Task UpdateVaultResetTags(KmsVaultClient kmsVaultClient, string vaultId)
        {
            logger.Info($"Updating vault");

            Dictionary<string, string> freeformTags = new Dictionary<string, string>();
            UpdateVaultDetails updateVaultDetails = new UpdateVaultDetails
            {
                FreeformTags = freeformTags
            };
            UpdateVaultRequest updateVaultRequest = new UpdateVaultRequest
            {
                UpdateVaultDetails = updateVaultDetails,
                VaultId = vaultId
            };
            UpdateVaultResponse updateVaultResponse = await kmsVaultClient.UpdateVault(updateVaultRequest);

            logger.Info($"cleared tags for the Vault: {updateVaultResponse.Vault.ToString()}");

        }

        private static async Task UpdateVault(KmsVaultClient kmsVaultClient, string vaultId)
        {
            logger.Info($"Updating vault");

            Dictionary<string, string> freeformTags = new Dictionary<string, string>(){
              {  "freeformkey1", "freeformvalue1" },
              {  "freeformkey2", "freeformvalue2" }
            };
            UpdateVaultDetails updateVaultDetails = new UpdateVaultDetails
            {
                FreeformTags = freeformTags,
                DisplayName = "updated-vault-display-name"
            };
            UpdateVaultRequest updateVaultRequest = new UpdateVaultRequest
            {
                UpdateVaultDetails = updateVaultDetails,
                VaultId = vaultId
            };
            UpdateVaultResponse updateVaultResponse = await kmsVaultClient.UpdateVault(updateVaultRequest);

            logger.Info($"added tags for the vault: {updateVaultResponse.Vault.ToString()}");

        }

        private static async Task ScheduleVaultDeletion(KmsVaultClient kmsVaultClient, string vaultId)
        {
            logger.Info("Schedule Vault Deletion");

            ScheduleVaultDeletionDetails scheduleVaultDeletionDetails = new ScheduleVaultDeletionDetails
            {
                TimeOfDeletion = null
            };
            ScheduleVaultDeletionRequest scheduleVaultDeletionRequest = new ScheduleVaultDeletionRequest
            {
                ScheduleVaultDeletionDetails = scheduleVaultDeletionDetails,
                VaultId = vaultId
            };
            ScheduleVaultDeletionResponse scheduleVaultDeletionResponse = await kmsVaultClient.ScheduleVaultDeletion(scheduleVaultDeletionRequest);

            logger.Info("Deletion Scheduled Successfully");
        }

        private static async Task CancelVaultDeletion(KmsVaultClient kmsVaultClient, string vaultId)
        {
            logger.Info("Cancel Vault Deletion");

            CancelVaultDeletionRequest cancelVaultDeletionRequest = new CancelVaultDeletionRequest
            {
                VaultId = vaultId
            };
            CancelVaultDeletionResponse cancelVaultDeletionResponse = await kmsVaultClient.CancelVaultDeletion(cancelVaultDeletionRequest);

            logger.Info("Deletion cancelled successfully");
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
                DisplayName = "DotNet-SDK-Key-1",
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

            logger.Info($"Updated key: {updateKeyResponse.Key.DisplayName}");

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

            logger.Info($"Updated key: {updateKeyResponse.Key.DisplayName}");

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

        private static async Task DisableKey(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Disable Key");

            DisableKeyRequest disableKeyRequest = new DisableKeyRequest
            {
                KeyId = keyId
            };
            DisableKeyResponse disableKeyResponse = await kmsManagementClient.DisableKey(disableKeyRequest);

            logger.Info($"Key Disabled Successfully: {disableKeyResponse.Key.DisplayName}");
        }

        private static async Task EnableKey(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Enable Key");

            EnableKeyRequest enableKeyRequest = new EnableKeyRequest
            {
                KeyId = keyId
            };
            EnableKeyResponse enableKeyResponse = await kmsManagementClient.EnableKey(enableKeyRequest);

            logger.Info($"Key Disabled Successfully: {enableKeyResponse.Key.DisplayName}");
        }

        private static async Task CancelKeyDeletion(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Cancel Key Deletion");

            CancelKeyDeletionRequest cancelKeyDeletionRequest = new CancelKeyDeletionRequest
            {
                KeyId = keyId
            };
            CancelKeyDeletionResponse cancelKeyDeletionResponse = await kmsManagementClient.CancelKeyDeletion(cancelKeyDeletionRequest);

            logger.Info($"Key Disabled Successfully: {cancelKeyDeletionResponse.Key.DisplayName}");
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

        private static async Task CreateKeyVersion(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("Create Key Version");
            CreateKeyVersionRequest createKeyVersionRequest = new CreateKeyVersionRequest
            {
                KeyId = keyId
            };
            CreateKeyVersionResponse createKeyVersionResponse = await kmsManagementClient.CreateKeyVersion(createKeyVersionRequest);
            logger.Info($"Created key version");
        }

        private static async Task ListKeyVersions(KmsManagementClient kmsManagementClient, string keyId)
        {
            logger.Info("List Key Versions");
            ListKeyVersionsRequest listKeyVersionsRequest = new ListKeyVersionsRequest
            {
                KeyId = keyId
            };
            ListKeyVersionsResponse listKeyVersionsResponse = await kmsManagementClient.ListKeyVersions(listKeyVersionsRequest);
            logger.Info("Retrieved List Key Versions");
            foreach (var keyVersion in listKeyVersionsResponse.Items)
            {
                logger.Info($"Key Version: {keyVersion.Id}");
            }
        }

        private static async Task<string> Encrypt(KmsCryptoClient kmsCryptoClient, string keyId)
        {
            logger.Info("Encrypt");
            string plainText = "I love .NET SDK!";
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            EncryptDataDetails encryptDataDetails = new EncryptDataDetails
            {
                KeyId = keyId,
                Plaintext = System.Convert.ToBase64String(plainTextBytes),
                LoggingContext = GetSampleLoggingContext()
            };
            EncryptRequest encryptRequest = new EncryptRequest
            {
                EncryptDataDetails = encryptDataDetails
            };
            EncryptResponse encryptResponse = await kmsCryptoClient.Encrypt(encryptRequest);

            logger.Info($"PlainText: {plainText}");
            logger.Info($"CipherText: {encryptResponse.EncryptedData.Ciphertext}");
            return encryptResponse.EncryptedData.Ciphertext;
        }

        private static async Task Decrypt(KmsCryptoClient kmsCryptoClient, string keyId, string cipherText)
        {
            logger.Info("Decrypt");
            DecryptDataDetails decryptDataDetails = new DecryptDataDetails
            {
                Ciphertext = cipherText,
                KeyId = keyId,
                LoggingContext = GetSampleLoggingContext()
            };
            DecryptRequest decryptRequest = new DecryptRequest
            {
                DecryptDataDetails = decryptDataDetails
            };
            DecryptResponse decryptResponse = await kmsCryptoClient.Decrypt(decryptRequest);
            logger.Info($"Decrypted text: {decryptResponse.DecryptedData.Plaintext}");

        }

        private static async Task GenerateDataEncryptionKey(KmsCryptoClient kmsCryptoClient, string keyId)
        {
            logger.Info("Generate Data Encryption Key");
            KeyShape keyShape = new KeyShape
            {
                Algorithm = KeyShape.AlgorithmEnum.Aes,
                Length = DefaultKeyLength
            };
            GenerateKeyDetails generateKeyDetails = new GenerateKeyDetails
            {
                KeyId = keyId,
                KeyShape = keyShape,
                IncludePlaintextKey = true,
                LoggingContext = GetSampleLoggingContext()
            };
            GenerateDataEncryptionKeyRequest generateDataEncryptionKeyRequest = new GenerateDataEncryptionKeyRequest
            {
                GenerateKeyDetails = generateKeyDetails
            };
            GenerateDataEncryptionKeyResponse generateDataEncryptionKeyResponse =
                await kmsCryptoClient.GenerateDataEncryptionKey(generateDataEncryptionKeyRequest);
            logger.Info($"Generated Data Encyption key: {generateDataEncryptionKeyResponse.GeneratedKey.Plaintext}");
        }

        private static Dictionary<string, string> GetSampleFreeformTagData()
        {
            Dictionary<string, string> freeformTags = new Dictionary<string, string>();
            freeformTags.Add("dummyfreeformkey1", "dummyfreeformvalue1");
            freeformTags.Add("dummyfreeformkey2", "dummyfreeformvalue2");
            return freeformTags;
        }

        private static Dictionary<string, string> GetSampleLoggingContext()
        {
            Dictionary<string, string> loggingContext = new Dictionary<string, string>();
            loggingContext.Add("loggingContextKey1", "loggingContextValue1");
            loggingContext.Add("loggingContextKey2", "loggingContextValue2");
            return loggingContext;
        }

    }
}
