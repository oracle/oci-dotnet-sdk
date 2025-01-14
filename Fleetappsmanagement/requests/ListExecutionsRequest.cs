/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.FleetappsmanagementService.Models;

namespace Oci.FleetappsmanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/fleetappsmanagement/ListExecutions.cs.html">here</a> to see an example of how to use ListExecutions request.
    /// </example>
    public class ListExecutionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// unique SchedulerJob identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchedulerJobId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "schedulerJobId")]
        public string SchedulerJobId { get; set; }
        
        /// <value>
        /// unique jobActivity identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobActivityId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobActivityId")]
        public string JobActivityId { get; set; }
        
        /// <value>
        /// unique Resource identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Task Id
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceTaskId")]
        public string ResourceTaskId { get; set; }
        
        /// <value>
        /// Unique step name
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "stepName")]
        public string StepName { get; set; }
        
        /// <value>
        /// Unique target name
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetName")]
        public string TargetName { get; set; }
        
        /// <value>
        /// Task Order Sequence
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sequence")]
        public string Sequence { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeStarted is descending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeStarted")]
            TimeStarted
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeStarted is descending.
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
