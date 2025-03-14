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
    /// An updated list of routing rules that overwrites the existing list of routing rules.
    /// </summary>
    public class UpdateRoutingPolicyDetails 
    {
                ///
        /// <value>
        /// The version of the language in which `condition` of `rules` are composed.
        /// 
        /// </value>
        ///
        public enum ConditionLanguageVersionEnum {
            [EnumMember(Value = "V1")]
            V1
        };

        /// <value>
        /// The version of the language in which `condition` of `rules` are composed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionLanguageVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ConditionLanguageVersionEnum> ConditionLanguageVersion { get; set; }
        
        /// <value>
        /// The list of routing rules.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rules is required.")]
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<RoutingRule> Rules { get; set; }
        
    }
}
