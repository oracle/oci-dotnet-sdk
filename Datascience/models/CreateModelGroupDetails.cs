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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Parameters needed to create a model group. Model Group is a group of models.
    /// </summary>
    public class CreateModelGroupDetails : CreateBaseModelGroupDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelGroupDetails is required.")]
        [JsonProperty(PropertyName = "modelGroupDetails")]
        public ModelGroupDetails ModelGroupDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemberModelEntries is required.")]
        [JsonProperty(PropertyName = "memberModelEntries")]
        public MemberModelEntries MemberModelEntries { get; set; }
        
        /// <value>
        /// A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
        /// Example: My ModelGroup
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A short description of the modelGroup.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the model group version history to which the modelGroup is associated.
        /// </value>
        [JsonProperty(PropertyName = "modelGroupVersionHistoryId")]
        public string ModelGroupVersionHistoryId { get; set; }
        
        /// <value>
        /// An additional description of the lifecycle state of the model group.
        /// </value>
        [JsonProperty(PropertyName = "versionLabel")]
        public string VersionLabel { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "createType")]
        private readonly string createType = "CREATE";
    }
}
