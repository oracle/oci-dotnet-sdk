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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The configuration details for returning history of suppressions for the specified alarm.
    /// 
    /// </summary>
    public class SummarizeAlarmSuppressionHistoryDetails 
    {
        
        /// <value>
        /// A filter to suppress only alarm state entries that include the set of specified dimension key-value pairs.
        /// If you specify {\"availabilityDomain\": \"phx-ad-1\"}
        /// and the alarm state entry corresponds to the set {\"availabilityDomain\": \"phx-ad-1\" and \"resourceId\": \"ocid1.instance.region1.phx.exampleuniqueID\"},
        /// then this alarm will be included for suppression.
        /// <br/>
        /// Example: {&quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;}
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// A filter to return only entries with \"timeSuppressFrom\" time occurring on or after the specified time.
        /// <br/>
        /// The value cannot be a future time.
        /// Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T01:02:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeSuppressFromGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeSuppressFromGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// A filter to return only entries with \"timeSuppressFrom\" time occurring before the specified time.
        /// <br/>
        /// The value cannot be a future time.
        /// Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T01:02:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeSuppressFromLessThan")]
        public System.Nullable<System.DateTime> TimeSuppressFromLessThan { get; set; }
        
    }
}