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


namespace Oci.SchService.Models
{
    /// <summary>
    /// Details about a connector plugin used to fetch data from a source.
    /// For configuration instructions, see
    /// [Creating a Connector](https://docs.cloud.oracle.com/iaas/Content/connector-hub/create-service-connector.htm).
    /// 
    /// </summary>
    public class PluginSourceDetails : SourceDetails
    {
        
        /// <value>
        /// The name of the connector plugin. This name indicates the service to be called by the connector plugin. For example, `QueueSource` indicates the Queue service.
        /// To find names of connector plugins, list the plugin using (ListConnectorPlugin)[#/en/serviceconnectors/latest/ConnectorPluginSummary/ListConnectorPlugins].
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PluginName is required.")]
        [JsonProperty(PropertyName = "pluginName")]
        public string PluginName { get; set; }
        
        /// <value>
        /// The configuration map for the connector plugin. This map includes parameters specific to the connector plugin type. 
        /// For example, for `QueueSource`, the map lists the OCID of the selected queue.
        /// To find the parameters for a connector plugin, get the plugin using (GetConnectorPlugin)[#/en/serviceconnectors/latest/ConnectorPlugin/GetConnectorPlugin] and review its schema value.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigMap is required.")]
        [JsonProperty(PropertyName = "configMap")]
        public System.Object ConfigMap { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "plugin";
    }
}
