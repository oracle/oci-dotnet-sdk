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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// Reference to an object in object storage as a tuple. The usage data file uploaded to object storage must be a gzip archive
    /// of the JSON usage data returned from the GraalVM native-image-inspect tool after a native-image build.
    /// 
    /// </summary>
    public class UsageDataViaObjectStorageTupleDetails : UsageDataDetails
    {
        
        /// <value>
        /// The Object Storage bucket to read the usage data from.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The Object Storage namespace to read the usage data from.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The Object Storage object name to read the usage data from.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "objectStorageTuple";
    }
}
