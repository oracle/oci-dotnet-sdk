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


namespace Oci.AutoscalingService.Models
{
    /// <summary>
    /// Creation details for a schedule-based autoscaling policy.
    /// <br/>
    /// In a schedule-based autoscaling policy, an autoscaling action is triggered at the scheduled execution time.
    /// 
    /// </summary>
    public class CreateScheduledPolicyDetails : CreateAutoScalingPolicyDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionSchedule is required.")]
        [JsonProperty(PropertyName = "executionSchedule")]
        public ExecutionSchedule ExecutionSchedule { get; set; }
        
        [JsonProperty(PropertyName = "resourceAction")]
        public ResourceAction ResourceAction { get; set; }
        
        [JsonProperty(PropertyName = "policyType")]
        private readonly string policyType = "scheduled";
    }
}
