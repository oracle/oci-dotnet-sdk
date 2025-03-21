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


namespace Oci.TenantmanagercontrolplaneService.Models
{
    /// <summary>
    /// Order details.
    /// </summary>
    public class Order 
    {
        
        /// <value>
        /// Immutable and unique order number holding customer subscription information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OrderNumber is required.")]
        [JsonProperty(PropertyName = "orderNumber")]
        public string OrderNumber { get; set; }
        
        /// <value>
        /// Order's data center region.
        /// </value>
        [JsonProperty(PropertyName = "dataCenterRegion")]
        public string DataCenterRegion { get; set; }
        
        /// <value>
        /// Email address of the administrator who owns the subscription.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminEmail is required.")]
        [JsonProperty(PropertyName = "adminEmail")]
        public string AdminEmail { get; set; }
        
        /// <value>
        /// State of the order.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OrderState is required.")]
        [JsonProperty(PropertyName = "orderState")]
        public string OrderState { get; set; }
        
        /// <value>
        /// Array of subscriptions associated with the order.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subscriptions is required.")]
        [JsonProperty(PropertyName = "subscriptions")]
        public System.Collections.Generic.List<SubscriptionInfo> Subscriptions { get; set; }
        
    }
}
