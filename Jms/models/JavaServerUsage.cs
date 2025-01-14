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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Java Server usage during a specified time period.
    /// 
    /// </summary>
    public class JavaServerUsage 
    {
        
        /// <value>
        /// The internal identifier of the Java Server.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServerKey is required.")]
        [JsonProperty(PropertyName = "serverKey")]
        public string ServerKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related fleet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetId is required.")]
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// The name of the Java Server.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServerName is required.")]
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }
        
        /// <value>
        /// The version of the Java Server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serverVersion")]
        public string ServerVersion { get; set; }
        
        /// <value>
        /// The count of server instances of the Java Server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serverInstanceCount")]
        public System.Nullable<int> ServerInstanceCount { get; set; }
        
        /// <value>
        /// The approximate count of deployed applications in the Java Server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "approximateDeployedApplicationCount")]
        public System.Nullable<int> ApproximateDeployedApplicationCount { get; set; }
        
        /// <value>
        /// Lower bound of the specified time period filter. JMS provides a view of the data that is _per day_. The query uses only the date element of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Upper bound of the specified time period filter. JMS provides a view of the data that is _per day_. The query uses only the date element of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The date and time the resource was _first_ reported to JMS.
        /// This is potentially _before_ the specified time period provided by the filters.
        /// For example, a resource can be first reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSeen")]
        public System.Nullable<System.DateTime> TimeFirstSeen { get; set; }
        
        /// <value>
        /// The date and time the resource was _last_ reported to JMS.
        /// This is potentially _after_ the specified time period provided by the filters.
        /// For example, a resource can be last reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastSeen")]
        public System.Nullable<System.DateTime> TimeLastSeen { get; set; }
        
    }
}
