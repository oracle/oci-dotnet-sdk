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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of the monitor assigned to an On-premise vantage point worker.
    /// </summary>
    public class WorkerMonitorList 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique name that can be edited. The name should not contain any confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Type of monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorType is required.")]
        [JsonProperty(PropertyName = "monitorType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MonitorTypes> MonitorType { get; set; }
        
        /// <value>
        /// If isRunNow is enabled, then the monitor will run immediately.
        /// </value>
        [JsonProperty(PropertyName = "isRunNow")]
        public System.Nullable<bool> IsRunNow { get; set; }
        
        /// <value>
        /// The time the resource was last assigned to an On-premise vantage point worker, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-12T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timeAssigned")]
        public System.Nullable<System.DateTime> TimeAssigned { get; set; }
        
    }
}
