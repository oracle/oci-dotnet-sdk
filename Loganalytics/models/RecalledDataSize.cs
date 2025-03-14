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
    /// This is the recall related data size for the given timeframe
    /// 
    /// </summary>
    public class RecalledDataSize 
    {
        
        /// <value>
        /// This is the start of the time range of the archival data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataStarted is required.")]
        [JsonProperty(PropertyName = "timeDataStarted")]
        public System.Nullable<System.DateTime> TimeDataStarted { get; set; }
        
        /// <value>
        /// This is the end of the time range of the archival data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataEnded is required.")]
        [JsonProperty(PropertyName = "timeDataEnded")]
        public System.Nullable<System.DateTime> TimeDataEnded { get; set; }
        
        /// <value>
        /// This is the size of the recalled data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecalledDataInBytes is required.")]
        [JsonProperty(PropertyName = "recalledDataInBytes")]
        public System.Nullable<long> RecalledDataInBytes { get; set; }
        
        /// <value>
        /// This is the size of the archival data not recalled yet
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NotRecalledDataInBytes is required.")]
        [JsonProperty(PropertyName = "notRecalledDataInBytes")]
        public System.Nullable<long> NotRecalledDataInBytes { get; set; }
        
    }
}
