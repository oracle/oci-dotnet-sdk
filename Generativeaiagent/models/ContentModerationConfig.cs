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


namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// The configuration details about whether to apply the content moderation feature to input and output. Content moderation removes toxic and biased content from responses. It is recommended to use content moderation.
    /// </summary>
    public class ContentModerationConfig 
    {
        
        /// <value>
        /// A flag to enable or disable content moderation on input.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableOnInput")]
        public System.Nullable<bool> ShouldEnableOnInput { get; set; }
        
        /// <value>
        /// A flag to enable or disable content moderation on output.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableOnOutput")]
        public System.Nullable<bool> ShouldEnableOnOutput { get; set; }
        
    }
}
