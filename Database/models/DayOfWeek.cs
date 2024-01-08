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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Day of the week.
    /// </summary>
    public class DayOfWeek 
    {
                ///
        /// <value>
        /// Name of the day of the week.
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
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
            Saturday,
            [EnumMember(Value = "SUNDAY")]
            Sunday
        };

        /// <value>
        /// Name of the day of the week.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
        
    }
}
