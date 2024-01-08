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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// The information for a left certificate for a rover node
    /// </summary>
    public class LeafCertificateResponse 
    {
        
        /// <value>
        /// The id of the rover node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RoverNodeId is required.")]
        [JsonProperty(PropertyName = "roverNodeId")]
        public string RoverNodeId { get; set; }
        
        [JsonProperty(PropertyName = "leafCertificateDetails")]
        public LeafCertificateDetails LeafCertificateDetails { get; set; }
        
    }
}
