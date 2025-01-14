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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Daily backup policy.
    /// </summary>
    public class DailyBackupPolicy : BackupPolicy
    {
        
        /// <value>
        /// Hour of the day when the backup starts.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupStart is required.")]
        [JsonProperty(PropertyName = "backupStart")]
        public string BackupStart { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "DAILY";
    }
}
