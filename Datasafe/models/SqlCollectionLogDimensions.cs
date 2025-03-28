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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The dimensions available for SQL collection analytics.
    /// </summary>
    public class SqlCollectionLogDimensions 
    {
        
        /// <value>
        /// The IP addresses for the SQL collection.
        /// </value>
        [JsonProperty(PropertyName = "clientIp")]
        public string ClientIp { get; set; }
        
        /// <value>
        /// The operating system user names for the SQL collection.
        /// </value>
        [JsonProperty(PropertyName = "clientOsUserName")]
        public string ClientOsUserName { get; set; }
        
        /// <value>
        /// The allowed client programs for the SQL collection.
        /// </value>
        [JsonProperty(PropertyName = "clientProgram")]
        public string ClientProgram { get; set; }
        
    }
}
