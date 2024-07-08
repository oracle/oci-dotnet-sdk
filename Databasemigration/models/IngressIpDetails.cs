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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Private Endpoint IP Addresses created in the customer's subnet.
    /// </summary>
    public class IngressIpDetails 
    {
        
        /// <value>
        /// A Private Endpoint IPv4 or IPv6 Address created in the customer's subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IngressIp is required.")]
        [JsonProperty(PropertyName = "ingressIp")]
        public string IngressIp { get; set; }
        
    }
}