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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details to update a database.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateDatabaseDetails 
    {
        
        [JsonProperty(PropertyName = "dbBackupConfig")]
        public DbBackupConfig DbBackupConfig { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Home.
        /// </value>
        [JsonProperty(PropertyName = "dbHomeId")]
        public string DbHomeId { get; set; }
        
        /// <value>
        /// A new strong password for SYS, SYSTEM, and the plugbable database ADMIN user. The password must be at least nine characters and contain at least two uppercase, two lowercase, two numeric, and two special characters. The special characters must be _, \\#, or -.
        /// </value>
        [JsonProperty(PropertyName = "newAdminPassword")]
        public string NewAdminPassword { get; set; }
        
        /// <value>
        /// The existing TDE wallet password. You must provide the existing password in order to set a new TDE wallet password.
        /// </value>
        [JsonProperty(PropertyName = "oldTdeWalletPassword")]
        public string OldTdeWalletPassword { get; set; }
        
        /// <value>
        /// The new password to open the TDE wallet. The password must be at least nine characters and contain at least two uppercase, two lowercase, two numeric, and two special characters. The special characters must be _, \\#, or -.
        /// </value>
        [JsonProperty(PropertyName = "newTdeWalletPassword")]
        public string NewTdeWalletPassword { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
