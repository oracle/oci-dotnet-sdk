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
    
    public class AuthorizationRequest 
    {
        
        /// <value>
        /// The id of this request. It is a GUID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestId is required.")]
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }
        
        /// <value>
        /// The user principal object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserPrincipal is required.")]
        [JsonProperty(PropertyName = "userPrincipal")]
        public Principal UserPrincipal { get; set; }
        
        /// <value>
        /// The service principal object for service to service calls.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SvcPrincipal is required.")]
        [JsonProperty(PropertyName = "svcPrincipal")]
        public Principal SvcPrincipal { get; set; }
        
        /// <value>
        /// The name of the service that is making this authorization request
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// A set of permission contexts
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Context is required.")]
        [JsonProperty(PropertyName = "context")]
        public System.Collections.Generic.List<PermissionContext> Context { get; set; }
        
        /// <value>
        /// The hash of cached policy on the caller service side. If this is different than what Identity has, it will
        /// send the most recent policy statements.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyHash is required.")]
        [JsonProperty(PropertyName = "policyHash")]
        public string PolicyHash { get; set; }
        
    }
}
