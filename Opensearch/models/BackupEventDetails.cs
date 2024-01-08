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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// Details about a cluster backup event.
    /// </summary>
    public class BackupEventDetails 
    {
        
        /// <value>
        /// The OCID of the OpenSearch cluster for the cluster backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterId is required.")]
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
        
        /// <value>
        /// The result of the cluster backup operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupState is required.")]
        [JsonProperty(PropertyName = "backupState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BackupState> BackupState { get; set; }
        
        /// <value>
        /// The name of the cluster backup.
        /// </value>
        [JsonProperty(PropertyName = "snapshotName")]
        public string SnapshotName { get; set; }
        
        /// <value>
        /// The date and time the cluster backup event started. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the cluster backup event started. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnded is required.")]
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// The cluster backup size in GB.
        /// </value>
        [JsonProperty(PropertyName = "backupSize")]
        public System.Double BackupSize { get; set; }
        
    }
}
