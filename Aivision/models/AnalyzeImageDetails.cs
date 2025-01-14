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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The details of how to analyze an image.
    /// </summary>
    public class AnalyzeImageDetails 
    {
        
        /// <value>
        /// The types of image analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Features is required.")]
        [JsonProperty(PropertyName = "features")]
        public System.Collections.Generic.List<ImageFeature> Features { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Image is required.")]
        [JsonProperty(PropertyName = "image")]
        public ImageDetails Image { get; set; }
        
        /// <value>
        /// The OCID of the compartment that calls the API.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
    }
}
