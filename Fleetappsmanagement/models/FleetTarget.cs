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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// A confirmed target within a fleet.
    /// </summary>
    public class FleetTarget 
    {
        
        /// <value>
        /// The OCID of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// compartment OCID
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The time this resource was created. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Current version of target.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Product to which the target belongs to.
        /// </value>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }
        
        [JsonProperty(PropertyName = "resource")]
        public TargetResource Resource { get; set; }
        
        /// <value>
        /// The last known compliance state of the target.
        /// </value>
        [JsonProperty(PropertyName = "complianceState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComplianceState> ComplianceState { get; set; }
        
        /// <value>
        /// The time when the last successful discovery was made.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastSuccessfulDiscovery")]
        public System.Nullable<System.DateTime> TimeOfLastSuccessfulDiscovery { get; set; }
        
        /// <value>
        /// The time when last discovery was attempted.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastDiscoveryAttempt")]
        public System.Nullable<System.DateTime> TimeOfLastDiscoveryAttempt { get; set; }
        
        /// <value>
        /// A boolean flag that represents whether the last discovery attempt was successful.
        /// </value>
        [JsonProperty(PropertyName = "isLastDiscoveryAttemptSuccessful")]
        public System.Nullable<bool> IsLastDiscoveryAttemptSuccessful { get; set; }
                ///
        /// <value>
        /// The current state of the FleetTarget.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the FleetTarget.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
