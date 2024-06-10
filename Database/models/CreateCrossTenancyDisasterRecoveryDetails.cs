/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The following are the details necessary to create a cross-tenancy disaster recovery (DR) association for an existing Autonomous Database. This may be in the same region, or in another.
    /// *IMPORTANT*
    /// For creating a standby databases in a cross-tenancy local DR association:
    ///   - To create the standby database in different tenancy, use the compartment OCID in the tenancy where the standby is located.
    ///   - To create the request in the standby database, the sourceId value must be the OCID of the primary database.
    ///   - Creating a ADG DR in the same tenancy and region is not allowed. Use changeDisasterRecoveryConfiguration instead.
    /// The following parameters are required for the cross-tenancy standby database
    ///   - disasterRecoveryType
    /// The following parameters are optional for the cross-tenancy standby database. If included in the request, these parameters must contain the same values as the source Autonomous Database:
    ///   - dbName
    ///   - dbVersion
    ///   - ecpuCount
    ///   - dataStorageSizeInTB
    ///   - customerContacts
    ///   - scheduledOperations
    ///   - isAutoScalingForStorageEnabled
    ///   - definedTags
    ///   - freeformTags
    ///   - licenseModel
    ///   - whitelistedIps
    ///   - isMtlsConnectionRequired
    /// 
    /// </summary>
    public class CreateCrossTenancyDisasterRecoveryDetails : CreateAutonomousDatabaseBase
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the source Autonomous Database that will be used to create a new peer database for the DR association.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceId is required.")]
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// Indicates the disaster recovery (DR) type of the standby Autonomous Database Serverless instance.
        /// Autonomous Data Guard (ADG) DR type provides business critical DR with a faster recovery time objective (RTO) during failover or switchover.
        /// Backup-based DR type provides lower cost DR with a slower RTO during failover or switchover.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisasterRecoveryType is required.")]
        [JsonProperty(PropertyName = "disasterRecoveryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DisasterRecoveryConfiguration.DisasterRecoveryTypeEnum> DisasterRecoveryType { get; set; }
        
        /// <value>
        /// If true, 7 days worth of backups are replicated across regions for Cross-Region ADB or Backup-Based DR between Primary and Standby. If false, the backups taken on the Primary are not replicated to the Standby database.
        /// </value>
        [JsonProperty(PropertyName = "isReplicateAutomaticBackups")]
        public System.Nullable<bool> IsReplicateAutomaticBackups { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        private readonly string source = "CROSS_TENANCY_DISASTER_RECOVERY";
    }
}