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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// The information about updating onboarding.
    /// </summary>
    public class UpdateOnboardingDetails 
    {
        
        /// <value>
        /// A value determining Fleet Application Management tag is enabled or not
        /// </value>
        [JsonProperty(PropertyName = "isFamsTagEnabled")]
        public System.Nullable<bool> IsFamsTagEnabled { get; set; }
        
        /// <value>
        /// A value determining if cost tracking tag is enabled or not
        /// </value>
        [JsonProperty(PropertyName = "isCostTrackingTagEnabled")]
        public System.Nullable<bool> IsCostTrackingTagEnabled { get; set; }
        
    }
}
