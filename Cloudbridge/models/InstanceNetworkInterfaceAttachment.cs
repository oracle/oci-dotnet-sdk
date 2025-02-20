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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// Describes a network interface attachment.
    /// </summary>
    public class InstanceNetworkInterfaceAttachment 
    {
        
        /// <value>
        /// The ID of the network interface attachment.
        /// </value>
        [JsonProperty(PropertyName = "attachmentKey")]
        public string AttachmentKey { get; set; }
        
        /// <value>
        /// The timestamp when the attachment initiated.
        /// </value>
        [JsonProperty(PropertyName = "timeAttach")]
        public System.Nullable<System.DateTime> TimeAttach { get; set; }
        
        /// <value>
        /// Indicates whether the network interface is deleted when the instance is terminated.
        /// </value>
        [JsonProperty(PropertyName = "isDeleteOnTermination")]
        public System.Nullable<bool> IsDeleteOnTermination { get; set; }
        
        /// <value>
        /// The index of the device on the instance for the network interface attachment.
        /// </value>
        [JsonProperty(PropertyName = "deviceIndex")]
        public System.Nullable<int> DeviceIndex { get; set; }
        
        /// <value>
        /// The index of the network card.
        /// </value>
        [JsonProperty(PropertyName = "networkCardIndex")]
        public System.Nullable<int> NetworkCardIndex { get; set; }
        
        /// <value>
        /// The attachment state.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
    }
}
