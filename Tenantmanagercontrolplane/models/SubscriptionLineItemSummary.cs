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
    /// Summary of line items in a subscription.
    /// </summary>
    public class SubscriptionLineItemSummary 
    {
        
        /// <value>
        /// Subscription line item identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Product code.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductCode is required.")]
        [JsonProperty(PropertyName = "productCode")]
        public string ProductCode { get; set; }
        
        /// <value>
        /// Product number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Quantity is required.")]
        [JsonProperty(PropertyName = "quantity")]
        public System.Nullable<float> Quantity { get; set; }
        
        /// <value>
        /// Billing model supported by the associated line item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BillingModel is required.")]
        [JsonProperty(PropertyName = "billingModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BillingModel> BillingModel { get; set; }
        
        /// <value>
        /// The time the subscription item and associated products should start. An RFC 3339 formatted date and time string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the subscription item and associated products should end. An RFC 3339 formatted date and time string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnded is required.")]
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
