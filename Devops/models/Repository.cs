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
    /// Repositories containing the source code to build and deploy.
    /// </summary>
    public class Repository 
    {
        
        /// <value>
        /// The OCID of the repository. This value is unique and immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique name of a repository. This value is mutable.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the repository's compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Tenancy unique namespace.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The OCID of the DevOps project containing the repository.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// Unique project name in a namespace.
        /// </value>
        [JsonProperty(PropertyName = "projectName")]
        public string ProjectName { get; set; }
        
        /// <value>
        /// SSH URL that you use to git clone, pull and push.
        /// </value>
        [JsonProperty(PropertyName = "sshUrl")]
        public string SshUrl { get; set; }
        
        /// <value>
        /// HTTP URL that you use to git clone, pull and push.
        /// </value>
        [JsonProperty(PropertyName = "httpUrl")]
        public string HttpUrl { get; set; }
        
        /// <value>
        /// Details of the repository. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The default branch of the repository.
        /// </value>
        [JsonProperty(PropertyName = "defaultBranch")]
        public string DefaultBranch { get; set; }
                ///
        /// <value>
        /// Type of repository:
        /// MIRRORED - Repository created by mirroring an existing repository.
        /// HOSTED - Repository created and hosted using OCI DevOps code repository.
        /// 
        /// </value>
        ///
        public enum RepositoryTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MIRRORED")]
            Mirrored,
            [EnumMember(Value = "HOSTED")]
            Hosted
        };

        /// <value>
        /// Type of repository:
        /// MIRRORED - Repository created by mirroring an existing repository.
        /// HOSTED - Repository created and hosted using OCI DevOps code repository.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "repositoryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RepositoryTypeEnum> RepositoryType { get; set; }
        
        [JsonProperty(PropertyName = "mirrorRepositoryConfig")]
        public MirrorRepositoryConfig MirrorRepositoryConfig { get; set; }
        
        /// <value>
        /// The time the repository was created. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the repository was updated. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the repository.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DELETING")]
            Deleting
        };

        /// <value>
        /// The current state of the repository.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecyleDetails")]
        public string LifecyleDetails { get; set; }
        
        /// <value>
        /// The count of the branches present in the repository.
        /// </value>
        [JsonProperty(PropertyName = "branchCount")]
        public System.Nullable<int> BranchCount { get; set; }
        
        /// <value>
        /// The count of the commits present in the repository.
        /// </value>
        [JsonProperty(PropertyName = "commitCount")]
        public System.Nullable<int> CommitCount { get; set; }
        
        /// <value>
        /// The size of the repository in bytes.
        /// </value>
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
                ///
        ///
        public enum TriggerBuildEventsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PUSH")]
            Push,
            [EnumMember(Value = "COMMIT_UPDATES")]
            CommitUpdates
        };

        /// <value>
        /// Trigger build events supported for this repository:
        /// PUSH - Build is triggered when a push event occurs.
        /// COMMIT_UPDATES - Build is triggered when new commits are mirrored into a repository.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "triggerBuildEvents", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<TriggerBuildEventsEnum> TriggerBuildEvents { get; set; }
        
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
