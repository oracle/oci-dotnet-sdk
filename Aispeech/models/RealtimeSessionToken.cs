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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// The response from the realtime session token endpoint that creates the auth token to be used with the realtime speech service.
    /// </summary>
    public class RealtimeSessionToken 
    {
        
        /// <value>
        /// The session token (JWT) to be consumed by the websocket server. The token contains the session/tenant ID, as well as the expiry time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Token is required.")]
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        
        /// <value>
        /// The session ID this token corresponds to. Provided for convenience, the session ID is already present in the JWT token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SessionId is required.")]
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }
        
        /// <value>
        /// Compartment ID that was used to create the token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}.
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace-1&quot;: {&quot;bar-key-1&quot;: &quot;value-1&quot;, &quot;bar-key-2&quot;: &quot;value-2&quot;}, &quot;foo-namespace-2&quot;: {&quot;bar-key-1&quot;: &quot;value-1&quot;, &quot;bar-key-2&quot;: &quot;value-2&quot;}}.
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}