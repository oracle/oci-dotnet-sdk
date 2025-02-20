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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// The metadata associated with the strategy. The strategy is the method used to apply the recommendation.
    /// 
    /// </summary>
    public class Strategy 
    {
        
        /// <value>
        /// The name of the strategy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StrategyName is required.")]
        [JsonProperty(PropertyName = "strategyName")]
        public string StrategyName { get; set; }
        
        /// <value>
        /// Whether this is the default recommendation strategy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDefault is required.")]
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// The list of strategies for the parameters.
        /// </value>
        [JsonProperty(PropertyName = "parametersDefinition")]
        public System.Collections.Generic.List<StrategyParameter> ParametersDefinition { get; set; }
        
    }
}
