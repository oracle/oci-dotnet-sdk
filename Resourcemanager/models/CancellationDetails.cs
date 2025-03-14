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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Cancellation details for a job.
    /// 
    /// </summary>
    public class CancellationDetails 
    {
        
        /// <value>
        /// Indicates whether a forced cancellation was requested for the job while it was running.
        /// A forced cancellation can result in an incorrect state file.
        /// For example, the state file might not reflect the exact state of the provisioned resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForced")]
        public System.Nullable<bool> IsForced { get; set; }
        
    }
}
