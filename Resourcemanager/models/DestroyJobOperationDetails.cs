/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Job details that are specific to destroy operations.
    /// 
    /// </summary>
    public class DestroyJobOperationDetails : JobOperationDetails
    {
        
        [JsonProperty(PropertyName = "terraformAdvancedOptions")]
        public TerraformAdvancedOptions TerraformAdvancedOptions { get; set; }
                ///
        /// <value>
        /// Specifies the source of the execution plan to apply.
        /// Currently, only `AUTO_APPROVED` is allowed, which indicates that the job
        /// will be run without an execution plan.
        /// 
        /// </value>
        ///
        public enum ExecutionPlanStrategyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO_APPROVED")]
            AutoApproved
        };

        /// <value>
        /// Specifies the source of the execution plan to apply.
        /// Currently, only `AUTO_APPROVED` is allowed, which indicates that the job
        /// will be run without an execution plan.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionPlanStrategy is required.")]
        [JsonProperty(PropertyName = "executionPlanStrategy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExecutionPlanStrategyEnum> ExecutionPlanStrategy { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "DESTROY";
    }
}
