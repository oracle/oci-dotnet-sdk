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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Monthly backup policy
    /// </summary>
    public class MonthlyBackupPolicy : BackupPolicy
    {
        
        /// <value>
        /// Hour of the day when backup starts.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupStart is required.")]
        [JsonProperty(PropertyName = "backupStart")]
        public string BackupStart { get; set; }
        
        /// <value>
        /// Days of the month when backup should start.
        /// If the day is greater last day of the current month, then it will be triggered on the last day of the current month
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DaysOfTheMonth is required.")]
        [JsonProperty(PropertyName = "daysOfTheMonth")]
        public System.Collections.Generic.List<int> DaysOfTheMonth { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "MONTHLY";
    }
}