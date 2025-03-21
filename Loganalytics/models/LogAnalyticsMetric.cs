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
    /// LogAnalyticsMetric
    /// </summary>
    public class LogAnalyticsMetric 
    {
        
        /// <value>
        /// The aggregation field.
        /// </value>
        [JsonProperty(PropertyName = "aggregationField")]
        public string AggregationField { get; set; }
        
        /// <value>
        /// The bucket metadata.
        /// </value>
        [JsonProperty(PropertyName = "bucketMetadata")]
        public string BucketMetadata { get; set; }
        
        /// <value>
        /// The clock period.
        /// </value>
        [JsonProperty(PropertyName = "clockPeriod")]
        public string ClockPeriod { get; set; }
        
        /// <value>
        /// The metric description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The metric edit version.
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// The field name.
        /// </value>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// The field values.
        /// </value>
        [JsonProperty(PropertyName = "fieldValues")]
        public System.Collections.Generic.List<string> FieldValues { get; set; }
        
        /// <value>
        /// The grouping fields.
        /// </value>
        [JsonProperty(PropertyName = "groupingField")]
        public string GroupingField { get; set; }
        
        /// <value>
        /// A flag inidcating whether or not the metric is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The metric display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The metric unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "metricReference")]
        public System.Nullable<long> MetricReference { get; set; }
        
        /// <value>
        /// The metric name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The metric type, specifying the type of aggreation to perform.  Default value
        /// is COUNT.
        /// 
        /// </value>
        ///
        public enum MetricTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "COUNT")]
            Count,
            [EnumMember(Value = "SUM")]
            Sum,
            [EnumMember(Value = "AVERAGE")]
            Average,
            [EnumMember(Value = "COUNT_DISTRIBUTION")]
            CountDistribution,
            [EnumMember(Value = "SUM_DISTRIBUTION")]
            SumDistribution,
            [EnumMember(Value = "AVERAGE_DISTRIBUTION")]
            AverageDistribution
        };

        /// <value>
        /// The metric type, specifying the type of aggreation to perform.  Default value
        /// is COUNT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metricType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricTypeEnum> MetricType { get; set; }
        
        /// <value>
        /// A flag specifying whether or not the metric source is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMetricSourceEnabled")]
        public System.Nullable<bool> IsMetricSourceEnabled { get; set; }
                ///
        /// <value>
        /// The metric operator.
        /// </value>
        ///
        public enum OperatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CONTAINS_IGNORE_CASE")]
            ContainsIgnoreCase,
            [EnumMember(Value = "IN_IGNORE_CASE")]
            InIgnoreCase,
            [EnumMember(Value = "EQUAL_IGNORE_CASE")]
            EqualIgnoreCase,
            [EnumMember(Value = "NOT_NULL")]
            NotNull
        };

        /// <value>
        /// The metric operator.
        /// </value>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorEnum> Operator { get; set; }
        
        /// <value>
        /// The metric sources.
        /// </value>
        [JsonProperty(PropertyName = "sources")]
        public System.Collections.Generic.List<LogAnalyticsSource> Sources { get; set; }
        
        /// <value>
        /// The entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The last updated date.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The unit type.
        /// </value>
        [JsonProperty(PropertyName = "unitType")]
        public string UnitType { get; set; }
        
        /// <value>
        /// A flag specifying whether or not this is a custom (user defined) metric.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUserCustomized")]
        public System.Nullable<bool> IsUserCustomized { get; set; }
        
    }
}
