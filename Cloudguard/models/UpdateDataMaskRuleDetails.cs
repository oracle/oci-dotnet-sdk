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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// The information to be updated for a data mask rule.
    /// </summary>
    public class UpdateDataMaskRuleDetails 
    {
        
        /// <value>
        /// Data mask rule display name
        /// <br/>
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment OCID where the resource is created
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// IAM group ID associated with the data mask rule
        /// </value>
        [JsonProperty(PropertyName = "iamGroupId")]
        public string IamGroupId { get; set; }
        
        [JsonProperty(PropertyName = "targetSelected")]
        public TargetSelected TargetSelected { get; set; }
        
        /// <value>
        /// Data mask rule categories
        /// </value>
        [JsonProperty(PropertyName = "dataMaskCategories", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<DataMaskCategory> DataMaskCategories { get; set; }
        
        /// <value>
        /// The status of the data mask rule
        /// </value>
        [JsonProperty(PropertyName = "dataMaskRuleStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataMaskRuleStatus> DataMaskRuleStatus { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
