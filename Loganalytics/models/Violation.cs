/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Violation
    /// </summary>
    public class Violation 
    {
        
        /// <value>
        /// The indices associated with regular expression violations.
        /// </value>
        [JsonProperty(PropertyName = "indexes")]
        public System.Collections.Generic.List<Indexes> Indexes { get; set; }
        
        /// <value>
        /// The rule description.
        /// </value>
        [JsonProperty(PropertyName = "ruleDescription")]
        public string RuleDescription { get; set; }
        
        /// <value>
        /// The rule name.
        /// </value>
        [JsonProperty(PropertyName = "ruleName")]
        public string RuleName { get; set; }
        
        /// <value>
        /// The rule remediation.
        /// </value>
        [JsonProperty(PropertyName = "ruleRemediation")]
        public string RuleRemediation { get; set; }
                ///
        /// <value>
        /// The rule type.  Either WARN or ERROR.
        /// </value>
        ///
        public enum RuleTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "WARN")]
            Warn,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// The rule type.  Either WARN or ERROR.
        /// </value>
        [JsonProperty(PropertyName = "ruleType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RuleTypeEnum> RuleType { get; set; }
        
    }
}
