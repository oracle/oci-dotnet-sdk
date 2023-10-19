/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details about Oracle GoldenGate GGS Deployment.
    /// 
    /// </summary>
    public class GgsDeployment 
    {
        
        /// <value>
        /// OCID of a GoldenGate Deployment
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentId is required.")]
        [JsonProperty(PropertyName = "deploymentId")]
        public string DeploymentId { get; set; }
        
        /// <value>
        /// OCID of a VaultSecret containing the Admin Credentials for the GGS Deployment
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GgsAdminCredentialsSecretId is required.")]
        [JsonProperty(PropertyName = "ggsAdminCredentialsSecretId")]
        public string GgsAdminCredentialsSecretId { get; set; }
        
    }
}