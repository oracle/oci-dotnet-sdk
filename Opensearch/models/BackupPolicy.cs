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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// Backup policy as optionally used for Opensearch cluster.
    /// 
    /// </summary>
    public class BackupPolicy 
    {
        
        /// <value>
        /// Specifies if automatic backups are enabled.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Specifies how long backup copy should remain on Storage in days
        /// </value>
        [JsonProperty(PropertyName = "retentionInDays")]
        public System.Nullable<int> RetentionInDays { get; set; }
        
        /// <value>
        /// Specifies how often backup should be performed
        /// </value>
        [JsonProperty(PropertyName = "frequencyInHours")]
        public System.Nullable<int> FrequencyInHours { get; set; }
        
    }
}
