/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CloudguardService.Models;

namespace Oci.CloudguardService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cloudguard/ListProblems.cs.html">here</a> to see an example of how to use ListProblems request.
    /// </example>
    public class ListProblemsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Start time for a filter. If start time is not specified, start time will be set to current time - 30 days.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastDetectedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLastDetectedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// End time for a filter. If end time is not specified, end time will be set to current time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastDetectedLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLastDetectedLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// Start time for a filter. If start time is not specified, start time will be set to current time - 30 days.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeFirstDetectedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeFirstDetectedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// End time for a filter. If end time is not specified, end time will be set to current time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeFirstDetectedLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeFirstDetectedLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The field life cycle state. Only one state can be provided. Default value for state is active.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleDetail")]
        public System.Nullable<ProblemLifecycleDetail> LifecycleDetail { get; set; }
        
        /// <value>
        /// The field lifecycle state. Only one state can be provided. Default value for state is active. If no value is specified state is active.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<ProblemLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// OCI monitoring region.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "region")]
        public string Region { get; set; }
        
        /// <value>
        /// Risk level of the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "riskLevel")]
        public string RiskLevel { get; set; }
        
        /// <value>
        /// Resource type associated with the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// City of the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "city")]
        public string City { get; set; }
        
        /// <value>
        /// State or province of the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "state")]
        public string State { get; set; }
        
        /// <value>
        /// Country of the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "country")]
        public string Country { get; set; }
        
        /// <value>
        /// User-defined label associated with the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "label")]
        public string Label { get; set; }
        
        /// <value>
        /// Comma seperated list of detector rule IDs to be passed in to match against Problems.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "detectorRuleIdList", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DetectorRuleIdList { get; set; }
        
        /// <value>
        /// The field to list the problems by detector type.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "detectorType")]
        public System.Nullable<DetectorEnum> DetectorType { get; set; }
        
        /// <value>
        /// The ID of the target in which to list resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Setting this to `SECURITY_ZONE` returns only security zone-related violations.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "problemCategory")]
        public System.Nullable<ProblemCategoryEnum> ProblemCategory { get; set; }
        
        /// <value>
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed
        /// and all compartments and subcompartments in the tenancy are
        /// returned depending on the setting of `accessLevel`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`.
        /// Setting this to `ACCESSIBLE` returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment).
        /// When set to `RESTRICTED` permissions are checked and no partial results are displayed.
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
        /// Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`.
        /// Setting this to `ACCESSIBLE` returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment).
        /// When set to `RESTRICTED` permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// The ID of the resource associated with the problem.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The maximum number of items to return
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for riskLevel, timeLastDetected and resourceName is descending. Default order for riskLevel and resourceName is ascending. If no value is specified timeLastDetected is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "riskLevel")]
            RiskLevel,
            [EnumMember(Value = "timeLastDetected")]
            TimeLastDetected,
            [EnumMember(Value = "resourceName")]
            ResourceName
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for riskLevel, timeLastDetected and resourceName is descending. Default order for riskLevel and resourceName is ascending. If no value is specified timeLastDetected is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
