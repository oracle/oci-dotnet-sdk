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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/GetCustomProperty.cs.html">here</a> to see an example of how to use GetCustomProperty request.
    /// </example>
    public class GetCustomPropertyRequest : Oci.Common.IOciRequest
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
        /// Unique namespace identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceId")]
        public string NamespaceId { get; set; }
        
        /// <value>
        /// Unique Custom Property key
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CustomPropertyKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "customPropertyKey")]
        public string CustomPropertyKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a custom property response.
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
            [EnumMember(Value = "dataType")]
            DataType,
            [EnumMember(Value = "namespaceName")]
            NamespaceName,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "updatedById")]
            UpdatedById,
            [EnumMember(Value = "properties")]
            Properties
        };

        /// <value>
        /// Specifies the fields to return in a custom property response.
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
