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


namespace Oci.RecoveryService.Models
{
    /// <summary>
    /// Backup performance and storage utilization metrics for the protected database.
    /// </summary>
    public class Metrics 
    {
        
        /// <value>
        /// Backup storage space, in gigabytes, utilized by the protected database. Oracle charges for the total storage used.
        /// </value>
        [JsonProperty(PropertyName = "backupSpaceUsedInGBs")]
        public System.Nullable<float> BackupSpaceUsedInGBs { get; set; }
        
        /// <value>
        /// The estimated backup storage space, in gigabytes, required to meet the recovery window goal, including foot print and backups for the protected database.
        /// </value>
        [JsonProperty(PropertyName = "backupSpaceEstimateInGBs")]
        public System.Nullable<float> BackupSpaceEstimateInGBs { get; set; }
        
        /// <value>
        /// This is the time window when there is data loss exposure. The point after which recovery is impossible unless additional redo is available. 
        /// This is the time we received the last backup or last redo-log shipped.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unprotectedWindowInSeconds")]
        public System.Nullable<float> UnprotectedWindowInSeconds { get; set; }
        
        /// <value>
        /// The estimated space, in gigabytes, consumed by the protected database. The database size is based on the size of the data files in the catalog, and does not include archive logs.
        /// </value>
        [JsonProperty(PropertyName = "dbSizeInGBs")]
        public System.Nullable<float> DbSizeInGBs { get; set; }
        
        /// <value>
        /// The value TRUE indicates that the protected database is configured to use Real-time data protection, and redo-data is sent from the protected database to Recovery Service.
        /// Real-time data protection substantially reduces the window of potential data loss that exists between successive archived redo log backups.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRedoLogsEnabled")]
        public System.Nullable<bool> IsRedoLogsEnabled { get; set; }
        
        /// <value>
        /// The maximum number of days to retain backups for a protected database.
        /// </value>
        [JsonProperty(PropertyName = "retentionPeriodInDays")]
        public System.Nullable<float> RetentionPeriodInDays { get; set; }
        
        /// <value>
        /// Number of seconds backups are currently retained for this database.
        /// </value>
        [JsonProperty(PropertyName = "currentRetentionPeriodInSeconds")]
        public System.Nullable<float> CurrentRetentionPeriodInSeconds { get; set; }
        
        /// <value>
        /// Number of days of redo/archive to be applied to recover database.
        /// </value>
        [JsonProperty(PropertyName = "minimumRecoveryNeededInDays")]
        public System.Nullable<float> MinimumRecoveryNeededInDays { get; set; }
        
    }
}
