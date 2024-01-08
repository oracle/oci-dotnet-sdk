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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class ObjectVersionSummary 
    {
        
        /// <value>
        /// The name of the object. Avoid entering confidential information.
        /// Example: test/object1.log
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Size of the object in bytes.
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<long> Size { get; set; }
        
        /// <value>
        /// Base64-encoded MD5 hash of the object data.
        /// </value>
        [JsonProperty(PropertyName = "md5")]
        public string Md5 { get; set; }
        
        /// <value>
        /// The date and time the object was created, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.29).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the object was modified, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616#section-14.29).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeModified is required.")]
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
        /// <value>
        /// The current entity tag (ETag) for the object.
        /// </value>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }
        
        /// <value>
        /// The storage tier that the object is stored in.
        /// </value>
        [JsonProperty(PropertyName = "storageTier")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StorageTier> StorageTier { get; set; }
        
        /// <value>
        /// Archival state of an object. This field is set only for objects in Archive tier.
        /// </value>
        [JsonProperty(PropertyName = "archivalState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchivalState> ArchivalState { get; set; }
        
        /// <value>
        /// VersionId of the object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VersionId is required.")]
        [JsonProperty(PropertyName = "versionId")]
        public string VersionId { get; set; }
        
        /// <value>
        /// This flag will indicate if the version is deleted or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDeleteMarker is required.")]
        [JsonProperty(PropertyName = "isDeleteMarker")]
        public System.Nullable<bool> IsDeleteMarker { get; set; }
        
    }
}
