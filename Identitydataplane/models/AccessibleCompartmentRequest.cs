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
    
    public class AccessibleCompartmentRequest 
    {
        
        /// <value>
        /// The authorization request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthorizationRequest is required.")]
        [JsonProperty(PropertyName = "authorizationRequest")]
        public AuthorizationRequest AuthorizationRequest { get; set; }
        
        /// <value>
        /// The list of compartment ids.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentIds is required.")]
        [JsonProperty(PropertyName = "compartmentIds")]
        public System.Collections.Generic.List<string> CompartmentIds { get; set; }
        
    }
}
