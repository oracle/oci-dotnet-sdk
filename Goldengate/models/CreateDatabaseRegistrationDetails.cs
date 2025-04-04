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
    /// The information about a new DatabaseRegistration.
    /// 
    /// </summary>
    public class CreateDatabaseRegistrationDetails 
    {
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists
        /// for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A three-label Fully Qualified Domain Name (FQDN) for a resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Fqdn is required.")]
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }
        
        /// <value>
        /// The private IP address in the customer's VCN of the customer's endpoint, typically a
        /// database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the target subnet of the dedicated connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated system of the given technology.
        /// This username must already exist and be available by the system/application to be connected to
        /// and must conform to the case sensitivty requirments defined in it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password Oracle GoldenGate uses to connect the associated system of the given technology.
        /// It must conform to the specific security requirements including length, case sensitivity, and so on.
        /// Deprecated: This field is deprecated and replaced by \"passwordSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// Connect descriptor or Easy Connect Naming method used to connect to a database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
                ///
        /// <value>
        /// The mode of the database connection session to be established by the data client.
        /// 'REDIRECT' - for a RAC database, 'DIRECT' - for a non-RAC database.
        /// Connection to a RAC database involves a redirection received from the SCAN listeners
        /// to the database node to connect to. By default the mode would be DIRECT.
        /// 
        /// </value>
        ///
        public enum SessionModeEnum {
            [EnumMember(Value = "DIRECT")]
            Direct,
            [EnumMember(Value = "REDIRECT")]
            Redirect
        };

        /// <value>
        /// The mode of the database connection session to be established by the data client.
        /// 'REDIRECT' - for a RAC database, 'DIRECT' - for a non-RAC database.
        /// Connection to a RAC database involves a redirection received from the SCAN listeners
        /// to the database node to connect to. By default the mode would be DIRECT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sessionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SessionModeEnum> SessionMode { get; set; }
        
        /// <value>
        /// The wallet contents Oracle GoldenGate uses to make connections to a database.
        /// This attribute is expected to be base64 encoded.
        /// Deprecated: This field is deprecated and replaced by \"walletSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "wallet")]
        public string Wallet { get; set; }
        
        /// <value>
        /// Credential store alias.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AliasName is required.")]
        [JsonProperty(PropertyName = "aliasName")]
        public string AliasName { get; set; }
        
        /// <value>
        /// Refers to the customer's vault OCID. 
        /// If provided, it references a vault where GoldenGate can manage secrets. Customers must add policies to permit GoldenGate
        /// to manage secrets contained within this vault.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// Refers to the customer's master key OCID. 
        /// If provided, it references a key to manage secrets. Customers must add policies to permit GoldenGate to use this key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The OCID of the compartment where the GoldenGate Secret will be created. 
        /// If provided, it references a key to manage secrets. Customers must add policies to permit GoldenGate to use this key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "secretCompartmentId")]
        public string SecretCompartmentId { get; set; }
        
    }
}
