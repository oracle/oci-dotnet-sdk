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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The connector of the Exadata storage server.
    /// </summary>
    public class ExternalExadataStorageConnectorSummary : DbmResource
    {
        
        /// <value>
        /// The unique string of the connection. For example, \"https://<storage-server-name>/MS/RESTService/\".
        /// </value>
        [JsonProperty(PropertyName = "connectionUri")]
        public string ConnectionUri { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "storageServerId")]
        public string StorageServerId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the agent for the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        [JsonProperty(PropertyName = "resourceType")]
        private readonly string resourceType = "STORAGE_CONNECTOR_SUMMARY";
    }
}