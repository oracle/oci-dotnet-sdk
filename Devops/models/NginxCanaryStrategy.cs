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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the NGINX canary release strategy.
    /// </summary>
    public class NginxCanaryStrategy : OkeCanaryStrategy
    {
        
        /// <value>
        /// Canary namespace to be used for Kubernetes canary deployment. Example: canary - Name of the Canary namespace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Name of the Ingress resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IngressName is required.")]
        [JsonProperty(PropertyName = "ingressName")]
        public string IngressName { get; set; }
        
        [JsonProperty(PropertyName = "strategyType")]
        private readonly string strategyType = "NGINX_CANARY_STRATEGY";
    }
}
