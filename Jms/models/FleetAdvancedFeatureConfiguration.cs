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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Metadata for the advanced features in the Fleet.
    /// </summary>
    public class FleetAdvancedFeatureConfiguration 
    {
        
        /// <value>
        /// Namespace for the Fleet advanced feature.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticNamespace is required.")]
        [JsonProperty(PropertyName = "analyticNamespace")]
        public string AnalyticNamespace { get; set; }
        
        /// <value>
        /// Bucket name required to store JFR and related data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticBucketName is required.")]
        [JsonProperty(PropertyName = "analyticBucketName")]
        public string AnalyticBucketName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Lcm is required.")]
        [JsonProperty(PropertyName = "lcm")]
        public Lcm Lcm { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CryptoEventAnalysis is required.")]
        [JsonProperty(PropertyName = "cryptoEventAnalysis")]
        public CryptoEventAnalysis CryptoEventAnalysis { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdvancedUsageTracking is required.")]
        [JsonProperty(PropertyName = "advancedUsageTracking")]
        public AdvancedUsageTracking AdvancedUsageTracking { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JfrRecording is required.")]
        [JsonProperty(PropertyName = "jfrRecording")]
        public JfrRecording JfrRecording { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PerformanceTuningAnalysis is required.")]
        [JsonProperty(PropertyName = "performanceTuningAnalysis")]
        public PerformanceTuningAnalysis PerformanceTuningAnalysis { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JavaMigrationAnalysis is required.")]
        [JsonProperty(PropertyName = "javaMigrationAnalysis")]
        public JavaMigrationAnalysis JavaMigrationAnalysis { get; set; }
        
        /// <value>
        /// The date and time of the last modification to the Fleet Agent Configuration (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastModified is required.")]
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
    }
}
