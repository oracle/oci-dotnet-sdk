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
    /// The information to update a Azure Data Lake Storage Connection.
    /// 
    /// </summary>
    public class UpdateAzureDataLakeStorageConnectionDetails : UpdateConnectionDetails
    {
        
        /// <value>
        /// Used authentication mechanism to access Azure Data Lake Storage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AzureDataLakeStorageConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// Sets the Azure storage account name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }
        
        /// <value>
        /// Azure storage account key. This property is required when 'authenticationType' is set to 'SHARED_KEY'.
        /// e.g.: pa3WbhVATzj56xD4DH1VjOUhApRGEGHvOo58eQJVWIzX+j8j4CUVFcTjpIqDSRaSa1Wo2LbWY5at+AStEgLOIQ==
        /// Deprecated: This field is deprecated and replaced by \"accountKeySecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the account key is stored.
        /// Note: When provided, 'accountKey' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accountKeySecretId")]
        public string AccountKeySecretId { get; set; }
        
        /// <value>
        /// Credential that uses a shared access signature (SAS) to authenticate to an Azure Service. This property is
        /// required when 'authenticationType' is set to 'SHARED_ACCESS_SIGNATURE'.
        /// e.g.: ?sv=2020-06-08&ss=bfqt&srt=sco&sp=rwdlacupyx&se=2020-09-10T20:27:28Z&st=2022-08-05T12:27:28Z&spr=https&sig=C1IgHsiLBmTSStYkXXGLTP8it0xBrArcgCqOsZbXwIQ%3D
        /// Deprecated: This field is deprecated and replaced by \"sasTokenSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sasToken")]
        public string SasToken { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the sas token is stored.
        /// Note: When provided, 'sasToken' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sasTokenSecretId")]
        public string SasTokenSecretId { get; set; }
        
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
        /// Azure client secret (aka application password) for authentication. This property is required when 'authenticationType' is set to 'AZURE_ACTIVE_DIRECTORY'.
        /// e.g.: dO29Q~F5-VwnA.lZdd11xFF_t5NAXCaGwDl9NbT1
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
        /// Azure Storage service endpoint.
        /// e.g: https://test.blob.core.windows.net
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AZURE_DATA_LAKE_STORAGE";
    }
}
