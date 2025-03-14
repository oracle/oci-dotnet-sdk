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


namespace Oci.CoreService.Models
{
    
    public class AttachIScsiVolumeDetails : AttachVolumeDetails
    {
        
        /// <value>
        /// Whether to use CHAP authentication for the volume attachment. Defaults to false.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "useChap")]
        public System.Nullable<bool> UseChap { get; set; }
        
        /// <value>
        /// Refer the top-level definition of encryptionInTransitType.
        /// The default value is NONE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionInTransitType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EncryptionInTransitType> EncryptionInTransitType { get; set; }
        
        /// <value>
        /// Whether to enable Oracle Cloud Agent to perform the iSCSI login and logout commands after the volume attach or detach operations for non multipath-enabled iSCSI attachments.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAgentAutoIscsiLoginEnabled")]
        public System.Nullable<bool> IsAgentAutoIscsiLoginEnabled { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "iscsi";
    }
}
