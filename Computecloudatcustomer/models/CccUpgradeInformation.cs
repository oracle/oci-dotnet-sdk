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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// Upgrade information that relates to a Compute Cloud@Customer infrastructure. This information
    /// cannot be updated.
    /// 
    /// </summary>
    public class CccUpgradeInformation 
    {
        
        /// <value>
        /// The current version of software installed on the Compute Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "currentVersion")]
        public string CurrentVersion { get; set; }
        
        /// <value>
        /// Compute Cloud@Customer infrastructure next upgrade time. The rack might have performance
        /// impacts during this time.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfScheduledUpgrade")]
        public System.Nullable<System.DateTime> TimeOfScheduledUpgrade { get; set; }
        
        /// <value>
        /// Expected duration of Compute Cloud@Customer infrastructure scheduled upgrade. The actual
        /// upgrade time might be longer or shorter than this duration depending on rack activity, this
        /// is only an estimate.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduledUpgradeDuration")]
        public string ScheduledUpgradeDuration { get; set; }
        
        /// <value>
        /// Indication that the Compute Cloud@Customer infrastructure is in the process of
        /// an upgrade or an upgrade activity (such as preloading upgrade images).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isActive")]
        public System.Nullable<bool> IsActive { get; set; }
        
    }
}
