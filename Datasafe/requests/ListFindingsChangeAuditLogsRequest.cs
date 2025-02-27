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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListFindingsChangeAuditLogs.cs.html">here</a> to see an example of how to use ListFindingsChangeAuditLogs request.
    /// </example>
    public class ListFindingsChangeAuditLogsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the security assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityAssessmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "securityAssessmentId")]
        public string SecurityAssessmentId { get; set; }
        
        ///
        /// <value>
        /// A filter to return only findings of a particular risk level.
        /// </value>
        ///
        public enum SeverityEnum {
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "EVALUATE")]
            Evaluate,
            [EnumMember(Value = "ADVISORY")]
            Advisory,
            [EnumMember(Value = "PASS")]
            Pass,
            [EnumMember(Value = "DEFERRED")]
            Deferred
        };

        /// <value>
        /// A filter to return only findings of a particular risk level.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "severity")]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The unique key that identifies the finding. It is a string and unique within a security assessment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "findingKey")]
        public string FindingKey { get; set; }
        
        /// <value>
        /// The unique title that identifies the finding. It is a string and unique within a security assessment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "findingTitle")]
        public string FindingTitle { get; set; }
        
        /// <value>
        /// A filter to check findings whose risks were deferred by the user.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isRiskDeferred")]
        public System.Nullable<bool> IsRiskDeferred { get; set; }
        
        /// <value>
        /// A filter to check which user modified the risk level of the finding.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "modifiedBy")]
        public string ModifiedBy { get; set; }
        
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
        /// The field to sort by. You can specify only one sort order(sortOrder). The default order for timeUpdated is descending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "modifiedBy")]
            ModifiedBy,
            [EnumMember(Value = "isRiskDeferred")]
            IsRiskDeferred,
            [EnumMember(Value = "timeValidUntil")]
            TimeValidUntil
        };

        /// <value>
        /// The field to sort by. You can specify only one sort order(sortOrder). The default order for timeUpdated is descending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Specifying `TimeValidUntilGreaterThanOrEqualToQueryParam` parameter 
        /// will retrieve all items for which the risk level modification by user will 
        /// no longer be valid greater than the date and time specified,
        /// in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T00:00:00.000Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeValidUntilGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeValidUntilGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Specifying `TimeValidUntilLessThanQueryParam` parameter
        /// will retrieve all items for which the risk level modification by user will 
        /// be valid until less than the date and time specified,
        /// in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T00:00:00.000Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeValidUntilLessThan")]
        public System.Nullable<System.DateTime> TimeValidUntilLessThan { get; set; }
        
        /// <value>
        /// Search for resources that were updated after a specific date.
        /// Specifying this parameter corresponding `timeUpdatedGreaterThanOrEqualTo`
        /// parameter will retrieve all resources updated after the
        /// specified created date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by RFC 3339.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Search for resources that were updated before a specific date.
        /// Specifying this parameter corresponding `timeUpdatedLessThan`
        /// parameter will retrieve all resources updated before the
        /// specified created date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by RFC 3339.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedLessThan")]
        public System.Nullable<System.DateTime> TimeUpdatedLessThan { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
