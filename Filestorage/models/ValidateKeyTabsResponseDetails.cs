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
    /// Validate keytabs response details.
    /// </summary>
    public class ValidateKeyTabsResponseDetails 
    {
        
        /// <value>
        /// An array of keytab entries (principal, encryptionType, keyVersionNumber).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentKerberosKeytabEntries is required.")]
        [JsonProperty(PropertyName = "currentKerberosKeytabEntries")]
        public System.Collections.Generic.List<KerberosKeytabEntry> CurrentKerberosKeytabEntries { get; set; }
        
        /// <value>
        /// An array of keytab entries (principal, encryptionType, keyVersionNumber).
        /// </value>
        [JsonProperty(PropertyName = "backupKerberosKeytabEntries")]
        public System.Collections.Generic.List<KerberosKeytabEntry> BackupKerberosKeytabEntries { get; set; }
        
    }
}
