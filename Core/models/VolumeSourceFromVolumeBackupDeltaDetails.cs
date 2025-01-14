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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Specifies the volume backups (first & second) and block size in bytes.
    /// </summary>
    public class VolumeSourceFromVolumeBackupDeltaDetails : VolumeSourceDetails
    {
        
        /// <value>
        /// The OCID of the first volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FirstBackupId is required.")]
        [JsonProperty(PropertyName = "firstBackupId")]
        public string FirstBackupId { get; set; }
        
        /// <value>
        /// The OCID of the second volume backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecondBackupId is required.")]
        [JsonProperty(PropertyName = "secondBackupId")]
        public string SecondBackupId { get; set; }
        
        /// <value>
        /// Block size in bytes to be considered while performing volume restore. The value must be a power of 2; ranging from 4KB (4096 bytes) to 1MB (1048576 bytes). If omitted, defaults to 4,096 bytes (4 KiB).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "changeBlockSizeInBytes")]
        public System.Nullable<long> ChangeBlockSizeInBytes { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "volumeBackupDelta";
    }
}
