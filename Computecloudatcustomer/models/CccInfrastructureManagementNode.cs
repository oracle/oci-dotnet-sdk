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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// Information about an individual management node in a Compute Cloud@Customer infrastructure.
    /// 
    /// </summary>
    public class CccInfrastructureManagementNode 
    {
        
        /// <value>
        /// Address of the management node.
        /// </value>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }
        
        /// <value>
        /// Hostname for interface to the management node.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
    }
}
