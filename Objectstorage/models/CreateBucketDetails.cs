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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class CreateBucketDetails 
    {
        
        /// <value>
        /// The name of the bucket. Valid characters are uppercase or lowercase letters, numbers, hyphens, underscores, and periods.
        /// Bucket names must be unique within an Object Storage namespace. Avoid entering confidential information.
        /// Example: 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The ID of the compartment in which to create the bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Arbitrary string, up to 4KB, of keys and values for user-defined metadata.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
                ///
        /// <value>
        /// The type of public access enabled on this bucket.
        /// A bucket is set to `NoPublicAccess` by default, which only allows an authenticated caller to access the
        /// bucket and its contents. When `ObjectRead` is enabled on the bucket, public access is allowed for the
        /// `GetObject`, `HeadObject`, and `ListObjects` operations. When `ObjectReadWithoutList` is enabled on the bucket,
        /// public access is allowed for the `GetObject` and `HeadObject` operations.
        /// 
        /// </value>
        ///
        public enum PublicAccessTypeEnum {
            [EnumMember(Value = "NoPublicAccess")]
            NoPublicAccess,
            [EnumMember(Value = "ObjectRead")]
            ObjectRead,
            [EnumMember(Value = "ObjectReadWithoutList")]
            ObjectReadWithoutList
        };

        /// <value>
        /// The type of public access enabled on this bucket.
        /// A bucket is set to `NoPublicAccess` by default, which only allows an authenticated caller to access the
        /// bucket and its contents. When `ObjectRead` is enabled on the bucket, public access is allowed for the
        /// `GetObject`, `HeadObject`, and `ListObjects` operations. When `ObjectReadWithoutList` is enabled on the bucket,
        /// public access is allowed for the `GetObject` and `HeadObject` operations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicAccessType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PublicAccessTypeEnum> PublicAccessType { get; set; }
                ///
        /// <value>
        /// The type of storage tier of this bucket.
        /// A bucket is set to 'Standard' tier by default, which means the bucket will be put in the standard storage tier.
        /// When 'Archive' tier type is set explicitly, the bucket is put in the Archive Storage tier. The 'storageTier'
        /// property is immutable after bucket is created.
        /// 
        /// </value>
        ///
        public enum StorageTierEnum {
            [EnumMember(Value = "Standard")]
            Standard,
            [EnumMember(Value = "Archive")]
            Archive
        };

        /// <value>
        /// The type of storage tier of this bucket.
        /// A bucket is set to 'Standard' tier by default, which means the bucket will be put in the standard storage tier.
        /// When 'Archive' tier type is set explicitly, the bucket is put in the Archive Storage tier. The 'storageTier'
        /// property is immutable after bucket is created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageTier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageTierEnum> StorageTier { get; set; }
        
        /// <value>
        /// Whether or not events are emitted for object state changes in this bucket. By default, `objectEventsEnabled` is
        /// set to `false`. Set `objectEventsEnabled` to `true` to emit events for object state changes. For more information
        /// about events, see [Overview of Events](https://docs.cloud.oracle.com/Content/Events/Concepts/eventsoverview.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectEventsEnabled")]
        public System.Nullable<bool> ObjectEventsEnabled { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a master encryption key used to call the Key
        /// Management service to generate a data encryption key or to encrypt or decrypt a data encryption key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
                ///
        /// <value>
        /// Set the versioning status on the bucket. By default, a bucket is created with versioning `Disabled`. Use this option to enable versioning during bucket creation. Objects in a version enabled bucket are protected from overwrites and deletions. Previous versions of the same object will be available in the bucket.
        /// 
        /// </value>
        ///
        public enum VersioningEnum {
            [EnumMember(Value = "Enabled")]
            Enabled,
            [EnumMember(Value = "Disabled")]
            Disabled
        };

        /// <value>
        /// Set the versioning status on the bucket. By default, a bucket is created with versioning `Disabled`. Use this option to enable versioning during bucket creation. Objects in a version enabled bucket are protected from overwrites and deletions. Previous versions of the same object will be available in the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versioning")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VersioningEnum> Versioning { get; set; }
        
        /// <value>
        /// Set the auto tiering status on the bucket. By default, a bucket is created with auto tiering `Disabled`.
        /// Use this option to enable auto tiering during bucket creation. Objects in a bucket with auto tiering set to
        /// `InfrequentAccess` are transitioned automatically between the 'Standard' and 'InfrequentAccess'
        /// tiers based on the access pattern of the objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autoTiering")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Bucket.AutoTieringEnum> AutoTiering { get; set; }
        
    }
}
