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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// IORM Setting details for this Exadata System to be updated
    /// 
    /// </summary>
    public class ExadataIormConfigUpdateDetails 
    {
                ///
        /// <value>
        /// Value for the IORM objective
        /// Default is \"Auto\"
        /// 
        /// </value>
        ///
        public enum ObjectiveEnum {
            [EnumMember(Value = "LOW_LATENCY")]
            LowLatency,
            [EnumMember(Value = "HIGH_THROUGHPUT")]
            HighThroughput,
            [EnumMember(Value = "BALANCED")]
            Balanced,
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "BASIC")]
            Basic
        };

        /// <value>
        /// Value for the IORM objective
        /// Default is \"Auto\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objective")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ObjectiveEnum> Objective { get; set; }
        
        /// <value>
        /// Array of IORM Setting for all the database in
        /// this Exadata DB System
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbPlans")]
        public System.Collections.Generic.List<DbIormConfigUpdateDetail> DbPlans { get; set; }
        
    }
}
