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


namespace Oci.RecoveryService.Models
{
    /// <summary>
    /// Subscription details of the new cloud service environment, such as Microsoft Azure, where the protected database will be provisioned.
    /// 
    /// </summary>
    public class ChangeProtectedDatabaseSubscriptionDetails 
    {
        
        /// <value>
        /// The OCID of the new cloud service subscription to which you want to link the protected database.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// Indicates whether it is a Universal Credit Model (UCM) subscription.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
