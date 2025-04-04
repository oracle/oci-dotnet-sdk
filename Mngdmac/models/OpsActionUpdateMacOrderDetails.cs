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


namespace Oci.MngdmacService.Models
{
    /// <summary>
    /// The data to update an order in MAC_ORDER bucket.
    /// </summary>
    public class OpsActionUpdateMacOrderDetails 
    {
        
        /// <value>
        /// The new status of the MacOrder.
        /// </value>
        [JsonProperty(PropertyName = "orderStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MacOrder.OrderStatusEnum> OrderStatus { get; set; }
        
        /// <value>
        /// The IP Range specified by the customer for this order.
        /// </value>
        [JsonProperty(PropertyName = "ipRange")]
        public string IpRange { get; set; }
        
        /// <value>
        /// The date and time this mac order is Active from. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeBillingStarted")]
        public System.Nullable<System.DateTime> TimeBillingStarted { get; set; }
        
        /// <value>
        /// The date and time this mac order until which this mac is Active. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeBillingEnded")]
        public System.Nullable<System.DateTime> TimeBillingEnded { get; set; }
        
    }
}
