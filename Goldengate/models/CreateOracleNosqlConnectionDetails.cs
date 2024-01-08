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
    /// The information about a new Oracle NoSQL Connection.
    /// 
    /// </summary>
    public class CreateOracleNosqlConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Oracle NoSQL technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OracleNosqlConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related OCI tenancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// The name of the region. e.g.: us-ashburn-1
        /// 
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the OCI user who will access the Oracle NoSQL database.
        /// The user must have write access to the table they want to connect to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// The base64 encoded content of the private key file (PEM file) corresponding to the API key of the fingerprint.
        /// See documentation: https://docs.oracle.com/en-us/iaas/Content/Identity/Tasks/managingcredentials.htm
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateKeyFile is required.")]
        [JsonProperty(PropertyName = "privateKeyFile")]
        public string PrivateKeyFile { get; set; }
        
        /// <value>
        /// The passphrase of the private key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateKeyPassphrase")]
        public string PrivateKeyPassphrase { get; set; }
        
        /// <value>
        /// The fingerprint of the API Key of the user specified by the userId.
        /// See documentation: https://docs.oracle.com/en-us/iaas/Content/Identity/Tasks/managingcredentials.htm
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicKeyFingerprint is required.")]
        [JsonProperty(PropertyName = "publicKeyFingerprint")]
        public string PublicKeyFingerprint { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "ORACLE_NOSQL";
    }
}
