/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// In lieu of a network database link, OCI Object Storage bucket will be used to store Data Pump dump files for the migration.
    /// 
    /// </summary>
    public class ObjectStoreBucket 
    {
        
        /// <value>
        /// Namespace name of the object store bucket.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Bucket name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
    }
}
