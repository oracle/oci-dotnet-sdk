/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cloudguard/ListResourceProfiles.cs.html">here</a> to see an example of how to use ListResourceProfiles request.
    /// </example>
    public class ListResourceProfilesRequest : Oci.Common.IOciRequest
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
        /// A filter to return only resources that match the list of resource types given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceTypes", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ResourceTypes { get; set; }
        
        /// <value>
        /// Risk score filter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "riskScoreGreaterThanOrEqualTo")]
        public System.Double RiskScoreGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Risk score filter,
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "riskScoreLessThanOrEqualTo")]
        public System.Double RiskScoreLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the list of techniques given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "techniques", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Techniques { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the list of tactics given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "tactics", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Tactics { get; set; }
        
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
        /// The field to sort resource profiles. Only one sort order may be provided. Default order for timeLastDetected is descending. If no value is specified timeLastDetected is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "riskScore")]
            RiskScore,
            [EnumMember(Value = "riskScoreGrowth")]
            RiskScoreGrowth,
            [EnumMember(Value = "timeFirstDetected")]
            TimeFirstDetected,
            [EnumMember(Value = "timeLastDetected")]
            TimeLastDetected,
            [EnumMember(Value = "sightingsCount")]
            SightingsCount,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "type")]
            Type
        };

        /// <value>
        /// The field to sort resource profiles. Only one sort order may be provided. Default order for timeLastDetected is descending. If no value is specified timeLastDetected is default.
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
