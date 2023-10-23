/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// Describes the modification parameters for the Autonomous Container Database.
    /// 
    /// </summary>
    public class UpdateAutonomousContainerDatabaseDetails 
    {
        
        /// <value>
        /// The display name for the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// Database Patch model preference.
        /// </value>
        ///
        public enum PatchModelEnum {
            [EnumMember(Value = "RELEASE_UPDATES")]
            ReleaseUpdates,
            [EnumMember(Value = "RELEASE_UPDATE_REVISIONS")]
            ReleaseUpdateRevisions
        };

        /// <value>
        /// Database Patch model preference.
        /// </value>
        [JsonProperty(PropertyName = "patchModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PatchModelEnum> PatchModel { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowDetails")]
        public MaintenanceWindow MaintenanceWindowDetails { get; set; }
        
        /// <value>
        /// The scheduling detail for the quarterly maintenance window of the standby Autonomous Container Database.
        /// This value represents the number of days before schedlued maintenance of the primary database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "standbyMaintenanceBufferInDays")]
        public System.Nullable<int> StandbyMaintenanceBufferInDays { get; set; }
                ///
        /// <value>
        /// The next maintenance version preference.
        /// 
        /// </value>
        ///
        public enum VersionPreferenceEnum {
            [EnumMember(Value = "NEXT_RELEASE_UPDATE")]
            NextReleaseUpdate,
            [EnumMember(Value = "LATEST_RELEASE_UPDATE")]
            LatestReleaseUpdate
        };

        /// <value>
        /// The next maintenance version preference.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versionPreference")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VersionPreferenceEnum> VersionPreference { get; set; }
        
        /// <value>
        /// Indicates if an automatic DST Time Zone file update is enabled for the Autonomous Container Database. If enabled along with Release Update, patching will be done in a Non-Rolling manner.
        /// </value>
        [JsonProperty(PropertyName = "isDstFileUpdateEnabled")]
        public System.Nullable<bool> IsDstFileUpdateEnabled { get; set; }
        
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
        
        [JsonProperty(PropertyName = "backupConfig")]
        public AutonomousContainerDatabaseBackupConfig BackupConfig { get; set; }
        
    }
}
