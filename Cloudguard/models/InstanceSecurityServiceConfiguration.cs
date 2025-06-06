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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Instance Security service configuration.
    /// </summary>
    public class InstanceSecurityServiceConfiguration : ServiceConfiguration
    {
        
        /// <value>
        /// Partner service status
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConfigurationLifecycleState> Status { get; set; }
        
        [JsonProperty(PropertyName = "serviceConfigurationType")]
        private readonly string serviceConfigurationType = "INSTANCE_SECURITY";
    }
}
