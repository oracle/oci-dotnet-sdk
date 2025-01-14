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
    /// Details for the HDFS data asset type.
    /// </summary>
    public class CreateDataAssetFromHdfs : CreateDataAssetDetails
    {
        
        /// <value>
        /// The HDFS hostname.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Host is required.")]
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The HDFS port.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// The HDFS Protocol name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// Specifies whether certificate validation is needed
        /// </value>
        [JsonProperty(PropertyName = "validateCertificate")]
        public System.Nullable<bool> ValidateCertificate { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultConnection is required.")]
        [JsonProperty(PropertyName = "defaultConnection")]
        public CreateConnectionFromHdfs DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "HDFS_DATA_ASSET";
    }
}
