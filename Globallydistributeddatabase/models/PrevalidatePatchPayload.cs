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


namespace Oci.GloballydistributeddatabaseService.Models
{
    /// <summary>
    /// Payload to prevalidate patch sharded database operation.
    /// 
    /// </summary>
    public class PrevalidatePatchPayload : PrevalidatePayload
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrevalidatePayload is required.")]
        [JsonProperty(PropertyName = "prevalidatePayload")]
        public PatchShardedDatabaseDetails PrevalidatePayload { get; set; }
        
        /// <value>
        /// Sharded database identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardedDatabaseId is required.")]
        [JsonProperty(PropertyName = "shardedDatabaseId")]
        public string ShardedDatabaseId { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "PATCH";
    }
}
