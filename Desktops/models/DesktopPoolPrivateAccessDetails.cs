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


namespace Oci.DesktopsService.Models
{
    /// <summary>
    /// The details of the desktop's private access network connectivity that were used to create the pool.
    /// 
    /// </summary>
    public class DesktopPoolPrivateAccessDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the customer VCN.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The three-label FQDN to use for the private endpoint. The customer VCN's DNS records are
        /// updated with this FQDN. This enables the customer to use the FQDN instead of the private endpoint's
        /// private IP address to access the service (for example,\u00A0xyz.oraclecloud.com).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpointFqdn")]
        public string EndpointFqdn { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet in the customer VCN where the
        /// connectivity will be established.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// A list of network security groups for the private access.
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The IPv4 address from the provided OCI subnet which needs to be assigned to the VNIC. If not provided, it will
        /// be auto-assigned with an available IPv4 address from the subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
    }
}