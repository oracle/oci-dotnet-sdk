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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a image verification policy.
    /// </summary>
    public class CreateImagePolicyConfigDetails 
    {
        
        /// <value>
        /// Whether the image verification policy is enabled. Defaults to false. If set to true, the images will be verified against the policy at runtime.
        /// </value>
        [JsonProperty(PropertyName = "isPolicyEnabled")]
        public System.Nullable<bool> IsPolicyEnabled { get; set; }
        
        /// <value>
        /// A list of KMS key details.
        /// </value>
        [JsonProperty(PropertyName = "keyDetails")]
        public System.Collections.Generic.List<KeyDetails> KeyDetails { get; set; }
        
    }
}
