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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// the pricing information for the offer
    /// </summary>
    public class Pricing 
    {
        
        /// <value>
        /// The currency supported for a given Offer, in the format specified by ISO-4217
        /// </value>
        [JsonProperty(PropertyName = "currencyType")]
        public string CurrencyType { get; set; }
        
        /// <value>
        /// The total amount an Offer costs
        /// </value>
        [JsonProperty(PropertyName = "totalAmount")]
        public System.Nullable<long> TotalAmount { get; set; }
                ///
        /// <value>
        /// The frequency at which the customer is billed for the Offer
        /// </value>
        ///
        public enum BillingCycleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ONE_TIME")]
            OneTime
        };

        /// <value>
        /// The frequency at which the customer is billed for the Offer
        /// </value>
        [JsonProperty(PropertyName = "billingCycle")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BillingCycleEnum> BillingCycle { get; set; }
        
    }
}
