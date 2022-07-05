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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary for all the statistic findings of an object in a SQL Tuning Advisor task. Includes the object's hash, name, type, schema, problem type and the object reference count.
    /// </summary>
    public class SqlTuningAdvisorTaskSummaryReportObjectStatFindingSummary 
    {
        
        /// <value>
        /// Numerical representation of the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectHashValue is required.")]
        [JsonProperty(PropertyName = "objectHashValue")]
        public System.Nullable<long> ObjectHashValue { get; set; }
        
        /// <value>
        /// Name of the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// Type of the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectType is required.")]
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// Schema of the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Schema is required.")]
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }
                ///
        /// <value>
        /// Type of statistics problem related to the object.
        /// </value>
        ///
        public enum ProblemTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MISSING")]
            Missing,
            [EnumMember(Value = "STALE")]
            Stale
        };

        /// <value>
        /// Type of statistics problem related to the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemType is required.")]
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProblemTypeEnum> ProblemType { get; set; }
        
        /// <value>
        /// The number of the times the object is referenced within the SQL Tuning advisor task findings.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReferenceCount is required.")]
        [JsonProperty(PropertyName = "referenceCount")]
        public System.Nullable<int> ReferenceCount { get; set; }
        
    }
}
