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
    /// Details object containing advanced feature configurations to be updated.
    /// Ensure that the namespace and bucket storage are created prior to turning on the JfrRecording or CryptoEventAnalysis feature.
    /// 
    /// </summary>
    public class UpdateFleetAdvancedFeatureConfigurationDetails 
    {
        
        /// <value>
        /// Namespace for the Fleet advanced feature.
        /// </value>
        [JsonProperty(PropertyName = "analyticNamespace")]
        public string AnalyticNamespace { get; set; }
        
        /// <value>
        /// Bucket name required to store JFR and related data.
        /// </value>
        [JsonProperty(PropertyName = "analyticBucketName")]
        public string AnalyticBucketName { get; set; }
        
        [JsonProperty(PropertyName = "lcm")]
        public Lcm Lcm { get; set; }
        
        [JsonProperty(PropertyName = "cryptoEventAnalysis")]
        public CryptoEventAnalysis CryptoEventAnalysis { get; set; }
        
        [JsonProperty(PropertyName = "advancedUsageTracking")]
        public AdvancedUsageTracking AdvancedUsageTracking { get; set; }
        
        [JsonProperty(PropertyName = "jfrRecording")]
        public JfrRecording JfrRecording { get; set; }
        
        [JsonProperty(PropertyName = "performanceTuningAnalysis")]
        public PerformanceTuningAnalysis PerformanceTuningAnalysis { get; set; }
        
        [JsonProperty(PropertyName = "javaMigrationAnalysis")]
        public JavaMigrationAnalysis JavaMigrationAnalysis { get; set; }
        
    }
}
