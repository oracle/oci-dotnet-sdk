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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// A Deployment Rule Set(DRS) is a JAR (Java ARchive) file used in Java applications to enforce security and manage compatibility
    /// between different versions of Java applets and web start applications
    /// (https://docs.oracle.com/javase/8/docs/technotes/guides/deploy/deployment_rules.html).
    /// 
    /// </summary>
    public class DrsFileSummary 
    {
        
        /// <value>
        /// The Object Storage bucket name where the DRS file is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The namespace for Object Storage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The name of the DRS file in Object Store.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrsFileName is required.")]
        [JsonProperty(PropertyName = "drsFileName")]
        public string DrsFileName { get; set; }
        
        /// <value>
        /// The unique identifier of the DRS file in Object Storage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrsFileKey is required.")]
        [JsonProperty(PropertyName = "drsFileKey")]
        public string DrsFileKey { get; set; }
                ///
        /// <value>
        /// The checksum type for the DRS file in Object Storage.
        /// </value>
        ///
        public enum ChecksumTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA256")]
            Sha256
        };

        /// <value>
        /// The checksum type for the DRS file in Object Storage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChecksumType is required.")]
        [JsonProperty(PropertyName = "checksumType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ChecksumTypeEnum> ChecksumType { get; set; }
        
        /// <value>
        /// The checksum value for the DRS file in Object Storage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChecksumValue is required.")]
        [JsonProperty(PropertyName = "checksumValue")]
        public string ChecksumValue { get; set; }
        
        /// <value>
        /// To check if the DRS file is the detfault ones.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDefault is required.")]
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
