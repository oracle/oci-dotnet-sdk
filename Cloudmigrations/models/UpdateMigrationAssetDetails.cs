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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Details of the updated migration asset.
    /// </summary>
    public class UpdateMigrationAssetDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Replication schedule identifier
        /// </value>
        [JsonProperty(PropertyName = "replicationScheduleId")]
        public string ReplicationScheduleId { get; set; }
        
        /// <value>
        /// List of migration assets that depends on this asset.
        /// </value>
        [JsonProperty(PropertyName = "dependsOn")]
        public System.Collections.Generic.List<string> DependsOn { get; set; }
        
    }
}
