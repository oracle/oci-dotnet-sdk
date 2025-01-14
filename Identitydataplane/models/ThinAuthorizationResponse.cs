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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class ThinAuthorizationResponse 
    {
        
        /// <value>
        /// The policy string related to the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthorizationRequest is required.")]
        [JsonProperty(PropertyName = "authorizationRequest")]
        public AuthorizationRequest AuthorizationRequest { get; set; }
        
        /// <value>
        /// The duration of how long this decision should be cached. Note that the type is of type java.time.Duration, not
        /// string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DecisionCacheDuration is required.")]
        [JsonProperty(PropertyName = "decisionCacheDuration")]
        public string DecisionCacheDuration { get; set; }
        
    }
}
