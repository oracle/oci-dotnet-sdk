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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The details of a replication source bucket that replicates to a target destination bucket.
    /// </summary>
    public class ReplicationSource 
    {
        
        /// <value>
        /// The name of the policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyName is required.")]
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; set; }
        
        /// <value>
        /// The source region replicating data from, for example \"us-ashburn-1\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceRegionName is required.")]
        [JsonProperty(PropertyName = "sourceRegionName")]
        public string SourceRegionName { get; set; }
        
        /// <value>
        /// The source bucket replicating data from.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceBucketName is required.")]
        [JsonProperty(PropertyName = "sourceBucketName")]
        public string SourceBucketName { get; set; }
        
    }
}
