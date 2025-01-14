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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Summary details of a workspace.
    /// </summary>
    public class WorkspaceSummary 
    {
        
        /// <value>
        /// A system-generated and immutable identifier assigned to the workspace upon creation.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user defined description for the workspace.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A user-friendly display name that is changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the workspace.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The date and time the workspace was created, in the timestamp format defined by RFC3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the workspace was updated, in the timestamp format defined by RFC3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
                ///
        /// <value>
        /// The current state of the workspace.
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
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped
        };

        /// <value>
        /// The current state of the workspace.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A detailed description about the current state of the workspace. Used to provide actionable information if the workspace is in a failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }
        
        /// <value>
        /// Name of the private endpoint associated with the container/workspace. Returns null if there is none.
        /// </value>
        [JsonProperty(PropertyName = "endpointName")]
        public string EndpointName { get; set; }
        
        /// <value>
        /// DCMS endpoint associated with the container/workspace. Returns null if there is none.
        /// </value>
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }
        
        /// <value>
        /// DCMS registry associated with the container/workspace. Returns null if there is none.
        /// </value>
        [JsonProperty(PropertyName = "registryId")]
        public string RegistryId { get; set; }
        
        /// <value>
        /// key-value pairs of workspace properties
        /// </value>
        [JsonProperty(PropertyName = "workspaceProperties")]
        public System.Collections.Generic.Dictionary<string, string> WorkspaceProperties { get; set; }
        
    }
}
