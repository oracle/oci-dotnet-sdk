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
    /// Summary of subscription.
    /// </summary>
    public class ClassicSubscriptionSummary : SubscriptionSummary
    {
        
        /// <value>
        /// Classic subscription ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClassicSubscriptionId is required.")]
        [JsonProperty(PropertyName = "classicSubscriptionId")]
        public string ClassicSubscriptionId { get; set; }
        
        /// <value>
        /// Specifies whether or not the subscription is from classic systems.
        /// </value>
        [JsonProperty(PropertyName = "isClassicSubscription")]
        public System.Nullable<bool> IsClassicSubscription { get; set; }
        
        /// <value>
        /// The pay model of the subscription, such as 'Pay as you go' or 'Monthly'.
        /// </value>
        [JsonProperty(PropertyName = "paymentModel")]
        public string PaymentModel { get; set; }
        
        /// <value>
        /// Region for the subscription.
        /// </value>
        [JsonProperty(PropertyName = "regionAssignment")]
        public string RegionAssignment { get; set; }
        
        /// <value>
        /// Lifecycle state of the subscription.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClassicSubscriptionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Subscription start time.
        /// </value>
        [JsonProperty(PropertyName = "startDate")]
        public System.Nullable<System.DateTime> StartDate { get; set; }
        
        /// <value>
        /// Subscription end time.
        /// </value>
        [JsonProperty(PropertyName = "endDate")]
        public System.Nullable<System.DateTime> EndDate { get; set; }
        
        [JsonProperty(PropertyName = "entityVersion")]
        private readonly string entityVersion = "V1";
    }
}
