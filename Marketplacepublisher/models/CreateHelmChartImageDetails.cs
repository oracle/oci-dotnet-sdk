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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Helmchart image details required to create an helmchart artifact.
    /// </summary>
    public class CreateHelmChartImageDetails 
    {
        
        /// <value>
        /// The source registry OCID of the container image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceRegistryId is required.")]
        [JsonProperty(PropertyName = "sourceRegistryId")]
        public string SourceRegistryId { get; set; }
        
        /// <value>
        /// The source registry url of the helmchart image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceRegistryUrl is required.")]
        [JsonProperty(PropertyName = "sourceRegistryUrl")]
        public string SourceRegistryUrl { get; set; }
        
        /// <value>
        /// The Supported Versions of Kubernetes
        /// </value>
        [JsonProperty(PropertyName = "supportedKubernetesVersions")]
        public System.Collections.Generic.List<string> SupportedKubernetesVersions { get; set; }
        
    }
}
