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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Request for creating Decryption Rule used in the firewall policy rules.
    /// A Decryption Rule is used to define which traffic should be decrypted by the firewall, and how it should do so.
    /// 
    /// </summary>
    public class CreateDecryptionRuleDetails 
    {
        
        /// <value>
        /// Name for the decryption rule, must be unique within the policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public DecryptionRuleMatchCriteria Condition { get; set; }
        
        /// <value>
        /// Action:
        /// <br/>
        /// * NO_DECRYPT - Matching traffic is not decrypted.
        /// * DECRYPT - Matching traffic is decrypted with the specified `secret` according to the specified `decryptionProfile`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DecryptionActionType> Action { get; set; }
        
        /// <value>
        /// The name of the decryption profile to use.
        /// </value>
        [JsonProperty(PropertyName = "decryptionProfile")]
        public string DecryptionProfile { get; set; }
        
        /// <value>
        /// The name of a mapped secret. Its `type` must match that of the specified decryption profile.
        /// </value>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }
        
        [JsonProperty(PropertyName = "position")]
        public RulePosition Position { get; set; }
        
    }
}
