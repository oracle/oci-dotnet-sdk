/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Frequency Details model for weekly frequency based on day of week.
    /// </summary>
    public class WeeklyFrequencyDetails : AbstractFrequencyDetails
    {
        
        [JsonProperty(PropertyName = "time")]
        public Time Time { get; set; }
                ///
        ///
        public enum DaysEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUNDAY")]
            Sunday,
            [EnumMember(Value = "MONDAY")]
            Monday,
            [EnumMember(Value = "TUESDAY")]
            Tuesday,
            [EnumMember(Value = "WEDNESDAY")]
            Wednesday,
            [EnumMember(Value = "THURSDAY")]
            Thursday,
            [EnumMember(Value = "FRIDAY")]
            Friday,
            [EnumMember(Value = "SATURDAY")]
            Saturday
        };

        /// <value>
        /// A list of days of the week to be scheduled. i.e. execute on Monday and Thursday.
        /// </value>
        [JsonProperty(PropertyName = "days", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<DaysEnum> Days { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "WEEKLY";
    }
}
