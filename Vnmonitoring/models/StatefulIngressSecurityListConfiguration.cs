/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the stateful subnet ingress security list configuration that allowed the egress traffic.
    /// 
    /// </summary>
    public class StatefulIngressSecurityListConfiguration : AllowedSecurityConfiguration
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the security
        /// list that allowed the traffic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityListId is required.")]
        [JsonProperty(PropertyName = "securityListId")]
        public string SecurityListId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityRule is required.")]
        [JsonProperty(PropertyName = "securityRule")]
        public EgressSecurityRule SecurityRule { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "STATEFUL_INGRESS_SECURITY_LIST";
    }
}
