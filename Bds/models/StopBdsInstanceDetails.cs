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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The request body for stopping a BDS cluster.
    /// </summary>
    public class StopBdsInstanceDetails 
    {
        
        /// <value>
        /// Boolean indicating whether to force stop jobs while stopping cluster. Defaults to false.
        /// </value>
        [JsonProperty(PropertyName = "isForceStopJobs")]
        public System.Nullable<bool> IsForceStopJobs { get; set; }
        
        /// <value>
        /// Base-64 encoded password for the cluster admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
    }
}
