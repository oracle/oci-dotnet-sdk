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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Subscription object which contains the common subscription data.
    /// </summary>
    public class SubscriptionSummary 
    {
        
        /// <value>
        /// Subscription id identifier (OCID).
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Subscription plan number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubscriptionPlanNumber is required.")]
        [JsonProperty(PropertyName = "subscriptionPlanNumber")]
        public string SubscriptionPlanNumber { get; set; }
                ///
        /// <value>
        /// Subscription plan type.
        /// </value>
        ///
        public enum PlanTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FREE_TIER")]
            FreeTier,
            [EnumMember(Value = "PAYG")]
            Payg
        };

        /// <value>
        /// Subscription plan type.
        /// </value>
        [JsonProperty(PropertyName = "planType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PlanTypeEnum> PlanType { get; set; }
        
        /// <value>
        /// Start date of the subscription.
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Ship to customer account site address id.
        /// </value>
        [JsonProperty(PropertyName = "shipToCustAcctSiteId")]
        public string ShipToCustAcctSiteId { get; set; }
        
        /// <value>
        /// Ship to customer account role.
        /// </value>
        [JsonProperty(PropertyName = "shipToCustAcctRoleId")]
        public string ShipToCustAcctRoleId { get; set; }
        
        /// <value>
        /// Bill to customer Account id.
        /// </value>
        [JsonProperty(PropertyName = "billToCustAccountId")]
        public string BillToCustAccountId { get; set; }
        
        /// <value>
        /// Payment intension.
        /// </value>
        [JsonProperty(PropertyName = "isIntentToPay")]
        public System.Nullable<bool> IsIntentToPay { get; set; }
        
        /// <value>
        /// Currency code
        /// </value>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }
        
        /// <value>
        /// GSI Subscription external code.
        /// </value>
        [JsonProperty(PropertyName = "gsiOrgCode")]
        public string GsiOrgCode { get; set; }
        
        /// <value>
        /// Language short code (en, de, hu, etc)
        /// </value>
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
        
        /// <value>
        /// GSI organization external identifier.
        /// </value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }
                ///
        /// <value>
        /// Status of the upgrade.
        /// </value>
        ///
        public enum UpgradeStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROMO")]
            Promo,
            [EnumMember(Value = "SUBMITTED")]
            Submitted,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "UPGRADED")]
            Upgraded
        };

        /// <value>
        /// Status of the upgrade.
        /// </value>
        [JsonProperty(PropertyName = "upgradeState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpgradeStateEnum> UpgradeState { get; set; }
                ///
        /// <value>
        /// This field is used to describe the Upgrade State in case of error (E.g. Upgrade failure caused by interfacing Tax details- TaxError)
        /// </value>
        ///
        public enum UpgradeStateDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TAX_ERROR")]
            TaxError,
            [EnumMember(Value = "UPGRADE_ERROR")]
            UpgradeError
        };

        /// <value>
        /// This field is used to describe the Upgrade State in case of error (E.g. Upgrade failure caused by interfacing Tax details- TaxError)
        /// </value>
        [JsonProperty(PropertyName = "upgradeStateDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpgradeStateDetailsEnum> UpgradeStateDetails { get; set; }
                ///
        /// <value>
        /// Account type.
        /// </value>
        ///
        public enum AccountTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PERSONAL")]
            Personal,
            [EnumMember(Value = "CORPORATE")]
            Corporate,
            [EnumMember(Value = "CORPORATE_SUBMITTED")]
            CorporateSubmitted
        };

        /// <value>
        /// Account type.
        /// </value>
        [JsonProperty(PropertyName = "accountType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AccountTypeEnum> AccountType { get; set; }
        
        [JsonProperty(PropertyName = "taxInfo")]
        public TaxInfo TaxInfo { get; set; }
        
        /// <value>
        /// Payment option list of a subscription.
        /// </value>
        [JsonProperty(PropertyName = "paymentOptions")]
        public System.Collections.Generic.List<PaymentOption> PaymentOptions { get; set; }
        
        [JsonProperty(PropertyName = "paymentGateway")]
        public PaymentGateway PaymentGateway { get; set; }
        
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }
        
        /// <value>
        /// Date of upgrade/conversion when planType changed from FREE_TIER to PAYG
        /// </value>
        [JsonProperty(PropertyName = "timePlanUpgrade")]
        public System.Nullable<System.DateTime> TimePlanUpgrade { get; set; }
        
        /// <value>
        /// Date of upgrade/conversion when account type changed from PERSONAL to CORPORATE
        /// </value>
        [JsonProperty(PropertyName = "timePersonalToCorporateConv")]
        public System.Nullable<System.DateTime> TimePersonalToCorporateConv { get; set; }
        
    }
}
