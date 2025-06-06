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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/GetAttributeTag.cs.html">here</a> to see an example of how to use GetAttributeTag request.
    /// </example>
    public class GetAttributeTagRequest : Oci.Common.IOciRequest
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
        /// Unique attribute key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "attributeKey")]
        public string AttributeKey { get; set; }
        
        /// <value>
        /// Unique tag key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "tagKey")]
        public string TagKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in an entity attribute tag response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "termKey")]
            TermKey,
            [EnumMember(Value = "termPath")]
            TermPath,
            [EnumMember(Value = "termDescription")]
            TermDescription,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "uri")]
            Uri,
            [EnumMember(Value = "attributeKey")]
            AttributeKey
        };

        /// <value>
        /// Specifies the fields to return in an entity attribute tag response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
