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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define meta data for a cluster.
    /// </summary>
    public class ClusterMetadata 
    {
        
        /// <value>
        /// The time the cluster was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The user who created the cluster.
        /// </value>
        [JsonProperty(PropertyName = "createdByUserId")]
        public string CreatedByUserId { get; set; }
        
        /// <value>
        /// The OCID of the work request which created the cluster.
        /// </value>
        [JsonProperty(PropertyName = "createdByWorkRequestId")]
        public string CreatedByWorkRequestId { get; set; }
        
        /// <value>
        /// The time the cluster was deleted.
        /// </value>
        [JsonProperty(PropertyName = "timeDeleted")]
        public System.Nullable<System.DateTime> TimeDeleted { get; set; }
        
        /// <value>
        /// The user who deleted the cluster.
        /// </value>
        [JsonProperty(PropertyName = "deletedByUserId")]
        public string DeletedByUserId { get; set; }
        
        /// <value>
        /// The OCID of the work request which deleted the cluster.
        /// </value>
        [JsonProperty(PropertyName = "deletedByWorkRequestId")]
        public string DeletedByWorkRequestId { get; set; }
        
        /// <value>
        /// The time the cluster was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The user who updated the cluster.
        /// </value>
        [JsonProperty(PropertyName = "updatedByUserId")]
        public string UpdatedByUserId { get; set; }
        
        /// <value>
        /// The OCID of the work request which updated the cluster.
        /// </value>
        [JsonProperty(PropertyName = "updatedByWorkRequestId")]
        public string UpdatedByWorkRequestId { get; set; }
        
        /// <value>
        /// The time until which the cluster credential is valid.
        /// </value>
        [JsonProperty(PropertyName = "timeCredentialExpiration")]
        public System.Nullable<System.DateTime> TimeCredentialExpiration { get; set; }
        
    }
}
