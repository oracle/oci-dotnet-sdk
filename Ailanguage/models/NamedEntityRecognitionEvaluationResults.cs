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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Named entity recognition model testing and evaluation results
    /// </summary>
    public class NamedEntityRecognitionEvaluationResults : EvaluationResults
    {
        
        [JsonProperty(PropertyName = "metrics")]
        public NamedEntityRecognitionModelMetrics Metrics { get; set; }
        
        /// <value>
        /// List of entity metrics
        /// </value>
        [JsonProperty(PropertyName = "entityMetrics")]
        public System.Collections.Generic.List<EntityMetrics> EntityMetrics { get; set; }
        
        /// <value>
        /// class level confusion matrix
        /// </value>
        [JsonProperty(PropertyName = "confusionMatrix")]
        public System.Collections.Generic.Dictionary<string, ConfusionMatrixDetails> ConfusionMatrix { get; set; }
        
        /// <value>
        /// labels
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "NAMED_ENTITY_RECOGNITION";
    }
}
