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


namespace Oci.DblmService.Models
{
    /// <summary>
    /// Description of PatchManagement.
    /// </summary>
    public class DblmPatchManagement 
    {
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// resources objects
        /// </value>
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<ResourceInfo> Resources { get; set; }
        
        /// <value>
        /// A message describing the status of the feature's state
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The time the Vulnerability was enabled. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeEnabled")]
        public System.Nullable<System.DateTime> TimeEnabled { get; set; }
                ///
        /// <value>
        /// The current state of the feature.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "NEEDS_ATTENTION")]
            NeedsAttention
        };

        /// <value>
        /// The current state of the feature.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Summary of patch operations.
        /// </value>
        [JsonProperty(PropertyName = "patchOperationsSummary")]
        public System.Object PatchOperationsSummary { get; set; }
        
        /// <value>
        /// Summary of image patches recommended to install.
        /// </value>
        [JsonProperty(PropertyName = "imagesPatchRecommendationSummary")]
        public System.Object ImagesPatchRecommendationSummary { get; set; }
        
        /// <value>
        /// Summary of image patches to be compliant to install.
        /// </value>
        [JsonProperty(PropertyName = "resourcesPatchComplianceSummary")]
        public System.Object ResourcesPatchComplianceSummary { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
