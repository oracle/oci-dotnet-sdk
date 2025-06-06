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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// Creates a vault replica.
    /// </summary>
    public class CreateVaultReplicaDetails 
    {
        
        /// <value>
        /// The region in the realm to which the vault need to be replicated to
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReplicaRegion is required.")]
        [JsonProperty(PropertyName = "replicaRegion")]
        public string ReplicaRegion { get; set; }
        
        [JsonProperty(PropertyName = "replicaVaultMetadata")]
        public ReplicaVaultMetadata ReplicaVaultMetadata { get; set; }
        
    }
}
