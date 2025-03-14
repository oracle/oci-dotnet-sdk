/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OspgatewayService.Models;

namespace Oci.OspgatewayService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ospgateway/ListSubscriptions.cs.html">here</a> to see an example of how to use ListSubscriptions request.
    /// </example>
    public class ListSubscriptionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The home region's public name of the logged in user.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OspHomeRegion is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "ospHomeRegion")]
        public string OspHomeRegion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For list pagination. The value of the opc-next-page response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one field can be selected for sorting.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "INVOICE_NO")]
            InvoiceNo,
            [EnumMember(Value = "REF_NO")]
            RefNo,
            [EnumMember(Value = "STATUS")]
            Status,
            [EnumMember(Value = "TYPE")]
            Type,
            [EnumMember(Value = "INVOICE_DATE")]
            InvoiceDate,
            [EnumMember(Value = "DUE_DATE")]
            DueDate,
            [EnumMember(Value = "PAYM_REF")]
            PaymRef,
            [EnumMember(Value = "TOTAL_AMOUNT")]
            TotalAmount,
            [EnumMember(Value = "BALANCE_DUE")]
            BalanceDue
        };

        /// <value>
        /// The field to sort by. Only one field can be selected for sorting.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use (ascending or descending).
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
        /// The sort order to use (ascending or descending).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
    }
}
