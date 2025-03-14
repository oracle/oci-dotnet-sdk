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


namespace Oci.HealthchecksService.Models
{
    /// <summary>
    /// The routing information for a vantage point.
    /// </summary>
    public class Routing 
    {
        
        /// <value>
        /// The registry label for `asn`, usually the name of the organization that
        /// owns the ASN. May be omitted or null.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "asLabel")]
        public string AsLabel { get; set; }
        
        /// <value>
        /// The Autonomous System Number (ASN) identifying the organization
        /// responsible for routing packets to `prefix`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "asn")]
        public System.Nullable<int> Asn { get; set; }
        
        /// <value>
        /// An IP prefix (CIDR syntax) that is less specific than
        /// `address`, through which `address` is routed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// An integer between 0 and 100 used to select between multiple
        /// origin ASNs when routing to `prefix`. Most prefixes have
        /// exactly one origin ASN, in which case `weight` will be 100.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<int> Weight { get; set; }
        
    }
}
