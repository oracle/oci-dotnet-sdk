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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// Details for extending data retention for given integration instance
    /// </summary>
    public class ExtendDataRetentionDetails 
    {
                ///
        /// <value>
        /// Data retention period set for given integration instance
        /// </value>
        ///
        public enum DataRetentionPeriodEnum {
            [EnumMember(Value = "MONTHS_1")]
            Months1,
            [EnumMember(Value = "MONTHS_3")]
            Months3,
            [EnumMember(Value = "MONTHS_6")]
            Months6
        };

        /// <value>
        /// Data retention period set for given integration instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataRetentionPeriod is required.")]
        [JsonProperty(PropertyName = "dataRetentionPeriod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataRetentionPeriodEnum> DataRetentionPeriod { get; set; }
        
    }
}
