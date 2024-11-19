/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Database system connection information. Used to connect to PostgreSQL instance(s).
    /// </summary>
    public class ConnectionDetails 
    {
        
        /// <value>
        /// The CA certificate to be used by the PosgreSQL client to connect to the database.
        /// The CA certificate is used to authenticate the server identity. 
        /// It is issued by PostgreSQL Service Private CA.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CaCertificate is required.")]
        [JsonProperty(PropertyName = "caCertificate")]
        public string CaCertificate { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrimaryDbEndpoint is required.")]
        [JsonProperty(PropertyName = "primaryDbEndpoint")]
        public Endpoint PrimaryDbEndpoint { get; set; }
        
        /// <value>
        /// The list of database instance node endpoints in the database system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceEndpoints is required.")]
        [JsonProperty(PropertyName = "instanceEndpoints")]
        public System.Collections.Generic.List<DbInstanceEndpoint> InstanceEndpoints { get; set; }
        
        [JsonProperty(PropertyName = "readerEndpoint")]
        public Endpoint ReaderEndpoint { get; set; }
        
    }
}
