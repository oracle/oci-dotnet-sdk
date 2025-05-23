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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The scope of analytics data.
    /// </summary>
    public class FindingAnalyticsDimensions 
    {
        
        /// <value>
        /// Each finding in security assessment has an associated key (think of key as a finding's name).
        /// For a given finding, the key will be the same across targets. The user can use these keys to filter the findings.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The category of the top finding.
        /// </value>
        [JsonProperty(PropertyName = "topFindingCategory")]
        public string TopFindingCategory { get; set; }
        
        /// <value>
        /// The short title of the finding.
        /// </value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
                ///
        /// <value>
        /// The status of the top finding. 
        /// All findings will have \"severity\" to indicate the risk level, but only top findings will have \"status\". 
        /// Possible status: Pass / Risk (Low, Medium, High)/ Evaluate / Advisory / Deferred
        /// Instead of having \"Low, Medium, High\" in severity, \"Risk\" will include these three situations in status.
        /// 
        /// </value>
        ///
        public enum TopFindingStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RISK")]
            Risk,
            [EnumMember(Value = "EVALUATE")]
            Evaluate,
            [EnumMember(Value = "ADVISORY")]
            Advisory,
            [EnumMember(Value = "PASS")]
            Pass,
            [EnumMember(Value = "DEFERRED")]
            Deferred
        };

        /// <value>
        /// The status of the top finding. 
        /// All findings will have \"severity\" to indicate the risk level, but only top findings will have \"status\". 
        /// Possible status: Pass / Risk (Low, Medium, High)/ Evaluate / Advisory / Deferred
        /// Instead of having \"Low, Medium, High\" in severity, \"Risk\" will include these three situations in status.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topFindingStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TopFindingStatusEnum> TopFindingStatus { get; set; }
                ///
        /// <value>
        /// The severity (risk level) of the finding.
        /// </value>
        ///
        public enum SeverityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "EVALUATE")]
            Evaluate,
            [EnumMember(Value = "ADVISORY")]
            Advisory,
            [EnumMember(Value = "PASS")]
            Pass,
            [EnumMember(Value = "DEFERRED")]
            Deferred
        };

        /// <value>
        /// The severity (risk level) of the finding.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The OCID of the target database.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
    }
}
