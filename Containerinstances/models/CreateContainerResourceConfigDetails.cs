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
    /// The size and amount of resources available to the container.
    /// 
    /// </summary>
    public class CreateContainerResourceConfigDetails 
    {
        
        /// <value>
        /// The maximum amount of CPUs that can be consumed by the container's process.
        /// <br/>
        /// If you do not set a value, then the process
        /// can use all available CPU resources on the instance.
        /// <br/>
        /// CPU usage is defined in terms of logical CPUs. This means that the maximum possible value on
        /// an E3 ContainerInstance with 1 OCPU is 2.0.
        /// <br/>
        /// A container with a 2.0 vcpusLimit could consume up to 100% of the CPU resources available on the container instance.
        /// Values can be fractional. A value of \"1.5\" means that the container
        /// can consume at most the equivalent of 1 and a half logical CPUs worth of CPU capacity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcpusLimit")]
        public System.Nullable<float> VcpusLimit { get; set; }
        
        /// <value>
        /// The maximum amount of memory that can be consumed by the container's
        /// process.
        /// <br/>
        /// If you do not set a value, then the process
        /// may use all available memory on the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryLimitInGBs")]
        public System.Nullable<float> MemoryLimitInGBs { get; set; }
        
    }
}
