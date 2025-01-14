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
    /// The particular finding reported by the security assessment.
    /// </summary>
    public class Finding 
    {
        
        /// <value>
        /// A unique identifier for the finding. This is common for the finding across targets.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
                ///
        /// <value>
        /// The severity of the finding.
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
        /// The severity of the finding.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The OCID of the assessment that generated this finding.
        /// </value>
        [JsonProperty(PropertyName = "assessmentId")]
        public string AssessmentId { get; set; }
        
        /// <value>
        /// The OCID of the target database.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The short title for the finding.
        /// </value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        
        /// <value>
        /// The explanation of the issue in this finding. It explains the reason for the rule and, if a risk is reported, it may also explain the recommended actions for remediation.
        /// </value>
        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }
        
        /// <value>
        /// The details of the finding. Provides detailed information to explain the finding summary, typically results from the assessed database, followed by any recommendations for changes.
        /// </value>
        [JsonProperty(PropertyName = "details")]
        public System.Object Details { get; set; }
        
        /// <value>
        /// The brief summary of the finding. When the finding is informational, the summary typically reports only the number of data elements that were examined.
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// Provides information on whether the finding is related to a CIS Oracle Database Benchmark recommendation, STIG rule, or related to a GDPR Article/Recital.
        /// </value>
        [JsonProperty(PropertyName = "references")]
        public References References { get; set; }
        
        /// <value>
        /// The severity of the finding as determined by security assessment. This cannot be modified by user.
        /// </value>
        [JsonProperty(PropertyName = "oracleDefinedSeverity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Finding.SeverityEnum> OracleDefinedSeverity { get; set; }
        
        /// <value>
        /// Determines if this risk level was modified by user.
        /// </value>
        [JsonProperty(PropertyName = "isRiskModified")]
        public System.Nullable<bool> IsRiskModified { get; set; }
        
        /// <value>
        /// Determines if this risk level has changed on the target database since the last time 'severity' was modified by user.
        /// </value>
        [JsonProperty(PropertyName = "hasTargetDbRiskLevelChanged")]
        public System.Nullable<bool> HasTargetDbRiskLevelChanged { get; set; }
        
        /// <value>
        /// User provided reason for accepting or modifying this finding if they choose to do so.
        /// </value>
        [JsonProperty(PropertyName = "justification")]
        public string Justification { get; set; }
        
        /// <value>
        /// The time until which the change in severity(deferred/modified) of this finding is valid.
        /// </value>
        [JsonProperty(PropertyName = "timeValidUntil")]
        public System.Nullable<System.DateTime> TimeValidUntil { get; set; }
        
        /// <value>
        /// The date and time the risk level of finding was last updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the finding.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FindingLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the finding.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }
}
