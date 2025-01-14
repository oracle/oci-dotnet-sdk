/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Metadata required to import wallet to deployment
    /// 
    /// </summary>
    public class ImportDeploymentWalletDetails 
    {
        
        /// <value>
        /// Refers to the customer's vault OCID. 
        /// If provided, it references a vault where GoldenGate can manage secrets. Customers must add policies to permit GoldenGate
        /// to manage secrets contained within this vault.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VaultId is required.")]
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// The OCID of the customer's GoldenGate Service Secret. 
        /// If provided, it references a key that customers will be required to ensure the policies are established 
        /// to permit GoldenGate to use this Secret.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NewWalletSecretId is required.")]
        [JsonProperty(PropertyName = "newWalletSecretId")]
        public string NewWalletSecretId { get; set; }
        
        /// <value>
        /// Name of the secret with which secret is shown in vault
        /// </value>
        [JsonProperty(PropertyName = "walletBackupSecretName")]
        public string WalletBackupSecretName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment, where the secret will be created in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "walletBackupSecretCompartmentId")]
        public string WalletBackupSecretCompartmentId { get; set; }
        
        /// <value>
        /// Refers to the customer's master key OCID. 
        /// If provided, it references a key to manage secrets. Customers must add policies to permit GoldenGate to use this key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "masterEncryptionKeyId")]
        public string MasterEncryptionKeyId { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}
