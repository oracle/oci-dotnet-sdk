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


namespace Oci.CoreService.Models
{
    
    public class UpdateIPSecConnectionTunnelDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The type of routing to use for this tunnel (BGP dynamic routing, static routing, or policy-based routing).
        /// 
        /// </value>
        ///
        public enum RoutingEnum {
            [EnumMember(Value = "BGP")]
            Bgp,
            [EnumMember(Value = "STATIC")]
            Static,
            [EnumMember(Value = "POLICY")]
            Policy
        };

        /// <value>
        /// The type of routing to use for this tunnel (BGP dynamic routing, static routing, or policy-based routing).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoutingEnum> Routing { get; set; }
                ///
        /// <value>
        /// Internet Key Exchange protocol version.
        /// 
        /// </value>
        ///
        public enum IkeVersionEnum {
            [EnumMember(Value = "V1")]
            V1,
            [EnumMember(Value = "V2")]
            V2
        };

        /// <value>
        /// Internet Key Exchange protocol version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ikeVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IkeVersionEnum> IkeVersion { get; set; }
        
        [JsonProperty(PropertyName = "bgpSessionConfig")]
        public UpdateIPSecTunnelBgpSessionDetails BgpSessionConfig { get; set; }
                ///
        /// <value>
        /// Indicates whether the Oracle end of the IPSec connection is able to initiate starting up the IPSec tunnel.
        /// 
        /// </value>
        ///
        public enum OracleInitiationEnum {
            [EnumMember(Value = "INITIATOR_OR_RESPONDER")]
            InitiatorOrResponder,
            [EnumMember(Value = "RESPONDER_ONLY")]
            ResponderOnly
        };

        /// <value>
        /// Indicates whether the Oracle end of the IPSec connection is able to initiate starting up the IPSec tunnel.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "oracleInitiation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OracleInitiationEnum> OracleInitiation { get; set; }
                ///
        /// <value>
        /// By default (the `AUTO` setting), IKE sends packets with a source and destination port set to 500,
        /// and when it detects that the port used to forward packets has changed (most likely because a NAT device
        /// is between the CPE device and the Oracle VPN headend) it will try to negotiate the use of NAT-T.
        /// <br/>
        /// The `ENABLED` option sets the IKE protocol to use port 4500 instead of 500 and forces encapsulating traffic with the ESP protocol inside UDP packets.
        /// <br/>
        /// The `DISABLED` option directs IKE to completely refuse to negotiate NAT-T
        /// even if it senses there may be a NAT device in use.
        /// 
        /// </value>
        ///
        public enum NatTranslationEnabledEnum {
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "AUTO")]
            Auto
        };

        /// <value>
        /// By default (the `AUTO` setting), IKE sends packets with a source and destination port set to 500,
        /// and when it detects that the port used to forward packets has changed (most likely because a NAT device
        /// is between the CPE device and the Oracle VPN headend) it will try to negotiate the use of NAT-T.
        /// <br/>
        /// The `ENABLED` option sets the IKE protocol to use port 4500 instead of 500 and forces encapsulating traffic with the ESP protocol inside UDP packets.
        /// <br/>
        /// The `DISABLED` option directs IKE to completely refuse to negotiate NAT-T
        /// even if it senses there may be a NAT device in use.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "natTranslationEnabled")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NatTranslationEnabledEnum> NatTranslationEnabled { get; set; }
        
        [JsonProperty(PropertyName = "phaseOneConfig")]
        public PhaseOneConfigDetails PhaseOneConfig { get; set; }
        
        [JsonProperty(PropertyName = "phaseTwoConfig")]
        public PhaseTwoConfigDetails PhaseTwoConfig { get; set; }
        
        [JsonProperty(PropertyName = "dpdConfig")]
        public DpdConfig DpdConfig { get; set; }
        
        [JsonProperty(PropertyName = "encryptionDomainConfig")]
        public UpdateIPSecTunnelEncryptionDomainDetails EncryptionDomainConfig { get; set; }
        
    }
}
