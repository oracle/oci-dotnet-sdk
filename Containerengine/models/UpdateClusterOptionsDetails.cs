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
    /// The properties that define extra options updating a cluster.
    /// </summary>
    public class UpdateClusterOptionsDetails 
    {
        
        /// <value>
        /// Configurable cluster admission controllers
        /// </value>
        [JsonProperty(PropertyName = "admissionControllerOptions")]
        public AdmissionControllerOptions AdmissionControllerOptions { get; set; }
        
        [JsonProperty(PropertyName = "persistentVolumeConfig")]
        public PersistentVolumeConfigDetails PersistentVolumeConfig { get; set; }
        
        [JsonProperty(PropertyName = "serviceLbConfig")]
        public ServiceLbConfigDetails ServiceLbConfig { get; set; }
        
        [JsonProperty(PropertyName = "openIdConnectTokenAuthenticationConfig")]
        public OpenIdConnectTokenAuthenticationConfig OpenIdConnectTokenAuthenticationConfig { get; set; }
        
        [JsonProperty(PropertyName = "openIdConnectDiscovery")]
        public OpenIdConnectDiscovery OpenIdConnectDiscovery { get; set; }
        
    }
}
