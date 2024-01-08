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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to resize a data file or temp file within the tablespace.
    /// 
    /// </summary>
    public class ResizeDataFileDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialDetails is required.")]
        [JsonProperty(PropertyName = "credentialDetails")]
        public TablespaceAdminCredentialDetails CredentialDetails { get; set; }
                ///
        /// <value>
        /// Specifies whether the file is a data file or temp file.
        /// 
        /// </value>
        ///
        public enum FileTypeEnum {
            [EnumMember(Value = "DATAFILE")]
            Datafile,
            [EnumMember(Value = "TEMPFILE")]
            Tempfile
        };

        /// <value>
        /// Specifies whether the file is a data file or temp file.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileType is required.")]
        [JsonProperty(PropertyName = "fileType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FileTypeEnum> FileType { get; set; }
        
        /// <value>
        /// Name of the data file or temp file to be resized.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataFile is required.")]
        [JsonProperty(PropertyName = "dataFile")]
        public string DataFile { get; set; }
        
        /// <value>
        /// The new size of the data file or temp file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fileSize")]
        public TablespaceStorageSize FileSize { get; set; }
        
        /// <value>
        /// Specifies whether the data file or temp file can be extended automatically.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoExtensible")]
        public System.Nullable<bool> IsAutoExtensible { get; set; }
        
        /// <value>
        /// The size of the next increment of disk space to be allocated automatically when more extents are required.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autoExtendNextSize")]
        public TablespaceStorageSize AutoExtendNextSize { get; set; }
        
        /// <value>
        /// The maximum disk space allowed for automatic extension of the data files or temp files.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autoExtendMaxSize")]
        public TablespaceStorageSize AutoExtendMaxSize { get; set; }
        
        /// <value>
        /// Specifies whether the disk space of the data file or temp file can be limited.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMaxSizeUnlimited")]
        public System.Nullable<bool> IsMaxSizeUnlimited { get; set; }
        
    }
}
