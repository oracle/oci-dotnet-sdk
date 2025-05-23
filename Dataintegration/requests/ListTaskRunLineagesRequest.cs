/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dataintegration/ListTaskRunLineages.cs.html">here</a> to see an example of how to use ListTaskRunLineages request.
    /// </example>
    public class ListTaskRunLineagesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The workspace ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkspaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "workspaceId")]
        public string WorkspaceId { get; set; }
        
        /// <value>
        /// The application key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "applicationKey")]
        public string ApplicationKey { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If
        /// you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Specifies the fields to get for an object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Fields { get; set; }
        
        /// <value>
        /// For list pagination. The value for this parameter is the `opc-next-page` or the `opc-prev-page` response header from the previous `List` call. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Sets the maximum number of results per page, or items to return in a paginated `List` call. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// Specifies sort order to use, either `ASC` (ascending) or `DESC` (descending).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// Specifies sort order to use, either `ASC` (ascending) or `DESC` (descending).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Specifies the field to sort by. Accepts only one field. By default, when you sort by time fields, results are shown in descending order. All other fields default to ascending order. Sorting related parameters are ignored when parameter `query` is present (search operation and sorting order is by relevance score in descending order).
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIME_CREATED")]
            TimeCreated,
            [EnumMember(Value = "DISPLAY_NAME")]
            DisplayName,
            [EnumMember(Value = "TIME_UPDATED")]
            TimeUpdated
        };

        /// <value>
        /// Specifies the field to sort by. Accepts only one field. By default, when you sort by time fields, results are shown in descending order. All other fields default to ascending order. Sorting related parameters are ignored when parameter `query` is present (search operation and sorting order is by relevance score in descending order).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// This filter parameter can be used to filter by model specific queryable fields of the object <br><br><B>Examples:-</B><br> <ul> <li><B>?filter=status eq Failed</B> returns all objects that have a status field with value Failed</li> </ul>
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filter", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Filter { get; set; }
        
        /// <value>
        /// This parameter allows users to get objects which were updated after a certain time. The format of timeUpdatedGreaterThan is \"YYYY-MM-dd'T'HH:mm:ss.SSS'Z'\"
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedGreaterThan")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThan { get; set; }
        
        /// <value>
        /// This parameter allows users to get objects which were updated after and at a certain time. The format of timeUpdatedGreaterThanOrEqualTo is \"YYYY-MM-dd'T'HH:mm:ss.SSS'Z'\"
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// This parameter allows users to get objects which were updated before a certain time. The format of timeUpatedLessThan is \"YYYY-MM-dd'T'HH:mm:ss.SSS'Z'\"
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpatedLessThan")]
        public System.Nullable<System.DateTime> TimeUpatedLessThan { get; set; }
        
        /// <value>
        /// This parameter allows users to get objects which were updated before and at a certain time. The format of timeUpatedLessThanOrEqualTo is \"YYYY-MM-dd'T'HH:mm:ss.SSS'Z'\"
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpatedLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUpatedLessThanOrEqualTo { get; set; }
    }
}
