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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Connection details of a MACS-managed cloud database insight.
    /// </summary>
    public class ChangeMacsManagedCloudDatabaseInsightConnectionDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Management Agent
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementAgentId is required.")]
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionDetails is required.")]
        [JsonProperty(PropertyName = "connectionDetails")]
        public ConnectionDetails ConnectionDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionCredentialDetails is required.")]
        [JsonProperty(PropertyName = "connectionCredentialDetails")]
        public CredentialDetails ConnectionCredentialDetails { get; set; }
        
    }
}
