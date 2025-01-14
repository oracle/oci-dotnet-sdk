/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListSensitiveDataModelSensitiveTypes.cs.html">here</a> to see an example of how to use ListSensitiveDataModelSensitiveTypes request.
    /// </example>
    public class ListSensitiveDataModelSensitiveTypesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SensitiveDataModelId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific sensitive type OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
        
        ///
        /// <value>
        /// - The field to sort by. You can specify only one sorting parameter (sortorder).
        /// The default order is descending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "count")]
            Count
        };

        /// <value>
        /// - The field to sort by. You can specify only one sorting parameter (sortorder).
        /// The default order is descending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of items to return per page in a paginated \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
