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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Used to remove a resource lock.
    /// Resource locks are used to prevent certain APIs from being called for the resource.
    /// A full lock prevents both updating the resource and deleting the resource. A delete
    /// lock prevents deleting the resource.
    /// 
    /// </summary>
    public class RemoveResourceLockDetails 
    {
                ///
        /// <value>
        /// Type of the lock.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "DELETE")]
            Delete
        };

        /// <value>
        /// Type of the lock.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
