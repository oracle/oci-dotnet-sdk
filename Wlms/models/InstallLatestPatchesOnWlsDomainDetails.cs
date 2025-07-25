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


namespace Oci.WlmsService.Models
{
    /// <summary>
    /// The configuration details for the install latest patches to WebLogic domain operation.
    /// 
    /// </summary>
    public class InstallLatestPatchesOnWlsDomainDetails 
    {
        
        /// <value>
        /// When installing or uninstalling patches, forces shutdown of the servers if they have not shutdown after a period of time. The timeout can be configured in the WebLogic domain configuration.
        /// </value>
        [JsonProperty(PropertyName = "isForceServersShutdown")]
        public System.Nullable<bool> IsForceServersShutdown { get; set; }
        
        /// <value>
        /// When installing or uninstalling patches, allows the operation to proceed on all domains that share the same middleware. If not set to true, the installation or uninstallation will fail if there is any other domain using the same middleware.
        /// </value>
        [JsonProperty(PropertyName = "mustIncludeDomainsSharingMiddleware")]
        public System.Nullable<bool> MustIncludeDomainsSharingMiddleware { get; set; }
        
    }
}
