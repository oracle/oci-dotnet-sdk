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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new Amazon S3 Connection.
    /// 
    /// </summary>
    public class CreateAmazonS3ConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Amazon S3 technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AmazonS3Connection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Access key ID to access the Amazon S3 bucket.
        /// e.g.: \"this-is-not-the-secret\"
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessKeyId is required.")]
        [JsonProperty(PropertyName = "accessKeyId")]
        public string AccessKeyId { get; set; }
        
        /// <value>
        /// Secret access key to access the Amazon S3 bucket.
        /// e.g.: \"this-is-not-the-secret\"
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretAccessKey is required.")]
        [JsonProperty(PropertyName = "secretAccessKey")]
        public string SecretAccessKey { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AMAZON_S3";
    }
}
