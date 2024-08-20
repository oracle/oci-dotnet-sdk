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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Workflow Group Layout.
    /// </summary>
    public class WorkflowGroup 
    {
        
        /// <value>
        /// Provide the name of the group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupName is required.")]
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
                ///
        /// <value>
        /// Workflow Group  Details.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PARALLEL_RESOURCE_GROUP")]
            ParallelResourceGroup,
            [EnumMember(Value = "ROLLING_RESOURCE_GROUP")]
            RollingResourceGroup
        };

        /// <value>
        /// Workflow Group  Details.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Steps within the Group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Steps is required.")]
        [JsonProperty(PropertyName = "steps")]
        public System.Collections.Generic.List<WorkflowComponent> Steps { get; set; }
        
    }
}