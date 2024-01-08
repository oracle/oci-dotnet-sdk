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
    /// Tenant eligibility for using third party paid listings
    /// </summary>
    public class ThirdPartyPaidListingEligibility 
    {
        
        /// <value>
        /// Whether the tenant is permitted to use paid listings
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsPaidListingEligible is required.")]
        [JsonProperty(PropertyName = "isPaidListingEligible")]
        public System.Nullable<bool> IsPaidListingEligible { get; set; }
        
        /// <value>
        /// Whether the tenant is currently prevented from using paid listings because of throttling
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsPaidListingThrottled is required.")]
        [JsonProperty(PropertyName = "isPaidListingThrottled")]
        public System.Nullable<bool> IsPaidListingThrottled { get; set; }
                ///
        /// <value>
        /// Reason the account is ineligible to launch paid listings
        /// </value>
        ///
        public enum EligibilityReasonEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ELIGIBLE")]
            Eligible,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_COUNTRY")]
            IneligibleAccountCountry,
            [EnumMember(Value = "INELIGIBLE_REGION")]
            IneligibleRegion,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_BLACKLISTED")]
            IneligibleAccountBlacklisted,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_FEATURE_DISABLED")]
            IneligibleAccountFeatureDisabled,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_CURRENCY")]
            IneligibleAccountCurrency,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_NOT_PAID")]
            IneligibleAccountNotPaid,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_INTERNAL")]
            IneligibleAccountInternal,
            [EnumMember(Value = "INELIGIBLE_ACCOUNT_GOV_SUBSCRIPTION")]
            IneligibleAccountGovSubscription,
            [EnumMember(Value = "NOT_AUTHORIZED")]
            NotAuthorized
        };

        /// <value>
        /// Reason the account is ineligible to launch paid listings
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EligibilityReason is required.")]
        [JsonProperty(PropertyName = "eligibilityReason")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EligibilityReasonEnum> EligibilityReason { get; set; }
        
    }
}
