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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// Label Metrics report for Document Classification Model.
    /// </summary>
    public class DocumentClassificationLabelMetricsReport 
    {
        
        /// <value>
        /// Label name
        /// </value>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// Mean average precision under different thresholds
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MeanAveragePrecision is required.")]
        [JsonProperty(PropertyName = "meanAveragePrecision")]
        public System.Nullable<float> MeanAveragePrecision { get; set; }
        
        /// <value>
        /// List of document classification confidence report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfidenceEntries is required.")]
        [JsonProperty(PropertyName = "confidenceEntries")]
        public System.Collections.Generic.List<DocumentClassificationConfidenceEntry> ConfidenceEntries { get; set; }
        
    }
}
