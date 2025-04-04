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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// A ResponderRecipeRule resource contains a specific instance of a
    /// single responder rule.
    /// <br/>
    /// A ResponderRecipeRule resource:
    /// * Is effectively a copy of a ResponderRule resource in which users can
    /// make certain changes if it\u2019s Oracle-managed, and other changes if it\u2019s user-managed.
    /// * Can also be created by cloning an existing ResponderRecipe resource, either
    /// user-managed or Oracle-managed; cloning the ResponderRecipe resource also clones
    /// its associated ResponderRule resources as ResponderRecipeRule resources.
    /// * Is visible on the Cloud Guard Responder Recipes, Responder Details page.
    /// * Is effectively located in a specific OCI compartment, through the ResponderRecipe
    /// resource to which it belongs.
    /// * Can be modified by users, programmatically or through the UI.
    /// * Changes that can be made here apply globally, to all resources in OCI compartments
    /// mapped to a target that attaches the associated responder recipe (in a
    /// TargetResponderRecipe resource), but are overridden by changes made in the
    /// corresponding TargetResponderRecipe resource (which is effectively a copy of the
    /// ResponderRecipe resource).
    /// type: object
    /// 
    /// </summary>
    public class ResponderRecipeResponderRule 
    {
        
        /// <value>
        /// Unique identifier for the responder rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderRuleId is required.")]
        [JsonProperty(PropertyName = "responderRuleId")]
        public string ResponderRuleId { get; set; }
        
        /// <value>
        /// Responder rule display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Responder rule description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Type of responder
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResponderType> Type { get; set; }
        
        /// <value>
        /// List of policies
        /// </value>
        [JsonProperty(PropertyName = "policies")]
        public System.Collections.Generic.List<string> Policies { get; set; }
                ///
        ///
        public enum SupportedModesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTOACTION")]
            Autoaction,
            [EnumMember(Value = "USERACTION")]
            Useraction
        };

        /// <value>
        /// Supported execution modes for the responder rule
        /// </value>
        [JsonProperty(PropertyName = "supportedModes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<SupportedModesEnum> SupportedModes { get; set; }
        
        [JsonProperty(PropertyName = "details")]
        public ResponderRuleDetails Details { get; set; }
        
        /// <value>
        /// Compartment OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The date and time the responder recipe rule was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the responder recipe rule was last updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current lifecycle state of the responder rule
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
