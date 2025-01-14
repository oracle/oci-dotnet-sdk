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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new Amazon Kinesis Connection.
    /// 
    /// </summary>
    public class CreateAmazonKinesisConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Amazon Kinesis technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AmazonKinesisConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Access key ID to access the Amazon Kinesis.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessKeyId is required.")]
        [JsonProperty(PropertyName = "accessKeyId")]
        public string AccessKeyId { get; set; }
        
        /// <value>
        /// Secret access key to access the Amazon Kinesis.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "secretAccessKey")]
        public string SecretAccessKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the secret access key is stored.
        /// Note: When provided, 'secretAccessKey' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "secretAccessKeySecretId")]
        public string SecretAccessKeySecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AMAZON_KINESIS";
    }
}
