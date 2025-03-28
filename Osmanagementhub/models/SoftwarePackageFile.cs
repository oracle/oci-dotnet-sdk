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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// A file associated with a package.
    /// </summary>
    public class SoftwarePackageFile 
    {
        
        /// <value>
        /// File path.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// Type of the file.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// The date and time the file was last modified (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
        /// <value>
        /// Checksum of the file.
        /// </value>
        [JsonProperty(PropertyName = "checksum")]
        public string Checksum { get; set; }
        
        /// <value>
        /// Type of the checksum.
        /// </value>
        [JsonProperty(PropertyName = "checksumType")]
        public string ChecksumType { get; set; }
        
        /// <value>
        /// Size of the file in bytes.
        /// </value>
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
        
    }
}
