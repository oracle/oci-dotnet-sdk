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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListFindings.cs.html">here</a> to see an example of how to use ListFindings request.
    /// </example>
    public class ListFindingsRequest : Oci.Common.IOciRequest
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
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A filter to return only the findings that are marked as top findings.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isTopFinding")]
        public System.Nullable<bool> IsTopFinding { get; set; }
        
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
        /// A filter to return only the findings that match the specified lifecycle states.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<FindingLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// An optional filter to return only findings that match the specified reference.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "references")]
        public System.Nullable<SecurityAssessmentReferences> References { get; set; }
        
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
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific target OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The scimQuery query parameter accepts filter expressions that use the syntax described in Section 3.2.2.2
        /// of the System for Cross-Domain Identity Management (SCIM) specification, which is available
        /// at [RFC3339](https://tools.ietf.org/html/draft-ietf-scim-api-12). In SCIM filtering expressions,
        /// text, date, and time values must be enclosed in quotation marks, with date and time values using ISO-8601 format.
        /// (Numeric and boolean values should not be quoted.)
        /// <br/>
        /// **Example: ** |scimQuery=(severity eq 'high') and (targetId eq 'target_1')scimQuery=(category eq &quot;Users&quot;) and (targetId eq &quot;target_1&quot;)scimQuery=(reference eq 'CIS') and (targetId eq 'target_1')Supported fields:severityfindingKeyreferencetargetIdisTopFindingtitlecategoryremarksdetailssummaryisRiskModified    
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scimQuery")]
        public string ScimQuery { get; set; }
        
        ///
        /// <value>
        /// Specifies a subset of fields to be returned in the response.
        /// </value>
        ///
        public enum FieldEnum {
            [EnumMember(Value = "severity")]
            Severity,
            [EnumMember(Value = "findingKey")]
            FindingKey,
            [EnumMember(Value = "reference")]
            Reference,
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "isTopFinding")]
            IsTopFinding,
            [EnumMember(Value = "title")]
            Title,
            [EnumMember(Value = "category")]
            Category,
            [EnumMember(Value = "remarks")]
            Remarks,
            [EnumMember(Value = "details")]
            Details,
            [EnumMember(Value = "summary")]
            Summary,
            [EnumMember(Value = "isRiskModified")]
            IsRiskModified
        };

        /// <value>
        /// Specifies a subset of fields to be returned in the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "field", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<FieldEnum> Field { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can specify only one sort order(sortOrder). The default order for category is alphabetical.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "category")]
            Category,
            [EnumMember(Value = "findingKey")]
            FindingKey,
            [EnumMember(Value = "severity")]
            Severity
        };

        /// <value>
        /// The field to sort by. You can specify only one sort order(sortOrder). The default order for category is alphabetical.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Each finding in security assessment has an associated key (think of key as a finding's name).
        /// For a given finding, the key will be the same across targets. The user can use these keys to filter the findings.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "findingKey")]
        public string FindingKey { get; set; }
    }
}
