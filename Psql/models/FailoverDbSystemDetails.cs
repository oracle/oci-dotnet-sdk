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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Database system failover information.
    /// </summary>
    public class FailoverDbSystemDetails 
    {
        
        /// <value>
        /// The preferred AD for regions with three availability domains. This parameter is optional. 
        /// If not set, the AD will be chosen based on availability.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ad")]
        public string Ad { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database instance node. This parameter is optional.
        /// If not set, an existing database instance node will be chosen based on availability.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbInstanceId")]
        public string DbInstanceId { get; set; }
        
    }
}
