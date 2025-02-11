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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The information about new monitoring template. The monitoring template name should be unique in a compartment.
    /// </summary>
    public class CreateMonitoringTemplateDetails 
    {
        
        /// <value>
        /// A user-friendly name for the monitoring template. It is unique and mutable in nature. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the monitoringTemplate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly description for the monitoring template. It does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A list of destinations for alarm notifications. Each destination is represented by the OCID of a related resource, such as a topic.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destinations is required.")]
        [JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.List<string> Destinations { get; set; }
        
        /// <value>
        /// Whether the alarm is enabled or disabled, it will be Enabled by default.
        /// </value>
        [JsonProperty(PropertyName = "isAlarmsEnabled")]
        public System.Nullable<bool> IsAlarmsEnabled { get; set; }
        
        /// <value>
        /// Whether the alarm notification is enabled or disabled, it will be Enabled by default.
        /// </value>
        [JsonProperty(PropertyName = "isSplitNotificationEnabled")]
        public System.Nullable<bool> IsSplitNotificationEnabled { get; set; }
        
        /// <value>
        /// List of members of this monitoring template
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Members is required.")]
        [JsonProperty(PropertyName = "members")]
        public System.Collections.Generic.List<MemberReference> Members { get; set; }
        
        /// <value>
        /// The frequency for re-submitting alarm notifications, if the alarm keeps firing without interruption. Format defined by ISO 8601. For example, PT4H indicates four hours. Minimum- PT1M. Maximum - P30D.
        /// </value>
        [JsonProperty(PropertyName = "repeatNotificationDuration")]
        public string RepeatNotificationDuration { get; set; }
        
        /// <value>
        /// The format to use for alarm notifications.
        /// </value>
        [JsonProperty(PropertyName = "messageFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MessageFormat> MessageFormat { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
