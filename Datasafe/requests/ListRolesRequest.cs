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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListRoles.cs.html">here</a> to see an example of how to use ListRoles request.
    /// </example>
    public class ListRolesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the Data Safe target database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "targetDatabaseId")]
        public string TargetDatabaseId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
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
        /// A filter to return only a specific role based on role name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "roleName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> RoleName { get; set; }
        
        /// <value>
        /// A filter to return roles based on whether they are maintained by oracle or not.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isOracleMaintained")]
        public System.Nullable<bool> IsOracleMaintained { get; set; }
        
        /// <value>
        /// A filter to return roles based on authentication type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "authenticationType")]
        public string AuthenticationType { get; set; }
        
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
        
        ///
        /// <value>
        /// The field used for sorting. Only one sorting order (sortOrder) can be specified.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "ROLENAME")]
            Rolename
        };

        /// <value>
        /// The field used for sorting. Only one sorting order (sortOrder) can be specified.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// A filter to return only items if role name contains a specific string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "roleNameContains")]
        public string RoleNameContains { get; set; }
    }
}
