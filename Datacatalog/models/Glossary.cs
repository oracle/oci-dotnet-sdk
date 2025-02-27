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
    /// Full glossary details. A glossary of business terms, such as 'Customer', 'Account', 'Contact' , 'Address',
    /// or 'Product', with definitions, used to provide common meaning across disparate data assets. Business glossaries
    /// may be hierarchical where some terms may contain child terms to allow them to be used as 'taxonomies'.
    /// By linking data assets, data entities, and attributes to glossaries and glossary terms, the glossary can act as a
    /// way of organizing data catalog objects in a hierarchy to make a large number of objects more navigable and easier to
    /// consume. Objects in the data aatalog, such as data assets or data entities, may be linked to any level in the
    /// glossary, so that the glossary can be used to browse the available data according to the business model of the
    /// organization.
    /// 
    /// </summary>
    public class Glossary 
    {
        
        /// <value>
        /// Unique glossary key that is immutable.
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
        /// Detailed description of the glossary.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The data catalog's OCID.
        /// </value>
        [JsonProperty(PropertyName = "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// The current state of the glossary.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the glossary was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time that any change was made to the glossary. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created this metadata element.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated this metadata element.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// OCID of the user who is the owner of the glossary.
        /// </value>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Status of the approval process workflow for this business glossary.
        /// </value>
        [JsonProperty(PropertyName = "workflowStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TermWorkflowStatus> WorkflowStatus { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertyGetUsage> CustomPropertyMembers { get; set; }
        
        /// <value>
        /// The unique key of the job definition resource that was used in the Glossary import.
        /// </value>
        [JsonProperty(PropertyName = "importJobDefinitionKey")]
        public string ImportJobDefinitionKey { get; set; }
        
        /// <value>
        /// The unique key of the job policy for Glossary import.
        /// </value>
        [JsonProperty(PropertyName = "importJobKey")]
        public string ImportJobKey { get; set; }
        
        /// <value>
        /// The unique key of the parent job execution for which the log resource was created.
        /// </value>
        [JsonProperty(PropertyName = "latestImportJobExecutionKey")]
        public string LatestImportJobExecutionKey { get; set; }
        
        /// <value>
        /// Status of the latest glossary import job execution, such as running, paused, or completed.
        /// This may include additional information like time import started , import file size and % of completion
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latestImportJobExecutionStatus")]
        public string LatestImportJobExecutionStatus { get; set; }
        
        /// <value>
        /// URI to the tag instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
    }
}
