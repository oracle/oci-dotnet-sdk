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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// This is the input used to estimate the size of data that might be purged
    /// 
    /// </summary>
    public class EstimatePurgeDataSizeDetails 
    {
        
        /// <value>
        /// This is the compartment OCID under which the data will be purged
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If true, purge child compartments data
        /// </value>
        [JsonProperty(PropertyName = "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// This is the time before which data will be purged
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataEnded is required.")]
        [JsonProperty(PropertyName = "timeDataEnded")]
        public System.Nullable<System.DateTime> TimeDataEnded { get; set; }
        
        /// <value>
        /// This is the solr data filter query, '*' means all
        /// </value>
        [JsonProperty(PropertyName = "purgeQueryString")]
        public string PurgeQueryString { get; set; }
        
        /// <value>
        /// This is the type of the log data to be purged
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageDataType> DataType { get; set; }
        
    }
}
