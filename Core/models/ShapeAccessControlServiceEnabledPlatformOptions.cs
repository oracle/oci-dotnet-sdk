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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Configuration options for the Access Control Service.
    /// 
    /// </summary>
    public class ShapeAccessControlServiceEnabledPlatformOptions 
    {
        
        /// <value>
        /// Whether the Access Control Service can be enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowedValues")]
        public System.Collections.Generic.List<bool> AllowedValues { get; set; }
        
        /// <value>
        /// Whether the Access Control Service is enabled by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefaultEnabled")]
        public System.Nullable<bool> IsDefaultEnabled { get; set; }
        
    }
}
