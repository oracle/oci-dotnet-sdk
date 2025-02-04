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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details required to create a Read Endpoint.
    /// 
    /// </summary>
    public class CreateReadEndpointDetails 
    {
        
        /// <value>
        /// Specifies if the DB System read endpoint is enabled or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The IP address the DB System read endpoint is configured to listen on.
        /// A private IP address of your choice to assign to the read endpoint of the DB System.
        /// Must be an available IP address within the subnet's CIDR. If you don't specify a value,
        /// Oracle automatically assigns a private IP address from the subnet. This should be a
        /// \"dotted-quad\" style IPv4 address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "readEndpointIpAddress")]
        public string ReadEndpointIpAddress { get; set; }
        
        /// <value>
        /// The hostname for the read endpoint of the DB System. Used for DNS.
        /// <br/>
        /// The value is the hostname portion of the primary private IP's fully qualified domain name (FQDN) 
        /// (for example, \"dbsystem-1\" in FQDN \"dbsystem-1.subnet123.vcn1.oraclevcn.com\").
        /// <br/>
        /// Must be unique across all VNICs in the subnet and comply with RFC 952 and RFC 1123.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "readEndpointHostnameLabel")]
        public string ReadEndpointHostnameLabel { get; set; }
        
        /// <value>
        /// A list of IP addresses of read replicas that are excluded from serving read requests.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "excludeIps")]
        public System.Collections.Generic.List<string> ExcludeIps { get; set; }
        
    }
}
