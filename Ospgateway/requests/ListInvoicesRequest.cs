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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ospgateway/ListInvoices.cs.html">here</a> to see an example of how to use ListInvoices request.
    /// </example>
    public class ListInvoicesRequest : Oci.Common.IOciRequest
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
        /// The invoice query param (not unique).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "invoiceId")]
        public string InvoiceId { get; set; }
        
        ///
        /// <value>
        /// A filter to only return resources that match the given type exactly.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "HARDWARE")]
            Hardware,
            [EnumMember(Value = "SUBSCRIPTION")]
            Subscription,
            [EnumMember(Value = "SUPPORT")]
            Support,
            [EnumMember(Value = "LICENSE")]
            License,
            [EnumMember(Value = "EDUCATION")]
            Education,
            [EnumMember(Value = "CONSULTING")]
            Consulting,
            [EnumMember(Value = "SERVICE")]
            Service,
            [EnumMember(Value = "USAGE")]
            Usage
        };

        /// <value>
        /// A filter to only return resources that match the given type exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "type", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<TypeEnum> Type { get; set; }
        
        /// <value>
        /// A filter to only return resources that match the given value.
        /// Looking for partial matches in the following fileds:
        /// Invoice No., Reference No. (plan number), Payment Ref, Total Amount(plan number), Balance Due(plan number)
        /// and Party/Customer Name
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "searchText")]
        public string SearchText { get; set; }
        
        /// <value>
        /// description: Start time (UTC) of the target invoice date range for which to fetch invoice data (inclusive).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeInvoiceStart")]
        public System.Nullable<System.DateTime> TimeInvoiceStart { get; set; }
        
        /// <value>
        /// description: End time (UTC) of the target invoice date range for which to fetch invoice data (exclusive).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeInvoiceEnd")]
        public System.Nullable<System.DateTime> TimeInvoiceEnd { get; set; }
        
        /// <value>
        /// description: Start time (UTC) of the target payment date range for which to fetch invoice data (inclusive).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timePaymentStart")]
        public System.Nullable<System.DateTime> TimePaymentStart { get; set; }
        
        /// <value>
        /// description: End time (UTC) of the target payment date range for which to fetch invoice data (exclusive).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timePaymentEnd")]
        public System.Nullable<System.DateTime> TimePaymentEnd { get; set; }
        
        ///
        /// <value>
        /// A filter to only return resources that match one of the status elements.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "OPEN")]
            Open,
            [EnumMember(Value = "PAST_DUE")]
            PastDue,
            [EnumMember(Value = "PAYMENT_SUBMITTED")]
            PaymentSubmitted,
            [EnumMember(Value = "CLOSED")]
            Closed
        };

        /// <value>
        /// A filter to only return resources that match one of the status elements.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<StatusEnum> Status { get; set; }
        
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
