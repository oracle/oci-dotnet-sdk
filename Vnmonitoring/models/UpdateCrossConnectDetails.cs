/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Update a CrossConnect
    /// 
    /// </summary>
    public class UpdateCrossConnectDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Set to true to activate the cross-connect. You activate it after the physical cabling
        /// is complete, and you've confirmed the cross-connect's light levels are good and your side
        /// of the interface is up. Activation indicates to Oracle that the physical connection is ready.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isActive")]
        public System.Nullable<bool> IsActive { get; set; }
        
    }
}
