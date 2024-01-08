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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Customer's Real Application Cluster (RAC)'s SCAN listener FQDN, port or list IPs and their ports.
    /// 
    /// </summary>
    public class ScanListenerInfo 
    {
        
        /// <value>
        /// FQDN of the customer's Real Application Cluster (RAC)'s SCAN listeners.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanListenerFqdn")]
        public string ScanListenerFqdn { get; set; }
        
        /// <value>
        /// A SCAN listener's IP of the customer's Real Application Cluster (RAC).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanListenerIp")]
        public string ScanListenerIp { get; set; }
        
        /// <value>
        /// The port that customer's Real Application Cluster (RAC)'s SCAN listeners are listening on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPort")]
        public System.Nullable<int> ScanListenerPort { get; set; }
        
    }
}
