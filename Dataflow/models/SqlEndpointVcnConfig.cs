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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// The VCN configuration for VCN network type selection.
    /// </summary>
    public class SqlEndpointVcnConfig : SqlEndpointNetworkConfiguration
    {
        
        /// <value>
        /// The VCN OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The VCN Subnet OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The host name prefix.
        /// </value>
        [JsonProperty(PropertyName = "hostNamePrefix")]
        public string HostNamePrefix { get; set; }
        
        /// <value>
        /// The OCIDs of Network Security Groups (NSGs).
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// Ip Address of private endpoint
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }
        
        [JsonProperty(PropertyName = "networkType")]
        private readonly string networkType = "VCN";
    }
}
