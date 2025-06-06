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
    /// Specifies the IPSec tunnel attached to the DRG.
    /// </summary>
    public class IpsecTunnelDrgAttachmentNetworkDetails : DrgAttachmentNetworkDetails
    {
        
        /// <value>
        /// The IPSec connection that contains the attached IPSec tunnel.
        /// </value>
        [JsonProperty(PropertyName = "ipsecConnectionId")]
        public string IpsecConnectionId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the virtual circuit's DRG attachment.
        /// </value>
        [JsonProperty(PropertyName = "transportAttachmentId")]
        public string TransportAttachmentId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "IPSEC_TUNNEL";
    }
}
