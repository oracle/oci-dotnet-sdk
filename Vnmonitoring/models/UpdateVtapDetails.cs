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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// These details can be included in a request to update a virtual test access point (VTAP).
    /// </summary>
    public class UpdateVtapDetails 
    {
        
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
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the source point where packets are captured.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the destination resource where mirrored packets are sent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The IP address of the destination resource where mirrored packets are sent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetIp")]
        public string TargetIp { get; set; }
        
        /// <value>
        /// The capture filter's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "captureFilterId")]
        public string CaptureFilterId { get; set; }
                ///
        /// <value>
        /// Defines an encapsulation header type for the VTAP's mirrored traffic.
        /// 
        /// </value>
        ///
        public enum EncapsulationProtocolEnum {
            [EnumMember(Value = "VXLAN")]
            Vxlan
        };

        /// <value>
        /// Defines an encapsulation header type for the VTAP's mirrored traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encapsulationProtocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EncapsulationProtocolEnum> EncapsulationProtocol { get; set; }
        
        /// <value>
        /// The virtual extensible LAN (VXLAN) network identifier (or VXLAN segment ID) that uniquely identifies the VXLAN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vxlanNetworkIdentifier")]
        public System.Nullable<long> VxlanNetworkIdentifier { get; set; }
        
        /// <value>
        /// Used to start or stop a `Vtap` resource.
        /// <br/>
        /// * `TRUE` directs the VTAP to start mirroring traffic.
        /// * `FALSE` (Default) directs the VTAP to stop mirroring traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isVtapEnabled")]
        public System.Nullable<bool> IsVtapEnabled { get; set; }
                ///
        /// <value>
        /// Used to control the priority of traffic. It is an optional field. If it not passed, the value is DEFAULT
        /// </value>
        ///
        public enum TrafficModeEnum {
            [EnumMember(Value = "DEFAULT")]
            Default,
            [EnumMember(Value = "PRIORITY")]
            Priority
        };

        /// <value>
        /// Used to control the priority of traffic. It is an optional field. If it not passed, the value is DEFAULT
        /// </value>
        [JsonProperty(PropertyName = "trafficMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TrafficModeEnum> TrafficMode { get; set; }
        
        /// <value>
        /// The maximum size of the packets to be included in the filter.
        /// </value>
        [JsonProperty(PropertyName = "maxPacketSize")]
        public System.Nullable<int> MaxPacketSize { get; set; }
        
        /// <value>
        /// The IP Address of the source private endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourcePrivateEndpointIp")]
        public string SourcePrivateEndpointIp { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet that source private endpoint belongs to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourcePrivateEndpointSubnetId")]
        public string SourcePrivateEndpointSubnetId { get; set; }
                ///
        /// <value>
        /// The target type for the VTAP.
        /// 
        /// </value>
        ///
        public enum TargetTypeEnum {
            [EnumMember(Value = "VNIC")]
            Vnic,
            [EnumMember(Value = "NETWORK_LOAD_BALANCER")]
            NetworkLoadBalancer,
            [EnumMember(Value = "IP_ADDRESS")]
            IpAddress
        };

        /// <value>
        /// The target type for the VTAP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TargetTypeEnum> TargetType { get; set; }
                ///
        /// <value>
        /// The source type for the VTAP.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "VNIC")]
            Vnic,
            [EnumMember(Value = "SUBNET")]
            Subnet,
            [EnumMember(Value = "LOAD_BALANCER")]
            LoadBalancer,
            [EnumMember(Value = "DB_SYSTEM")]
            DbSystem,
            [EnumMember(Value = "EXADATA_VM_CLUSTER")]
            ExadataVmCluster,
            [EnumMember(Value = "AUTONOMOUS_DATA_WAREHOUSE")]
            AutonomousDataWarehouse
        };

        /// <value>
        /// The source type for the VTAP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SourceTypeEnum> SourceType { get; set; }
        
    }
}
