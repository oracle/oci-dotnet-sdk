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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// The documents details for text classification call.
    /// </summary>
    public class BatchDetectLanguageTextClassificationDetails 
    {
        
        /// <value>
        /// Unique name across user tenancy in a region to identify an endpoint to be used for inferencing.
        /// </value>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that calls the API, inference will be served from pre trained model
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The endpoint which have to be used for inferencing. If endpointId and compartmentId is provided, then inference will be served from custom model which is mapped to this Endpoint.
        /// </value>
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }
        
        /// <value>
        /// List of Documents for detect text classification.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Documents is required.")]
        [JsonProperty(PropertyName = "documents")]
        public System.Collections.Generic.List<TextDocument> Documents { get; set; }
        
    }
}
