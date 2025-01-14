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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// The logical configuration of the API exposed by a deployment.
    /// </summary>
    public class ApiSpecification 
    {
        
        [JsonProperty(PropertyName = "requestPolicies")]
        public ApiSpecificationRequestPolicies RequestPolicies { get; set; }
        
        [JsonProperty(PropertyName = "loggingPolicies")]
        public ApiSpecificationLoggingPolicies LoggingPolicies { get; set; }
        
        /// <value>
        /// A list of routes that this API exposes.
        /// </value>
        [JsonProperty(PropertyName = "routes")]
        public System.Collections.Generic.List<ApiSpecificationRoute> Routes { get; set; }
        
    }
}
