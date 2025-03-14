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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// A remote peering connection (RPC) is an object on a DRG that lets the VCN that is attached
    /// to the DRG peer with a VCN in a different region. *Peering* means that the two VCNs can
    /// communicate using private IP addresses, but without the traffic traversing the internet or
    /// routing through your on-premises network. For more information, see
    /// [VCN Peering](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/VCNpeering.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class RemotePeeringConnection 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the RPC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
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
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG that this RPC belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgId is required.")]
        [JsonProperty(PropertyName = "drgId")]
        public string DrgId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the RPC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Whether the VCN at the other end of the peering is in a different tenancy.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsCrossTenancyPeering is required.")]
        [JsonProperty(PropertyName = "isCrossTenancyPeering")]
        public System.Nullable<bool> IsCrossTenancyPeering { get; set; }
                ///
        /// <value>
        /// The RPC's current lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The RPC's current lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// If this RPC is peered, this value is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the other RPC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerId")]
        public string PeerId { get; set; }
        
        /// <value>
        /// If this RPC is peered, this value is the region that contains the other RPC.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        [JsonProperty(PropertyName = "peerRegionName")]
        public string PeerRegionName { get; set; }
        
        /// <value>
        /// If this RPC is peered, this value is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the other RPC's tenancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerTenancyId")]
        public string PeerTenancyId { get; set; }
                ///
        /// <value>
        /// Whether the RPC is peered with another RPC. `NEW` means the RPC has not yet been
        /// peered. `PENDING` means the peering is being established. `REVOKED` means the
        /// RPC at the other end of the peering has been deleted.
        /// 
        /// </value>
        ///
        public enum PeeringStatusEnum {
            [EnumMember(Value = "INVALID")]
            Invalid,
            [EnumMember(Value = "NEW")]
            New,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "PEERED")]
            Peered,
            [EnumMember(Value = "REVOKED")]
            Revoked
        };

        /// <value>
        /// Whether the RPC is peered with another RPC. `NEW` means the RPC has not yet been
        /// peered. `PENDING` means the peering is being established. `REVOKED` means the
        /// RPC at the other end of the peering has been deleted.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeeringStatus is required.")]
        [JsonProperty(PropertyName = "peeringStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PeeringStatusEnum> PeeringStatus { get; set; }
        
        /// <value>
        /// The date and time the RPC was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
