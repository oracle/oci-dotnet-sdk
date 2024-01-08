/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// The result of the endpoint configuration validation
    /// </summary>
    public class ValidateEndpointResult 
    {
        
        /// <value>
        /// The validation status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// The validation status description.
        /// </value>
        [JsonProperty(PropertyName = "statusDescription")]
        public string StatusDescription { get; set; }
        
        /// <value>
        /// Validation results for each specified endpoint.
        /// </value>
        [JsonProperty(PropertyName = "validationResults")]
        public System.Collections.Generic.List<EndpointResult> ValidationResults { get; set; }
        
    }
}
