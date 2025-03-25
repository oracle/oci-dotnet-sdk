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
    /// The data to update an endpoint.
    /// 
    /// </summary>
    public class UpdateAgentEndpointDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// An optional description of the AgentEndpoint.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "contentModerationConfig")]
        public ContentModerationConfig ContentModerationConfig { get; set; }
        
        [JsonProperty(PropertyName = "guardrailConfig")]
        public GuardrailConfig GuardrailConfig { get; set; }
        
        /// <value>
        /// Key-value pairs to allow additional configurations.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        [JsonProperty(PropertyName = "humanInputConfig")]
        public HumanInputConfig HumanInputConfig { get; set; }
        
        [JsonProperty(PropertyName = "outputConfig")]
        public OutputConfig OutputConfig { get; set; }
        
        /// <value>
        /// Whether to show traces in the chat result.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableTrace")]
        public System.Nullable<bool> ShouldEnableTrace { get; set; }
        
        /// <value>
        /// Whether to show citations in the chat result.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableCitation")]
        public System.Nullable<bool> ShouldEnableCitation { get; set; }
        
        /// <value>
        /// Whether to enable multi-language for chat.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableMultiLanguage")]
        public System.Nullable<bool> ShouldEnableMultiLanguage { get; set; }
        
        [JsonProperty(PropertyName = "sessionConfig")]
        public SessionConfig SessionConfig { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
