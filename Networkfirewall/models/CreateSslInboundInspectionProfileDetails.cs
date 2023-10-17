/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Request for creating SSLInboundInspection used on the firewall policy rules.
    /// </summary>
    public class CreateSslInboundInspectionProfileDetails : CreateDecryptionProfileDetails
    {
        
        /// <value>
        /// Whether to block sessions if SSL version is not supported.
        /// </value>
        [JsonProperty(PropertyName = "isUnsupportedVersionBlocked")]
        public System.Nullable<bool> IsUnsupportedVersionBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if SSL cipher suite is not supported.
        /// </value>
        [JsonProperty(PropertyName = "isUnsupportedCipherBlocked")]
        public System.Nullable<bool> IsUnsupportedCipherBlocked { get; set; }
        
        /// <value>
        /// Whether to block sessions if the firewall is temporarily unable to decrypt their traffic.
        /// </value>
        [JsonProperty(PropertyName = "isOutOfCapacityBlocked")]
        public System.Nullable<bool> IsOutOfCapacityBlocked { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SSL_INBOUND_INSPECTION";
    }
}
