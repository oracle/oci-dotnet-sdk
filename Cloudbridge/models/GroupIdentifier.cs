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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// Describes a security group.
    /// </summary>
    public class GroupIdentifier 
    {
        
        /// <value>
        /// The ID of the security group.
        /// </value>
        [JsonProperty(PropertyName = "groupKey")]
        public string GroupKey { get; set; }
        
        /// <value>
        /// The name of the security group.
        /// </value>
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
        
    }
}
