/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.UsageService.Models;

namespace Oci.UsageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/usage/ListRedeemableUsers.cs.html">here</a> to see an example of how to use ListRedeemableUsers request.
    /// </example>
    public class ListRedeemableUsersRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// The subscription ID for which rewards information is requested for.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubscriptionId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// Unique, Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The value of the 'opc-next-page' response header from the previous call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of items to return in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, which can be ascending (ASC) or descending (DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, which can be ascending (ASC) or descending (DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Supports one sort order.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "TIMESTART")]
            Timestart
        };

        /// <value>
        /// The field to sort by. Supports one sort order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
