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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Start policy that defines the exact start time
    /// </summary>
    public class AbsoluteTimeStartPolicy : ContinuousQueryStartPolicy
    {
        
        /// <value>
        /// Time when the query can start. If not specified it can start immediately
        /// </value>
        [JsonProperty(PropertyName = "queryStartTime")]
        public System.Nullable<System.DateTime> QueryStartTime { get; set; }
        
        [JsonProperty(PropertyName = "startPolicyType")]
        private readonly string startPolicyType = "ABSOLUTE_TIME_START_POLICY";
    }
}
