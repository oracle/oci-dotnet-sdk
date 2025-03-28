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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// The Oracle Cloud Infrastructure resource representing the connection to the hardware and
    /// software located in a customer's data center running the Compute Cloud@Customer IaaS services.
    /// 
    /// </summary>
    public class CccInfrastructure 
    {
        
        /// <value>
        /// The Compute Cloud@Customer infrastructure [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// This cannot be changed once created.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The Compute Cloud@Customer infrastructure short name.
        /// This cannot be changed once created. The
        /// short name is used to refer to the infrastructure in several contexts and is unique.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }
        
        /// <value>
        /// The name that will be used to display the Compute Cloud@Customer infrastructure
        /// in the Oracle Cloud Infrastructure console. Does not have to be unique and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A mutable client-meaningful text description of the Compute Cloud@Customer infrastructure.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The infrastructure compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the network subnet that is
        /// used to communicate with Compute Cloud@Customer infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
                ///
        /// <value>
        /// The current connection state of the infrastructure. A user can only update
        /// it from REQUEST to READY or from any state back to REJECT. The system automatically
        /// handles the REJECT to REQUEST, READY to CONNECTED, or CONNECTED to DISCONNECTED transitions.
        /// 
        /// </value>
        ///
        public enum ConnectionStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REJECT")]
            Reject,
            [EnumMember(Value = "REQUEST")]
            Request,
            [EnumMember(Value = "READY")]
            Ready,
            [EnumMember(Value = "CONNECTED")]
            Connected,
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected
        };

        /// <value>
        /// The current connection state of the infrastructure. A user can only update
        /// it from REQUEST to READY or from any state back to REJECT. The system automatically
        /// handles the REJECT to REQUEST, READY to CONNECTED, or CONNECTED to DISCONNECTED transitions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConnectionStateEnum> ConnectionState { get; set; }
        
        /// <value>
        /// A message describing the current connection state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }
        
        /// <value>
        /// Schedule used for upgrades. If no schedule is associated with the infrastructure,
        /// it can be updated at any time.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cccUpgradeScheduleId")]
        public string CccUpgradeScheduleId { get; set; }
        
        /// <value>
        /// Fingerprint of a Compute Cloud@Customer infrastructure in a data center generated
        /// during the initial connection to this resource. The fingerprint should be verified
        /// by the administrator when changing the connectionState from REQUEST to READY.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningFingerprint")]
        public string ProvisioningFingerprint { get; set; }
        
        /// <value>
        /// Code that is required for service personnel to connect a
        /// Compute Cloud@Customer infrastructure in a data center to this resource.
        /// This code will only be available when the connectionState is REJECT (usually
        /// at create time of the Compute Cloud@Customer infrastructure).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningPin")]
        public string ProvisioningPin { get; set; }
        
        /// <value>
        /// Compute Cloud@Customer infrastructure creation date and time, using an RFC3339 formatted
        /// datetime string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Compute Cloud@Customer infrastructure updated date and time, using an RFC3339 formatted
        /// datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the Compute Cloud@Customer infrastructure.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "NEEDS_ATTENTION")]
            NeedsAttention,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Compute Cloud@Customer infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current lifecycle state in more detail.
        /// For example, this can be used to provide actionable information for a resource that is in
        /// a Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        [JsonProperty(PropertyName = "infrastructureInventory")]
        public CccInfrastructureInventory InfrastructureInventory { get; set; }
        
        [JsonProperty(PropertyName = "infrastructureNetworkConfiguration")]
        public CccInfrastructureNetworkConfiguration InfrastructureNetworkConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "upgradeInformation")]
        public CccUpgradeInformation UpgradeInformation { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
