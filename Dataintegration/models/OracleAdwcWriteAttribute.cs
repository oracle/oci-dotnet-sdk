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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Properties to configure writing to Oracle Autonomous Data Warehouse Cloud.
    /// </summary>
    public class OracleAdwcWriteAttribute : AbstractWriteAttribute
    {
        
        /// <value>
        /// The bucket name for the attribute.
        /// </value>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The file name for the attribute.
        /// </value>
        [JsonProperty(PropertyName = "stagingFileName")]
        public string StagingFileName { get; set; }
        
        [JsonProperty(PropertyName = "stagingDataAsset")]
        public DataAsset StagingDataAsset { get; set; }
        
        [JsonProperty(PropertyName = "stagingConnection")]
        public Connection StagingConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLEADWCWRITEATTRIBUTE";
    }
}
