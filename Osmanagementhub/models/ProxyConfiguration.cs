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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Information for a proxy configuration
    /// </summary>
    public class ProxyConfiguration 
    {
        
        /// <value>
        /// To enable or disable the proxy (default true)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// List of hosts
        /// </value>
        [JsonProperty(PropertyName = "hosts")]
        public System.Collections.Generic.List<string> Hosts { get; set; }
        
        /// <value>
        /// Port that the proxy will use
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// URL that the proxy will forward to
        /// </value>
        [JsonProperty(PropertyName = "forward")]
        public string Forward { get; set; }
        
    }
}