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


namespace Oci.DatalabelingService.Models
{
    /// <summary>
    /// Once the Dataset is defined, it's largely immutable from a metadata perspective.  The records found in the data source itself, may change over time.
    /// 
    /// </summary>
    public class UpdateDatasetDetails 
    {
        
        /// <value>
        /// A user-friendly display name for the resource.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user provided description of the dataset
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The labeling instructions for human labelers in rich text format
        /// </value>
        [JsonProperty(PropertyName = "labelingInstructions")]
        public string LabelingInstructions { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. It exists for cross-compatibility only.
        /// For Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
