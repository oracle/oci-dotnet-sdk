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


namespace Oci.UsageService.Models
{
    /// <summary>
    /// Object describing the monthly rewards summary for the requested subscription ID.
    /// </summary>
    public class MonthlyRewardSummary 
    {
        
        /// <value>
        /// The number of rewards available for a specific usage period.
        /// </value>
        [JsonProperty(PropertyName = "availableRewards")]
        public System.Nullable<float> AvailableRewards { get; set; }
        
        /// <value>
        /// The number of rewards redeemed for a specific month.
        /// </value>
        [JsonProperty(PropertyName = "redeemedRewards")]
        public System.Nullable<float> RedeemedRewards { get; set; }
        
        /// <value>
        /// The number of rewards earned for the specific usage period.
        /// </value>
        [JsonProperty(PropertyName = "earnedRewards")]
        public System.Nullable<float> EarnedRewards { get; set; }
        
        /// <value>
        /// The boolean parameter to indicate whether or not the available rewards are manually posted.
        /// </value>
        [JsonProperty(PropertyName = "isManual")]
        public System.Nullable<bool> IsManual { get; set; }
        
        /// <value>
        /// The date and time when rewards expire.
        /// </value>
        [JsonProperty(PropertyName = "timeRewardsExpired")]
        public System.Nullable<System.DateTime> TimeRewardsExpired { get; set; }
        
        /// <value>
        /// The date and time when rewards accrue.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRewardsEarned")]
        public System.Nullable<System.DateTime> TimeRewardsEarned { get; set; }
        
        /// <value>
        /// The start date and time for the usage period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUsageStarted")]
        public System.Nullable<System.DateTime> TimeUsageStarted { get; set; }
        
        /// <value>
        /// The end date and time for the usage period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUsageEnded")]
        public System.Nullable<System.DateTime> TimeUsageEnded { get; set; }
        
        /// <value>
        /// The usage amount for the usage period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usageAmount")]
        public System.Double UsageAmount { get; set; }
        
        /// <value>
        /// The eligible usage amount for the usage period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "eligibleUsageAmount")]
        public System.Double EligibleUsageAmount { get; set; }
        
        /// <value>
        /// The ineligible usage amount for the usage period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ineligibleUsageAmount")]
        public System.Double IneligibleUsageAmount { get; set; }
        
        /// <value>
        /// The usage period ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usagePeriodKey")]
        public string UsagePeriodKey { get; set; }
        
    }
}
