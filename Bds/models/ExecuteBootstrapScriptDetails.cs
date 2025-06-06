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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about the bootstrap script to be executed.
    /// </summary>
    public class ExecuteBootstrapScriptDetails 
    {
        
        /// <value>
        /// Base-64 encoded password for the cluster admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
        /// <value>
        /// pre-authenticated URL of the bootstrap script in Object Store that can be downloaded and executed.
        /// </value>
        [JsonProperty(PropertyName = "bootstrapScriptUrl")]
        public string BootstrapScriptUrl { get; set; }
        
    }
}
