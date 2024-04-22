/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Summary information for a logging query for a data source.
    /// </summary>
    public class LoggingQueryDataSourceSummaryDetails : DataSourceSummaryDetails
    {
        
        /// <value>
        /// Data source customer-specified regions
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
        /// <value>
        /// Data source mapping with detector recipe and detector rule
        /// </value>
        [JsonProperty(PropertyName = "dataSourceDetectorMappingInfo")]
        public System.Collections.Generic.List<DataSourceMappingInfo> DataSourceDetectorMappingInfo { get; set; }
        
        /// <value>
        /// Data source query metadata replication region and status.
        /// </value>
        [JsonProperty(PropertyName = "regionStatusDetail")]
        public System.Collections.Generic.List<RegionStatusDetail> RegionStatusDetail { get; set; }
        
        [JsonProperty(PropertyName = "dataSourceFeedProvider")]
        private readonly string dataSourceFeedProvider = "LOGGINGQUERY";
    }
}
