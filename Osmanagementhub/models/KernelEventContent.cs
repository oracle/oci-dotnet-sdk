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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides information collected for the kernel event.
    /// </summary>
    public class KernelEventContent : EventContent
    {
                ///
        /// <value>
        /// Crash content availability status:
        ///     * 'NOT_AVAILABLE' indicates the content is not available on the instance nor in the service
        ///     * 'AVAILABLE_ON_INSTANCE' indicates the content is only available on the instance.
        ///     * 'AVAILABLE_ON_SERVICE' indicates the content is only available on the service.
        ///     * 'AVAILABLE_ON_INSTANCE_AND_SERVICE' indicates the content is available both on the instance and the service
        ///     * 'AVAILABLE_ON_INSTANCE_UPLOAD_IN_PROGRESS' indicates the content is available on the instance and its upload to the service is in progress.
        /// 
        /// </value>
        ///
        public enum ContentAvailabilityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_AVAILABLE")]
            NotAvailable,
            [EnumMember(Value = "AVAILABLE_ON_INSTANCE")]
            AvailableOnInstance,
            [EnumMember(Value = "AVAILABLE_ON_SERVICE")]
            AvailableOnService,
            [EnumMember(Value = "AVAILABLE_ON_INSTANCE_AND_SERVICE")]
            AvailableOnInstanceAndService,
            [EnumMember(Value = "AVAILABLE_ON_INSTANCE_UPLOAD_IN_PROGRESS")]
            AvailableOnInstanceUploadInProgress
        };

        /// <value>
        /// Crash content availability status:
        ///     * 'NOT_AVAILABLE' indicates the content is not available on the instance nor in the service
        ///     * 'AVAILABLE_ON_INSTANCE' indicates the content is only available on the instance.
        ///     * 'AVAILABLE_ON_SERVICE' indicates the content is only available on the service.
        ///     * 'AVAILABLE_ON_INSTANCE_AND_SERVICE' indicates the content is available both on the instance and the service
        ///     * 'AVAILABLE_ON_INSTANCE_UPLOAD_IN_PROGRESS' indicates the content is available on the instance and its upload to the service is in progress.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContentAvailability is required.")]
        [JsonProperty(PropertyName = "contentAvailability")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ContentAvailabilityEnum> ContentAvailability { get; set; }
        
        /// <value>
        /// Location of the Kernel event content.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContentLocation is required.")]
        [JsonProperty(PropertyName = "contentLocation")]
        public string ContentLocation { get; set; }
        
        /// <value>
        /// Size of the event content.
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<int> Size { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "KERNEL";
    }
}
