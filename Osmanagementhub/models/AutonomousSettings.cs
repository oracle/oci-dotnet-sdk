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
    /// Settings for the Autonomous Linux service.
    /// </summary>
    public class AutonomousSettings 
    {
        
        /// <value>
        /// Indicates whether Autonomous Linux will collect crash files. This setting can be changed by the user.
        /// </value>
        [JsonProperty(PropertyName = "isDataCollectionAuthorized")]
        public System.Nullable<bool> IsDataCollectionAuthorized { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the restricted scheduled job associated with this instance. This value cannot be deleted by the user.
        /// </value>
        [JsonProperty(PropertyName = "scheduledJobId")]
        public string ScheduledJobId { get; set; }
        
    }
}
