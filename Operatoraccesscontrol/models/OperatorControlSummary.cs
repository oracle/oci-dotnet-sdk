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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// Summary of the OperatorControl.
    /// </summary>
    public class OperatorControlSummary 
    {
        
        /// <value>
        /// The OCID of the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Name of the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatorControlName is required.")]
        [JsonProperty(PropertyName = "operatorControlName")]
        public string OperatorControlName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the operator control.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Whether all operator actions are pre-approved. If yes, an access request associated with a resource governed by the operator control will be automatically approved by the system.
        /// </value>
        [JsonProperty(PropertyName = "isFullyPreApproved")]
        public System.Nullable<bool> IsFullyPreApproved { get; set; }
        
        /// <value>
        /// resourceType for which the OperatorControl is applicable
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypes> ResourceType { get; set; }
        
        /// <value>
        /// Number of approvers required to approve an access request.
        /// </value>
        [JsonProperty(PropertyName = "numberOfApprovers")]
        public System.Nullable<int> NumberOfApprovers { get; set; }
        
        /// <value>
        /// Time when the operator control was created, expressed in [RFC 3339] (https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfCreation")]
        public System.Nullable<System.DateTime> TimeOfCreation { get; set; }
        
        /// <value>
        /// Time when the operator control was last modified, expressed in [RFC 3339] (https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfModification")]
        public System.Nullable<System.DateTime> TimeOfModification { get; set; }
        
        /// <value>
        /// Time when the operator control was deleted, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        /// <value>
        /// The current lifecycle state of the operator control.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorControlLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
