/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of the new migration asset.
    /// </summary>
    public class CreateMigrationAssetDetails 
    {
        
        /// <value>
        /// A user-friendly name. If empty, then source asset name will be used. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of an asset for an inventory.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InventoryAssetId is required.")]
        [JsonProperty(PropertyName = "inventoryAssetId")]
        public string InventoryAssetId { get; set; }
        
        /// <value>
        /// OCID of the associated migration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MigrationId is required.")]
        [JsonProperty(PropertyName = "migrationId")]
        public string MigrationId { get; set; }
        
        /// <value>
        /// Replication schedule identifier
        /// </value>
        [JsonProperty(PropertyName = "replicationScheduleId")]
        public string ReplicationScheduleId { get; set; }
        
        /// <value>
        /// Availability domain
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Replication compartment identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReplicationCompartmentId is required.")]
        [JsonProperty(PropertyName = "replicationCompartmentId")]
        public string ReplicationCompartmentId { get; set; }
        
        /// <value>
        /// Name of snapshot bucket
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapShotBucketName is required.")]
        [JsonProperty(PropertyName = "snapShotBucketName")]
        public string SnapShotBucketName { get; set; }
        
        /// <value>
        /// List of migration assets that depends on this asset.
        /// </value>
        [JsonProperty(PropertyName = "dependsOn")]
        public System.Collections.Generic.List<string> DependsOn { get; set; }
        
    }
}