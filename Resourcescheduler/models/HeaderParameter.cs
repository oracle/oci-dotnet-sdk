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


namespace Oci.ResourceschedulerService.Models
{
    /// <summary>
    /// This is an input parameter that will be passed as HTTP request header.
    /// </summary>
    public class HeaderParameter : Parameter
    {
        
        /// <value>
        /// This is the HTTP request header value.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.Dictionary<string, string> Value { get; set; }
        
        [JsonProperty(PropertyName = "parameterType")]
        private readonly string parameterType = "HEADER";
    }
}
