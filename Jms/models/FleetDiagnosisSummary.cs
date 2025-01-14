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
    /// Diagnosis of a resource needed by the fleet.
    /// </summary>
    public class FleetDiagnosisSummary 
    {
                ///
        /// <value>
        /// The type of the resource needed by the fleet.
        /// This is the role of a resource in the fleet. Use the OCID to determine the actual OCI
        /// resource type such as log group or log.
        /// 
        /// </value>
        ///
        public enum ResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INVENTORY_LOG")]
            InventoryLog,
            [EnumMember(Value = "OPERATION_LOG")]
            OperationLog,
            [EnumMember(Value = "CRYPTO_SUMMARIZED_LOG")]
            CryptoSummarizedLog,
            [EnumMember(Value = "ANALYSIS_OSS_BUCKET")]
            AnalysisOssBucket
        };

        /// <value>
        /// The type of the resource needed by the fleet.
        /// This is the role of a resource in the fleet. Use the OCID to determine the actual OCI
        /// resource type such as log group or log.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeEnum> ResourceType { get; set; }
        
        /// <value>
        /// The OCID of the external resouce needed by the fleet.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
                ///
        /// <value>
        /// The state of the resource. The resource state is ACTIVE when it works properly for the fleet.
        /// In case it would cause an issue for the fleet function, the state is INACTIVE.
        /// When JMS can't locate the resource, the state is NOT_FOUND.
        /// OTHER covers other cases, such as a temporarily network issue that prevents JMS from detecting the
        /// resource. Check the resourceDiagnosis for details.
        /// 
        /// </value>
        ///
        public enum ResourceStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "NOT_FOUND")]
            NotFound,
            [EnumMember(Value = "OTHER")]
            Other
        };

        /// <value>
        /// The state of the resource. The resource state is ACTIVE when it works properly for the fleet.
        /// In case it would cause an issue for the fleet function, the state is INACTIVE.
        /// When JMS can't locate the resource, the state is NOT_FOUND.
        /// OTHER covers other cases, such as a temporarily network issue that prevents JMS from detecting the
        /// resource. Check the resourceDiagnosis for details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceStateEnum> ResourceState { get; set; }
        
        /// <value>
        /// The diagnosis message.
        /// </value>
        [JsonProperty(PropertyName = "resourceDiagnosis")]
        public string ResourceDiagnosis { get; set; }
        
    }
}
