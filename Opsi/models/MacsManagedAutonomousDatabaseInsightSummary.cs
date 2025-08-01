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
    /// Summary of a database insight resource.
    /// </summary>
    public class MacsManagedAutonomousDatabaseInsightSummary : DatabaseInsightSummary
    {
        
        /// <value>
        /// OCI database resource type
        /// </value>
        [JsonProperty(PropertyName = "databaseResourceType")]
        public string DatabaseResourceType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Management Agent
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VM Cluster or DB System ID, depending on which configuration the resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the root resource for a composite target. e.g. for ExaCS members the rootId will be the OCID of the Exadata Infrastructure resource.
        /// </value>
        [JsonProperty(PropertyName = "rootId")]
        public string RootId { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "MACS_MANAGED_AUTONOMOUS_DATABASE";
    }
}
