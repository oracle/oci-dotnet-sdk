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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Connect Descriptor details.
    /// 
    /// </summary>
    public class ConnectDescriptor 
    {
        
        /// <value>
        /// Host of the connect descriptor.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// Port of the connect descriptor.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Database service name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseServiceName")]
        public string DatabaseServiceName { get; set; }
        
        /// <value>
        /// Connect string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectString")]
        public string ConnectString { get; set; }
        
    }
}
