/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary of Data Guard performance metrics for Managed Databases.
    /// </summary>
    public class DataguardPerformanceMetrics 
    {
        
        /// <value>
        /// A summary of Data Guard performance metrics such as ApplyLag, TransportLag and RedoApplyRate, for Managed Databases.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricsData is required.")]
        [JsonProperty(PropertyName = "metricsData")]
        public System.Collections.Generic.List<PerformanceMetricsData> MetricsData { get; set; }
        
    }
}
