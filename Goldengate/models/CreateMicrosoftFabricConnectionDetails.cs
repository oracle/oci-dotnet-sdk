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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new Microsoft Fabric Connection.
    /// 
    /// </summary>
    public class CreateMicrosoftFabricConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Microsoft Fabric technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MicrosoftFabricConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Azure tenant ID of the application.
        /// e.g.: 14593954-d337-4a61-a364-9f758c64f97f
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// Azure client ID of the application.
        /// e.g.: 06ecaabf-8b80-4ec8-a0ec-20cbf463703d
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientId is required.")]
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// Client secret associated with the client id.
        /// Deprecated: This field is deprecated and replaced by \"clientSecretSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the client secret is stored.
        /// Note: When provided, 'clientSecret' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientSecretSecretId")]
        public string ClientSecretSecretId { get; set; }
        
        /// <value>
        /// Optional Microsoft Fabric service endpoint.
        /// Default value: https://onelake.dfs.fabric.microsoft.com
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "MICROSOFT_FABRIC";
    }
}
