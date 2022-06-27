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
    /// An individual port speed level for cross-connects.
    /// 
    /// </summary>
    public class CrossConnectPortSpeedShape 
    {
        
        /// <value>
        /// The name of the port speed shape.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The port speed in Gbps.
        /// <br/>
        /// Example: 10
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PortSpeedInGbps is required.")]
        [JsonProperty(PropertyName = "portSpeedInGbps")]
        public System.Nullable<int> PortSpeedInGbps { get; set; }
        
    }
}
