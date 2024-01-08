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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for international market pricing.
    /// </summary>
    public class InternationalMarketPrice 
    {
        
        /// <value>
        /// The currency of the pricing model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrencyCode is required.")]
        [JsonProperty(PropertyName = "currencyCode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PricingCurrencyEnum> CurrencyCode { get; set; }
        
        /// <value>
        /// The symbol of the currency
        /// </value>
        [JsonProperty(PropertyName = "currencySymbol")]
        public string CurrencySymbol { get; set; }
        
        /// <value>
        /// The pricing rate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rate is required.")]
        [JsonProperty(PropertyName = "rate")]
        public System.Double Rate { get; set; }
        
    }
}
