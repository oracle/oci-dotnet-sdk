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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// Kerberos details needed to create configuration.
    /// 
    /// </summary>
    public class CreateKerberosDetails 
    {
        
        /// <value>
        /// The Kerberos realm that the mount target will join.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KerberosRealm is required.")]
        [JsonProperty(PropertyName = "kerberosRealm")]
        public string KerberosRealm { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the keytab Secret in the Vault.
        /// </value>
        [JsonProperty(PropertyName = "keyTabSecretId")]
        public string KeyTabSecretId { get; set; }
        
        /// <value>
        /// Version of the keytab Secret in the Vault to use.
        /// </value>
        [JsonProperty(PropertyName = "currentKeyTabSecretVersion")]
        public System.Nullable<int> CurrentKeyTabSecretVersion { get; set; }
        
        /// <value>
        /// Version of the keytab Secret in the Vault to use as a backup.
        /// </value>
        [JsonProperty(PropertyName = "backupKeyTabSecretVersion")]
        public System.Nullable<int> BackupKeyTabSecretVersion { get; set; }
        
        /// <value>
        /// Specifies whether to enable or disable Kerberos.
        /// </value>
        [JsonProperty(PropertyName = "isKerberosEnabled")]
        public System.Nullable<bool> IsKerberosEnabled { get; set; }
        
    }
}
