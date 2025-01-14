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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// A named ordered list of routing rules that is applied to a listener.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class RoutingPolicy 
    {
        
        /// <value>
        /// The unique name for this list of routing rules. Avoid entering confidential information.
        /// <br/>
        /// Example: example_routing_policy
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The version of the language in which `condition` of `rules` are composed.
        /// 
        /// </value>
        ///
        public enum ConditionLanguageVersionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "V1")]
            V1
        };

        /// <value>
        /// The version of the language in which `condition` of `rules` are composed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConditionLanguageVersion is required.")]
        [JsonProperty(PropertyName = "conditionLanguageVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionLanguageVersionEnum> ConditionLanguageVersion { get; set; }
        
        /// <value>
        /// The ordered list of routing rules.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rules is required.")]
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<RoutingRule> Rules { get; set; }
        
    }
}
