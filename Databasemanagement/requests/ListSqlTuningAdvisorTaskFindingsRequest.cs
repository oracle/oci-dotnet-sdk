/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListSqlTuningAdvisorTaskFindings.cs.html">here</a> to see an example of how to use ListSqlTuningAdvisorTaskFindings request.
    /// </example>
    public class ListSqlTuningAdvisorTaskFindingsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The SQL tuning task identifier. This is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlTuningAdvisorTaskId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "sqlTuningAdvisorTaskId")]
        public System.Nullable<long> SqlTuningAdvisorTaskId { get; set; }
        
        /// <value>
        /// The optional greater than or equal to filter on the execution ID related to a specific SQL Tuning Advisor task.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "beginExecId")]
        public System.Nullable<long> BeginExecId { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter on the execution ID related to a specific SQL Tuning Advisor task.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endExecId")]
        public System.Nullable<long> EndExecId { get; set; }
        
        ///
        /// <value>
        /// The search period during which the API will search for begin and end exec id, if not supplied.
        /// Unused if beginExecId and endExecId optional query params are both supplied.
        /// 
        /// </value>
        ///
        public enum SearchPeriodEnum {
            [EnumMember(Value = "LAST_24HR")]
            Last24Hr,
            [EnumMember(Value = "LAST_7DAY")]
            Last7Day,
            [EnumMember(Value = "LAST_31DAY")]
            Last31Day,
            [EnumMember(Value = "SINCE_LAST")]
            SinceLast,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The search period during which the API will search for begin and end exec id, if not supplied.
        /// Unused if beginExecId and endExecId optional query params are both supplied.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "searchPeriod")]
        public System.Nullable<SearchPeriodEnum> SearchPeriod { get; set; }
        
        ///
        /// <value>
        /// The filter used to display specific findings in the report.
        /// </value>
        ///
        public enum FindingFilterEnum {
            [EnumMember(Value = "none")]
            None,
            [EnumMember(Value = "FINDINGS")]
            Findings,
            [EnumMember(Value = "NOFINDINGS")]
            Nofindings,
            [EnumMember(Value = "ERRORS")]
            Errors,
            [EnumMember(Value = "PROFILES")]
            Profiles,
            [EnumMember(Value = "INDICES")]
            Indices,
            [EnumMember(Value = "STATS")]
            Stats,
            [EnumMember(Value = "RESTRUCTURE")]
            Restructure,
            [EnumMember(Value = "ALTERNATIVE")]
            Alternative,
            [EnumMember(Value = "AUTO_PROFILES")]
            AutoProfiles,
            [EnumMember(Value = "OTHER_PROFILES")]
            OtherProfiles
        };

        /// <value>
        /// The filter used to display specific findings in the report.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "findingFilter")]
        public System.Nullable<FindingFilterEnum> FindingFilter { get; set; }
        
        /// <value>
        /// The hash value of the object for the statistic finding search.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "statsHashFilter")]
        public string StatsHashFilter { get; set; }
        
        /// <value>
        /// The hash value of the index table name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "indexHashFilter")]
        public string IndexHashFilter { get; set; }
        
        ///
        /// <value>
        /// The possible sortBy values of an object's recommendations.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "DBTIME_BENEFIT")]
            DbtimeBenefit,
            [EnumMember(Value = "PARSING_SCHEMA")]
            ParsingSchema,
            [EnumMember(Value = "SQL_ID")]
            SqlId,
            [EnumMember(Value = "STATS")]
            Stats,
            [EnumMember(Value = "PROFILES")]
            Profiles,
            [EnumMember(Value = "SQL_BENEFIT")]
            SqlBenefit,
            [EnumMember(Value = "DATE")]
            Date,
            [EnumMember(Value = "INDICES")]
            Indices,
            [EnumMember(Value = "RESTRUCTURE")]
            Restructure,
            [EnumMember(Value = "ALTERNATIVE")]
            Alternative,
            [EnumMember(Value = "MISC")]
            Misc,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "TIMEOUTS")]
            Timeouts
        };

        /// <value>
        /// The possible sortBy values of an object's recommendations.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order. Descending order is the default order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
