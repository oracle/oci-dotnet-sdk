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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/GetDatabaseFleetHealthMetrics.cs.html">here</a> to see an example of how to use GetDatabaseFleetHealthMetrics request.
    /// </example>
    public class GetDatabaseFleetHealthMetricsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The baseline time for metrics comparison.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompareBaselineTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compareBaselineTime")]
        public string CompareBaselineTime { get; set; }
        
        /// <value>
        /// The target time for metrics comparison.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompareTargetTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compareTargetTime")]
        public string CompareTargetTime { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database Group.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "managedDatabaseGroupId")]
        public string ManagedDatabaseGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The time window used for metrics comparison.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compareType")]
        public System.Nullable<CompareType> CompareType { get; set; }
        
        /// <value>
        /// The filter used to retrieve a specific set of metrics by passing the desired metric names with a comma separator. Note that, by default, the service returns all supported metrics.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterByMetricNames")]
        public string FilterByMetricNames { get; set; }
        
        /// <value>
        /// The filter used to filter the databases in the fleet by a specific Oracle Database type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterByDatabaseType")]
        public string FilterByDatabaseType { get; set; }
        
        /// <value>
        /// The filter used to filter the databases in the fleet by a specific Oracle Database subtype.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterByDatabaseSubType")]
        public string FilterByDatabaseSubType { get; set; }
        
        /// <value>
        /// The filter used to filter the databases in the fleet by a specific Oracle Database deployment type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterByDatabaseDeploymentType")]
        public string FilterByDatabaseDeploymentType { get; set; }
        
        /// <value>
        /// The filter used to filter the databases in the fleet by a specific Oracle Database version.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterByDatabaseVersion")]
        public string FilterByDatabaseVersion { get; set; }
    }
}
