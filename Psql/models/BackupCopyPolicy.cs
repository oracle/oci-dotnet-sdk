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
    /// Backup copy details
    /// </summary>
    public class BackupCopyPolicy 
    {
        
        /// <value>
        /// target compartment to place a new backup
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Retention period in days of the backup copy.
        /// </value>
        [JsonProperty(PropertyName = "retentionPeriod")]
        public System.Nullable<int> RetentionPeriod { get; set; }
        
        /// <value>
        /// List of region names of the remote region
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
    }
}
