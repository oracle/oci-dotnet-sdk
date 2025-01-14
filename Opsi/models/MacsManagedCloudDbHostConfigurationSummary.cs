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
    /// Configuration Summary of Cloud MACS-managed database host insight resource.
    /// </summary>
    public class MacsManagedCloudDbHostConfigurationSummary : HostConfigurationSummary
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
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentId is required.")]
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataDetails is required.")]
        [JsonProperty(PropertyName = "exadataDetails")]
        public ExadataDetails ExadataDetails { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "MACS_MANAGED_CLOUD_DB_HOST";
    }
}
