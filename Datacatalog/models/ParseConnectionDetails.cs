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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Parse connections from the connection metadata and Oracle wallet file.
    /// An error will be returned if more than one of connectionPayload, walletSecretId or walletSecretName are present in the request.
    /// 
    /// </summary>
    public class ParseConnectionDetails 
    {
        
        [JsonProperty(PropertyName = "connectionDetail")]
        public Connection ConnectionDetail { get; set; }
        
        /// <value>
        /// The information used to parse the connection from the wallet file payload.
        /// </value>
        [JsonProperty(PropertyName = "connectionPayload")]
        public System.Byte[] ConnectionPayload { get; set; }
        
        /// <value>
        /// OCID of the OCI Vault secret holding the Oracle wallet to parse.
        /// </value>
        [JsonProperty(PropertyName = "walletSecretId")]
        public string WalletSecretId { get; set; }
        
        /// <value>
        /// Name of the OCI Vault secret holding the Oracle wallet to parse.
        /// </value>
        [JsonProperty(PropertyName = "walletSecretName")]
        public string WalletSecretName { get; set; }
        
    }
}
