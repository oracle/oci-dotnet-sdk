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
    /// Summary of a masking report.
    /// </summary>
    public class MaskingReportSummary 
    {
        
        /// <value>
        /// The OCID of the masking report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the masking report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the masking work request that resulted in this masking report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskingWorkRequestId is required.")]
        [JsonProperty(PropertyName = "maskingWorkRequestId")]
        public string MaskingWorkRequestId { get; set; }
        
        /// <value>
        /// The OCID of the masking policy used.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskingPolicyId is required.")]
        [JsonProperty(PropertyName = "maskingPolicyId")]
        public string MaskingPolicyId { get; set; }
        
        /// <value>
        /// The OCID of the target database masked.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The total number of unique sensitive types associated with the masked columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMaskedSensitiveTypes is required.")]
        [JsonProperty(PropertyName = "totalMaskedSensitiveTypes")]
        public System.Nullable<long> TotalMaskedSensitiveTypes { get; set; }
        
        /// <value>
        /// The total number of unique schemas that contain the masked columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMaskedSchemas is required.")]
        [JsonProperty(PropertyName = "totalMaskedSchemas")]
        public System.Nullable<long> TotalMaskedSchemas { get; set; }
        
        /// <value>
        /// The total number of unique objects (tables and editioning views) that contain the masked columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMaskedObjects is required.")]
        [JsonProperty(PropertyName = "totalMaskedObjects")]
        public System.Nullable<long> TotalMaskedObjects { get; set; }
        
        /// <value>
        /// The total number of masked columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMaskedColumns is required.")]
        [JsonProperty(PropertyName = "totalMaskedColumns")]
        public System.Nullable<long> TotalMaskedColumns { get; set; }
        
        /// <value>
        /// The total number of masked values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMaskedValues is required.")]
        [JsonProperty(PropertyName = "totalMaskedValues")]
        public System.Nullable<long> TotalMaskedValues { get; set; }
        
        /// <value>
        /// The date and time data masking started, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMaskingStarted is required.")]
        [JsonProperty(PropertyName = "timeMaskingStarted")]
        public System.Nullable<System.DateTime> TimeMaskingStarted { get; set; }
        
        /// <value>
        /// The date and time data masking finished, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMaskingFinished is required.")]
        [JsonProperty(PropertyName = "timeMaskingFinished")]
        public System.Nullable<System.DateTime> TimeMaskingFinished { get; set; }
        
        /// <value>
        /// The current state of the masking report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaskingLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the masking report was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Indicates if the temporary tables created during the masking operation were dropped after masking.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDropTempTablesEnabled")]
        public System.Nullable<bool> IsDropTempTablesEnabled { get; set; }
        
        /// <value>
        /// Indicates if redo logging was enabled during the masking operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRedoLoggingEnabled")]
        public System.Nullable<bool> IsRedoLoggingEnabled { get; set; }
        
        /// <value>
        /// Indicates if statistics gathering was enabled during the masking operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRefreshStatsEnabled")]
        public System.Nullable<bool> IsRefreshStatsEnabled { get; set; }
        
        /// <value>
        /// Indicates if parallel execution was enabled during the masking operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parallelDegree")]
        public string ParallelDegree { get; set; }
        
        /// <value>
        /// Indicates how invalid objects were recompiled post the masking operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recompile")]
        public string Recompile { get; set; }
                ///
        /// <value>
        /// The status of the masking job.
        /// </value>
        ///
        public enum MaskingStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCESS")]
            Success
        };

        /// <value>
        /// The status of the masking job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskingStatus is required.")]
        [JsonProperty(PropertyName = "maskingStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaskingStatusEnum> MaskingStatus { get; set; }
        
        /// <value>
        /// The total number of errors in pre-masking script.
        /// </value>
        [JsonProperty(PropertyName = "totalPreMaskingScriptErrors")]
        public System.Nullable<long> TotalPreMaskingScriptErrors { get; set; }
        
        /// <value>
        /// The total number of errors in post-masking script.
        /// </value>
        [JsonProperty(PropertyName = "totalPostMaskingScriptErrors")]
        public System.Nullable<long> TotalPostMaskingScriptErrors { get; set; }
        
    }
}
