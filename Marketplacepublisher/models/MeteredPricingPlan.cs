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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Metered pricing plan.
    /// 
    /// </summary>
    public class MeteredPricingPlan : PricingPlan
    {
                ///
        /// <value>
        /// The listing's pricing plan name.
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PER_INSTANCE")]
            PerInstance,
            [EnumMember(Value = "PER_OCPU_MIN_BILLING_HRS")]
            PerOcpuMinBillingHrs,
            [EnumMember(Value = "PER_OCPU_LINEAR")]
            PerOcpuLinear,
            [EnumMember(Value = "PER_INSTANCE_MONTHLY_INCLUSIVE")]
            PerInstanceMonthlyInclusive
        };

        /// <value>
        /// The listing's pricing plan name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs for the metering pricing.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, string> ExtendedMetadata { get; set; }
        
        [JsonProperty(PropertyName = "planType")]
        private readonly string planType = "METERED";
    }
}
