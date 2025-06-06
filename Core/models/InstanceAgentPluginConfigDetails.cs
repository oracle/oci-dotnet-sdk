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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The configuration of plugins associated with this instance.
    /// </summary>
    public class InstanceAgentPluginConfigDetails 
    {
        
        /// <value>
        /// The plugin name. To get a list of available plugins, use the
        /// {@link #listInstanceagentAvailablePlugins(ListInstanceagentAvailablePluginsRequest) listInstanceagentAvailablePlugins}
        /// operation in the Oracle Cloud Agent API. For more information about the available plugins, see
        /// [Managing Plugins with Oracle Cloud Agent](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/manage-plugins.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Whether the plugin should be enabled or disabled.
        /// <br/>
        /// To enable the monitoring and management plugins, the `isMonitoringDisabled` and
        /// `isManagementDisabled` attributes must also be set to false.
        /// 
        /// </value>
        ///
        public enum DesiredStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Whether the plugin should be enabled or disabled.
        /// <br/>
        /// To enable the monitoring and management plugins, the `isMonitoringDisabled` and
        /// `isManagementDisabled` attributes must also be set to false.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DesiredState is required.")]
        [JsonProperty(PropertyName = "desiredState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DesiredStateEnum> DesiredState { get; set; }
        
    }
}
