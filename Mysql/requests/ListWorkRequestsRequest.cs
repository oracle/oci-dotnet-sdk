/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.MysqlService.Models;

namespace Oci.MysqlService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/mysql/ListWorkRequests.cs.html">here</a> to see an example of how to use ListWorkRequests request.
    /// </example>
    public class ListWorkRequestsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Customer-defined unique identifier for the request. If you need to
        /// contact Oracle about a specific request, please provide the request
        /// ID that you supplied in this header with the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// The optional field to sort the results by.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "ID")]
            Id,
            [EnumMember(Value = "OPERATION_TYPE")]
            OperationType,
            [EnumMember(Value = "STATUS")]
            Status,
            [EnumMember(Value = "TIME_ACCEPTED")]
            TimeAccepted,
            [EnumMember(Value = "TIME_STARTED")]
            TimeStarted,
            [EnumMember(Value = "TIME_FINISHED")]
            TimeFinished
        };

        /// <value>
        /// The optional field to sort the results by.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use (ASC or DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use (ASC or DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated list call. For information about pagination, see
        /// [List Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` or `opc-prev-page` response header from
        /// the previous list call. For information about pagination, see [List
        /// Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
    }
}
