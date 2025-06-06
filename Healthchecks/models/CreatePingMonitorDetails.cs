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


namespace Oci.HealthchecksService.Models
{
    /// <summary>
    /// The request body used to create a Ping monitor.
    /// </summary>
    public class CreatePingMonitorDetails 
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A list of targets (hostnames or IP addresses) of the probe.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Targets is required.")]
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<string> Targets { get; set; }
        
        /// <value>
        /// A list of names of vantage points from which to execute the probe.
        /// </value>
        [JsonProperty(PropertyName = "vantagePointNames")]
        public System.Collections.Generic.List<string> VantagePointNames { get; set; }
        
        /// <value>
        /// The port on which to probe endpoints. If unspecified, probes will use the
        /// default port of their protocol.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The probe timeout in seconds. Valid values: 10, 20, 30, and 60.
        /// The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PingProbeProtocol> Protocol { get; set; }
        
        /// <value>
        /// A user-friendly and mutable name suitable for display in a user interface.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The monitor interval in seconds. Valid values: 10, 30, and 60.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntervalInSeconds is required.")]
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public System.Nullable<int> IntervalInSeconds { get; set; }
        
        /// <value>
        /// Enables or disables the monitor. Set to 'true' to launch monitoring.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace.  For more information,
        /// see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
