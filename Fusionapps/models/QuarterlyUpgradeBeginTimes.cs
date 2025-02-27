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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Determines the quarterly upgrade begin times (monthly maintenance group schedule ) of the Fusion environment.
    /// </summary>
    public class QuarterlyUpgradeBeginTimes 
    {
                ///
        /// <value>
        /// Determines if the maintenance schedule of the Fusion environment is inherited from the Fusion environment family.
        /// </value>
        ///
        public enum OverrideTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OVERRIDDEN")]
            Overridden,
            [EnumMember(Value = "INHERITED")]
            Inherited
        };

        /// <value>
        /// Determines if the maintenance schedule of the Fusion environment is inherited from the Fusion environment family.
        /// </value>
        [JsonProperty(PropertyName = "overrideType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OverrideTypeEnum> OverrideType { get; set; }
        
        /// <value>
        /// The frequency and month when maintenance occurs for the Fusion environment.
        /// </value>
        [JsonProperty(PropertyName = "beginTimesValue")]
        public string BeginTimesValue { get; set; }
        
    }
}
