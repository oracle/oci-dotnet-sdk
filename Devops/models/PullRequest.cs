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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Pull Request containing the diff between a review branch and a destination branch
    /// </summary>
    public class PullRequest 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// PullRequest title, can be renamed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Details of the pull request. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
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
        /// DevOps Repository Identifier tells which repository this pull request belongs to
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryId is required.")]
        [JsonProperty(PropertyName = "repositoryId")]
        public string RepositoryId { get; set; }
        
        /// <value>
        /// The source branch which contains the changes to be reviewed. Example: &quot;feature/JIRA-123&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceBranch is required.")]
        [JsonProperty(PropertyName = "sourceBranch")]
        public string SourceBranch { get; set; }
        
        /// <value>
        /// The destination branch against which the changes are to be reviewed. Example: &quot;main&quot;.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBranch is required.")]
        [JsonProperty(PropertyName = "destinationBranch")]
        public string DestinationBranch { get; set; }
        
        /// <value>
        /// The source branch commit ID when the Pull Request status was last changed to merged or closed
        /// </value>
        [JsonProperty(PropertyName = "sourceCommitIdAtTermination")]
        public string SourceCommitIdAtTermination { get; set; }
        
        /// <value>
        /// The merge base commit ID when the Pull Request status was last changed to merged or closed
        /// </value>
        [JsonProperty(PropertyName = "mergeBaseCommitIdAtTermination")]
        public string MergeBaseCommitIdAtTermination { get; set; }
        
        /// <value>
        /// The time the PullRequest was created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the PullRequest was updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the PullRequest.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the PullRequest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The status of the Pull Request.
        /// </value>
        ///
        public enum LifecycleDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OPEN")]
            Open,
            [EnumMember(Value = "CONFLICT")]
            Conflict,
            [EnumMember(Value = "CLOSED")]
            Closed,
            [EnumMember(Value = "MERGING")]
            Merging,
            [EnumMember(Value = "MERGED")]
            Merged
        };

        /// <value>
        /// The status of the Pull Request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleDetails is required.")]
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleDetailsEnum> LifecycleDetails { get; set; }
        
        /// <value>
        /// List of Reviewers.
        /// </value>
        [JsonProperty(PropertyName = "reviewers")]
        public System.Collections.Generic.List<Reviewer> Reviewers { get; set; }
        
        [JsonProperty(PropertyName = "mergeChecks")]
        public MergeCheckCollection MergeChecks { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public PrincipalDetails CreatedBy { get; set; }
        
        [JsonProperty(PropertyName = "mergedBy")]
        public PrincipalDetails MergedBy { get; set; }
        
        /// <value>
        /// The OCID of the forked repository that will act as the source of the changes to be included in the pull request against the parent repository.
        /// </value>
        [JsonProperty(PropertyName = "sourceRepositoryId")]
        public string SourceRepositoryId { get; set; }
        
        /// <value>
        /// The total number of comments on the pull request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalComments is required.")]
        [JsonProperty(PropertyName = "totalComments")]
        public System.Nullable<int> TotalComments { get; set; }
        
        /// <value>
        /// The total number of reviewers on the pull request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalReviewers is required.")]
        [JsonProperty(PropertyName = "totalReviewers")]
        public System.Nullable<int> TotalReviewers { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SystemTags is required.")]
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
