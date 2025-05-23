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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Details of the detector recipe and detector rule mapped to the data source.
    /// </summary>
    public class DataSourceMappingInfo 
    {
        
        /// <value>
        /// ID of the detector recipe attached to the data source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRecipeId is required.")]
        [JsonProperty(PropertyName = "detectorRecipeId")]
        public string DetectorRecipeId { get; set; }
        
        /// <value>
        /// ID of the detector rule attached to the data source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRuleId is required.")]
        [JsonProperty(PropertyName = "detectorRuleId")]
        public string DetectorRuleId { get; set; }
        
    }
}
