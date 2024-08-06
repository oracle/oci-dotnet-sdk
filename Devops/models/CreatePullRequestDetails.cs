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
    /// The information about new Pull Request.
    /// </summary>
    public class CreatePullRequestDetails 
    {
        
        /// <value>
        /// Pull Request title
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The source branch of the pull request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceBranch is required.")]
        [JsonProperty(PropertyName = "sourceBranch")]
        public string SourceBranch { get; set; }
        
        /// <value>
        /// The destination branch of the pull request. If not provided, default branch will be used as the destination branch.
        /// </value>
        [JsonProperty(PropertyName = "destinationBranch")]
        public string DestinationBranch { get; set; }
        
        /// <value>
        /// The OCID of the repository.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryId is required.")]
        [JsonProperty(PropertyName = "repositoryId")]
        public string RepositoryId { get; set; }
        
        /// <value>
        /// The OCID of the forked repository that will act as the source of the changes to be included in the pull request against the parent repository.
        /// </value>
        [JsonProperty(PropertyName = "sourceRepositoryId")]
        public string SourceRepositoryId { get; set; }
        
        /// <value>
        /// Details of the pull request. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Reviewers for this pull request.
        /// </value>
        [JsonProperty(PropertyName = "reviewers")]
        public System.Collections.Generic.List<CreateReviewerDetails> Reviewers { get; set; }
        
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
        
    }
}
