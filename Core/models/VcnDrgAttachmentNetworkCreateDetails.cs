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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Specifies the VCN Attachment
    /// </summary>
    public class VcnDrgAttachmentNetworkCreateDetails : DrgAttachmentNetworkCreateDetails
    {
        
        /// <value>
        /// This is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table that is used to route the traffic as it enters a VCN through this attachment.
        /// <br/>
        /// For information about why you would associate a route table with a DRG attachment, see
        /// [Advanced Scenario: Transit Routing](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitrouting.htm).
        /// For information about why you would associate a route table with a DRG attachment, see:
        /// <br/>
        ///   * [Transit Routing: Access to Multiple VCNs in Same Region](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitrouting.htm)
        ///   * [Transit Routing: Private Access to Oracle Services](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitroutingoracleservices.htm)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
        
        /// <value>
        /// Indicates whether the VCN CIDRs or the individual subnet CIDRs are imported from the attachment.
        /// Routes from the VCN ingress route table are always imported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnRouteType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VcnDrgAttachmentNetworkDetails.VcnRouteTypeEnum> VcnRouteType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VCN";
    }
}
