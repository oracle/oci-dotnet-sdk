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
    /// Defines the configuration for TCP protocol parameters.
    /// </summary>
    public class TcpProtocolParameters : ProtocolParameters
    {
        
        /// <value>
        /// The source port to use in a `PathAnalyzerTest` resource.
        /// </value>
        [JsonProperty(PropertyName = "sourcePort")]
        public System.Nullable<int> SourcePort { get; set; }
        
        /// <value>
        /// The destination port to use in a `PathAnalyzerTest` resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationPort is required.")]
        [JsonProperty(PropertyName = "destinationPort")]
        public System.Nullable<int> DestinationPort { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TCP";
    }
}
