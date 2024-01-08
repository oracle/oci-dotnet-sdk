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
    /// <summary>
    /// A DRG route rule is a mapping between a destination IP address range and a DRG attachment.
    /// The map is used to route matching packets. Traffic will be routed across the attachments using Equal-cost multi-path routing (ECMP)
    /// if there are multiple rules with identical destinations and none of the rules conflict.
    /// 
    /// </summary>
    public class DrgRouteRule 
    {
        
        /// <value>
        /// Represents the range of IP addresses to match against when routing traffic.
        /// <br/>
        /// Potential values:
        ///   * An IP address range (IPv4 or IPv6) in CIDR notation. For Example: 192.168.1.0/24  or 2001:0db8:0123:45::/56.  * When you're setting up a security rule for traffic destined for a particular Service through  a service gateway, this is the cidrBlock value associated with that {@link Service}. For
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
                ///
        /// <value>
        /// The type of destination for the rule.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
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
            ServiceCidrBlock
        };

        /// <value>
        /// The type of destination for the rule.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationType is required.")]
        [JsonProperty(PropertyName = "destinationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DestinationTypeEnum> DestinationType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the next hop DRG attachment responsible
        /// for reaching the network destination.
        /// <br/>
        /// A value of `BLACKHOLE` means traffic for this route is discarded without notification.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NextHopDrgAttachmentId is required.")]
        [JsonProperty(PropertyName = "nextHopDrgAttachmentId")]
        public string NextHopDrgAttachmentId { get; set; }
                ///
        /// <value>
        /// You can specify static routes for the DRG route table using the API.
        /// The DRG learns dynamic routes from the DRG attachments using various routing protocols.
        /// 
        /// </value>
        ///
        public enum RouteTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STATIC")]
            Static,
            [EnumMember(Value = "DYNAMIC")]
            Dynamic
        };

        /// <value>
        /// You can specify static routes for the DRG route table using the API.
        /// The DRG learns dynamic routes from the DRG attachments using various routing protocols.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RouteTypeEnum> RouteType { get; set; }
        
        /// <value>
        /// Indicates that the route was not imported due to a conflict between route rules.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isConflict")]
        public System.Nullable<bool> IsConflict { get; set; }
        
        /// <value>
        /// Indicates that if the next hop attachment does not exist, so traffic for this route is discarded without notification.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBlackhole")]
        public System.Nullable<bool> IsBlackhole { get; set; }
        
        /// <value>
        /// The Oracle-assigned ID of the DRG route rule.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The earliest origin of a route. If a route is advertised to a DRG through an IPsec tunnel attachment,
        /// and is propagated to peered DRGs via RPC attachments, the route's provenance in the peered DRGs remains `IPSEC_TUNNEL`,
        /// because that is the earliest origin.
        /// <br/>
        /// No routes with a provenance `IPSEC_TUNNEL` or `VIRTUAL_CIRCUIT` will be exported to IPsec tunnel or virtual circuit attachments,
        /// regardless of the attachment's export distribution.
        /// 
        /// </value>
        ///
        public enum RouteProvenanceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STATIC")]
            Static,
            [EnumMember(Value = "VCN")]
            Vcn,
            [EnumMember(Value = "VIRTUAL_CIRCUIT")]
            VirtualCircuit,
            [EnumMember(Value = "IPSEC_TUNNEL")]
            IpsecTunnel
        };

        /// <value>
        /// The earliest origin of a route. If a route is advertised to a DRG through an IPsec tunnel attachment,
        /// and is propagated to peered DRGs via RPC attachments, the route's provenance in the peered DRGs remains `IPSEC_TUNNEL`,
        /// because that is the earliest origin.
        /// <br/>
        /// No routes with a provenance `IPSEC_TUNNEL` or `VIRTUAL_CIRCUIT` will be exported to IPsec tunnel or virtual circuit attachments,
        /// regardless of the attachment's export distribution.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RouteProvenance is required.")]
        [JsonProperty(PropertyName = "routeProvenance")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RouteProvenanceEnum> RouteProvenance { get; set; }
        
        /// <value>
        /// Additional properties for the route, computed by the service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributes")]
        public System.Object Attributes { get; set; }
        
    }
}
