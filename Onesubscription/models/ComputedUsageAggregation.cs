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
    /// Computed Usage Aggregation object
    /// 
    /// </summary>
    public class ComputedUsageAggregation 
    {
        
        /// <value>
        /// Total Quantity that was used for computation
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public ComputedUsageProduct Product { get; set; }
        
        /// <value>
        /// Data Center Attribute as sent by MQS to SPM.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataCenter")]
        public string DataCenter { get; set; }
        
        /// <value>
        /// Metered Service date , expressed in RFC 3339 timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeMeteredOn")]
        public System.Nullable<System.DateTime> TimeMeteredOn { get; set; }
        
        /// <value>
        /// Net Unit Price for the product in consideration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }
        
        /// <value>
        /// Sum of Computed Line Amount unrounded
        /// 
        /// </value>
        [JsonProperty(PropertyName = "costUnrounded")]
        public string CostUnrounded { get; set; }
        
        /// <value>
        /// Sum of Computed Line Amount rounded
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; set; }
                ///
        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROMOTION")]
            Promotion,
            [EnumMember(Value = "DO_NOT_BILL")]
            DoNotBill,
            [EnumMember(Value = "USAGE")]
            Usage,
            [EnumMember(Value = "COMMIT")]
            Commit,
            [EnumMember(Value = "OVERAGE")]
            Overage,
            [EnumMember(Value = "PAY_AS_YOU_GO")]
            PayAsYouGo,
            [EnumMember(Value = "MONTHLY_MINIMUM")]
            MonthlyMinimum,
            [EnumMember(Value = "DELAYED_USAGE_INVOICE_TIMING")]
            DelayedUsageInvoiceTiming,
            [EnumMember(Value = "DELAYED_USAGE_COMMITMENT_EXP")]
            DelayedUsageCommitmentExp,
            [EnumMember(Value = "ON_ACCOUNT_CREDIT")]
            OnAccountCredit,
            [EnumMember(Value = "SERVICE_CREDIT")]
            ServiceCredit,
            [EnumMember(Value = "COMMITMENT_EXPIRATION")]
            CommitmentExpiration,
            [EnumMember(Value = "FUNDED_ALLOCATION")]
            FundedAllocation,
            [EnumMember(Value = "DONOT_BILL_USAGE_POST_TERMINATION")]
            DonotBillUsagePostTermination,
            [EnumMember(Value = "DELAYED_USAGE_POST_TERMINATION")]
            DelayedUsagePostTermination
        };

        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
