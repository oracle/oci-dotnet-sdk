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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// Details about a shape for a container instance.
    /// 
    /// </summary>
    public class ContainerInstanceShapeSummary 
    {
        
        /// <value>
        /// The name identifying the shape.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A short description of the container instance's processor (CPU).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProcessorDescription is required.")]
        [JsonProperty(PropertyName = "processorDescription")]
        public string ProcessorDescription { get; set; }
        
        [JsonProperty(PropertyName = "ocpuOptions")]
        public ShapeOcpuOptions OcpuOptions { get; set; }
        
        [JsonProperty(PropertyName = "memoryOptions")]
        public ShapeMemoryOptions MemoryOptions { get; set; }
        
        [JsonProperty(PropertyName = "networkingBandwidthOptions")]
        public ShapeNetworkingBandwidthOptions NetworkingBandwidthOptions { get; set; }
        
    }
}
