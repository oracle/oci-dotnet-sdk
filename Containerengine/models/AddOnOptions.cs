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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define options for supported add-ons.
    /// </summary>
    public class AddOnOptions 
    {
        
        /// <value>
        /// Whether or not to enable the Kubernetes Dashboard add-on.
        /// </value>
        [JsonProperty(PropertyName = "isKubernetesDashboardEnabled")]
        public System.Nullable<bool> IsKubernetesDashboardEnabled { get; set; }
        
        /// <value>
        /// Whether or not to enable the Tiller add-on.
        /// </value>
        [JsonProperty(PropertyName = "isTillerEnabled")]
        public System.Nullable<bool> IsTillerEnabled { get; set; }
        
    }
}
