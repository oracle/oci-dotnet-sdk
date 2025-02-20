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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Access policy rule.
    /// </summary>
    public class AccessPolicyRuleDetails 
    {
                ///
        /// <value>
        /// Action for the traffic between the source and the destination.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "ALLOW")]
            Allow
        };

        /// <value>
        /// Action for the traffic between the source and the destination.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public AccessPolicyTargetDetails Source { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public AccessPolicyTargetDetails Destination { get; set; }
        
    }
}
