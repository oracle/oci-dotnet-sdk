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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Premigration Advisor report details.
    /// 
    /// </summary>
    public class AdvisorReport 
    {
        
        [JsonProperty(PropertyName = "reportLocationDetails")]
        public AdvisorReportLocationDetails ReportLocationDetails { get; set; }
        
        /// <value>
        /// Premigration Advisor result.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Result is required.")]
        [JsonProperty(PropertyName = "result")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AdvisorResults> Result { get; set; }
        
        /// <value>
        /// Number of Fatal results in the advisor report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfFatal is required.")]
        [JsonProperty(PropertyName = "numberOfFatal")]
        public System.Nullable<int> NumberOfFatal { get; set; }
        
        /// <value>
        /// Number of Fatal Blocker results in the advisor report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfFatalBlockers is required.")]
        [JsonProperty(PropertyName = "numberOfFatalBlockers")]
        public System.Nullable<int> NumberOfFatalBlockers { get; set; }
        
        /// <value>
        /// Number of Warning results in the advisor report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfWarnings is required.")]
        [JsonProperty(PropertyName = "numberOfWarnings")]
        public System.Nullable<int> NumberOfWarnings { get; set; }
        
        /// <value>
        /// Number of Informational results in the advisor report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfInformationalResults is required.")]
        [JsonProperty(PropertyName = "numberOfInformationalResults")]
        public System.Nullable<int> NumberOfInformationalResults { get; set; }
        
    }
}
