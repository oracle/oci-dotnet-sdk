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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Details about the batch image analysis.
    /// </summary>
    public class CreateImageJobDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InputLocation is required.")]
        [JsonProperty(PropertyName = "inputLocation")]
        public InputLocation InputLocation { get; set; }
        
        /// <value>
        /// List of image analysis types requested.
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
        [Required(ErrorMessage = "OutputLocation is required.")]
        [JsonProperty(PropertyName = "outputLocation")]
        public OutputLocation OutputLocation { get; set; }
        
        /// <value>
        /// Compartment identifier from the requester.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Image job display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Whether to generate a Zip file containing the results.
        /// </value>
        [JsonProperty(PropertyName = "isZipOutputEnabled")]
        public System.Nullable<bool> IsZipOutputEnabled { get; set; }
        
    }
}