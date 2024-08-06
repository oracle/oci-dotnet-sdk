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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Entry for description of change on a file.
    /// </summary>
    public class PullRequestFileChangeSummary 
    {
        
        /// <value>
        /// Type of change made to file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangeType is required.")]
        [JsonProperty(PropertyName = "changeType")]
        public string ChangeType { get; set; }
        
        /// <value>
        /// The type of the changed object.
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// The ID of the commit where the change is coming from.
        /// </value>
        [JsonProperty(PropertyName = "commitId")]
        public string CommitId { get; set; }
        
        /// <value>
        /// The path on the target to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "oldPath")]
        public string OldPath { get; set; }
        
        /// <value>
        /// The path on the source to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "newPath")]
        public string NewPath { get; set; }
        
        /// <value>
        /// The ID of the changed object on the target.
        /// </value>
        [JsonProperty(PropertyName = "oldId")]
        public string OldId { get; set; }
        
        /// <value>
        /// The ID of the changed object on the source.
        /// </value>
        [JsonProperty(PropertyName = "newId")]
        public string NewId { get; set; }
        
        /// <value>
        /// The number of lines added in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "addedLinesCount")]
        public System.Nullable<int> AddedLinesCount { get; set; }
        
        /// <value>
        /// The number of lines deleted in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "deletedLinesCount")]
        public System.Nullable<int> DeletedLinesCount { get; set; }
        
        /// <value>
        /// Indicates whether the changed file contains conflicts.
        /// </value>
        [JsonProperty(PropertyName = "hasConflicts")]
        public System.Nullable<bool> HasConflicts { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
