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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Creation details for an Object Storage bucket that contains Terraform configuration files.
    /// 
    /// </summary>
    public class CreateObjectStorageConfigSourceDetails : CreateConfigSourceDetails
    {
        
        /// <value>
        /// The name of the bucket's region.
        /// Example: us-phoenix-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// The Object Storage namespace that contains the bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The name of the bucket that contains the Terraform configuration files.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        [JsonProperty(PropertyName = "configSourceType")]
        private readonly string configSourceType = "OBJECT_STORAGE_CONFIG_SOURCE";
    }
}
