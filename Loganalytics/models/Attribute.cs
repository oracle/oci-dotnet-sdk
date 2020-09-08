/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// Attribute
    /// </summary>
    public class Attribute 
    {
        
        /// <value>
        /// default value
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public System.Object DefaultValue { get; set; }

        /// <value>
        /// dynamic value range reference attribute
        /// </value>
        [JsonProperty(PropertyName = "dynamicValueRangeRefAttr")]
        public string DynamicValueRangeRefAttr { get; set; }
        ///
        /// <value>
        /// maximum length
        /// </value>
        ///
        public enum MaximumLenEnum {
            [EnumMember(Value = "LENGTH_FIVE")]
            LengthFive,
            [EnumMember(Value = "LENGTH_SIXTEEN")]
            LengthSixteen,
            [EnumMember(Value = "LENGTH_THIRTYTWO")]
            LengthThirtytwo,
            [EnumMember(Value = "LENGTH_SIXTYFOUR")]
            LengthSixtyfour,
            [EnumMember(Value = "LENGTH_ONETWOEIGHT")]
            LengthOnetwoeight,
            [EnumMember(Value = "LENGTH_TWOFIFTYSIX")]
            LengthTwofiftysix,
            [EnumMember(Value = "LENGTH_FIVETWELVE")]
            LengthFivetwelve,
            [EnumMember(Value = "LENGTH_SEVENFIFTY")]
            LengthSevenfifty,
            [EnumMember(Value = "LENGTH_ONE_THOUSAND")]
            LengthOneThousand,
            [EnumMember(Value = "LENGTH_TWO_THOUSAND")]
            LengthTwoThousand,
            [EnumMember(Value = "LENGTH_FOUR_THOUSAND")]
            LengthFourThousand
        };

        /// <value>
        /// maximum length
        /// </value>
        [JsonProperty(PropertyName = "maximumLen")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MaximumLenEnum> MaximumLen { get; set; }

        /// <value>
        /// name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        ///
        /// <value>
        /// populated by
        /// </value>
        ///
        public enum PopulatedByEnum {
            [EnumMember(Value = "BACKEND_GEN")]
            BackendGen,
            [EnumMember(Value = "CALLER_GEN")]
            CallerGen
        };

        /// <value>
        /// populated by
        /// </value>
        [JsonProperty(PropertyName = "populatedBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PopulatedByEnum> PopulatedBy { get; set; }
        ///
        /// <value>
        /// required in JSON
        /// </value>
        ///
        public enum RequiredInJSONEnum {
            [EnumMember(Value = "MANDATORY")]
            Mandatory,
            [EnumMember(Value = "OPTIONAL")]
            Optional
        };

        /// <value>
        /// required in JSON
        /// </value>
        [JsonProperty(PropertyName = "requiredInJSON")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RequiredInJSONEnum> RequiredInJSON { get; set; }

        /// <value>
        /// schema column
        /// </value>
        [JsonProperty(PropertyName = "schemaColumn")]
        public string SchemaColumn { get; set; }

        /// <value>
        /// is string exceed maximum length
        /// </value>
        [JsonProperty(PropertyName = "isStringExceedMaximumLength")]
        public System.Nullable<bool> IsStringExceedMaximumLength { get; set; }
        ///
        /// <value>
        /// usage senario
        /// </value>
        ///
        public enum UsageSenarioEnum {
            [EnumMember(Value = "CREATE")]
            Create,
            [EnumMember(Value = "UPDATE")]
            Update,
            [EnumMember(Value = "CREATE_AND_UPDATE")]
            CreateAndUpdate,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "RE_CREATE")]
            ReCreate,
            [EnumMember(Value = "DETAIL")]
            Detail,
            [EnumMember(Value = "LIST")]
            List,
            [EnumMember(Value = "FUNCTION_WITH_LOOKUP")]
            FunctionWithLookup,
            [EnumMember(Value = "DB_PATTERN")]
            DbPattern,
            [EnumMember(Value = "CREATE_FIRSTTIME_T1")]
            CreateFirsttimeT1,
            [EnumMember(Value = "UPDATE_OOB_METRIC")]
            UpdateOobMetric
        };

        /// <value>
        /// usage senario
        /// </value>
        [JsonProperty(PropertyName = "usageSenario")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UsageSenarioEnum> UsageSenario { get; set; }
        ///
        /// <value>
        /// value data type
        /// </value>
        ///
        public enum ValueDataTypeEnum {
            [EnumMember(Value = "INTEGER")]
            Integer,
            [EnumMember(Value = "LONG")]
            Long,
            [EnumMember(Value = "FLOAT")]
            Float,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "TIMESTAMP")]
            Timestamp,
            [EnumMember(Value = "DATE")]
            Date,
            [EnumMember(Value = "CLOB")]
            Clob,
            [EnumMember(Value = "TAG_REF")]
            TagRef,
            [EnumMember(Value = "PARSER_REF")]
            ParserRef,
            [EnumMember(Value = "STT_REF")]
            SttRef,
            [EnumMember(Value = "LOOKUP_REF")]
            LookupRef,
            [EnumMember(Value = "META_FUNCTION_REF")]
            MetaFunctionRef,
            [EnumMember(Value = "COMMON_FIELD_REF")]
            CommonFieldRef
        };

        /// <value>
        /// value data type
        /// </value>
        [JsonProperty(PropertyName = "valueDataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ValueDataTypeEnum> ValueDataType { get; set; }
        ///
        /// <value>
        /// value population priority
        /// </value>
        ///
        public enum ValuePopulationPriorityEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "HIGH")]
            High
        };

        /// <value>
        /// value population priority
        /// </value>
        [JsonProperty(PropertyName = "valuePopulationPriority")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ValuePopulationPriorityEnum> ValuePopulationPriority { get; set; }
    }
}
