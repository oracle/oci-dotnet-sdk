/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CapacitymanagementService.Models;

namespace Oci.CapacitymanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/capacitymanagement/ListInternalOccHandoverResourceBlocks.cs.html">here</a> to see an example of how to use ListInternalOccHandoverResourceBlocks request.
    /// </example>
    public class ListInternalOccHandoverResourceBlocksRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The namespace enum value that needs to be passed as a required query parameter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "namespace")]
        public System.Nullable<Namespace> Namespace { get; set; }
        
        /// <value>
        /// The ocid of the compartment or tenancy in which resources are to be listed. This will also be used for authorization purposes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The customer group ocid by which we would filter the list.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OccCustomerGroupId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "occCustomerGroupId")]
        public string OccCustomerGroupId { get; set; }
        
        /// <value>
        /// A filter to return only the list of resources that match the name provided in this filter.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "handoverResourceName")]
        public string HandoverResourceName { get; set; }
        
        /// <value>
        /// This filter helps in fetching all handed over resources for which the recordDate is greater than or equal to the startDate.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "handoverDateGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> HandoverDateGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// This filter helps in fetching all handed over resources for which the recordDate is less than or equal to the endDate.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "handoverDateLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> HandoverDateLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// This filter helps in fetching the handed over resource for which the occHandoverResourceId is equal to the one provided here.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "occHandoverResourceBlockId")]
        public string OccHandoverResourceBlockId { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing. The only valid characters for request IDs are letters, numbers,
        /// underscore, and dash.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. 
        /// The default order for handoverDate is chronological order(latest date item at the end).
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "handoverDate")]
            HandoverDate
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. 
        /// The default order for handoverDate is chronological order(latest date item at the end).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
