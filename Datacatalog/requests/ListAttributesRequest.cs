/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/ListAttributes.cs.html">here</a> to see an example of how to use ListAttributes request.
    /// </example>
    public class ListAttributesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique data asset key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// Unique entity key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "entityKey")]
        public string EntityKey { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire business name given. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "businessName")]
        public string BusinessName { get; set; }
        
        /// <value>
        /// A filter to return only resources that match display name or business name pattern given. The match is not case sensitive.
        /// For Example : /folders?displayOrBusinessNameContains=Cu.*
        /// The above would match all folders with display name or business name that starts with \"Cu\" or has the pattern \"Cu\" anywhere in between.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayOrBusinessNameContains")]
        public string DisplayOrBusinessNameContains { get; set; }
        
        /// <value>
        /// A filter to return only resources that match display name pattern given. The match is not case sensitive.
        /// For Example : /folders?displayNameContains=Cu.*
        /// The above would match all folders with display name that starts with \"Cu\" or has the pattern \"Cu\" anywhere in between.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayNameContains")]
        public string DisplayNameContains { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the specified lifecycle state. The value is case insensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Time that the resource was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time that the resource was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// Unique external identifier of this resource in the external source system.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "externalKey")]
        public string ExternalKey { get; set; }
        
        /// <value>
        /// Last modified timestamp of this object in the external system.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }
        
        /// <value>
        /// Data type as defined in an external system.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "externalTypeName")]
        public string ExternalTypeName { get; set; }
        
        /// <value>
        /// Identifies whether this attribute can be used as a watermark to extract incremental data.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isIncrementalData")]
        public System.Nullable<bool> IsIncrementalData { get; set; }
        
        /// <value>
        /// Identifies whether this attribute can be assigned null value.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }
        
        /// <value>
        /// Max allowed length of the attribute value.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "length")]
        public System.Nullable<long> Length { get; set; }
        
        /// <value>
        /// Position of the attribute in the record definition.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "position")]
        public System.Nullable<int> Position { get; set; }
        
        /// <value>
        /// Precision of the attribute value usually applies to float data type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "precision")]
        public System.Nullable<int> Precision { get; set; }
        
        /// <value>
        /// Scale of the attribute value usually applies to float data type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scale")]
        public System.Nullable<int> Scale { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in an entity attribute summary response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "entityKey")]
            EntityKey,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "externalDataType")]
            ExternalDataType,
            [EnumMember(Value = "externalKey")]
            ExternalKey,
            [EnumMember(Value = "length")]
            Length,
            [EnumMember(Value = "precision")]
            Precision,
            [EnumMember(Value = "scale")]
            Scale,
            [EnumMember(Value = "isNullable")]
            IsNullable,
            [EnumMember(Value = "uri")]
            Uri,
            [EnumMember(Value = "path")]
            Path,
            [EnumMember(Value = "minCollectionCount")]
            MinCollectionCount,
            [EnumMember(Value = "maxCollectionCount")]
            MaxCollectionCount,
            [EnumMember(Value = "datatypeEntityKey")]
            DatatypeEntityKey,
            [EnumMember(Value = "externalDatatypeEntityKey")]
            ExternalDatatypeEntityKey,
            [EnumMember(Value = "parentAttributeKey")]
            ParentAttributeKey,
            [EnumMember(Value = "externalParentAttributeKey")]
            ExternalParentAttributeKey,
            [EnumMember(Value = "position")]
            Position,
            [EnumMember(Value = "typeKey")]
            TypeKey
        };

        /// <value>
        /// Specifies the fields to return in an entity attribute summary response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. DISPLAYORBUSINESSNAME considers businessName of a given object if set, else its displayName is used.
        /// Default sort order for TIMECREATED is descending and default sort order for DISPLAYNAME, POSITION and DISPLAYORBUSINESSNAME is ascending. If no order is specified, POSITION is the default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname,
            [EnumMember(Value = "POSITION")]
            Position,
            [EnumMember(Value = "DISPLAYORBUSINESSNAME")]
            Displayorbusinessname
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. DISPLAYORBUSINESSNAME considers businessName of a given object if set, else its displayName is used.
        /// Default sort order for TIMECREATED is descending and default sort order for DISPLAYNAME, POSITION and DISPLAYORBUSINESSNAME is ascending. If no order is specified, POSITION is the default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
