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


namespace Oci.BudgetService.Models
{
    /// <summary>
    /// The update alert rule details.
    /// </summary>
    public class UpdateAlertRuleDetails 
    {
        
        /// <value>
        /// The name of the alert rule. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of the alert. Valid values are ACTUAL (the alert triggers based on actual usage), or
        /// FORECAST (the alert triggers based on predicted usage).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlertType> Type { get; set; }
        
        /// <value>
        /// The threshold for triggering the alert, expressed as a whole number or decimal value.
        /// If the thresholdType is ABSOLUTE, the threshold can have at most 12 digits before the decimal point, and up to two digits after the decimal point.
        /// If the thresholdType is PERCENTAGE, the maximum value is 10000 and can have up to two digits after the decimal point.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "threshold")]
        public System.Nullable<decimal> Threshold { get; set; }
        
        /// <value>
        /// The type of threshold.
        /// </value>
        [JsonProperty(PropertyName = "thresholdType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ThresholdType> ThresholdType { get; set; }
        
        /// <value>
        /// The audience that receives the alert when it triggers. If you need to clear out this value, pass in an empty string instead of a null value.
        /// </value>
        [JsonProperty(PropertyName = "recipients")]
        public string Recipients { get; set; }
        
        /// <value>
        /// The description of the alert rule.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The message to be delivered to the recipients when an alert is triggered.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
