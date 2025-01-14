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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of the external database connector used to connect to the external database.
    /// 
    /// </summary>
    public class ExternalConnectorDetails : ConnectorDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external database connector.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseConnectorId is required.")]
        [JsonProperty(PropertyName = "databaseConnectorId")]
        public string DatabaseConnectorId { get; set; }
        
        [JsonProperty(PropertyName = "connectorType")]
        private readonly string connectorType = "EXTERNAL";
    }
}
