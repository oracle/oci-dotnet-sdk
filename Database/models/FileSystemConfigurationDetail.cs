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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the file system configuration of the VM cluster.
    /// </summary>
    public class FileSystemConfigurationDetail 
    {
        
        /// <value>
        /// The mount point of file system.
        /// </value>
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; set; }
        
        /// <value>
        /// The file system size to be allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "fileSystemSizeGb")]
        public System.Nullable<int> FileSystemSizeGb { get; set; }
        
    }
}
