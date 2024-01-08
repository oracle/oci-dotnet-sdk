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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A sensitive column is a resource corresponding to a database column that is considered sensitive.
    /// It's a subresource of sensitive data model resource and is always associated with a sensitive data model.
    /// Note that referential relationships are also managed as part of sensitive columns.
    /// 
    /// </summary>
    public class SensitiveColumn 
    {
        
        /// <value>
        /// The unique key that identifies the sensitive column. It's numeric and unique within a sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The OCID of the sensitive data model that contains the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SensitiveDataModelId is required.")]
        [JsonProperty(PropertyName = "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        /// <value>
        /// The date and time, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339),
        /// the sensitive column was created in the sensitive data model.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339),
        /// the sensitive column was last updated in the sensitive data model.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SensitiveColumnLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The name of the application associated with the sensitive column. It's useful when the application name is
        /// different from the schema name. Otherwise, it can be ignored.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AppName is required.")]
        [JsonProperty(PropertyName = "appName")]
        public string AppName { get; set; }
        
        /// <value>
        /// The database schema that contains the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
        /// <value>
        /// The database object that contains the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// The name of the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnName is required.")]
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }
                ///
        /// <value>
        /// The type of the database object that contains the sensitive column.
        /// </value>
        ///
        public enum ObjectTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TABLE")]
            Table,
            [EnumMember(Value = "EDITIONING_VIEW")]
            EditioningView
        };

        /// <value>
        /// The type of the database object that contains the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectType is required.")]
        [JsonProperty(PropertyName = "objectType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ObjectTypeEnum> ObjectType { get; set; }
        
        /// <value>
        /// The data type of the sensitive column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataType is required.")]
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
                ///
        /// <value>
        /// The status of the sensitive column. VALID means the column is considered sensitive. INVALID means the column
        /// is not considered sensitive. Tracking invalid columns in a sensitive data model helps ensure that an
        /// incremental data discovery job does not identify these columns as sensitive again.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VALID")]
            Valid,
            [EnumMember(Value = "INVALID")]
            Invalid
        };

        /// <value>
        /// The status of the sensitive column. VALID means the column is considered sensitive. INVALID means the column
        /// is not considered sensitive. Tracking invalid columns in a sensitive data model helps ensure that an
        /// incremental data discovery job does not identify these columns as sensitive again.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The OCID of the sensitive type associated with the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
                ///
        /// <value>
        /// The source of the sensitive column. DISCOVERY indicates that the column was added to the sensitive data model
        /// using a data discovery job. MANUAL indicates that the column was added manually.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "DISCOVERY")]
            Discovery
        };

        /// <value>
        /// The source of the sensitive column. DISCOVERY indicates that the column was added to the sensitive data model
        /// using a data discovery job. MANUAL indicates that the column was added manually.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceEnum> Source { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are parents of the sensitive column. At present, it tracks a single parent only.
        /// </value>
        [JsonProperty(PropertyName = "parentColumnKeys")]
        public System.Collections.Generic.List<string> ParentColumnKeys { get; set; }
                ///
        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the
        /// sensitive column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database
        /// dictionary. APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        ///
        public enum RelationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "APP_DEFINED")]
            AppDefined,
            [EnumMember(Value = "DB_DEFINED")]
            DbDefined
        };

        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the
        /// sensitive column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database
        /// dictionary. APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelationType is required.")]
        [JsonProperty(PropertyName = "relationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RelationTypeEnum> RelationType { get; set; }
        
        /// <value>
        /// The estimated number of data values the column has in the associated database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedDataValueCount is required.")]
        [JsonProperty(PropertyName = "estimatedDataValueCount")]
        public System.Nullable<long> EstimatedDataValueCount { get; set; }
        
        /// <value>
        /// Original data values collected for the sensitive column from the associated database. Sample data helps review
        /// the column and ensure that it actually contains sensitive data. Note that sample data is retrieved by a data
        /// discovery job only if the isSampleDataCollectionEnabled attribute is set to true. At present, only one data
        /// value is collected per sensitive column.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sampleDataValues")]
        public System.Collections.Generic.List<string> SampleDataValues { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are application-level (non-dictionary) children of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "appDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> AppDefinedChildColumnKeys { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are database-level (dictionary-defined) children of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "dbDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> DbDefinedChildColumnKeys { get; set; }
        
        /// <value>
        /// The composite key groups to which the sensitive column belongs. If the column is part of a composite key,
        /// it's assigned a column group. It helps identify and manage referential relationships that involve composite keys.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "columnGroups")]
        public System.Collections.Generic.List<string> ColumnGroups { get; set; }
        
    }
}
