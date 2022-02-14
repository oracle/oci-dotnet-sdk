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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of a discovery job result.
    /// </summary>
    public class DiscoveryJobResultSummary 
    {
        
        /// <value>
        /// The unique key that identifies the discovery result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The type of the discovery result. It can be one of the following three types:
        /// NEW: A new sensitive column in the target database that is not in the sensitive data model.
        /// DELETED: A column that is present in the sensitive data model but has been deleted from the target database.
        /// MODIFIED: A column that is present in the target database as well as the sensitive data model but some of its attributes have been modified.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiscoveryType is required.")]
        [JsonProperty(PropertyName = "discoveryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoveryJobResult.DiscoveryTypeEnum> DiscoveryType { get; set; }
        
        /// <value>
        /// The unique key that identifies the sensitive column represented by the discovery result.
        /// </value>
        [JsonProperty(PropertyName = "sensitiveColumnkey")]
        public string SensitiveColumnkey { get; set; }
        
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
        [JsonConverter(typeof(StringEnumConverter))]
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
        
        /// <value>
        /// The OCID of the sensitive type associated with the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are parents of the sensitive column. At present, it tracks a single parent only.
        /// </value>
        [JsonProperty(PropertyName = "parentColumnKeys")]
        public System.Collections.Generic.List<string> ParentColumnKeys { get; set; }
                ///
        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the sensitive
        /// column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database dictionary.
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        ///
        public enum RelationTypeEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "APP_DEFINED")]
            AppDefined,
            [EnumMember(Value = "DB_DEFINED")]
            DbDefined
        };

        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the sensitive
        /// column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database dictionary.
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelationType is required.")]
        [JsonProperty(PropertyName = "relationType")]
        [JsonConverter(typeof(StringEnumConverter))]
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
        /// Specifies how to process the discovery result. It's set to NONE by default. Use the PatchDiscoveryJobResults operation to update this attribute. You can choose one of the following options:
        /// ACCEPT: To accept the discovery result and update the sensitive data model to reflect the changes.
        /// REJECT: To reject the discovery result so that it doesn't change the sensitive data model.
        /// INVALIDATE: To invalidate a newly discovered column. It adds the column to the sensitive data model but marks it as invalid. It helps track false positives and ensure that they aren't reported by future discovery jobs.
        /// After specifying the planned action, you can use the ApplyDiscoveryJobResults operation to automatically process the discovery results.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlannedAction is required.")]
        [JsonProperty(PropertyName = "plannedAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoveryJobResult.PlannedActionEnum> PlannedAction { get; set; }
        
        /// <value>
        /// Indicates if the discovery result has been processed. You can update this attribute using the PatchDiscoveryJobResults
        /// operation to track whether the discovery result has already been processed and applied to the sensitive data model.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsResultApplied is required.")]
        [JsonProperty(PropertyName = "isResultApplied")]
        public System.Nullable<bool> IsResultApplied { get; set; }
        
    }
}