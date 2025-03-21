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
    /// The property that define the status of the OIDC Discovery feature for a cluster.
    /// 
    /// </summary>
    public class OpenIdConnectDiscovery 
    {
        
        /// <value>
        /// Whether the cluster has OIDC Discovery enabled. Defaults to false. If set to true, the cluster will be assigned a public OIDC Discovery endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isOpenIdConnectDiscoveryEnabled")]
        public System.Nullable<bool> IsOpenIdConnectDiscoveryEnabled { get; set; }
        
    }
}
