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
    /// Summary of audit log of risk updates of findings of specified security assessment.
    /// </summary>
    public class FindingsChangeAuditLogSummary 
    {
        
        /// <value>
        /// The unique key that identifies the finding risk change.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The unique key that identifies the finding.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FindingKey is required.")]
        [JsonProperty(PropertyName = "findingKey")]
        public string FindingKey { get; set; }
        
        /// <value>
        /// The short title for the finding whose risk is being modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FindingTitle is required.")]
        [JsonProperty(PropertyName = "findingTitle")]
        public string FindingTitle { get; set; }
        
        /// <value>
        /// The OCID of the latest security assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssessmentId is required.")]
        [JsonProperty(PropertyName = "assessmentId")]
        public string AssessmentId { get; set; }
        
        /// <value>
        /// The OCID of the target database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The date and time the risk level of finding was last updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The original severity / risk level of the finding as determined by security assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Severity is required.")]
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Finding.SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The severity of the finding as determined by security assessment by Oracle.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OracleDefinedSeverity is required.")]
        [JsonProperty(PropertyName = "oracleDefinedSeverity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Finding.SeverityEnum> OracleDefinedSeverity { get; set; }
        
        /// <value>
        /// Determines if the user has deferred the risk level of this finding when he is ok with it 
        /// and does not plan to do anything about it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRiskDeferred is required.")]
        [JsonProperty(PropertyName = "isRiskDeferred")]
        public System.Nullable<bool> IsRiskDeferred { get; set; }
        
        /// <value>
        /// If the risk level is changed more than once, the previous modified value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PreviousSeverity is required.")]
        [JsonProperty(PropertyName = "previousSeverity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Finding.SeverityEnum> PreviousSeverity { get; set; }
        
        /// <value>
        /// The justification given by the user for accepting or modifying the risk level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Justification is required.")]
        [JsonProperty(PropertyName = "justification")]
        public string Justification { get; set; }
        
        /// <value>
        /// The date and time, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339),
        /// the risk level change as updated by user is valid until. After this date passes, the risk level
        /// will be that of what is determined by the latest security assessment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeValidUntil")]
        public System.Nullable<System.DateTime> TimeValidUntil { get; set; }
        
        /// <value>
        /// The user who initiated change of risk level of the finding
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModifiedBy is required.")]
        [JsonProperty(PropertyName = "modifiedBy")]
        public string ModifiedBy { get; set; }
        
    }
}
