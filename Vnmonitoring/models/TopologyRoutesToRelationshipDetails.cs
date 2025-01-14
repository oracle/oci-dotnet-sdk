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
    /// Defines route rule details for a `routesTo` relationship.
    /// </summary>
    public class TopologyRoutesToRelationshipDetails 
    {
        
        /// <value>
        /// The destinationType can be set to one of two values:
        /// <br/>
        /// * Use `CIDR_BLOCK` if the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        /// * Use `SERVICE_CIDR_BLOCK` if the rule's `destination` is the `cidrBlock` value for a {@link Service}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationType is required.")]
        [JsonProperty(PropertyName = "destinationType")]
        public string DestinationType { get; set; }
        
        /// <value>
        /// An IP address range in CIDR notation or the `cidrBlock` value for a {@link Service}.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the routing table that contains the route rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RouteTableId is required.")]
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
                ///
        /// <value>
        /// A route rule can be `STATIC` if manually added to the route table or `DYNAMIC` if imported from another route table.
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
        /// A route rule can be `STATIC` if manually added to the route table or `DYNAMIC` if imported from another route table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RouteTypeEnum> RouteType { get; set; }
        
    }
}
