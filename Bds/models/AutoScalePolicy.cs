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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// This model for autoscaling policy is deprecated and not supported for ODH clusters. Use the `AutoScalePolicyDetails` model to manage autoscale policy details for ODH clusters.
    /// 
    /// </summary>
    public class AutoScalePolicy 
    {
                ///
        /// <value>
        /// Types of autoscale policies. Options are SCHEDULE-BASED or THRESHOLD-BASED. (Only THRESHOLD-BASED is supported in this release.)
        /// </value>
        ///
        public enum PolicyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "THRESHOLD_BASED")]
            ThresholdBased,
            [EnumMember(Value = "SCHEDULE_BASED")]
            ScheduleBased,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// Types of autoscale policies. Options are SCHEDULE-BASED or THRESHOLD-BASED. (Only THRESHOLD-BASED is supported in this release.)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyType is required.")]
        [JsonProperty(PropertyName = "policyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PolicyTypeEnum> PolicyType { get; set; }
        
        /// <value>
        /// The list of rules for autoscaling. If an action has multiple rules, the last rule in the array will be applied.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rules is required.")]
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<AutoScalePolicyRule> Rules { get; set; }
        
    }
}
