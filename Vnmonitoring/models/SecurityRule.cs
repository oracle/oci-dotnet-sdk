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
    /// A security rule is one of the items in a {@link NetworkSecurityGroup}.
    /// It is a virtual firewall rule for the VNICs in the network security group. A rule can be for
    /// either inbound (`direction`= INGRESS) or outbound (`direction`= EGRESS) IP packets.
    /// 
    /// </summary>
    public class SecurityRule 
    {
        
        /// <value>
        /// An optional description of your choice for the rule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Conceptually, this is the range of IP addresses that a packet originating from the instance
        /// can go to.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * An IP address range in CIDR notation. For Example: 192.168.1.0/24 or 2001:0db8:0123:45::/56    IPv6 addressing is supported for all commercial and government regions.    See [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).  * The cidrBlock value for a {@link Service}, if you're    setting up a security rule for traffic destined for a particular Service through    a service gateway. For
        /// </value>
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
                ///
        /// <value>
        /// Type of destination for the rule. Required if `direction` = `EGRESS`.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// <br/>
        ///   * `NETWORK_SECURITY_GROUP`: If the rule's `destination` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a
        ///     {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        ///
        public enum DestinationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "SERVICE_CIDR_BLOCK")]
            ServiceCidrBlock,
            [EnumMember(Value = "NETWORK_SECURITY_GROUP")]
            NetworkSecurityGroup
        };

        /// <value>
        /// Type of destination for the rule. Required if `direction` = `EGRESS`.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// <br/>
        ///   * `NETWORK_SECURITY_GROUP`: If the rule's `destination` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a
        ///     {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DestinationTypeEnum> DestinationType { get; set; }
                ///
        /// <value>
        /// Direction of the security rule. Set to `EGRESS` for rules to allow outbound IP packets,
        /// or `INGRESS` for rules to allow inbound IP packets.
        /// 
        /// </value>
        ///
        public enum DirectionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EGRESS")]
            Egress,
            [EnumMember(Value = "INGRESS")]
            Ingress
        };

        /// <value>
        /// Direction of the security rule. Set to `EGRESS` for rules to allow outbound IP packets,
        /// or `INGRESS` for rules to allow inbound IP packets.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Direction is required.")]
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DirectionEnum> Direction { get; set; }
        
        [JsonProperty(PropertyName = "icmpOptions")]
        public IcmpOptions IcmpOptions { get; set; }
        
        /// <value>
        /// An Oracle-assigned identifier for the security rule. You specify this ID when you want to
        /// update or delete the rule.
        /// <br/>
        /// Example: 04ABEC
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A stateless rule allows traffic in one direction. Remember to add a corresponding
        /// stateless rule in the other direction if you need to support bidirectional traffic. For
        /// example, if egress traffic allows TCP destination port 80, there should be an ingress
        /// rule to allow TCP source port 80. Defaults to false, which means the rule is stateful
        /// and a corresponding rule is not necessary for bidirectional traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isStateless")]
        public System.Nullable<bool> IsStateless { get; set; }
        
        /// <value>
        /// Whether the rule is valid. The value is `True` when the rule is first created. If
        /// the rule's `source` or `destination` is a network security group, the value changes to
        /// `False` if that network security group is deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isValid")]
        public System.Nullable<bool> IsValid { get; set; }
        
        /// <value>
        /// The transport protocol. Specify either `all` or an IPv4 protocol number as
        /// defined in
        /// [Protocol Numbers](http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml).
        /// Options are supported only for ICMP (\"1\"), TCP (\"6\"), UDP (\"17\"), and ICMPv6 (\"58\").
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// Conceptually, this is the range of IP addresses that a packet coming into the instance
        /// can come from.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * An IP address range in CIDR notation. For Example: 192.168.1.0/24 or 2001:0db8:0123:45::/56    IPv6 addressing is supported for all commercial and government regions.    See [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).  * The cidrBlock value for a {@link Service}, if you're    setting up a security rule for traffic coming from a particular Service through    a service gateway. For
        /// </value>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
                ///
        /// <value>
        /// Type of source for the rule. Required if `direction` = `INGRESS`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `source` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `source` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic coming from a
        ///     particular `Service` through a service gateway).
        /// <br/>
        ///   * `NETWORK_SECURITY_GROUP`: If the rule's `source` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a
        ///     {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "SERVICE_CIDR_BLOCK")]
            ServiceCidrBlock,
            [EnumMember(Value = "NETWORK_SECURITY_GROUP")]
            NetworkSecurityGroup
        };

        /// <value>
        /// Type of source for the rule. Required if `direction` = `INGRESS`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `source` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `source` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic coming from a
        ///     particular `Service` through a service gateway).
        /// <br/>
        ///   * `NETWORK_SECURITY_GROUP`: If the rule's `source` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a
        ///     {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceTypeEnum> SourceType { get; set; }
        
        [JsonProperty(PropertyName = "tcpOptions")]
        public TcpOptions TcpOptions { get; set; }
        
        /// <value>
        /// The date and time the security rule was created. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        [JsonProperty(PropertyName = "udpOptions")]
        public UdpOptions UdpOptions { get; set; }
        
    }
}
