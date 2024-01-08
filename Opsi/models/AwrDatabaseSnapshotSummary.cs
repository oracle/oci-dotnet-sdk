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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The AWR snapshot summary of one snapshot.
    /// </summary>
    public class AwrDatabaseSnapshotSummary 
    {
        
        /// <value>
        /// Internal ID of the database. The internal ID of the database is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDatabases
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrSourceDatabaseIdentifier is required.")]
        [JsonProperty(PropertyName = "awrSourceDatabaseIdentifier")]
        public string AwrSourceDatabaseIdentifier { get; set; }
        
        /// <value>
        /// The database instance number.
        /// </value>
        [JsonProperty(PropertyName = "instanceNumber")]
        public System.Nullable<int> InstanceNumber { get; set; }
        
        /// <value>
        /// The timestamp of the database startup.
        /// </value>
        [JsonProperty(PropertyName = "timeDbStartup")]
        public System.Nullable<System.DateTime> TimeDbStartup { get; set; }
        
        /// <value>
        /// The start time of the snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeBegin")]
        public System.Nullable<System.DateTime> TimeBegin { get; set; }
        
        /// <value>
        /// The end time of the snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The ID of the snapshot. The snapshot identifier is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDbSnapshots
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapshotIdentifier is required.")]
        [JsonProperty(PropertyName = "snapshotIdentifier")]
        public System.Nullable<int> SnapshotIdentifier { get; set; }
        
        /// <value>
        /// The total number of errors.
        /// </value>
        [JsonProperty(PropertyName = "errorCount")]
        public System.Nullable<long> ErrorCount { get; set; }
        
    }
}
