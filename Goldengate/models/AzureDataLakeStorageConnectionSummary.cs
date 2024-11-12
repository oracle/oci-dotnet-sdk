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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Summary of the Azure Data Lake Storage Connection.
    /// 
    /// </summary>
    public class AzureDataLakeStorageConnectionSummary : ConnectionSummary
    {
        
        /// <value>
        /// The Azure Data Lake Storage technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AzureDataLakeStorageConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Used authentication mechanism to access Azure Data Lake Storage.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationType is required.")]
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AzureDataLakeStorageConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// Sets the Azure storage account name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccountName is required.")]
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }
        
        /// <value>
        /// Azure tenant ID of the application. This property is required when 'authenticationType' is set to 'AZURE_ACTIVE_DIRECTORY'.
        /// e.g.: 14593954-d337-4a61-a364-9f758c64f97f
        /// 
        /// </value>
        [JsonProperty(PropertyName = "azureTenantId")]
        public string AzureTenantId { get; set; }
        
        /// <value>
        /// Azure client ID of the application. This property is required when 'authenticationType' is set to 'AZURE_ACTIVE_DIRECTORY'.
        /// e.g.: 06ecaabf-8b80-4ec8-a0ec-20cbf463703d
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// Azure Storage service endpoint.
        /// e.g: https://test.blob.core.windows.net
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the account key is stored.
        /// Note: When provided, 'accountKey' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accountKeySecretId")]
        public string AccountKeySecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the sas token is stored.
        /// Note: When provided, 'sasToken' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sasTokenSecretId")]
        public string SasTokenSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the client secret is stored.
        /// Note: When provided, 'clientSecret' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientSecretSecretId")]
        public string ClientSecretSecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AZURE_DATA_LAKE_STORAGE";
    }
}
