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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Glossary tree element with child terms.
    /// </summary>
    public class GlossaryTreeElement 
    {
        
        /// <value>
        /// An array of child terms.
        /// </value>
        [JsonProperty(PropertyName = "childTerms")]
        public System.Collections.Generic.List<GlossaryTreeElement> ChildTerms { get; set; }
        
        /// <value>
        /// Unique term key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the term.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Unique id of the parent glossary.
        /// </value>
        [JsonProperty(PropertyName = "glossaryKey")]
        public string GlossaryKey { get; set; }
        
        /// <value>
        /// URI to the term instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// This terms parent term key. Will be null if the term has no parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermKey")]
        public string ParentTermKey { get; set; }
        
        /// <value>
        /// Indicates whether a term may contain child terms.
        /// </value>
        [JsonProperty(PropertyName = "isAllowedToHaveChildTerms")]
        public System.Nullable<bool> IsAllowedToHaveChildTerms { get; set; }
        
        /// <value>
        /// Absolute path of the term.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// The date and time the term was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Status of the approval process workflow for this business term in the glossary.
        /// </value>
        [JsonProperty(PropertyName = "workflowStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TermWorkflowStatus> WorkflowStatus { get; set; }
        
        /// <value>
        /// The number of objects tagged with this term.
        /// </value>
        [JsonProperty(PropertyName = "associatedObjectCount")]
        public System.Nullable<int> AssociatedObjectCount { get; set; }
        
        /// <value>
        /// State of the term.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
    }
}
