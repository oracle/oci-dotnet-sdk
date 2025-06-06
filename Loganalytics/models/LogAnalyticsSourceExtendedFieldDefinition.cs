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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsSourceExtendedFieldDefinition
    /// </summary>
    public class LogAnalyticsSourceExtendedFieldDefinition 
    {
        
        [JsonProperty(PropertyName = "field")]
        public LogAnalyticsField Field { get; set; }
        
        /// <value>
        /// The regular expression.
        /// </value>
        [JsonProperty(PropertyName = "displayRegularExpression")]
        public string DisplayRegularExpression { get; set; }
        
        /// <value>
        /// An array of extended fields.
        /// </value>
        [JsonProperty(PropertyName = "extendedFields")]
        public System.Collections.Generic.List<LogAnalyticsExtendedField> ExtendedFields { get; set; }
        
        /// <value>
        /// The base field internal name.
        /// </value>
        [JsonProperty(PropertyName = "baseFieldName")]
        public string BaseFieldName { get; set; }
        
        /// <value>
        /// The base field log text.
        /// </value>
        [JsonProperty(PropertyName = "baseFieldLogText")]
        public string BaseFieldLogText { get; set; }
        
        /// <value>
        /// The conditional data type.
        /// </value>
        [JsonProperty(PropertyName = "conditionDataType")]
        public string ConditionDataType { get; set; }
        
        /// <value>
        /// The conditional field.
        /// </value>
        [JsonProperty(PropertyName = "conditionField")]
        public string ConditionField { get; set; }
        
        /// <value>
        /// The conditional operator.
        /// </value>
        [JsonProperty(PropertyName = "conditionOperator")]
        public string ConditionOperator { get; set; }
        
        /// <value>
        /// The conditional value.
        /// </value>
        [JsonProperty(PropertyName = "conditionValue")]
        public string ConditionValue { get; set; }
        
        /// <value>
        /// The converted regular expression.
        /// </value>
        [JsonProperty(PropertyName = "convertedRegularExpression")]
        public string ConvertedRegularExpression { get; set; }
        
        /// <value>
        /// A flag inidcating whether or not the extended definition is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The extended field definition unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "extendedFieldDefinitionId")]
        public System.Nullable<long> ExtendedFieldDefinitionId { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The regular expression.
        /// </value>
        [JsonProperty(PropertyName = "regularExpression")]
        public string RegularExpression { get; set; }
        
        /// <value>
        /// The source unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
        /// <value>
        /// The last updated date.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// String representation of the extended field condition. This supports specifying multiple condition blocks at various nested levels.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionString")]
        public string ConditionString { get; set; }
        
        [JsonProperty(PropertyName = "conditionBlock")]
        public GenericConditionBlock ConditionBlock { get; set; }
        
    }
}
