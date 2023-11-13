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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The properties for a file system member of a DR protection group.
    /// 
    /// </summary>
    public class DrProtectionGroupMemberFileSystem : DrProtectionGroupMember
    {
        
        /// <value>
        /// The availability domain of the destination mount target.
        ///   
        /// Example: BBTh:region-AD
        /// </value>
        [JsonProperty(PropertyName = "destinationAvailabilityDomain")]
        public string DestinationAvailabilityDomain { get; set; }
        
        /// <value>
        /// A list of mappings between the primary region file system export and destination region mount target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportMappings")]
        public System.Collections.Generic.List<FileSystemExportMapping> ExportMappings { get; set; }
        
        [JsonProperty(PropertyName = "memberType")]
        private readonly string memberType = "FILE_SYSTEM";
    }
}