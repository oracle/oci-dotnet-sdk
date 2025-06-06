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
    /// Database insight resource.
    /// </summary>
    public class AutonomousDatabaseInsight : DatabaseInsight
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// Name of database
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseName is required.")]
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// Display name of database
        /// </value>
        [JsonProperty(PropertyName = "databaseDisplayName")]
        public string DatabaseDisplayName { get; set; }
        
        /// <value>
        /// OCI database resource type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseResourceType is required.")]
        [JsonProperty(PropertyName = "databaseResourceType")]
        public string DatabaseResourceType { get; set; }
        
        /// <value>
        /// Additional details of a database in JSON format. For autonomous databases, this is the AutonomousDatabase object serialized as a JSON string as defined in https://docs.cloud.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabase/. For EM, pass in null or an empty string. Note that this string needs to be escaped when specified in the curl command.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbAdditionalDetails")]
        public System.Object DbAdditionalDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the OPSI private endpoint
        /// </value>
        [JsonProperty(PropertyName = "opsiPrivateEndpointId")]
        public string OpsiPrivateEndpointId { get; set; }
        
        /// <value>
        /// Flag is to identify if advanced features for autonomous database is enabled or not
        /// </value>
        [JsonProperty(PropertyName = "isAdvancedFeaturesEnabled")]
        public System.Nullable<bool> IsAdvancedFeaturesEnabled { get; set; }
        
        [JsonProperty(PropertyName = "connectionDetails")]
        public ConnectionDetails ConnectionDetails { get; set; }
        
        [JsonProperty(PropertyName = "credentialDetails")]
        public CredentialDetails CredentialDetails { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "AUTONOMOUS_DATABASE";
    }
}
