/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Subscribed Service Contract details
    /// 
    /// </summary>
    public class AggregatedComputedUsageSummary 
    {
        
        /// <value>
        /// Subscription Id is an identifier associated to the service used for filter the Computed Usage in SPM
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubscriptionId is required.")]
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// Subscribed service line parent id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parentSubscribedServiceId")]
        public string ParentSubscribedServiceId { get; set; }
        
        [JsonProperty(PropertyName = "parentProduct")]
        public ComputedUsageProduct ParentProduct { get; set; }
        
        /// <value>
        /// Subscribed services contract line start date, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Subscribed services contract line end date, expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Subscribed service asociated subscription plan number.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "planNumber")]
        public string PlanNumber { get; set; }
        
        /// <value>
        /// Currency code
        /// 
        /// </value>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }
        
        /// <value>
        /// Inernal SPM Ratecard Id at line level
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rateCardId")]
        public string RateCardId { get; set; }
                ///
        /// <value>
        /// Subscribed services pricing model
        /// 
        /// </value>
        ///
        public enum PricingModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PAY_AS_YOU_GO")]
            PayAsYouGo,
            [EnumMember(Value = "MONTHLY")]
            Monthly,
            [EnumMember(Value = "ANNUAL")]
            Annual,
            [EnumMember(Value = "PREPAID")]
            Prepaid,
            [EnumMember(Value = "FUNDED_ALLOCATION")]
            FundedAllocation
        };

        /// <value>
        /// Subscribed services pricing model
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pricingModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PricingModelEnum> PricingModel { get; set; }
        
        /// <value>
        /// Aggregation of computed usages for the subscribed service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "aggregatedComputedUsages")]
        public System.Collections.Generic.List<ComputedUsageAggregation> AggregatedComputedUsages { get; set; }
        
    }
}
