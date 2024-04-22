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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Information about the kernel crash event. A kernel crash event occurs when the kernel detects an exception and triggers a reboot.
    /// </summary>
    public class KernelCrashEvent : Event
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Data is required.")]
        [JsonProperty(PropertyName = "data")]
        public KernelEventData Data { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "KERNEL_CRASH";
    }
}
