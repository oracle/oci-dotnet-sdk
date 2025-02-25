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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides the information used for the reboot job.
    /// </summary>
    public class RebootManagedInstanceDetails 
    {
        
        /// <value>
        /// The number of minutes the service waits for the reboot to complete. If the instance doesn't reboot within this 
        /// time, the reboot job status is set to failed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rebootTimeoutInMins")]
        public System.Nullable<int> RebootTimeoutInMins { get; set; }
        
        [JsonProperty(PropertyName = "workRequestDetails")]
        public WorkRequestDetails WorkRequestDetails { get; set; }
        
    }
}
