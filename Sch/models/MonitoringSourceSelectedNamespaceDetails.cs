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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The namespaces for the compartment-specific list.
    /// 
    /// </summary>
    public class MonitoringSourceSelectedNamespaceDetails : MonitoringSourceNamespaceDetails
    {
        
        /// <value>
        /// The namespaces for the compartment-specific list.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespaces is required.")]
        [JsonProperty(PropertyName = "namespaces")]
        public System.Collections.Generic.List<MonitoringSourceSelectedNamespace> Namespaces { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "selected";
    }
}
