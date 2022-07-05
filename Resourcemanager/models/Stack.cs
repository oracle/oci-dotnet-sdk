/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// The stack object. Stacks represent definitions of groups of Oracle Cloud Infrastructure
    /// resources that you can act upon as a group. You take action on stacks by using jobs.
    /// 
    /// </summary>
    public class Stack 
    {
        
        /// <value>
        /// Unique identifier ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)) for the stack.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique identifier ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)) for the compartment where the stack is located.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Human-readable name of the stack.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the stack.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The date and time at which the stack was created.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the stack.
        /// For more information about stack lifecycle states in Resource Manager, see
        /// [Key Concepts](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/resourcemanager.htm#concepts__StackStates).
        /// 
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
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current lifecycle state of the stack.
        /// For more information about stack lifecycle states in Resource Manager, see
        /// [Key Concepts](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/resourcemanager.htm#concepts__StackStates).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "configSource")]
        public ConfigSource ConfigSource { get; set; }
        
        /// <value>
        /// Terraform variables associated with this resource.
        /// Maximum number of variables supported is 250.
        /// The maximum size of each variable, including both name and value, is 8192 bytes.
        /// Example: {&quot;CompartmentId&quot;: &quot;compartment-id-value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.Dictionary<string, string> Variables { get; set; }
        
        /// <value>
        /// The version of Terraform specified for the stack. Example: 0.12.x
        /// </value>
        [JsonProperty(PropertyName = "terraformVersion")]
        public string TerraformVersion { get; set; }
                ///
        /// <value>
        /// Drift status of the stack.
        /// Drift refers to differences between the actual (current) state of the stack and the expected (defined) state of the stack.
        /// 
        /// </value>
        ///
        public enum StackDriftStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_CHECKED")]
            NotChecked,
            [EnumMember(Value = "IN_SYNC")]
            InSync,
            [EnumMember(Value = "DRIFTED")]
            Drifted
        };

        /// <value>
        /// Drift status of the stack.
        /// Drift refers to differences between the actual (current) state of the stack and the expected (defined) state of the stack.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stackDriftStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StackDriftStatusEnum> StackDriftStatus { get; set; }
        
        /// <value>
        /// The date and time when the drift detection was last executed.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeDriftLastChecked")]
        public System.Nullable<System.DateTime> TimeDriftLastChecked { get; set; }
        
        /// <value>
        /// Free-form tags associated with the resource. Each tag is a key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
