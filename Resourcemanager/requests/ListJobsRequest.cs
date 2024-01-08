/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ResourcemanagerService.Models;

namespace Oci.ResourcemanagerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/resourcemanager/ListJobs.cs.html">here</a> to see an example of how to use ListJobs request.
    /// </example>
    public class ListJobsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A filter to return only resources that exist in the compartment, identified by [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The stack [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) on which to filter.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "stackId")]
        public string StackId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) on which to query for jobs.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A filter that returns all resources that match the specified lifecycle state.
        /// The state value is case-insensitive.
        /// <br/>
        /// Allowable values:
        /// - ACCEPTED
        /// - IN_PROGRESS
        /// - FAILED
        /// - SUCCEEDED
        /// - CANCELING
        /// - CANCELED
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<Job.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given display name exactly.
        /// Use this filter to list a resource by name.
        /// Requires `sortBy` set to `DISPLAYNAME`.
        /// Alternatively, when you know the resource OCID, use the related Get operation.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        ///
        /// <value>
        /// The field to use when sorting returned resources.
        /// By default, `TIMECREATED` is ordered descending.
        /// By default, `DISPLAYNAME` is ordered ascending. Note that you can sort only on one field.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname
        };

        /// <value>
        /// The field to use when sorting returned resources.
        /// By default, `TIMECREATED` is ordered descending.
        /// By default, `DISPLAYNAME` is ordered ascending. Note that you can sort only on one field.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use when sorting returned resources. Ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use when sorting returned resources. Ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The number of items returned in a paginated `List` call. For information about pagination, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the preceding `List` call.
        /// For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
    }
}
