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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A model to hold time in hour:minute:second format.
    /// </summary>
    public class Time 
    {
        
        /// <value>
        /// The hour value.
        /// </value>
        [JsonProperty(PropertyName = "hour")]
        public System.Nullable<int> Hour { get; set; }
        
        /// <value>
        /// The minute value.
        /// </value>
        [JsonProperty(PropertyName = "minute")]
        public System.Nullable<int> Minute { get; set; }
        
        /// <value>
        /// The second value.
        /// </value>
        [JsonProperty(PropertyName = "second")]
        public System.Nullable<int> Second { get; set; }
        
    }
}
