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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// DNS settings for containers.
    /// </summary>
    public class ContainerDnsConfig 
    {
        
        /// <value>
        /// IP address of the name server..
        /// </value>
        [JsonProperty(PropertyName = "nameservers")]
        public System.Collections.Generic.List<string> Nameservers { get; set; }
        
        /// <value>
        /// Search list for hostname lookup.
        /// </value>
        [JsonProperty(PropertyName = "searches")]
        public System.Collections.Generic.List<string> Searches { get; set; }
        
        /// <value>
        /// Options allows certain internal resolver variables to be modified.
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public System.Collections.Generic.List<string> Options { get; set; }
        
    }
}
