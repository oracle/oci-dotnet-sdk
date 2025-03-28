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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class CompartmentMetadata 
    {
        
        /// <value>
        /// The compartment id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The access level.
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "accessible")]
            Accessible,
            [EnumMember(Value = "visible")]
            Visible,
            [EnumMember(Value = "inaccessible")]
            Inaccessible
        };

        /// <value>
        /// The access level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessLevel is required.")]
        [JsonProperty(PropertyName = "accessLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
    }
}
