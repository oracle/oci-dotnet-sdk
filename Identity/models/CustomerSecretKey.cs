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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A `CustomerSecretKey` is an Oracle-provided key for using the Object Storage Service's
    /// [Amazon S3 compatible API](https://docs.cloud.oracle.com/Content/Object/Tasks/s3compatibleapi.htm). The key consists of a
    /// secret key/access key pair. A user can have up to two secret keys at a time.
    /// <br/>
    /// **Note:** The secret key is always an Oracle-generated string; you can't change it to a string of your choice.
    /// <br/>
    /// For more information, see [Managing User Credentials](https://docs.cloud.oracle.com/Content/Identity/access/managing-user-credentials.htm).
    /// 
    /// </summary>
    public class CustomerSecretKey 
    {
        
        /// <value>
        /// The secret key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The access key portion of the key pair.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the user the password belongs to.
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// The display name you assign to the secret key. Does not have to be unique, and it's changeable.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Date and time the `CustomerSecretKey` object was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time when this password will expire, in the format defined by RFC3339.
        /// Null if it never expires.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
                ///
        /// <value>
        /// The secret key's current state. After creating a secret key, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The secret key's current state. After creating a secret key, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The detailed status of INACTIVE lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }
        
    }
}
