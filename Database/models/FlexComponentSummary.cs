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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The Flex Components for a DB system. The Flex Component determines resources to allocate to the DB system -  CPU cores, memory and storage for Flex shapes.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator.
    /// If you're an administrator who needs to write policies to give users access,
    /// see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class FlexComponentSummary 
    {
        
        /// <value>
        /// The name of the Flex Component used for the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The minimum number of CPU cores that can be enabled on the DB Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "minimumCoreCount")]
        public System.Nullable<int> MinimumCoreCount { get; set; }
        
        /// <value>
        /// The maximum number of CPU cores that can ben enabled on the DB Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "availableCoreCount")]
        public System.Nullable<int> AvailableCoreCount { get; set; }
        
        /// <value>
        /// The maximum  storage that can be enabled on the Storage Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "availableDbStorageInGBs")]
        public System.Nullable<int> AvailableDbStorageInGBs { get; set; }
        
        /// <value>
        /// The runtime minimum number of CPU cores that can be enabled for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "runtimeMinimumCoreCount")]
        public System.Nullable<int> RuntimeMinimumCoreCount { get; set; }
        
        /// <value>
        /// The name of the DB system shape for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The maximum memory size that can be enabled on the DB Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "availableMemoryInGBs")]
        public System.Nullable<int> AvailableMemoryInGBs { get; set; }
        
        /// <value>
        /// The maximum local storage that can be enabled on the DB Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "availableLocalStorageInGBs")]
        public System.Nullable<int> AvailableLocalStorageInGBs { get; set; }
        
        /// <value>
        /// The compute model of the DB Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        public string ComputeModel { get; set; }
                ///
        /// <value>
        /// The hardware type of the DB (Compute) or Storage (Cell) Server for this Flex Component.
        /// </value>
        ///
        public enum HardwareTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "COMPUTE")]
            Compute,
            [EnumMember(Value = "CELL")]
            Cell
        };

        /// <value>
        /// The hardware type of the DB (Compute) or Storage (Cell) Server for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "hardwareType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HardwareTypeEnum> HardwareType { get; set; }
        
        /// <value>
        /// The description summary for this Flex Component.
        /// </value>
        [JsonProperty(PropertyName = "descriptionSummary")]
        public string DescriptionSummary { get; set; }
        
    }
}
