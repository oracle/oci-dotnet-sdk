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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary data for a range of AWR snapshots.
    /// </summary>
    public class AwrDbSnapshotRangeSummary 
    {
        
        /// <value>
        /// The internal ID of the database. The internal ID of the database is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrDbId is required.")]
        [JsonProperty(PropertyName = "awrDbId")]
        public string AwrDbId { get; set; }
        
        /// <value>
        /// The name of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The unique name of the database.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The internal ID of the database where the AWR snapshot data was collected.
        /// </value>
        [JsonProperty(PropertyName = "srcDbId")]
        public string SrcDbId { get; set; }
        
        /// <value>
        /// The name of the database where the AWR snapshot data was collected.
        /// </value>
        [JsonProperty(PropertyName = "srcDbName")]
        public string SrcDbName { get; set; }
        
        /// <value>
        /// The database instance numbers.
        /// </value>
        [JsonProperty(PropertyName = "instanceList")]
        public System.Collections.Generic.List<int> InstanceList { get; set; }
        
        /// <value>
        /// The timestamp of the database startup.
        /// </value>
        [JsonProperty(PropertyName = "timeDbStartup")]
        public System.Nullable<System.DateTime> TimeDbStartup { get; set; }
        
        /// <value>
        /// The start time of the earliest snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSnapshotBegin")]
        public System.Nullable<System.DateTime> TimeFirstSnapshotBegin { get; set; }
        
        /// <value>
        /// The end time of the latest snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeLatestSnapshotEnd")]
        public System.Nullable<System.DateTime> TimeLatestSnapshotEnd { get; set; }
        
        /// <value>
        /// The ID of the earliest snapshot. The snapshot ID is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs/{awrDbId}/awrDbSnapshots
        /// 
        /// </value>
        [JsonProperty(PropertyName = "firstSnapshotId")]
        public System.Nullable<int> FirstSnapshotId { get; set; }
        
        /// <value>
        /// The ID of the latest snapshot. The snapshot ID is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs/{awrDbId}/awrDbSnapshots
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latestSnapshotId")]
        public System.Nullable<int> LatestSnapshotId { get; set; }
        
        /// <value>
        /// The total number of snapshots.
        /// </value>
        [JsonProperty(PropertyName = "snapshotCount")]
        public System.Nullable<long> SnapshotCount { get; set; }
        
        /// <value>
        /// The interval time between snapshots (in minutes).
        /// </value>
        [JsonProperty(PropertyName = "snapshotIntervalInMin")]
        public System.Nullable<int> SnapshotIntervalInMin { get; set; }
        
        /// <value>
        /// ID of the database container. The database container ID is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbSnapshotRanges
        /// 
        /// </value>
        [JsonProperty(PropertyName = "containerId")]
        public System.Nullable<int> ContainerId { get; set; }
        
        /// <value>
        /// The version of the database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The time zone of the snapshot.
        /// </value>
        [JsonProperty(PropertyName = "snapshotTimezone")]
        public string SnapshotTimezone { get; set; }
        
    }
}
