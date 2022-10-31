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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Policy to specify how to modify the response code, body and headers.
    /// 
    /// </summary>
    public class ModifyResponseValidationFailurePolicy : ValidationFailurePolicy
    {
        
        /// <value>
        /// HTTP response code, can include context variables.
        /// </value>
        [JsonProperty(PropertyName = "responseCode")]
        public string ResponseCode { get; set; }
        
        /// <value>
        /// HTTP response message.
        /// </value>
        [JsonProperty(PropertyName = "responseMessage")]
        public string ResponseMessage { get; set; }
        
        [JsonProperty(PropertyName = "responseHeaderTransformations")]
        public HeaderTransformationPolicy ResponseHeaderTransformations { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "MODIFY_RESPONSE";
    }
}