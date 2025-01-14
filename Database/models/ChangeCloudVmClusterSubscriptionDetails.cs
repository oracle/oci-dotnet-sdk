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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The configuration details for associating the cloud VM cluster resource with a different subscription.
    /// 
    /// </summary>
    public class ChangeCloudVmClusterSubscriptionDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subscription with which resource needs to be associated with.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// Indicates if the subscription is UCM or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
