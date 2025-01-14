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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to create a tablespace.
    /// It takes either credentialDetails or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class CreateTablespaceDetails 
    {
        
        [JsonProperty(PropertyName = "credentialDetails")]
        public TablespaceAdminCredentialDetails CredentialDetails { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
        /// <value>
        /// The name of the tablespace. It must be unique within a database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The type of tablespace.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "PERMANENT")]
            Permanent,
            [EnumMember(Value = "TEMPORARY")]
            Temporary
        };

        /// <value>
        /// The type of tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Specifies whether the tablespace is a bigfile or smallfile tablespace.
        /// A bigfile tablespace contains only one data file or temp file, which can contain up to approximately 4 billion (232) blocks.
        /// A smallfile tablespace is a traditional Oracle tablespace, which can contain 1022 data files or temp files, each of which can contain up to approximately 4 million (222) blocks.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBigfile")]
        public System.Nullable<bool> IsBigfile { get; set; }
        
        /// <value>
        /// The list of data files or temp files created for the tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataFiles")]
        public System.Collections.Generic.List<string> DataFiles { get; set; }
        
        /// <value>
        /// The number of data files or temp files created for the tablespace. This is for Oracle Managed Files only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fileCount")]
        public System.Nullable<int> FileCount { get; set; }
        
        /// <value>
        /// The size of each data file or temp file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fileSize")]
        public TablespaceStorageSize FileSize { get; set; }
        
        /// <value>
        /// Specifies whether Oracle can reuse the data file or temp file. Reuse is only allowed when the file name is provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isReusable")]
        public System.Nullable<bool> IsReusable { get; set; }
        
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
        
        /// <value>
        /// Block size for the tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockSizeInKilobytes")]
        public System.Nullable<int> BlockSizeInKilobytes { get; set; }
        
        /// <value>
        /// Indicates whether the tablespace is encrypted.
        /// </value>
        [JsonProperty(PropertyName = "isEncrypted")]
        public System.Nullable<bool> IsEncrypted { get; set; }
        
        /// <value>
        /// The name of the encryption algorithm to be used for tablespace encryption.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public string EncryptionAlgorithm { get; set; }
                ///
        /// <value>
        /// The default compression of data for all tables created in the tablespace.
        /// 
        /// </value>
        ///
        public enum DefaultCompressEnum {
            [EnumMember(Value = "NO_COMPRESS")]
            NoCompress,
            [EnumMember(Value = "BASIC_COMPRESS")]
            BasicCompress
        };

        /// <value>
        /// The default compression of data for all tables created in the tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultCompress")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DefaultCompressEnum> DefaultCompress { get; set; }
                ///
        /// <value>
        /// The status of the tablespace.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "READ_ONLY")]
            ReadOnly,
            [EnumMember(Value = "READ_WRITE")]
            ReadWrite
        };

        /// <value>
        /// The status of the tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// Specifies how the extents of the tablespace should be managed.
        /// 
        /// </value>
        ///
        public enum ExtentManagementEnum {
            [EnumMember(Value = "AUTOALLOCATE")]
            Autoallocate,
            [EnumMember(Value = "UNIFORM")]
            Uniform
        };

        /// <value>
        /// Specifies how the extents of the tablespace should be managed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extentManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExtentManagementEnum> ExtentManagement { get; set; }
        
        /// <value>
        /// The size of the extent when the tablespace is managed with uniform extents of a specific size.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extentUniformSize")]
        public TablespaceStorageSize ExtentUniformSize { get; set; }
                ///
        /// <value>
        /// Specifies whether tablespace segment management should be automatic or manual.
        /// 
        /// </value>
        ///
        public enum SegmentManagementEnum {
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "MANUAL")]
            Manual
        };

        /// <value>
        /// Specifies whether tablespace segment management should be automatic or manual.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "segmentManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SegmentManagementEnum> SegmentManagement { get; set; }
        
        /// <value>
        /// Specifies whether the tablespace is the default tablespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
