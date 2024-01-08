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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Backup Policy as optionally used for DB System update.
    /// 
    /// </summary>
    public class UpdateBackupPolicyDetails 
    {
        
        /// <value>
        /// Specifies if automatic backups are enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The start of a 30-minute window of time in which daily, automated backups occur.
        /// <br/>
        /// This should be in the format of the \"Time\" portion of an RFC3339-formatted timestamp. Any second or sub-second time data will be truncated to zero.
        /// <br/>
        /// At some point in the window, the system may incur a brief service disruption as the backup is performed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "windowStartTime")]
        public string WindowStartTime { get; set; }
        
        /// <value>
        /// Number of days to retain an automatic backup.
        /// </value>
        [JsonProperty(PropertyName = "retentionInDays")]
        public System.Nullable<int> RetentionInDays { get; set; }
        
        /// <value>
        /// Simple key-value pair applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// <br/>
        /// Tags defined here will be copied verbatim as tags on the Backup resource created by this BackupPolicy.
        /// <br/>
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// <br/>
        /// Tags defined here will be copied verbatim as tags on the Backup resource created by this BackupPolicy.
        /// <br/>
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "pitrPolicy")]
        public PitrPolicy PitrPolicy { get; set; }
        
    }
}
