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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Subscribed service contract details
    /// 
    /// </summary>
    public class SubscribedService 
    {
        
        /// <value>
        /// SPM internal Subscribed Service ID
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Subscribed Service line type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Subscribed service line number
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// Subscription ID associated to the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public RateCardProduct Product { get; set; }
        
        /// <value>
        /// Subscribed service start date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Subscribed service end date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Subscribed service quantity
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }
        
        /// <value>
        /// Subscribed service status
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// Subscribed service operation type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; set; }
        
        /// <value>
        /// Subscribed service net unit price
        /// 
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }
        
        /// <value>
        /// Indicates the period for which the commitment amount can be utilised exceeding which the amount lapses. Also used in calculation of total contract line value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pricePeriod")]
        public string PricePeriod { get; set; }
        
        /// <value>
        /// Subscribed service line net amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lineNetAmount")]
        public string LineNetAmount { get; set; }
        
        /// <value>
        /// Indicates if the commitment lines can have different quantities
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isVariableCommitment")]
        public System.Nullable<bool> IsVariableCommitment { get; set; }
        
        /// <value>
        /// Indicates if a service can recieve usages and consequently have available amounts computed
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAllowance")]
        public System.Nullable<bool> IsAllowance { get; set; }
        
        /// <value>
        /// Subscribed service used amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usedAmount")]
        public string UsedAmount { get; set; }
        
        /// <value>
        /// Subscribed sercice available or remaining amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availableAmount")]
        public string AvailableAmount { get; set; }
        
        /// <value>
        /// Funded Allocation line value
        /// Example: 12000.00
        /// </value>
        [JsonProperty(PropertyName = "fundedAllocationValue")]
        public string FundedAllocationValue { get; set; }
        
        /// <value>
        /// Indicator on whether or not there has been usage for the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHavingUsage")]
        public System.Nullable<bool> IsHavingUsage { get; set; }
        
        /// <value>
        /// If true compares rate between ratecard and the active pricelist and minimum rate would be fetched
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCapToPriceList")]
        public System.Nullable<bool> IsCapToPriceList { get; set; }
        
        /// <value>
        /// Subscribed service credit percentage
        /// 
        /// </value>
        [JsonProperty(PropertyName = "creditPercentage")]
        public string CreditPercentage { get; set; }
        
        /// <value>
        /// This field contains the name of the partner to which the subscription belongs - depending on which the invoicing may differ
        /// 
        /// </value>
        [JsonProperty(PropertyName = "partnerTransactionType")]
        public string PartnerTransactionType { get; set; }
        
        /// <value>
        /// Used in context of service credit lines
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCreditEnabled")]
        public System.Nullable<bool> IsCreditEnabled { get; set; }
        
        /// <value>
        /// Overage Policy of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overagePolicy")]
        public string OveragePolicy { get; set; }
        
        /// <value>
        /// Overage Bill To of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overageBillTo")]
        public string OverageBillTo { get; set; }
        
        /// <value>
        /// Pay As You Go policy of Subscribed Service (Can be null - indicating no payg policy)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "paygPolicy")]
        public string PaygPolicy { get; set; }
        
        /// <value>
        /// Not null if this service has an associated promotion line in SPM. Contains the line identifier from Order Management of 
        /// the associated promo line.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "promoOrderLineId")]
        public System.Nullable<long> PromoOrderLineId { get; set; }
        
        /// <value>
        /// Promotion Pricing Type of Subscribed Service (Can be null - indicating no promotion pricing)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "promotionPricingType")]
        public string PromotionPricingType { get; set; }
        
        /// <value>
        /// Subscribed service Rate Card Discount Percentage
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rateCardDiscountPercentage")]
        public string RateCardDiscountPercentage { get; set; }
        
        /// <value>
        /// Subscribed service Overage Discount Percentage
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overageDiscountPercentage")]
        public string OverageDiscountPercentage { get; set; }
        
        [JsonProperty(PropertyName = "billToCustomer")]
        public SubscribedServiceBusinessPartner BillToCustomer { get; set; }
        
        [JsonProperty(PropertyName = "billToContact")]
        public SubscribedServiceUser BillToContact { get; set; }
        
        [JsonProperty(PropertyName = "billToAddress")]
        public SubscribedServiceAddress BillToAddress { get; set; }
        
        /// <value>
        /// Payment Number of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "paymentNumber")]
        public string PaymentNumber { get; set; }
        
        /// <value>
        /// Subscribed service payment expiry date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timePaymentExpiry")]
        public System.Nullable<System.DateTime> TimePaymentExpiry { get; set; }
        
        [JsonProperty(PropertyName = "paymentTerm")]
        public SubscribedServicePaymentTerm PaymentTerm { get; set; }
        
        /// <value>
        /// Payment Method of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "paymentMethod")]
        public string PaymentMethod { get; set; }
        
        /// <value>
        /// Subscribed service Transaction Extension Id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "transactionExtensionId")]
        public System.Nullable<long> TransactionExtensionId { get; set; }
        
        /// <value>
        /// Sales Channel of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "salesChannel")]
        public string SalesChannel { get; set; }
        
        /// <value>
        /// Subscribed service eligible to renew field
        /// 
        /// </value>
        [JsonProperty(PropertyName = "eligibleToRenew")]
        public string EligibleToRenew { get; set; }
        
        /// <value>
        /// SPM renewed Subscription ID
        /// 
        /// </value>
        [JsonProperty(PropertyName = "renewedSubscribedServiceId")]
        public string RenewedSubscribedServiceId { get; set; }
        
        /// <value>
        /// Term value in Months
        /// 
        /// </value>
        [JsonProperty(PropertyName = "termValue")]
        public System.Nullable<long> TermValue { get; set; }
        
        /// <value>
        /// Term value UOM
        /// 
        /// </value>
        [JsonProperty(PropertyName = "termValueUom")]
        public string TermValueUom { get; set; }
        
        /// <value>
        /// Subscribed service Opportunity Id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "renewalOptyId")]
        public System.Nullable<long> RenewalOptyId { get; set; }
        
        /// <value>
        /// Renewal Opportunity Number of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "renewalOptyNumber")]
        public string RenewalOptyNumber { get; set; }
        
        /// <value>
        /// Renewal Opportunity Type of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "renewalOptyType")]
        public string RenewalOptyType { get; set; }
        
        /// <value>
        /// Booking Opportunity Number of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bookingOptyNumber")]
        public string BookingOptyNumber { get; set; }
        
        /// <value>
        /// Subscribed service Revenue Line Id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "revenueLineId")]
        public System.Nullable<long> RevenueLineId { get; set; }
        
        /// <value>
        /// Revenue Line NUmber of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "revenueLineNumber")]
        public string RevenueLineNumber { get; set; }
        
        /// <value>
        /// Subscribed service Major Set
        /// 
        /// </value>
        [JsonProperty(PropertyName = "majorSet")]
        public System.Nullable<long> MajorSet { get; set; }
        
        /// <value>
        /// Subscribed service Major Set Start date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeMajorsetStart")]
        public System.Nullable<System.DateTime> TimeMajorsetStart { get; set; }
        
        /// <value>
        /// Subscribed service Major Set End date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeMajorsetEnd")]
        public System.Nullable<System.DateTime> TimeMajorsetEnd { get; set; }
        
        /// <value>
        /// Subscribed service System ARR
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemArrInLc")]
        public string SystemArrInLc { get; set; }
        
        /// <value>
        /// Subscribed service System ARR in Standard Currency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemArrInSc")]
        public string SystemArrInSc { get; set; }
        
        /// <value>
        /// Subscribed service System ATR-ARR
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemAtrArrInLc")]
        public string SystemAtrArrInLc { get; set; }
        
        /// <value>
        /// Subscribed service System ATR-ARR in Standard Currency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemAtrArrInSc")]
        public string SystemAtrArrInSc { get; set; }
        
        /// <value>
        /// Subscribed service Revised ARR
        /// 
        /// </value>
        [JsonProperty(PropertyName = "revisedArrInLc")]
        public string RevisedArrInLc { get; set; }
        
        /// <value>
        /// Subscribed service Revised ARR in Standard Currency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "revisedArrInSc")]
        public string RevisedArrInSc { get; set; }
        
        /// <value>
        /// Subscribed service total value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalValue")]
        public string TotalValue { get; set; }
        
        /// <value>
        /// Subscribed service Promotion Amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "originalPromoAmount")]
        public string OriginalPromoAmount { get; set; }
        
        /// <value>
        /// Sales Order Header associated to the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderHeaderId")]
        public System.Nullable<long> OrderHeaderId { get; set; }
        
        /// <value>
        /// Sales Order Number associated to the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderNumber")]
        public System.Nullable<long> OrderNumber { get; set; }
        
        /// <value>
        /// Order Type of Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderType")]
        public string OrderType { get; set; }
        
        /// <value>
        /// Sales Order Line Id associated to the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderLineId")]
        public System.Nullable<long> OrderLineId { get; set; }
        
        /// <value>
        /// Sales Order Line Number associated to the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderLineNumber")]
        public System.Nullable<int> OrderLineNumber { get; set; }
        
        /// <value>
        /// Subscribed service commitment schedule Id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commitmentScheduleId")]
        public string CommitmentScheduleId { get; set; }
        
        /// <value>
        /// Subscribed service sales account party id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "salesAccountPartyId")]
        public System.Nullable<long> SalesAccountPartyId { get; set; }
        
        /// <value>
        /// Subscribed service data center
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataCenter")]
        public string DataCenter { get; set; }
        
        /// <value>
        /// Subscribed service data center region
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataCenterRegion")]
        public string DataCenterRegion { get; set; }
        
        /// <value>
        /// Subscribed service admin email id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adminEmail")]
        public string AdminEmail { get; set; }
        
        /// <value>
        /// Subscribed service buyer email id
        /// 
        /// </value>
        [JsonProperty(PropertyName = "buyerEmail")]
        public string BuyerEmail { get; set; }
        
        /// <value>
        /// Subscribed service source
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subscriptionSource")]
        public string SubscriptionSource { get; set; }
        
        /// <value>
        /// Subscribed service provisioning source
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningSource")]
        public string ProvisioningSource { get; set; }
        
        /// <value>
        /// Subscribed service fulfillment set
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fulfillmentSet")]
        public string FulfillmentSet { get; set; }
        
        /// <value>
        /// Subscribed service intent to pay flag
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIntentToPay")]
        public System.Nullable<bool> IsIntentToPay { get; set; }
        
        /// <value>
        /// Subscribed service payg flag
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPayg")]
        public System.Nullable<bool> IsPayg { get; set; }
        
        /// <value>
        /// Subscribed service pricing model
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pricingModel")]
        public string PricingModel { get; set; }
        
        /// <value>
        /// Subscribed service program type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "programType")]
        public string ProgramType { get; set; }
        
        /// <value>
        /// Subscribed service start date type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "startDateType")]
        public string StartDateType { get; set; }
        
        /// <value>
        /// Subscribed service provisioning date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeProvisioned")]
        public System.Nullable<System.DateTime> TimeProvisioned { get; set; }
        
        /// <value>
        /// Subscribed service promotion type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "promoType")]
        public string PromoType { get; set; }
        
        [JsonProperty(PropertyName = "serviceToCustomer")]
        public SubscribedServiceBusinessPartner ServiceToCustomer { get; set; }
        
        [JsonProperty(PropertyName = "serviceToContact")]
        public SubscribedServiceUser ServiceToContact { get; set; }
        
        [JsonProperty(PropertyName = "serviceToAddress")]
        public SubscribedServiceAddress ServiceToAddress { get; set; }
        
        [JsonProperty(PropertyName = "soldToCustomer")]
        public SubscribedServiceBusinessPartner SoldToCustomer { get; set; }
        
        [JsonProperty(PropertyName = "soldToContact")]
        public SubscribedServiceUser SoldToContact { get; set; }
        
        [JsonProperty(PropertyName = "endUserCustomer")]
        public SubscribedServiceBusinessPartner EndUserCustomer { get; set; }
        
        [JsonProperty(PropertyName = "endUserContact")]
        public SubscribedServiceUser EndUserContact { get; set; }
        
        [JsonProperty(PropertyName = "endUserAddress")]
        public SubscribedServiceAddress EndUserAddress { get; set; }
        
        [JsonProperty(PropertyName = "resellerCustomer")]
        public SubscribedServiceBusinessPartner ResellerCustomer { get; set; }
        
        [JsonProperty(PropertyName = "resellerContact")]
        public SubscribedServiceUser ResellerContact { get; set; }
        
        [JsonProperty(PropertyName = "resellerAddress")]
        public SubscribedServiceAddress ResellerAddress { get; set; }
        
        /// <value>
        /// Subscribed service CSI number
        /// 
        /// </value>
        [JsonProperty(PropertyName = "csi")]
        public System.Nullable<long> Csi { get; set; }
        
        /// <value>
        /// Identifier for a customer's transactions for purchase of ay oracle services
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerTransactionReference")]
        public string CustomerTransactionReference { get; set; }
        
        /// <value>
        /// Subscribed service partner credit amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "partnerCreditAmount")]
        public string PartnerCreditAmount { get; set; }
        
        /// <value>
        /// Indicates if the Subscribed service has a single ratecard
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSingleRateCard")]
        public System.Nullable<bool> IsSingleRateCard { get; set; }
        
        /// <value>
        /// Subscribed service agreement ID
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agreementId")]
        public System.Nullable<long> AgreementId { get; set; }
        
        /// <value>
        /// Subscribed service agrrement name
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agreementName")]
        public string AgreementName { get; set; }
        
        /// <value>
        /// Subscribed service agrrement type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agreementType")]
        public string AgreementType { get; set; }
        
        /// <value>
        /// Subscribed service invoice frequency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "billingFrequency")]
        public string BillingFrequency { get; set; }
        
        /// <value>
        /// Subscribed service welcome email sent date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeWelcomeEmailSent")]
        public System.Nullable<System.DateTime> TimeWelcomeEmailSent { get; set; }
        
        /// <value>
        /// Subscribed service service configuration email sent date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeServiceConfigurationEmailSent")]
        public System.Nullable<System.DateTime> TimeServiceConfigurationEmailSent { get; set; }
        
        /// <value>
        /// Subscribed service customer config date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCustomerConfig")]
        public System.Nullable<System.DateTime> TimeCustomerConfig { get; set; }
        
        /// <value>
        /// Subscribed service agrrement end date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeAgreementEnd")]
        public System.Nullable<System.DateTime> TimeAgreementEnd { get; set; }
        
        /// <value>
        /// List of Commitment services of a line
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commitmentServices")]
        public System.Collections.Generic.List<CommitmentService> CommitmentServices { get; set; }
        
        /// <value>
        /// List of Rate Cards of a Subscribed Service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rateCards")]
        public System.Collections.Generic.List<RateCardSummary> RateCards { get; set; }
        
        /// <value>
        /// Subscribed service creation date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// User that created the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Subscribed service last update date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// User that updated the subscribed service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        
        /// <value>
        /// SPM Ratecard Type
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ratecardType")]
        public string RatecardType { get; set; }
        
    }
}
