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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Properties used to update MACsec settings.
    /// </summary>
    public class UpdateMacsecProperties 
    {
        
        /// <value>
        /// Indicates whether or not MACsec is enabled.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "State is required.")]
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MacsecState> State { get; set; }
        
        [JsonProperty(PropertyName = "primaryKey")]
        public UpdateMacsecKey PrimaryKey { get; set; }
        
        /// <value>
        /// Type of encryption cipher suite to use for the MACsec connection.
        /// </value>
        [JsonProperty(PropertyName = "encryptionCipher")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MacsecEncryptionCipher> EncryptionCipher { get; set; }
        
    }
}
