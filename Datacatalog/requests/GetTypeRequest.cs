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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/GetType.cs.html">here</a> to see an example of how to use GetType request.
    /// </example>
    public class GetTypeRequest : Oci.Common.IOciRequest
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
        /// Unique type key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TypeKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "typeKey")]
        public string TypeKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a type response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "catalogId")]
            CatalogId,
            [EnumMember(Value = "properties")]
            Properties,
            [EnumMember(Value = "isInternal")]
            IsInternal,
            [EnumMember(Value = "isTag")]
            IsTag,
            [EnumMember(Value = "isApproved")]
            IsApproved,
            [EnumMember(Value = "typeCategory")]
            TypeCategory,
            [EnumMember(Value = "externalTypeName")]
            ExternalTypeName,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "uri")]
            Uri
        };

        /// <value>
        /// Specifies the fields to return in a type response.
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
