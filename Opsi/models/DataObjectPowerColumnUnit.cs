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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Unit details of a data object column of POWER unit category.
    /// </summary>
    public class DataObjectPowerColumnUnit : DataObjectColumnUnit
    {
                ///
        /// <value>
        /// Power unit.
        /// </value>
        ///
        public enum UnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMP")]
            Amp,
            [EnumMember(Value = "WATT")]
            Watt,
            [EnumMember(Value = "KILO_WATT")]
            KiloWatt,
            [EnumMember(Value = "MEGA_WATT")]
            MegaWatt,
            [EnumMember(Value = "GIGA_WATT")]
            GigaWatt
        };

        /// <value>
        /// Power unit.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
        [JsonProperty(PropertyName = "unitCategory")]
        private readonly string unitCategory = "POWER";
    }
}
